namespace ProjetII_B56
{
    partial class frmStatisque
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AboonementParAnneeEtType = new System.Windows.Forms.TabPage();
            this.AbonnementParMoisEtType = new System.Windows.Forms.TabPage();
            this.PartiesParAnneeEtTerrain = new System.Windows.Forms.TabPage();
            this.PartiesParMoisEtTerrain = new System.Windows.Forms.TabPage();
            this.DepensesParAnneeEtABonnement = new System.Windows.Forms.TabPage();
            this.DepensesParMoisEtAbonnement = new System.Windows.Forms.TabPage();
            this.lblTitreAbonneParAnneeEtType = new System.Windows.Forms.Label();
            this.lblTypeAbonnement = new System.Windows.Forms.Label();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.cbTypeAbonnee = new System.Windows.Forms.ComboBox();
            this.nudAnnee = new System.Windows.Forms.NumericUpDown();
            this.AbonneParAnneeEtTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.lblTitreAbonneParMoisEtType = new System.Windows.Forms.Label();
            this.cbTypeAbonne = new System.Windows.Forms.ComboBox();
            this.lblTypeAbonne = new System.Windows.Forms.Label();
            this.cbMois = new System.Windows.Forms.ComboBox();
            this.lblMois = new System.Windows.Forms.Label();
            this.AbonneParMoisEtTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.AboonementParAnneeEtType.SuspendLayout();
            this.AbonnementParMoisEtType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbonneParAnneeEtTypeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbonneParMoisEtTypeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AboonementParAnneeEtType);
            this.tabControl1.Controls.Add(this.AbonnementParMoisEtType);
            this.tabControl1.Controls.Add(this.PartiesParAnneeEtTerrain);
            this.tabControl1.Controls.Add(this.PartiesParMoisEtTerrain);
            this.tabControl1.Controls.Add(this.DepensesParAnneeEtABonnement);
            this.tabControl1.Controls.Add(this.DepensesParMoisEtAbonnement);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(823, 449);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // AboonementParAnneeEtType
            // 
            this.AboonementParAnneeEtType.Controls.Add(this.AbonneParAnneeEtTypeDataGridView);
            this.AboonementParAnneeEtType.Controls.Add(this.nudAnnee);
            this.AboonementParAnneeEtType.Controls.Add(this.cbTypeAbonnee);
            this.AboonementParAnneeEtType.Controls.Add(this.lblAnnee);
            this.AboonementParAnneeEtType.Controls.Add(this.lblTypeAbonnement);
            this.AboonementParAnneeEtType.Controls.Add(this.lblTitreAbonneParAnneeEtType);
            this.AboonementParAnneeEtType.Location = new System.Drawing.Point(4, 22);
            this.AboonementParAnneeEtType.Name = "AboonementParAnneeEtType";
            this.AboonementParAnneeEtType.Padding = new System.Windows.Forms.Padding(3);
            this.AboonementParAnneeEtType.Size = new System.Drawing.Size(815, 423);
            this.AboonementParAnneeEtType.TabIndex = 0;
            this.AboonementParAnneeEtType.Text = "Abonnements par année et par type d\'abonnement";
            this.AboonementParAnneeEtType.UseVisualStyleBackColor = true;
            // 
            // AbonnementParMoisEtType
            // 
            this.AbonnementParMoisEtType.Controls.Add(this.AbonneParMoisEtTypeDataGridView);
            this.AbonnementParMoisEtType.Controls.Add(this.cbMois);
            this.AbonnementParMoisEtType.Controls.Add(this.lblMois);
            this.AbonnementParMoisEtType.Controls.Add(this.cbTypeAbonne);
            this.AbonnementParMoisEtType.Controls.Add(this.lblTypeAbonne);
            this.AbonnementParMoisEtType.Controls.Add(this.lblTitreAbonneParMoisEtType);
            this.AbonnementParMoisEtType.Location = new System.Drawing.Point(4, 22);
            this.AbonnementParMoisEtType.Name = "AbonnementParMoisEtType";
            this.AbonnementParMoisEtType.Padding = new System.Windows.Forms.Padding(3);
            this.AbonnementParMoisEtType.Size = new System.Drawing.Size(815, 423);
            this.AbonnementParMoisEtType.TabIndex = 1;
            this.AbonnementParMoisEtType.Text = "Abonnements par mois de l’année courante et par type d’abonnement";
            this.AbonnementParMoisEtType.UseVisualStyleBackColor = true;
            // 
            // PartiesParAnneeEtTerrain
            // 
            this.PartiesParAnneeEtTerrain.Location = new System.Drawing.Point(4, 22);
            this.PartiesParAnneeEtTerrain.Name = "PartiesParAnneeEtTerrain";
            this.PartiesParAnneeEtTerrain.Padding = new System.Windows.Forms.Padding(3);
            this.PartiesParAnneeEtTerrain.Size = new System.Drawing.Size(1161, 423);
            this.PartiesParAnneeEtTerrain.TabIndex = 2;
            this.PartiesParAnneeEtTerrain.Text = "Parties jouées par année et par terrain";
            this.PartiesParAnneeEtTerrain.UseVisualStyleBackColor = true;
            // 
            // PartiesParMoisEtTerrain
            // 
            this.PartiesParMoisEtTerrain.Location = new System.Drawing.Point(4, 22);
            this.PartiesParMoisEtTerrain.Name = "PartiesParMoisEtTerrain";
            this.PartiesParMoisEtTerrain.Size = new System.Drawing.Size(1161, 423);
            this.PartiesParMoisEtTerrain.TabIndex = 3;
            this.PartiesParMoisEtTerrain.Text = "Parties jouées par mois de l’année courante et par terrain";
            this.PartiesParMoisEtTerrain.UseVisualStyleBackColor = true;
            // 
            // DepensesParAnneeEtABonnement
            // 
            this.DepensesParAnneeEtABonnement.Location = new System.Drawing.Point(4, 22);
            this.DepensesParAnneeEtABonnement.Name = "DepensesParAnneeEtABonnement";
            this.DepensesParAnneeEtABonnement.Size = new System.Drawing.Size(1161, 423);
            this.DepensesParAnneeEtABonnement.TabIndex = 4;
            this.DepensesParAnneeEtABonnement.Text = "Dépenses par année et par abonnement";
            this.DepensesParAnneeEtABonnement.UseVisualStyleBackColor = true;
            // 
            // DepensesParMoisEtAbonnement
            // 
            this.DepensesParMoisEtAbonnement.Location = new System.Drawing.Point(4, 22);
            this.DepensesParMoisEtAbonnement.Name = "DepensesParMoisEtAbonnement";
            this.DepensesParMoisEtAbonnement.Size = new System.Drawing.Size(1161, 423);
            this.DepensesParMoisEtAbonnement.TabIndex = 5;
            this.DepensesParMoisEtAbonnement.Text = "Dépenses par mois de l’année courante et par abonnement";
            this.DepensesParMoisEtAbonnement.UseVisualStyleBackColor = true;
            // 
            // lblTitreAbonneParAnneeEtType
            // 
            this.lblTitreAbonneParAnneeEtType.AutoSize = true;
            this.lblTitreAbonneParAnneeEtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreAbonneParAnneeEtType.Location = new System.Drawing.Point(44, 3);
            this.lblTitreAbonneParAnneeEtType.Name = "lblTitreAbonneParAnneeEtType";
            this.lblTitreAbonneParAnneeEtType.Size = new System.Drawing.Size(714, 33);
            this.lblTitreAbonneParAnneeEtType.TabIndex = 0;
            this.lblTitreAbonneParAnneeEtType.Text = "Abonnements par année et par type d’abonnement";
            // 
            // lblTypeAbonnement
            // 
            this.lblTypeAbonnement.AutoSize = true;
            this.lblTypeAbonnement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeAbonnement.Location = new System.Drawing.Point(9, 56);
            this.lblTypeAbonnement.Name = "lblTypeAbonnement";
            this.lblTypeAbonnement.Size = new System.Drawing.Size(171, 20);
            this.lblTypeAbonnement.TabIndex = 1;
            this.lblTypeAbonnement.Text = "Type d\'abonnement:";
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnee.Location = new System.Drawing.Point(399, 56);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(66, 20);
            this.lblAnnee.TabIndex = 2;
            this.lblAnnee.Text = "Année:";
            // 
            // cbTypeAbonnee
            // 
            this.cbTypeAbonnee.FormattingEnabled = true;
            this.cbTypeAbonnee.Location = new System.Drawing.Point(187, 54);
            this.cbTypeAbonnee.Name = "cbTypeAbonnee";
            this.cbTypeAbonnee.Size = new System.Drawing.Size(121, 21);
            this.cbTypeAbonnee.TabIndex = 3;
            this.cbTypeAbonnee.SelectedValueChanged += new System.EventHandler(this.cbTypeAbonnee_SelectedValueChanged);
            // 
            // nudAnnee
            // 
            this.nudAnnee.Location = new System.Drawing.Point(472, 55);
            this.nudAnnee.Maximum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudAnnee.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudAnnee.Name = "nudAnnee";
            this.nudAnnee.Size = new System.Drawing.Size(120, 20);
            this.nudAnnee.TabIndex = 4;
            this.nudAnnee.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudAnnee.ValueChanged += new System.EventHandler(this.nudAnnee_ValueChanged);
            // 
            // AbonneParAnneeEtTypeDataGridView
            // 
            this.AbonneParAnneeEtTypeDataGridView.AllowUserToAddRows = false;
            this.AbonneParAnneeEtTypeDataGridView.AllowUserToDeleteRows = false;
            this.AbonneParAnneeEtTypeDataGridView.AllowUserToResizeColumns = false;
            this.AbonneParAnneeEtTypeDataGridView.AllowUserToResizeRows = false;
            this.AbonneParAnneeEtTypeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AbonneParAnneeEtTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AbonneParAnneeEtTypeDataGridView.Location = new System.Drawing.Point(9, 80);
            this.AbonneParAnneeEtTypeDataGridView.Name = "AbonneParAnneeEtTypeDataGridView";
            this.AbonneParAnneeEtTypeDataGridView.ReadOnly = true;
            this.AbonneParAnneeEtTypeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AbonneParAnneeEtTypeDataGridView.Size = new System.Drawing.Size(800, 340);
            this.AbonneParAnneeEtTypeDataGridView.TabIndex = 5;
            // 
            // lblTitreAbonneParMoisEtType
            // 
            this.lblTitreAbonneParMoisEtType.AutoSize = true;
            this.lblTitreAbonneParMoisEtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreAbonneParMoisEtType.Location = new System.Drawing.Point(60, 3);
            this.lblTitreAbonneParMoisEtType.Name = "lblTitreAbonneParMoisEtType";
            this.lblTitreAbonneParMoisEtType.Size = new System.Drawing.Size(696, 33);
            this.lblTitreAbonneParMoisEtType.TabIndex = 1;
            this.lblTitreAbonneParMoisEtType.Text = "Abonnements par mois et par type d’abonnement";
            // 
            // cbTypeAbonne
            // 
            this.cbTypeAbonne.FormattingEnabled = true;
            this.cbTypeAbonne.Location = new System.Drawing.Point(182, 56);
            this.cbTypeAbonne.Name = "cbTypeAbonne";
            this.cbTypeAbonne.Size = new System.Drawing.Size(121, 21);
            this.cbTypeAbonne.TabIndex = 5;
            this.cbTypeAbonne.SelectedValueChanged += new System.EventHandler(this.cbTypeAbonne_SelectedValueChanged);
            // 
            // lblTypeAbonne
            // 
            this.lblTypeAbonne.AutoSize = true;
            this.lblTypeAbonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeAbonne.Location = new System.Drawing.Point(4, 58);
            this.lblTypeAbonne.Name = "lblTypeAbonne";
            this.lblTypeAbonne.Size = new System.Drawing.Size(171, 20);
            this.lblTypeAbonne.TabIndex = 4;
            this.lblTypeAbonne.Text = "Type d\'abonnement:";
            // 
            // cbMois
            // 
            this.cbMois.FormattingEnabled = true;
            this.cbMois.Location = new System.Drawing.Point(588, 56);
            this.cbMois.Name = "cbMois";
            this.cbMois.Size = new System.Drawing.Size(121, 21);
            this.cbMois.TabIndex = 7;
            this.cbMois.SelectedValueChanged += new System.EventHandler(this.cbMois_SelectedValueChanged);
            // 
            // lblMois
            // 
            this.lblMois.AutoSize = true;
            this.lblMois.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMois.Location = new System.Drawing.Point(410, 58);
            this.lblMois.Name = "lblMois";
            this.lblMois.Size = new System.Drawing.Size(171, 20);
            this.lblMois.TabIndex = 6;
            this.lblMois.Text = "Type d\'abonnement:";
            // 
            // AbonneParMoisEtTypeDataGridView
            // 
            this.AbonneParMoisEtTypeDataGridView.AllowUserToAddRows = false;
            this.AbonneParMoisEtTypeDataGridView.AllowUserToDeleteRows = false;
            this.AbonneParMoisEtTypeDataGridView.AllowUserToResizeColumns = false;
            this.AbonneParMoisEtTypeDataGridView.AllowUserToResizeRows = false;
            this.AbonneParMoisEtTypeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AbonneParMoisEtTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AbonneParMoisEtTypeDataGridView.Location = new System.Drawing.Point(4, 82);
            this.AbonneParMoisEtTypeDataGridView.Name = "AbonneParMoisEtTypeDataGridView";
            this.AbonneParMoisEtTypeDataGridView.ReadOnly = true;
            this.AbonneParMoisEtTypeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AbonneParMoisEtTypeDataGridView.Size = new System.Drawing.Size(808, 341);
            this.AbonneParMoisEtTypeDataGridView.TabIndex = 8;
            // 
            // frmStatisque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmStatisque";
            this.Text = "frmStatisque";
            this.tabControl1.ResumeLayout(false);
            this.AboonementParAnneeEtType.ResumeLayout(false);
            this.AboonementParAnneeEtType.PerformLayout();
            this.AbonnementParMoisEtType.ResumeLayout(false);
            this.AbonnementParMoisEtType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbonneParAnneeEtTypeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbonneParMoisEtTypeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AboonementParAnneeEtType;
        private System.Windows.Forms.TabPage AbonnementParMoisEtType;
        private System.Windows.Forms.TabPage PartiesParAnneeEtTerrain;
        private System.Windows.Forms.TabPage PartiesParMoisEtTerrain;
        private System.Windows.Forms.TabPage DepensesParAnneeEtABonnement;
        private System.Windows.Forms.TabPage DepensesParMoisEtAbonnement;
        private System.Windows.Forms.NumericUpDown nudAnnee;
        private System.Windows.Forms.ComboBox cbTypeAbonnee;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.Label lblTypeAbonnement;
        private System.Windows.Forms.Label lblTitreAbonneParAnneeEtType;
        private System.Windows.Forms.DataGridView AbonneParAnneeEtTypeDataGridView;
        private System.Windows.Forms.Label lblTitreAbonneParMoisEtType;
        private System.Windows.Forms.DataGridView AbonneParMoisEtTypeDataGridView;
        private System.Windows.Forms.ComboBox cbMois;
        private System.Windows.Forms.Label lblMois;
        private System.Windows.Forms.ComboBox cbTypeAbonne;
        private System.Windows.Forms.Label lblTypeAbonne;
    }
}