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
    public partial class frmRapports : Form
    {
        public frmRapports()
        {
            InitializeComponent();

            this.employesTableAdapter1.Fill( this.bDB56Pr211DataSet.Employes );

            // Check if column doesn't already exist
            if(!this.bDB56Pr211DataSet.Employes.Columns.Contains( "NomComplet" )) {
                this.bDB56Pr211DataSet.Employes.Columns.Add( "NomComplet", typeof( string ), "Prenom + ' ' + Nom" );
            }

            cbEmploye.DataSource = this.bDB56Pr211DataSet.Employes;
            cbEmploye.DisplayMember = "NomComplet";
            cbEmploye.ValueMember = "No";

            this.depenseParEmpTableAdapter.Fill( this.bDB56Pr211DataSet.DepenseParEmp, Convert.ToInt32(cbEmploye.SelectedValue) );
        }
    }
}
