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
    public partial class frmModifieEmploye : Form
    {
        public frmModifieEmploye()
        {
            InitializeComponent();
        }

        private void employesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Pr211DataSet);

        }

        private void employesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.employesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Pr211DataSet);

        }

        private void frmModifieEmploye_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Pr211DataSet.Employes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employesTableAdapter.Fill(this.bDB56Pr211DataSet.Employes);

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
