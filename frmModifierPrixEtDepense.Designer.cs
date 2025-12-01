namespace ProjetII_B56
{
    partial class frmModifierPrixEtDepense
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
            this.label1 = new System.Windows.Forms.Label();
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTypeAbo = new System.Windows.Forms.DataGridView();
            this.prixDepensesAbonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvPrixDepenseAbo = new System.Windows.Forms.DataGridView();
            this.btnModifierTypeAbo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeAbo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrixDepenseAbo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(990, 420);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(229, 26);
            this.btnRetour.TabIndex = 17;
            this.btnRetour.Text = "Retour au menu principale";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(707, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Page de modification des prix et dépenses obligatoire";
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(ProjetII_B56.TypesAbonnement);
            // 
            // dgvTypeAbo
            // 
            this.dgvTypeAbo.AutoGenerateColumns = false;
            this.dgvTypeAbo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypeAbo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvTypeAbo.DataSource = this.typesAbonnementBindingSource;
            this.dgvTypeAbo.Location = new System.Drawing.Point(27, 85);
            this.dgvTypeAbo.Name = "dgvTypeAbo";
            this.dgvTypeAbo.Size = new System.Drawing.Size(456, 220);
            this.dgvTypeAbo.TabIndex = 20;
            // 
            // prixDepensesAbonnementsBindingSource
            // 
            this.prixDepensesAbonnementsBindingSource.DataMember = "PrixDepensesAbonnements";
            this.prixDepensesAbonnementsBindingSource.DataSource = this.typesAbonnementBindingSource;
            // 
            // dgvPrixDepenseAbo
            // 
            this.dgvPrixDepenseAbo.AutoGenerateColumns = false;
            this.dgvPrixDepenseAbo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrixDepenseAbo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvPrixDepenseAbo.DataSource = this.prixDepensesAbonnementsBindingSource;
            this.dgvPrixDepenseAbo.Location = new System.Drawing.Point(641, 85);
            this.dgvPrixDepenseAbo.Name = "dgvPrixDepenseAbo";
            this.dgvPrixDepenseAbo.Size = new System.Drawing.Size(543, 220);
            this.dgvPrixDepenseAbo.TabIndex = 20;
            // 
            // btnModifierTypeAbo
            // 
            this.btnModifierTypeAbo.Location = new System.Drawing.Point(641, 420);
            this.btnModifierTypeAbo.Name = "btnModifierTypeAbo";
            this.btnModifierTypeAbo.Size = new System.Drawing.Size(75, 23);
            this.btnModifierTypeAbo.TabIndex = 21;
            this.btnModifierTypeAbo.Text = "Modifier";
            this.btnModifierTypeAbo.UseVisualStyleBackColor = true;
            this.btnModifierTypeAbo.Click += new System.EventHandler(this.btnModifierTypeAbo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "liste des types abonnement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(638, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "pris et dépense par type abonnement";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "No";
            this.dataGridViewTextBoxColumn1.FillWeight = 120F;
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Remarque";
            this.dataGridViewTextBoxColumn3.HeaderText = "Remarque";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NoTypeAbonnement";
            this.dataGridViewTextBoxColumn4.HeaderText = "NoTypeAbonnement";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Annee";
            this.dataGridViewTextBoxColumn5.HeaderText = "Annee";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Prix";
            this.dataGridViewTextBoxColumn6.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DepensesObligatoires";
            this.dataGridViewTextBoxColumn7.HeaderText = "DepensesObligatoires";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Remarque";
            this.dataGridViewTextBoxColumn8.HeaderText = "Remarque";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // frmModifierPrixEtDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 458);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModifierTypeAbo);
            this.Controls.Add(this.dgvPrixDepenseAbo);
            this.Controls.Add(this.dgvTypeAbo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRetour);
            this.Name = "frmModifierPrixEtDepense";
            this.Text = "frmModifierPrixEtDepense";
            this.Load += new System.EventHandler(this.frmModifierPrixEtDepense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeAbo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrixDepenseAbo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
        private System.Windows.Forms.DataGridView dgvTypeAbo;
        private System.Windows.Forms.BindingSource prixDepensesAbonnementsBindingSource;
        private System.Windows.Forms.DataGridView dgvPrixDepenseAbo;
        private System.Windows.Forms.Button btnModifierTypeAbo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}