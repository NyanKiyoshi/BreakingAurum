namespace BreakingBudget.Views
{
    partial class InputMessageBox
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
            this.lblDescription = new MetroFramework.Controls.MetroLabel();
            this.textBoxInput = new MetroFramework.Controls.MetroTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SubmitBtn = new MetroFramework.Controls.MetroButton();
            this.cancelBtn = new MetroFramework.Controls.MetroButton();
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescription.Location = new System.Drawing.Point(20, 60);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(88, 19);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "lblDescription";
            // 
            // textBoxInput
            // 
            // 
            // 
            // 
            this.textBoxInput.CustomButton.Image = null;
            this.textBoxInput.CustomButton.Location = new System.Drawing.Point(522, 1);
            this.textBoxInput.CustomButton.Name = "";
            this.textBoxInput.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.textBoxInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxInput.CustomButton.TabIndex = 1;
            this.textBoxInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxInput.CustomButton.UseSelectable = true;
            this.textBoxInput.CustomButton.Visible = false;
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput.Lines = new string[0];
            this.textBoxInput.Location = new System.Drawing.Point(20, 79);
            this.textBoxInput.MaximumSize = new System.Drawing.Size(0, 21);
            this.textBoxInput.MaxLength = 30;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.PasswordChar = '\0';
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxInput.SelectedText = "";
            this.textBoxInput.SelectionLength = 0;
            this.textBoxInput.SelectionStart = 0;
            this.textBoxInput.ShortcutsEnabled = true;
            this.textBoxInput.Size = new System.Drawing.Size(542, 21);
            this.textBoxInput.TabIndex = 1;
            this.textBoxInput.UseSelectable = true;
            this.textBoxInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.SubmitBtn);
            this.flowLayoutPanel1.Controls.Add(this.cancelBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 118);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(542, 29);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SubmitBtn.Location = new System.Drawing.Point(464, 3);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBtn.TabIndex = 0;
            this.SubmitBtn.Text = "S&ubmit";
            this.SubmitBtn.UseSelectable = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(383, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "&Cancel";
            this.cancelBtn.UseSelectable = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // InputMessageBox
            // 
            this.AcceptButton = this.SubmitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(582, 167);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.lblDescription);
            this.Name = "InputMessageBox";
            this.Resizable = false;
            this.Text = "InputMessageBox";
            this.Icon = global::BreakingBudget.Properties.Resources.icon;
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblDescription;
        private MetroFramework.Controls.MetroTextBox textBoxInput;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton SubmitBtn;
        private MetroFramework.Controls.MetroButton cancelBtn;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
    }
}