using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingBudget
{
    class SidebarEntry
    {
        private static byte[] DEFAULT_ICON = new byte[] { 0xEE, 0x97, 0x90 };

        public SidebarEntry(string text)
        {
            this.Text = text;
        }

        public SidebarEntry(byte[] icon, string text) : this(text)
        {
            this.Icon = icon;
        }

        // A function called to make a decision on every update (see bellow).
        public delegate bool CustomEntryCondition();

        // A UTF8 char array representing a Google Material icon
        private byte[] _icon;
        public byte[] Icon {
            get
            {
                return (this._icon != null) ? this._icon : SidebarEntry.DEFAULT_ICON;
            }
            set
            {
                this._icon = value;
            }
        }

        // The entry's name
        public string Text { get; set; }

        // Event to be called on click
        public EventHandler OnClick { get; set; }

        // A custom function to pass.
        // If it returns true, it means that the entry should be put in active state.
        // Otherwise (false), inactive.
        public CustomEntryCondition isActive { get; set; }

        // A custom function to pass.
        // If it returns true, it means that we must make it visible.
        // Otherwise (false), we hide it.
        public CustomEntryCondition IsVisible { get; set; }

        // The children nodes.
        public SidebarEntry[] children { get; set; }
    }
}
