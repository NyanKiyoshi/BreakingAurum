using System.Windows.Forms;
using Kerido.Controls;

namespace BreakingBudget.Structural
{
    class SidebarEntry
    {
        private static byte[] DEFAULT_ICON = new byte[] { 0xEE, 0x97, 0x90 };
        public delegate void CallbackFunction();

        public SidebarEntry(string text)
        {
            this.Text = text;
        }

        public SidebarEntry(CallbackFunction callback, string text) : this(text)
        {
            this.TargetCallback = callback;
        }

        public SidebarEntry(CallbackFunction callback, byte[] icon, string text) : this(callback, text)
        {
            this.Icon = icon;
        }

        public SidebarEntry(CallbackFunction callback, byte[] icon, string text, SidebarEntry[] children)
            : this(callback, icon, text)
        {
            this.children = children;
        }

        public SidebarEntry(MultiPanePage target, string text) : this(text)
        {
            this.Target = target;
        }

        public SidebarEntry(MultiPanePage target, byte[] icon, string text) : this(target, text)
        {
            this.Icon = icon;
        }

        public SidebarEntry(MultiPanePage target, byte[] icon, string text, SidebarEntry[] children) : this(target, icon, text)
        {
            this.children = children;
        }

        // A UTF8 char array representing a Google Material icon
        public byte[] Icon;

        // The entry's name
        public string Text { get; set; }

        // The entry's target
        public MultiPanePage Target { get; set; }

        // The entry's target url
        public CallbackFunction TargetCallback { get; set; }

        // The children nodes.
        private SidebarEntry[] _children;
        public SidebarEntry[] children
        {
            get { return this._children; }
            set
            {
                foreach (SidebarEntry child in value)
                {
                    child._parent = this;
                }
                this._children = value;
            }
        }

        public bool IsActive { get; set; }
        public bool IsExpanded = false;

        private SidebarEntry _parent;
        public SidebarEntry parent { get { return this._parent; } }

        // The controller storing/ using the data
        public FlowLayoutPanel _OwnerController { get; set; }
    }
}
