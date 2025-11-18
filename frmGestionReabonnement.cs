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
            this.reabonnementsTableAdapter.Fill(this.bDB56Pr211DataSet.Reabonnements);

        }
    }
}
