namespace BreakingBudget.Views
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPosteNum = new MetroFramework.Controls.MetroLabel();
            this.lblAchat = new MetroFramework.Controls.MetroLabel();
            this.rtxtEch = new System.Windows.Forms.RichTextBox();
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(17, 49);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(413, 256);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtxtEch, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 246);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.lblPosteNum);
            this.flowLayoutPanel1.Controls.Add(this.lblAchat);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(407, 38);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // lblPosteNum
            // 
            this.lblPosteNum.AutoSize = true;
            this.lblPosteNum.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPosteNum.Location = new System.Drawing.Point(3, 0);
            this.lblPosteNum.Name = "lblPosteNum";
            this.lblPosteNum.Size = new System.Drawing.Size(142, 19);
            this.lblPosteNum.TabIndex = 0;
            this.lblPosteNum.Text = "Poste à échéance n° : ";
            // 
            // lblAchat
            // 
            this.lblAchat.AutoSize = true;
            this.lblAchat.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAchat.Location = new System.Drawing.Point(3, 19);
            this.lblAchat.Name = "lblAchat";
            this.lblAchat.Size = new System.Drawing.Size(55, 19);
            this.lblAchat.TabIndex = 1;
            this.lblAchat.Text = "Achat : ";
            // 
            // rtxtEch
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.rtxtEch, true);
            this.rtxtEch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtEch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtEch.Location = new System.Drawing.Point(3, 46);
            this.rtxtEch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtEch.Name = "rtxtEch";
            this.rtxtEch.ReadOnly = true;
            this.rtxtEch.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtEch.Size = new System.Drawing.Size(407, 198);
            this.rtxtEch.TabIndex = 2;
            this.rtxtEch.Text = "";
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // FrmAffichDetailsPoste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 321);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmAffichDetailsPoste";
            this.Padding = new System.Windows.Forms.Padding(17, 49, 17, 16);
            this.Text = "Détails poste à échéance ";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLabel lblPosteNum;
        private MetroFramework.Controls.MetroLabel lblAchat;
        private System.Windows.Forms.RichTextBox rtxtEch;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
    }
}