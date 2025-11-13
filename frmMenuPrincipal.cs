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
        public frmMenuPrincipal() {
            InitializeComponent();
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
    }
}
