namespace ProjetII_B56
{
    partial class frmModifierAbonnementDependant
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
            System.Windows.Forms.Label dateNaissanceLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label remarqueLabel;
            System.Windows.Forms.Label IDLabel;
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxSexe = new System.Windows.Forms.ComboBox();
            this.provincesComboBox = new System.Windows.Forms.ComboBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.titre = new System.Windows.Forms.Label();
            this.cellulaireTextBox = new System.Windows.Forms.TextBox();
            this.codePostalTextBox = new System.Windows.Forms.TextBox();
            this.courrielTextBox = new System.Windows.Forms.TextBox();
            this.dateAbonnementDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateNaissanceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.noCiviqueTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.remarqueTextBox = new System.Windows.Forms.TextBox();
            this.rueTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.villeTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.typesAbonnementComboBox = new System.Windows.Forms.ComboBox();
            this.rueLabel = new System.Windows.Forms.Label();
            this.villeLabel = new System.Windows.Forms.Label();
            this.codePostalLabel = new System.Windows.Forms.Label();
            this.provinceLabel = new System.Windows.Forms.Label();
            this.typeAbonnementLabel = new System.Windows.Forms.Label();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.dateAbonnementLabel = new System.Windows.Forms.Label();
            this.cellulaireLabel = new System.Windows.Forms.Label();
            this.noCiviqueLabel = new System.Windows.Forms.Label();
            this.courrielLabel = new System.Windows.Forms.Label();
            this.sexeLabel = new System.Windows.Forms.Label();
            dateNaissanceLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateNaissanceLabel
            // 
            dateNaissanceLabel.AutoSize = true;
            dateNaissanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateNaissanceLabel.Location = new System.Drawing.Point(36, 158);
            dateNaissanceLabel.Name = "dateNaissanceLabel";
            dateNaissanceLabel.Size = new System.Drawing.Size(134, 20);
            dateNaissanceLabel.TabIndex = 122;
            dateNaissanceLabel.Text = "Date Naissance:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomLabel.Location = new System.Drawing.Point(36, 101);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(49, 20);
            nomLabel.TabIndex = 127;
            nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prenomLabel.Location = new System.Drawing.Point(36, 129);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(72, 20);
            prenomLabel.TabIndex = 130;
            prenomLabel.Text = "Prenom:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remarqueLabel.Location = new System.Drawing.Point(36, 211);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(91, 20);
            remarqueLabel.TabIndex = 132;
            remarqueLabel.Text = "Remarque:";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            IDLabel.Location = new System.Drawing.Point(36, 76);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new System.Drawing.Size(31, 20);
            IDLabel.TabIndex = 147;
            IDLabel.Text = "ID:";
            // 
            // abonnementsBindingSource
            // 
            this.abonnementsBindingSource.DataSource = typeof(ProjetII_B56.Abonnements);
            // 
            // comboBoxSexe
            // 
            this.comboBoxSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSexe.FormattingEnabled = true;
            this.comboBoxSexe.Location = new System.Drawing.Point(215, 183);
            this.comboBoxSexe.Name = "comboBoxSexe";
            this.comboBoxSexe.Size = new System.Drawing.Size(200, 28);
            this.comboBoxSexe.TabIndex = 146;
            // 
            // provincesComboBox
            // 
            this.provincesComboBox.DisplayMember = "Nom";
            this.provincesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provincesComboBox.FormattingEnabled = true;
            this.provincesComboBox.Location = new System.Drawing.Point(215, 344);
            this.provincesComboBox.Name = "provincesComboBox";
            this.provincesComboBox.Size = new System.Drawing.Size(200, 28);
            this.provincesComboBox.TabIndex = 144;
            this.provincesComboBox.ValueMember = "Id";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(486, 110);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(121, 30);
            this.btnAnnuler.TabIndex = 143;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSauvegarder.Location = new System.Drawing.Point(486, 74);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(121, 30);
            this.btnSauvegarder.TabIndex = 142;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(135, 9);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(360, 32);
            this.titre.TabIndex = 141;
            this.titre.Text = "Modifier une abonnement";
            // 
            // cellulaireTextBox
            // 
            this.cellulaireTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellulaireTextBox.Location = new System.Drawing.Point(215, 458);
            this.cellulaireTextBox.Name = "cellulaireTextBox";
            this.cellulaireTextBox.Size = new System.Drawing.Size(200, 27);
            this.cellulaireTextBox.TabIndex = 115;
            // 
            // codePostalTextBox
            // 
            this.codePostalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codePostalTextBox.Location = new System.Drawing.Point(215, 315);
            this.codePostalTextBox.Name = "codePostalTextBox";
            this.codePostalTextBox.Size = new System.Drawing.Size(200, 27);
            this.codePostalTextBox.TabIndex = 117;
            // 
            // courrielTextBox
            // 
            this.courrielTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courrielTextBox.Location = new System.Drawing.Point(215, 514);
            this.courrielTextBox.Name = "courrielTextBox";
            this.courrielTextBox.Size = new System.Drawing.Size(200, 27);
            this.courrielTextBox.TabIndex = 119;
            // 
            // dateAbonnementDateTimePicker
            // 
            this.dateAbonnementDateTimePicker.Enabled = false;
            this.dateAbonnementDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAbonnementDateTimePicker.Location = new System.Drawing.Point(215, 402);
            this.dateAbonnementDateTimePicker.Name = "dateAbonnementDateTimePicker";
            this.dateAbonnementDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.dateAbonnementDateTimePicker.TabIndex = 121;
            // 
            // dateNaissanceDateTimePicker
            // 
            this.dateNaissanceDateTimePicker.Enabled = false;
            this.dateNaissanceDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNaissanceDateTimePicker.Location = new System.Drawing.Point(215, 155);
            this.dateNaissanceDateTimePicker.Name = "dateNaissanceDateTimePicker";
            this.dateNaissanceDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.dateNaissanceDateTimePicker.TabIndex = 123;
            // 
            // noCiviqueTextBox
            // 
            this.noCiviqueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noCiviqueTextBox.Location = new System.Drawing.Point(215, 486);
            this.noCiviqueTextBox.Name = "noCiviqueTextBox";
            this.noCiviqueTextBox.Size = new System.Drawing.Size(200, 27);
            this.noCiviqueTextBox.TabIndex = 126;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomTextBox.Location = new System.Drawing.Point(215, 99);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.ReadOnly = true;
            this.nomTextBox.Size = new System.Drawing.Size(200, 27);
            this.nomTextBox.TabIndex = 128;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomTextBox.Location = new System.Drawing.Point(215, 127);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(200, 27);
            this.prenomTextBox.TabIndex = 131;
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarqueTextBox.Location = new System.Drawing.Point(215, 208);
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(200, 27);
            this.remarqueTextBox.TabIndex = 133;
            // 
            // rueTextBox
            // 
            this.rueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rueTextBox.Location = new System.Drawing.Point(215, 259);
            this.rueTextBox.Name = "rueTextBox";
            this.rueTextBox.Size = new System.Drawing.Size(200, 27);
            this.rueTextBox.TabIndex = 135;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneTextBox.Location = new System.Drawing.Point(215, 430);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(200, 27);
            this.telephoneTextBox.TabIndex = 138;
            // 
            // villeTextBox
            // 
            this.villeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.villeTextBox.Location = new System.Drawing.Point(215, 287);
            this.villeTextBox.Name = "villeTextBox";
            this.villeTextBox.Size = new System.Drawing.Size(200, 27);
            this.villeTextBox.TabIndex = 140;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.Location = new System.Drawing.Point(215, 74);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(200, 27);
            this.IDTextBox.TabIndex = 148;
            // 
            // typesAbonnementComboBox
            // 
            this.typesAbonnementComboBox.DisplayMember = "Description";
            this.typesAbonnementComboBox.Enabled = false;
            this.typesAbonnementComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typesAbonnementComboBox.FormattingEnabled = true;
            this.typesAbonnementComboBox.Location = new System.Drawing.Point(215, 374);
            this.typesAbonnementComboBox.Name = "typesAbonnementComboBox";
            this.typesAbonnementComboBox.Size = new System.Drawing.Size(200, 28);
            this.typesAbonnementComboBox.TabIndex = 145;
            this.typesAbonnementComboBox.ValueMember = "No";
            // 
            // rueLabel
            // 
            this.rueLabel.AutoSize = true;
            this.rueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rueLabel.Location = new System.Drawing.Point(36, 262);
            this.rueLabel.Name = "rueLabel";
            this.rueLabel.Size = new System.Drawing.Size(44, 20);
            this.rueLabel.TabIndex = 149;
            this.rueLabel.Text = "Rue:";
            // 
            // villeLabel
            // 
            this.villeLabel.AutoSize = true;
            this.villeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.villeLabel.Location = new System.Drawing.Point(36, 290);
            this.villeLabel.Name = "villeLabel";
            this.villeLabel.Size = new System.Drawing.Size(46, 20);
            this.villeLabel.TabIndex = 150;
            this.villeLabel.Text = "Ville:";
            // 
            // codePostalLabel
            // 
            this.codePostalLabel.AutoSize = true;
            this.codePostalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codePostalLabel.Location = new System.Drawing.Point(36, 318);
            this.codePostalLabel.Name = "codePostalLabel";
            this.codePostalLabel.Size = new System.Drawing.Size(103, 20);
            this.codePostalLabel.TabIndex = 151;
            this.codePostalLabel.Text = "Code postal:";
            // 
            // provinceLabel
            // 
            this.provinceLabel.AutoSize = true;
            this.provinceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceLabel.Location = new System.Drawing.Point(36, 347);
            this.provinceLabel.Name = "provinceLabel";
            this.provinceLabel.Size = new System.Drawing.Size(79, 20);
            this.provinceLabel.TabIndex = 152;
            this.provinceLabel.Text = "Province:";
            // 
            // typeAbonnementLabel
            // 
            this.typeAbonnementLabel.AutoSize = true;
            this.typeAbonnementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeAbonnementLabel.Location = new System.Drawing.Point(36, 377);
            this.typeAbonnementLabel.Name = "typeAbonnementLabel";
            this.typeAbonnementLabel.Size = new System.Drawing.Size(148, 20);
            this.typeAbonnementLabel.TabIndex = 153;
            this.typeAbonnementLabel.Text = "Type Abonnement:";
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneLabel.Location = new System.Drawing.Point(36, 433);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(91, 20);
            this.telephoneLabel.TabIndex = 154;
            this.telephoneLabel.Text = "Telephone:";
            // 
            // dateAbonnementLabel
            // 
            this.dateAbonnementLabel.AutoSize = true;
            this.dateAbonnementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAbonnementLabel.Location = new System.Drawing.Point(36, 407);
            this.dateAbonnementLabel.Name = "dateAbonnementLabel";
            this.dateAbonnementLabel.Size = new System.Drawing.Size(148, 20);
            this.dateAbonnementLabel.TabIndex = 155;
            this.dateAbonnementLabel.Text = "Date Abonnement:";
            // 
            // cellulaireLabel
            // 
            this.cellulaireLabel.AutoSize = true;
            this.cellulaireLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellulaireLabel.Location = new System.Drawing.Point(36, 461);
            this.cellulaireLabel.Name = "cellulaireLabel";
            this.cellulaireLabel.Size = new System.Drawing.Size(84, 20);
            this.cellulaireLabel.TabIndex = 156;
            this.cellulaireLabel.Text = "Cellulaire:";
            // 
            // noCiviqueLabel
            // 
            this.noCiviqueLabel.AutoSize = true;
            this.noCiviqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noCiviqueLabel.Location = new System.Drawing.Point(36, 489);
            this.noCiviqueLabel.Name = "noCiviqueLabel";
            this.noCiviqueLabel.Size = new System.Drawing.Size(95, 20);
            this.noCiviqueLabel.TabIndex = 157;
            this.noCiviqueLabel.Text = "No Civique:";
            // 
            // courrielLabel
            // 
            this.courrielLabel.AutoSize = true;
            this.courrielLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courrielLabel.Location = new System.Drawing.Point(36, 517);
            this.courrielLabel.Name = "courrielLabel";
            this.courrielLabel.Size = new System.Drawing.Size(73, 20);
            this.courrielLabel.TabIndex = 158;
            this.courrielLabel.Text = "Courriel:";
            // 
            // sexeLabel
            // 
            this.sexeLabel.AutoSize = true;
            this.sexeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexeLabel.Location = new System.Drawing.Point(36, 186);
            this.sexeLabel.Name = "sexeLabel";
            this.sexeLabel.Size = new System.Drawing.Size(51, 20);
            this.sexeLabel.TabIndex = 159;
            this.sexeLabel.Text = "Sexe:";
            // 
            // frmModifierAbonnementDependant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 553);
            this.Controls.Add(this.sexeLabel);
            this.Controls.Add(this.courrielLabel);
            this.Controls.Add(this.noCiviqueLabel);
            this.Controls.Add(this.cellulaireLabel);
            this.Controls.Add(this.dateAbonnementLabel);
            this.Controls.Add(this.telephoneLabel);
            this.Controls.Add(this.typeAbonnementLabel);
            this.Controls.Add(this.provinceLabel);
            this.Controls.Add(this.codePostalLabel);
            this.Controls.Add(this.villeLabel);
            this.Controls.Add(this.rueLabel);
            this.Controls.Add(IDLabel);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.comboBoxSexe);
            this.Controls.Add(this.typesAbonnementComboBox);
            this.Controls.Add(this.provincesComboBox);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.cellulaireTextBox);
            this.Controls.Add(this.codePostalTextBox);
            this.Controls.Add(this.courrielTextBox);
            this.Controls.Add(this.dateAbonnementDateTimePicker);
            this.Controls.Add(dateNaissanceLabel);
            this.Controls.Add(this.dateNaissanceDateTimePicker);
            this.Controls.Add(this.noCiviqueTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.remarqueTextBox);
            this.Controls.Add(this.rueTextBox);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(this.villeTextBox);
            this.Name = "frmModifierAbonnementDependant";
            this.Text = "Modifier une donné";
            this.Load += new System.EventHandler(this.frmModifierAbonnementDependant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private System.Windows.Forms.ComboBox comboBoxSexe;
        private System.Windows.Forms.ComboBox provincesComboBox;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.TextBox cellulaireTextBox;
        private System.Windows.Forms.TextBox codePostalTextBox;
        private System.Windows.Forms.TextBox courrielTextBox;
        private System.Windows.Forms.DateTimePicker dateAbonnementDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateNaissanceDateTimePicker;
        private System.Windows.Forms.TextBox noCiviqueTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox remarqueTextBox;
        private System.Windows.Forms.TextBox rueTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox villeTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.ComboBox typesAbonnementComboBox;
        private System.Windows.Forms.Label rueLabel;
        private System.Windows.Forms.Label villeLabel;
        private System.Windows.Forms.Label codePostalLabel;
        private System.Windows.Forms.Label provinceLabel;
        private System.Windows.Forms.Label typeAbonnementLabel;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Label dateAbonnementLabel;
        private System.Windows.Forms.Label cellulaireLabel;
        private System.Windows.Forms.Label noCiviqueLabel;
        private System.Windows.Forms.Label courrielLabel;
        private System.Windows.Forms.Label sexeLabel;
    }
}