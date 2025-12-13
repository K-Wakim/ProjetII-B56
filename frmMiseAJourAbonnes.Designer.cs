namespace ProjetII_B56
{
    partial class frmMiseAJourAbonnes
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
            this.btnRetour = new System.Windows.Forms.Button();
            this.bDB56Pr211DataSet = new ProjetII_B56.BDB56Pr211DataSet();
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonnementsTableAdapter = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.AbonnementsTableAdapter();
            this.tableAdapterManager = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.TableAdapterManager();
            this.abonnementsPrincipaleDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAbonnementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noCiviqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProvinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellulaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courrielDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTypeAbonnementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModifierAbonne = new System.Windows.Forms.Button();
            this.abonnementsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.dependantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dependantsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModifierDependant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Pr211DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsPrincipaleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(2004, 517);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(305, 32);
            this.btnRetour.TabIndex = 16;
            this.btnRetour.Text = "Retour au menu principale";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
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
            this.tableAdapterManager.ProvincesTableAdapter = null;
            this.tableAdapterManager.ReabonnementsTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.TerrainsTableAdapter = null;
            this.tableAdapterManager.TypesAbonnementTableAdapter = null;
            this.tableAdapterManager.TypesEmployeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetII_B56.BDB56Pr211DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // abonnementsPrincipaleDataGridView
            // 
            this.abonnementsPrincipaleDataGridView.AutoGenerateColumns = false;
            this.abonnementsPrincipaleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.abonnementsPrincipaleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abonnementsPrincipaleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateAbonnementDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.sexeDataGridViewTextBoxColumn,
            this.dateNaissanceDataGridViewTextBoxColumn,
            this.noCiviqueDataGridViewTextBoxColumn,
            this.rueDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.idProvinceDataGridViewTextBoxColumn,
            this.codePostalDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.cellulaireDataGridViewTextBoxColumn,
            this.courrielDataGridViewTextBoxColumn,
            this.noTypeAbonnementDataGridViewTextBoxColumn,
            this.remarqueDataGridViewTextBoxColumn});
            this.abonnementsPrincipaleDataGridView.DataSource = this.abonnementsBindingSource;
            this.abonnementsPrincipaleDataGridView.Location = new System.Drawing.Point(21, 40);
            this.abonnementsPrincipaleDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.abonnementsPrincipaleDataGridView.MultiSelect = false;
            this.abonnementsPrincipaleDataGridView.Name = "abonnementsPrincipaleDataGridView";
            this.abonnementsPrincipaleDataGridView.RowHeadersWidth = 51;
            this.abonnementsPrincipaleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.abonnementsPrincipaleDataGridView.Size = new System.Drawing.Size(1731, 271);
            this.abonnementsPrincipaleDataGridView.TabIndex = 17;
            this.abonnementsPrincipaleDataGridView.SelectionChanged += new System.EventHandler(this.abonnementsPrincipaleDataGridView_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dateAbonnementDataGridViewTextBoxColumn
            // 
            this.dateAbonnementDataGridViewTextBoxColumn.DataPropertyName = "DateAbonnement";
            this.dateAbonnementDataGridViewTextBoxColumn.HeaderText = "DateAbonnement";
            this.dateAbonnementDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateAbonnementDataGridViewTextBoxColumn.Name = "dateAbonnementDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // sexeDataGridViewTextBoxColumn
            // 
            this.sexeDataGridViewTextBoxColumn.DataPropertyName = "Sexe";
            this.sexeDataGridViewTextBoxColumn.HeaderText = "Sexe";
            this.sexeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexeDataGridViewTextBoxColumn.Name = "sexeDataGridViewTextBoxColumn";
            // 
            // dateNaissanceDataGridViewTextBoxColumn
            // 
            this.dateNaissanceDataGridViewTextBoxColumn.DataPropertyName = "DateNaissance";
            this.dateNaissanceDataGridViewTextBoxColumn.HeaderText = "DateNaissance";
            this.dateNaissanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateNaissanceDataGridViewTextBoxColumn.Name = "dateNaissanceDataGridViewTextBoxColumn";
            // 
            // noCiviqueDataGridViewTextBoxColumn
            // 
            this.noCiviqueDataGridViewTextBoxColumn.DataPropertyName = "NoCivique";
            this.noCiviqueDataGridViewTextBoxColumn.HeaderText = "NoCivique";
            this.noCiviqueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noCiviqueDataGridViewTextBoxColumn.Name = "noCiviqueDataGridViewTextBoxColumn";
            // 
            // rueDataGridViewTextBoxColumn
            // 
            this.rueDataGridViewTextBoxColumn.DataPropertyName = "Rue";
            this.rueDataGridViewTextBoxColumn.HeaderText = "Rue";
            this.rueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rueDataGridViewTextBoxColumn.Name = "rueDataGridViewTextBoxColumn";
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "Ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            // 
            // idProvinceDataGridViewTextBoxColumn
            // 
            this.idProvinceDataGridViewTextBoxColumn.DataPropertyName = "IdProvince";
            this.idProvinceDataGridViewTextBoxColumn.HeaderText = "IdProvince";
            this.idProvinceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProvinceDataGridViewTextBoxColumn.Name = "idProvinceDataGridViewTextBoxColumn";
            // 
            // codePostalDataGridViewTextBoxColumn
            // 
            this.codePostalDataGridViewTextBoxColumn.DataPropertyName = "CodePostal";
            this.codePostalDataGridViewTextBoxColumn.HeaderText = "CodePostal";
            this.codePostalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codePostalDataGridViewTextBoxColumn.Name = "codePostalDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // cellulaireDataGridViewTextBoxColumn
            // 
            this.cellulaireDataGridViewTextBoxColumn.DataPropertyName = "Cellulaire";
            this.cellulaireDataGridViewTextBoxColumn.HeaderText = "Cellulaire";
            this.cellulaireDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cellulaireDataGridViewTextBoxColumn.Name = "cellulaireDataGridViewTextBoxColumn";
            // 
            // courrielDataGridViewTextBoxColumn
            // 
            this.courrielDataGridViewTextBoxColumn.DataPropertyName = "Courriel";
            this.courrielDataGridViewTextBoxColumn.HeaderText = "Courriel";
            this.courrielDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courrielDataGridViewTextBoxColumn.Name = "courrielDataGridViewTextBoxColumn";
            // 
            // noTypeAbonnementDataGridViewTextBoxColumn
            // 
            this.noTypeAbonnementDataGridViewTextBoxColumn.DataPropertyName = "NoTypeAbonnement";
            this.noTypeAbonnementDataGridViewTextBoxColumn.HeaderText = "NoTypeAbonnement";
            this.noTypeAbonnementDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noTypeAbonnementDataGridViewTextBoxColumn.Name = "noTypeAbonnementDataGridViewTextBoxColumn";
            // 
            // remarqueDataGridViewTextBoxColumn
            // 
            this.remarqueDataGridViewTextBoxColumn.DataPropertyName = "Remarque";
            this.remarqueDataGridViewTextBoxColumn.HeaderText = "Remarque";
            this.remarqueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remarqueDataGridViewTextBoxColumn.Name = "remarqueDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Liste d\'abonnés (principales)";
            // 
            // btnModifierAbonne
            // 
            this.btnModifierAbonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierAbonne.Location = new System.Drawing.Point(21, 647);
            this.btnModifierAbonne.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierAbonne.Name = "btnModifierAbonne";
            this.btnModifierAbonne.Size = new System.Drawing.Size(215, 36);
            this.btnModifierAbonne.TabIndex = 19;
            this.btnModifierAbonne.Text = "Modifier une abonné";
            this.btnModifierAbonne.UseVisualStyleBackColor = true;
            this.btnModifierAbonne.Click += new System.EventHandler(this.btnModifierAbonne_Click);
            // 
            // abonnementsBindingSource1
            // 
            this.abonnementsBindingSource1.DataSource = typeof(ProjetII_B56.Abonnements);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 324);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Liste d\'abonnés (dépendants)";
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinitialiser.Location = new System.Drawing.Point(467, 647);
            this.btnReinitialiser.Margin = new System.Windows.Forms.Padding(4);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(215, 36);
            this.btnReinitialiser.TabIndex = 21;
            this.btnReinitialiser.Text = "Réinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = true;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // dependantsBindingSource
            // 
            this.dependantsBindingSource.DataMember = "Dependants";
            this.dependantsBindingSource.DataSource = this.abonnementsBindingSource1;
            // 
            // dependantsDataGridView
            // 
            this.dependantsDataGridView.AllowUserToAddRows = false;
            this.dependantsDataGridView.AllowUserToDeleteRows = false;
            this.dependantsDataGridView.AllowUserToResizeColumns = false;
            this.dependantsDataGridView.AllowUserToResizeRows = false;
            this.dependantsDataGridView.AutoGenerateColumns = false;
            this.dependantsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dependantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dependantsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dependantsDataGridView.DataSource = this.dependantsBindingSource;
            this.dependantsDataGridView.Location = new System.Drawing.Point(21, 352);
            this.dependantsDataGridView.Name = "dependantsDataGridView";
            this.dependantsDataGridView.RowHeadersWidth = 51;
            this.dependantsDataGridView.RowTemplate.Height = 24;
            this.dependantsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dependantsDataGridView.Size = new System.Drawing.Size(1227, 288);
            this.dependantsDataGridView.TabIndex = 21;
            this.dependantsDataGridView.SelectionChanged += new System.EventHandler(this.dependantsDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sexe";
            this.dataGridViewTextBoxColumn4.HeaderText = "Sexe";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateNaissance";
            this.dataGridViewTextBoxColumn5.HeaderText = "DateNaissance";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdAbonnement";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdAbonnement";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Remarque";
            this.dataGridViewTextBoxColumn7.HeaderText = "Remarque";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Abonnements";
            this.dataGridViewTextBoxColumn8.HeaderText = "Abonnements";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // btnModifierDependant
            // 
            this.btnModifierDependant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierDependant.Location = new System.Drawing.Point(244, 647);
            this.btnModifierDependant.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierDependant.Name = "btnModifierDependant";
            this.btnModifierDependant.Size = new System.Drawing.Size(215, 36);
            this.btnModifierDependant.TabIndex = 22;
            this.btnModifierDependant.Text = "Modifier une dependant";
            this.btnModifierDependant.UseVisualStyleBackColor = true;
            this.btnModifierDependant.Click += new System.EventHandler(this.btnModifierDependant_Click);
            // 
            // frmMiseAJourAbonnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 786);
            this.Controls.Add(this.btnModifierDependant);
            this.Controls.Add(this.dependantsDataGridView);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModifierAbonne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.abonnementsPrincipaleDataGridView);
            this.Controls.Add(this.btnRetour);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMiseAJourAbonnes";
            this.Text = "Mise à jour des abonnés";
            this.Load += new System.EventHandler(this.frmMiseAJourAbonnes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Pr211DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsPrincipaleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private BDB56Pr211DataSet bDB56Pr211DataSet;
        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private BDB56Pr211DataSetTableAdapters.AbonnementsTableAdapter abonnementsTableAdapter;
        private BDB56Pr211DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView abonnementsPrincipaleDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModifierAbonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAbonnementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noCiviqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProvinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellulaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courrielDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTypeAbonnementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource abonnementsBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.BindingSource dependantsBindingSource;
        private System.Windows.Forms.DataGridView dependantsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnModifierDependant;
    }
}