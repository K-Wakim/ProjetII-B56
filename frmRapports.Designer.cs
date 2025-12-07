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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DepenseEmploye = new System.Windows.Forms.TabPage();
            this.lblEmploye = new System.Windows.Forms.Label();
            this.cbEmploye = new System.Windows.Forms.ComboBox();
            this.DepenseAbonnement = new System.Windows.Forms.TabPage();
            this.DepenseAnnee = new System.Windows.Forms.TabPage();
            this.PartiesParTerrain = new System.Windows.Forms.TabPage();
            this.PartiesParAbonnement = new System.Windows.Forms.TabPage();
            this.PartiesParAnnee = new System.Windows.Forms.TabPage();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employesTableAdapter1 = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.EmployesTableAdapter();
            this.servicesTableAdapter1 = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.ServicesTableAdapter();
            this.bDB56Pr211DataSet = new ProjetII_B56.BDB56Pr211DataSet();
            this.depenseParEmpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depenseParEmpTableAdapter = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.DepenseParEmpTableAdapter();
            this.tableAdapterManager = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.TableAdapterManager();
            this.depenseParEmpDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitre = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.DepenseEmploye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Pr211DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depenseParEmpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depenseParEmpDataGridView)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // DepenseEmploye
            // 
            this.DepenseEmploye.AutoScroll = true;
            this.DepenseEmploye.Controls.Add(this.lblTitre);
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
            // cbEmploye
            // 
            this.cbEmploye.FormattingEnabled = true;
            this.cbEmploye.Location = new System.Drawing.Point(117, 56);
            this.cbEmploye.Name = "cbEmploye";
            this.cbEmploye.Size = new System.Drawing.Size(135, 21);
            this.cbEmploye.TabIndex = 0;
            // 
            // DepenseAbonnement
            // 
            this.DepenseAbonnement.Location = new System.Drawing.Point(4, 22);
            this.DepenseAbonnement.Name = "DepenseAbonnement";
            this.DepenseAbonnement.Padding = new System.Windows.Forms.Padding(3);
            this.DepenseAbonnement.Size = new System.Drawing.Size(781, 423);
            this.DepenseAbonnement.TabIndex = 1;
            this.DepenseAbonnement.Text = "Dépenses par abonnement";
            this.DepenseAbonnement.UseVisualStyleBackColor = true;
            // 
            // DepenseAnnee
            // 
            this.DepenseAnnee.Location = new System.Drawing.Point(4, 22);
            this.DepenseAnnee.Name = "DepenseAnnee";
            this.DepenseAnnee.Padding = new System.Windows.Forms.Padding(3);
            this.DepenseAnnee.Size = new System.Drawing.Size(781, 423);
            this.DepenseAnnee.TabIndex = 2;
            this.DepenseAnnee.Text = "Dépenses par année";
            this.DepenseAnnee.UseVisualStyleBackColor = true;
            // 
            // PartiesParTerrain
            // 
            this.PartiesParTerrain.Location = new System.Drawing.Point(4, 22);
            this.PartiesParTerrain.Name = "PartiesParTerrain";
            this.PartiesParTerrain.Size = new System.Drawing.Size(781, 423);
            this.PartiesParTerrain.TabIndex = 3;
            this.PartiesParTerrain.Text = "Parties jouées par terrain";
            this.PartiesParTerrain.UseVisualStyleBackColor = true;
            // 
            // PartiesParAbonnement
            // 
            this.PartiesParAbonnement.Location = new System.Drawing.Point(4, 22);
            this.PartiesParAbonnement.Name = "PartiesParAbonnement";
            this.PartiesParAbonnement.Size = new System.Drawing.Size(781, 423);
            this.PartiesParAbonnement.TabIndex = 4;
            this.PartiesParAbonnement.Text = "Parties jouées par abonnement";
            this.PartiesParAbonnement.UseVisualStyleBackColor = true;
            // 
            // PartiesParAnnee
            // 
            this.PartiesParAnnee.Location = new System.Drawing.Point(4, 22);
            this.PartiesParAnnee.Name = "PartiesParAnnee";
            this.PartiesParAnnee.Size = new System.Drawing.Size(781, 423);
            this.PartiesParAnnee.TabIndex = 5;
            this.PartiesParAnnee.Text = "Parties jouées par année";
            this.PartiesParAnnee.UseVisualStyleBackColor = true;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataSource = typeof(ProjetII_B56.Services);
            // 
            // employesBindingSource
            // 
            this.employesBindingSource.DataSource = typeof(ProjetII_B56.Employes);
            // 
            // employesTableAdapter1
            // 
            this.employesTableAdapter1.ClearBeforeFill = true;
            // 
            // servicesTableAdapter1
            // 
            this.servicesTableAdapter1.ClearBeforeFill = true;
            // 
            // bDB56Pr211DataSet
            // 
            this.bDB56Pr211DataSet.DataSetName = "BDB56Pr211DataSet";
            this.bDB56Pr211DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depenseParEmpBindingSource
            // 
            this.depenseParEmpBindingSource.DataMember = "DepenseParEmp";
            this.depenseParEmpBindingSource.DataSource = this.bDB56Pr211DataSet;
            // 
            // depenseParEmpTableAdapter
            // 
            this.depenseParEmpTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbonnementsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DependantsTableAdapter = null;
            this.tableAdapterManager.DepensesTableAdapter = null;
            this.tableAdapterManager.EmployesTableAdapter = this.employesTableAdapter1;
            this.tableAdapterManager.PartiesJoueesTableAdapter = null;
            this.tableAdapterManager.PrixDepensesAbonnementsTableAdapter = null;
            this.tableAdapterManager.ProvincesTableAdapter = null;
            this.tableAdapterManager.ReabonnementsTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = this.servicesTableAdapter1;
            this.tableAdapterManager.TerrainsTableAdapter = null;
            this.tableAdapterManager.TypesAbonnementTableAdapter = null;
            this.tableAdapterManager.TypesEmployeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetII_B56.BDB56Pr211DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // depenseParEmpDataGridView
            // 
            this.depenseParEmpDataGridView.AllowUserToAddRows = false;
            this.depenseParEmpDataGridView.AllowUserToDeleteRows = false;
            this.depenseParEmpDataGridView.AllowUserToResizeColumns = false;
            this.depenseParEmpDataGridView.AllowUserToResizeRows = false;
            this.depenseParEmpDataGridView.AutoGenerateColumns = false;
            this.depenseParEmpDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.depenseParEmpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depenseParEmpDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn9});
            this.depenseParEmpDataGridView.DataSource = this.depenseParEmpBindingSource;
            this.depenseParEmpDataGridView.Location = new System.Drawing.Point(6, 83);
            this.depenseParEmpDataGridView.Name = "depenseParEmpDataGridView";
            this.depenseParEmpDataGridView.ReadOnly = true;
            this.depenseParEmpDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.depenseParEmpDataGridView.Size = new System.Drawing.Size(769, 333);
            this.depenseParEmpDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TypeService";
            this.dataGridViewTextBoxColumn3.HeaderText = "Type de service";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Montant";
            this.dataGridViewTextBoxColumn2.HeaderText = "Montant";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DateDepense";
            this.dataGridViewTextBoxColumn1.HeaderText = "Date de la dépense";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "NomComplet";
            this.dataGridViewTextBoxColumn9.HeaderText = "Nom de l\'abonné";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(204, 3);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(363, 37);
            this.lblTitre.TabIndex = 3;
            this.lblTitre.Text = "Dépenses par employé";
            // 
            // frmRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmRapports";
            this.Text = "Rapports";
            this.tabControl1.ResumeLayout(false);
            this.DepenseEmploye.ResumeLayout(false);
            this.DepenseEmploye.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Pr211DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depenseParEmpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depenseParEmpDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DepenseEmploye;
        private System.Windows.Forms.TabPage DepenseAbonnement;
        private System.Windows.Forms.TabPage DepenseAnnee;
        private System.Windows.Forms.TabPage PartiesParTerrain;
        private System.Windows.Forms.TabPage PartiesParAbonnement;
        private System.Windows.Forms.TabPage PartiesParAnnee;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private System.Windows.Forms.Label lblEmploye;
        private System.Windows.Forms.ComboBox cbEmploye;
        private BDB56Pr211DataSetTableAdapters.EmployesTableAdapter employesTableAdapter1;
        private System.Windows.Forms.BindingSource employesBindingSource;
        private BDB56Pr211DataSetTableAdapters.ServicesTableAdapter servicesTableAdapter1;
        private BDB56Pr211DataSet bDB56Pr211DataSet;
        private System.Windows.Forms.BindingSource depenseParEmpBindingSource;
        private BDB56Pr211DataSetTableAdapters.DepenseParEmpTableAdapter depenseParEmpTableAdapter;
        private BDB56Pr211DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView depenseParEmpDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label lblTitre;
    }
}