namespace BreakingBudget
{
    partial class FrmAffichDetailsPoste
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
            this.lblPosteNum = new System.Windows.Forms.Label();
            this.lblAchat = new System.Windows.Forms.Label();
            this.rtxtEch = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblPosteNum
            // 
            this.lblPosteNum.AutoSize = true;
            this.lblPosteNum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosteNum.Location = new System.Drawing.Point(15, 16);
            this.lblPosteNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosteNum.Name = "lblPosteNum";
            this.lblPosteNum.Size = new System.Drawing.Size(141, 16);
            this.lblPosteNum.TabIndex = 0;
            this.lblPosteNum.Text = "Poste à échéance n° : ";
            // 
            // lblAchat
            // 
            this.lblAchat.AutoSize = true;
            this.lblAchat.Location = new System.Drawing.Point(15, 41);
            this.lblAchat.Name = "lblAchat";
            this.lblAchat.Size = new System.Drawing.Size(54, 16);
            this.lblAchat.TabIndex = 1;
            this.lblAchat.Text = "Achat : ";
            // 
            // rtxtEch
            // 
            this.rtxtEch.Location = new System.Drawing.Point(18, 70);
            this.rtxtEch.Name = "rtxtEch";
            this.rtxtEch.ReadOnly = true;
            this.rtxtEch.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtEch.Size = new System.Drawing.Size(313, 142);
            this.rtxtEch.TabIndex = 2;
            this.rtxtEch.Text = "";
            // 
            // FrmAffichDetailsPoste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 224);
            this.Controls.Add(this.rtxtEch);
            this.Controls.Add(this.lblAchat);
            this.Controls.Add(this.lblPosteNum);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmAffichDetailsPoste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Détails poste à échéance ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPosteNum;
        private System.Windows.Forms.Label lblAchat;
        private System.Windows.Forms.RichTextBox rtxtEch;
    }
}