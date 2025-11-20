namespace ProjetII_B56
{
    partial class frmModifieEmploye
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
            System.Windows.Forms.Label noLabel;
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bDB56Pr211DataSet = new ProjetII_B56.BDB56Pr211DataSet();
            this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employesTableAdapter = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.EmployesTableAdapter();
            this.tableAdapterManager = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.TableAdapterManager();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNoCivique = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtCellulaire = new System.Windows.Forms.TextBox();
            this.txtCourriel = new System.Windows.Forms.TextBox();
            this.txtRemarque = new System.Windows.Forms.TextBox();
            this.cboSexe = new System.Windows.Forms.ComboBox();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.cboTypeEmployes = new System.Windows.Forms.ComboBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.nudSalaire = new System.Windows.Forms.NumericUpDown();
            noLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalaire)).BeginInit();
            this.SuspendLayout();
            // 
            // noLabel
            // 
            noLabel.AutoSize = true;
            noLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noLabel.Location = new System.Drawing.Point(50, 49);
            noLabel.Name = "noLabel";
            noLabel.Size = new System.Drawing.Size(28, 16);
            noLabel.TabIndex = 75;
            noLabel.Text = "No:";
            // 
            // motDePasseLabel
            // 
            motDePasseLabel.AutoSize = true;
            motDePasseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            motDePasseLabel.Location = new System.Drawing.Point(50, 75);
            motDePasseLabel.Name = "motDePasseLabel";
            motDePasseLabel.Size = new System.Drawing.Size(95, 16);
            motDePasseLabel.TabIndex = 77;
            motDePasseLabel.Text = "Mot De Passe:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomLabel.Location = new System.Drawing.Point(50, 101);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(39, 16);
            nomLabel.TabIndex = 79;
            nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prenomLabel.Location = new System.Drawing.Point(50, 127);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(57, 16);
            prenomLabel.TabIndex = 81;
            prenomLabel.Text = "Prenom:";
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexeLabel.Location = new System.Drawing.Point(50, 153);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(41, 16);
            sexeLabel.TabIndex = 83;
            sexeLabel.Text = "Sexe:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ageLabel.Location = new System.Drawing.Point(50, 179);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(35, 16);
            ageLabel.TabIndex = 85;
            ageLabel.Text = "Age:";
            // 
            // noCiviqueLabel
            // 
            noCiviqueLabel.AutoSize = true;
            noCiviqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noCiviqueLabel.Location = new System.Drawing.Point(50, 205);
            noCiviqueLabel.Name = "noCiviqueLabel";
            noCiviqueLabel.Size = new System.Drawing.Size(76, 16);
            noCiviqueLabel.TabIndex = 87;
            noCiviqueLabel.Text = "No Civique:";
            // 
            // rueLabel
            // 
            rueLabel.AutoSize = true;
            rueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rueLabel.Location = new System.Drawing.Point(50, 231);
            rueLabel.Name = "rueLabel";
            rueLabel.Size = new System.Drawing.Size(35, 16);
            rueLabel.TabIndex = 89;
            rueLabel.Text = "Rue:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            villeLabel.Location = new System.Drawing.Point(50, 257);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(36, 16);
            villeLabel.TabIndex = 91;
            villeLabel.Text = "Ville:";
            // 
            // idProvinceLabel
            // 
            idProvinceLabel.AutoSize = true;
            idProvinceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idProvinceLabel.Location = new System.Drawing.Point(328, 49);
            idProvinceLabel.Name = "idProvinceLabel";
            idProvinceLabel.Size = new System.Drawing.Size(77, 16);
            idProvinceLabel.TabIndex = 93;
            idProvinceLabel.Text = "Id Province:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codePostalLabel.Location = new System.Drawing.Point(328, 75);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(84, 16);
            codePostalLabel.TabIndex = 95;
            codePostalLabel.Text = "Code Postal:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telephoneLabel.Location = new System.Drawing.Point(328, 101);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(76, 16);
            telephoneLabel.TabIndex = 97;
            telephoneLabel.Text = "Telephone:";
            // 
            // cellulaireLabel
            // 
            cellulaireLabel.AutoSize = true;
            cellulaireLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cellulaireLabel.Location = new System.Drawing.Point(328, 127);
            cellulaireLabel.Name = "cellulaireLabel";
            cellulaireLabel.Size = new System.Drawing.Size(66, 16);
            cellulaireLabel.TabIndex = 99;
            cellulaireLabel.Text = "Cellulaire:";
            // 
            // courrielLabel
            // 
            courrielLabel.AutoSize = true;
            courrielLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            courrielLabel.Location = new System.Drawing.Point(328, 153);
            courrielLabel.Name = "courrielLabel";
            courrielLabel.Size = new System.Drawing.Size(56, 16);
            courrielLabel.TabIndex = 101;
            courrielLabel.Text = "Courriel:";
            // 
            // salaireHoraireLabel
            // 
            salaireHoraireLabel.AutoSize = true;
            salaireHoraireLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            salaireHoraireLabel.Location = new System.Drawing.Point(328, 179);
            salaireHoraireLabel.Name = "salaireHoraireLabel";
            salaireHoraireLabel.Size = new System.Drawing.Size(101, 16);
            salaireHoraireLabel.TabIndex = 103;
            salaireHoraireLabel.Text = "Salaire Horaire:";
            // 
            // noTypeEmployeLabel
            // 
            noTypeEmployeLabel.AutoSize = true;
            noTypeEmployeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noTypeEmployeLabel.Location = new System.Drawing.Point(328, 205);
            noTypeEmployeLabel.Name = "noTypeEmployeLabel";
            noTypeEmployeLabel.Size = new System.Drawing.Size(120, 16);
            noTypeEmployeLabel.TabIndex = 105;
            noTypeEmployeLabel.Text = "No Type Employe:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remarqueLabel.Location = new System.Drawing.Point(328, 231);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(74, 16);
            remarqueLabel.TabIndex = 107;
            remarqueLabel.Text = "Remarque:";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(331, 293);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(118, 23);
            this.btnAnnuler.TabIndex = 74;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSauvegarder.Location = new System.Drawing.Point(207, 293);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(118, 23);
            this.btnSauvegarder.TabIndex = 73;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 72;
            this.label1.Text = "Détailes de l\'employe";
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
            // txtNo
            // 
            this.txtNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "No", true));
            this.txtNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNo.Location = new System.Drawing.Point(150, 46);
            this.txtNo.Name = "txtNo";
            this.txtNo.ReadOnly = true;
            this.txtNo.Size = new System.Drawing.Size(130, 22);
            this.txtNo.TabIndex = 76;
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "MotDePasse", true));
            this.txtMotDePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotDePasse.Location = new System.Drawing.Point(150, 72);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(130, 22);
            this.txtMotDePasse.TabIndex = 78;
            // 
            // txtNom
            // 
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Nom", true));
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(150, 98);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(130, 22);
            this.txtNom.TabIndex = 80;
            // 
            // txtPrenom
            // 
            this.txtPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Prenom", true));
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(150, 124);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(130, 22);
            this.txtPrenom.TabIndex = 82;
            // 
            // txtNoCivique
            // 
            this.txtNoCivique.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "NoCivique", true));
            this.txtNoCivique.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoCivique.Location = new System.Drawing.Point(150, 202);
            this.txtNoCivique.Name = "txtNoCivique";
            this.txtNoCivique.Size = new System.Drawing.Size(130, 22);
            this.txtNoCivique.TabIndex = 88;
            // 
            // txtRue
            // 
            this.txtRue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Rue", true));
            this.txtRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRue.Location = new System.Drawing.Point(150, 228);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(130, 22);
            this.txtRue.TabIndex = 90;
            // 
            // txtVille
            // 
            this.txtVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Ville", true));
            this.txtVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVille.Location = new System.Drawing.Point(150, 254);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(130, 22);
            this.txtVille.TabIndex = 92;
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "CodePostal", true));
            this.txtCodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodePostal.Location = new System.Drawing.Point(454, 72);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(130, 22);
            this.txtCodePostal.TabIndex = 96;
            this.txtCodePostal.TextChanged += new System.EventHandler(this.codePostalTextBox_TextChanged);
            // 
            // txtTelephone
            // 
            this.txtTelephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Telephone", true));
            this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.Location = new System.Drawing.Point(454, 98);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(130, 22);
            this.txtTelephone.TabIndex = 98;
            // 
            // txtCellulaire
            // 
            this.txtCellulaire.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Cellulaire", true));
            this.txtCellulaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellulaire.Location = new System.Drawing.Point(454, 124);
            this.txtCellulaire.Name = "txtCellulaire";
            this.txtCellulaire.Size = new System.Drawing.Size(130, 22);
            this.txtCellulaire.TabIndex = 100;
            this.txtCellulaire.TextChanged += new System.EventHandler(this.cellulaireTextBox_TextChanged);
            // 
            // txtCourriel
            // 
            this.txtCourriel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Courriel", true));
            this.txtCourriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourriel.Location = new System.Drawing.Point(454, 150);
            this.txtCourriel.Name = "txtCourriel";
            this.txtCourriel.Size = new System.Drawing.Size(130, 22);
            this.txtCourriel.TabIndex = 102;
            // 
            // txtRemarque
            // 
            this.txtRemarque.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Remarque", true));
            this.txtRemarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarque.Location = new System.Drawing.Point(454, 228);
            this.txtRemarque.Name = "txtRemarque";
            this.txtRemarque.Size = new System.Drawing.Size(130, 22);
            this.txtRemarque.TabIndex = 108;
            // 
            // cboSexe
            // 
            this.cboSexe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Sexe", true));
            this.cboSexe.FormattingEnabled = true;
            this.cboSexe.Location = new System.Drawing.Point(150, 149);
            this.cboSexe.Name = "cboSexe";
            this.cboSexe.Size = new System.Drawing.Size(130, 21);
            this.cboSexe.TabIndex = 109;
            // 
            // cboProvince
            // 
            this.cboProvince.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "IdProvince", true));
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Location = new System.Drawing.Point(454, 49);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(130, 21);
            this.cboProvince.TabIndex = 110;
            // 
            // cboTypeEmployes
            // 
            this.cboTypeEmployes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "NoTypeEmploye", true));
            this.cboTypeEmployes.Enabled = false;
            this.cboTypeEmployes.FormattingEnabled = true;
            this.cboTypeEmployes.Location = new System.Drawing.Point(454, 204);
            this.cboTypeEmployes.Name = "cboTypeEmployes";
            this.cboTypeEmployes.Size = new System.Drawing.Size(130, 21);
            this.cboTypeEmployes.TabIndex = 111;
            // 
            // nudAge
            // 
            this.nudAge.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employesBindingSource, "Age", true));
            this.nudAge.Location = new System.Drawing.Point(150, 176);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(130, 20);
            this.nudAge.TabIndex = 112;
            // 
            // nudSalaire
            // 
            this.nudSalaire.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employesBindingSource, "SalaireHoraire", true));
            this.nudSalaire.Location = new System.Drawing.Point(454, 179);
            this.nudSalaire.Name = "nudSalaire";
            this.nudSalaire.Size = new System.Drawing.Size(130, 20);
            this.nudSalaire.TabIndex = 113;
            // 
            // frmModifieEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 339);
            this.Controls.Add(this.nudSalaire);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.cboTypeEmployes);
            this.Controls.Add(this.cboProvince);
            this.Controls.Add(this.cboSexe);
            this.Controls.Add(noLabel);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(motDePasseLabel);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(sexeLabel);
            this.Controls.Add(ageLabel);
            this.Controls.Add(noCiviqueLabel);
            this.Controls.Add(this.txtNoCivique);
            this.Controls.Add(rueLabel);
            this.Controls.Add(this.txtRue);
            this.Controls.Add(villeLabel);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(idProvinceLabel);
            this.Controls.Add(codePostalLabel);
            this.Controls.Add(this.txtCodePostal);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(cellulaireLabel);
            this.Controls.Add(this.txtCellulaire);
            this.Controls.Add(courrielLabel);
            this.Controls.Add(this.txtCourriel);
            this.Controls.Add(salaireHoraireLabel);
            this.Controls.Add(noTypeEmployeLabel);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.txtRemarque);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.label1);
            this.Name = "frmModifieEmploye";
            this.Text = "Modifier un employe";
            this.Load += new System.EventHandler(this.frmModifieEmploye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Pr211DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Label label1;
        private BDB56Pr211DataSet bDB56Pr211DataSet;
        private System.Windows.Forms.BindingSource employesBindingSource;
        private BDB56Pr211DataSetTableAdapters.EmployesTableAdapter employesTableAdapter;
        private BDB56Pr211DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNoCivique;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtCellulaire;
        private System.Windows.Forms.TextBox txtCourriel;
        private System.Windows.Forms.TextBox txtRemarque;
        private System.Windows.Forms.ComboBox cboSexe;
        private System.Windows.Forms.ComboBox cboProvince;
        private System.Windows.Forms.ComboBox cboTypeEmployes;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.NumericUpDown nudSalaire;
    }
}