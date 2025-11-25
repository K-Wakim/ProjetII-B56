using ProjetII_B56.BDB56Pr211DataSetTableAdapters;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ProjetII_B56
{
    public partial class frmInscriptionDepense : Form
    {
        BDB56Pr211DataSetTableAdapters.DepensesTableAdapter depensesTA = new DepensesTableAdapter();
        private BDB56Pr211DataSet.EmployesRow user;

        public frmInscriptionDepense(BDB56Pr211DataSet.EmployesRow user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInscriptionDepense_Load(object sender, EventArgs e)
        {
            this.servicesTableAdapter.Fill(this.bDB56Pr211DataSet.Services);
            this.abonnementsTableAdapter.Fill(this.bDB56Pr211DataSet.Abonnements);

            // Gestion de l'affichage selon type d'employé
            if (user.NoTypeEmploye >= 1 && user.NoTypeEmploye <= 3)
            {
                cbTypesServices.Enabled = true;
                cbTypesServices.Visible = true;
                lblTypeService.Enabled = false;
                lblTypeService.Visible = false;
            }
            else
            {
                cbTypesServices.Visible = false;
                lblTypeService.Visible = true;
                lblTypeService.Enabled = true;

                if (user.NoTypeEmploye == 5)
                    lblTypeService.Text = "Magasin Pro Shop";
                else if (user.NoTypeEmploye == 6)
                    lblTypeService.Text = "Restaurant";
                else if (user.NoTypeEmploye == 7)
                    lblTypeService.Text = "Leçon de golf";
                else
                    lblTypeService.Text = "";
            }
        }

        string connectionString = Properties.Settings.Default.connexion;

        private void btnDepense_Click(object sender, EventArgs e)
        {
            // Vérifications de base
            if (cboNomAbo.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un abonné.");
                return;
            }

            if (nudDepense.Value <= 0 || nudDepense.Value > 1000)
            {
                MessageBox.Show("Le montant doit être entre 0.01$ et 1000$.");
                return;
            }

            string idAbo = cboNomAbo.SelectedValue.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        // Associer les TableAdapters à la transaction
                        servicesTableAdapter.Connection = conn;
                        servicesTableAdapter.Transaction = trans;
                        depensesTA.Connection = conn;
                        depensesTA.Transaction = trans;

                        // Déterminer le type de service
                        string typeService;
                        if (user.NoTypeEmploye == 5)
                            typeService = "Magasin Pro Shop";
                        else if (user.NoTypeEmploye == 6)
                            typeService = "Restaurant";
                        else if (user.NoTypeEmploye == 7)
                            typeService = "Leçon de golf";
                        else
                            typeService = cbTypesServices.Text;

                        // Chercher service existant
                        var existingService = bDB56Pr211DataSet.Services
                            .FirstOrDefault(s => s.NoEmploye == user.No &&
                                                 s.TypeService.Trim().ToLower() == typeService.Trim().ToLower());

                        int noService;
                        if (existingService != null)
                        {
                            noService = existingService.No;
                        }
                        else
                        {
                            // Nouveau service
                            int nextService = bDB56Pr211DataSet.Services.Count == 0
                                ? 1
                                : bDB56Pr211DataSet.Services.Max(s => s.No) + 1;

                            var newService = bDB56Pr211DataSet.Services.NewServicesRow();
                            newService.No = nextService;
                            newService.TypeService = typeService;
                            newService.NoEmploye = user.No;

                            bDB56Pr211DataSet.Services.AddServicesRow(newService);
                            servicesTableAdapter.Update(bDB56Pr211DataSet.Services);

                            noService = nextService;
                        }

                        // Créer la dépense (No est identity, pas besoin de le définir)
                        var dep = bDB56Pr211DataSet.Depenses.NewDepensesRow();
                        dep.IdAbonnement = idAbo;
                        dep.NoService = noService;
                        dep.DateDepense = DateTime.Today;
                        dep.Montant = nudDepense.Value;

                        if (!string.IsNullOrWhiteSpace(rtbRemarque.Text))
                            dep.Remarque = rtbRemarque.Text;
                        else
                            dep.SetRemarqueNull(); // permet DBNull si Remarque est vide

                        bDB56Pr211DataSet.Depenses.AddDepensesRow(dep);
                        depensesTA.Update(bDB56Pr211DataSet.Depenses);

                        trans.Commit();

                        // Rafraîchir les données locales
                        servicesTableAdapter.Fill(bDB56Pr211DataSet.Services);
                        depensesTA.Fill(bDB56Pr211DataSet.Depenses);

                        // Calcul du total et montant restant
                        decimal totalDepenses = CalculerTotalDepenses(idAbo);
                        decimal montantRestant = MontantRestant(idAbo);

                        // Afficher info
                        frmInfoDepense f = new frmInfoDepense(
                            cboNomAbo.Text,
                            dep.DateDepense,
                            dep.Montant,
                            typeService,
                            $"{user.Prenom} {user.Nom}",
                            totalDepenses,
                            montantRestant
                        );
                        f.ShowDialog();

                        MessageBox.Show("Dépense enregistrée !");
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            trans.Rollback();
                        }
                        catch
                        {
                            // La transaction peut déjà être terminée
                        }
                        //MessageBox.Show("Erreur : " + ex.Message);
                    }
                    MessageBox.Show("Dépense enregistrée !");
                    this.Close();
                }
            }
        }

        private decimal CalculerTotalDepenses(string idAbo)
        {
            return bDB56Pr211DataSet.Depenses
                .Where(d => d.IdAbonnement == idAbo)
                .Sum(d => d.Montant);
        }

        private decimal MontantRestant(string idAbo)
        {
            var abo = bDB56Pr211DataSet.Abonnements.FirstOrDefault(a => a.Id == idAbo);
            if (abo == null) return 0;

            var prix = bDB56Pr211DataSet.PrixDepensesAbonnements
                .FirstOrDefault(p => p.NoTypeAbonnement == abo.NoTypeAbonnement);
            if (prix == null) return 0;

            return prix.DepensesObligatoires - CalculerTotalDepenses(idAbo);
        }
    }
}
