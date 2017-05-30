using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using System.Windows.Forms;
using BreakingBudget.Views;

namespace BreakingBudget.Services.Lang
{
    public static class ErrorManager
    {
        public enum REPOSITORY_ERROR
        {
            DUPLICATE
        }

        // TODO: show the data in a TextBox
        // (generated using a center with a padding of 40 chars and a dash sep. `.center(40, '-')`
        //  Thanks Python2, da real MVP <3)
        public static void HandleOleDBError(OleDbException e)
        {
            FatalErrorReporter errorReporter;
            StringBuilder collectedErrorData = new StringBuilder();

            // ole db exception
            // error collection sample
            collectedErrorData.AppendLine("------- A DB EXCEPTION OCCURRED --------");
            for (int i = 0; i <= e.Errors.Count - 1; i++)
            {
                collectedErrorData.AppendLine(
                    string.Format("----------------- {0:000} ------------------", i)
                );
                collectedErrorData.AppendLine("Message: " + e.Errors[i].Message);
                collectedErrorData.AppendLine("Native: " + e.Errors[i].NativeError.ToString());
                collectedErrorData.AppendLine("Source: " + e.Errors[i].Source);
                collectedErrorData.AppendLine("SQL: "    + e.Errors[i].SQLState);
            }
            collectedErrorData.AppendLine("---------------- STACK -----------------");
            collectedErrorData.AppendLine(e.StackTrace);
            collectedErrorData.AppendLine("----------------- END ------------------");

            Console.WriteLine(collectedErrorData);
            errorReporter = new FatalErrorReporter(collectedErrorData.ToString());
            errorReporter.ShowDialog();
        }

        #region success
        public static DialogResult EntriesSuccessfullyAdded(IWin32Window owner)
        {
            return MetroMessageBox.Show(owner,
                Program.settings.localize.Translate("msg_entries_successfully_added_msg"),
                Program.settings.localize.Translate("msg_entries_successfully_added_caption"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        #endregion

        #region fieldErrors
        public static DialogResult ShowMissingFieldsError(IWin32Window owner)
        {
            return MetroMessageBox.Show(owner,
                Program.settings.localize.Translate("err_missing_fields_msg"),
                Program.settings.localize.Translate("err_missing_fields_caption"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        public static DialogResult ShowNotANumberError(IWin32Window owner)
        {
            return MetroMessageBox.Show(owner,
                Program.settings.localize.Translate("err_not_a_valid_number"),
                Program.settings.localize.Translate("err_uh_oh_caption"),
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowDuplicateError(IWin32Window owner)
        {
            return MetroMessageBox.Show(owner,
                Program.settings.localize.Translate("err_duplicate_value"),
                Program.settings.localize.Translate("err_duplicate_value_caption"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        public static DialogResult ShowDuplicateError(IWin32Window owner, string field)
        {
            return MetroMessageBox.Show(owner,
                Program.settings.localize.Translate("err_duplicate_value_{0}", field),
                Program.settings.localize.Translate("err_duplicate_value_caption"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
        #endregion
    }
}
