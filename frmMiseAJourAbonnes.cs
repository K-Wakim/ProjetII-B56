using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetII_B56
{
    public partial class frmMiseAJourAbonnes : Form
    {
        DataClassesCclubGolfDataContext db = new DataClassesCclubGolfDataContext();

        public frmMiseAJourAbonnes()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abonnementsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.abonnementsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Pr211DataSet);

        }

        private void frmMiseAJourAbonnes_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Pr211DataSet.Abonnements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            // this.abonnementsTableAdapter.Fill(this.bDB56Pr211DataSet.Abonnements);

            // --------------------------------------------------------------------------
            // Charger le table des abonnés avec LINQ to SQL
            // --------------------------------------------------------------------------

            var abonnementsPrincipaleList = db.Abonnements
                                            .Select(abo => new
                                            {
                                                abo.Id,
                                                abo.DateNaissance,
                                                abo.Nom,
                                                abo.Prenom,
                                                abo.Sexe,
                                                abo.NoCivique,
                                                abo.Rue,
                                                abo.Ville,
                                                abo.IdProvince,
                                                abo.NoTypeAbonnement,
                                                abo.DateAbonnement,
                                                abo.Telephone,
                                                abo.Cellulaire,
                                                abo.Courriel,
                                                abo.CodePostal,
                                                abo.Remarque
                                            });

            abonnementsPrincipaleDataGridView.AutoGenerateColumns = true;

            abonnementsPrincipaleDataGridView.DataSource = abonnementsPrincipaleList;

        }

        private void abonnementsPrincipaleDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // --------------------------------------------------------------------------
            // Charger la liste dependant selon l'abonné sélectionné
            // --------------------------------------------------------------------------

            dependantsDataGridView.ClearSelection();

            try
            {
                var selectedRows = abonnementsPrincipaleDataGridView.SelectedRows;

                if (selectedRows.Count == 1)
                {
                    var dependants = db.Dependants
                                    .Where(dependant => dependant.IdAbonnement == selectedRows[0].Cells[0].Value.ToString())
                                    .Select(dependant => new
                                    {
                                        dependant.Id,
                                        dependant.Nom,
                                        dependant.Prenom,
                                        dependant.DateNaissance,
                                        dependant.IdAbonnement,
                                        dependant.Remarque
                                    });

                    dependantsDataGridView.AutoGenerateColumns = true;
                    dependantsDataGridView.DataSource = dependants;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans la chargement des dependants: " + ex.Message, "ERREUR");
            }
        }

        private void btnModifierAbonne_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedAbonnementRow = abonnementsPrincipaleDataGridView.SelectedRows[0];

            try
            {
                if (selectedAbonnementRow != null)
                {
                    this.Hide();
                    (new frmModifierAbonnementDependant("Abonnement", selectedAbonnementRow)).ShowDialog();
                    this.Show();
                }
                else
                {
                    throw new Exception("Veillez choisir une abonnement à modifier!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sélection du row à modifier: " + ex.Message, "Erreur");
            }
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            frmMiseAJourAbonnes_Load(sender, e);
        }

        private void dependantsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            abonnementsPrincipaleDataGridView.ClearSelection();
        }

        private void btnModifierDependant_Click(object sender, EventArgs e)
        {
            //TODO
            DataGridViewRow selectedDependantRow = dependantsDataGridView.SelectedRows[0];

            try
            {
                if (selectedDependantRow != null)
                {
                    this.Hide();
                    (new frmModifierAbonnementDependant("Dependant", selectedDependantRow)).ShowDialog();
                    this.Show();
                }
                else
                {
                    throw new Exception("Veillez choisir un dépendant à modifier!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sélection du row à modifier: " + ex.Message, "Erreur");


            }
        }
    }
}
