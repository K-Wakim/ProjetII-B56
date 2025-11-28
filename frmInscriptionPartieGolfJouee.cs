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
    public partial class frmInscriptionPartieGolfJouee : Form
    {
        DataClassesCclubGolfDataContext db = new DataClassesCclubGolfDataContext();


        public frmInscriptionPartieGolfJouee()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void terrainsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.terrainsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Pr211DataSet);

        }

        private void frmInscriptionPartieGolfJouee_Load(object sender, EventArgs e)
        {
            // Charger les abonnements
            var abonnements = db.Abonnements
                                .Select(a => new
                                {
                                    a.Id,
                                    NomComplet = a.Nom + " " + a.Prenom
                                })
                                .ToList();
            cboNomAbo.DataSource = abonnements;
            cboNomAbo.DisplayMember = "NomComplet";
            cboNomAbo.ValueMember = "Id";

            // Charger les terrains
            var terrains = db.Terrains
                             .Select(t => new
                             {
                                 t.No,
                                 t.Nom
                             })
                             .ToList();
            cboNomTerrain.DataSource = terrains;
            cboNomTerrain.DisplayMember = "Nom";
            cboNomTerrain.ValueMember = "No";
        }


        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (cboNomAbo.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un abonné.");
                return;
            }
            if (cboNomTerrain.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un terrain.");
                return;
            }

            try
            {
                PartiesJouees nouvellePartie = new PartiesJouees
                {
                    IdAbonnement = cboNomAbo.SelectedValue.ToString(),
                    NoTerrain = (int)cboNomTerrain.SelectedValue,
                    Pointage = (int)nudPointage.Value,
                    DatePartie = dtpPartieJoue.Value,
                    Remarque = string.IsNullOrWhiteSpace(rtbRemarque.Text) ? null : rtbRemarque.Text
                };

                db.PartiesJouees.InsertOnSubmit(nouvellePartie);
                db.SubmitChanges();

                MessageBox.Show("Partie enregistrée avec succès !");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }


    }
}
