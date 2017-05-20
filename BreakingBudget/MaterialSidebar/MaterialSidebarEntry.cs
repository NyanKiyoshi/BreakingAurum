using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialSidebar
{
    public struct MaterialSidebarEntry
    {
        // A function called to make a decision on every update (see bellow).
        public delegate bool CustomEntryCondition();

        // A UTF16 char representing a Google Material icon
        private byte[] icon;
        public byte[] Icon
        {
            get
            {
                return this.icon;
            }

            set
            {
                byte[] _icon = new byte[] { 0xEE, 0x97, 0x90 };
                if (value != null && value.Length > 0)
                {
                    _icon[0] = value[0];
                }
                this.icon = _icon;
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
        public MaterialSidebarEntry[] children { get; set; }
    }
}
