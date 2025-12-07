using ProjetII_B56.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetII_B56
{
    public partial class frmStatisque : Form
    {
        private DataClassesCclubGolfDataContext _context = new DataClassesCclubGolfDataContext( Settings.Default.connexion );

        public frmStatisque()
        {
            InitializeComponent();

            ////// ABONNEMENTS PAR ANNÉE ET TYPE D'ABONNEMENT //////
            
            cbTypeAbonnee.DataSource = _context.TypesAbonnement.ToList();
            cbTypeAbonnee.DisplayMember = "Description";
            cbTypeAbonnee.ValueMember = "No";

            nudAnnee.Maximum = DateTime.Now.Year;
            nudAnnee.Value = DateTime.Now.Year;

            var abonnesParTypeEtAnnee = _context.Abonnements
                .Where( a => a.DateAbonnement.Year == (int) nudAnnee.Value && a.NoTypeAbonnement == Convert.ToInt32( cbTypeAbonnee.SelectedValue ) )
                .Select(a => new {
                    NomComplet = a.Prenom + " " + a.Nom,
                    a.DateAbonnement,
                    Adresse = a.NoCivique + " " + a.Rue + ", " + a.Ville + ", " + a.IdProvince + ", " + a.CodePostal,
                    a.Telephone,
                    a.Cellulaire,
                    a.Courriel,
                    a.Remarque,
                } );

            AbonneParAnneeEtTypeDataGridView.DataSource = abonnesParTypeEtAnnee.ToList();

            AbonneParAnneeEtTypeDataGridView.Columns["NomComplet"].HeaderText = "Nom de l'abonné";
            AbonneParAnneeEtTypeDataGridView.Columns["DateAbonnement"].HeaderText = "Date d'abonnement";
            AbonneParAnneeEtTypeDataGridView.Columns["Telephone"].HeaderText = "Téléphone";

            ////// ABONNEMENTS PAR MOIS DE L'ANNÉE COURANTE ET PAR TYPE D'ABONNEMENT //////
            
            cbTypeAbonne.DataSource = _context.TypesAbonnement.ToList();
            cbTypeAbonne.DisplayMember = "Description";
            cbTypeAbonne.ValueMember = "No";

            // get all the months in french
            cbMois.DataSource = new System.Globalization.CultureInfo( "fr-CA" ).DateTimeFormat.MonthNames
                .Where( m => !string.IsNullOrEmpty( m ) )
                .Select( ( m, i ) => new { Mois = m, No = i + 1 } )
                .ToList();
            cbMois.DisplayMember = "Mois";
            cbMois.ValueMember = "No";

            var abonnesParMoisEtType = _context.Abonnements
                .Where( a => a.DateAbonnement.Year == DateTime.Now.Year
                    && a.NoTypeAbonnement == Convert.ToInt32( cbTypeAbonne.SelectedValue )
                    && a.DateAbonnement.Month == Convert.ToInt32( cbMois.SelectedValue ) )
                .Select( a => new {
                    NomComplet = a.Prenom + " " + a.Nom,
                    a.DateAbonnement,
                    Adresse = a.NoCivique + " " + a.Rue + ", " + a.Ville + ", " + a.IdProvince + ", " + a.CodePostal,
                    a.Telephone,
                    a.Cellulaire,
                    a.Courriel,
                    a.Remarque,
                } );

            AbonneParMoisEtTypeDataGridView.DataSource = abonnesParMoisEtType.ToList();
            lblTotalAbonneParMoisEtType.Text = $"nombre total d'abonnements: {(_context.Abonnements).Count()}";
            lblSousTotalAbonneParMoisEtType.Text = $"nombre d'abonnements avec filtres: {abonnesParMoisEtType.Count()}";

            AbonneParMoisEtTypeDataGridView.Columns["NomComplet"].HeaderText = "Nom de l'abonné";
            AbonneParMoisEtTypeDataGridView.Columns["DateAbonnement"].HeaderText = "Date d'abonnement";
            AbonneParMoisEtTypeDataGridView.Columns["Telephone"].HeaderText = "Téléphone";

            lblTotalAbonneAnneType.Text = $"nombre total d'abonnements: {(_context.Abonnements).Count()}";
            lblSousTotalAbonneAnneType.Text = $"nombre d'abonnements avec filtres: {abonnesParTypeEtAnnee.Count()}";


            ////// PARTIES JOUÉES PAR ANNÉE ET PAR TERRAIN //////

            cbTerrain.DataSource = _context.Terrains.ToList();
            cbTerrain.DisplayMember = "Nom";
            cbTerrain.ValueMember = "No";

            nudAnneeParties.Maximum = DateTime.Now.Year;
            nudAnneeParties.Value = DateTime.Now.Year;

            var partiesParAnneeEtTerrain = _context.PartiesJouees
                .Where( p => p.DatePartie.Year == (int) nudAnneeParties.Value && p.NoTerrain == Convert.ToInt32( cbTerrain.SelectedValue ) )
                .Select( p => new {
                    NomComplet = p.Abonnements.Prenom + " " + p.Abonnements.Nom,
                    p.DatePartie,
                    p.Pointage,
                    p.Remarque,
                } );

            partiesParAnneeEtTerrainDataGridView.DataSource = partiesParAnneeEtTerrain.ToList();
            lblTotalPartiesAnneeTerrain.Text = $"nombre total de parties jouées: {(_context.PartiesJouees).Count()}";
            lblSousTotalPartiesAnneeTerrain.Text = $"nombre de parties jouées avec filtres: {partiesParAnneeEtTerrain.Count()}";

            partiesParAnneeEtTerrainDataGridView.Columns["NomComplet"].HeaderText = "Nom de l'abonné";
            partiesParAnneeEtTerrainDataGridView.Columns["DatePartie"].HeaderText = "Date de la partie";

            ////// PARTIES JOUÉES PAR MOIS DE L'ANNÉE COURANTE ET PAR TERRAIN //////
            
            cbPartiesTerrain.DataSource = _context.Terrains.ToList();
            cbPartiesTerrain.DisplayMember = "Nom";
            cbPartiesTerrain.ValueMember = "No";

            cbPartiesMois.DataSource = new System.Globalization.CultureInfo( "fr-CA" ).DateTimeFormat.MonthNames
                .Where( m => !string.IsNullOrEmpty( m ) )
                .Select( ( m, i ) => new { Mois = m, No = i + 1 } )
                .ToList();
            cbPartiesMois.DisplayMember = "Mois";
            cbPartiesMois.ValueMember = "No";

            var partiesParMoisEtTerrain = _context.PartiesJouees
                .Where( p => p.DatePartie.Year == DateTime.Now.Year 
                    && p.NoTerrain == Convert.ToInt32( cbTerrain.SelectedValue ) 
                    && p.DatePartie.Month == Convert.ToInt32(cbPartiesMois.SelectedValue))
                .Select( p => new {
                    NomComplet = p.Abonnements.Prenom + " " + p.Abonnements.Nom,
                    p.DatePartie,
                    p.Pointage,
                    p.Remarque,
                } );

            partiesParMoisEtTerrainDataGridView.DataSource = partiesParMoisEtTerrain.ToList();
            lblTotalPartiesMoisTerrain.Text = $"nombre total de parties jouées: {(_context.PartiesJouees).Count()}";
            lblSousTotalPartiesMoisTerrain.Text = $"nombre de parties jouées avec filtres: {partiesParMoisEtTerrain.Count()}";

            partiesParMoisEtTerrainDataGridView.Columns["NomComplet"].HeaderText = "Nom de l'abonné";
            partiesParMoisEtTerrainDataGridView.Columns["DatePartie"].HeaderText = "Date de la partie";

            ////// DÉPENSES PAR ANNÉE ET PAR ABONNEMENT //////
            
            cbAbonneDepenseAnnee.DataSource = _context.Abonnements.Select(a => new {
                a.Id,
                NomComplet = a.Prenom + " " + a.Nom
            } ).ToList();
            cbAbonneDepenseAnnee.DisplayMember = "NomComplet";
            cbAbonneDepenseAnnee.ValueMember = "Id";

            nudDepensesAnne.Maximum = DateTime.Now.Year;
            nudDepensesAnne.Value = DateTime.Now.Year;

            var depensesParAnneeEtAbonne = _context.Depenses
                .Where( d => d.DateDepense.Year == (int) nudDepensesAnne.Value && d.IdAbonnement == cbAbonneDepenseAnnee.SelectedValue.ToString() )
                .Join( _context.Services,
                    d => d.NoService,
                    s => s.No,
                    ( d, s ) => new {
                        d.DateDepense,
                        d.Montant,
                        s.TypeService,
                        d.Remarque,
                    } )
                .Select( d => new {
                    d.TypeService,
                    d.DateDepense,
                    d.Montant,
                    d.Remarque,
                } );

            depensesParAnneeEtAbonneDataGridView.DataSource = depensesParAnneeEtAbonne.ToList();
            lblTotalDepenseAnneeAbonne.Text = $"montant total des dépenses: {(_context.Depenses.Any() ? _context.Depenses.Sum( d => d.Montant ):0):C2}";
            lblSousTotalDepenseAnneeAbonne.Text = $"montant des dépenses avec filtres: {(depensesParAnneeEtAbonne.Any() ? depensesParAnneeEtAbonne.Sum( d => d.Montant ):0):C2}";

            depensesParAnneeEtAbonneDataGridView.Columns["TypeService"].HeaderText = "Type de service";
            depensesParAnneeEtAbonneDataGridView.Columns["DateDepense"].HeaderText = "Date de la dépense";

            ////// DÉPENSES PAR MOIS DE L'ANNÉE COURANTE ET PAR ABONNEMENT //////
            
            cbAbonneDepensesMois.DataSource = _context.Abonnements.Select( a => new {
                    a.Id,
                    NomComplet = a.Prenom + " " + a.Nom
                } ).ToList();
            cbAbonneDepensesMois.DisplayMember = "NomComplet";
            cbAbonneDepensesMois.ValueMember = "Id";

            cbMoisDepenses.DataSource = new System.Globalization.CultureInfo( "fr-CA" ).DateTimeFormat.MonthNames
                .Where( m => !string.IsNullOrEmpty( m ) )
                .Select( ( m, i ) => new { Mois = m, No = i + 1 } )
                .ToList();
            cbMoisDepenses.DisplayMember = "Mois";
            cbMoisDepenses.ValueMember = "No";

            var depensesParMoisEtAbonne = _context.Depenses
                .Where( d => d.DateDepense.Year == DateTime.Now.Year
                    && d.IdAbonnement == cbAbonneDepensesMois.SelectedValue.ToString()
                    && d.DateDepense.Month == Convert.ToInt32( cbMoisDepenses.SelectedValue ) )
                .Join( _context.Services,
                    d => d.NoService,
                    s => s.No,
                    ( d, s ) => new {
                        d.DateDepense,
                        d.Montant,
                        s.TypeService,
                        d.Remarque,
                    } )
                .Select( d => new {
                    d.TypeService,
                    d.DateDepense,
                    d.Montant,
                    d.Remarque,
                } );

            depensesParMoisEtAbonneDataGridView.DataSource = depensesParMoisEtAbonne.ToList();
            lblTotalDepenseMoisAbonne.Text = $"montant total des dépenses: {(_context.Depenses.Any() ? _context.Depenses.Sum( d => d.Montant ) : 0):C2}";
            lblSousTotalDepenseMoisAbonne.Text = $"montant des dépenses avec filtres: {(depensesParMoisEtAbonne.Any() ? depensesParMoisEtAbonne.Sum( d => d.Montant ) : 0):C2}";

        }

        private void cbTypeAbonnee_SelectedValueChanged( object sender, EventArgs e ) {

            if(cbTypeAbonnee.SelectedItem == null)
                return;

            dynamic selectedItem = cbTypeAbonnee.SelectedItem;
            int noTypeAbonnement = selectedItem.No;

            var abonnesParTypeEtAnnee = _context.Abonnements
                .Where( a => a.DateAbonnement.Year == (int) nudAnnee.Value && a.NoTypeAbonnement == noTypeAbonnement )
                .Select( a => new {
                    NomComplet = a.Prenom + " " + a.Nom,
                    a.DateAbonnement,
                    Adresse = a.NoCivique + " " + a.Rue + ", " + a.Ville + ", " + a.IdProvince + ", " + a.CodePostal,
                    a.Telephone,
                    a.Cellulaire,
                    a.Courriel,
                    a.Remarque,
                } );

            AbonneParAnneeEtTypeDataGridView.DataSource = abonnesParTypeEtAnnee.ToList();
            lblSousTotalAbonneAnneType.Text = $"nombre d'abonnements avec filtres: {abonnesParTypeEtAnnee.Count()}";

        }

        private void nudAnnee_ValueChanged( object sender, EventArgs e ) {

            dynamic selectedItem = cbTypeAbonnee.SelectedItem;
            int noTypeAbonnement = selectedItem.No;

            var abonnesParTypeEtAnnee = _context.Abonnements
                .Where( a => a.DateAbonnement.Year == (int) nudAnnee.Value && a.NoTypeAbonnement == noTypeAbonnement )
                .Select( a => new {
                    NomComplet = a.Prenom + " " + a.Nom,
                    a.DateAbonnement,
                    Adresse = a.NoCivique + " " + a.Rue + ", " + a.Ville + ", " + a.IdProvince + ", " + a.CodePostal,
                    a.Telephone,
                    a.Cellulaire,
                    a.Courriel,
                    a.Remarque,
                } );

            AbonneParAnneeEtTypeDataGridView.DataSource = abonnesParTypeEtAnnee.ToList();
            lblSousTotalAbonneAnneType.Text = $"nombre d'abonnements avec filtres: {abonnesParTypeEtAnnee.Count()}";
        }

        private void cbMois_SelectedValueChanged( object sender, EventArgs e ) {
            if (cbMois.SelectedItem == null)
                return;

            dynamic selectedItemType = cbTypeAbonne.SelectedItem;
            int noTypeAbonnement = selectedItemType.No;

            dynamic selectedItemMois = cbMois.SelectedItem;
            int noMois = selectedItemMois.No;

            var abonnesParMoisEtType = _context.Abonnements
                .Where( a => a.DateAbonnement.Year == DateTime.Now.Year
                    && a.NoTypeAbonnement == noTypeAbonnement
                    && a.DateAbonnement.Month == noMois )
                .Select( a => new {
                    NomComplet = a.Prenom + " " + a.Nom,
                    a.DateAbonnement,
                    Adresse = a.NoCivique + " " + a.Rue + ", " + a.Ville + ", " + a.IdProvince + ", " + a.CodePostal,
                    a.Telephone,
                    a.Cellulaire,
                    a.Courriel,
                    a.Remarque,
                } );

            AbonneParMoisEtTypeDataGridView.DataSource = abonnesParMoisEtType.ToList();
            lblSousTotalAbonneParMoisEtType.Text = $"nombre d'abonnements avec filtres: {abonnesParMoisEtType.Count()}";
        }

        private void cbTypeAbonne_SelectedValueChanged( object sender, EventArgs e ) {

            if(cbTypeAbonne.SelectedItem == null || cbMois.SelectedItem == null)
                return;

            dynamic selectedItemType = cbTypeAbonne.SelectedItem;
            int noTypeAbonnement = selectedItemType.No;

            dynamic selectedItemMois = cbMois.SelectedItem;
            int noMois = selectedItemMois.No;

            var abonnesParMoisEtType = _context.Abonnements
                .Where( a => a.DateAbonnement.Year == DateTime.Now.Year
                    && a.NoTypeAbonnement == noTypeAbonnement
                    && a.DateAbonnement.Month == noMois )
                .Select( a => new {
                    NomComplet = a.Prenom + " " + a.Nom,
                    a.DateAbonnement,
                    Adresse = a.NoCivique + " " + a.Rue + ", " + a.Ville + ", " + a.IdProvince + ", " + a.CodePostal,
                    a.Telephone,
                    a.Cellulaire,
                    a.Courriel,
                    a.Remarque,
                } );

            AbonneParMoisEtTypeDataGridView.DataSource = abonnesParMoisEtType.ToList();
            lblSousTotalAbonneParMoisEtType.Text = $"nombre d'abonnements avec filtres: {abonnesParMoisEtType.Count()}";
        }

        private void cbTerrain_SelectedValueChanged( object sender, EventArgs e ) {

            dynamic selectedItem = cbTerrain.SelectedItem;
            int noTerrain = selectedItem.No;

            var partiesParAnneeEtTerrain = _context.PartiesJouees
                .Where( p => p.DatePartie.Year == (int) nudAnneeParties.Value && p.NoTerrain == noTerrain )
                .Select( p => new {
                    NomComplet = p.Abonnements.Prenom + " " + p.Abonnements.Nom,
                    p.DatePartie,
                    p.Pointage,
                    p.Remarque,
                } );

            partiesParAnneeEtTerrainDataGridView.DataSource = partiesParAnneeEtTerrain.ToList();
            lblSousTotalPartiesAnneeTerrain.Text = $"nombre de parties jouées avec filtres: {partiesParAnneeEtTerrain.Count()}";
        }

        private void nudAnneeParties_ValueChanged( object sender, EventArgs e ) {

            dynamic selectedItem = cbTerrain.SelectedItem;
            int noTerrain = selectedItem.No;

            var partiesParAnneeEtTerrain = _context.PartiesJouees
                .Where( p => p.DatePartie.Year == (int) nudAnneeParties.Value && p.NoTerrain == noTerrain )
                .Select( p => new {
                    NomComplet = p.Abonnements.Prenom + " " + p.Abonnements.Nom,
                    p.DatePartie,
                    p.Pointage,
                    p.Remarque,
                } );

            partiesParAnneeEtTerrainDataGridView.DataSource = partiesParAnneeEtTerrain.ToList();
            lblSousTotalPartiesAnneeTerrain.Text = $"nombre de parties jouées avec filtres: {partiesParAnneeEtTerrain.Count()}";
        }

        private void cbPartiesTerrain_SelectedValueChanged( object sender, EventArgs e ) {

            if (cbPartiesTerrain.SelectedItem == null || cbPartiesMois.SelectedItem == null)
                return;

            dynamic selectedItem = cbPartiesTerrain.SelectedItem;
            int noTerrain = selectedItem.No;
            dynamic selectedItemMois = cbPartiesMois.SelectedItem;
            int noMois = selectedItemMois.No;

            var partiesParMoisEtTerrain = _context.PartiesJouees
                .Where( p => p.DatePartie.Year == DateTime.Now.Year
                    && p.NoTerrain == noTerrain
                    && p.DatePartie.Month == noMois )
                .Select( p => new {
                    NomComplet = p.Abonnements.Prenom + " " + p.Abonnements.Nom,
                    p.DatePartie,
                    p.Pointage,
                    p.Remarque,
                } );

            partiesParMoisEtTerrainDataGridView.DataSource = partiesParMoisEtTerrain.ToList();
            lblSousTotalPartiesMoisTerrain.Text = $"nombre de parties jouées avec filtres: {partiesParMoisEtTerrain.Count()}";
        }

        private void cbPartiesMois_SelectedValueChanged( object sender, EventArgs e ) {

            if(cbPartiesTerrain.SelectedItem == null || cbPartiesMois.SelectedItem == null)
                return;

            dynamic selectedItem = cbPartiesTerrain.SelectedItem;
            int noTerrain = selectedItem.No;
            dynamic selectedItemMois = cbPartiesMois.SelectedItem;
            int noMois = selectedItemMois.No;

            var partiesParMoisEtTerrain = _context.PartiesJouees
                .Where( p => p.DatePartie.Year == DateTime.Now.Year
                    && p.NoTerrain == noTerrain
                    && p.DatePartie.Month == noMois )
                .Select( p => new {
                    NomComplet = p.Abonnements.Prenom + " " + p.Abonnements.Nom,
                    p.DatePartie,
                    p.Pointage,
                    p.Remarque,
                } );

            partiesParMoisEtTerrainDataGridView.DataSource = partiesParMoisEtTerrain.ToList();
            lblSousTotalPartiesMoisTerrain.Text = $"nombre de parties jouées avec filtres: {partiesParMoisEtTerrain.Count()}";
        }

        private void cbAbonneDepenseAnnee_SelectedValueChanged( object sender, EventArgs e ) {

            if (cbAbonneDepenseAnnee.SelectedItem == null)
                return;

            dynamic selectedItemAbonne = cbAbonneDepenseAnnee.SelectedItem;
            string idAbonnement = selectedItemAbonne.Id;

            var depensesParAnneeEtAbonne = _context.Depenses
                .Where( d => d.DateDepense.Year == (int) nudDepensesAnne.Value && d.IdAbonnement == idAbonnement )
                .Join( _context.Services,
                    d => d.NoService,
                    s => s.No,
                    ( d, s ) => new {
                        d.DateDepense,
                        d.Montant,
                        s.TypeService,
                        d.Remarque,
                    } )
                .Select( d => new {
                    d.TypeService,
                    d.DateDepense,
                    d.Montant,
                    d.Remarque,
                } );

            depensesParAnneeEtAbonneDataGridView.DataSource = depensesParAnneeEtAbonne.ToList();
            lblSousTotalDepenseAnneeAbonne.Text = $"montant des dépenses avec filtres: {(depensesParAnneeEtAbonne.Any() ? depensesParAnneeEtAbonne.Sum( d => d.Montant ) : 0):C2}";

        }

        private void nudDepensesAnne_ValueChanged( object sender, EventArgs e ) {

            if(cbAbonneDepenseAnnee.SelectedItem == null)
                return;

            dynamic selectedItemAbonne = cbAbonneDepenseAnnee.SelectedItem;
            string idAbonnement = selectedItemAbonne.Id;

            var depensesParAnneeEtAbonne = _context.Depenses
                .Where( d => d.DateDepense.Year == (int) nudDepensesAnne.Value && d.IdAbonnement == idAbonnement )
                .Join( _context.Services,
                    d => d.NoService,
                    s => s.No,
                    ( d, s ) => new {
                        d.DateDepense,
                        d.Montant,
                        s.TypeService,
                        d.Remarque,
                    } )
                .Select( d => new {
                    d.TypeService,
                    d.DateDepense,
                    d.Montant,
                    d.Remarque,
                } );

            depensesParAnneeEtAbonneDataGridView.DataSource = depensesParAnneeEtAbonne.ToList();
            lblSousTotalDepenseAnneeAbonne.Text = $"montant des dépenses avec filtres: {(depensesParAnneeEtAbonne.Any() ? depensesParAnneeEtAbonne.Sum( d => d.Montant ) : 0):C2}";
        }

        private void cbAbonneDepensesMois_SelectedValueChanged( object sender, EventArgs e ) {

            if(cbAbonneDepensesMois.SelectedItem == null || cbMoisDepenses.SelectedItem == null)
                return;

            dynamic selectedItemAbonne = cbAbonneDepensesMois.SelectedItem;
            string idAbonnement = selectedItemAbonne.Id;
            dynamic selectedItemMois = cbMoisDepenses.SelectedItem;
            int noMois = selectedItemMois.No;

            var depensesParMoisEtAbonne = _context.Depenses
                .Where( d => d.DateDepense.Year == DateTime.Now.Year
                    && d.IdAbonnement == idAbonnement
                    && d.DateDepense.Month == noMois )
                .Join( _context.Services,
                    d => d.NoService,
                    s => s.No,
                    ( d, s ) => new {
                        d.DateDepense,
                        d.Montant,
                        s.TypeService,
                        d.Remarque,
                    } )
                .Select( d => new {
                    d.TypeService,
                    d.DateDepense,
                    d.Montant,
                    d.Remarque,
                } );

            depensesParMoisEtAbonneDataGridView.DataSource = depensesParMoisEtAbonne.ToList();
            lblSousTotalDepenseMoisAbonne.Text = $"montant des dépenses avec filtres: {(depensesParMoisEtAbonne.Any() ? depensesParMoisEtAbonne.Sum( d => d.Montant ) : 0):C2}";
        }

        private void cbMoisDepenses_SelectedValueChanged( object sender, EventArgs e ) {

            if(cbAbonneDepensesMois.SelectedItem == null || cbMoisDepenses.SelectedItem == null)
                return;

            dynamic selectedItemAbonne = cbAbonneDepensesMois.SelectedItem;
            string idAbonnement = selectedItemAbonne.Id;
            dynamic selectedItemMois = cbMoisDepenses.SelectedItem;
            int noMois = selectedItemMois.No;

            var depensesParMoisEtAbonne = _context.Depenses
                .Where( d => d.DateDepense.Year == DateTime.Now.Year
                    && d.IdAbonnement == idAbonnement
                    && d.DateDepense.Month == noMois )
                .Join( _context.Services,
                    d => d.NoService,
                    s => s.No,
                    ( d, s ) => new {
                        d.DateDepense,
                        d.Montant,
                        s.TypeService,
                        d.Remarque,
                    } )
                .Select( d => new {
                    d.TypeService,
                    d.DateDepense,
                    d.Montant,
                    d.Remarque,
                } );

            depensesParMoisEtAbonneDataGridView.DataSource = depensesParMoisEtAbonne.ToList();
            lblSousTotalDepenseMoisAbonne.Text = $"montant des dépenses avec filtres: {(depensesParMoisEtAbonne.Any() ? depensesParMoisEtAbonne.Sum( d => d.Montant ) : 0):C2}";
        }
    }
}
