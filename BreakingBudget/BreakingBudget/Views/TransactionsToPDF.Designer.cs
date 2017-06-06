namespace BreakingBudget.Views
{
    partial class TransactionsToPDF
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.comboBoxMonth = new MetroFramework.Controls.MetroComboBox();
            this.txtBoxYear = new MetroFramework.Controls.MetroTextBox();
            this.btnExport = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "pdf";
            this.saveFileDialog.FileName = "rapport.pdf";
            this.saveFileDialog.Filter = "Portable Document Format (*.pdf)|*.pdf";
            this.saveFileDialog.Title = "Save rapport";
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.ItemHeight = 23;
            this.comboBoxMonth.Location = new System.Drawing.Point(3, 3);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(121, 29);
            this.comboBoxMonth.TabIndex = 0;
            this.comboBoxMonth.UseSelectable = true;
            // 
            // txtBoxYear
            // 
            // 
            // 
            // 
            this.txtBoxYear.CustomButton.Image = null;
            this.txtBoxYear.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.txtBoxYear.CustomButton.Name = "";
            this.txtBoxYear.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtBoxYear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxYear.CustomButton.TabIndex = 1;
            this.txtBoxYear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxYear.CustomButton.UseSelectable = true;
            this.txtBoxYear.CustomButton.Visible = false;
            this.txtBoxYear.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtBoxYear.Lines = new string[0];
            this.txtBoxYear.Location = new System.Drawing.Point(130, 3);
            this.txtBoxYear.MaxLength = 32767;
            this.txtBoxYear.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtBoxYear.Name = "txtBoxYear";
            this.txtBoxYear.PasswordChar = '\0';
            this.txtBoxYear.PromptText = "Year";
            this.txtBoxYear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxYear.SelectedText = "";
            this.txtBoxYear.SelectionLength = 0;
            this.txtBoxYear.SelectionStart = 0;
            this.txtBoxYear.ShortcutsEnabled = true;
            this.txtBoxYear.Size = new System.Drawing.Size(69, 29);
            this.txtBoxYear.TabIndex = 1;
            this.txtBoxYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxYear.UseSelectable = true;
            this.txtBoxYear.WaterMark = "Year";
            this.txtBoxYear.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxYear.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(164, 124);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.UseSelectable = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.comboBoxMonth);
            this.flowLayoutPanel1.Controls.Add(this.txtBoxYear);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(219, 35);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // TransactionsToPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(259, 170);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnExport);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransactionsToPDF";
            this.Resizable = false;
            this.Text = "TransactionsToPDF";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private MetroFramework.Controls.MetroComboBox comboBoxMonth;
        private MetroFramework.Controls.MetroTextBox txtBoxYear;
        private MetroFramework.Controls.MetroButton btnExport;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
    }
}