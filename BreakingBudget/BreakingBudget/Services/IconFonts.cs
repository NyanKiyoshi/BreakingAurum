using System.Drawing;
using System.Drawing.Text;


namespace BreakingBudget.Services
{
    class IconFonts
    {
        readonly private PrivateFontCollection Fonts;
        public enum FONT_FAMILY
        {
            MaterialIcons
        }

        public IconFonts()
        {
            this.Fonts = CreateFontCollection();
        }

        // Load the icon font from the embedded resources
        private PrivateFontCollection CreateFontCollection()
        {
            PrivateFontCollection CustomFonts = new PrivateFontCollection();
            CustomFonts.AddFontFile("Resources\\MaterialIcons-Regular.ttf");
            return CustomFonts;
        }

        public Font GetFont(FONT_FAMILY family, float size, FontStyle style)
        {
            return new Font(Fonts.Families[(int)family], size, style, GraphicsUnit.Point);
        }

        public Font GetFont(FONT_FAMILY family, float size)
        {
            return GetFont(family, size, FontStyle.Regular);
        }
    }
}
