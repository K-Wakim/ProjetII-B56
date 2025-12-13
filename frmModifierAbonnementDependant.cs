using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetII_B56
{
    public partial class frmModifierAbonnementDependant : Form
    {
        private string type = "";
        private DataGridViewRow selectedRow = null;
        DataClassesCclubGolfDataContext db = new DataClassesCclubGolfDataContext();

        public frmModifierAbonnementDependant(string type, DataGridViewRow selectedRow)
        {
            InitializeComponent();
            this.type = type;
            this.selectedRow = selectedRow;
        }

        private void frmModifierAbonnementDependant_Load(object sender, EventArgs e)
        {
            // ---------------------------------------------
            // Charger les valeurs dans les champs selon le type
            // ---------------------------------------------


            // Vérifie si selectedRow n'est pas null, sinon fermer le form
            if (selectedRow != null)
            {
                try
                {
                    switch (type)
                    {
                        case "Abonnement":

                            // Charger la visibilité des champs pour un abonnement

                            titre.Text = "Modifier une abonnement";

                            IDTextBox.Visible = true;
                            nomTextBox.Visible = true;
                            prenomTextBox.Visible = true;
                            dateNaissanceDateTimePicker.Visible = true;
                            comboBoxSexe.Visible = true;
                            remarqueTextBox.Visible = true;

                            provinceLabel.Visible = true;
                            provincesComboBox.Visible = true;
                            typeAbonnementLabel.Visible = true;
                            typesAbonnementComboBox.Visible = true;
                            dateAbonnementLabel.Visible = true;
                            dateAbonnementDateTimePicker.Visible = true;
                            telephoneLabel.Visible = true;
                            telephoneTextBox.Visible = true;
                            cellulaireLabel.Visible = true;
                            cellulaireTextBox.Visible = true;
                            noCiviqueLabel.Visible = true;
                            noCiviqueTextBox.Visible = true;
                            courrielLabel.Visible = true;
                            courrielTextBox.Visible = true;
                            rueLabel.Visible = true;
                            rueTextBox.Visible = true;
                            villeLabel.Visible = true;
                            villeTextBox.Visible = true;
                            rueLabel.Visible = true;
                            rueTextBox.Visible = true;
                            codePostalLabel.Visible = true;
                            codePostalTextBox.Visible = true;

                            // Charger les options comboBox

                            comboBoxSexe.Items.Add("H");
                            comboBoxSexe.Items.Add("F");

                            provincesComboBox.DataSource = db.Provinces.ToList();
                            provincesComboBox.DisplayMember = "Nom";
                            provincesComboBox.ValueMember = "Id";

                            typesAbonnementComboBox.DataSource = db.TypesAbonnement.ToList();
                            typesAbonnementComboBox.DisplayMember = "Description";
                            typesAbonnementComboBox.ValueMember = "No";

                            // Charger les valeurs des champs depuis selectedRow

                            IDTextBox.Text = selectedRow.Cells[0].Value.ToString();
                            dateNaissanceDateTimePicker.Value = Convert.ToDateTime(selectedRow.Cells[1].Value);
                            nomTextBox.Text = selectedRow.Cells[2].Value.ToString();
                            prenomTextBox.Text = selectedRow.Cells[3].Value.ToString();
                            comboBoxSexe.SelectedIndex = comboBoxSexe.Items.IndexOf(selectedRow.Cells[4].Value.ToString());
                            noCiviqueTextBox.Text = selectedRow.Cells[5].Value.ToString();
                            rueTextBox.Text = selectedRow.Cells[6].Value.ToString();
                            villeTextBox.Text = selectedRow.Cells[7].Value.ToString();
                            provincesComboBox.Text = db.Provinces.SingleOrDefault(p => p.Id == selectedRow.Cells[8].Value.ToString()).Nom;
                            typesAbonnementComboBox.Text = db.TypesAbonnement.SingleOrDefault(t => t.No == Convert.ToInt32(selectedRow.Cells[9].Value.ToString())).Description;
                            dateAbonnementDateTimePicker.Value = Convert.ToDateTime(selectedRow.Cells[10].Value);
                            telephoneTextBox.Text = $"{selectedRow.Cells[11].Value.ToString().Substring(0, 3)} {selectedRow.Cells[11].Value.ToString().Substring(3, 3)} {selectedRow.Cells[11].Value.ToString().Substring(6, 4)}";
                            cellulaireTextBox.Text = $"{selectedRow.Cells[12].Value.ToString().Substring(0, 3)} {selectedRow.Cells[12].Value.ToString().Substring(3, 3)} {selectedRow.Cells[12].Value.ToString().Substring(6, 4)}";
                            courrielTextBox.Text = selectedRow.Cells[13].Value.ToString();
                            codePostalTextBox.Text = $"{selectedRow.Cells[14].Value.ToString().Substring(0, 3)} {selectedRow.Cells[14].Value.ToString().Substring(3, 3)}";
                            remarqueTextBox.Text = selectedRow.Cells[15].Value == null ? "" : selectedRow.Cells[15].Value.ToString();


                            break;
                        case "Dependant":

                            // Charger la visibilité des champs pour un dependant

                            titre.Text = "Modifier une dependant";

                            IDTextBox.Visible = true;
                            nomTextBox.Visible = true;
                            prenomTextBox.Visible = true;
                            dateNaissanceDateTimePicker.Visible = true;
                            sexeLabel.Visible = false;
                            comboBoxSexe.Visible = false;
                            remarqueTextBox.Visible = true;

                            provinceLabel.Visible = false;
                            provincesComboBox.Visible = false;
                            typeAbonnementLabel.Visible = false;
                            typesAbonnementComboBox.Visible = false;
                            dateAbonnementLabel.Visible = false;
                            dateAbonnementDateTimePicker.Visible = false;
                            telephoneLabel.Visible = false;
                            telephoneTextBox.Visible = false;
                            cellulaireLabel.Visible = false;
                            cellulaireTextBox.Visible = false;
                            noCiviqueLabel.Visible = false;
                            noCiviqueTextBox.Visible = false;
                            courrielLabel.Visible = false;
                            courrielTextBox.Visible = false;
                            rueLabel.Visible = false;
                            rueTextBox.Visible = false;
                            villeLabel.Visible = false;
                            villeTextBox.Visible = false;
                            rueLabel.Visible = false;
                            rueTextBox.Visible = false;
                            codePostalLabel.Visible = false;
                            codePostalTextBox.Visible = false;


                            // Charger les valeurs des champs depuis selectedRow

                            //string DEBUG = "";

                            //for (int i = 0; i < selectedRow.Cells.Count; i++)
                            //{
                            //    if (selectedRow.Cells[i].Value == null)
                            //    {
                            //        DEBUG += $"Index {i} is null \n";
                            //    }
                            //    else
                            //    {
                            //        DEBUG += $"Index {i}: {selectedRow.Cells[i].Value.ToString()} \n";
                            //    }
                            //}

                            // MessageBox.Show(DEBUG);

                            // Charger les valeurs des champs depuis selectedRow

                            IDTextBox.Text = selectedRow.Cells[0].Value.ToString();
                            nomTextBox.Text = selectedRow.Cells[1].Value.ToString();
                            prenomTextBox.Text = selectedRow.Cells[2].Value.ToString();
                            dateNaissanceDateTimePicker.Value = Convert.ToDateTime(selectedRow.Cells[3].Value);
                            remarqueTextBox.Text = selectedRow.Cells[5].Value == null ? "" : selectedRow.Cells[5].Value.ToString();

                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement du form: " + ex.Message, "Erreur!");
                }
            }
            else
            {
                MessageBox.Show("Le selectedRow est introuvable! Le system se redirige vers la form précédente.", "Erreur!");
                this.Close();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            try
            {
                switch (type)
                {
                    case "Abonnement":

                        // ---------------------------------------------
                        // Validation des champs abonnement
                        // ---------------------------------------------

                        if(String.IsNullOrWhiteSpace(prenomTextBox.Text) ||
                           String.IsNullOrWhiteSpace(rueTextBox.Text) ||
                           String.IsNullOrWhiteSpace(villeTextBox.Text) ||
                           String.IsNullOrWhiteSpace(codePostalTextBox.Text) ||
                           String.IsNullOrWhiteSpace(telephoneTextBox.Text) ||
                           String.IsNullOrWhiteSpace(cellulaireTextBox.Text) ||
                           String.IsNullOrWhiteSpace(noCiviqueTextBox.Text) ||
                           String.IsNullOrWhiteSpace(courrielTextBox.Text))
                        {
                            throw new Exception("Veuillez remplir tous les champs obligatoires.");
                        }

                        // Vérifier le format du code postal (ex: A1A 1A1)
                        if (!System.Text.RegularExpressions.Regex.IsMatch(codePostalTextBox.Text, @"^[A-Za-z]\d[A-Za-z] \d[A-Za-z]\d$"))
                        {
                            throw new Exception("Le code postal doit être au format A1A 1A1.");
                        }

                        //Vérifier le format du telephone et cellulaire (ex: 123-456-7890 or 123 456 7890)
                        if (!System.Text.RegularExpressions.Regex.IsMatch(telephoneTextBox.Text, @"^(\d{3}[- ]?\d{3}[- ]?\d{4})$"))
                        {
                            throw new Exception("Le numéro de téléphone doit être au format 123-456-7890 ou 123 456 7890.");
                        }

                        //Vérifier le format du courriel (ex: coolperson@awesome.com)
                        if (!System.Text.RegularExpressions.Regex.IsMatch(courrielTextBox.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                        {
                            throw new Exception("Le courriel doit être au format");
                        }


                        var abonnement = db.Abonnements
                                        .SingleOrDefault(a => a.Id == IDTextBox.Text);
                        
                        if (abonnement != null) {
                            abonnement.Prenom = prenomTextBox.Text;
                            abonnement.Sexe = comboBoxSexe.SelectedItem.ToString() == null ? Convert.ToChar(selectedRow.Cells[4].Value.ToString()) : Convert.ToChar(comboBoxSexe.SelectedItem.ToString());
                            abonnement.Remarque = remarqueTextBox.Text;
                            abonnement.Rue = rueTextBox.Text;
                            abonnement.Ville = villeTextBox.Text;
                            abonnement.CodePostal = codePostalTextBox.Text.Replace(" ", "");
                            abonnement.IdProvince = provincesComboBox.SelectedValue.ToString();
                            abonnement.NoTypeAbonnement = Convert.ToInt32(typesAbonnementComboBox.SelectedValue);
                            abonnement.Telephone = telephoneTextBox.Text.Replace(" ", "").Replace("-", "");
                            abonnement.Cellulaire = cellulaireTextBox.Text.Replace(" ", "").Replace("-", "");
                            abonnement.NoCivique = noCiviqueTextBox.Text;
                            abonnement.Courriel = courrielTextBox.Text;

                            db.SubmitChanges();
                            MessageBox.Show("Abonnement modifié avec succès!");
                            this.Close();
                        }
                        else {
                            throw new Exception("Abonnement non trouvé.");
                        }

                            break;
                    case "Dependant":

                        // ---------------------------------------------
                        // Validation des champs abonnement
                        // ---------------------------------------------

                        if (String.IsNullOrWhiteSpace(prenomTextBox.Text))
                        {
                            throw new Exception("Veuillez remplir tous les champs obligatoires.");
                        }

                        var dependant = db.Dependants
                                        .SingleOrDefault(d => d.Id == IDTextBox.Text);

                        if (dependant != null)
                        {
                            dependant.Id = IDTextBox.Text;
                            dependant.Nom = nomTextBox.Text;
                            dependant.Prenom = prenomTextBox.Text;
                            dependant.DateNaissance = dateNaissanceDateTimePicker.Value;
                            dependant.Remarque = remarqueTextBox.Text;
                        }

                        db.SubmitChanges();
                        MessageBox.Show("Dépendant modifié avec succès!");
                        this.Close();

                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du modification du " + type + ": " + ex.Message, "Erreur!");
            }
        }
    }
}
