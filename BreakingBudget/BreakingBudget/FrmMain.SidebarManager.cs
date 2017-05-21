using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using Kerido.Controls;

namespace BreakingBudget
{
    partial class FrmMain
    {
        private PrivateFontCollection CustomFonts = new PrivateFontCollection();
        private Font IconFont;

        // the default text color and the active & hover one
        Color BaseSidebarEntryColor = Color.FromArgb(117, 117, 117);
        Color ActiveBaseSidebarEntryColor = Color.FromArgb(0, 0, 0);

        SidebarEntry[][] SidebarsRootEntries;

        private void InitFonts()
        {
            this.CustomFonts = new PrivateFontCollection();
            this.CustomFonts.AddFontFile("MaterialIcons-Regular.ttf");
            this.IconFont = new Font(this.CustomFonts.Families[0], 19.0f, FontStyle.Regular, GraphicsUnit.Point);  // FIXME: dynamic value (23)
        }

        private void GenerateSidebar(SidebarEntry[][] SidebarsRootEntries)
        {
            InitFonts();

            this.SidebarsRootEntries = SidebarsRootEntries;

            this.SidebarTable.BackColor = this.BackColor;
            this.SidebarTopFlowLayout.BackColor = this.BackColor;
            this.SidebarBottomFlowLayout.BackColor = this.BackColor;

            this.SidebarTable.Padding = new Padding(0);
            this.SidebarTable.Margin = new Padding(0);

            this.SidebarTopFlowLayout.FlowDirection = FlowDirection.TopDown;
            this.SidebarBottomFlowLayout.FlowDirection = FlowDirection.BottomUp;

            GenerateSidebarContent(this.SidebarTopFlowLayout, this.TopSidebarEntries);
            GenerateSidebarContent(this.SidebarBottomFlowLayout, this.BottomSidebarEntries);
        }

        private void SwitchPanel(MultiPanePage target)
        {
            this.ContentPanel.SelectedPage = target;
        }

        private void ToggleSidebarChildren(SidebarEntry[] children, bool Visible)
        {
            foreach (SidebarEntry child in children)
            {
                if (child._OwnerController.GetType() == typeof(FlowLayoutPanel))
                {
                    ((FlowLayoutPanel)child._OwnerController).Visible = Visible;
                }
            }
        }

        private void UnexpandSidebarEntries()
        {
            foreach (SidebarEntry[] SidebarRootEntries in this.SidebarsRootEntries)
            {
                foreach (SidebarEntry ParentEntry in SidebarRootEntries)
                {
                    if (ParentEntry.children != null)
                    {
                        ToggleSidebarChildren(ParentEntry.children, false);
                    }
                    ParentEntry.IsExpanded = false;
                }
            }
        }

        private FlowLayoutPanel GenerateSidebarEntry(SidebarEntry e)
        {
            Label EntryIcon;
            Label EntryText;

            // future lambda event handlers
            EventHandler OnMouseLeave;
            EventHandler OnMouseEnter;
            EventHandler OnMouseClick;

            // Declare and create the entry's container
            // Warning: we MUST put the declaration here to make the bellow
            //          lambda functions point on the right container.
            FlowLayoutPanel entry_layout = new FlowLayoutPanel();

            // init the entry labels
            EntryIcon = new Label();
            EntryText = new Label();

            // create the mouse events (hover and release/ leave)
            OnMouseEnter = (s, ev) =>
            {
                entry_layout.ForeColor = this.ActiveBaseSidebarEntryColor;
            };

            OnMouseLeave = (s, ev) =>
            {
                if (e.IsActive != true)
                {
                    entry_layout.ForeColor = this.BaseSidebarEntryColor;
                }
            };

            // if the target is a web link -> open it when the user clicks on it
            if (e.TargetLink != null)
            {
                OnMouseClick = (s, ev) =>
                {
                    ProcessStartInfo sInfo = new ProcessStartInfo(e.TargetLink);
                    Process.Start(sInfo);
                };
            }
            else
            {
                OnMouseClick = (s, ev) =>
                {
                    // Swith to the target
                    SwitchPanel(e.Target);

                    // if the entry is not a child: unexpand everything
                    if (!e.IsExpanded && e.parent == null)
                    {
                        // close everything opened on the sidebar
                        // (we don't care if the entry has children or not, close anyway)
                        UnexpandSidebarEntries();
                    }

                    if (e.children != null && e.children.Length > 0)
                    {
                        // set the children visible
                        e.IsExpanded = !e.IsExpanded;
                        ToggleSidebarChildren(e.children, e.IsExpanded);
                    }
                };
            }

            // set the inactive color to the whole container
            entry_layout.ForeColor = this.BaseSidebarEntryColor;

            // assign the events to EVERY component of the entry
            entry_layout.MouseEnter += OnMouseEnter;
            entry_layout.MouseLeave += OnMouseLeave;
            entry_layout.Click += OnMouseClick;

            EntryIcon.MouseEnter += OnMouseEnter;
            EntryIcon.MouseLeave += OnMouseLeave;
            EntryIcon.Click += OnMouseClick;

            EntryText.MouseEnter += OnMouseEnter;
            EntryText.MouseLeave += OnMouseLeave;
            EntryText.Click += OnMouseClick;
            // ----

            // The inner layout is gonna contain in the following order:
            // [Label: ICON] [Label: Text]
            // So we put the layout's direction in Left to Right
            entry_layout.FlowDirection = FlowDirection.LeftToRight;

            // [Label: ICON] [Label: Text]
            entry_layout.Controls.Add(EntryIcon);
            entry_layout.Controls.Add(EntryText);

            // spacing between every entry is of 15px (margin bottom = 15)
            entry_layout.Margin = new Padding(0, 0, 0, 15);

            // the icon's label is a square of 30x30
            EntryIcon.AutoSize = false;
            EntryIcon.Height = EntryIcon.Width = 30;

            // Auto resize the text label
            EntryText.AutoSize = true;

            // align everything on top-left
            EntryText.TextAlign = EntryIcon.TextAlign = ContentAlignment.TopLeft;

            // XXX: we probably don't need this line anymore
            EntryText.Height = EntryIcon.Height;

            // set the icon's label in MaterialFont
            EntryIcon.Font = this.IconFont;

            // Convert the UTF-8 byte array to String
            EntryIcon.Text = e.Icon != null ? Encoding.UTF8.GetString(e.Icon) : "";

            // Make the entry's text (entry name) label bigger
            EntryText.Font = new Font("Microsoft Sans Serif", 14.0f, FontStyle.Regular, GraphicsUnit.Point);
            EntryText.Text = e.Text;

            // set the layout's height at the same height of the icon
            entry_layout.Height = EntryIcon.Height;
            e._OwnerController = entry_layout;

            return entry_layout;
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
        private void GenerateSidebarContent(FlowLayoutPanel TargetLayout, SidebarEntry[] RootEntries)
        {
            FlowLayoutPanel child;

            // we now start to append every entry from the attribute `SidebarEntries`
            foreach (SidebarEntry ParentEntry in RootEntries)
            {
                // append the entry to the sidebar
                TargetLayout.Controls.Add(this.GenerateSidebarEntry(ParentEntry));

                if (ParentEntry.children != null)
                {
                    // generate the children
                    foreach (SidebarEntry ChildEntry in ParentEntry.children)
                    {
                        // put the child's container invisible (not expanded)
                        child = this.GenerateSidebarEntry(ChildEntry);
                        child.Visible = false;

                        // append the child to the main container
                        TargetLayout.Controls.Add(child);
                    }
                }
            }
        }

        private void UpdateSidebar(MultiPaneControl sender, SidebarEntry[] entries)
        {
            if (entries == null)
            {
                return;
            }

            foreach (SidebarEntry e in entries)
            {
                if (e.Target != null && e._OwnerController.GetType() == typeof(FlowLayoutPanel))
                {
                    if (sender.SelectedPage == e.Target)
                    {
                        ((FlowLayoutPanel)e._OwnerController).ForeColor = this.ActiveBaseSidebarEntryColor;
                        e.IsActive = true;
                    }
                    else
                    {
                        ((FlowLayoutPanel)e._OwnerController).ForeColor = this.BaseSidebarEntryColor;
                        e.IsActive = false;
                    }
                }
            }
        }

        private void ContentPanel_SelectedPageChanged(object _s, EventArgs e)
        {
            MultiPaneControl sender = _s as MultiPaneControl;
            if (sender.SelectedPage == null)
            {
                return;
            }

            UpdateSidebar(sender, this.TopSidebarEntries);
            UpdateSidebar(sender, this.BottomSidebarEntries);

            this.Text = this.BaseName + " - " + sender.SelectedPage.AccessibleName;
            this.Refresh();
        }
    }
}
