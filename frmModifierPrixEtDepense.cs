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
    public partial class frmModifierPrixEtDepense : Form
    {
        DataClassesCclubGolfDataContext db = new DataClassesCclubGolfDataContext();

        public frmModifierPrixEtDepense()
        {
            InitializeComponent();
        }
        public class PrixDepenseAboEditable
        {
            public int NoTypeAbonnement { get; set; }
            public int Annee { get; set; }
            public decimal Prix { get; set; }
            public decimal DepensesObligatoires { get; set; }
            public string Remarque { get; set; }
        }


        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifierTypeAbo_Click(object sender, EventArgs e)
        {
            try
            {
                int currentYear = DateTime.Now.Year;

                foreach (DataGridViewRow row in dgvPrixDepenseAbo.Rows)
                {
                    if (row.IsNewRow) continue;

                    int noTypeAbonnement = Convert.ToInt32(row.Cells["NoTypeAbonnement"].Value);
                    int annee = Convert.ToInt32(row.Cells["Annee"].Value);

                    decimal prix;
                    decimal depensesObligatoires;

                    bool prixOk = decimal.TryParse(row.Cells["Prix"].Value?.ToString(), out prix);
                    bool depenseOk = decimal.TryParse(row.Cells["DepensesObligatoires"].Value?.ToString(), out depensesObligatoires);

                    if (!prixOk || prix < 0)
                    {
                        MessageBox.Show($"Prix invalide à la ligne {row.Index + 1}.");
                        return;
                    }
                    if (!depenseOk || depensesObligatoires < 0)
                    {
                        MessageBox.Show($"Dépenses obligatoires invalides à la ligne {row.Index + 1}.");
                        return;
                    }

                    string remarque = row.Cells["Remarque"].Value?.ToString();

                    // Récupérer l'enregistrement existant
                    var record = db.PrixDepensesAbonnements
                        .FirstOrDefault(p => p.NoTypeAbonnement == noTypeAbonnement && p.Annee == annee);

                    if (record != null)
                    {
                        // Vérifier si l'utilisateur a modifié prix, dépense ou remarque
                        bool isModified = record.Prix != prix || record.DepensesObligatoires != depensesObligatoires || record.Remarque != remarque;

                        if (isModified)
                        {
                            var existsCurrentYear = db.PrixDepensesAbonnements
                                .Any(p => p.NoTypeAbonnement == noTypeAbonnement && p.Annee == currentYear);

                            if (existsCurrentYear)
                            {
                                MessageBox.Show($"Impossible de mettre à jour l'année pour l'abonnement {noTypeAbonnement} : ligne déjà existante pour {currentYear}.");
                                continue;
                            }

                            string remarqueNonNull = remarque ?? "";

                            db.ExecuteCommand(@"
        UPDATE PrixDepensesAbonnements
        SET Annee = {0},
            Prix = {1},
            DepensesObligatoires = {2},
            Remarque = {3}
        WHERE NoTypeAbonnement = {4} AND Annee = {5}",
                                currentYear,
                                prix,
                                depensesObligatoires,
                                remarqueNonNull,
                                noTypeAbonnement,
                                annee);
                        }


                    }
                    else
                    {
                        MessageBox.Show($"Type d'abonné {noTypeAbonnement} inexistant pour l'année {annee}.");
                    }
                }

                MessageBox.Show("Modifications sauvegardées avec succès !");
                frmModifierPrixEtDepense_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sauvegarde : " + ex.Message);
            }
        }





        private void frmModifierPrixEtDepense_Load(object sender, EventArgs e)
        {
            var dgvTypeAboList = db.TypesAbonnement
                .Select(ta => new
                {
                    ta.No,
                    ta.Description,
                    ta.Remarque
                }).ToList();

            var prixDepenseAboList = db.PrixDepensesAbonnements
                .Select(pda => new PrixDepenseAboEditable
                {
                    NoTypeAbonnement = pda.NoTypeAbonnement,
                    Annee = pda.Annee,
                    Prix = pda.Prix,
                    DepensesObligatoires = pda.DepensesObligatoires,
                    Remarque = pda.Remarque
                }).ToList();

            BindingList<PrixDepenseAboEditable> bindingList = new BindingList<PrixDepenseAboEditable>(prixDepenseAboList);

            dgvPrixDepenseAbo.AutoGenerateColumns = false;
            dgvPrixDepenseAbo.Columns.Clear();

            // Colonnes clé (lecture seule)
            dgvPrixDepenseAbo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NoTypeAbonnement",           // <-- IMPORTANT
                DataPropertyName = "NoTypeAbonnement",
                HeaderText = "Type d'abonnement",
                ReadOnly = true
            });
            dgvPrixDepenseAbo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Annee",                      // <-- IMPORTANT
                DataPropertyName = "Annee",
                HeaderText = "Année",
                ReadOnly = true
            });

            // Colonnes éditables
            dgvPrixDepenseAbo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Prix",                        // <-- IMPORTANT
                DataPropertyName = "Prix",
                HeaderText = "Prix"
            });
            dgvPrixDepenseAbo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DepensesObligatoires",        // <-- IMPORTANT
                DataPropertyName = "DepensesObligatoires",
                HeaderText = "Dépenses obligatoires"
            });
            dgvPrixDepenseAbo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Remarque",                    // <-- IMPORTANT
                DataPropertyName = "Remarque",
                HeaderText = "Remarque"
            });

            dgvPrixDepenseAbo.DataSource = bindingList;
            dgvPrixDepenseAbo.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            dgvTypeAbo.DataSource = dgvTypeAboList;
        }



        private void dgvTypeAbo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvTypeAbo.Columns.Contains("Description"))
                dgvTypeAbo.Columns["Description"].HeaderText = "Description de l'abonnement";
            if (dgvTypeAbo.Columns.Contains("Remarque"))
                dgvTypeAbo.Columns["Remarque"].HeaderText = "Remarque";
        }

    }
}
