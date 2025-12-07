namespace ProjetII_B56
{
    partial class frmRapports
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
            this.DepenseEmploye = new System.Windows.Forms.TabPage();
            this.lblTitreEmploye = new System.Windows.Forms.Label();
            this.depenseParEmpDataGridView = new System.Windows.Forms.DataGridView();
            this.lblEmploye = new System.Windows.Forms.Label();
            this.DepenseAbonnement = new System.Windows.Forms.TabPage();
            this.DepenseAnnee = new System.Windows.Forms.TabPage();
            this.PartiesParTerrain = new System.Windows.Forms.TabPage();
            this.PartiesParAbonnement = new System.Windows.Forms.TabPage();
            this.PartiesParAnnee = new System.Windows.Forms.TabPage();
            this.cbEmploye = new System.Windows.Forms.ComboBox();
            this.lbTitreAbonne = new System.Windows.Forms.Label();
            this.lblAbonne = new System.Windows.Forms.Label();
            this.cbAbonne = new System.Windows.Forms.ComboBox();
            this.depenseParAbonneDataGridView = new System.Windows.Forms.DataGridView();
            this.depenseParAnneeDataGridView = new System.Windows.Forms.DataGridView();
            this.lblTitreAnne = new System.Windows.Forms.Label();
            this.lblAnne = new System.Windows.Forms.Label();
            this.nudAnnee = new System.Windows.Forms.NumericUpDown();
            this.partiesParTerrainDataGridView = new System.Windows.Forms.DataGridView();
            this.lblTitreTerrain = new System.Windows.Forms.Label();
            this.lblTerrain = new System.Windows.Forms.Label();
            this.cbTerrain = new System.Windows.Forms.ComboBox();
            this.partiesParAbonneDataGridView = new System.Windows.Forms.DataGridView();
            this.lblTitrePartieAbonne = new System.Windows.Forms.Label();
            this.lblPartieAbonne = new System.Windows.Forms.Label();
            this.cbPartieAbonne = new System.Windows.Forms.ComboBox();
            this.nudPartiesAnnee = new System.Windows.Forms.NumericUpDown();
            this.partiesParAnneeDataGridView = new System.Windows.Forms.DataGridView();
            this.lblPartiesAnne = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRapports = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.DepenseEmploye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depenseParEmpDataGridView)).BeginInit();
            this.DepenseAbonnement.SuspendLayout();
            this.DepenseAnnee.SuspendLayout();
            this.PartiesParTerrain.SuspendLayout();
            this.PartiesParAbonnement.SuspendLayout();
            this.PartiesParAnnee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depenseParAbonneDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depenseParAnneeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesParTerrainDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesParAbonneDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPartiesAnnee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesParAnneeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DepenseEmploye);
            this.tabControl1.Controls.Add(this.DepenseAbonnement);
            this.tabControl1.Controls.Add(this.DepenseAnnee);
            this.tabControl1.Controls.Add(this.PartiesParTerrain);
            this.tabControl1.Controls.Add(this.PartiesParAbonnement);
            this.tabControl1.Controls.Add(this.PartiesParAnnee);
            this.tabControl1.Location = new System.Drawing.Point(2, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // DepenseEmploye
            // 
            this.DepenseEmploye.AutoScroll = true;
            this.DepenseEmploye.Controls.Add(this.lblTitreEmploye);
            this.DepenseEmploye.Controls.Add(this.depenseParEmpDataGridView);
            this.DepenseEmploye.Controls.Add(this.lblEmploye);
            this.DepenseEmploye.Controls.Add(this.cbEmploye);
            this.DepenseEmploye.Location = new System.Drawing.Point(4, 22);
            this.DepenseEmploye.Name = "DepenseEmploye";
            this.DepenseEmploye.Padding = new System.Windows.Forms.Padding(3);
            this.DepenseEmploye.Size = new System.Drawing.Size(781, 423);
            this.DepenseEmploye.TabIndex = 0;
            this.DepenseEmploye.Text = "Dépenses par employé";
            this.DepenseEmploye.UseVisualStyleBackColor = true;
            // 
            // lblTitreEmploye
            // 
            this.lblTitreEmploye.AutoSize = true;
            this.lblTitreEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreEmploye.Location = new System.Drawing.Point(188, 0);
            this.lblTitreEmploye.Name = "lblTitreEmploye";
            this.lblTitreEmploye.Size = new System.Drawing.Size(363, 37);
            this.lblTitreEmploye.TabIndex = 3;
            this.lblTitreEmploye.Text = "Dépenses par employé";
            // 
            // depenseParEmpDataGridView
            // 
            this.depenseParEmpDataGridView.AllowUserToAddRows = false;
            this.depenseParEmpDataGridView.AllowUserToDeleteRows = false;
            this.depenseParEmpDataGridView.AllowUserToResizeColumns = false;
            this.depenseParEmpDataGridView.AllowUserToResizeRows = false;
            this.depenseParEmpDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.depenseParEmpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depenseParEmpDataGridView.Location = new System.Drawing.Point(6, 83);
            this.depenseParEmpDataGridView.Name = "depenseParEmpDataGridView";
            this.depenseParEmpDataGridView.ReadOnly = true;
            this.depenseParEmpDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.depenseParEmpDataGridView.Size = new System.Drawing.Size(769, 333);
            this.depenseParEmpDataGridView.TabIndex = 2;
            // 
            // lblEmploye
            // 
            this.lblEmploye.AutoSize = true;
            this.lblEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmploye.Location = new System.Drawing.Point(7, 51);
            this.lblEmploye.Name = "lblEmploye";
            this.lblEmploye.Size = new System.Drawing.Size(104, 24);
            this.lblEmploye.TabIndex = 1;
            this.lblEmploye.Text = "Employé: ";
            // 
            // DepenseAbonnement
            // 
            this.DepenseAbonnement.Controls.Add(this.depenseParAbonneDataGridView);
            this.DepenseAbonnement.Controls.Add(this.lbTitreAbonne);
            this.DepenseAbonnement.Controls.Add(this.lblAbonne);
            this.DepenseAbonnement.Controls.Add(this.cbAbonne);
            this.DepenseAbonnement.Location = new System.Drawing.Point(4, 22);
            this.DepenseAbonnement.Name = "DepenseAbonnement";
            this.DepenseAbonnement.Padding = new System.Windows.Forms.Padding(3);
            this.DepenseAbonnement.Size = new System.Drawing.Size(782, 422);
            this.DepenseAbonnement.TabIndex = 1;
            this.DepenseAbonnement.Text = "Dépenses par abonnement";
            this.DepenseAbonnement.UseVisualStyleBackColor = true;
            // 
            // DepenseAnnee
            // 
            this.DepenseAnnee.Controls.Add(this.nudAnnee);
            this.DepenseAnnee.Controls.Add(this.depenseParAnneeDataGridView);
            this.DepenseAnnee.Controls.Add(this.lblTitreAnne);
            this.DepenseAnnee.Controls.Add(this.lblAnne);
            this.DepenseAnnee.Location = new System.Drawing.Point(4, 22);
            this.DepenseAnnee.Name = "DepenseAnnee";
            this.DepenseAnnee.Padding = new System.Windows.Forms.Padding(3);
            this.DepenseAnnee.Size = new System.Drawing.Size(782, 422);
            this.DepenseAnnee.TabIndex = 2;
            this.DepenseAnnee.Text = "Dépenses par année";
            this.DepenseAnnee.UseVisualStyleBackColor = true;
            // 
            // PartiesParTerrain
            // 
            this.PartiesParTerrain.Controls.Add(this.partiesParTerrainDataGridView);
            this.PartiesParTerrain.Controls.Add(this.lblTitreTerrain);
            this.PartiesParTerrain.Controls.Add(this.lblTerrain);
            this.PartiesParTerrain.Controls.Add(this.cbTerrain);
            this.PartiesParTerrain.Location = new System.Drawing.Point(4, 22);
            this.PartiesParTerrain.Name = "PartiesParTerrain";
            this.PartiesParTerrain.Size = new System.Drawing.Size(782, 422);
            this.PartiesParTerrain.TabIndex = 3;
            this.PartiesParTerrain.Text = "Parties jouées par terrain";
            this.PartiesParTerrain.UseVisualStyleBackColor = true;
            // 
            // PartiesParAbonnement
            // 
            this.PartiesParAbonnement.Controls.Add(this.partiesParAbonneDataGridView);
            this.PartiesParAbonnement.Controls.Add(this.lblTitrePartieAbonne);
            this.PartiesParAbonnement.Controls.Add(this.lblPartieAbonne);
            this.PartiesParAbonnement.Controls.Add(this.cbPartieAbonne);
            this.PartiesParAbonnement.Location = new System.Drawing.Point(4, 22);
            this.PartiesParAbonnement.Name = "PartiesParAbonnement";
            this.PartiesParAbonnement.Size = new System.Drawing.Size(782, 422);
            this.PartiesParAbonnement.TabIndex = 4;
            this.PartiesParAbonnement.Text = "Parties jouées par abonnement";
            this.PartiesParAbonnement.UseVisualStyleBackColor = true;
            // 
            // PartiesParAnnee
            // 
            this.PartiesParAnnee.Controls.Add(this.nudPartiesAnnee);
            this.PartiesParAnnee.Controls.Add(this.partiesParAnneeDataGridView);
            this.PartiesParAnnee.Controls.Add(this.lblPartiesAnne);
            this.PartiesParAnnee.Controls.Add(this.label2);
            this.PartiesParAnnee.Location = new System.Drawing.Point(4, 22);
            this.PartiesParAnnee.Name = "PartiesParAnnee";
            this.PartiesParAnnee.Size = new System.Drawing.Size(782, 422);
            this.PartiesParAnnee.TabIndex = 5;
            this.PartiesParAnnee.Text = "Parties jouées par année";
            this.PartiesParAnnee.UseVisualStyleBackColor = true;
            // 
            // cbEmploye
            // 
            this.cbEmploye.FormattingEnabled = true;
            this.cbEmploye.Location = new System.Drawing.Point(117, 56);
            this.cbEmploye.Name = "cbEmploye";
            this.cbEmploye.Size = new System.Drawing.Size(135, 21);
            this.cbEmploye.TabIndex = 0;
            this.cbEmploye.SelectedValueChanged += new System.EventHandler(this.cbEmploye_SelectedValueChanged);
            // 
            // lbTitreAbonne
            // 
            this.lbTitreAbonne.AutoSize = true;
            this.lbTitreAbonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitreAbonne.Location = new System.Drawing.Point(187, 0);
            this.lbTitreAbonne.Name = "lbTitreAbonne";
            this.lbTitreAbonne.Size = new System.Drawing.Size(425, 37);
            this.lbTitreAbonne.TabIndex = 6;
            this.lbTitreAbonne.Text = "Dépenses par abonnement";
            // 
            // lblAbonne
            // 
            this.lblAbonne.AutoSize = true;
            this.lblAbonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbonne.Location = new System.Drawing.Point(6, 51);
            this.lblAbonne.Name = "lblAbonne";
            this.lblAbonne.Size = new System.Drawing.Size(90, 24);
            this.lblAbonne.TabIndex = 5;
            this.lblAbonne.Text = "Abonné:";
            // 
            // cbAbonne
            // 
            this.cbAbonne.FormattingEnabled = true;
            this.cbAbonne.Location = new System.Drawing.Point(116, 56);
            this.cbAbonne.Name = "cbAbonne";
            this.cbAbonne.Size = new System.Drawing.Size(135, 21);
            this.cbAbonne.TabIndex = 4;
            this.cbAbonne.SelectedValueChanged += new System.EventHandler(this.cbAbonne_SelectedValueChanged);
            // 
            // depenseParAbonneDataGridView
            // 
            this.depenseParAbonneDataGridView.AllowUserToAddRows = false;
            this.depenseParAbonneDataGridView.AllowUserToDeleteRows = false;
            this.depenseParAbonneDataGridView.AllowUserToResizeColumns = false;
            this.depenseParAbonneDataGridView.AllowUserToResizeRows = false;
            this.depenseParAbonneDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.depenseParAbonneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depenseParAbonneDataGridView.Location = new System.Drawing.Point(6, 83);
            this.depenseParAbonneDataGridView.Name = "depenseParAbonneDataGridView";
            this.depenseParAbonneDataGridView.ReadOnly = true;
            this.depenseParAbonneDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.depenseParAbonneDataGridView.Size = new System.Drawing.Size(769, 333);
            this.depenseParAbonneDataGridView.TabIndex = 7;
            // 
            // depenseParAnneeDataGridView
            // 
            this.depenseParAnneeDataGridView.AllowUserToAddRows = false;
            this.depenseParAnneeDataGridView.AllowUserToDeleteRows = false;
            this.depenseParAnneeDataGridView.AllowUserToResizeColumns = false;
            this.depenseParAnneeDataGridView.AllowUserToResizeRows = false;
            this.depenseParAnneeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.depenseParAnneeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depenseParAnneeDataGridView.Location = new System.Drawing.Point(6, 83);
            this.depenseParAnneeDataGridView.Name = "depenseParAnneeDataGridView";
            this.depenseParAnneeDataGridView.ReadOnly = true;
            this.depenseParAnneeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.depenseParAnneeDataGridView.Size = new System.Drawing.Size(769, 333);
            this.depenseParAnneeDataGridView.TabIndex = 11;
            // 
            // lblTitreAnne
            // 
            this.lblTitreAnne.AutoSize = true;
            this.lblTitreAnne.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreAnne.Location = new System.Drawing.Point(187, 0);
            this.lblTitreAnne.Name = "lblTitreAnne";
            this.lblTitreAnne.Size = new System.Drawing.Size(330, 37);
            this.lblTitreAnne.TabIndex = 10;
            this.lblTitreAnne.Text = "Dépenses par année";
            // 
            // lblAnne
            // 
            this.lblAnne.AutoSize = true;
            this.lblAnne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnne.Location = new System.Drawing.Point(6, 51);
            this.lblAnne.Name = "lblAnne";
            this.lblAnne.Size = new System.Drawing.Size(78, 24);
            this.lblAnne.TabIndex = 9;
            this.lblAnne.Text = "Année:";
            // 
            // nudAnnee
            // 
            this.nudAnnee.Location = new System.Drawing.Point(117, 57);
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
            this.nudAnnee.TabIndex = 12;
            this.nudAnnee.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudAnnee.ValueChanged += new System.EventHandler(this.nudAnnee_ValueChanged);
            // 
            // partiesParTerrainDataGridView
            // 
            this.partiesParTerrainDataGridView.AllowUserToAddRows = false;
            this.partiesParTerrainDataGridView.AllowUserToDeleteRows = false;
            this.partiesParTerrainDataGridView.AllowUserToResizeColumns = false;
            this.partiesParTerrainDataGridView.AllowUserToResizeRows = false;
            this.partiesParTerrainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partiesParTerrainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partiesParTerrainDataGridView.Location = new System.Drawing.Point(6, 86);
            this.partiesParTerrainDataGridView.Name = "partiesParTerrainDataGridView";
            this.partiesParTerrainDataGridView.ReadOnly = true;
            this.partiesParTerrainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partiesParTerrainDataGridView.Size = new System.Drawing.Size(769, 333);
            this.partiesParTerrainDataGridView.TabIndex = 11;
            // 
            // lblTitreTerrain
            // 
            this.lblTitreTerrain.AutoSize = true;
            this.lblTitreTerrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreTerrain.Location = new System.Drawing.Point(187, 3);
            this.lblTitreTerrain.Name = "lblTitreTerrain";
            this.lblTitreTerrain.Size = new System.Drawing.Size(400, 37);
            this.lblTitreTerrain.TabIndex = 10;
            this.lblTitreTerrain.Text = "Parties jouées par terrain";
            // 
            // lblTerrain
            // 
            this.lblTerrain.AutoSize = true;
            this.lblTerrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerrain.Location = new System.Drawing.Point(6, 54);
            this.lblTerrain.Name = "lblTerrain";
            this.lblTerrain.Size = new System.Drawing.Size(83, 24);
            this.lblTerrain.TabIndex = 9;
            this.lblTerrain.Text = "Terrain:";
            // 
            // cbTerrain
            // 
            this.cbTerrain.FormattingEnabled = true;
            this.cbTerrain.Location = new System.Drawing.Point(116, 59);
            this.cbTerrain.Name = "cbTerrain";
            this.cbTerrain.Size = new System.Drawing.Size(135, 21);
            this.cbTerrain.TabIndex = 8;
            this.cbTerrain.SelectedValueChanged += new System.EventHandler(this.cbTerrain_SelectedValueChanged);
            // 
            // partiesParAbonneDataGridView
            // 
            this.partiesParAbonneDataGridView.AllowUserToAddRows = false;
            this.partiesParAbonneDataGridView.AllowUserToDeleteRows = false;
            this.partiesParAbonneDataGridView.AllowUserToResizeColumns = false;
            this.partiesParAbonneDataGridView.AllowUserToResizeRows = false;
            this.partiesParAbonneDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partiesParAbonneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partiesParAbonneDataGridView.Location = new System.Drawing.Point(6, 86);
            this.partiesParAbonneDataGridView.Name = "partiesParAbonneDataGridView";
            this.partiesParAbonneDataGridView.ReadOnly = true;
            this.partiesParAbonneDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partiesParAbonneDataGridView.Size = new System.Drawing.Size(769, 333);
            this.partiesParAbonneDataGridView.TabIndex = 15;
            // 
            // lblTitrePartieAbonne
            // 
            this.lblTitrePartieAbonne.AutoSize = true;
            this.lblTitrePartieAbonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitrePartieAbonne.Location = new System.Drawing.Point(187, 3);
            this.lblTitrePartieAbonne.Name = "lblTitrePartieAbonne";
            this.lblTitrePartieAbonne.Size = new System.Drawing.Size(415, 37);
            this.lblTitrePartieAbonne.TabIndex = 14;
            this.lblTitrePartieAbonne.Text = "Parties jouées par abonné";
            // 
            // lblPartieAbonne
            // 
            this.lblPartieAbonne.AutoSize = true;
            this.lblPartieAbonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartieAbonne.Location = new System.Drawing.Point(6, 54);
            this.lblPartieAbonne.Name = "lblPartieAbonne";
            this.lblPartieAbonne.Size = new System.Drawing.Size(90, 24);
            this.lblPartieAbonne.TabIndex = 13;
            this.lblPartieAbonne.Text = "Abonné:";
            // 
            // cbPartieAbonne
            // 
            this.cbPartieAbonne.FormattingEnabled = true;
            this.cbPartieAbonne.Location = new System.Drawing.Point(116, 59);
            this.cbPartieAbonne.Name = "cbPartieAbonne";
            this.cbPartieAbonne.Size = new System.Drawing.Size(135, 21);
            this.cbPartieAbonne.TabIndex = 12;
            this.cbPartieAbonne.SelectedValueChanged += new System.EventHandler(this.cbPartieAbonne_SelectedValueChanged);
            // 
            // nudPartiesAnnee
            // 
            this.nudPartiesAnnee.Location = new System.Drawing.Point(117, 60);
            this.nudPartiesAnnee.Maximum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudPartiesAnnee.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudPartiesAnnee.Name = "nudPartiesAnnee";
            this.nudPartiesAnnee.Size = new System.Drawing.Size(120, 20);
            this.nudPartiesAnnee.TabIndex = 16;
            this.nudPartiesAnnee.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudPartiesAnnee.ValueChanged += new System.EventHandler(this.nudPartiesAnnee_ValueChanged);
            // 
            // partiesParAnneeDataGridView
            // 
            this.partiesParAnneeDataGridView.AllowUserToAddRows = false;
            this.partiesParAnneeDataGridView.AllowUserToDeleteRows = false;
            this.partiesParAnneeDataGridView.AllowUserToResizeColumns = false;
            this.partiesParAnneeDataGridView.AllowUserToResizeRows = false;
            this.partiesParAnneeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partiesParAnneeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partiesParAnneeDataGridView.Location = new System.Drawing.Point(6, 86);
            this.partiesParAnneeDataGridView.Name = "partiesParAnneeDataGridView";
            this.partiesParAnneeDataGridView.ReadOnly = true;
            this.partiesParAnneeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partiesParAnneeDataGridView.Size = new System.Drawing.Size(769, 333);
            this.partiesParAnneeDataGridView.TabIndex = 15;
            // 
            // lblPartiesAnne
            // 
            this.lblPartiesAnne.AutoSize = true;
            this.lblPartiesAnne.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartiesAnne.Location = new System.Drawing.Point(187, 3);
            this.lblPartiesAnne.Name = "lblPartiesAnne";
            this.lblPartiesAnne.Size = new System.Drawing.Size(286, 37);
            this.lblPartiesAnne.TabIndex = 14;
            this.lblPartiesAnne.Text = "Parties par année";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Année:";
            // 
            // lblRapports
            // 
            this.lblRapports.AutoSize = true;
            this.lblRapports.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRapports.Location = new System.Drawing.Point(301, 9);
            this.lblRapports.Name = "lblRapports";
            this.lblRapports.Size = new System.Drawing.Size(155, 37);
            this.lblRapports.TabIndex = 4;
            this.lblRapports.Text = "Rapports";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(686, 22);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 5;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // frmRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 521);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblRapports);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmRapports";
            this.Text = "Rapports";
            this.tabControl1.ResumeLayout(false);
            this.DepenseEmploye.ResumeLayout(false);
            this.DepenseEmploye.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depenseParEmpDataGridView)).EndInit();
            this.DepenseAbonnement.ResumeLayout(false);
            this.DepenseAbonnement.PerformLayout();
            this.DepenseAnnee.ResumeLayout(false);
            this.DepenseAnnee.PerformLayout();
            this.PartiesParTerrain.ResumeLayout(false);
            this.PartiesParTerrain.PerformLayout();
            this.PartiesParAbonnement.ResumeLayout(false);
            this.PartiesParAbonnement.PerformLayout();
            this.PartiesParAnnee.ResumeLayout(false);
            this.PartiesParAnnee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depenseParAbonneDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depenseParAnneeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesParTerrainDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesParAbonneDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPartiesAnnee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesParAnneeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DepenseEmploye;
        private System.Windows.Forms.TabPage DepenseAbonnement;
        private System.Windows.Forms.TabPage DepenseAnnee;
        private System.Windows.Forms.TabPage PartiesParTerrain;
        private System.Windows.Forms.TabPage PartiesParAbonnement;
        private System.Windows.Forms.TabPage PartiesParAnnee;
        private System.Windows.Forms.Label lblEmploye;
        private System.Windows.Forms.DataGridView depenseParEmpDataGridView;
        private System.Windows.Forms.Label lblTitreEmploye;
        private System.Windows.Forms.ComboBox cbEmploye;
        private System.Windows.Forms.Label lbTitreAbonne;
        private System.Windows.Forms.Label lblAbonne;
        private System.Windows.Forms.ComboBox cbAbonne;
        private System.Windows.Forms.DataGridView depenseParAbonneDataGridView;
        private System.Windows.Forms.NumericUpDown nudAnnee;
        private System.Windows.Forms.DataGridView depenseParAnneeDataGridView;
        private System.Windows.Forms.Label lblTitreAnne;
        private System.Windows.Forms.Label lblAnne;
        private System.Windows.Forms.DataGridView partiesParTerrainDataGridView;
        private System.Windows.Forms.Label lblTitreTerrain;
        private System.Windows.Forms.Label lblTerrain;
        private System.Windows.Forms.ComboBox cbTerrain;
        private System.Windows.Forms.DataGridView partiesParAbonneDataGridView;
        private System.Windows.Forms.Label lblTitrePartieAbonne;
        private System.Windows.Forms.Label lblPartieAbonne;
        private System.Windows.Forms.ComboBox cbPartieAbonne;
        private System.Windows.Forms.NumericUpDown nudPartiesAnnee;
        private System.Windows.Forms.DataGridView partiesParAnneeDataGridView;
        private System.Windows.Forms.Label lblPartiesAnne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRapports;
        private System.Windows.Forms.Button btnRetour;
    }
}