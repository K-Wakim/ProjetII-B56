namespace ProjetII_B56
{
    partial class frmInscriptionDepense
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
            System.Windows.Forms.Label lTypeServices;
            this.btnRetour = new System.Windows.Forms.Button();
            this.cboNomAbo = new System.Windows.Forms.ComboBox();
            this.bDB56Pr211DataSet = new ProjetII_B56.BDB56Pr211DataSet();
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonnementsTableAdapter = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.AbonnementsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbRemarque = new System.Windows.Forms.RichTextBox();
            this.nudDepense = new System.Windows.Forms.NumericUpDown();
            this.dtpDepense = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDepense = new System.Windows.Forms.Button();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.ServicesTableAdapter();
            this.tableAdapterManager = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.TableAdapterManager();
            this.cbTypesServices = new System.Windows.Forms.ComboBox();
            this.lblTypeService = new System.Windows.Forms.Label();
            lTypeServices = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Pr211DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(482, 405);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(305, 32);
            this.btnRetour.TabIndex = 17;
            this.btnRetour.Text = "Retour au menu principale";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // cboNomAbo
            // 
            this.cboNomAbo.DataSource = this.abonnementsBindingSource;
            this.cboNomAbo.DisplayMember = "Nom";
            this.cboNomAbo.FormattingEnabled = true;
            this.cboNomAbo.Location = new System.Drawing.Point(164, 70);
            this.cboNomAbo.Margin = new System.Windows.Forms.Padding(4);
            this.cboNomAbo.Name = "cboNomAbo";
            this.cboNomAbo.Size = new System.Drawing.Size(160, 24);
            this.cboNomAbo.TabIndex = 25;
            this.cboNomAbo.ValueMember = "Id";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nom de l\'abonné";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Montant depense";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Remarque";
            // 
            // rtbRemarque
            // 
            this.rtbRemarque.Location = new System.Drawing.Point(482, 73);
            this.rtbRemarque.Name = "rtbRemarque";
            this.rtbRemarque.Size = new System.Drawing.Size(289, 178);
            this.rtbRemarque.TabIndex = 29;
            this.rtbRemarque.Text = "";
            // 
            // nudDepense
            // 
            this.nudDepense.Location = new System.Drawing.Point(164, 120);
            this.nudDepense.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDepense.Name = "nudDepense";
            this.nudDepense.Size = new System.Drawing.Size(160, 22);
            this.nudDepense.TabIndex = 30;
            // 
            // dtpDepense
            // 
            this.dtpDepense.Enabled = false;
            this.dtpDepense.Location = new System.Drawing.Point(197, 353);
            this.dtpDepense.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDepense.Name = "dtpDepense";
            this.dtpDepense.Size = new System.Drawing.Size(265, 22);
            this.dtpDepense.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "date de la dépense";
            // 
            // btnDepense
            // 
            this.btnDepense.Location = new System.Drawing.Point(13, 413);
            this.btnDepense.Name = "btnDepense";
            this.btnDepense.Size = new System.Drawing.Size(207, 23);
            this.btnDepense.TabIndex = 33;
            this.btnDepense.Text = "confirmer la dépense";
            this.btnDepense.UseVisualStyleBackColor = true;
            this.btnDepense.Click += new System.EventHandler(this.btnDepense_Click);
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.bDB56Pr211DataSet;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ServicesTableAdapter = this.servicesTableAdapter;
            this.tableAdapterManager.TerrainsTableAdapter = null;
            this.tableAdapterManager.TypesAbonnementTableAdapter = null;
            this.tableAdapterManager.TypesEmployeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetII_B56.BDB56Pr211DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lTypeServices
            // 
            lTypeServices.AutoSize = true;
            lTypeServices.Location = new System.Drawing.Point(23, 273);
            lTypeServices.Name = "lTypeServices";
            lTypeServices.Size = new System.Drawing.Size(91, 16);
            lTypeServices.TabIndex = 33;
            lTypeServices.Text = "Type Service:";
            // 
            // cbTypesServices
            // 
            this.cbTypesServices.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "TypeService", true));
            this.cbTypesServices.Enabled = false;
            this.cbTypesServices.FormattingEnabled = true;
            this.cbTypesServices.Items.AddRange(new object[] {
            "Pro Shop",
            "Restaurent",
            "professeur de golf"});
            this.cbTypesServices.Location = new System.Drawing.Point(132, 270);
            this.cbTypesServices.Name = "cbTypesServices";
            this.cbTypesServices.Size = new System.Drawing.Size(121, 24);
            this.cbTypesServices.TabIndex = 34;
            // 
            // lblTypeService
            // 
            this.lblTypeService.AutoSize = true;
            this.lblTypeService.Enabled = false;
            this.lblTypeService.Location = new System.Drawing.Point(129, 278);
            this.lblTypeService.Name = "lblTypeService";
            this.lblTypeService.Size = new System.Drawing.Size(51, 16);
            this.lblTypeService.TabIndex = 35;
            this.lblTypeService.Text = "service";
            // 
            // frmInscriptionDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 457);
            this.Controls.Add(this.lblTypeService);
            this.Controls.Add(lTypeServices);
            this.Controls.Add(this.cbTypesServices);
            this.Controls.Add(this.btnDepense);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDepense);
            this.Controls.Add(this.nudDepense);
            this.Controls.Add(this.rtbRemarque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboNomAbo);
            this.Controls.Add(this.btnRetour);
            this.Name = "frmInscriptionDepense";
            this.Text = "frmInscriptionDepense";
            this.Load += new System.EventHandler(this.frmInscriptionDepense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Pr211DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.ComboBox cboNomAbo;
        private BDB56Pr211DataSet bDB56Pr211DataSet;
        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private BDB56Pr211DataSetTableAdapters.AbonnementsTableAdapter abonnementsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbRemarque;
        private System.Windows.Forms.NumericUpDown nudDepense;
        private System.Windows.Forms.DateTimePicker dtpDepense;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDepense;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private BDB56Pr211DataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private BDB56Pr211DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbTypesServices;
        private System.Windows.Forms.Label lblTypeService;
    }
}