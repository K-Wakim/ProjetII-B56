using ProjetII_B56.BDB56Pr211DataSetTableAdapters;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ProjetII_B56
{
    public partial class frmInscriptionDepense : Form
    {
        BDB56Pr211DataSetTableAdapters.DepensesTableAdapter depensesTA = new BDB56Pr211DataSetTableAdapters.DepensesTableAdapter();

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

            if (user.NoTypeEmploye == 1 || user.NoTypeEmploye == 2 || user.NoTypeEmploye == 3)
            {
                cbTypesServices.Enabled = true;
                cbTypesServices.Visible = true;
                lblTypeService.Enabled = false;
                lblTypeService.Visible = false;
            }
            else
            {
                lblTypeService.Enabled = true;
                lblTypeService.Visible = true;
                cbTypesServices.Visible = false;
                if (user.NoTypeEmploye == 5)
                    lblTypeService.Text = "Magasin Pro Shop";
                else if (user.NoTypeEmploye == 6)
                    lblTypeService.Text = "Restaurent";
                else if (user.NoTypeEmploye == 7)
                    lblTypeService.Text = "Leçon de golf";
            }
        }

        private void btnDepense_Click(object sender, EventArgs e)
        {
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

            using (SqlConnection conn = new SqlConnection(servicesTableAdapter.Connection.ConnectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        // Associer transaction + connexion
                        servicesTableAdapter.Connection = conn;
                        servicesTableAdapter.Transaction = trans;

                        depensesTA.Connection = conn;
                        depensesTA.Transaction = trans;

                        // 1. Type de service
                        string typeService;
                        if (user.NoTypeEmploye == 5)
                            typeService = "Magasin Pro Shop";
                        else if (user.NoTypeEmploye == 6)
                            typeService = "Restaurant";
                        else if (user.NoTypeEmploye == 7)
                            typeService = "Leçon de golf";
                        else
                            typeService = cbTypesServices.Text;

                        // 2. Chercher service existant
                        var existing = bDB56Pr211DataSet.Services
                            .FirstOrDefault(s => s.NoEmploye == user.No &&
                                                 s.TypeService.Trim().ToLower() == typeService.Trim().ToLower());

                        int noService;

                        if (existing != null)
                        {
                            noService = existing.No;
                        }
                        else
                        {
                            // Nouveau service
                            int nextService = bDB56Pr211DataSet.Services.Count == 0 ?
                                              1 :
                                              bDB56Pr211DataSet.Services.Max(s => s.No) + 1;

                            var newService = bDB56Pr211DataSet.Services.NewServicesRow();
                            newService.No = nextService;
                            newService.TypeService = typeService;
                            newService.NoEmploye = user.No;

                            bDB56Pr211DataSet.Services.AddServicesRow(newService);
                            servicesTableAdapter.Update(bDB56Pr211DataSet.Services);

                            noService = nextService;
                        }

                        // 3. Obtenir le prochain numéro de dépense en base (sécurisé)
                        int nextDepense;
                        using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(No), 0) + 1 FROM Depenses", conn, trans))
                        {
                            nextDepense = (int)cmd.ExecuteScalar();
                        }

                        // 4. Créer nouvelle dépense
                        var dep = bDB56Pr211DataSet.Depenses.NewDepensesRow();
                        dep.No = nextDepense;
                        dep.IdAbonnement = idAbo;
                        dep.NoService = noService;
                        dep.DateDepense = DateTime.Today;
                        dep.Montant = nudDepense.Value;

                        if (!string.IsNullOrWhiteSpace(rtbRemarque.Text))
                            dep.Remarque = rtbRemarque.Text;
                        else
                            dep.SetRemarqueNull();

                        bDB56Pr211DataSet.Depenses.AddDepensesRow(dep);
                        depensesTA.Update(bDB56Pr211DataSet.Depenses);

                        trans.Commit();

                        // Rafraîchir données locales
                        servicesTableAdapter.Fill(bDB56Pr211DataSet.Services);
                        depensesTA.Fill(bDB56Pr211DataSet.Depenses);

                        // Afficher info
                        frmInfoDepense f = new frmInfoDepense(
                            cboNomAbo.Text,
                            dep.DateDepense,
                            dep.Montant,
                            typeService,
                            user.Prenom + " " + user.Nom,
                            CalculerTotalDepenses(idAbo),
                            MontantRestant(idAbo)
                        );
                        f.ShowDialog();

                        MessageBox.Show("Dépense enregistrée !");
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Erreur : " + ex.Message);
                    }
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
            var abo = bDB56Pr211DataSet.Abonnements
                .First(a => a.Id == idAbo);

            int idTypeAbo = abo.NoTypeAbonnement;

            var prix = bDB56Pr211DataSet.PrixDepensesAbonnements
                .First(p => p.NoTypeAbonnement == idTypeAbo);

            decimal montantExige = prix.DepensesObligatoires;

            decimal totalDepenses = CalculerTotalDepenses(idAbo);

            return montantExige - totalDepenses;
        }
    }
}
