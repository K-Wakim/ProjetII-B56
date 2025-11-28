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
    public partial class frmModifieEmploye : Form
    {
        DataClassesCclubGolfDataContext db = new DataClassesCclubGolfDataContext();
        private Employes employe;

        public frmModifieEmploye(Employes emp)
        {
            InitializeComponent();
            this.employe = emp;
        }



        BDB56Pr211DataSetTableAdapters.EmployesTableAdapter empTA = new BDB56Pr211DataSetTableAdapters.EmployesTableAdapter();

        BDB56Pr211DataSetTableAdapters.ProvincesTableAdapter provincesTableAdapter = new BDB56Pr211DataSetTableAdapters.ProvincesTableAdapter();

        BDB56Pr211DataSetTableAdapters.TypesEmployeTableAdapter typesEmployeTableAdapter = new BDB56Pr211DataSetTableAdapters.TypesEmployeTableAdapter();
        private void employesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Pr211DataSet);

        }

        private void employesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.employesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Pr211DataSet);

        }

        private void frmModifieEmploye_Load(object sender, EventArgs e)
        {
            // Charger les tables nécessaires
            provincesTableAdapter.Fill(bDB56Pr211DataSet.Provinces);
            cboProvince.DataSource = bDB56Pr211DataSet.Provinces;
            cboProvince.DisplayMember = "Nom";
            cboProvince.ValueMember = "Id";

            // Sexe
            cboSexe.Items.Add("H");
            cboSexe.Items.Add("F");

            // Salaire min/max
            nudSalaire.Minimum = 15;
            nudSalaire.Maximum = 500;

            // Age min/max
            nudAge.Minimum = 16;
            nudAge.Maximum = 65;

            // Pré-remplir les champs avec les données existantes
            if (employe != null)
            {
                txtNo.Text = employe.No.ToString();
                txtMotDePasse.Text = employe.MotDePasse;
                txtNom.Text = employe.Nom;
                txtPrenom.Text = employe.Prenom;
                cboSexe.Text = employe.Sexe.ToString();
                nudAge.Value = employe.Age;
                txtNoCivique.Text = employe.NoCivique;
                txtRue.Text = employe.Rue;
                txtVille.Text = employe.Ville;
                cboProvince.SelectedValue = employe.IdProvince;
                txtCodePostal.Text = employe.CodePostal;
                txtTelephone.Text = employe.Telephone;
                txtCellulaire.Text = employe.Cellulaire;
                txtCourriel.Text = employe.Courriel;
                nudSalaire.Value = employe.SalaireHoraire;
                cboTypeEmployes.SelectedValue = employe.NoTypeEmploye;
                txtRemarque.Text = employe.Remarque;
            }
        }



        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps()) return;

            try
            {
                // Mettre à jour les champs
                employe.MotDePasse = txtMotDePasse.Text.Trim();
                employe.Nom = txtNom.Text.Trim();
                employe.Prenom = txtPrenom.Text.Trim();
                employe.Sexe = cboSexe.Text.Length > 0 ? cboSexe.Text[0] : 'H';
                employe.Age = (int)nudAge.Value;
                employe.NoCivique = txtNoCivique.Text.Trim();
                employe.Rue = txtRue.Text.Trim();
                employe.Ville = txtVille.Text.Trim();
                employe.IdProvince = (string)cboProvince.SelectedValue;
                employe.CodePostal = txtCodePostal.Text.Replace(" ", "");
                employe.Telephone = txtTelephone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim();
                employe.Cellulaire = string.IsNullOrWhiteSpace(txtCellulaire.Text) ? null : txtCellulaire.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim();
                employe.Courriel = txtCourriel.Text.Trim();
                employe.SalaireHoraire = nudSalaire.Value;
                //employe.NoTypeEmploye = (int)cboTypeEmployes.SelectedValue;
                employe.Remarque = string.IsNullOrWhiteSpace(txtRemarque.Text) ? null : txtRemarque.Text.Trim();

                db.SubmitChanges(); // Sauvegarde dans la base LINQ to SQL


                MessageBox.Show("Employé modifié avec succès !");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }


        private bool ValiderChamps()
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtPrenom.Text) ||
                cboSexe.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(txtNoCivique.Text) ||
                cboProvince.SelectedIndex < 0 ||
                txtCodePostal.Text.Replace(" ", "").Length != 6 ||
                txtTelephone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim().Length != 10 ||
                string.IsNullOrWhiteSpace(txtCourriel.Text) ||
                string.IsNullOrWhiteSpace(txtRue.Text) ||
                string.IsNullOrWhiteSpace(txtVille.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
                return false;
            }

            // Validation mot de passe
            string mdp = txtMotDePasse.Text;
            if (mdp.Length < 8 ||
                !mdp.Any(char.IsLetter) ||
                !mdp.Any(char.IsDigit) ||
                !mdp.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                MessageBox.Show("Le mot de passe doit avoir au moins 8 caractères, une lettre, un chiffre et un caractère spécial.");
                return false;
            }

            return true;
        }


        private void codePostalTextBox_TextChanged(object sender, EventArgs e) { }

        private void cellulaireTextBox_TextChanged(object sender, EventArgs e) { }
    }
}
