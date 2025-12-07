using ProjetII_B56.Properties;
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

    public partial class frmRapports : Form {
        private DataClassesCclubGolfDataContext _context = new DataClassesCclubGolfDataContext( Settings.Default.connexion );

        public frmRapports() {
            InitializeComponent();
            var nomComplet = _context.Employes.Select( e => new {
                e.No,
                NomComplet = e.Prenom + " " + e.Nom
            } );

            cbEmploye.DataSource = nomComplet.ToList();
            cbEmploye.DisplayMember = "NomComplet";
            cbEmploye.ValueMember = "No";

            var result = _context.Depenses
                .Join( _context.Services,
                    d => d.NoService,
                    s => s.No,
                    ( d, s ) => new { d, s } )
                .Join( _context.Abonnements,
                    ds => ds.d.IdAbonnement,
                    a => a.Id,
                    ( ds, a ) => new { ds.d, ds.s, a } )
                .Where( x => x.s.NoEmploye == Convert.ToInt32( cbEmploye.SelectedValue ) )
                .Select( x => new {
                    x.s.TypeService,
                    x.d.Montant,
                    x.d.DateDepense,
                    NomComplet = x.a.Prenom + " " + x.a.Nom
                } );

            depenseParEmpDataGridView.DataSource = result.ToList();
        }

        private void cbEmploye_SelectedValueChanged( object sender, EventArgs e ) {

            if(cbEmploye.SelectedValue == null)
                return;

            dynamic selectedItem = cbEmploye.SelectedItem;
            int noEmp = selectedItem.No;


            var result = _context.Depenses
                .Join( _context.Services,
                    d => d.NoService,
                    s => s.No,
                    ( d, s ) => new { d, s } )
                .Join( _context.Abonnements,
                    ds => ds.d.IdAbonnement,
                    a => a.Id,
                    ( ds, a ) => new { ds.d, ds.s, a } )
                .Where( x => x.s.NoEmploye == noEmp )
                .Select( x => new {
                    x.s.TypeService,
                    x.d.Montant,
                    x.d.DateDepense,
                    NomComplet = x.a.Prenom + " " + x.a.Nom
                } );

            depenseParEmpDataGridView.DataSource = result.ToList();
        }
    }
}