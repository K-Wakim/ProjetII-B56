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
            this.employesTableAdapter.Fill(this.bDB56Pr211DataSet.Employes);

            // Sexe
            cboSexe.Items.Add("H");
            cboSexe.Items.Add("F");

            // Salaire min/max
            nudSalaire.Minimum = 15;
            nudSalaire.Maximum = 500;

            //Age min/max
            nudAge.Minimum = 16;
            nudAge.Maximum = 65;

            // Provinces
            provincesTableAdapter.Fill(bDB56Pr211DataSet.Provinces);
            cboProvince.DataSource = bDB56Pr211DataSet.Provinces;
            cboProvince.DisplayMember = "Nom";
            cboProvince.ValueMember = "Id";

            // Types employé
            typesEmployeTableAdapter.Fill(bDB56Pr211DataSet.TypesEmploye);
            cboTypeEmploye.DataSource = bDB56Pr211DataSet.TypesEmploye;
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

            // Empêcher d'ajouter un admin
            int typeSelect = (int)cboTypeEmploye.SelectedValue;
            string descType = bDB56Pr211DataSet.TypesEmploye.FindByNo(typeSelect).Description;

            if (descType.ToLower().Contains("admin"))
            {
                MessageBox.Show("Impossible d’ajouter un administrateur.");
                return;
            }

            try
            {
                int nextNo = GetNextEmployeeNumber();

                var newRow = bDB56Pr211DataSet.Employes.NewEmployesRow();

                newRow.No = nextNo;
                newRow.MotDePasse = txtMotDePasse.Text.Trim();

                newRow.Nom = txtNom.Text.Trim();
                newRow.Prenom = txtPrenom.Text.Trim();
                newRow.Sexe = cboSexe.Text;

                newRow.Age = (int)nudAge.Value;

                // Adresse séparée
                newRow.NoCivique = txtNoCivique.Text.Trim();
                newRow.Rue = txtRue.Text.Trim();
                newRow.Ville = txtVille.Text.Trim();

                newRow.IdProvince = cboProvince.SelectedValue.ToString();
                newRow.CodePostal = txtCodePostal.Text.Replace(" ", "");

                newRow.Telephone = txtTelephone.Text
                                   .Replace("(", "").Replace(")", "")
                                   .Replace("-", "").Trim();

                // Cellulaire optionnel
                if (string.IsNullOrWhiteSpace(txtCellulaire.Text))
                    newRow.SetCellulaireNull();
                else
                    newRow.Cellulaire = txtCellulaire.Text
                                        .Replace("(", "").Replace(")", "")
                                        .Replace("-", "").Trim();

                newRow.Courriel = txtCourriel.Text.Trim();
                newRow.SalaireHoraire = nudSalaire.Value;

                newRow.NoTypeEmploye = typeSelect;

                // Remarque optionnelle
                if (string.IsNullOrWhiteSpace(txtRemarque.Text))
                    newRow.SetRemarqueNull();
                else
                    newRow.Remarque = txtRemarque.Text.Trim();

                // Ajouter ligne au dataset
                bDB56Pr211DataSet.Employes.AddEmployesRow(newRow);

                empTA.Update(bDB56Pr211DataSet.Employes);

                MessageBox.Show("Employé ajouté avec succès !");
                this.empTA.Fill(this.bDB56Pr211DataSet.Employes);
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
