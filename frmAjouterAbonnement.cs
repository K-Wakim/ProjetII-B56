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
    public partial class frmAjouterAbonnement : Form
    {
        public frmAjouterAbonnement()
        {
            InitializeComponent();
        }

        private void abonnementsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.abonnementsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Pr211DataSet);

        }

        private void frmAjouterAbonnement_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Pr211DataSet.Provinces'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.provincesTableAdapter.Fill(this.bDB56Pr211DataSet.Provinces);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Pr211DataSet.TypesAbonnement'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typesAbonnementTableAdapter.Fill(this.bDB56Pr211DataSet.TypesAbonnement);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Pr211DataSet.TypesAbonnement'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typesAbonnementTableAdapter.Fill(this.bDB56Pr211DataSet.TypesAbonnement);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Pr211DataSet.Abonnements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.abonnementsTableAdapter.Fill(this.bDB56Pr211DataSet.Abonnements);

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

        }
    }
}
