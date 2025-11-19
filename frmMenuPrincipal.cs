using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetII_B56 {
    public partial class frmMenuPrincipal : Form {
        public frmMenuPrincipal() {
            InitializeComponent();
        }

        private void frmMenuPrincipal_FormClosing( object sender, FormClosingEventArgs e ) {
            Application.Exit();
        }

        private void btnGestionEmploye_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmGestionEmployes()).ShowDialog();
            this.Show();
        }

        private void btnAbonnement_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmGestionAbonnement()).ShowDialog();
            this.Show();
        }

        private void btnReabonnement_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmGestionReabonnement()).ShowDialog();
            this.Show();
        }

        private void btnMiseAJourAbonne_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmMiseAJourAbonnes()).ShowDialog();
            this.Show();
        }

        private void btnModPrix_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmModifierPrixEtDepense()).ShowDialog();
            this.Show();
        }

        private void btnInscGolfJouer_Click(object sender, EventArgs e)
        {

        }

        private void btnInscDepense_Click(object sender, EventArgs e)
        {

        }

        private void btnVisiStats_Click(object sender, EventArgs e)
        {

        }

        private void btnVisiRapports_Click(object sender, EventArgs e)
        {

        }
    }
}
