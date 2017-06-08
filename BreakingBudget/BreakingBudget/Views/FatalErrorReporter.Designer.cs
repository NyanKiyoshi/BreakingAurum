namespace BreakingBudget.Views
{
    partial class FatalErrorReporter
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.errorDataTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnAskForSupport = new MetroFramework.Controls.MetroButton();
            this.btnSendError = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.errorDataTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(537, 249);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // errorDataTextBox
            // 
            this.errorDataTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.errorDataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorDataTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorDataTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorDataTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.errorDataTextBox.Location = new System.Drawing.Point(3, 3);
            this.errorDataTextBox.Name = "errorDataTextBox";
            this.errorDataTextBox.Size = new System.Drawing.Size(531, 217);
            this.errorDataTextBox.TabIndex = 2;
            this.errorDataTextBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnAskForSupport);
            this.panel1.Controls.Add(this.btnSendError);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 226);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 20);
            this.panel1.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(88, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnClose.MaximumSize = new System.Drawing.Size(0, 20);
            this.btnClose.MinimumSize = new System.Drawing.Size(0, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(352, 20);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAskForSupport
            // 
            this.btnAskForSupport.AutoSize = true;
            this.btnAskForSupport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAskForSupport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAskForSupport.Location = new System.Drawing.Point(0, 0);
            this.btnAskForSupport.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnAskForSupport.MaximumSize = new System.Drawing.Size(0, 20);
            this.btnAskForSupport.MinimumSize = new System.Drawing.Size(0, 20);
            this.btnAskForSupport.Name = "btnAskForSupport";
            this.btnAskForSupport.Size = new System.Drawing.Size(88, 20);
            this.btnAskForSupport.TabIndex = 2;
            this.btnAskForSupport.Text = "Ask for support";
            this.btnAskForSupport.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAskForSupport.UseSelectable = true;
            this.btnAskForSupport.Click += new System.EventHandler(this.btnAskForSupport_Click);
            // 
            // btnSendError
            // 
            this.btnSendError.AutoSize = true;
            this.btnSendError.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSendError.Location = new System.Drawing.Point(440, 0);
            this.btnSendError.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnSendError.MaximumSize = new System.Drawing.Size(0, 20);
            this.btnSendError.MinimumSize = new System.Drawing.Size(0, 20);
            this.btnSendError.Name = "btnSendError";
            this.btnSendError.Size = new System.Drawing.Size(91, 20);
            this.btnSendError.TabIndex = 1;
            this.btnSendError.Text = "Report the error";
            this.btnSendError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSendError.UseSelectable = true;
            this.btnSendError.Click += new System.EventHandler(this.btnSendError_Click);
            // 
            // FatalErrorReporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 329);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FatalErrorReporter";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Fatal Error";
            this.Icon = global::BreakingBudget.Properties.Resources.icon;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox errorDataTextBox;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnAskForSupport;
        private MetroFramework.Controls.MetroButton btnSendError;
    }
}