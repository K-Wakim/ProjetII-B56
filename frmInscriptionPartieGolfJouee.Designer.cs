namespace ProjetII_B56
{
    partial class frmInscriptionPartieGolfJouee
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
            this.nomLabel = new System.Windows.Forms.Label();
            this.nomLabel1 = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPointage = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bDB56Pr211DataSet = new ProjetII_B56.BDB56Pr211DataSet();
            this.terrainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terrainsTableAdapter = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.TerrainsTableAdapter();
            this.tableAdapterManager = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.TableAdapterManager();
            this.abonnementsTableAdapter = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.AbonnementsTableAdapter();
            this.partiesJoueesTableAdapter = new ProjetII_B56.BDB56Pr211DataSetTableAdapters.PartiesJoueesTableAdapter();
            this.cboNomTerrain = new System.Windows.Forms.ComboBox();
            this.dtpPartieJoue = new System.Windows.Forms.DateTimePicker();
            this.fKPartiesJoueesTerrainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboNomAbo = new System.Windows.Forms.ComboBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbRemarque = new System.Windows.Forms.RichTextBox();
            this.bdB56Pr211DataSet1 = new ProjetII_B56.BDB56Pr211DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Pr211DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrainsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPartiesJoueesTerrainsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdB56Pr211DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(35, 161);
            this.nomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(97, 16);
            this.nomLabel.TabIndex = 21;
            this.nomLabel.Text = "Nom du terrain:";
            // 
            // nomLabel1
            // 
            this.nomLabel1.AutoSize = true;
            this.nomLabel1.Location = new System.Drawing.Point(35, 113);
            this.nomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomLabel1.Name = "nomLabel1";
            this.nomLabel1.Size = new System.Drawing.Size(113, 16);
            this.nomLabel1.TabIndex = 23;
            this.nomLabel1.Text = "Nom de l\'abonné:";
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(475, 402);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(305, 32);
            this.btnRetour.TabIndex = 16;
            this.btnRetour.Text = "Retour au menu principale";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 39);
            this.label1.TabIndex = 17;
            this.label1.Text = "Page d\'inscription partie jouée";
            // 
            // nudPointage
            // 
            this.nudPointage.Location = new System.Drawing.Point(189, 201);
            this.nudPointage.Margin = new System.Windows.Forms.Padding(4);
            this.nudPointage.Name = "nudPointage";
            this.nudPointage.Size = new System.Drawing.Size(160, 22);
            this.nudPointage.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Pointage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Date de la partie joué";
            // 
            // bDB56Pr211DataSet
            // 
            this.bDB56Pr211DataSet.DataSetName = "BDB56Pr211DataSet";
            this.bDB56Pr211DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // terrainsBindingSource
            // 
            this.terrainsBindingSource.DataMember = "Terrains";
            this.terrainsBindingSource.DataSource = this.bDB56Pr211DataSet;
            // 
            // terrainsTableAdapter
            // 
            this.terrainsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbonnementsTableAdapter = this.abonnementsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DependantsTableAdapter = null;
            this.tableAdapterManager.DepensesTableAdapter = null;
            this.tableAdapterManager.EmployesTableAdapter = null;
            this.tableAdapterManager.PartiesJoueesTableAdapter = this.partiesJoueesTableAdapter;
            this.tableAdapterManager.PrixDepensesAbonnementsTableAdapter = null;
            this.tableAdapterManager.ProvincesTableAdapter = null;
            this.tableAdapterManager.ReabonnementsTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.TerrainsTableAdapter = this.terrainsTableAdapter;
            this.tableAdapterManager.TypesAbonnementTableAdapter = null;
            this.tableAdapterManager.TypesEmployeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetII_B56.BDB56Pr211DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // abonnementsTableAdapter
            // 
            this.abonnementsTableAdapter.ClearBeforeFill = true;
            // 
            // partiesJoueesTableAdapter
            // 
            this.partiesJoueesTableAdapter.ClearBeforeFill = true;
            // 
            // cboNomTerrain
            // 
            this.cboNomTerrain.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrainsBindingSource, "Nom", true));
            this.cboNomTerrain.DataSource = this.terrainsBindingSource;
            this.cboNomTerrain.DisplayMember = "Nom";
            this.cboNomTerrain.FormattingEnabled = true;
            this.cboNomTerrain.Location = new System.Drawing.Point(189, 161);
            this.cboNomTerrain.Margin = new System.Windows.Forms.Padding(4);
            this.cboNomTerrain.Name = "cboNomTerrain";
            this.cboNomTerrain.Size = new System.Drawing.Size(160, 24);
            this.cboNomTerrain.TabIndex = 22;
            this.cboNomTerrain.ValueMember = "No";
            // 
            // dtpPartieJoue
            // 
            this.dtpPartieJoue.Enabled = false;
            this.dtpPartieJoue.Location = new System.Drawing.Point(189, 262);
            this.dtpPartieJoue.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPartieJoue.Name = "dtpPartieJoue";
            this.dtpPartieJoue.Size = new System.Drawing.Size(265, 22);
            this.dtpPartieJoue.TabIndex = 23;
            // 
            // fKPartiesJoueesTerrainsBindingSource
            // 
            this.fKPartiesJoueesTerrainsBindingSource.DataMember = "FK_PartiesJouees_Terrains";
            this.fKPartiesJoueesTerrainsBindingSource.DataSource = this.terrainsBindingSource;
            // 
            // abonnementsBindingSource
            // 
            this.abonnementsBindingSource.DataMember = "Abonnements";
            this.abonnementsBindingSource.DataSource = this.bDB56Pr211DataSet;
            // 
            // cboNomAbo
            // 
            this.cboNomAbo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Nom", true));
            this.cboNomAbo.DataSource = this.abonnementsBindingSource;
            this.cboNomAbo.DisplayMember = "Nom";
            this.cboNomAbo.FormattingEnabled = true;
            this.cboNomAbo.Location = new System.Drawing.Point(189, 113);
            this.cboNomAbo.Margin = new System.Windows.Forms.Padding(4);
            this.cboNomAbo.Name = "cboNomAbo";
            this.cboNomAbo.Size = new System.Drawing.Size(160, 24);
            this.cboNomAbo.TabIndex = 24;
            this.cboNomAbo.ValueMember = "Id";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(52, 402);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(203, 28);
            this.btnEnregistrer.TabIndex = 25;
            this.btnEnregistrer.Text = "Enregistrer partie jouée";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "remarque";
            // 
            // rtbRemarque
            // 
            this.rtbRemarque.Location = new System.Drawing.Point(524, 158);
            this.rtbRemarque.Name = "rtbRemarque";
            this.rtbRemarque.Size = new System.Drawing.Size(246, 182);
            this.rtbRemarque.TabIndex = 27;
            this.rtbRemarque.Text = "";
            // 
            // bdB56Pr211DataSet1
            // 
            this.bdB56Pr211DataSet1.DataSetName = "BDB56Pr211DataSet";
            this.bdB56Pr211DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmInscriptionPartieGolfJouee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 449);
            this.Controls.Add(this.rtbRemarque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.nomLabel1);
            this.Controls.Add(this.cboNomAbo);
            this.Controls.Add(this.dtpPartieJoue);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.cboNomTerrain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudPointage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRetour);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInscriptionPartieGolfJouee";
            this.Text = "frmInscriptionPartieGolfJouee";
            this.Load += new System.EventHandler(this.frmInscriptionPartieGolfJouee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPointage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Pr211DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrainsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPartiesJoueesTerrainsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdB56Pr211DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPointage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private BDB56Pr211DataSet bDB56Pr211DataSet;
        private System.Windows.Forms.BindingSource terrainsBindingSource;
        private BDB56Pr211DataSetTableAdapters.TerrainsTableAdapter terrainsTableAdapter;
        private BDB56Pr211DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cboNomTerrain;
        private System.Windows.Forms.DateTimePicker dtpPartieJoue;
        private BDB56Pr211DataSetTableAdapters.PartiesJoueesTableAdapter partiesJoueesTableAdapter;
        private System.Windows.Forms.BindingSource fKPartiesJoueesTerrainsBindingSource;
        private BDB56Pr211DataSetTableAdapters.AbonnementsTableAdapter abonnementsTableAdapter;
        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private System.Windows.Forms.ComboBox cboNomAbo;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label nomLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbRemarque;
        private BDB56Pr211DataSet bdB56Pr211DataSet1;
    }
}