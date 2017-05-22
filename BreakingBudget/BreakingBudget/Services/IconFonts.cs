using System.Drawing;
using System.Drawing.Text;


namespace BreakingBudget.Services
{
    static class IconFonts
    {
        static readonly private PrivateFontCollection Fonts = CreateFontCollection();
        public enum FONT_FAMILY
        {
            MaterialIcons
        }

        // Load the icon font from the embedded resources
        static private PrivateFontCollection CreateFontCollection()
        {
            PrivateFontCollection CustomFonts = new PrivateFontCollection();
            CustomFonts.AddFontFile("MaterialIcons-Regular.ttf");
            return CustomFonts;
        }

        static public Font GetFont(FONT_FAMILY family, float size, FontStyle style)
        {
            return new Font(Fonts.Families[(int)family], size, style, GraphicsUnit.Point);
        }

        static public Font GetFont(FONT_FAMILY family, float size)
        {
            return GetFont(family, size, FontStyle.Regular);
        }
    }
}
