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


            bool _Deconnect = false;

        private BDB56Pr211DataSet.EmployesRow user;


        public frmMenuPrincipal(BDB56Pr211DataSet.EmployesRow user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnDeconnection_Click( object sender, EventArgs e ) {
            _Deconnect = true;
            this.Close();
        }

        private void frmMenuPrincipal_FormClosing( object sender, FormClosingEventArgs e ) {
            if(_Deconnect) {
                return;
            } else {
                Application.Exit();
            }
        }

        private void btnSortie_Click( object sender, EventArgs e ) {
            this.Close();
        }

        private void btnGestionEmploye_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmGestionEmployes(user)).ShowDialog();
            this.Show();
        }

        private void btnAbonnement_Click(object sender, EventArgs e)
        {
            // Si une exception est levée, relancer l'application
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
            this.Hide();
            (new frmInscriptionPartieGolfJouee()).ShowDialog();
            this.Show();
        }

        private void btnInscDepense_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmInscriptionDepense(user)).ShowDialog();
            this.Show();
        }

        private void btnVisiStats_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmStatisque()).ShowDialog();
            this.Show();
        }

        private void btnVisiRapports_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmRapports()).ShowDialog();
            this.Show();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (user.NoTypeEmploye != 1 && user.NoTypeEmploye != 2)
            {
                btnGestionEmploye.Enabled = false; // Désactive le bouton
                btnGestionEmploye.BackColor = Color.LightGray; // Optionnel : griser le bouton
                btnGestionEmploye.Text += " (Accès restreint)";
            }
            if (user.NoTypeEmploye != 1 && user.NoTypeEmploye != 3 && user.NoTypeEmploye != 4)
            {
                btnAbonnement.Enabled = false; // Désactive le bouton
                btnAbonnement.BackColor = Color.LightGray; // Optionnel : griser le bouton
                btnAbonnement.Text += " (Accès restreint)";
            }
            if (user.NoTypeEmploye != 1 && user.NoTypeEmploye != 3 && user.NoTypeEmploye != 4)
            {
                btnReabonnement.Enabled = false; // Désactive le bouton
                btnReabonnement.BackColor = Color.LightGray; // Optionnel : griser le bouton
                btnReabonnement.Text += " (Accès restreint)";
            }
            if (user.NoTypeEmploye != 1 && user.NoTypeEmploye != 3 && user.NoTypeEmploye != 4)
            {
                btnMiseAJourAbonne.Enabled = false; // Désactive le bouton
                btnMiseAJourAbonne.BackColor = Color.LightGray; // Optionnel : griser le bouton
                btnMiseAJourAbonne.Text += " (Accès restreint)";
            }
            if (user.NoTypeEmploye != 1 && user.NoTypeEmploye != 2 && user.NoTypeEmploye != 3)
            {
                btnModPrix.Enabled = false; // Désactive le bouton
                btnModPrix.BackColor = Color.LightGray; // Optionnel : griser le bouton
                btnModPrix.Text += " (Accès restreint)";
            }
            if (user.NoTypeEmploye != 1 && user.NoTypeEmploye != 3 && user.NoTypeEmploye != 4)
            {
                btnInscGolfJouer.Enabled = false; // Désactive le bouton
                btnInscGolfJouer.BackColor = Color.LightGray; // Optionnel : griser le bouton
                btnInscGolfJouer.Text += " (Accès restreint)";
            }
            if (user.NoTypeEmploye == 4)
            {
                btnInscDepense.Enabled = false; // Désactive le bouton
                btnInscDepense.BackColor = Color.LightGray; // Optionnel : griser le bouton
                btnInscDepense.Text += " (Accès restreint)";
            }
            if (user.NoTypeEmploye != 1 && user.NoTypeEmploye != 2 && user.NoTypeEmploye != 3)
            {
                btnVisiRapports.Enabled = false; // Désactive le bouton
                btnVisiRapports.BackColor = Color.LightGray; // Optionnel : griser le bouton
                btnVisiRapports.Text += " (Accès restreint)";
            }
            if (user.NoTypeEmploye != 1 && user.NoTypeEmploye != 2 && user.NoTypeEmploye != 3)
            {
                btnVisiStats.Enabled = false; // Désactive le bouton
                btnVisiStats.BackColor = Color.LightGray; // Optionnel : griser le bouton
                btnVisiStats.Text += " (Accès restreint)";
            }
        }

/*        private void btnDeconnection_Click(object sender, EventArgs e)
        {
            this.Close(); // Ferme cette fenêtre

            // Ouvre la fenêtre de connexion
            var frmConn = new frmConnection();
            frmConn.Show();
        }*/


/*        private void btnSortie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }*/
        // private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e) { Application.Exit(); }
    }
}
