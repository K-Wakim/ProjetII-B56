namespace ProjetII_B56
{
    partial class frmAjouterAbonnement
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
            System.Windows.Forms.Label dateAbonnementLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label sexeLabel;
            System.Windows.Forms.Label dateNaissanceLabel;
            System.Windows.Forms.Label noCiviqueLabel;
            System.Windows.Forms.Label rueLabel;
            System.Windows.Forms.Label villeLabel;
            System.Windows.Forms.Label idProvinceLabel;
            System.Windows.Forms.Label codePostalLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label cellulaireLabel;
            System.Windows.Forms.Label courrielLabel;
            System.Windows.Forms.Label noTypeAbonnementLabel;
            System.Windows.Forms.Label remarqueLabel;
            this.bDB56Pr211DataSet = new ProjetII_B56.BDB56Pr211DataSet();
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonnementsTableAdapter = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.AbonnementsTableAdapter();
            this.tableAdapterManager = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.TableAdapterManager();
            this.provincesTableAdapter = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.ProvincesTableAdapter();
            this.typesAbonnementTableAdapter = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.TypesAbonnementTableAdapter();
            this.dateAbonnementDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.sexeTextBox = new System.Windows.Forms.TextBox();
            this.dateNaissanceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.noCiviqueTextBox = new System.Windows.Forms.TextBox();
            this.rueTextBox = new System.Windows.Forms.TextBox();
            this.villeTextBox = new System.Windows.Forms.TextBox();
            this.codePostalTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.cellulaireTextBox = new System.Windows.Forms.TextBox();
            this.courrielTextBox = new System.Windows.Forms.TextBox();
            this.remarqueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.noTypeAbonnementComboBox = new System.Windows.Forms.ComboBox();
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.idProvinceComboBox = new System.Windows.Forms.ComboBox();
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            dateAbonnementLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            sexeLabel = new System.Windows.Forms.Label();
            dateNaissanceLabel = new System.Windows.Forms.Label();
            noCiviqueLabel = new System.Windows.Forms.Label();
            rueLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            idProvinceLabel = new System.Windows.Forms.Label();
            codePostalLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            cellulaireLabel = new System.Windows.Forms.Label();
            courrielLabel = new System.Windows.Forms.Label();
            noTypeAbonnementLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Pr211DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dateAbonnementLabel
            // 
            dateAbonnementLabel.AutoSize = true;
            dateAbonnementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateAbonnementLabel.Location = new System.Drawing.Point(117, 58);
            dateAbonnementLabel.Name = "dateAbonnementLabel";
            dateAbonnementLabel.Size = new System.Drawing.Size(118, 16);
            dateAbonnementLabel.TabIndex = 3;
            dateAbonnementLabel.Text = "Date Abonnement:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomLabel.Location = new System.Drawing.Point(117, 83);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(39, 16);
            nomLabel.TabIndex = 5;
            nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prenomLabel.Location = new System.Drawing.Point(117, 109);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(57, 16);
            prenomLabel.TabIndex = 7;
            prenomLabel.Text = "Prenom:";
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexeLabel.Location = new System.Drawing.Point(117, 135);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(41, 16);
            sexeLabel.TabIndex = 9;
            sexeLabel.Text = "Sexe:";
            // 
            // dateNaissanceLabel
            // 
            dateNaissanceLabel.AutoSize = true;
            dateNaissanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateNaissanceLabel.Location = new System.Drawing.Point(117, 162);
            dateNaissanceLabel.Name = "dateNaissanceLabel";
            dateNaissanceLabel.Size = new System.Drawing.Size(107, 16);
            dateNaissanceLabel.TabIndex = 11;
            dateNaissanceLabel.Text = "Date Naissance:";
            // 
            // noCiviqueLabel
            // 
            noCiviqueLabel.AutoSize = true;
            noCiviqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noCiviqueLabel.Location = new System.Drawing.Point(117, 187);
            noCiviqueLabel.Name = "noCiviqueLabel";
            noCiviqueLabel.Size = new System.Drawing.Size(76, 16);
            noCiviqueLabel.TabIndex = 13;
            noCiviqueLabel.Text = "No Civique:";
            // 
            // rueLabel
            // 
            rueLabel.AutoSize = true;
            rueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rueLabel.Location = new System.Drawing.Point(117, 213);
            rueLabel.Name = "rueLabel";
            rueLabel.Size = new System.Drawing.Size(35, 16);
            rueLabel.TabIndex = 15;
            rueLabel.Text = "Rue:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            villeLabel.Location = new System.Drawing.Point(115, 239);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(36, 16);
            villeLabel.TabIndex = 17;
            villeLabel.Text = "Ville:";
            // 
            // idProvinceLabel
            // 
            idProvinceLabel.AutoSize = true;
            idProvinceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idProvinceLabel.Location = new System.Drawing.Point(486, 55);
            idProvinceLabel.Name = "idProvinceLabel";
            idProvinceLabel.Size = new System.Drawing.Size(63, 16);
            idProvinceLabel.TabIndex = 19;
            idProvinceLabel.Text = "Province:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codePostalLabel.Location = new System.Drawing.Point(486, 81);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(84, 16);
            codePostalLabel.TabIndex = 21;
            codePostalLabel.Text = "Code Postal:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telephoneLabel.Location = new System.Drawing.Point(486, 107);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(76, 16);
            telephoneLabel.TabIndex = 23;
            telephoneLabel.Text = "Telephone:";
            // 
            // cellulaireLabel
            // 
            cellulaireLabel.AutoSize = true;
            cellulaireLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cellulaireLabel.Location = new System.Drawing.Point(486, 133);
            cellulaireLabel.Name = "cellulaireLabel";
            cellulaireLabel.Size = new System.Drawing.Size(66, 16);
            cellulaireLabel.TabIndex = 25;
            cellulaireLabel.Text = "Cellulaire:";
            // 
            // courrielLabel
            // 
            courrielLabel.AutoSize = true;
            courrielLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            courrielLabel.Location = new System.Drawing.Point(486, 159);
            courrielLabel.Name = "courrielLabel";
            courrielLabel.Size = new System.Drawing.Size(56, 16);
            courrielLabel.TabIndex = 27;
            courrielLabel.Text = "Courriel:";
            // 
            // noTypeAbonnementLabel
            // 
            noTypeAbonnementLabel.AutoSize = true;
            noTypeAbonnementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noTypeAbonnementLabel.Location = new System.Drawing.Point(486, 185);
            noTypeAbonnementLabel.Name = "noTypeAbonnementLabel";
            noTypeAbonnementLabel.Size = new System.Drawing.Size(121, 16);
            noTypeAbonnementLabel.TabIndex = 29;
            noTypeAbonnementLabel.Text = "Type Abonnement:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remarqueLabel.Location = new System.Drawing.Point(486, 211);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(74, 16);
            remarqueLabel.TabIndex = 31;
            remarqueLabel.Text = "Remarque:";
            // 
            // bDB56Pr211DataSet
            // 
            this.bDB56Pr211DataSet.DataSetName = "BDB56Pr211DataSet";
            this.bDB56Pr211DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // abonnementsBindingSource
            // 
            this.abonnementsBindingSource.DataMember = "Abonnements";
            this.abonnementsBindingSource.DataSource = this.bDB56Pr211DataSet;
            // 
            // abonnementsTableAdapter
            // 
            this.abonnementsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbonnementsTableAdapter = this.abonnementsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DependantsTableAdapter = null;
            this.tableAdapterManager.DepensesTableAdapter = null;
            this.tableAdapterManager.EmployesTableAdapter = null;
            this.tableAdapterManager.PartiesJoueesTableAdapter = null;
            this.tableAdapterManager.PrixDepensesAbonnementsTableAdapter = null;
            this.tableAdapterManager.ProvincesTableAdapter = this.provincesTableAdapter;
            this.tableAdapterManager.ReabonnementsTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.TerrainsTableAdapter = null;
            this.tableAdapterManager.TypesAbonnementTableAdapter = this.typesAbonnementTableAdapter;
            this.tableAdapterManager.TypesEmployeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetII_B56.BDB56Pr211DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // provincesTableAdapter
            // 
            this.provincesTableAdapter.ClearBeforeFill = true;
            // 
            // typesAbonnementTableAdapter
            // 
            this.typesAbonnementTableAdapter.ClearBeforeFill = true;
            // 
            // dateAbonnementDateTimePicker
            // 
            this.dateAbonnementDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.abonnementsBindingSource, "DateAbonnement", true));
            this.dateAbonnementDateTimePicker.Enabled = false;
            this.dateAbonnementDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAbonnementDateTimePicker.Location = new System.Drawing.Point(256, 54);
            this.dateAbonnementDateTimePicker.Name = "dateAbonnementDateTimePicker";
            this.dateAbonnementDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateAbonnementDateTimePicker.TabIndex = 4;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Nom", true));
            this.nomTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomTextBox.Location = new System.Drawing.Point(256, 80);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(200, 22);
            this.nomTextBox.TabIndex = 6;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Prenom", true));
            this.prenomTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomTextBox.Location = new System.Drawing.Point(256, 106);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(200, 22);
            this.prenomTextBox.TabIndex = 8;
            // 
            // sexeTextBox
            // 
            this.sexeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Sexe", true));
            this.sexeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexeTextBox.Location = new System.Drawing.Point(256, 132);
            this.sexeTextBox.Name = "sexeTextBox";
            this.sexeTextBox.Size = new System.Drawing.Size(200, 22);
            this.sexeTextBox.TabIndex = 10;
            // 
            // dateNaissanceDateTimePicker
            // 
            this.dateNaissanceDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.abonnementsBindingSource, "DateNaissance", true));
            this.dateNaissanceDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNaissanceDateTimePicker.Location = new System.Drawing.Point(256, 158);
            this.dateNaissanceDateTimePicker.Name = "dateNaissanceDateTimePicker";
            this.dateNaissanceDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateNaissanceDateTimePicker.TabIndex = 12;
            // 
            // noCiviqueTextBox
            // 
            this.noCiviqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "NoCivique", true));
            this.noCiviqueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noCiviqueTextBox.Location = new System.Drawing.Point(256, 184);
            this.noCiviqueTextBox.Name = "noCiviqueTextBox";
            this.noCiviqueTextBox.Size = new System.Drawing.Size(200, 22);
            this.noCiviqueTextBox.TabIndex = 14;
            // 
            // rueTextBox
            // 
            this.rueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Rue", true));
            this.rueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rueTextBox.Location = new System.Drawing.Point(256, 210);
            this.rueTextBox.Name = "rueTextBox";
            this.rueTextBox.Size = new System.Drawing.Size(200, 22);
            this.rueTextBox.TabIndex = 16;
            // 
            // villeTextBox
            // 
            this.villeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Ville", true));
            this.villeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.villeTextBox.Location = new System.Drawing.Point(256, 236);
            this.villeTextBox.Name = "villeTextBox";
            this.villeTextBox.Size = new System.Drawing.Size(200, 22);
            this.villeTextBox.TabIndex = 18;
            // 
            // codePostalTextBox
            // 
            this.codePostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "CodePostal", true));
            this.codePostalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codePostalTextBox.Location = new System.Drawing.Point(627, 78);
            this.codePostalTextBox.Name = "codePostalTextBox";
            this.codePostalTextBox.Size = new System.Drawing.Size(200, 22);
            this.codePostalTextBox.TabIndex = 22;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Telephone", true));
            this.telephoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneTextBox.Location = new System.Drawing.Point(627, 104);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(200, 22);
            this.telephoneTextBox.TabIndex = 24;
            // 
            // cellulaireTextBox
            // 
            this.cellulaireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Cellulaire", true));
            this.cellulaireTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellulaireTextBox.Location = new System.Drawing.Point(627, 130);
            this.cellulaireTextBox.Name = "cellulaireTextBox";
            this.cellulaireTextBox.Size = new System.Drawing.Size(200, 22);
            this.cellulaireTextBox.TabIndex = 26;
            // 
            // courrielTextBox
            // 
            this.courrielTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Courriel", true));
            this.courrielTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courrielTextBox.Location = new System.Drawing.Point(627, 156);
            this.courrielTextBox.Name = "courrielTextBox";
            this.courrielTextBox.Size = new System.Drawing.Size(200, 22);
            this.courrielTextBox.TabIndex = 28;
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Remarque", true));
            this.remarqueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarqueTextBox.Location = new System.Drawing.Point(627, 208);
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(200, 22);
            this.remarqueTextBox.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ajouter une abonnement";
            // 
            // noTypeAbonnementComboBox
            // 
            this.noTypeAbonnementComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "NoTypeAbonnement", true));
            this.noTypeAbonnementComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.abonnementsBindingSource, "NoTypeAbonnement", true));
            this.noTypeAbonnementComboBox.DataSource = this.typesAbonnementBindingSource;
            this.noTypeAbonnementComboBox.DisplayMember = "Description";
            this.noTypeAbonnementComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noTypeAbonnementComboBox.FormattingEnabled = true;
            this.noTypeAbonnementComboBox.Location = new System.Drawing.Point(627, 182);
            this.noTypeAbonnementComboBox.Name = "noTypeAbonnementComboBox";
            this.noTypeAbonnementComboBox.Size = new System.Drawing.Size(200, 24);
            this.noTypeAbonnementComboBox.TabIndex = 34;
            this.noTypeAbonnementComboBox.ValueMember = "No";
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataMember = "TypesAbonnement";
            this.typesAbonnementBindingSource.DataSource = this.bDB56Pr211DataSet;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(343, 273);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(113, 27);
            this.btnEnregistrer.TabIndex = 35;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(462, 273);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(113, 27);
            this.btnAnnuler.TabIndex = 36;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // idProvinceComboBox
            // 
            this.idProvinceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "IdProvince", true));
            this.idProvinceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.abonnementsBindingSource, "IdProvince", true));
            this.idProvinceComboBox.DataSource = this.provincesBindingSource;
            this.idProvinceComboBox.DisplayMember = "Nom";
            this.idProvinceComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProvinceComboBox.FormattingEnabled = true;
            this.idProvinceComboBox.Location = new System.Drawing.Point(627, 54);
            this.idProvinceComboBox.Name = "idProvinceComboBox";
            this.idProvinceComboBox.Size = new System.Drawing.Size(200, 24);
            this.idProvinceComboBox.TabIndex = 37;
            this.idProvinceComboBox.ValueMember = "Id";
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataMember = "Provinces";
            this.provincesBindingSource.DataSource = this.bDB56Pr211DataSet;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmAjouterAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 327);
            this.Controls.Add(this.idProvinceComboBox);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.noTypeAbonnementComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(dateAbonnementLabel);
            this.Controls.Add(this.dateAbonnementDateTimePicker);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(sexeLabel);
            this.Controls.Add(this.sexeTextBox);
            this.Controls.Add(dateNaissanceLabel);
            this.Controls.Add(this.dateNaissanceDateTimePicker);
            this.Controls.Add(noCiviqueLabel);
            this.Controls.Add(this.noCiviqueTextBox);
            this.Controls.Add(rueLabel);
            this.Controls.Add(this.rueTextBox);
            this.Controls.Add(villeLabel);
            this.Controls.Add(this.villeTextBox);
            this.Controls.Add(idProvinceLabel);
            this.Controls.Add(codePostalLabel);
            this.Controls.Add(this.codePostalTextBox);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(cellulaireLabel);
            this.Controls.Add(this.cellulaireTextBox);
            this.Controls.Add(courrielLabel);
            this.Controls.Add(this.courrielTextBox);
            this.Controls.Add(noTypeAbonnementLabel);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.remarqueTextBox);
            this.Name = "frmAjouterAbonnement";
            this.Text = "L\'ajout d\'une abonnement";
            this.Load += new System.EventHandler(this.frmAjouterAbonnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Pr211DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56Pr211DataSet bDB56Pr211DataSet;
        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private BDB56Pr211DataSetTableAdapters.AbonnementsTableAdapter abonnementsTableAdapter;
        private BDB56Pr211DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dateAbonnementDateTimePicker;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox sexeTextBox;
        private System.Windows.Forms.DateTimePicker dateNaissanceDateTimePicker;
        private System.Windows.Forms.TextBox noCiviqueTextBox;
        private System.Windows.Forms.TextBox rueTextBox;
        private System.Windows.Forms.TextBox villeTextBox;
        private System.Windows.Forms.TextBox codePostalTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox cellulaireTextBox;
        private System.Windows.Forms.TextBox courrielTextBox;
        private System.Windows.Forms.TextBox remarqueTextBox;
        private System.Windows.Forms.Label label1;
        private BDB56Pr211DataSetTableAdapters.TypesAbonnementTableAdapter typesAbonnementTableAdapter;
        private System.Windows.Forms.ComboBox noTypeAbonnementComboBox;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private BDB56Pr211DataSetTableAdapters.ProvincesTableAdapter provincesTableAdapter;
        private System.Windows.Forms.ComboBox idProvinceComboBox;
        private System.Windows.Forms.BindingSource provincesBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}