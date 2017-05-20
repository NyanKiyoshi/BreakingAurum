using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSidebar
{
    public partial class MaterialSidebar : Control
    {
        private SolidBrush borderBrush, textBrush;
        private Rectangle borderRectangle;
        private bool active = false;
        private StringFormat stringFormat = new StringFormat();

        public MaterialSidebarEntryCollection _RootEntries = new MaterialSidebarEntryCollection();

        private PrivateFontCollection fonts;
        private Font IconFont;

        private FlowLayoutPanel flowLayoutPanel;

        public override Cursor Cursor { get; set; } = Cursors.Default;
        public float BorderThickness { get; set; } = 2;

        [Category(Defaults.PropertyCategory.Appearance)]
        [DefaultValue(typeof(Color), Defaults.Values.BaseEntryBackColor)]
        public Color BaseEntryBackColor { get; set; }

        [Category(Defaults.PropertyCategory.Appearance)]
        [DefaultValue(typeof(Color), Defaults.Values.BaseEntryBorderColor)]
        public Color EntryBorderColor { get; set; }

        [Category(Defaults.PropertyCategory.Appearance)]
        [DefaultValue(typeof(int), Defaults.Values.BaseEntryIconWidthPx)]
        public int EntryIconWidth { get; set; }

        [Category(Defaults.PropertyCategory.Appearance)]
        [DefaultValue(typeof(int), Defaults.Values.BaseBaseEntryIconSize)]
        public int EntryIconSize { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public MaterialSidebarEntryCollection RootEntries { get { return this._RootEntries; } }

        public MaterialSidebar()
        {
            InitFonts();

            borderBrush = new SolidBrush(ColorTranslator.FromHtml("#31302b"));
            textBrush = new SolidBrush(ColorTranslator.FromHtml("#FFF"));

            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            this.Paint += FlatButton_Paint;

            Label lbl = new Label();
            lbl.Text = "MaterialSidebar";

            this.flowLayoutPanel = new FlowLayoutPanel();
            this.flowLayoutPanel.Controls.Add(lbl);
            this.flowLayoutPanel.Controls.Add(lbl);
            this.flowLayoutPanel.Controls.Add(lbl);
            this.flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            this.flowLayoutPanel.Dock = DockStyle.Fill;

            this.Controls.Add(flowLayoutPanel);
        }

        private void InitFonts()
        {
            this.fonts = new PrivateFontCollection();
            this.fonts.AddFontFile("MaterialIcons-Regular.ttf");
            this.IconFont = new Font(this.fonts.Families[0], 12);  // FIXME: dynamic value (12)
        }

        private Label CreateEntryIcon(byte[] icon_char)
        {
            Label icon = new Label();

            icon.AutoSize = false;
            icon.Width = this.EntryIconWidth;
            icon.Font = new Font(this.fonts.Families[0], (this.EntryIconSize > 0) ? this.EntryIconSize : 12);
            icon.Text = Encoding.UTF8.GetString(new byte[] { 0xEE, 0x97, 0x90 });

            return icon;
        }

        // FIXME
        private void GenerateData()
        {
            MaterialSidebarEntry e = new MaterialSidebarEntry();

            e.Icon = null;
            e.Text = "Hello!";

            this.RootEntries.Add(e);
        }

        private void CreateAll()
        {
            if (this.RootEntries == null)
            {
                return;
            }

            MaterialSidebarEntry entry;
            FlowLayoutPanel entry_panel;
            Label entry_text;

            entry_text = new Label();
            entry_text.Text = "HELLELELE";

            entry_panel = new FlowLayoutPanel();

            entry_panel.Controls.Add(entry_text);
            this.flowLayoutPanel.Controls.Add(entry_panel);

            for (int i = 0; i < this.RootEntries.Count; ++i)
            {
                entry = this.RootEntries[i];

                entry_panel = new FlowLayoutPanel();
                entry_text = new Label();

                entry_panel.BackColor = this.BaseEntryBackColor;
                entry_text.Text = entry.Text;

                entry_panel.Controls.Add(CreateEntryIcon(entry.Icon));
                entry_panel.Controls.Add(entry_text);

                flowLayoutPanel.Width = this.flowLayoutPanel.Width;
                flowLayoutPanel.Height = entry_text.Height;

                this.flowLayoutPanel.Controls.Add(entry_panel);
            }

            HSLColor baseColor = new HSLColor(this.BaseEntryBackColor);
        }

        private void FlatButton_Paint(object sender, PaintEventArgs e)
        {
            borderRectangle = new Rectangle(0, 0, Width, Height);
            e.Graphics.DrawRectangle(new Pen(borderBrush, BorderThickness), borderRectangle);
            e.Graphics.DrawString(this.Text, this.IconFont, (active) ? textBrush : borderBrush, borderRectangle, stringFormat);
            GenerateData();
            this.flowLayoutPanel.Controls.Clear();
            //CreateAll();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            base.BackColor = ColorTranslator.FromHtml("#31302b");
            active = true;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            base.BackColor = ColorTranslator.FromHtml("#FFF");
            active = false;
        }
    }
}
