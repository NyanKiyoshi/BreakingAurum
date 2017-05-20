using System;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace BreakingBudget
{
    public class AutoCompleter
    {
        public delegate string[] _DataFinder(string s);
        
        // TODO: implement me (must see how others want to implement. Structs? Collections? Multidim?)
        private static string[] DataFinder(string s)
        {
            return new string[] {
                "abcdef",
                "abcdefg",
                "abcdefgh",
            };
        }

        private static void _OnTextChanged(object _s, EventArgs e, int MinLength, _DataFinder DataFinder)
        {
            TextBox sender = _s as TextBox;
            if (sender == null || sender.Text.Length < MinLength)
            {
                return;
            }

            string[] arr = DataFinder(sender.Text);

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(arr);

            sender.AutoCompleteCustomSource = collection;
        }

        /*
         * _DataFinder DataFinderFn -> take a value and returns an array of strings either from cache or db
         */
        public static void ImplementCompleter(TextBox TextBoxField, int MinLength, _DataFinder DataFinderFn)
        {
            TextBoxField.AutoCompleteMode = AutoCompleteMode.Suggest;
            TextBoxField.AutoCompleteSource = AutoCompleteSource.CustomSource;

            TextBoxField.TextChanged += (object s, EventArgs e) => _OnTextChanged(s, e, MinLength, DataFinderFn);
        }

        public static void ImplementCompleter(TextBox TextBoxField, int MinLength) /*, string[] source)*/
        {
            AutoCompleter.ImplementCompleter(TextBoxField, MinLength, AutoCompleter.DataFinder);
        }

        public static void DiscardCompleter(TextBox TextBoxField)
        {
            // TODO: implement me
        }
    }
}
