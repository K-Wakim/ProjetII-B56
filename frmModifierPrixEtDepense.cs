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
                    int oldYear = Convert.ToInt32(row.Cells["Annee"].Value);

                    decimal prix;
                    decimal depenses;

                    if (!decimal.TryParse(row.Cells["Prix"].Value?.ToString(), out prix) || prix < 0)
                    {
                        MessageBox.Show($"Prix invalide à la ligne {row.Index + 1}");
                        return;
                    }

                    if (!decimal.TryParse(row.Cells["DepensesObligatoires"].Value?.ToString(), out depenses) || depenses < 0)
                    {
                        MessageBox.Show($"Dépenses obligatoires invalides à la ligne {row.Index + 1}");
                        return;
                    }

                    string remarque = row.Cells["Remarque"].Value?.ToString() ?? "";

                    // Récupérer l'ancien record
                    var oldRecord = db.PrixDepensesAbonnements
                        .FirstOrDefault(p => p.NoTypeAbonnement == noTypeAbonnement && p.Annee == oldYear);

                    if (oldRecord == null)
                    {
                        MessageBox.Show($"Aucun enregistrement trouvé pour l'abonnement {noTypeAbonnement}");
                        continue;
                    }

                    bool modified =
                        oldRecord.Prix != prix ||
                        oldRecord.DepensesObligatoires != depenses ||
                        (oldRecord.Remarque ?? "") != remarque;

                    if (!modified) continue;

                    // Vérifier si l'année courante existe déjà
                    bool existsCurrentYear = db.PrixDepensesAbonnements
                        .Any(p => p.NoTypeAbonnement == noTypeAbonnement && p.Annee == currentYear);

                    if (existsCurrentYear)
                    {
                        MessageBox.Show($"Une ligne existe déjà pour {noTypeAbonnement} en {currentYear}.");
                        continue;
                    }

                    // ➜ CRÉATION D'UN NOUVEL ENREGISTREMENT
                    var newRecord = new PrixDepensesAbonnements
                    {
                        NoTypeAbonnement = noTypeAbonnement,
                        Annee = currentYear,
                        Prix = prix,
                        DepensesObligatoires = depenses,
                        Remarque = remarque
                    };

                    db.PrixDepensesAbonnements.InsertOnSubmit(newRecord);
                }

                db.SubmitChanges();
                MessageBox.Show("Nouveaux enregistrements créés avec succès !");
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

            var prixDepenseAboList =
      db.PrixDepensesAbonnements
      .GroupBy(p => p.NoTypeAbonnement)
      .Select(g => g.OrderByDescending(p => p.Annee).First())
      .Select(pda => new PrixDepenseAboEditable
      {
          NoTypeAbonnement = pda.NoTypeAbonnement,
          Annee = pda.Annee,
          Prix = pda.Prix,
          DepensesObligatoires = pda.DepensesObligatoires,
          Remarque = pda.Remarque
      })
      .ToList();


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
