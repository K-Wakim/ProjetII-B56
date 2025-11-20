namespace ProjetII_B56
{
    partial class frmAjouterEmploye
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label motDePasseLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label sexeLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label noCiviqueLabel;
            System.Windows.Forms.Label rueLabel;
            System.Windows.Forms.Label villeLabel;
            System.Windows.Forms.Label idProvinceLabel;
            System.Windows.Forms.Label codePostalLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label cellulaireLabel;
            System.Windows.Forms.Label courrielLabel;
            System.Windows.Forms.Label salaireHoraireLabel;
            System.Windows.Forms.Label noTypeEmployeLabel;
            System.Windows.Forms.Label remarqueLabel;
            this.bDB56Pr211DataSet = new ProjetII_B56.BDB56Pr211DataSet();
            this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employesTableAdapter = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.EmployesTableAdapter();
            this.tableAdapterManager = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cboSexe = new System.Windows.Forms.ComboBox();
            this.nudSalaire = new System.Windows.Forms.NumericUpDown();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.cboTypeEmploye = new System.Windows.Forms.ComboBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtNoCivique = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtCourriel = new System.Windows.Forms.TextBox();
            this.txtCellulaire = new System.Windows.Forms.TextBox();
            this.txtRemarque = new System.Windows.Forms.TextBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            motDePasseLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            sexeLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            noCiviqueLabel = new System.Windows.Forms.Label();
            rueLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            idProvinceLabel = new System.Windows.Forms.Label();
            codePostalLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            cellulaireLabel = new System.Windows.Forms.Label();
            courrielLabel = new System.Windows.Forms.Label();
            salaireHoraireLabel = new System.Windows.Forms.Label();
            noTypeEmployeLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Pr211DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // motDePasseLabel
            // 
            motDePasseLabel.AutoSize = true;
            motDePasseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            motDePasseLabel.Location = new System.Drawing.Point(43, 60);
            motDePasseLabel.Name = "motDePasseLabel";
            motDePasseLabel.Size = new System.Drawing.Size(95, 16);
            motDePasseLabel.TabIndex = 3;
            motDePasseLabel.Text = "Mot De Passe:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomLabel.Location = new System.Drawing.Point(43, 86);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(39, 16);
            nomLabel.TabIndex = 5;
            nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prenomLabel.Location = new System.Drawing.Point(43, 112);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(57, 16);
            prenomLabel.TabIndex = 7;
            prenomLabel.Text = "Prenom:";
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexeLabel.Location = new System.Drawing.Point(43, 138);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(41, 16);
            sexeLabel.TabIndex = 9;
            sexeLabel.Text = "Sexe:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ageLabel.Location = new System.Drawing.Point(43, 164);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(35, 16);
            ageLabel.TabIndex = 11;
            ageLabel.Text = "Age:";
            // 
            // noCiviqueLabel
            // 
            noCiviqueLabel.AutoSize = true;
            noCiviqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noCiviqueLabel.Location = new System.Drawing.Point(43, 190);
            noCiviqueLabel.Name = "noCiviqueLabel";
            noCiviqueLabel.Size = new System.Drawing.Size(76, 16);
            noCiviqueLabel.TabIndex = 13;
            noCiviqueLabel.Text = "No Civique:";
            // 
            // rueLabel
            // 
            rueLabel.AutoSize = true;
            rueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rueLabel.Location = new System.Drawing.Point(43, 216);
            rueLabel.Name = "rueLabel";
            rueLabel.Size = new System.Drawing.Size(35, 16);
            rueLabel.TabIndex = 15;
            rueLabel.Text = "Rue:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            villeLabel.Location = new System.Drawing.Point(43, 242);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(36, 16);
            villeLabel.TabIndex = 17;
            villeLabel.Text = "Ville:";
            // 
            // idProvinceLabel
            // 
            idProvinceLabel.AutoSize = true;
            idProvinceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idProvinceLabel.Location = new System.Drawing.Point(300, 59);
            idProvinceLabel.Name = "idProvinceLabel";
            idProvinceLabel.Size = new System.Drawing.Size(77, 16);
            idProvinceLabel.TabIndex = 19;
            idProvinceLabel.Text = "Id Province:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codePostalLabel.Location = new System.Drawing.Point(300, 85);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(84, 16);
            codePostalLabel.TabIndex = 21;
            codePostalLabel.Text = "Code Postal:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telephoneLabel.Location = new System.Drawing.Point(300, 111);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(76, 16);
            telephoneLabel.TabIndex = 23;
            telephoneLabel.Text = "Telephone:";
            // 
            // cellulaireLabel
            // 
            cellulaireLabel.AutoSize = true;
            cellulaireLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cellulaireLabel.Location = new System.Drawing.Point(300, 137);
            cellulaireLabel.Name = "cellulaireLabel";
            cellulaireLabel.Size = new System.Drawing.Size(66, 16);
            cellulaireLabel.TabIndex = 25;
            cellulaireLabel.Text = "Cellulaire:";
            // 
            // courrielLabel
            // 
            courrielLabel.AutoSize = true;
            courrielLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            courrielLabel.Location = new System.Drawing.Point(300, 163);
            courrielLabel.Name = "courrielLabel";
            courrielLabel.Size = new System.Drawing.Size(56, 16);
            courrielLabel.TabIndex = 27;
            courrielLabel.Text = "Courriel:";
            // 
            // salaireHoraireLabel
            // 
            salaireHoraireLabel.AutoSize = true;
            salaireHoraireLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            salaireHoraireLabel.Location = new System.Drawing.Point(300, 189);
            salaireHoraireLabel.Name = "salaireHoraireLabel";
            salaireHoraireLabel.Size = new System.Drawing.Size(101, 16);
            salaireHoraireLabel.TabIndex = 29;
            salaireHoraireLabel.Text = "Salaire Horaire:";
            // 
            // noTypeEmployeLabel
            // 
            noTypeEmployeLabel.AutoSize = true;
            noTypeEmployeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noTypeEmployeLabel.Location = new System.Drawing.Point(300, 215);
            noTypeEmployeLabel.Name = "noTypeEmployeLabel";
            noTypeEmployeLabel.Size = new System.Drawing.Size(120, 16);
            noTypeEmployeLabel.TabIndex = 31;
            noTypeEmployeLabel.Text = "No Type Employe:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remarqueLabel.Location = new System.Drawing.Point(300, 241);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(74, 16);
            remarqueLabel.TabIndex = 33;
            remarqueLabel.Text = "Remarque:";
            // 
            // bDB56Pr211DataSet
            // 
            this.bDB56Pr211DataSet.DataSetName = "BDB56Pr211DataSet";
            this.bDB56Pr211DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employesBindingSource
            // 
            this.employesBindingSource.DataMember = "Employes";
            this.employesBindingSource.DataSource = this.bDB56Pr211DataSet;
            // 
            // employesTableAdapter
            // 
            this.employesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbonnementsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DependantsTableAdapter = null;
            this.tableAdapterManager.DepensesTableAdapter = null;
            this.tableAdapterManager.EmployesTableAdapter = this.employesTableAdapter;
            this.tableAdapterManager.PartiesJoueesTableAdapter = null;
            this.tableAdapterManager.PrixDepensesAbonnementsTableAdapter = null;
            this.tableAdapterManager.ProvincesTableAdapter = null;
            this.tableAdapterManager.ReabonnementsTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.TerrainsTableAdapter = null;
            this.tableAdapterManager.TypesAbonnementTableAdapter = null;
            this.tableAdapterManager.TypesEmployeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetII_B56.BDB56Pr211DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Saisie les nouveaux informations";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(154, 301);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(118, 23);
            this.btnEnregistrer.TabIndex = 36;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(302, 301);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(118, 23);
            this.btnAnnuler.TabIndex = 37;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // cboSexe
            // 
            this.cboSexe.FormattingEnabled = true;
            this.cboSexe.Location = new System.Drawing.Point(154, 134);
            this.cboSexe.Name = "cboSexe";
            this.cboSexe.Size = new System.Drawing.Size(134, 21);
            this.cboSexe.TabIndex = 38;
            // 
            // nudSalaire
            // 
            this.nudSalaire.Location = new System.Drawing.Point(423, 189);
            this.nudSalaire.Name = "nudSalaire";
            this.nudSalaire.Size = new System.Drawing.Size(134, 20);
            this.nudSalaire.TabIndex = 39;
            // 
            // cboProvince
            // 
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Location = new System.Drawing.Point(423, 59);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(134, 21);
            this.cboProvince.TabIndex = 40;
            // 
            // cboTypeEmploye
            // 
            this.cboTypeEmploye.FormattingEnabled = true;
            this.cboTypeEmploye.Location = new System.Drawing.Point(427, 211);
            this.cboTypeEmploye.Name = "cboTypeEmploye";
            this.cboTypeEmploye.Size = new System.Drawing.Size(130, 21);
            this.cboTypeEmploye.TabIndex = 41;
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Location = new System.Drawing.Point(154, 60);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(134, 20);
            this.txtMotDePasse.TabIndex = 42;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(154, 85);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(134, 20);
            this.txtNom.TabIndex = 43;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(154, 111);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(134, 20);
            this.txtPrenom.TabIndex = 44;
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(154, 215);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(134, 20);
            this.txtRue.TabIndex = 45;
            // 
            // txtNoCivique
            // 
            this.txtNoCivique.Location = new System.Drawing.Point(154, 186);
            this.txtNoCivique.Name = "txtNoCivique";
            this.txtNoCivique.Size = new System.Drawing.Size(134, 20);
            this.txtNoCivique.TabIndex = 46;
            this.txtNoCivique.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(154, 242);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(134, 20);
            this.txtVille.TabIndex = 48;
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(423, 86);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(134, 20);
            this.txtCodePostal.TabIndex = 49;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(423, 112);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(134, 20);
            this.txtTelephone.TabIndex = 50;
            // 
            // txtCourriel
            // 
            this.txtCourriel.Location = new System.Drawing.Point(423, 164);
            this.txtCourriel.Name = "txtCourriel";
            this.txtCourriel.Size = new System.Drawing.Size(134, 20);
            this.txtCourriel.TabIndex = 51;
            // 
            // txtCellulaire
            // 
            this.txtCellulaire.Location = new System.Drawing.Point(423, 138);
            this.txtCellulaire.Name = "txtCellulaire";
            this.txtCellulaire.Size = new System.Drawing.Size(134, 20);
            this.txtCellulaire.TabIndex = 52;
            // 
            // txtRemarque
            // 
            this.txtRemarque.Location = new System.Drawing.Point(423, 238);
            this.txtRemarque.Name = "txtRemarque";
            this.txtRemarque.Size = new System.Drawing.Size(134, 20);
            this.txtRemarque.TabIndex = 53;
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(152, 159);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(136, 20);
            this.nudAge.TabIndex = 54;
            // 
            // frmAjouterEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 335);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.txtRemarque);
            this.Controls.Add(this.txtCellulaire);
            this.Controls.Add(this.txtCourriel);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtCodePostal);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtNoCivique);
            this.Controls.Add(this.txtRue);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.cboTypeEmploye);
            this.Controls.Add(this.cboProvince);
            this.Controls.Add(this.nudSalaire);
            this.Controls.Add(this.cboSexe);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.label1);
            this.Controls.Add(motDePasseLabel);
            this.Controls.Add(nomLabel);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(sexeLabel);
            this.Controls.Add(ageLabel);
            this.Controls.Add(noCiviqueLabel);
            this.Controls.Add(rueLabel);
            this.Controls.Add(villeLabel);
            this.Controls.Add(idProvinceLabel);
            this.Controls.Add(codePostalLabel);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(cellulaireLabel);
            this.Controls.Add(courrielLabel);
            this.Controls.Add(salaireHoraireLabel);
            this.Controls.Add(noTypeEmployeLabel);
            this.Controls.Add(remarqueLabel);
            this.Name = "frmAjouterEmploye";
            this.Text = "Ajouter un employe";
            this.Load += new System.EventHandler(this.frmAjouterEmploye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Pr211DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56Pr211DataSet bDB56Pr211DataSet;
        private System.Windows.Forms.BindingSource employesBindingSource;
        private BDB56Pr211DataSetTableAdapters.EmployesTableAdapter employesTableAdapter;
        private BDB56Pr211DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ComboBox cboSexe;
        private System.Windows.Forms.NumericUpDown nudSalaire;
        private System.Windows.Forms.ComboBox cboProvince;
        private System.Windows.Forms.ComboBox cboTypeEmploye;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtNoCivique;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtCourriel;
        private System.Windows.Forms.TextBox txtCellulaire;
        private System.Windows.Forms.TextBox txtRemarque;
        private System.Windows.Forms.NumericUpDown nudAge;
    }
}