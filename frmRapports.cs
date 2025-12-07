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


            ////// DÉPENSES PAR EMPLOYÉ //////

            var nomCompletEmp = _context.Employes.Select( e => new {
                e.No,
                NomComplet = e.Prenom + " " + e.Nom
            } );

            cbEmploye.DataSource = nomCompletEmp.ToList();
            cbEmploye.DisplayMember = "NomComplet";
            cbEmploye.ValueMember = "No";

            var depensesParEmp = _context.Depenses
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

            depenseParEmpDataGridView.DataSource = depensesParEmp.ToList();

            depenseParEmpDataGridView.Columns["TypeService"].HeaderText = "Type de service";
            depenseParEmpDataGridView.Columns["Montant"].HeaderText = "Montant ($)";
            depenseParEmpDataGridView.Columns["DateDepense"].HeaderText = "Date de dépense";
            depenseParEmpDataGridView.Columns["NomComplet"].HeaderText = "Nom de l'abonné";


            ////// DÉPENSES PAR ABONNÉ //////

            var nomCompletAbonne = _context.Abonnements
                .Where( a => a.Id[a.Id.Length - 1] == 'P' ) // single quote for type char
                .Select( a => new {
                    a.Id,
                    nomComplet = a.Prenom + " " + a.Nom
                } );

            cbAbonne.DataSource = nomCompletAbonne.ToList();
            cbAbonne.DisplayMember = "nomComplet";
            cbAbonne.ValueMember = "Id";

            var depenseParAbonne = _context.Abonnements
                .Where( a => a.Id == cbAbonne.SelectedValue.ToString() )
                .Join( _context.Depenses,
                    a => a.Id,
                    d => d.IdAbonnement,
                    ( a, d ) => new { a, d } )
                .Join( _context.Services,
                    ad => ad.d.NoService,
                    s => s.No,
                    ( ad, s ) => new { ad.a, ad.d, s } )
                .Join( _context.Employes,
                    ads => ads.s.NoEmploye,
                    e => e.No,
                    ( ads, e ) => new { ads.a, ads.d, ads.s, e } )
                .Select( x => new {
                    x.d.Montant,
                    x.d.DateDepense,
                    x.s.TypeService,
                    NomComplet = x.e.Prenom + " " + x.e.Nom
                } );

            depenseParAbonneDataGridView.DataSource = depenseParAbonne.ToList();

            depenseParAbonneDataGridView.Columns["TypeService"].HeaderText = "Type de service";
            depenseParAbonneDataGridView.Columns["Montant"].HeaderText = "Montant ($)";
            depenseParAbonneDataGridView.Columns["DateDepense"].HeaderText = "Date de dépense";
            depenseParAbonneDataGridView.Columns["NomComplet"].HeaderText = "Nom de l'employé";


            ///// DÉPENSES PAR ANNÉE /////

            nudAnnee.Maximum = DateTime.Now.Year;
            nudAnnee.Value = DateTime.Now.Year;

            var depenseParAnnee = _context.Depenses
                .Where( d => d.DateDepense.Year == Convert.ToInt32( nudAnnee.Value ) )
                .Join( _context.Services,
                    d => d.NoService,
                    s => s.No,
                    ( d, s ) => new { d, s } )
                .Join( _context.Abonnements,
                    ds => ds.d.IdAbonnement,
                    a => a.Id,
                    ( ds, a ) => new { ds.d, ds.s, a } )
                .Join( _context.Employes,
                    dsa => dsa.s.NoEmploye,
                    e => e.No,
                    ( dsa, e ) => new { dsa.d, dsa.s, dsa.a, e } )
                .Select( x => new {
                    NomCompletAbonne = x.a.Prenom + " " + x.a.Nom,
                    x.d.Montant,
                    x.d.DateDepense,
                    x.s.TypeService,
                    NomCompletEmploye = x.e.Prenom + " " + x.e.Nom
                } );

            depenseParAnneeDataGridView.DataSource = depenseParAnnee.ToList();

            depenseParAnneeDataGridView.Columns["TypeService"].HeaderText = "Type de service";
            depenseParAnneeDataGridView.Columns["Montant"].HeaderText = "Montant ($)";
            depenseParAnneeDataGridView.Columns["DateDepense"].HeaderText = "Date de dépense";
            depenseParAnneeDataGridView.Columns["NomCompletAbonne"].HeaderText = "Nom de l'abonné";
            depenseParAnneeDataGridView.Columns["NomCompletEmploye"].HeaderText = "Nom de l'employé";

            ////// PARTIES JOUÉES PAR TERRAIN //////

            var terrains = _context.Terrains.Select( t => new {
                t.No,
                t.Nom
            } ).ToList();

            cbTerrain.DataSource = terrains;
            cbTerrain.DisplayMember = "Nom";
            cbTerrain.ValueMember = "No";

                var partiesParTerrain = _context.PartiesJouees
                    .Where( pj => pj.NoTerrain == Convert.ToInt32(cbTerrain.SelectedValue) )
                    .Join( _context.Terrains,
                        pj => pj.NoTerrain,
                        t => t.No,
                        ( pj, t ) => new { pj, t } )
                    .Join( _context.Abonnements,
                        pjt => pjt.pj.IdAbonnement,
                        a => a.Id,
                        ( pjt, a ) => new { pjt.pj, pjt.t, a } )
                    .Select( x => new {
                        x.pj.DatePartie,
                        nomCompletAbonne = x.a.Prenom + " " + x.a.Nom,
                        x.pj.Pointage,
                    } );

                partiesParTerrainDataGridView.DataSource = partiesParTerrain.ToList();

                partiesParTerrainDataGridView.Columns["DatePartie"].HeaderText = "Date de la partie";
                partiesParTerrainDataGridView.Columns["nomCompletAbonne"].HeaderText = "Nom de l'abonné";
                partiesParTerrainDataGridView.Columns["Pointage"].HeaderText = "Pointage";

            ////// PARTIES JOUÉES PAR ABONNÉ //////
            
            cbPartieAbonne.DataSource = nomCompletAbonne.ToList();
            cbPartieAbonne.DisplayMember = "nomComplet";
            cbPartieAbonne.ValueMember = "Id";

            var partiesParAbonne = _context.PartiesJouees
                    .Where( pj => pj.IdAbonnement == cbPartieAbonne.SelectedValue.ToString() )
                    .Join( _context.Terrains,
                        pj => pj.NoTerrain,
                        t => t.No,
                        ( pj, t ) => new { pj, t } )
                    .Join( _context.Abonnements,
                        pjt => pjt.pj.IdAbonnement,
                        a => a.Id,
                        ( pjt, a ) => new { pjt.pj, pjt.t, a } )
                    .Select( x => new {
                        x.pj.DatePartie,
                        nomCompletAbonne = x.a.Prenom + " " + x.a.Nom,
                        x.pj.Pointage,
                    } );

            partiesParAbonneDataGridView.DataSource = partiesParAbonne.ToList();

            partiesParAbonneDataGridView.Columns["DatePartie"].HeaderText = "Date de la partie";
            partiesParAbonneDataGridView.Columns["nomCompletAbonne"].HeaderText = "Nom de l'abonné";
            partiesParAbonneDataGridView.Columns["Pointage"].HeaderText = "Pointage";

            ////// PARTIES JOUÉES PAR ANNÉE //////
            
            nudPartiesAnnee.Maximum = DateTime.Now.Year;
            nudPartiesAnnee.Value = DateTime.Now.Year;

            var partiesParAnnee = _context.PartiesJouees
                .Where( pj => pj.DatePartie.Year == Convert.ToInt32( nudPartiesAnnee.Value ) )
                .Join( _context.Terrains,
                    pj => pj.NoTerrain,
                    t => t.No,
                    ( pj, t ) => new { pj, t } )
                .Join( _context.Abonnements,
                    pjt => pjt.pj.IdAbonnement,
                    a => a.Id,
                    ( pjt, a ) => new { pjt.pj, pjt.t, a } )
                .Select( x => new {
                    x.pj.DatePartie,
                    nomCompletAbonne = x.a.Prenom + " " + x.a.Nom,
                    x.t.Nom,
                    x.pj.Pointage,
                } );

            partiesParAnneeDataGridView.DataSource = partiesParAnnee.ToList();

            partiesParAnneeDataGridView.Columns["DatePartie"].HeaderText = "Date de la partie";
            partiesParAnneeDataGridView.Columns["nomCompletAbonne"].HeaderText = "Nom de l'abonné";
            partiesParAnneeDataGridView.Columns["Nom"].HeaderText = "Nom du terrain";
            partiesParAnneeDataGridView.Columns["Pointage"].HeaderText = "Pointage";
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

        private void cbAbonne_SelectedValueChanged( object sender, EventArgs e ) {

            if(cbAbonne.SelectedValue == null)
                return;

            var depenseParAbonne = _context.Abonnements
                .Where( a => a.Id == cbAbonne.SelectedValue.ToString() )
                .Join( _context.Depenses,
                    a => a.Id,
                    d => d.IdAbonnement,
                    ( a, d ) => new { a, d } )
                .Join( _context.Services,
                    ad => ad.d.NoService,
                    s => s.No,
                    ( ad, s ) => new { ad.a, ad.d, s } )
                .Join( _context.Employes,
                    ads => ads.s.NoEmploye,
                    em => em.No,
                    ( ads, em ) => new { ads.a, ads.d, ads.s, em } )
                .Select( x => new {
                    x.s.TypeService,
                    x.d.Montant,
                    x.d.DateDepense,
                    NomComplet = x.em.Prenom + " " + x.em.Nom
                } );

            depenseParAbonneDataGridView.DataSource = depenseParAbonne.ToList();
        }

        private void nudAnnee_ValueChanged( object sender, EventArgs e ) {

            var depenseParAnnee = _context.Depenses
                .Where( d => d.DateDepense.Year == Convert.ToInt32( nudAnnee.Value ) )
                .Join( _context.Services,
                    d => d.NoService,
                    s => s.No,
                    ( d, s ) => new { d, s } )
                .Join( _context.Abonnements,
                    ds => ds.d.IdAbonnement,
                    a => a.Id,
                    ( ds, a ) => new { ds.d, ds.s, a } )
                .Join( _context.Employes,
                    dsa => dsa.s.NoEmploye,
                    em => em.No,
                    ( dsa, em ) => new { dsa.d, dsa.s, dsa.a, em } )
                .Select( x => new {
                    NomCompletAbonne = x.a.Prenom + " " + x.a.Nom,
                    x.d.Montant,
                    x.d.DateDepense,
                    x.s.TypeService,
                    NomCompletEmploye = x.em.Prenom + " " + x.em.Nom
                } );

            depenseParAnneeDataGridView.DataSource = depenseParAnnee.ToList();
        }

        private void cbTerrain_SelectedValueChanged( object sender, EventArgs e ) {

            if(cbTerrain.SelectedValue == null)
                return;

            dynamic selectedItem = cbTerrain.SelectedItem;
            int noTerrain = selectedItem.No;

            var partiesParTerrain = _context.PartiesJouees
                .Where( pj => pj.NoTerrain == noTerrain )
                .Join( _context.Terrains,
                    pj => pj.NoTerrain,
                    t => t.No,
                    ( pj, t ) => new { pj, t } )
                .Join( _context.Abonnements,
                    pjt => pjt.pj.IdAbonnement,
                    a => a.Id,
                    ( pjt, a ) => new { pjt.pj, pjt.t, a } )
                .Select( x => new {
                    x.pj.DatePartie,
                    nomCompletAbonne = x.a.Prenom + " " + x.a.Nom,
                    x.pj.Pointage,
                } );

            partiesParTerrainDataGridView.DataSource = partiesParTerrain.ToList();
        }

        private void cbPartieAbonne_SelectedValueChanged( object sender, EventArgs e ) {

            dynamic selectedItem = cbPartieAbonne.SelectedItem;
            string noAbonne = selectedItem.Id;

            var partiesParAbonne = _context.PartiesJouees
                    .Where( pj => pj.IdAbonnement == noAbonne )
                    .Join( _context.Terrains,
                        pj => pj.NoTerrain,
                        t => t.No,
                        ( pj, t ) => new { pj, t } )
                    .Join( _context.Abonnements,
                        pjt => pjt.pj.IdAbonnement,
                        a => a.Id,
                        ( pjt, a ) => new { pjt.pj, pjt.t, a } )
                    .Select( x => new {
                        x.pj.DatePartie,
                        nomCompletAbonne = x.a.Prenom + " " + x.a.Nom,
                        x.pj.Pointage,
                    } );

            partiesParAbonneDataGridView.DataSource = partiesParAbonne.ToList();
        }

        private void nudPartiesAnnee_ValueChanged( object sender, EventArgs e ) {

            var partiesParAnnee = _context.PartiesJouees
                .Where( pj => pj.DatePartie.Year == Convert.ToInt32( nudPartiesAnnee.Value ) )
                .Join( _context.Terrains,
                    pj => pj.NoTerrain,
                    t => t.No,
                    ( pj, t ) => new { pj, t } )
                .Join( _context.Abonnements,
                    pjt => pjt.pj.IdAbonnement,
                    a => a.Id,
                    ( pjt, a ) => new { pjt.pj, pjt.t, a } )
                .Select( x => new {
                    x.pj.DatePartie,
                    nomCompletAbonne = x.a.Prenom + " " + x.a.Nom,
                    x.t.Nom,
                    x.pj.Pointage,
                } );

            partiesParAnneeDataGridView.DataSource = partiesParAnnee.ToList();
        }

        private void btnRetour_Click( object sender, EventArgs e ) {
            this.Close();
        }
    }
}