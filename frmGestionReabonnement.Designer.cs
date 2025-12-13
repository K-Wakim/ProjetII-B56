namespace ProjetII_B56
{
    partial class frmGestionReabonnement
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
            this.btnRenouvellerAbonne = new System.Windows.Forms.Button();
            this.btnAjouterRemarque = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bDB56Pr211DataSet = new ProjetII_B56.BDB56Pr211DataSet();
            this.reabonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reabonnementsTableAdapter = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.ReabonnementsTableAdapter();
            this.tableAdapterManager = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.TableAdapterManager();
            this.reabonnementsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRetour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonnementsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRemarque = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Pr211DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reabonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reabonnementsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRenouvellerAbonne
            // 
            this.btnRenouvellerAbonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenouvellerAbonne.Location = new System.Drawing.Point(820, 357);
            this.btnRenouvellerAbonne.Margin = new System.Windows.Forms.Padding(4);
            this.btnRenouvellerAbonne.Name = "btnRenouvellerAbonne";
            this.btnRenouvellerAbonne.Size = new System.Drawing.Size(215, 52);
            this.btnRenouvellerAbonne.TabIndex = 12;
            this.btnRenouvellerAbonne.Text = "Renouveller une abonnement";
            this.btnRenouvellerAbonne.UseVisualStyleBackColor = true;
            this.btnRenouvellerAbonne.Click += new System.EventHandler(this.btnRenouvellerAbonne_Click);
            // 
            // btnAjouterRemarque
            // 
            this.btnAjouterRemarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterRemarque.Location = new System.Drawing.Point(820, 38);
            this.btnAjouterRemarque.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterRemarque.Name = "btnAjouterRemarque";
            this.btnAjouterRemarque.Size = new System.Drawing.Size(215, 36);
            this.btnAjouterRemarque.TabIndex = 11;
            this.btnAjouterRemarque.Text = "Ajouter une remarque";
            this.btnAjouterRemarque.UseVisualStyleBackColor = true;
            this.btnAjouterRemarque.Click += new System.EventHandler(this.btnAjouterRemarque_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Réabonnement :";
            // 
            // bDB56Pr211DataSet
            // 
            this.bDB56Pr211DataSet.DataSetName = "BDB56Pr211DataSet";
            this.bDB56Pr211DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reabonnementsBindingSource
            // 
            this.reabonnementsBindingSource.DataMember = "Reabonnements";
            this.reabonnementsBindingSource.DataSource = this.bDB56Pr211DataSet;
            // 
            // reabonnementsTableAdapter
            // 
            this.reabonnementsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbonnementsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DependantsTableAdapter = null;
            this.tableAdapterManager.DepensesTableAdapter = null;
            this.tableAdapterManager.EmployesTableAdapter = null;
            this.tableAdapterManager.PartiesJoueesTableAdapter = null;
            this.tableAdapterManager.PrixDepensesAbonnementsTableAdapter = null;
            this.tableAdapterManager.ProvincesTableAdapter = null;
            this.tableAdapterManager.ReabonnementsTableAdapter = this.reabonnementsTableAdapter;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.TerrainsTableAdapter = null;
            this.tableAdapterManager.TypesAbonnementTableAdapter = null;
            this.tableAdapterManager.TypesEmployeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetII_B56.BDB56Pr211DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reabonnementsDataGridView
            // 
            this.reabonnementsDataGridView.AllowUserToAddRows = false;
            this.reabonnementsDataGridView.AllowUserToDeleteRows = false;
            this.reabonnementsDataGridView.AllowUserToResizeColumns = false;
            this.reabonnementsDataGridView.AllowUserToResizeRows = false;
            this.reabonnementsDataGridView.AutoGenerateColumns = false;
            this.reabonnementsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reabonnementsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reabonnementsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.reabonnementsDataGridView.DataSource = this.reabonnementsBindingSource;
            this.reabonnementsDataGridView.Location = new System.Drawing.Point(20, 38);
            this.reabonnementsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.reabonnementsDataGridView.Name = "reabonnementsDataGridView";
            this.reabonnementsDataGridView.RowHeadersWidth = 51;
            this.reabonnementsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reabonnementsDataGridView.Size = new System.Drawing.Size(792, 271);
            this.reabonnementsDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdAbonnement";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdAbonnement";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateRenouvellement";
            this.dataGridViewTextBoxColumn2.HeaderText = "DateRenouvellement";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Remarque";
            this.dataGridViewTextBoxColumn3.HeaderText = "Remarque";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(820, 260);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(215, 49);
            this.btnRetour.TabIndex = 14;
            this.btnRetour.Text = "Retour au menu principale";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Listes abonnements principales :";
            // 
            // abonnementsBindingSource
            // 
            this.abonnementsBindingSource.DataSource = typeof(ProjetII_B56.Abonnements);
            // 
            // abonnementsDataGridView
            // 
            this.abonnementsDataGridView.AutoGenerateColumns = false;
            this.abonnementsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.abonnementsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abonnementsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.abonnementsDataGridView.DataSource = this.abonnementsBindingSource;
            this.abonnementsDataGridView.Location = new System.Drawing.Point(20, 357);
            this.abonnementsDataGridView.Name = "abonnementsDataGridView";
            this.abonnementsDataGridView.RowHeadersWidth = 51;
            this.abonnementsDataGridView.RowTemplate.Height = 24;
            this.abonnementsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.abonnementsDataGridView.Size = new System.Drawing.Size(792, 281);
            this.abonnementsDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateAbonnement";
            this.dataGridViewTextBoxColumn5.HeaderText = "DateAbonnement";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn7.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Courriel";
            this.dataGridViewTextBoxColumn17.HeaderText = "Courriel";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "NoTypeAbonnement";
            this.dataGridViewTextBoxColumn18.HeaderText = "NoTypeAbonnement";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // txtRemarque
            // 
            this.txtRemarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarque.Location = new System.Drawing.Point(820, 81);
            this.txtRemarque.Multiline = true;
            this.txtRemarque.Name = "txtRemarque";
            this.txtRemarque.Size = new System.Drawing.Size(215, 99);
            this.txtRemarque.TabIndex = 16;
            // 
            // frmGestionReabonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 650);
            this.Controls.Add(this.txtRemarque);
            this.Controls.Add(this.abonnementsDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.reabonnementsDataGridView);
            this.Controls.Add(this.btnRenouvellerAbonne);
            this.Controls.Add(this.btnAjouterRemarque);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGestionReabonnement";
            this.Text = "Gestion Réabonnement";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmGestionReabonnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Pr211DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reabonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reabonnementsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRenouvellerAbonne;
        private System.Windows.Forms.Button btnAjouterRemarque;
        private System.Windows.Forms.Label label2;
        private BDB56Pr211DataSet bDB56Pr211DataSet;
        private System.Windows.Forms.BindingSource reabonnementsBindingSource;
        private BDB56Pr211DataSetTableAdapters.ReabonnementsTableAdapter reabonnementsTableAdapter;
        private BDB56Pr211DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView reabonnementsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private System.Windows.Forms.DataGridView abonnementsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.TextBox txtRemarque;
    }
}