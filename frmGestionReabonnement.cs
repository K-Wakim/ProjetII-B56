using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetII_B56
{
    public partial class frmGestionReabonnement : Form
    {

        DataClassesCclubGolfDataContext db = new DataClassesCclubGolfDataContext();

        public frmGestionReabonnement()
        {
            InitializeComponent();
        }

        private void reabonnementsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reabonnementsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Pr211DataSet);

        }

        private void frmGestionReabonnement_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Pr211DataSet.Reabonnements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            // this.reabonnementsTableAdapter.Fill(this.bDB56Pr211DataSet.Reabonnements);

            // --------------------------------------------------------------------------
            // Charger le table de réabonnement avec LINQ to SQL
            // --------------------------------------------------------------------------

            var reabonnementsList = db.Reabonnements
                                    .Select(reab => new
                                    {
                                        reab.DateRenouvellement,
                                        reab.IdAbonnement,
                                        reab.Remarque
                                    })
                                    .ToList();
            
            reabonnementsDataGridView.AutoGenerateColumns = true;
            reabonnementsDataGridView.DataSource = reabonnementsList;

            var abonnementsList = db.Abonnements
                                  .Where(abo => !db.Reabonnements
                                    .GroupBy(r => new { r.IdAbonnement, Annee = r.DateRenouvellement.Year })
                                    .Any(g => g.Key.IdAbonnement == abo.Id && g.Count() > 1))
                                  .Select(abo => new
                                  {
                                     abo.Id,
                                     abo.DateAbonnement,
                                     abo.Nom,
                                     abo.Prenom,
                                     abo.Courriel,
                                     abo.TypesAbonnement.Description
                                  })
                                  .Where(abo => abo.Id.Contains("P"))
                                  .ToList();


            abonnementsDataGridView.AutoGenerateColumns = true;
            abonnementsDataGridView.DataSource = abonnementsList;

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRenouvellerAbonne_Click(object sender, EventArgs e)
        {
            // --------------------------------------------------------------------------
            // Ajouter une row au table Reabonnements
            // --------------------------------------------------------------------------

            if (abonnementsDataGridView.SelectedRows.Count == 1)
            {
                try
                {
                    DataGridViewRow selectedRow = abonnementsDataGridView.SelectedRows[0];

                    var reabonnement = new Reabonnements
                    {
                        DateRenouvellement = DateTime.Now,
                        IdAbonnement = selectedRow.Cells[0].Value.ToString(),
                        Remarque = "Renouvellement automatique"
                    };

                    db.Reabonnements.InsertOnSubmit(reabonnement);
                    db.SubmitChanges();

                    MessageBox.Show("Abonnement renouvellé avec succès!");

                    frmGestionReabonnement_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du renouvellement de l'abonnement: " + ex.Message);
                }


            }
            else if (abonnementsDataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selectionez seulement un abonnement à renouveller!");
            }
            else
            {
                MessageBox.Show("Selectionez un abonnement à renouveller!");
            }
        }

        private void btnAjouterRemarque_Click(object sender, EventArgs e)
        {
            // --------------------------------------------------------------------------
            // Ajouter une remarque à une réabonnement
            // --------------------------------------------------------------------------

            if (abonnementsDataGridView.SelectedRows.Count == 1)
            {
                try
                {
                    MessageBox.Show(reabonnementsDataGridView.SelectedRows[0].Cells[1].Value.ToString());

                    var reabonnement = db.Reabonnements
                                       .SingleOrDefault(a => a.IdAbonnement == reabonnementsDataGridView.SelectedRows[0].Cells[1].Value.ToString());

                    if (String.IsNullOrWhiteSpace(txtRemarque.Text))
                    {
                        throw new Exception("Veillez remplir le champ");
                    }

                    if (reabonnement != null)
                    {
                        reabonnement.Remarque = txtRemarque.Text;
                        db.SubmitChanges();
                        MessageBox.Show("Remarque ajoutée avec succès!");
                        frmGestionReabonnement_Load(sender, e);
                    }
                    else
                    {
                        throw new Exception("Abonnement non trouvé.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout d'un remarque: " + ex.Message);
                }


            }
            else if (abonnementsDataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selectionez seulement un réabonnement!");
            }
            else
            {
                MessageBox.Show("Selectionez un réabonnement!");
            }
        }
    }
}
