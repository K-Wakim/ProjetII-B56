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
            // TODO: cette ligne de code charge les données dans la table 'bDB56Pr211DataSet.Abonnements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.abonnementsTableAdapter.Fill(this.bDB56Pr211DataSet.Abonnements);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Pr211DataSet.PartiesJouees'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.partiesJoueesTableAdapter.Fill(this.bDB56Pr211DataSet.PartiesJouees);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Pr211DataSet.Terrains'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.terrainsTableAdapter.Fill(this.bDB56Pr211DataSet.Terrains);

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            // Validation minimale
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
                // Crée une nouvelle ligne PartieJouee
                BDB56Pr211DataSet.PartiesJoueesRow nouvellePartie =
                    bDB56Pr211DataSet.PartiesJouees.NewPartiesJoueesRow();

                // Affectation des valeurs provenant du formulaire
                nouvellePartie.IdAbonnement = Convert.ToString(cboNomAbo.SelectedValue);
                nouvellePartie.NoTerrain = Convert.ToInt32(cboNomTerrain.SelectedValue);
                nouvellePartie.Pointage = Convert.ToInt32(nudPointage.Value);
                nouvellePartie.DatePartie = dtpPartieJoue.Value;

                // Remarque est optionnel
                if (!string.IsNullOrWhiteSpace(rtbRemarque.Text))
                    nouvellePartie.Remarque = rtbRemarque.Text;
                else
                    nouvellePartie.SetRemarqueNull();  // obligatoire si colonne peut être NULL

                // Ajouter la ligne au DataSet
                bDB56Pr211DataSet.PartiesJouees.AddPartiesJoueesRow(nouvellePartie);

                // Sauvegarder dans la BD
                partiesJoueesTableAdapter.Update(bDB56Pr211DataSet.PartiesJouees);

                MessageBox.Show("Partie enregistrée avec succès !");

                // Optionnel : rafraîchir le formulaire
                this.partiesJoueesTableAdapter.Fill(this.bDB56Pr211DataSet.PartiesJouees);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

    }
}
