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
    }
}
