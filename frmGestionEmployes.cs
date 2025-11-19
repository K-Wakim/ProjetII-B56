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
        public frmGestionEmployes()
        {
            InitializeComponent();
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
            this.Hide();
            (new frmModifieEmploye()).ShowDialog();
            this.Show();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimerEmploye_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez-vous supprimer cet employe?", "Supprimation d'un employe", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Cet fonction n'est pas implementer!");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Supprimation annuler!");
            }
        }
    }
}
