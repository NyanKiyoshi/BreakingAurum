using System;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace BreakingBudget
{
    public partial class FrmMain : MetroForm
    {
        PrivateFontCollection CustomFonts = new PrivateFontCollection();
        Font IconFont;

        SidebarEntry[] SidebarEntries = new SidebarEntry[]
        {
            new SidebarEntry(new byte[] { 0xEE, 0xA1, 0xA8 }, "Meow"),
            new SidebarEntry(new byte[] { 0xEE, 0xA1, 0xA9 }, "OwO"),
            new SidebarEntry(new byte[] { 0xEE, 0x90, 0xA0 }, "OmO")
        };


        public FrmMain()
        {
            InitializeComponent();
            InitFonts();

            this.Font = new Font("Arial", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            GenerateSidebar();
        }

        private void InitFonts()
        {
            this.CustomFonts = new PrivateFontCollection();
            this.CustomFonts.AddFontFile("MaterialIcons-Regular.ttf");
            this.IconFont = new Font(this.CustomFonts.Families[0], 19.0f, FontStyle.Regular, GraphicsUnit.Point);  // FIXME: dynamic value (23)
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MetroMessageBox.Show(this,
                "Êtes-vous sûr de vouloir quitter ?",
                "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes
                )
            {
                e.Cancel = true;
            }
        }

        private void GenerateSidebar()
        {
            this.SidebarTable.BackColor = this.BackColor;
            this.SidebarTopFlowLayout.BackColor = this.BackColor;
            this.SidebarBottomFlowLayout.BackColor = this.BackColor;

            this.SidebarTable.Padding = new Padding(0);
            this.SidebarTable.Margin  = new Padding(0);

            this.SidebarTopFlowLayout.FlowDirection = FlowDirection.TopDown;
            this.SidebarBottomFlowLayout.FlowDirection = FlowDirection.BottomUp;

            GenerateSidebarContent();
            UpdateSidebar();
        }

        /*
         * Generates the sidebar using the following design:
         *   + ------ [FlowLayoutPanel -> From Top to Down] ------ +
         *   + + ------------ Entry 1 [Left to Right] ---------- + +
         *   + + + ------ + + -------------------------------- + + +
         *   + + +  Icon  + +  Entry Text                      + + +
         *   + + + ------ + + -------------------------------- + + +
         *   + + ----------------------------------------------- + +
         *   + --------------------------------------------------- +
         */
        private void GenerateSidebarContent()
        {
            Label entry_icon;
            Label entry_text;

            // future lambda event handlers
            EventHandler OnMouseLeave;
            EventHandler OnMouseEnter;

            // the default text color and the active & hover one
            Color BaseColor = Color.FromArgb(117, 117, 117);
            Color ActiveColor = Color.FromArgb(0, 0, 0);

            // we now start to append every entry from the attribute `SidebarEntries`
            foreach (SidebarEntry e in this.SidebarEntries)
            {
                // Declare and create the entry's container
                // Warning: we MUST put the declaration here to make the bellow
                //          lambda functions point on the right container.
                FlowLayoutPanel entry_layout = new FlowLayoutPanel();

                // init the entry labels
                entry_icon = new Label();
                entry_text = new Label();

                // create the mouse events (hover and release/ leave)
                OnMouseEnter = (s, ev) =>
                {
                    entry_layout.ForeColor = ActiveColor;
                };

                OnMouseLeave = (s, ev) =>
                {
                    entry_layout.ForeColor = BaseColor;
                };

                // set the inactive color to the whole container
                entry_layout.ForeColor = BaseColor;

                // assign the events to EVERY component of the entry
                entry_layout.MouseEnter += OnMouseEnter;
                entry_layout.MouseLeave += OnMouseLeave;

                entry_icon.MouseEnter += OnMouseEnter;
                entry_icon.MouseLeave += OnMouseLeave;

                entry_text.MouseEnter += OnMouseEnter;
                entry_text.MouseLeave += OnMouseLeave;
                // ----

                // The inner layout is gonna contain in the following order:
                // [Label: ICON] [Label: Text]
                // So we put the layout's direction in Left to Right
                entry_layout.FlowDirection = FlowDirection.LeftToRight;

                // [Label: ICON] [Label: Text]
                entry_layout.Controls.Add(entry_icon);
                entry_layout.Controls.Add(entry_text);

                // spacing between every entry is of 15px (margin bottom = 15)
                entry_layout.Margin = new Padding(0, 0, 0, 15);

                // the icon's label is a square of 30x30
                entry_icon.AutoSize = false;
                entry_icon.Height = entry_icon.Width = 30;

                // align everything on top-left
                entry_text.TextAlign = entry_icon.TextAlign = ContentAlignment.TopLeft;

                // XXX: we probably don't need this line anymore
                entry_text.Height = entry_icon.Height;

                // set the icon's label in MaterialFont
                entry_icon.Font = this.IconFont;

                // Convert the UTF-8 byte array to String
                entry_icon.Text = Encoding.UTF8.GetString(e.Icon);

                // Make the entry's text (entry name) label bigger
                entry_text.Font = new Font("Microsoft Sans Serif", 14.0f, FontStyle.Regular, GraphicsUnit.Point);
                entry_text.Text = e.Text;

                // set the layout's height at the same height of the icon
                entry_layout.Height = entry_icon.Height;

                // append the entry to the sidebar
                this.SidebarTopFlowLayout.Controls.Add(entry_layout);
            }
        }

        private void UpdateSidebar()
        {
        }

        private void ContentPanel_SelectedPageChanged(object sender, EventArgs e)
        {
            // TODO: go through the sidebar content
            //       -> isActive()
            UpdateSidebar();
        }
    }
}
