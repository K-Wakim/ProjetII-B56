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
        private BDB56Pr211DataSet.EmployesRow employeRow;


        public frmModifieEmploye(BDB56Pr211DataSet.EmployesRow row)
        {
            InitializeComponent();
            employeRow = row;
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

            /*typesEmployeTableAdapter.Fill(bDB56Pr211DataSet.TypesEmploye);
            cboTypeEmploye.DataSource = bDB56Pr211DataSet.TypesEmploye;
            cboTypeEmploye.DisplayMember = "Description";
            cboTypeEmploye.ValueMember = "No";*/

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
            if (employeRow != null)
            {
                txtNo.Text = employeRow["No"].ToString();
                txtMotDePasse.Text = employeRow["MotDePasse"].ToString();
                txtNom.Text = employeRow["Nom"].ToString();
                txtPrenom.Text = employeRow["Prenom"].ToString();
                cboSexe.Text = employeRow["Sexe"].ToString();
                nudAge.Value = Convert.ToDecimal(employeRow["Age"]);
                txtNoCivique.Text = employeRow["NoCivique"].ToString();
                txtRue.Text = employeRow["Rue"].ToString();
                txtVille.Text = employeRow["Ville"].ToString();
                cboProvince.SelectedValue = employeRow["IdProvince"].ToString();
                txtCodePostal.Text = employeRow["CodePostal"].ToString();
                txtTelephone.Text = employeRow["Telephone"].ToString();
                txtCellulaire.Text = employeRow["Cellulaire"]?.ToString();
                txtCourriel.Text = employeRow["Courriel"].ToString();
                nudSalaire.Value = Convert.ToDecimal(employeRow["SalaireHoraire"]);
                cboTypeEmployes.SelectedValue = Convert.ToInt32(employeRow["NoTypeEmploye"]);
                txtRemarque.Text = employeRow["Remarque"]?.ToString();
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
                // Utiliser directement la ligne passée dans le constructeur
                var row = employeRow;

                // Mettre à jour les champs
                row.MotDePasse = txtMotDePasse.Text.Trim();
                row.Nom = txtNom.Text.Trim();
                row.Prenom = txtPrenom.Text.Trim();
                row.Sexe = cboSexe.Text;
                row.Age = (int)nudAge.Value;

                row.NoCivique = txtNoCivique.Text.Trim();
                row.Rue = txtRue.Text.Trim();
                row.Ville = txtVille.Text.Trim();

                row.IdProvince = cboProvince.SelectedValue.ToString();
                row.CodePostal = txtCodePostal.Text.Replace(" ", "");

                row.Telephone = txtTelephone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim();

                if (string.IsNullOrWhiteSpace(txtCellulaire.Text))
                    row.SetCellulaireNull();
                else
                    row.Cellulaire = txtCellulaire.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim();

                row.Courriel = txtCourriel.Text.Trim();
                row.SalaireHoraire = nudSalaire.Value;
                //row.NoTypeEmploye = (int)cboTypeEmployes.SelectedValue;

                if (string.IsNullOrWhiteSpace(txtRemarque.Text))
                    row.SetRemarqueNull();
                else
                    row.Remarque = txtRemarque.Text.Trim();

                // Sauvegarder les modifications
                empTA.Update(bDB56Pr211DataSet.Employes);

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
