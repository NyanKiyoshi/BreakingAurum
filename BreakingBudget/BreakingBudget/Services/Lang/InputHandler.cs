using MetroFramework.Controls;
using System.Windows.Forms;

namespace BreakingBudget.Services.Lang
{
    public static class InputHandler
    {


        public static void AllowKeyPressAFloat(object s, KeyPressEventArgs e)
        {
            e.Handled = !(
                IsTextBoxKeyPressNumber((MetroTextBox)s, e.KeyChar)
            );
        }

        public static void AllowKeyPressAPositiveFloat(object s, KeyPressEventArgs e)
        {
            e.Handled = !(
                IsTextBoxKeyPressNumber((MetroTextBox)s, e.KeyChar, true, false)
            );
        }

        public static void AllowKeyPressAInteger(object s, KeyPressEventArgs e)
        {
            e.Handled = !(
                IsTextBoxKeyPressNumber((MetroTextBox)s, e.KeyChar, false)
            );
        }

        public static void AllowKeyPressANonNegativeInteger(object s, KeyPressEventArgs e)
        {
            e.Handled = !(
                IsTextBoxKeyPressNumber((MetroTextBox)s, e.KeyChar, false, false)
            );
        }

        public static bool IsTextBoxKeyPressNumber(MetroTextBox sender, char KeyChar,
            bool allowFloat = true,
            bool allowNegatives = true)
        {
            return (
                // is the char (not) a number?
                char.IsNumber(KeyChar)

                // or (not) a backspace?
                || KeyChar == (char)Keys.Back

                // or (not) a unique dot?
                || (allowFloat && (KeyChar == '.' || KeyChar == ',')
                                && (!sender.Text.Contains(".") && !sender.Text.Contains(",")))

                // ...or (not) a unique minus at the beginning of the line? (is the cursor not at the beginning)
                || (allowNegatives && KeyChar == '-' && (!sender.Text.Contains("-")) && sender.SelectionStart == 0)
            );
        }
    }
}
