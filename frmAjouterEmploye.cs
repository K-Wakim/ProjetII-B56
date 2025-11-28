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
    public partial class frmAjouterEmploye : Form
    {
        DataClassesCclubGolfDataContext db = new DataClassesCclubGolfDataContext();

        public frmAjouterEmploye()
        {
            InitializeComponent();
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

        private void frmAjouterEmploye_Load(object sender, EventArgs e)
        {
            // Sexe
            cboSexe.Items.Add("H");
            cboSexe.Items.Add("F");

            // Salaire min/max
            nudSalaire.Minimum = 15;
            nudSalaire.Maximum = 500;

            // Age min/max
            nudAge.Minimum = 16;
            nudAge.Maximum = 65;

            // Provinces
            cboProvince.DataSource = db.Provinces.ToList();
            cboProvince.DisplayMember = "Nom";
            cboProvince.ValueMember = "Id";

            // Types employé
            cboTypeEmploye.DataSource = db.TypesEmploye.ToList();
            cboTypeEmploye.DisplayMember = "Description";
            cboTypeEmploye.ValueMember = "No";
        }

        private int GetNextEmployeeNumber()
        {
            if (bDB56Pr211DataSet.Employes.Rows.Count == 0)
                return 1;

            return bDB56Pr211DataSet.Employes.AsEnumerable()
                   .Max(row => row.Field<int>("No")) + 1;
        }

        private bool ValiderChamps()
        {
            if (txtNom.Text.Trim() == "" ||
                txtPrenom.Text.Trim() == "" ||
                cboSexe.SelectedIndex < 0 ||
                txtNoCivique.Text.Trim() == "" ||
                cboProvince.SelectedIndex < 0 ||
                txtCodePostal.Text.Replace(" ", "").Length != 6 ||
                txtTelephone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim().Length != 10 ||
                txtCourriel.Text.Trim() == "" ||
                txtRue.Text.Trim() == "" ||
                    txtVille.Text.Trim() == "" ||
                    txtNoCivique.Text.Trim() == "") 
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
                return false;
            }


            // 🔥 Validation du mot de passe 🔥
            if (!MotDePasseValide(txtMotDePasse.Text))
            {
                MessageBox.Show("Le mot de passe doit contenir :\n" +
                                "- au moins 8 caractères\n" +
                                "- au moins une lettre\n" +
                                "- au moins un chiffre\n" +
                                "- au moins un caractère spécial");
                return false;
            }

            return true;
        }

        private bool MotDePasseValide(string mdp)
        {
            if (mdp.Length < 8) return false;

            bool aLettre = mdp.Any(char.IsLetter);
            bool aChiffre = mdp.Any(char.IsDigit);
            bool aSpecial = mdp.Any(c => !char.IsLetterOrDigit(c));

            return aLettre && aChiffre && aSpecial;
        }



        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps()) return;

            int typeSelect = (int)cboTypeEmploye.SelectedValue;
            var typeEmp = db.TypesEmploye.Single(te => te.No == typeSelect);

            if (typeEmp.Description.ToLower().Contains("admin"))
            {
                MessageBox.Show("Impossible d’ajouter un administrateur.");
                return;
            }

            try
            {
                // Calculer le prochain No d'employé
                int nextNo = db.Employes.Any() ? db.Employes.Max(emp => emp.No) + 1 : 1;

                // Créer un nouvel objet Employe
                Employes newEmp = new Employes
                {
                    No = nextNo,
                    MotDePasse = txtMotDePasse.Text.Trim(),
                    Nom = txtNom.Text.Trim(),
                    Prenom = txtPrenom.Text.Trim(),
                    Sexe = cboSexe.Text.Length > 0 ? cboSexe.Text[0] : 'H',
                    Age = (int)nudAge.Value,
                    NoCivique = txtNoCivique.Text.Trim(),
                    Rue = txtRue.Text.Trim(),
                    Ville = txtVille.Text.Trim(),
                    IdProvince = cboProvince.SelectedValue.ToString(),
                    CodePostal = txtCodePostal.Text.Replace(" ", ""),
                    Telephone = txtTelephone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim(),
                    Cellulaire = string.IsNullOrWhiteSpace(txtCellulaire.Text) ? null : txtCellulaire.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim(),
                    Courriel = txtCourriel.Text.Trim(),
                    SalaireHoraire = nudSalaire.Value,
                    NoTypeEmploye = typeSelect,
                    Remarque = string.IsNullOrWhiteSpace(txtRemarque.Text) ? null : txtRemarque.Text.Trim()
                };

                // Ajouter à la table et sauvegarder
                db.Employes.InsertOnSubmit(newEmp);
                db.SubmitChanges();

                MessageBox.Show($"Employé ajouté avec succès !\nNuméro attribué : {newEmp.No}");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }


        private void btnAjouter_Click(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
    }
}
