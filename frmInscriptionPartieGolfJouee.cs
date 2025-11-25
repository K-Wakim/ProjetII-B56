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
    public partial class frmInscriptionPartieGolfJouee : Form
    {
        public frmInscriptionPartieGolfJouee()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void terrainsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.terrainsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Pr211DataSet);

        }

        private void frmInscriptionPartieGolfJouee_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Pr211DataSet.Abonnements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.abonnementsTableAdapter.Fill(this.bDB56Pr211DataSet.Abonnements);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Pr211DataSet.PartiesJouees'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.partiesJoueesTableAdapter.Fill(this.bDB56Pr211DataSet.PartiesJouees);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Pr211DataSet.Terrains'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.terrainsTableAdapter.Fill(this.bDB56Pr211DataSet.Terrains);

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

        }
    }
}
