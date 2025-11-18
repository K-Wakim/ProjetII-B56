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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Pr211DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reabonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reabonnementsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRenouvellerAbonne
            // 
            this.btnRenouvellerAbonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenouvellerAbonne.Location = new System.Drawing.Point(615, 67);
            this.btnRenouvellerAbonne.Name = "btnRenouvellerAbonne";
            this.btnRenouvellerAbonne.Size = new System.Drawing.Size(161, 42);
            this.btnRenouvellerAbonne.TabIndex = 12;
            this.btnRenouvellerAbonne.Text = "Renouveller une abonnement";
            this.btnRenouvellerAbonne.UseVisualStyleBackColor = true;
            // 
            // btnAjouterRemarque
            // 
            this.btnAjouterRemarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterRemarque.Location = new System.Drawing.Point(615, 115);
            this.btnAjouterRemarque.Name = "btnAjouterRemarque";
            this.btnAjouterRemarque.Size = new System.Drawing.Size(161, 29);
            this.btnAjouterRemarque.TabIndex = 11;
            this.btnAjouterRemarque.Text = "Ajouter une remarque";
            this.btnAjouterRemarque.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
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
            this.reabonnementsDataGridView.Location = new System.Drawing.Point(15, 31);
            this.reabonnementsDataGridView.Name = "reabonnementsDataGridView";
            this.reabonnementsDataGridView.Size = new System.Drawing.Size(594, 220);
            this.reabonnementsDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdAbonnement";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdAbonnement";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateRenouvellement";
            this.dataGridViewTextBoxColumn2.HeaderText = "DateRenouvellement";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Remarque";
            this.dataGridViewTextBoxColumn3.HeaderText = "Remarque";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(615, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Retour au menu principale";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmGestionReabonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 266);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reabonnementsDataGridView);
            this.Controls.Add(this.btnRenouvellerAbonne);
            this.Controls.Add(this.btnAjouterRemarque);
            this.Controls.Add(this.label2);
            this.Name = "frmGestionReabonnement";
            this.Text = "Gestion Réabonnement";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmGestionReabonnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Pr211DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reabonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reabonnementsDataGridView)).EndInit();
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
        private System.Windows.Forms.Button button1;
    }
}