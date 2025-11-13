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

        private int typeUser;

        public frmMenuPrincipal(int NoTypeUser) {
            InitializeComponent();
            this.typeUser = NoTypeUser;
        }

        private void frmMenuPrincipal_FormClosing( object sender, FormClosingEventArgs e ) {
            Application.Exit();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (this.typeUser == 1 || this.typeUser == 2)
            {
                btnGestionEmploye.Enabled = true;
                btnGestionEmploye.Visible = true;
            }
        }
    }
}
