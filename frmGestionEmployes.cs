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
            // TODO: cette ligne de code charge les données dans la table 'bDB56Pr211DataSet.Employes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employesTableAdapter.Fill(this.bDB56Pr211DataSet.Employes);

        }

        private void btnAjoutEmploye_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmAjouterEmploye()).ShowDialog();
            this.Show();
        }

        private void btnModifierEmploye_Click(object sender, EventArgs e)
        {
            if (employesBindingSource.Current == null)
            {
                MessageBox.Show("Veuillez sélectionner un employé.");
                return;
            }

            DataRowView drv = (DataRowView)employesBindingSource.Current;
            var row = (BDB56Pr211DataSet.EmployesRow)((DataRowView)drv).Row;

            this.Hide();
            var frm = new frmModifieEmploye(row);
            frm.ShowDialog();
            this.Show();
        }



        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimerEmploye_Click(object sender, EventArgs e)
        {
            if (employesBindingSource.Current == null)
            {
                MessageBox.Show("Veuillez sélectionner un employé à supprimer.");
                return;
            }

            // Obtenir la ligne sélectionnée
            DataRowView drv = (DataRowView)employesBindingSource.Current;
            int noEmploye = (int)drv["No"];
            string nom = drv["Nom"].ToString();
            string prenom = drv["Prenom"].ToString();
            if (noEmploye ==1)
            {
                MessageBox.Show("Veuillez sélectionner un employé à supprimer qui n'est pas l'admin.");
                return;
            }
            if(user.No == noEmploye)
            {
                MessageBox.Show("vous ne pouvez pas vous supprimez");
                return;
            }
            // Confirmation
            DialogResult rep = MessageBox.Show(
                $"Voulez-vous vraiment supprimer l'employé :\n{prenom} {nom} (No {noEmploye}) ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (rep == DialogResult.Yes)
            {
                try
                {
                    // Supprimer dans le BindingSource
                    employesBindingSource.RemoveCurrent();

                    // Mettre à jour la BD
                    employesTableAdapter.Update(bDB56Pr211DataSet.Employes);

                    MessageBox.Show("Employé supprimé avec succès !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Suppression annulée.");
            }
        }
    }
}
