using ProjetII_B56.BDB56Pr211DataSetTableAdapters;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ProjetII_B56
{
    public partial class frmInscriptionDepense : Form
    {
        DataClassesCclubGolfDataContext db = new DataClassesCclubGolfDataContext();
        private BDB56Pr211DataSet.EmployesRow user; // toujours l'employé connecté


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
            // Charger les abonnements
            var abonnements = db.Abonnements
                                .Select(a => new
                                {
                                    a.Id,
                                    NomComplet = a.Nom + " " + a.Prenom
                                })
                                .ToList();
            cboNomAbo.DataSource = abonnements;
            cboNomAbo.DisplayMember = "NomComplet";
            cboNomAbo.ValueMember = "Id";

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

            try
            {
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

                // Chercher un service existant
                var service = db.Services
                                .FirstOrDefault(s => s.NoEmploye == user.No &&
                                                     s.TypeService.Trim().ToLower() == typeService.Trim().ToLower());

                if (service == null)
                {
                    service = new Services
                    {
                        TypeService = typeService,
                        NoEmploye = user.No
                    };
                    db.Services.InsertOnSubmit(service);
                    db.SubmitChanges();
                }

                // Créer la dépense
                var depense = new Depenses
                {
                    IdAbonnement = idAbo,
                    NoService = service.No,
                    DateDepense = DateTime.Today,
                    Montant = nudDepense.Value,
                    Remarque = string.IsNullOrWhiteSpace(rtbRemarque.Text) ? null : rtbRemarque.Text
                };

                db.Depenses.InsertOnSubmit(depense);
                db.SubmitChanges();

                // Calculer total et montant restant
                decimal totalDepenses = db.Depenses
                                          .Where(d => d.IdAbonnement == idAbo)
                                          .Sum(d => d.Montant);

                var abo = db.Abonnements.FirstOrDefault(a => a.Id == idAbo);
                decimal montantRestant = 0;
                if (abo != null)
                {
                    var prix = db.PrixDepensesAbonnements
                                .FirstOrDefault(p => p.NoTypeAbonnement == abo.NoTypeAbonnement);
                    if (prix != null)
                        montantRestant = prix.DepensesObligatoires - totalDepenses;
                }

                // Afficher info
                frmInfoDepense f = new frmInfoDepense(
                    cboNomAbo.Text,
                    depense.DateDepense,
                    depense.Montant,
                    typeService,
                    $"{user.Prenom} {user.Nom}",
                    totalDepenses,
                    montantRestant
                );
                f.ShowDialog();

                MessageBox.Show("Dépense enregistrée !");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
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
