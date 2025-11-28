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
    public partial class frmGestionEmployes : Form
    {
        private BDB56Pr211DataSet.EmployesRow user;
        DataClassesCclubGolfDataContext db = new DataClassesCclubGolfDataContext();
        public frmGestionEmployes(BDB56Pr211DataSet.EmployesRow user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void employesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Pr211DataSet);

        }
        private void frmGestionEmployes_Load(object sender, EventArgs e)
        {
            // Charger tous les employés depuis LINQ to SQL
            var employesList = db.Employes
                     .Select(emp => new
                     {
                         emp.No,
                         emp.MotDePasse,
                         emp.Nom,
                         emp.Prenom,
                         emp.Sexe,
                         emp.Age,
                         emp.NoCivique,
                         emp.Rue,
                         emp.Ville,
                         emp.IdProvince,
                         emp.CodePostal,
                         emp.Telephone,
                         emp.Cellulaire,
                         emp.Courriel,
                         emp.SalaireHoraire,
                         emp.NoTypeEmploye,
                         emp.Remarque
                     })
                     .ToList();


            // Désactiver l'auto-génération si tu veux gérer les colonnes toi-même
            dgvEmployes.AutoGenerateColumns = true;

            // Ajouter l'événement DataBindingComplete pour modifier l'entête
            dgvEmployes.DataBindingComplete -= dgvEmployes_DataBindingComplete; // éviter doublons
            dgvEmployes.DataBindingComplete += dgvEmployes_DataBindingComplete;

            // Définir la source de données
            dgvEmployes.DataSource = employesList;
        }

        // Cet événement se déclenche après que le DataGridView ait généré les colonnes
        private void dgvEmployes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvEmployes.Columns.Contains("NoTypeEmploye"))
                dgvEmployes.Columns["NoTypeEmploye"].HeaderText = "Type d'employé";
        }


        private void btnAjoutEmploye_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmAjouterEmploye()).ShowDialog();
            this.Show();
            frmGestionEmployes_Load(sender, e); // Recharger la grille après ajout
        }

        private void btnModifierEmploye_Click(object sender, EventArgs e)
        {
            if (dgvEmployes.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un employé.");
                return;
            }

            int noEmploye = (int)dgvEmployes.CurrentRow.Cells[0].Value;
            var emp = db.Employes.Single(em => em.No == noEmploye);


            this.Hide();
            var frm = new frmModifieEmploye(emp);
            frm.ShowDialog();
            this.Show();
            frmGestionEmployes_Load(sender, e); // Recharger la grille après modification
        }




        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimerEmploye_Click(object sender, EventArgs e)
        {
            if (dgvEmployes.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un employé à supprimer.");
                return;
            }

            int noEmploye = (int)dgvEmployes.CurrentRow.Cells["No"].Value;

            if (noEmploye == 1)
            {
                MessageBox.Show("Impossible de supprimer l'administrateur principal.");
                return;
            }

            if (user.No == noEmploye)
            {
                MessageBox.Show("Vous ne pouvez pas vous supprimer.");
                return;
            }

            var empToDelete = db.Employes.Single(emp => emp.No == noEmploye);

            DialogResult rep = MessageBox.Show(
                $"Voulez-vous vraiment supprimer l'employé :\n{empToDelete.Prenom} {empToDelete.Nom} (No {empToDelete.No}) ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (rep == DialogResult.Yes)
            {
                db.Employes.DeleteOnSubmit(empToDelete);
                db.SubmitChanges();

                MessageBox.Show("Employé supprimé avec succès !");
                frmGestionEmployes_Load(sender, e); // Recharger le DataGridView
            }
            else
            {
                MessageBox.Show("Suppression annulée.");
            }
        }

    }
}
