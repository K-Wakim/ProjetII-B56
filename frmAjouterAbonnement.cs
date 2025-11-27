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
    public partial class frmAjouterAbonnement : Form
    {
        public frmAjouterAbonnement()
        {
            InitializeComponent();
        }

        private void abonnementsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.abonnementsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Pr211DataSet);

        }

        private void frmAjouterAbonnement_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Pr211DataSet.Provinces'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.provincesTableAdapter.Fill(this.bDB56Pr211DataSet.Provinces);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Pr211DataSet.TypesAbonnement'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typesAbonnementTableAdapter.Fill(this.bDB56Pr211DataSet.TypesAbonnement);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Pr211DataSet.TypesAbonnement'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typesAbonnementTableAdapter.Fill(this.bDB56Pr211DataSet.TypesAbonnement);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Pr211DataSet.Abonnements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            // this.abonnementsTableAdapter.Fill(this.bDB56Pr211DataSet.Abonnements);

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            //  -------------------
            //      VALIDATION
            //  -------------------

            // Whitespace or null checks

            if (String.IsNullOrWhiteSpace(nomTextBox.Text) == true ||
                String.IsNullOrWhiteSpace(prenomTextBox.Text) == true ||
                String.IsNullOrWhiteSpace(sexeTextBox.Text) == true ||
                String.IsNullOrWhiteSpace(villeTextBox.Text) == true ||
                String.IsNullOrWhiteSpace(rueTextBox.Text) == true ||
                String.IsNullOrWhiteSpace(noCiviqueTextBox.Text) == true ||
                String.IsNullOrWhiteSpace(codePostalTextBox.Text) == true ||
                String.IsNullOrWhiteSpace(telephoneTextBox.Text) == true ||
                String.IsNullOrWhiteSpace(cellulaireTextBox.Text) == true ||
                String.IsNullOrWhiteSpace(courrielTextBox.Text) == true)
            {
                MessageBox.Show("Veuillez remplir tout les champs!", "Erreur de validation!");
            }

            

            try
            {
                // Dates

                if (dateAbonnementDateTimePicker.Value < dateNaissanceDateTimePicker.Value)
                {
                    errorProvider.SetError(dateNaissanceDateTimePicker, "La date de naissance ne peux pas être avant la date de l'abonnement!");
                    throw new Exception();
                }
                if ((dateAbonnementDateTimePicker.Value.Year - dateNaissanceDateTimePicker.Value.Year) < 18)
                {
                    errorProvider.SetError(dateNaissanceDateTimePicker, "L’âge minimum de l’abonné principal est de 18 ans!");
                    throw new Exception();
                }
                if ((dateAbonnementDateTimePicker.Value.Year - dateNaissanceDateTimePicker.Value.Year) < 60 && Convert.ToInt64(noTypeAbonnementComboBox.SelectedValue) == 2)
                {
                    errorProvider.SetError(dateNaissanceDateTimePicker, "L’âge minimum de l’abonné principal est de 60 ans pour les personnes de l’âge d’or!");
                    throw new Exception();
                }

                //Formatting

            }
            catch (Exception ex)
            {

            }

        }
    }
}
