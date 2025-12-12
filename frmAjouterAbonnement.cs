using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetII_B56
{
    public partial class frmAjouterAbonnement : Form
    {
        DataClassesCclubGolfDataContext db = new DataClassesCclubGolfDataContext();

        public frmAjouterAbonnement()
        {
            InitializeComponent();
        }

        private void frmAjouterAbonnement_Load(object sender, EventArgs e)
        {
            // Cacher les champs supplémentaires par défaut
            subtitre1.Visible = false;
            nomConjointTextBox.Visible = false;
            prenomConjointTextBox.Visible = false;
            dateNaissanceConjointTimePicker.Visible = false;
            comboBoxSexeConjoint.Visible = false;
            remarqueConjointTextBox.Visible = false;

            enfantnomLabel.Visible = false;
            enfantprenomLabel.Visible = false;
            enfantDateNaissanceLabel.Visible = false;

            subtitre2.Visible = false;
            nbEnfantnumericUpDown.Visible = false;


            nomEnfantTextBox1.Visible = false;
            prenomEnfantTextBox1.Visible = false;
            dateNaissanceEnfantTimePicker1.Visible = false;

            nomEnfantTextBox2.Visible = false;
            prenomEnfantTextBox2.Visible = false;
            dateNaissanceEnfantTimePicker2.Visible = false;

            nomEnfantTextBox3.Visible = false;
            prenomEnfantTextBox3.Visible = false;
            dateNaissanceEnfantTimePicker3.Visible = false;

            nomEnfantTextBox4.Visible = false;
            prenomEnfantTextBox4.Visible = false;
            dateNaissanceEnfantTimePicker4.Visible = false;

            nomEnfantTextBox5.Visible = false;
            prenomEnfantTextBox5.Visible = false;
            dateNaissanceEnfantTimePicker5.Visible = false;

            nomEnfantTextBox6.Visible = false;
            prenomEnfantTextBox6.Visible = false;
            dateNaissanceEnfantTimePicker6.Visible = false;

            nomEnfantTextBox7.Visible = false;
            prenomEnfantTextBox7.Visible = false;
            dateNaissanceEnfantTimePicker7.Visible = false;

            nomEnfantTextBox8.Visible = false;
            prenomEnfantTextBox8.Visible = false;
            dateNaissanceEnfantTimePicker8.Visible = false;

            nomEnfantTextBox9.Visible = false;
            prenomEnfantTextBox9.Visible = false;
            dateNaissanceEnfantTimePicker9.Visible = false;

            // Charger les combo boxes

            // Provinces
            provincesComboBox.DataSource = db.Provinces.ToList();
            provincesComboBox.DisplayMember = "Nom";
            provincesComboBox.ValueMember = "Id";

            // Types abonnements

            typesAbonnementComboBox.DataSource = db.TypesAbonnement.ToList();
            typesAbonnementComboBox.DisplayMember = "Description";
            typesAbonnementComboBox.ValueMember = "No";

            // Conjoint

            comboBoxSexe.Items.Add("H");
            comboBoxSexe.Items.Add("F");

            comboBoxSexeConjoint.Items.Add("H");
            comboBoxSexeConjoint.Items.Add("F");

            // Enfants

            enfantSexeComboBox1.Items.Add("H");
            enfantSexeComboBox1.Items.Add("F");

            enfantSexeComboBox2.Items.Add("H");
            enfantSexeComboBox2.Items.Add("F");

            enfantSexeComboBox3.Items.Add("H");
            enfantSexeComboBox3.Items.Add("F");

            enfantSexeComboBox4.Items.Add("H");
            enfantSexeComboBox4.Items.Add("F");

            enfantSexeComboBox5.Items.Add("H");
            enfantSexeComboBox5.Items.Add("F");

            enfantSexeComboBox6.Items.Add("H");
            enfantSexeComboBox6.Items.Add("F");

            enfantSexeComboBox7.Items.Add("H");
            enfantSexeComboBox7.Items.Add("F");

            enfantSexeComboBox8.Items.Add("H");
            enfantSexeComboBox8.Items.Add("F");

            enfantSexeComboBox9.Items.Add("H");
            enfantSexeComboBox9.Items.Add("F");
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                // ----------------------------------------------------------------------
                // Validation des champs obligatoires
                // ----------------------------------------------------------------------

                // Vérifier que tous les champs obligatoires sont remplis
                if (String.IsNullOrWhiteSpace(nomTextBox.Text) ||
                    String.IsNullOrWhiteSpace(prenomTextBox.Text) ||
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

                // Vérifier que la date de naissance est antérieure à la date d'abonnement
                if (dateNaissanceDateTimePicker.Value >= dateAbonnementDateTimePicker.Value)
                {
                    throw new Exception("La date de naissance doit être antérieure à la date d'abonnement.");
                }

                // Vérifier que l'abonné a au moins 18 ans au moment de l'abonnement
                if ((dateAbonnementDateTimePicker.Value.Year - dateNaissanceDateTimePicker.Value.Year) < 18)
                {
                    throw new Exception("L'abonné doit avoir au moins 18 ans au moment de l'abonnement.");
                }

                // Vérifier les conditions spécifiques pour les abonnements seniors
                if ((dateAbonnementDateTimePicker.Value.Year - dateNaissanceDateTimePicker.Value.Year) < 60 && Convert.ToInt64(typesAbonnementComboBox.SelectedValue) == 2)
                {
                    throw new Exception("L'abonnement senior est réservé aux personnes âgées de 60 ans et plus.");
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

                // ----------------------------------------------------------------------
                // Validation des champs supplémentaires pour les abonnements familiaux
                // ----------------------------------------------------------------------

                switch (Convert.ToInt32(typesAbonnementComboBox.SelectedValue))
                {
                    case 3: // Conjoint
                        if (String.IsNullOrWhiteSpace(nomConjointTextBox.Text) ||
                            String.IsNullOrWhiteSpace(prenomConjointTextBox.Text) ||
                            String.IsNullOrWhiteSpace(comboBoxSexeConjoint.Text))
                        {
                            throw new Exception("Veuillez remplir tous les champs obligatoires pour le conjoint.");
                        }
                        if (dateNaissanceConjointTimePicker.Value >= dateAbonnementDateTimePicker.Value)
                        {
                            throw new Exception("La date de naissance du conjoint doit être antérieure à la date d'abonnement.");
                        }
                        if (dateAbonnementDateTimePicker.Value.Year - dateNaissanceConjointTimePicker.Value.Year < 18)
                        {
                            throw new Exception("Le conjoint doit avoir au moins 18 ans au moment de l'abonnement.");
                        }
                        break;
                    case 4: // Famille (couple + 1 enfant)
                        if (String.IsNullOrWhiteSpace(nomConjointTextBox.Text) ||
                            String.IsNullOrWhiteSpace(prenomConjointTextBox.Text) ||
                            String.IsNullOrWhiteSpace(comboBoxSexeConjoint.Text) ||
                            String.IsNullOrWhiteSpace(nomEnfantTextBox1.Text) ||
                            String.IsNullOrWhiteSpace(prenomEnfantTextBox1.Text))
                        {
                            throw new Exception("Veuillez remplir tous les champs obligatoires pour le conjoint et l'enfant.");
                        }
                        if (dateNaissanceConjointTimePicker.Value >= dateAbonnementDateTimePicker.Value)
                        {
                            throw new Exception("La date de naissance du conjoint doit être antérieure à la date d'abonnement.");
                        }
                        if (dateAbonnementDateTimePicker.Value.Year - dateNaissanceConjointTimePicker.Value.Year < 18)
                        {
                            throw new Exception("Le conjoint doit avoir au moins 18 ans au moment de l'abonnement.");
                        }
                        if (dateAbonnementDateTimePicker.Value.Year - dateNaissanceEnfantTimePicker1.Value.Year >= 18)
                        {
                            throw new Exception("Les enfants doivent être moins 18 ans au moment de l'abonnement.");
                        }
                        break;
                    case 5: // Famille (couple + 2 enfants)
                        if (String.IsNullOrWhiteSpace(nomConjointTextBox.Text) ||
                            String.IsNullOrWhiteSpace(prenomConjointTextBox.Text) ||
                            String.IsNullOrWhiteSpace(comboBoxSexeConjoint.Text) ||
                            String.IsNullOrWhiteSpace(nomEnfantTextBox1.Text) ||
                            String.IsNullOrWhiteSpace(prenomEnfantTextBox1.Text) ||
                            String.IsNullOrWhiteSpace(nomEnfantTextBox2.Text) ||
                            String.IsNullOrWhiteSpace(prenomEnfantTextBox2.Text))
                        {
                            throw new Exception("Veuillez remplir tous les champs obligatoires pour le conjoint et les enfants.");
                        }
                        if (dateNaissanceConjointTimePicker.Value >= dateAbonnementDateTimePicker.Value)
                        {
                            throw new Exception("La date de naissance du conjoint doit être antérieure à la date d'abonnement.");
                        }
                        if (dateAbonnementDateTimePicker.Value.Year - dateNaissanceConjointTimePicker.Value.Year < 18)
                        {
                            throw new Exception("Le conjoint doit avoir au moins 18 ans au moment de l'abonnement.");
                        }
                        if (dateAbonnementDateTimePicker.Value.Year - dateNaissanceEnfantTimePicker1.Value.Year >= 18 &&
                            dateAbonnementDateTimePicker.Value.Year - dateNaissanceEnfantTimePicker2.Value.Year >= 18)
                        {
                            throw new Exception("Les enfants doivent être moins 18 ans au moment de l'abonnement.");
                        }


                        break;
                    case 6: // Famille (couple + 3 ou plus enfants)

                        if (String.IsNullOrWhiteSpace(nomConjointTextBox.Text) ||
                            String.IsNullOrWhiteSpace(prenomConjointTextBox.Text) ||
                            String.IsNullOrWhiteSpace(comboBoxSexeConjoint.Text))
                        {
                            throw new Exception("Veuillez remplir tous les champs obligatoires pour le conjoint.");
                        }
                        if (dateNaissanceConjointTimePicker.Value >= dateAbonnementDateTimePicker.Value)
                        {
                            throw new Exception("La date de naissance du conjoint doit être antérieure à la date d'abonnement.");
                        }
                        if (dateAbonnementDateTimePicker.Value.Year - dateNaissanceConjointTimePicker.Value.Year < 18)
                        {
                            throw new Exception("Le conjoint doit avoir au moins 18 ans au moment de l'abonnement.");
                        }

                        List<(string nom, string prenom, DateTime dateNaissance)> lstInfoEnfants = new List<(string nom, string prenom, DateTime dateNaissance)>();
                        lstInfoEnfants.Add((nomEnfantTextBox1.Text, prenomEnfantTextBox1.Text, dateNaissanceEnfantTimePicker1.Value));
                        lstInfoEnfants.Add((nomEnfantTextBox2.Text, prenomEnfantTextBox2.Text, dateNaissanceEnfantTimePicker2.Value));
                        lstInfoEnfants.Add((nomEnfantTextBox3.Text, prenomEnfantTextBox3.Text, dateNaissanceEnfantTimePicker3.Value));
                        lstInfoEnfants.Add((nomEnfantTextBox4.Text, prenomEnfantTextBox4.Text, dateNaissanceEnfantTimePicker4.Value));
                        lstInfoEnfants.Add((nomEnfantTextBox5.Text, prenomEnfantTextBox5.Text, dateNaissanceEnfantTimePicker5.Value));
                        lstInfoEnfants.Add((nomEnfantTextBox6.Text, prenomEnfantTextBox6.Text, dateNaissanceEnfantTimePicker6.Value));
                        lstInfoEnfants.Add((nomEnfantTextBox7.Text, prenomEnfantTextBox7.Text, dateNaissanceEnfantTimePicker7.Value));
                        lstInfoEnfants.Add((nomEnfantTextBox8.Text, prenomEnfantTextBox8.Text, dateNaissanceEnfantTimePicker8.Value));
                        lstInfoEnfants.Add((nomEnfantTextBox9.Text, prenomEnfantTextBox9.Text, dateNaissanceEnfantTimePicker9.Value));

                        for (int i = 1; i < nbEnfantnumericUpDown.Value; i++)
                        {
                            if (String.IsNullOrWhiteSpace(lstInfoEnfants[i].nom) ||
                                String.IsNullOrWhiteSpace(lstInfoEnfants[i].prenom))
                            {
                                throw new Exception("Veuillez remplir tous les champs obligatoires pour le conjoint et les enfants.");
                            }
                            if (dateAbonnementDateTimePicker.Value.Year - lstInfoEnfants[i].dateNaissance.Year >= 18)
                            {
                                throw new Exception("Les enfants doivent être moins 18 ans au moment de l'abonnement.");
                            }
                        }

                        break;
                }

                // ----------------------------------------------------------------------
                // LINQ to SQL - Enregistrement de l'abonnement (TODO)
                // ----------------------------------------------------------------------

                // Reformatter les informations saisies afin que ça soit uniforme dans la base de données
                var nomFormate = "";
                var codePostalFormate = codePostalTextBox.Text.Replace(" ", "");
                var telephoneFormate = telephoneTextBox.Text.Replace(" ", "").Replace("-", "");
                var cellulaireFormate = cellulaireTextBox.Text.Replace(" ", "").Replace("-", "");

                if (nomTextBox.Text.Length > 8)
                {
                    nomFormate = nomTextBox.Text.Substring(0, 7);
                }
                else
                {
                    nomFormate = nomTextBox.Text;
                }


                // Insérer l'abonné à une personne
                if (Convert.ToInt32(typesAbonnementComboBox.SelectedValue) == 1 ||
                    Convert.ToInt32(typesAbonnementComboBox.SelectedValue) == 2)
                {

                    int nombre = (from abonnement in db.Abonnements
                                  where abonnement.Nom == nomTextBox.Text
                                  select abonnement).Count() + 1;

                    var province = (from prov in db.Provinces
                                    where prov.Id == provincesComboBox.SelectedValue.ToString()
                                    select prov).FirstOrDefault();

                    Abonnements abonnements = new Abonnements
                    {
                        Id = nomFormate + nombre + 'P' + 0,
                        Nom = nomTextBox.Text,
                        Prenom = prenomTextBox.Text,
                        DateNaissance = dateNaissanceDateTimePicker.Value,
                        Rue = rueTextBox.Text,
                        NoCivique = noCiviqueTextBox.Text,
                        Ville = villeTextBox.Text,
                        CodePostal = codePostalFormate,
                        Telephone = telephoneFormate,
                        Cellulaire = cellulaireFormate,
                        Courriel = courrielTextBox.Text,
                        DateAbonnement = dateAbonnementDateTimePicker.Value,
                        Provinces = province,
                        Sexe = Convert.ToChar(comboBoxSexe.Text),
                        NoTypeAbonnement = Convert.ToInt32(typesAbonnementComboBox.SelectedValue)
                    };

                    db.Abonnements.InsertOnSubmit(abonnements);
                    db.SubmitChanges();

                    MessageBox.Show("Nouveau abonnement ajouté! Voici l'ID du nouvelle abonnement:" + nomTextBox.Text + nombre + 'P', "Nouveulle enregistrement!");
                    this.Close();
                }
                // Insérer l'abonné à un couple
                else if (Convert.ToInt32(typesAbonnementComboBox.SelectedValue) == 3)
                {
                    int nombre = (from abonnement in db.Abonnements
                                  where abonnement.Nom == nomTextBox.Text
                                  select abonnement).Count() + 1;

                    var province = (from prov in db.Provinces
                                    where prov.Id == provincesComboBox.SelectedValue.ToString()
                                    select prov).FirstOrDefault();

                    Abonnements abonnements = new Abonnements
                    {
                        Id = nomFormate + nombre + Convert.ToChar(comboBoxSexe.Text) + 0,
                        Nom = nomTextBox.Text,
                        Prenom = prenomTextBox.Text,
                        DateNaissance = dateNaissanceDateTimePicker.Value,
                        Rue = rueTextBox.Text,
                        NoCivique = noCiviqueTextBox.Text,
                        Ville = villeTextBox.Text,
                        CodePostal = codePostalFormate,
                        Telephone = telephoneFormate,
                        Cellulaire = cellulaireFormate,
                        Courriel = courrielTextBox.Text,
                        DateAbonnement = dateAbonnementDateTimePicker.Value,
                        Provinces = province,
                        Sexe = Convert.ToChar(comboBoxSexe.Text),
                        NoTypeAbonnement = Convert.ToInt32(typesAbonnementComboBox.SelectedValue)
                    };

                    Dependants dependantsConjoint = new Dependants
                    {
                        Id = nomFormate + nombre + Convert.ToChar(comboBoxSexeConjoint.Text) + 0,
                        Nom = nomConjointTextBox.Text,
                        Prenom = prenomConjointTextBox.Text,
                        Sexe = Convert.ToChar(comboBoxSexeConjoint.Text),
                        DateNaissance = dateNaissanceConjointTimePicker.Value,
                        IdAbonnement = nomFormate + nombre + Convert.ToChar(comboBoxSexe.Text) + 0,
                        Remarque = remarqueConjointTextBox.Text
                    };

                    db.Abonnements.InsertOnSubmit(abonnements);
                    db.SubmitChanges();
                    db.Dependants.InsertOnSubmit(dependantsConjoint);
                    db.SubmitChanges();

                    MessageBox.Show("Nouveau abonnement ajouté! Voici les IDs du nouvelle abonnement: \n"
                                    + nomTextBox.Text + nombre + Convert.ToChar(comboBoxSexe.Text) + 0 + "\n"
                                    + nomTextBox.Text + nombre + Convert.ToChar(comboBoxSexeConjoint.Text) + 0
                                    , "Nouveulle enregistrement!");
                    this.Close();
                }
                // Insérer l'abonné à une famille
                else if (Convert.ToInt32(typesAbonnementComboBox.SelectedValue) == 4 ||
                         Convert.ToInt32(typesAbonnementComboBox.SelectedValue) == 5 ||
                         Convert.ToInt32(typesAbonnementComboBox.SelectedValue) == 6)
                {
                    int nombre = (from abonnement in db.Abonnements
                                  where abonnement.Nom == nomTextBox.Text
                                  select abonnement).Count() + 1;

                    var province = (from prov in db.Provinces
                                    where prov.Id == provincesComboBox.SelectedValue.ToString()
                                    select prov).FirstOrDefault();

                    Abonnements abonnements = new Abonnements
                    {
                        Id = nomFormate + nombre + Convert.ToChar(comboBoxSexe.Text) + 0,
                        Nom = nomTextBox.Text,
                        Prenom = prenomTextBox.Text,
                        DateNaissance = dateNaissanceDateTimePicker.Value,
                        Rue = rueTextBox.Text,
                        NoCivique = noCiviqueTextBox.Text,
                        Ville = villeTextBox.Text,
                        CodePostal = codePostalFormate,
                        Telephone = telephoneFormate,
                        Cellulaire = cellulaireFormate,
                        Courriel = courrielTextBox.Text,
                        DateAbonnement = dateAbonnementDateTimePicker.Value,
                        Provinces = province,
                        Sexe = Convert.ToChar(comboBoxSexe.Text),
                        NoTypeAbonnement = Convert.ToInt32(typesAbonnementComboBox.SelectedValue)
                    };

                    db.Abonnements.InsertOnSubmit(abonnements);
                    db.SubmitChanges();

                    Dependants dependantsConjoint = new Dependants
                    {
                        Id = nomFormate + nombre + Convert.ToChar(comboBoxSexeConjoint.Text) + 0,
                        Nom = nomConjointTextBox.Text,
                        Prenom = prenomConjointTextBox.Text,
                        Sexe = Convert.ToChar(comboBoxSexeConjoint.Text),
                        IdAbonnement = nomFormate + nombre + Convert.ToChar(comboBoxSexe.Text) + 0,
                        Remarque = remarqueConjointTextBox.Text
                    };

                    db.Dependants.InsertOnSubmit(dependantsConjoint);
                    db.SubmitChanges();

                    List<(string nom, string prenom, char sexe, DateTime dateNaissance)> lstInfoEnfants = new List<(string nom, string prenom, char sexe, DateTime dateNaissance)>();
                    lstInfoEnfants.Add((nomEnfantTextBox1.Text, prenomEnfantTextBox1.Text, Convert.ToChar(enfantSexeComboBox1.SelectedValue), dateNaissanceEnfantTimePicker1.Value));
                    lstInfoEnfants.Add((nomEnfantTextBox2.Text, prenomEnfantTextBox2.Text, Convert.ToChar(enfantSexeComboBox2.SelectedValue), dateNaissanceEnfantTimePicker2.Value));
                    lstInfoEnfants.Add((nomEnfantTextBox3.Text, prenomEnfantTextBox3.Text, Convert.ToChar(enfantSexeComboBox3.SelectedValue), dateNaissanceEnfantTimePicker3.Value));
                    lstInfoEnfants.Add((nomEnfantTextBox4.Text, prenomEnfantTextBox4.Text, Convert.ToChar(enfantSexeComboBox4.SelectedValue), dateNaissanceEnfantTimePicker4.Value));
                    lstInfoEnfants.Add((nomEnfantTextBox5.Text, prenomEnfantTextBox5.Text, Convert.ToChar(enfantSexeComboBox5.SelectedValue), dateNaissanceEnfantTimePicker5.Value));
                    lstInfoEnfants.Add((nomEnfantTextBox6.Text, prenomEnfantTextBox6.Text, Convert.ToChar(enfantSexeComboBox6.SelectedValue), dateNaissanceEnfantTimePicker6.Value));
                    lstInfoEnfants.Add((nomEnfantTextBox7.Text, prenomEnfantTextBox7.Text, Convert.ToChar(enfantSexeComboBox7.SelectedValue), dateNaissanceEnfantTimePicker7.Value));
                    lstInfoEnfants.Add((nomEnfantTextBox8.Text, prenomEnfantTextBox8.Text, Convert.ToChar(enfantSexeComboBox8.SelectedValue), dateNaissanceEnfantTimePicker8.Value));
                    lstInfoEnfants.Add((nomEnfantTextBox9.Text, prenomEnfantTextBox9.Text, Convert.ToChar(enfantSexeComboBox9.SelectedValue), dateNaissanceEnfantTimePicker9.Value));

                    for (int i = 0; i < nbEnfantnumericUpDown.Value; i++)
                    {
                        var nomEnfantFormate = "";

                        if (lstInfoEnfants[i].nom.Length > 8)
                        {
                            nomEnfantFormate = lstInfoEnfants[i].nom.Substring(0, 8);
                        }
                        else
                        {
                            nomEnfantFormate = lstInfoEnfants[i].nom;
                        }

                        Dependants dependantsEnfant = new Dependants
                        {
                            Id = nomEnfantFormate + nombre + 'E' + (i + 1),
                            Nom = lstInfoEnfants[i].nom,
                            Prenom = lstInfoEnfants[i].prenom,
                            Sexe = lstInfoEnfants[i].sexe,
                            IdAbonnement = nomFormate + nombre + Convert.ToChar(comboBoxSexe.Text) + 0,
                            Remarque = "Parents - " + prenomConjointTextBox.Text + " " + nomConjointTextBox.Text + " et " + prenomTextBox.Text + " " + nomTextBox.Text
                        };

                        db.Dependants.InsertOnSubmit(dependantsEnfant);
                        db.SubmitChanges();
                    }

                    MessageBox.Show("Les nouvelles abonnements pour la famille est ajouté!" , "Nouveulle enregistrement!");
                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de l'enregistrement de l'abonnement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void typesAbonnementComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ----------------------------------------------------------------------
            // Afficher les champs supplémentaires en fonction du type d'abonnement sélectionné
            // ----------------------------------------------------------------------

            // Reset la visibilité de tous les champs supplémentaires

            subtitre1.Visible = false;
            nomConjointTextBox.Visible = false;
            nomConjointTextBox.Text = "";
            prenomConjointTextBox.Visible = false;
            prenomConjointTextBox.Text = "";
            dateNaissanceConjointTimePicker.Visible = false;
            comboBoxSexeConjoint.Visible = false;
            remarqueConjointTextBox.Visible = false;
            remarqueConjointTextBox.Text = "";

            enfantnomLabel.Visible = false;
            enfantprenomLabel.Visible = false;
            enfantDateNaissanceLabel.Visible = false;
            enfantSexeLabel.Visible = false;

            subtitre2.Visible = false;
            nbEnfantnumericUpDown.Visible = false;


            nomEnfantTextBox1.Visible = false;
            nomEnfantTextBox1.Text = "";
            prenomEnfantTextBox1.Visible = false;
            prenomEnfantTextBox1.Text = "";
            enfantSexeComboBox1.Visible = false;
            dateNaissanceEnfantTimePicker1.Visible = false;

            nomEnfantTextBox2.Visible = false;
            nomEnfantTextBox2.Text = "";
            prenomEnfantTextBox2.Visible = false;
            prenomEnfantTextBox2.Text = "";
            enfantSexeComboBox2.Visible = false;
            dateNaissanceEnfantTimePicker2.Visible = false;

            nomEnfantTextBox3.Visible = false;
            nomEnfantTextBox3.Text = "";
            prenomEnfantTextBox3.Visible = false;
            prenomEnfantTextBox3.Text = "";
            enfantSexeComboBox3.Visible = false;
            dateNaissanceEnfantTimePicker3.Visible = false;

            nomEnfantTextBox4.Visible = false;
            nomEnfantTextBox4.Text = "";
            prenomEnfantTextBox4.Visible = false;
            prenomEnfantTextBox4.Text = "";
            enfantSexeComboBox4.Visible = false;
            dateNaissanceEnfantTimePicker4.Visible = false;

            nomEnfantTextBox5.Visible = false;
            nomEnfantTextBox5.Text = "";
            prenomEnfantTextBox5.Visible = false;
            prenomEnfantTextBox5.Text = "";
            enfantSexeComboBox5.Visible = false;
            dateNaissanceEnfantTimePicker5.Visible = false;

            nomEnfantTextBox6.Visible = false;
            nomEnfantTextBox6.Text = "";
            prenomEnfantTextBox6.Visible = false;
            prenomEnfantTextBox6.Text = "";
            enfantSexeComboBox6.Visible = false;
            dateNaissanceEnfantTimePicker6.Visible = false;

            nomEnfantTextBox7.Visible = false;
            nomEnfantTextBox7.Text = "";
            prenomEnfantTextBox7.Visible = false;
            prenomEnfantTextBox7.Text = "";
            enfantSexeComboBox7.Visible = false;
            dateNaissanceEnfantTimePicker7.Visible = false;

            nomEnfantTextBox8.Visible = false;
            nomEnfantTextBox8.Text = "";
            prenomEnfantTextBox8.Visible = false;
            prenomEnfantTextBox8.Text = "";
            enfantSexeComboBox8.Visible = false;
            dateNaissanceEnfantTimePicker8.Visible = false;

            nomEnfantTextBox9.Visible = false;
            nomEnfantTextBox9.Text = "";
            prenomEnfantTextBox9.Visible = false;
            prenomEnfantTextBox9.Text = "";
            enfantSexeComboBox9.Visible = false;
            dateNaissanceEnfantTimePicker9.Visible = false;

            //Réafficher les champs nécessaires selon le type d'abonnement sélectionné
            if (Convert.ToInt32(typesAbonnementComboBox.SelectedValue) == 1)
            {
                // Ne rien afficher de plus
                subtitre1.Visible = false;
                nomConjointTextBox.Visible = false;
                nomConjointTextBox.Text = "";
                prenomConjointTextBox.Visible = false;
                prenomConjointTextBox.Text = "";
                dateNaissanceConjointTimePicker.Visible = false;
                comboBoxSexeConjoint.Visible = false;
                remarqueConjointTextBox.Visible = false;
                remarqueConjointTextBox.Text = "";

                enfantnomLabel.Visible = false;
                enfantprenomLabel.Visible = false;
                enfantDateNaissanceLabel.Visible = false;
                enfantSexeLabel.Visible = false;

                subtitre2.Visible = false;
                nbEnfantnumericUpDown.Visible = false;


                nomEnfantTextBox1.Visible = false;
                nomEnfantTextBox1.Text = "";
                prenomEnfantTextBox1.Visible = false;
                prenomEnfantTextBox1.Text = "";
                enfantSexeComboBox1.Visible = false;
                dateNaissanceEnfantTimePicker1.Visible = false;

                nomEnfantTextBox2.Visible = false;
                nomEnfantTextBox2.Text = "";
                prenomEnfantTextBox2.Visible = false;
                prenomEnfantTextBox2.Text = "";
                enfantSexeComboBox2.Visible = false;
                dateNaissanceEnfantTimePicker2.Visible = false;

                nomEnfantTextBox3.Visible = false;
                nomEnfantTextBox3.Text = "";
                prenomEnfantTextBox3.Visible = false;
                prenomEnfantTextBox3.Text = "";
                enfantSexeComboBox3.Visible = false;
                dateNaissanceEnfantTimePicker3.Visible = false;

                nomEnfantTextBox4.Visible = false;
                nomEnfantTextBox4.Text = "";
                prenomEnfantTextBox4.Visible = false;
                prenomEnfantTextBox4.Text = "";
                enfantSexeComboBox4.Visible = false;
                dateNaissanceEnfantTimePicker4.Visible = false;

                nomEnfantTextBox5.Visible = false;
                nomEnfantTextBox5.Text = "";
                prenomEnfantTextBox5.Visible = false;
                prenomEnfantTextBox5.Text = "";
                enfantSexeComboBox5.Visible = false;
                dateNaissanceEnfantTimePicker5.Visible = false;

                nomEnfantTextBox6.Visible = false;
                nomEnfantTextBox6.Text = "";
                prenomEnfantTextBox6.Visible = false;
                prenomEnfantTextBox6.Text = "";
                enfantSexeComboBox6.Visible = false;
                dateNaissanceEnfantTimePicker6.Visible = false;

                nomEnfantTextBox7.Visible = false;
                nomEnfantTextBox7.Text = "";
                prenomEnfantTextBox7.Visible = false;
                prenomEnfantTextBox7.Text = "";
                enfantSexeComboBox7.Visible = false;
                dateNaissanceEnfantTimePicker7.Visible = false;

                nomEnfantTextBox8.Visible = false;
                nomEnfantTextBox8.Text = "";
                prenomEnfantTextBox8.Visible = false;
                prenomEnfantTextBox8.Text = "";
                enfantSexeComboBox8.Visible = false;
                dateNaissanceEnfantTimePicker8.Visible = false;

                nomEnfantTextBox9.Visible = false;
                nomEnfantTextBox9.Text = "";
                prenomEnfantTextBox9.Visible = false;
                prenomEnfantTextBox9.Text = "";
                enfantSexeComboBox9.Visible = false;
                dateNaissanceEnfantTimePicker9.Visible = false;
            }
            else if (Convert.ToInt32(typesAbonnementComboBox.SelectedValue) == 2)
            {
                // Ne rien afficher de plus
                subtitre1.Visible = false;
                nomConjointTextBox.Visible = false;
                nomConjointTextBox.Text = "";
                prenomConjointTextBox.Visible = false;
                prenomConjointTextBox.Text = "";
                dateNaissanceConjointTimePicker.Visible = false;
                comboBoxSexeConjoint.Visible = false;
                remarqueConjointTextBox.Visible = false;
                remarqueConjointTextBox.Text = "";

                enfantnomLabel.Visible = false;
                enfantprenomLabel.Visible = false;
                enfantDateNaissanceLabel.Visible = false;
                enfantSexeLabel.Visible = false;

                subtitre2.Visible = false;
                nbEnfantnumericUpDown.Visible = false;


                nomEnfantTextBox1.Visible = false;
                nomEnfantTextBox1.Text = "";
                prenomEnfantTextBox1.Visible = false;
                prenomEnfantTextBox1.Text = "";
                enfantSexeComboBox1.Visible = false;
                dateNaissanceEnfantTimePicker1.Visible = false;

                nomEnfantTextBox2.Visible = false;
                nomEnfantTextBox2.Text = "";
                prenomEnfantTextBox2.Visible = false;
                prenomEnfantTextBox2.Text = "";
                enfantSexeComboBox2.Visible = false;
                dateNaissanceEnfantTimePicker2.Visible = false;

                nomEnfantTextBox3.Visible = false;
                nomEnfantTextBox3.Text = "";
                prenomEnfantTextBox3.Visible = false;
                prenomEnfantTextBox3.Text = "";
                enfantSexeComboBox3.Visible = false;
                dateNaissanceEnfantTimePicker3.Visible = false;

                nomEnfantTextBox4.Visible = false;
                nomEnfantTextBox4.Text = "";
                prenomEnfantTextBox4.Visible = false;
                prenomEnfantTextBox4.Text = "";
                enfantSexeComboBox4.Visible = false;
                dateNaissanceEnfantTimePicker4.Visible = false;

                nomEnfantTextBox5.Visible = false;
                nomEnfantTextBox5.Text = "";
                prenomEnfantTextBox5.Visible = false;
                prenomEnfantTextBox5.Text = "";
                enfantSexeComboBox5.Visible = false;
                dateNaissanceEnfantTimePicker5.Visible = false;

                nomEnfantTextBox6.Visible = false;
                nomEnfantTextBox6.Text = "";
                prenomEnfantTextBox6.Visible = false;
                prenomEnfantTextBox6.Text = "";
                enfantSexeComboBox6.Visible = false;
                dateNaissanceEnfantTimePicker6.Visible = false;

                nomEnfantTextBox7.Visible = false;
                nomEnfantTextBox7.Text = "";
                prenomEnfantTextBox7.Visible = false;
                prenomEnfantTextBox7.Text = "";
                enfantSexeComboBox7.Visible = false;
                dateNaissanceEnfantTimePicker7.Visible = false;

                nomEnfantTextBox8.Visible = false;
                nomEnfantTextBox8.Text = "";
                prenomEnfantTextBox8.Visible = false;
                prenomEnfantTextBox8.Text = "";
                enfantSexeComboBox8.Visible = false;
                dateNaissanceEnfantTimePicker8.Visible = false;

                nomEnfantTextBox9.Visible = false;
                nomEnfantTextBox9.Text = "";
                prenomEnfantTextBox9.Visible = false;
                prenomEnfantTextBox9.Text = "";
                enfantSexeComboBox9.Visible = false;
                dateNaissanceEnfantTimePicker9.Visible = false;
            }
            //Afficher les champs pour l'abonnement type "Couple"
            else if (Convert.ToInt32(typesAbonnementComboBox.SelectedValue) == 3)
            {
                subtitre1.Visible = true;
                nomConjointTextBox.Visible = true;
                nomConjointTextBox.Text = "";
                prenomConjointTextBox.Visible = true;
                prenomConjointTextBox.Text = "";
                dateNaissanceConjointTimePicker.Visible = true;
                comboBoxSexeConjoint.Visible = true;
                remarqueConjointTextBox.Visible = true;
                remarqueConjointTextBox.Text = "";

                enfantnomLabel.Visible = false;
                enfantprenomLabel.Visible = false;
                enfantDateNaissanceLabel.Visible = false;
                enfantSexeLabel.Visible = false;

                subtitre2.Visible = false;
                nbEnfantnumericUpDown.Visible = false;


                nomEnfantTextBox1.Visible = false;
                nomEnfantTextBox1.Text = "";
                prenomEnfantTextBox1.Visible = false;
                prenomEnfantTextBox1.Text = "";
                enfantSexeComboBox1.Visible = false;
                dateNaissanceEnfantTimePicker1.Visible = false;

                nomEnfantTextBox2.Visible = false;
                nomEnfantTextBox2.Text = "";
                prenomEnfantTextBox2.Visible = false;
                prenomEnfantTextBox2.Text = "";
                enfantSexeComboBox2.Visible = false;
                dateNaissanceEnfantTimePicker2.Visible = false;

                nomEnfantTextBox3.Visible = false;
                nomEnfantTextBox3.Text = "";
                prenomEnfantTextBox3.Visible = false;
                prenomEnfantTextBox3.Text = "";
                enfantSexeComboBox3.Visible = false;
                dateNaissanceEnfantTimePicker3.Visible = false;

                nomEnfantTextBox4.Visible = false;
                nomEnfantTextBox4.Text = "";
                prenomEnfantTextBox4.Visible = false;
                prenomEnfantTextBox4.Text = "";
                enfantSexeComboBox4.Visible = false;
                dateNaissanceEnfantTimePicker4.Visible = false;

                nomEnfantTextBox5.Visible = false;
                nomEnfantTextBox5.Text = "";
                prenomEnfantTextBox5.Visible = false;
                prenomEnfantTextBox5.Text = "";
                enfantSexeComboBox5.Visible = false;
                dateNaissanceEnfantTimePicker5.Visible = false;

                nomEnfantTextBox6.Visible = false;
                nomEnfantTextBox6.Text = "";
                prenomEnfantTextBox6.Visible = false;
                prenomEnfantTextBox6.Text = "";
                enfantSexeComboBox6.Visible = false;
                dateNaissanceEnfantTimePicker6.Visible = false;

                nomEnfantTextBox7.Visible = false;
                nomEnfantTextBox7.Text = "";
                prenomEnfantTextBox7.Visible = false;
                prenomEnfantTextBox7.Text = "";
                enfantSexeComboBox7.Visible = false;
                dateNaissanceEnfantTimePicker7.Visible = false;

                nomEnfantTextBox8.Visible = false;
                nomEnfantTextBox8.Text = "";
                prenomEnfantTextBox8.Visible = false;
                prenomEnfantTextBox8.Text = "";
                enfantSexeComboBox8.Visible = false;
                dateNaissanceEnfantTimePicker8.Visible = false;

                nomEnfantTextBox9.Visible = false;
                nomEnfantTextBox9.Text = "";
                prenomEnfantTextBox9.Visible = false;
                prenomEnfantTextBox9.Text = "";
                enfantSexeComboBox9.Visible = false;
                dateNaissanceEnfantTimePicker9.Visible = false;
            }
            // Afficher les champs pour l'abonnement type "Famille (couple + 1 enfant)"
            else if (Convert.ToInt32(typesAbonnementComboBox.SelectedValue) == 4)
            {
                subtitre1.Visible = true;
                nomConjointTextBox.Visible = true;
                nomConjointTextBox.Text = "";
                prenomConjointTextBox.Visible = true;
                prenomConjointTextBox.Text = "";
                dateNaissanceConjointTimePicker.Visible = true;
                comboBoxSexeConjoint.Visible = true;
                remarqueConjointTextBox.Visible = true;
                remarqueConjointTextBox.Text = "";

                enfantnomLabel.Visible = true;
                enfantprenomLabel.Visible = true;
                enfantDateNaissanceLabel.Visible = true;
                enfantSexeLabel.Visible = true;

                subtitre2.Visible = false;
                nbEnfantnumericUpDown.Visible = false;


                nomEnfantTextBox1.Visible = true;
                nomEnfantTextBox1.Text = "";
                prenomEnfantTextBox1.Visible = true;
                prenomEnfantTextBox1.Text = "";
                enfantSexeComboBox1.Visible = true;
                dateNaissanceEnfantTimePicker1.Visible = true;

                nomEnfantTextBox2.Visible = false;
                nomEnfantTextBox2.Text = "";
                prenomEnfantTextBox2.Visible = false;
                prenomEnfantTextBox2.Text = "";
                enfantSexeComboBox2.Visible = false;
                dateNaissanceEnfantTimePicker2.Visible = false;

                nomEnfantTextBox3.Visible = false;
                nomEnfantTextBox3.Text = "";
                prenomEnfantTextBox3.Visible = false;
                prenomEnfantTextBox3.Text = "";
                enfantSexeComboBox3.Visible = false;
                dateNaissanceEnfantTimePicker3.Visible = false;

                nomEnfantTextBox4.Visible = false;
                nomEnfantTextBox4.Text = "";
                prenomEnfantTextBox4.Visible = false;
                prenomEnfantTextBox4.Text = "";
                enfantSexeComboBox4.Visible = false;
                dateNaissanceEnfantTimePicker4.Visible = false;

                nomEnfantTextBox5.Visible = false;
                nomEnfantTextBox5.Text = "";
                prenomEnfantTextBox5.Visible = false;
                prenomEnfantTextBox5.Text = "";
                enfantSexeComboBox5.Visible = false;
                dateNaissanceEnfantTimePicker5.Visible = false;

                nomEnfantTextBox6.Visible = false;
                nomEnfantTextBox6.Text = "";
                prenomEnfantTextBox6.Visible = false;
                prenomEnfantTextBox6.Text = "";
                enfantSexeComboBox6.Visible = false;
                dateNaissanceEnfantTimePicker6.Visible = false;

                nomEnfantTextBox7.Visible = false;
                nomEnfantTextBox7.Text = "";
                prenomEnfantTextBox7.Visible = false;
                prenomEnfantTextBox7.Text = "";
                enfantSexeComboBox7.Visible = false;
                dateNaissanceEnfantTimePicker7.Visible = false;

                nomEnfantTextBox8.Visible = false;
                nomEnfantTextBox8.Text = "";
                prenomEnfantTextBox8.Visible = false;
                prenomEnfantTextBox8.Text = "";
                enfantSexeComboBox8.Visible = false;
                dateNaissanceEnfantTimePicker8.Visible = false;

                nomEnfantTextBox9.Visible = false;
                nomEnfantTextBox9.Text = "";
                prenomEnfantTextBox9.Visible = false;
                prenomEnfantTextBox9.Text = "";
                enfantSexeComboBox9.Visible = false;
                dateNaissanceEnfantTimePicker9.Visible = false;
            }
            // Afficher les champs pour l'abonnement type "Famille (couple + 2 enfant)"
            else if (Convert.ToInt32(typesAbonnementComboBox.SelectedValue) == 5)
            {
                subtitre1.Visible = true;
                nomConjointTextBox.Visible = true;
                nomConjointTextBox.Text = "";
                prenomConjointTextBox.Visible = true;
                prenomConjointTextBox.Text = "";
                dateNaissanceConjointTimePicker.Visible = true;
                comboBoxSexeConjoint.Visible = true;
                remarqueConjointTextBox.Visible = true;
                remarqueConjointTextBox.Text = "";

                enfantnomLabel.Visible = true;
                enfantprenomLabel.Visible = true;
                enfantDateNaissanceLabel.Visible = true;
                enfantSexeLabel.Visible = true;

                subtitre2.Visible = false;
                nbEnfantnumericUpDown.Visible = false;


                nomEnfantTextBox1.Visible = true;
                nomEnfantTextBox1.Text = "";
                prenomEnfantTextBox1.Visible = true;
                prenomEnfantTextBox1.Text = "";
                enfantSexeComboBox1.Visible = true;
                dateNaissanceEnfantTimePicker1.Visible = true;

                nomEnfantTextBox2.Visible = true;
                nomEnfantTextBox2.Text = "";
                prenomEnfantTextBox2.Visible = true;
                prenomEnfantTextBox2.Text = "";
                enfantSexeComboBox2.Visible = true;
                dateNaissanceEnfantTimePicker2.Visible = true;

                nomEnfantTextBox3.Visible = false;
                nomEnfantTextBox3.Text = "";
                prenomEnfantTextBox3.Visible = false;
                prenomEnfantTextBox3.Text = "";
                enfantSexeComboBox3.Visible = false;
                dateNaissanceEnfantTimePicker3.Visible = false;

                nomEnfantTextBox4.Visible = false;
                nomEnfantTextBox4.Text = "";
                prenomEnfantTextBox4.Visible = false;
                prenomEnfantTextBox4.Text = "";
                enfantSexeComboBox4.Visible = false;
                dateNaissanceEnfantTimePicker4.Visible = false;

                nomEnfantTextBox5.Visible = false;
                nomEnfantTextBox5.Text = "";
                prenomEnfantTextBox5.Visible = false;
                prenomEnfantTextBox5.Text = "";
                enfantSexeComboBox5.Visible = false;
                dateNaissanceEnfantTimePicker5.Visible = false;

                nomEnfantTextBox6.Visible = false;
                nomEnfantTextBox6.Text = "";
                prenomEnfantTextBox6.Visible = false;
                prenomEnfantTextBox6.Text = "";
                enfantSexeComboBox6.Visible = false;
                dateNaissanceEnfantTimePicker6.Visible = false;

                nomEnfantTextBox7.Visible = false;
                nomEnfantTextBox7.Text = "";
                prenomEnfantTextBox7.Visible = false;
                prenomEnfantTextBox7.Text = "";
                enfantSexeComboBox7.Visible = false;
                dateNaissanceEnfantTimePicker7.Visible = false;

                nomEnfantTextBox8.Visible = false;
                nomEnfantTextBox8.Text = "";
                prenomEnfantTextBox8.Visible = false;
                prenomEnfantTextBox8.Text = "";
                enfantSexeComboBox8.Visible = false;
                dateNaissanceEnfantTimePicker8.Visible = false;

                nomEnfantTextBox9.Visible = false;
                nomEnfantTextBox9.Text = "";
                prenomEnfantTextBox9.Visible = false;
                prenomEnfantTextBox9.Text = "";
                enfantSexeComboBox9.Visible = false;
                dateNaissanceEnfantTimePicker9.Visible = false;
            }
            // Afficher les champs pour l'abonnement type "Famille (couple + 3 ou plus enfant)"
            else if (Convert.ToInt32(typesAbonnementComboBox.SelectedValue) == 6)
            {
                subtitre1.Visible = true;
                nomConjointTextBox.Visible = true;
                nomConjointTextBox.Text = "";
                prenomConjointTextBox.Visible = true;
                prenomConjointTextBox.Text = "";
                dateNaissanceConjointTimePicker.Visible = true;
                comboBoxSexeConjoint.Visible = true;
                remarqueConjointTextBox.Visible = true;
                remarqueConjointTextBox.Text = "";

                enfantnomLabel.Visible = true;
                enfantprenomLabel.Visible = true;
                enfantDateNaissanceLabel.Visible = true;
                enfantSexeLabel.Visible = true;

                subtitre2.Visible = true;
                nbEnfantnumericUpDown.Visible = true;
                nbEnfantnumericUpDown.Value = 2;


                nomEnfantTextBox1.Visible = true;
                nomEnfantTextBox1.Text = "";
                prenomEnfantTextBox1.Visible = true;
                prenomEnfantTextBox1.Text = "";
                enfantSexeComboBox1.Visible = true;
                dateNaissanceEnfantTimePicker1.Visible = true;

                nomEnfantTextBox2.Visible = true;
                nomEnfantTextBox2.Text = "";
                prenomEnfantTextBox2.Visible = true;
                prenomEnfantTextBox2.Text = "";
                enfantSexeComboBox2.Visible = true;
                dateNaissanceEnfantTimePicker2.Visible = true;

                nomEnfantTextBox3.Visible = false;
                nomEnfantTextBox3.Text = "";
                prenomEnfantTextBox3.Visible = false;
                prenomEnfantTextBox3.Text = "";
                enfantSexeComboBox3.Visible = false;
                dateNaissanceEnfantTimePicker3.Visible = false;

                nomEnfantTextBox4.Visible = false;
                nomEnfantTextBox4.Text = "";
                prenomEnfantTextBox4.Visible = false;
                prenomEnfantTextBox4.Text = "";
                enfantSexeComboBox4.Visible = false;
                dateNaissanceEnfantTimePicker4.Visible = false;

                nomEnfantTextBox5.Visible = false;
                nomEnfantTextBox5.Text = "";
                prenomEnfantTextBox5.Visible = false;
                prenomEnfantTextBox5.Text = "";
                enfantSexeComboBox5.Visible = false;
                dateNaissanceEnfantTimePicker5.Visible = false;

                nomEnfantTextBox6.Visible = false;
                nomEnfantTextBox6.Text = "";
                prenomEnfantTextBox6.Visible = false;
                prenomEnfantTextBox6.Text = "";
                enfantSexeComboBox6.Visible = false;
                dateNaissanceEnfantTimePicker6.Visible = false;

                nomEnfantTextBox7.Visible = false;
                nomEnfantTextBox7.Text = "";
                prenomEnfantTextBox7.Visible = false;
                prenomEnfantTextBox7.Text = "";
                enfantSexeComboBox7.Visible = false;
                dateNaissanceEnfantTimePicker7.Visible = false;

                nomEnfantTextBox8.Visible = false;
                nomEnfantTextBox8.Text = "";
                prenomEnfantTextBox8.Visible = false;
                prenomEnfantTextBox8.Text = "";
                enfantSexeComboBox8.Visible = false;
                dateNaissanceEnfantTimePicker8.Visible = false;

                nomEnfantTextBox9.Visible = false;
                nomEnfantTextBox9.Text = "";
                prenomEnfantTextBox9.Visible = false;
                prenomEnfantTextBox9.Text = "";
                enfantSexeComboBox9.Visible = false;
                dateNaissanceEnfantTimePicker9.Visible = false;
            }
        }

        private void nbEnfantnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (nbEnfantnumericUpDown.Visible == false)
            {
                nomEnfantTextBox1.Visible = false;
                nomEnfantTextBox1.Text = "";
                prenomEnfantTextBox1.Visible = false;
                prenomEnfantTextBox1.Text = "";
                enfantSexeComboBox1.Visible = false;
                dateNaissanceEnfantTimePicker1.Visible = false;

                nomEnfantTextBox2.Visible = false;
                nomEnfantTextBox2.Text = "";
                prenomEnfantTextBox2.Visible = false;
                prenomEnfantTextBox2.Text = "";
                enfantSexeComboBox2.Visible = false;
                dateNaissanceEnfantTimePicker2.Visible = false;

                nomEnfantTextBox3.Visible = false;
                nomEnfantTextBox3.Text = "";
                prenomEnfantTextBox3.Visible = false;
                prenomEnfantTextBox3.Text = "";
                enfantSexeComboBox3.Visible = false;
                dateNaissanceEnfantTimePicker3.Visible = false;

                nomEnfantTextBox4.Visible = false;
                nomEnfantTextBox4.Text = "";
                prenomEnfantTextBox4.Visible = false;
                prenomEnfantTextBox4.Text = "";
                enfantSexeComboBox4.Visible = false;
                dateNaissanceEnfantTimePicker4.Visible = false;

                nomEnfantTextBox5.Visible = false;
                nomEnfantTextBox5.Text = "";
                prenomEnfantTextBox5.Visible = false;
                prenomEnfantTextBox5.Text = "";
                enfantSexeComboBox5.Visible = false;
                dateNaissanceEnfantTimePicker5.Visible = false;

                nomEnfantTextBox6.Visible = false;
                nomEnfantTextBox6.Text = "";
                prenomEnfantTextBox6.Visible = false;
                prenomEnfantTextBox6.Text = "";
                enfantSexeComboBox6.Visible = false;
                dateNaissanceEnfantTimePicker6.Visible = false;

                nomEnfantTextBox7.Visible = false;
                nomEnfantTextBox7.Text = "";
                prenomEnfantTextBox7.Visible = false;
                prenomEnfantTextBox7.Text = "";
                enfantSexeComboBox7.Visible = false;
                dateNaissanceEnfantTimePicker7.Visible = false;

                nomEnfantTextBox8.Visible = false;
                nomEnfantTextBox8.Text = "";
                prenomEnfantTextBox8.Visible = false;
                prenomEnfantTextBox8.Text = "";
                enfantSexeComboBox8.Visible = false;
                dateNaissanceEnfantTimePicker8.Visible = false;

                nomEnfantTextBox9.Visible = false;
                nomEnfantTextBox9.Text = "";
                prenomEnfantTextBox9.Visible = false;
                prenomEnfantTextBox9.Text = "";
                enfantSexeComboBox9.Visible = false;
                dateNaissanceEnfantTimePicker9.Visible = false;
            }
            else
            {
                switch (nbEnfantnumericUpDown.Value)
                {
                    case 1:
                        nomEnfantTextBox1.Visible = true;
                        nomEnfantTextBox1.Text = "";
                        prenomEnfantTextBox1.Visible = true;
                        prenomEnfantTextBox1.Text = "";
                        enfantSexeComboBox1.Visible = true;
                        dateNaissanceEnfantTimePicker1.Visible = true;

                        nomEnfantTextBox2.Visible = false;
                        nomEnfantTextBox2.Text = "";
                        prenomEnfantTextBox2.Visible = false;
                        prenomEnfantTextBox2.Text = "";
                        enfantSexeComboBox2.Visible = false;
                        dateNaissanceEnfantTimePicker2.Visible = false;

                        nomEnfantTextBox3.Visible = false;
                        nomEnfantTextBox3.Text = "";
                        prenomEnfantTextBox3.Visible = false;
                        prenomEnfantTextBox3.Text = "";
                        enfantSexeComboBox3.Visible = false;
                        dateNaissanceEnfantTimePicker3.Visible = false;

                        nomEnfantTextBox4.Visible = false;
                        nomEnfantTextBox4.Text = "";
                        prenomEnfantTextBox4.Visible = false;
                        prenomEnfantTextBox4.Text = "";
                        enfantSexeComboBox4.Visible = false;
                        dateNaissanceEnfantTimePicker4.Visible = false;

                        nomEnfantTextBox5.Visible = false;
                        nomEnfantTextBox5.Text = "";
                        prenomEnfantTextBox5.Visible = false;
                        prenomEnfantTextBox5.Text = "";
                        enfantSexeComboBox5.Visible = false;
                        dateNaissanceEnfantTimePicker5.Visible = false;

                        nomEnfantTextBox6.Visible = false;
                        nomEnfantTextBox6.Text = "";
                        prenomEnfantTextBox6.Visible = false;
                        prenomEnfantTextBox6.Text = "";
                        enfantSexeComboBox6.Visible = false;
                        dateNaissanceEnfantTimePicker6.Visible = false;

                        nomEnfantTextBox7.Visible = false;
                        nomEnfantTextBox7.Text = "";
                        prenomEnfantTextBox7.Visible = false;
                        prenomEnfantTextBox7.Text = "";
                        enfantSexeComboBox7.Visible = false;
                        dateNaissanceEnfantTimePicker7.Visible = false;

                        nomEnfantTextBox8.Visible = false;
                        nomEnfantTextBox8.Text = "";
                        prenomEnfantTextBox8.Visible = false;
                        prenomEnfantTextBox8.Text = "";
                        enfantSexeComboBox8.Visible = false;
                        dateNaissanceEnfantTimePicker8.Visible = false;

                        nomEnfantTextBox9.Visible = false;
                        nomEnfantTextBox9.Text = "";
                        prenomEnfantTextBox9.Visible = false;
                        prenomEnfantTextBox9.Text = "";
                        enfantSexeComboBox9.Visible = false;
                        dateNaissanceEnfantTimePicker9.Visible = false;
                        break;
                    case 2:
                        nomEnfantTextBox1.Visible = true;
                        nomEnfantTextBox1.Text = "";
                        prenomEnfantTextBox1.Visible = true;
                        prenomEnfantTextBox1.Text = "";
                        enfantSexeComboBox1.Visible = true;
                        dateNaissanceEnfantTimePicker1.Visible = true;

                        nomEnfantTextBox2.Visible = true;
                        nomEnfantTextBox2.Text = "";
                        prenomEnfantTextBox2.Visible = true;
                        prenomEnfantTextBox2.Text = "";
                        enfantSexeComboBox2.Visible = true;
                        dateNaissanceEnfantTimePicker2.Visible = true;

                        nomEnfantTextBox3.Visible = false;
                        nomEnfantTextBox3.Text = "";
                        prenomEnfantTextBox3.Visible = false;
                        prenomEnfantTextBox3.Text = "";
                        enfantSexeComboBox3.Visible = false;
                        dateNaissanceEnfantTimePicker3.Visible = false;

                        nomEnfantTextBox4.Visible = false;
                        nomEnfantTextBox4.Text = "";
                        prenomEnfantTextBox4.Visible = false;
                        prenomEnfantTextBox4.Text = "";
                        enfantSexeComboBox4.Visible = false;
                        dateNaissanceEnfantTimePicker4.Visible = false;

                        nomEnfantTextBox5.Visible = false;
                        nomEnfantTextBox5.Text = "";
                        prenomEnfantTextBox5.Visible = false;
                        prenomEnfantTextBox5.Text = "";
                        enfantSexeComboBox5.Visible = false;
                        dateNaissanceEnfantTimePicker5.Visible = false;

                        nomEnfantTextBox6.Visible = false;
                        nomEnfantTextBox6.Text = "";
                        prenomEnfantTextBox6.Visible = false;
                        prenomEnfantTextBox6.Text = "";
                        enfantSexeComboBox6.Visible = false;
                        dateNaissanceEnfantTimePicker6.Visible = false;

                        nomEnfantTextBox7.Visible = false;
                        nomEnfantTextBox7.Text = "";
                        prenomEnfantTextBox7.Visible = false;
                        prenomEnfantTextBox7.Text = "";
                        enfantSexeComboBox7.Visible = false;
                        dateNaissanceEnfantTimePicker7.Visible = false;

                        nomEnfantTextBox8.Visible = false;
                        nomEnfantTextBox8.Text = "";
                        prenomEnfantTextBox8.Visible = false;
                        prenomEnfantTextBox8.Text = "";
                        enfantSexeComboBox8.Visible = false;
                        dateNaissanceEnfantTimePicker8.Visible = false;

                        nomEnfantTextBox9.Visible = false;
                        nomEnfantTextBox9.Text = "";
                        prenomEnfantTextBox9.Visible = false;
                        prenomEnfantTextBox9.Text = "";
                        enfantSexeComboBox9.Visible = false;
                        dateNaissanceEnfantTimePicker9.Visible = false;
                        break;
                    case 3:
                        nomEnfantTextBox1.Visible = true;
                        nomEnfantTextBox1.Text = "";
                        prenomEnfantTextBox1.Visible = true;
                        prenomEnfantTextBox1.Text = "";
                        enfantSexeComboBox1.Visible = true;
                        dateNaissanceEnfantTimePicker1.Visible = true;

                        nomEnfantTextBox2.Visible = true;
                        nomEnfantTextBox2.Text = "";
                        prenomEnfantTextBox2.Visible = true;
                        prenomEnfantTextBox2.Text = "";
                        enfantSexeComboBox2.Visible = true;
                        dateNaissanceEnfantTimePicker2.Visible = true;

                        nomEnfantTextBox3.Visible = true;
                        nomEnfantTextBox3.Text = "";
                        prenomEnfantTextBox3.Visible = true;
                        prenomEnfantTextBox3.Text = "";
                        enfantSexeComboBox3.Visible = true;
                        dateNaissanceEnfantTimePicker3.Visible = true;

                        nomEnfantTextBox4.Visible = false;
                        nomEnfantTextBox4.Text = "";
                        prenomEnfantTextBox4.Visible = false;
                        prenomEnfantTextBox4.Text = "";
                        enfantSexeComboBox4.Visible = false;
                        dateNaissanceEnfantTimePicker4.Visible = false;

                        nomEnfantTextBox5.Visible = false;
                        nomEnfantTextBox5.Text = "";
                        prenomEnfantTextBox5.Visible = false;
                        prenomEnfantTextBox5.Text = "";
                        enfantSexeComboBox5.Visible = false;
                        dateNaissanceEnfantTimePicker5.Visible = false;

                        nomEnfantTextBox6.Visible = false;
                        nomEnfantTextBox6.Text = "";
                        prenomEnfantTextBox6.Visible = false;
                        prenomEnfantTextBox6.Text = "";
                        enfantSexeComboBox6.Visible = false;
                        dateNaissanceEnfantTimePicker6.Visible = false;

                        nomEnfantTextBox7.Visible = false;
                        nomEnfantTextBox7.Text = "";
                        prenomEnfantTextBox7.Visible = false;
                        prenomEnfantTextBox7.Text = "";
                        enfantSexeComboBox7.Visible = false;
                        dateNaissanceEnfantTimePicker7.Visible = false;

                        nomEnfantTextBox8.Visible = false;
                        nomEnfantTextBox8.Text = "";
                        prenomEnfantTextBox8.Visible = false;
                        prenomEnfantTextBox8.Text = "";
                        enfantSexeComboBox8.Visible = false;
                        dateNaissanceEnfantTimePicker8.Visible = false;

                        nomEnfantTextBox9.Visible = false;
                        nomEnfantTextBox9.Text = "";
                        prenomEnfantTextBox9.Visible = false;
                        prenomEnfantTextBox9.Text = "";
                        enfantSexeComboBox9.Visible = false;
                        dateNaissanceEnfantTimePicker9.Visible = false;
                        break;
                    case 4:
                        nomEnfantTextBox1.Visible = true;
                        nomEnfantTextBox1.Text = "";
                        prenomEnfantTextBox1.Visible = true;
                        prenomEnfantTextBox1.Text = "";
                        enfantSexeComboBox1.Visible = true;
                        dateNaissanceEnfantTimePicker1.Visible = true;

                        nomEnfantTextBox2.Visible = true;
                        nomEnfantTextBox2.Text = "";
                        prenomEnfantTextBox2.Visible = true;
                        prenomEnfantTextBox2.Text = "";
                        enfantSexeComboBox2.Visible = true;
                        dateNaissanceEnfantTimePicker2.Visible = true;

                        nomEnfantTextBox3.Visible = true;
                        nomEnfantTextBox3.Text = "";
                        prenomEnfantTextBox3.Visible = true;
                        prenomEnfantTextBox3.Text = "";
                        enfantSexeComboBox3.Visible = true;
                        dateNaissanceEnfantTimePicker3.Visible = true;

                        nomEnfantTextBox4.Visible = true;
                        nomEnfantTextBox4.Text = "";
                        prenomEnfantTextBox4.Visible = true;
                        prenomEnfantTextBox4.Text = "";
                        enfantSexeComboBox4.Visible = true;
                        dateNaissanceEnfantTimePicker4.Visible = true;

                        nomEnfantTextBox5.Visible = false;
                        nomEnfantTextBox5.Text = "";
                        prenomEnfantTextBox5.Visible = false;
                        prenomEnfantTextBox5.Text = "";
                        enfantSexeComboBox5.Visible = false;
                        dateNaissanceEnfantTimePicker5.Visible = false;

                        nomEnfantTextBox6.Visible = false;
                        nomEnfantTextBox6.Text = "";
                        prenomEnfantTextBox6.Visible = false;
                        prenomEnfantTextBox6.Text = "";
                        enfantSexeComboBox6.Visible = false;
                        dateNaissanceEnfantTimePicker6.Visible = false;

                        nomEnfantTextBox7.Visible = false;
                        nomEnfantTextBox7.Text = "";
                        prenomEnfantTextBox7.Visible = false;
                        prenomEnfantTextBox7.Text = "";
                        enfantSexeComboBox7.Visible = false;
                        dateNaissanceEnfantTimePicker7.Visible = false;

                        nomEnfantTextBox8.Visible = false;
                        nomEnfantTextBox8.Text = "";
                        prenomEnfantTextBox8.Visible = false;
                        prenomEnfantTextBox8.Text = "";
                        enfantSexeComboBox8.Visible = false;
                        dateNaissanceEnfantTimePicker8.Visible = false;

                        nomEnfantTextBox9.Visible = false;
                        nomEnfantTextBox9.Text = "";
                        prenomEnfantTextBox9.Visible = false;
                        prenomEnfantTextBox9.Text = "";
                        enfantSexeComboBox9.Visible = false;
                        dateNaissanceEnfantTimePicker9.Visible = false;
                        break;
                    case 5:
                        nomEnfantTextBox1.Visible = true;
                        nomEnfantTextBox1.Text = "";
                        prenomEnfantTextBox1.Visible = true;
                        prenomEnfantTextBox1.Text = "";
                        enfantSexeComboBox1.Visible = true;
                        dateNaissanceEnfantTimePicker1.Visible = true;

                        nomEnfantTextBox2.Visible = true;
                        nomEnfantTextBox2.Text = "";
                        prenomEnfantTextBox2.Visible = true;
                        prenomEnfantTextBox2.Text = "";
                        enfantSexeComboBox2.Visible = true;
                        dateNaissanceEnfantTimePicker2.Visible = true;

                        nomEnfantTextBox3.Visible = true;
                        nomEnfantTextBox3.Text = "";
                        prenomEnfantTextBox3.Visible = true;
                        prenomEnfantTextBox3.Text = "";
                        enfantSexeComboBox3.Visible = true;
                        dateNaissanceEnfantTimePicker3.Visible = true;

                        nomEnfantTextBox4.Visible = true;
                        nomEnfantTextBox4.Text = "";
                        prenomEnfantTextBox4.Visible = true;
                        prenomEnfantTextBox4.Text = "";
                        enfantSexeComboBox4.Visible = true;
                        dateNaissanceEnfantTimePicker4.Visible = true;

                        nomEnfantTextBox5.Visible = true;
                        nomEnfantTextBox5.Text = "";
                        prenomEnfantTextBox5.Visible = true;
                        prenomEnfantTextBox5.Text = "";
                        enfantSexeComboBox5.Visible = true;
                        dateNaissanceEnfantTimePicker5.Visible = true;

                        nomEnfantTextBox6.Visible = false;
                        nomEnfantTextBox6.Text = "";
                        prenomEnfantTextBox6.Visible = false;
                        prenomEnfantTextBox6.Text = "";
                        enfantSexeComboBox6.Visible = false;
                        dateNaissanceEnfantTimePicker6.Visible = false;

                        nomEnfantTextBox7.Visible = false;
                        nomEnfantTextBox7.Text = "";
                        prenomEnfantTextBox7.Visible = false;
                        prenomEnfantTextBox7.Text = "";
                        enfantSexeComboBox7.Visible = false;
                        dateNaissanceEnfantTimePicker7.Visible = false;

                        nomEnfantTextBox8.Visible = false;
                        nomEnfantTextBox8.Text = "";
                        prenomEnfantTextBox8.Visible = false;
                        prenomEnfantTextBox8.Text = "";
                        enfantSexeComboBox8.Visible = false;
                        dateNaissanceEnfantTimePicker8.Visible = false;

                        nomEnfantTextBox9.Visible = false;
                        nomEnfantTextBox9.Text = "";
                        prenomEnfantTextBox9.Visible = false;
                        prenomEnfantTextBox9.Text = "";
                        enfantSexeComboBox9.Visible = false;
                        dateNaissanceEnfantTimePicker9.Visible = false;
                        break;
                    case 6:
                        nomEnfantTextBox1.Visible = true;
                        nomEnfantTextBox1.Text = "";
                        prenomEnfantTextBox1.Visible = true;
                        prenomEnfantTextBox1.Text = "";
                        enfantSexeComboBox1.Visible = true;
                        dateNaissanceEnfantTimePicker1.Visible = true;

                        nomEnfantTextBox2.Visible = true;
                        nomEnfantTextBox2.Text = "";
                        prenomEnfantTextBox2.Visible = true;
                        prenomEnfantTextBox2.Text = "";
                        enfantSexeComboBox2.Visible = true;
                        dateNaissanceEnfantTimePicker2.Visible = true;

                        nomEnfantTextBox3.Visible = true;
                        nomEnfantTextBox3.Text = "";
                        prenomEnfantTextBox3.Visible = true;
                        prenomEnfantTextBox3.Text = "";
                        enfantSexeComboBox3.Visible = true;
                        dateNaissanceEnfantTimePicker3.Visible = true;

                        nomEnfantTextBox4.Visible = true;
                        nomEnfantTextBox4.Text = "";
                        prenomEnfantTextBox4.Visible = true;
                        prenomEnfantTextBox4.Text = "";
                        enfantSexeComboBox4.Visible = true;
                        dateNaissanceEnfantTimePicker4.Visible = true;

                        nomEnfantTextBox5.Visible = true;
                        nomEnfantTextBox5.Text = "";
                        prenomEnfantTextBox5.Visible = true;
                        prenomEnfantTextBox5.Text = "";
                        enfantSexeComboBox5.Visible = true;
                        dateNaissanceEnfantTimePicker5.Visible = true;

                        nomEnfantTextBox6.Visible = true;
                        nomEnfantTextBox6.Text = "";
                        prenomEnfantTextBox6.Visible = true;
                        prenomEnfantTextBox6.Text = "";
                        enfantSexeComboBox6.Visible = true;
                        dateNaissanceEnfantTimePicker6.Visible = true;

                        nomEnfantTextBox7.Visible = false;
                        nomEnfantTextBox7.Text = "";
                        prenomEnfantTextBox7.Visible = false;
                        prenomEnfantTextBox7.Text = "";
                        enfantSexeComboBox7.Visible = false;
                        dateNaissanceEnfantTimePicker7.Visible = false;

                        nomEnfantTextBox8.Visible = false;
                        nomEnfantTextBox8.Text = "";
                        prenomEnfantTextBox8.Visible = false;
                        prenomEnfantTextBox8.Text = "";
                        enfantSexeComboBox8.Visible = false;
                        dateNaissanceEnfantTimePicker8.Visible = false;

                        nomEnfantTextBox9.Visible = false;
                        nomEnfantTextBox9.Text = "";
                        prenomEnfantTextBox9.Visible = false;
                        prenomEnfantTextBox9.Text = "";
                        enfantSexeComboBox9.Visible = false;
                        dateNaissanceEnfantTimePicker9.Visible = false;
                        break;
                    case 7:
                        nomEnfantTextBox1.Visible = true;
                        nomEnfantTextBox1.Text = "";
                        prenomEnfantTextBox1.Visible = true;
                        prenomEnfantTextBox1.Text = "";
                        enfantSexeComboBox1.Visible = true;
                        dateNaissanceEnfantTimePicker1.Visible = true;

                        nomEnfantTextBox2.Visible = true;
                        nomEnfantTextBox2.Text = "";
                        prenomEnfantTextBox2.Visible = true;
                        prenomEnfantTextBox2.Text = "";
                        enfantSexeComboBox2.Visible = true;
                        dateNaissanceEnfantTimePicker2.Visible = true;

                        nomEnfantTextBox3.Visible = true;
                        nomEnfantTextBox3.Text = "";
                        prenomEnfantTextBox3.Visible = true;
                        prenomEnfantTextBox3.Text = "";
                        enfantSexeComboBox3.Visible = true;
                        dateNaissanceEnfantTimePicker3.Visible = true;

                        nomEnfantTextBox4.Visible = true;
                        nomEnfantTextBox4.Text = "";
                        prenomEnfantTextBox4.Visible = true;
                        prenomEnfantTextBox4.Text = "";
                        enfantSexeComboBox4.Visible = true;
                        dateNaissanceEnfantTimePicker4.Visible = true;

                        nomEnfantTextBox5.Visible = true;
                        nomEnfantTextBox5.Text = "";
                        prenomEnfantTextBox5.Visible = true;
                        prenomEnfantTextBox5.Text = "";
                        enfantSexeComboBox5.Visible = true;
                        dateNaissanceEnfantTimePicker5.Visible = true;

                        nomEnfantTextBox6.Visible = true;
                        nomEnfantTextBox6.Text = "";
                        prenomEnfantTextBox6.Visible = true;
                        prenomEnfantTextBox6.Text = "";
                        enfantSexeComboBox6.Visible = true;
                        dateNaissanceEnfantTimePicker6.Visible = true;

                        nomEnfantTextBox7.Visible = true;
                        nomEnfantTextBox7.Text = "";
                        prenomEnfantTextBox7.Visible = true;
                        prenomEnfantTextBox7.Text = "";
                        enfantSexeComboBox7.Visible = true;
                        dateNaissanceEnfantTimePicker7.Visible = true;

                        nomEnfantTextBox8.Visible = false;
                        nomEnfantTextBox8.Text = "";
                        prenomEnfantTextBox8.Visible = false;
                        prenomEnfantTextBox8.Text = "";
                        enfantSexeComboBox8.Visible = false;
                        dateNaissanceEnfantTimePicker8.Visible = false;

                        nomEnfantTextBox9.Visible = false;
                        nomEnfantTextBox9.Text = "";
                        prenomEnfantTextBox9.Visible = false;
                        prenomEnfantTextBox9.Text = "";
                        enfantSexeComboBox9.Visible = false;
                        dateNaissanceEnfantTimePicker9.Visible = false;
                        break;
                    case 8:
                        nomEnfantTextBox1.Visible = true;
                        nomEnfantTextBox1.Text = "";
                        prenomEnfantTextBox1.Visible = true;
                        prenomEnfantTextBox1.Text = "";
                        enfantSexeComboBox1.Visible = true;
                        dateNaissanceEnfantTimePicker1.Visible = true;

                        nomEnfantTextBox2.Visible = true;
                        nomEnfantTextBox2.Text = "";
                        prenomEnfantTextBox2.Visible = true;
                        prenomEnfantTextBox2.Text = "";
                        enfantSexeComboBox2.Visible = true;
                        dateNaissanceEnfantTimePicker2.Visible = true;

                        nomEnfantTextBox3.Visible = true;
                        nomEnfantTextBox3.Text = "";
                        prenomEnfantTextBox3.Visible = true;
                        prenomEnfantTextBox3.Text = "";
                        enfantSexeComboBox3.Visible = true;
                        dateNaissanceEnfantTimePicker3.Visible = true;

                        nomEnfantTextBox4.Visible = true;
                        nomEnfantTextBox4.Text = "";
                        prenomEnfantTextBox4.Visible = true;
                        prenomEnfantTextBox4.Text = "";
                        enfantSexeComboBox4.Visible = true;
                        dateNaissanceEnfantTimePicker4.Visible = true;

                        nomEnfantTextBox5.Visible = true;
                        nomEnfantTextBox5.Text = "";
                        prenomEnfantTextBox5.Visible = true;
                        prenomEnfantTextBox5.Text = "";
                        enfantSexeComboBox5.Visible = true;
                        dateNaissanceEnfantTimePicker5.Visible = true;

                        nomEnfantTextBox6.Visible = true;
                        nomEnfantTextBox6.Text = "";
                        prenomEnfantTextBox6.Visible = true;
                        prenomEnfantTextBox6.Text = "";
                        enfantSexeComboBox6.Visible = true;
                        dateNaissanceEnfantTimePicker6.Visible = true;

                        nomEnfantTextBox7.Visible = true;
                        nomEnfantTextBox7.Text = "";
                        prenomEnfantTextBox7.Visible = true;
                        prenomEnfantTextBox7.Text = "";
                        enfantSexeComboBox7.Visible = true;
                        dateNaissanceEnfantTimePicker7.Visible = true;

                        nomEnfantTextBox8.Visible = true;
                        nomEnfantTextBox8.Text = "";
                        prenomEnfantTextBox8.Visible = true;
                        prenomEnfantTextBox8.Text = "";
                        enfantSexeComboBox8.Visible = true;
                        dateNaissanceEnfantTimePicker8.Visible = true;

                        nomEnfantTextBox9.Visible = false;
                        nomEnfantTextBox9.Text = "";
                        prenomEnfantTextBox9.Visible = false;
                        prenomEnfantTextBox9.Text = "";
                        enfantSexeComboBox9.Visible = false;
                        dateNaissanceEnfantTimePicker9.Visible = false;
                        break;
                    case 9:
                        nomEnfantTextBox1.Visible = true;
                        nomEnfantTextBox1.Text = "";
                        prenomEnfantTextBox1.Visible = true;
                        prenomEnfantTextBox1.Text = "";
                        enfantSexeComboBox1.Visible = true;
                        dateNaissanceEnfantTimePicker1.Visible = true;

                        nomEnfantTextBox2.Visible = true;
                        nomEnfantTextBox2.Text = "";
                        prenomEnfantTextBox2.Visible = true;
                        prenomEnfantTextBox2.Text = "";
                        enfantSexeComboBox2.Visible = true;
                        dateNaissanceEnfantTimePicker2.Visible = true;

                        nomEnfantTextBox3.Visible = true;
                        nomEnfantTextBox3.Text = "";
                        prenomEnfantTextBox3.Visible = true;
                        prenomEnfantTextBox3.Text = "";
                        enfantSexeComboBox3.Visible = true;
                        dateNaissanceEnfantTimePicker3.Visible = true;

                        nomEnfantTextBox4.Visible = true;
                        nomEnfantTextBox4.Text = "";
                        prenomEnfantTextBox4.Visible = true;
                        prenomEnfantTextBox4.Text = "";
                        enfantSexeComboBox4.Visible = true;
                        dateNaissanceEnfantTimePicker4.Visible = true;

                        nomEnfantTextBox5.Visible = true;
                        nomEnfantTextBox5.Text = "";
                        prenomEnfantTextBox5.Visible = true;
                        prenomEnfantTextBox5.Text = "";
                        enfantSexeComboBox5.Visible = true;
                        dateNaissanceEnfantTimePicker5.Visible = true;

                        nomEnfantTextBox6.Visible = true;
                        nomEnfantTextBox6.Text = "";
                        prenomEnfantTextBox6.Visible = true;
                        prenomEnfantTextBox6.Text = "";
                        enfantSexeComboBox6.Visible = true;
                        dateNaissanceEnfantTimePicker6.Visible = true;

                        nomEnfantTextBox7.Visible = true;
                        nomEnfantTextBox7.Text = "";
                        prenomEnfantTextBox7.Visible = true;
                        prenomEnfantTextBox7.Text = "";
                        enfantSexeComboBox7.Visible = true;
                        dateNaissanceEnfantTimePicker7.Visible = true;

                        nomEnfantTextBox8.Visible = true;
                        nomEnfantTextBox8.Text = "";
                        prenomEnfantTextBox8.Visible = true;
                        prenomEnfantTextBox8.Text = "";
                        enfantSexeComboBox8.Visible = true;
                        dateNaissanceEnfantTimePicker8.Visible = true;

                        nomEnfantTextBox9.Visible = true;
                        nomEnfantTextBox9.Text = "";
                        prenomEnfantTextBox9.Visible = true;
                        prenomEnfantTextBox9.Text = "";
                        enfantSexeComboBox9.Visible = true;
                        dateNaissanceEnfantTimePicker9.Visible = true;
                        break;
                }
            }
        } 
    }
}
