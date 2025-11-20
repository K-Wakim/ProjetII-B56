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
    public partial class frmConnection : Form {
        public frmConnection() {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "" || txtMotPasse.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs pour vous connecter");
                return;
            }

            var user = (from u in this.bDB56Pr211DataSet.Employes
                        where u.No.ToString() == txtUserName.Text && u.MotDePasse == txtMotPasse.Text
                        select u).FirstOrDefault();

            if (user != null)
            {
                this.Hide();
                frmMenuPrincipal menu = new frmMenuPrincipal(user); // <-- Passer l'objet user
                menu.ShowDialog();
                this.Show();
            }
            else {
                lblStatusConnection.Text = "Connection échoué";
            }
        }


        private void frmConnection_Load( object sender, EventArgs e ) {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Pr211DataSet.Employes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employesTableAdapter.Fill( this.bDB56Pr211DataSet.Employes );

        }

        private void btnQuitter_Click( object sender, EventArgs e ) {
            Application.Exit();
        }
    }
}
