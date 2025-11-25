using ProjetII_B56.BDB56Pr211DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // TODO: cette ligne de code charge les données dans la table 'bDB56Pr211DataSet.Services'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.servicesTableAdapter.Fill(this.bDB56Pr211DataSet.Services);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Pr211DataSet.Abonnements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.abonnementsTableAdapter.Fill(this.bDB56Pr211DataSet.Abonnements);
            
            if(user.NoTypeEmploye ==1 || user.NoTypeEmploye == 2 || user.NoTypeEmploye == 3) {
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
                if(user.NoTypeEmploye ==5 )
                {
                    lblTypeService.Text = "Magasin Pro Shop";
                }
                else if (user.NoTypeEmploye ==6 )
                {
                    lblTypeService.Text = "Restaurent";
                }
                else if (user.NoTypeEmploye==7 )
                {
                    lblTypeService.Text = "Leçon de golf";
                }
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
                SqlTransaction trans = conn.BeginTransaction();

                // Associer transaction + connexion
                servicesTableAdapter.Connection = conn;
                servicesTableAdapter.Transaction = trans;

                depensesTA.Connection = conn;
                depensesTA.Transaction = trans;

                try
                {
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
                        .Where(s => s.NoEmploye == user.No &&
                                    s.TypeService.ToLower() == typeService.ToLower())
                        .FirstOrDefault();

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

                    // 3. Ajouter dépense
                    int nextDepense = bDB56Pr211DataSet.Depenses.Count == 0 ?
                                      1 :
                                      bDB56Pr211DataSet.Depenses.Max(d => d.No) + 1;

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

                    // Form info
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

        private decimal CalculerTotalDepenses(string idAbo)
        {
            return bDB56Pr211DataSet.Depenses
                .Where(d => d.IdAbonnement == idAbo)
                .Sum(d => d.Montant);
        }


        private decimal MontantRestant(string idAbo)
        {
            // 1. Chercher l'abonnement
            var abo = bDB56Pr211DataSet.Abonnements
                .First(a => a.Id == idAbo);

            // 2. Chercher le type d'abonnement
            int idTypeAbo = abo.NoTypeAbonnement;

            // 3. Aller chercher MontantExige dans PrixDepenseAbonnement
            var prix = bDB56Pr211DataSet.PrixDepensesAbonnements
                .First(p => p.NoTypeAbonnement == idTypeAbo);

            decimal montantExige = prix.DepensesObligatoires;

            // 4. Somme des dépenses déjà effectuées
            decimal totalDepenses = CalculerTotalDepenses(idAbo);

            // 5. Résultat
            return montantExige - totalDepenses;
        }





    }
}
