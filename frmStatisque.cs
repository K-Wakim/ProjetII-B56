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

            AbonneParMoisEtTypeDataGridView.Columns["NomComplet"].HeaderText = "Nom de l'abonné";
            AbonneParMoisEtTypeDataGridView.Columns["DateAbonnement"].HeaderText = "Date d'abonnement";
            AbonneParMoisEtTypeDataGridView.Columns["Telephone"].HeaderText = "Téléphone";
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
        }
    }
}
