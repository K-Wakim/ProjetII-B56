namespace ProjetII_B56
{
    partial class frmInfoDepense
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
            this.lblNomAbo = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblTypeService = new System.Windows.Forms.Label();
            this.lblNomEmploye = new System.Windows.Forms.Label();
            this.lblTotalDepenses = new System.Windows.Forms.Label();
            this.lblMontantRestant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomAbo
            // 
            this.lblNomAbo.AutoSize = true;
            this.lblNomAbo.Location = new System.Drawing.Point(85, 48);
            this.lblNomAbo.Name = "lblNomAbo";
            this.lblNomAbo.Size = new System.Drawing.Size(75, 16);
            this.lblNomAbo.TabIndex = 0;
            this.lblNomAbo.Text = "lblNomAbo";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(85, 83);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 16);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "lblDate";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(85, 114);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(68, 16);
            this.lblMontant.TabIndex = 2;
            this.lblMontant.Text = "lblMontant";
            // 
            // lblTypeService
            // 
            this.lblTypeService.AutoSize = true;
            this.lblTypeService.Location = new System.Drawing.Point(85, 168);
            this.lblTypeService.Name = "lblTypeService";
            this.lblTypeService.Size = new System.Drawing.Size(99, 16);
            this.lblTypeService.TabIndex = 3;
            this.lblTypeService.Text = "lblTypeService";
            // 
            // lblNomEmploye
            // 
            this.lblNomEmploye.AutoSize = true;
            this.lblNomEmploye.Location = new System.Drawing.Point(85, 201);
            this.lblNomEmploye.Name = "lblNomEmploye";
            this.lblNomEmploye.Size = new System.Drawing.Size(104, 16);
            this.lblNomEmploye.TabIndex = 4;
            this.lblNomEmploye.Text = "lblNomEmploye";
            // 
            // lblTotalDepenses
            // 
            this.lblTotalDepenses.AutoSize = true;
            this.lblTotalDepenses.Location = new System.Drawing.Point(85, 242);
            this.lblTotalDepenses.Name = "lblTotalDepenses";
            this.lblTotalDepenses.Size = new System.Drawing.Size(115, 16);
            this.lblTotalDepenses.TabIndex = 5;
            this.lblTotalDepenses.Text = "lblTotalDepenses";
            // 
            // lblMontantRestant
            // 
            this.lblMontantRestant.AutoSize = true;
            this.lblMontantRestant.Location = new System.Drawing.Point(85, 283);
            this.lblMontantRestant.Name = "lblMontantRestant";
            this.lblMontantRestant.Size = new System.Drawing.Size(114, 16);
            this.lblMontantRestant.TabIndex = 6;
            this.lblMontantRestant.Text = "lblMontantRestant";
            // 
            // frmInfoDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMontantRestant);
            this.Controls.Add(this.lblTotalDepenses);
            this.Controls.Add(this.lblNomEmploye);
            this.Controls.Add(this.lblTypeService);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNomAbo);
            this.Name = "frmInfoDepense";
            this.Text = "frmInfoDepense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomAbo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblTypeService;
        private System.Windows.Forms.Label lblNomEmploye;
        private System.Windows.Forms.Label lblTotalDepenses;
        private System.Windows.Forms.Label lblMontantRestant;
    }
}