using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Kerido.Controls;
using System.Collections.Generic;
using BreakingBudget.Services;
using BreakingBudget.Structural;

namespace BreakingBudget.Views.FrmMain
{
    partial class FrmMain
    {
        private readonly Padding BaseEntryMargin = new Padding(0, 0, 0, 15);

        // the default text color and the active & hover one
        Color BaseSidebarEntryColor = Color.FromArgb(117, 117, 117);
        Color ActiveBaseSidebarEntryColor = Color.FromArgb(0, 0, 0);

        // List of the sub-sidebars (FIXME: should take a FlowLayout this.SidebarTopFlowLayout, ...)
        SidebarEntry[][] SidebarsRootEntries;

        private void GenerateSidebar(SidebarEntry[][] SidebarsRootEntries)
        {
            this.SidebarsRootEntries = SidebarsRootEntries;

            // Set the sidebar background as the same as the form's one
            this.SidebarTable.BackColor = this.BackColor;
            this.SidebarTopFlowLayout.BackColor = this.BackColor;
            this.SidebarBottomFlowLayout.BackColor = this.BackColor;

            this.SidebarTable.Padding = new Padding(0, 0, 10, 0);
            this.SidebarTable.Margin = new Padding(0);

            this.SidebarTopFlowLayout.FlowDirection = FlowDirection.TopDown;
            this.SidebarBottomFlowLayout.FlowDirection = FlowDirection.BottomUp;

            // Generate every sub-sidebar
            GenerateSidebarContent(this.SidebarTopFlowLayout, this.TopSidebarEntries);
            GenerateSidebarContent(this.SidebarBottomFlowLayout, this.BottomSidebarEntries);
        }

        // Change the form's current page
        private void SwitchPanel(MultiPanePage target)
        {
            this.ContentPanel.SelectedPage = target;
        }

        // Toggle every child visibility
        private void ToggleSidebarChildren(SidebarEntry[] children, bool Visible)
        {
            foreach (SidebarEntry child in children)
            {
                child._OwnerController.Visible = Visible;
            }
        }

        // Hide every root's children
        private void UnexpandSidebarEntries()
        {
            // Process every sub-sidebar
            foreach (SidebarEntry[] SidebarRootEntries in this.SidebarsRootEntries)
            {
                // Process every entry
                foreach (SidebarEntry ParentEntry in this.GoThroughEntries(SidebarRootEntries))
                {
                    // If the entry has children
                    if (ParentEntry.children != null)
                    {
                        // Set every child as hidden
                        ToggleSidebarChildren(ParentEntry.children, false);
                    }
                    // Mark the entry as unexpanded
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
                // change the entry color to the active one
                entry_layout.ForeColor = this.ActiveBaseSidebarEntryColor;
            };

            OnMouseLeave = (s, ev) =>
            {
                // put the inactive color on mouse leave if and only if
                //   the entry is not marked as active
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
                    if (e.Target != null)
                    {
                        // Swith to the target
                        SwitchPanel(e.Target);
                    }

                    // if the entry is not a child: unexpand everything
                    if (!e.IsExpanded && e.parent == null)
                    {
                        // close everything opened on the sidebar
                        // (we don't care if the entry has children or not, close anyway)
                        UnexpandSidebarEntries();
                    }

                    // if the entry has children: toggle the children' visibility
                    if (e.children != null && e.children.Length > 0)
                    {
                        // set the children visible
                        e.IsExpanded = !e.IsExpanded;
                        ToggleSidebarChildren(e.children, e.IsExpanded);
                    }
                };
            }

            // Set the container layout to AutoSize to allow the sidebar to be able to resize itself
            // + disallow content wrapping to force the layout to resize itself, provoking the sidebar to grow
            entry_layout.AutoSize = true;
            entry_layout.WrapContents = false;
            
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
            entry_layout.Margin = new Padding(this.BaseEntryMargin.Left, this.BaseEntryMargin.Top,
                                              this.BaseEntryMargin.Right, this.BaseEntryMargin.Bottom);

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
            EntryText.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Regular, GraphicsUnit.Point);
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
            FlowLayoutPanel ChildLayout;

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
                        ChildLayout = this.GenerateSidebarEntry(ChildEntry);
                        ChildLayout.Visible = false;

                        // append the child to the main container
                        TargetLayout.Controls.Add(ChildLayout);
                    }
                }
            }
        }

        // Toggle the active state of a given entry and thus the color
        private void ToggleEntryActive(SidebarEntry e, bool active)
        {
            e._OwnerController.ForeColor = active ? this.ActiveBaseSidebarEntryColor : this.BaseSidebarEntryColor;
            e.IsActive = active;
        }

        /* Goes through every child of a given array of `SidebarEntry` following the bellow pattern.
         *  (---> / <---) (in / out)
         *  ++++++++++++++++++++++++++++++++++
         *  | <--- RootEntry1                +
         *  | ---> Children                  +
         *  |   | <--- Children1             +
         *  |   | ---> Sub-Children          +
         *  |   |   | <--- Sub-Children1     +
         *  |   |   | <--- Sub-Children2     +
         *  |   |   | <---    ...            +
         *  |   |   | <--- Sub-Children{n}   +
         *  |   |   |    | ---> ...          +
         *  |   | <--- Children2             +
         *  |   | <--- ...                   +
         *  |   | <--- Children{n}           +
         *  | <--- RootEntry2                +
         *  | ---> Children                  +
         *  |   | ...                        +
         *  | ...                            +
         *  ++++++++++++++++++++++++++++++++++
         */
        private IEnumerable<SidebarEntry> GoThroughEntries(SidebarEntry[] entries)
        {
            SidebarEntry[] CurrentEntries = entries;
            foreach(SidebarEntry e in entries)
            {
                yield return e;

                // if there are children into the current entry, proceed them
                if (e.children != null)
                {
                    foreach(SidebarEntry child in GoThroughEntries(e.children))
                    {
                        yield return child;
                    }
                }
            }
        }

        private void UpdateSidebar(MultiPaneControl sender, SidebarEntry[] entries)
        {
            // If the sub-sidebar is empty => there nothing to update, do nothing
            if (entries == null)
            {
                return;
            }

            // Will be used to update independently the entry's parents from the entrie
            // to avoid having its newly assigned status being overridden
            SidebarEntry ActiveEntry = null;

            // Will be used to go through the active entry's parents
            SidebarEntry ParentEntry;

            // Is the entry active?
            bool ActiveState;

            // Update every entry of the given sub-sidebar
            // (disclamer: we don't use a while loop there to disable every inactive state)
            foreach (SidebarEntry e in this.GoThroughEntries(entries))
            {
                ActiveState = false;
                // if the sub-sidebar entry has attached page
                if (e.Target != null)
                {
                    ActiveState = sender.SelectedPage == e.Target;
                    // if the new page is same page than the attached one:
                    //   -> change its color to the active one
                    //   -> mark the entry has active
                    // else:
                    //   -> put the inactive color
                    //   -> mark it as inactive
                    if (ActiveState)
                    {
                        ActiveEntry = e;
                    }
                }
                ToggleEntryActive(e, ActiveState);
            }

            // Proceed the active entry and its parents (if there was one)
            if (ActiveEntry != null)
            {
                // Mark the parent as active as well
                ParentEntry = ActiveEntry.parent;
                while (ParentEntry != null)
                {
                    ToggleEntryActive(ParentEntry, true);
                    ParentEntry = ParentEntry.parent;
                }
            }
        }

        private void ContentPanel_SelectedPageChanged(object _s, EventArgs _e)
        {
            MultiPaneControl sender = _s as MultiPaneControl;

            // if the page didn't change: do nothing
            if (sender.SelectedPage == null)
            {
                return;
            }

            // Update each sidebar is content
            foreach (SidebarEntry[] e in this.SidebarsRootEntries)
            {
                UpdateSidebar(sender, e);
            }

            // Update the form's title and force the repaint
            this.Text = this.BaseName + " - " + sender.SelectedPage.AccessibleName;
            this.Refresh();
        }
    }
}
