using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using BreakingBudget.Services.PDF;
using BreakingBudget.Services.Lang;
using BreakingBudget.Repositories;

namespace BreakingBudget.Views
{
    public class UnableToSummonDaCatException : System.Exception {
        public UnableToSummonDaCatException() : base("im in ur computer makin ur wannacry worm") { }
    }

    public partial class TransactionsToPDF : MetroForm
    {
        public TransactionsToPDF()
        {
            InitializeComponent();


            // retrieve the set of translations for this form
            Program.settings.localize.ImportResourceLocalization("PDFTransactions");

            // inherit theme from settings
            this.metroStyleExtender.StyleManager = Program.settings.styleManager;
            this.StyleManager = this.metroStyleManager;
            this.StyleManager.Theme = Program.settings.styleManager.Theme;
            this.StyleManager.Style = Program.settings.styleManager.Style;

            this.Text = Program.settings.localize.Translate(this.Name);
            Program.settings.localize.ControlerTranslator(this);

            this.txtBoxYear.Text = System.DateTime.Today.Year.ToString();

            comboBoxMonth.Items.Clear();
            for (int i = 1; i < 13; ++i)
            {
                comboBoxMonth.Items.Add(Program.settings.localize.Translate("month_id_" + i));
            }
            comboBoxMonth.SelectedIndex = 0;
        }

        // TODO: PUT A LOGO!
        public static void GetCSSMeta(StringBuilder output)
        {
            output.AppendLine(@"
        <style type='text/css'>
            body {
                font-family: 'Lato','proxima-nova','Helvetica Neue',Arial,sans-serif;
                font-weight: normal;
                color: #404040;
                font-size: 16px;
                max-width: 22cm;
                margin: 0 auto;
            }

            table {
                margin-bottom: 14px;
                border-collapse: collapse;
                border-spacing: 0;
                /*width: 100%;*/
            }

            table tr {
                border-top: 1px solid #CCC;
            }

            .th-line-title {
                background: rgba(0,0,0,0.1);
            }

            table th {
                font-weight: bold;
            }

            table th, table td {
                border: 1px solid #DDD;
                padding: 6px 13px;
            }

            h2 {
                margin-top: 0;
                font-size: 150%;
                display: block;
            }

            h1, h2 {
                text-align: center;
                margin: 30px 0;
                font-weight: 700;
            }

            h1 span.light {
                font-size: 70%;
            }

            th, td {
                text-align: center;
                min-height: 30px;
            }

            td.hr {
                border: none;
                padding-top: 1em;
            }

            .left {
                text-align: left;
            }

            .amount::after {
                content: '\20\20AC'
            }

            table.bold-table tr td:first-child {
                font-weight: 700;
                text-align: right;
            }

            table.bold-table tr td:last-child {
                padding: 0 1.5em;
            }

            table.bold-table tfoot {
                font-weight: 700;
            }

            hr {
                border: 1px solid #e3e3e3;
                background: #FFF;
                margin: 3em 0;
                padding: 0;
            }

            .no {
                background-image: url('data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAGQAAABkCAYAAABw4pVUAAAACXBIWXMAAAABAAAAAQBPJcTWAAAAH3RFWHRUaXRsZQBNVUxUSVBMSUNBVElPTiBYIChVKzI3MTUpPpWZ6AAAABV0RVh0QXV0aG9yAEFuZHJldyBNYXJjdXNl5zc3gwAAAC90RVh0U29mdHdhcmUAaW5mby5maWxlZm9ybWF0LmRhdGEuVW5pY29kZVBuZ1NlcnZsZXRoAX8wAAAAQnRFWHREZXNjcmlwdGlvbgBodHRwOi8vd3d3LmZpbGVmb3JtYXQuaW5mby9pbmZvL3VuaWNvZGUvMjcxNS9pbmRleC5odG2a0vdeAAAAO3RFWHRDb3B5cmlnaHQAaHR0cDovL2NyZWF0aXZlY29tbW9ucy5vcmcvbGljZW5zZXMvYnktbmMtc2EvMi4wL2yIkoMAAAF9SURBVHja7dzRSsJQAMfhQ/RWXYTQK8SQEBlCD9R9dBmMkN7QFuSNoE5a89/O98G5P/qbx7kdVwoAAAAAAAAAAAAAULP78Pnd9eO2lhjv/dj1ow2d3+PP/LY1xdiFRmkO5retKUZalObI/Lo5xng48mJTojRn5reYY5Tn0CjnYmzmvGxtwqJUHWOvDYmyFCMnihhBUcQ4YT1xFDEGWE0U5UmMnChiBEUR4w+P5FaM6S1HirISIyfKWoycKGIERWnFyIkiRlCUVzHyoojxD6KIERRFjAm9DPhOYSLNwE9I663KiSFK8FmWKFeI8SZKTozNwF/qokwYo4iSF2NvJcr4fnunT5SgGKIExhAlMIYogTGGniCIcsERPNZVW1GCYogywLV2h4gSFEOUwBiiXHCtaerbrlVHSd03VWWURcnekHAuyiz/p96V7N0hx6J8zHnZ6kr2Vp3DKFU8gKYr2fum9lE++3FTy6lv+pr8/Tyvap6XBQAAAAAAAAAAjOoLIteLhEAwPmAAAAAASUVORK5CYII=');
                background-size: 30px, auto;
                background-position: center;
                background-repeat: no-repeat;
            }

            .yes {
                background-image: url('data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAGQAAABkCAYAAABw4pVUAAAACXBIWXMAAAABAAAAAQBPJcTWAAAAGXRFWHRUaXRsZQBDSEVDSyBNQVJLIChVKzI3MTMpi24hYgAAABV0RVh0QXV0aG9yAEFuZHJldyBNYXJjdXNl5zc3gwAAAC90RVh0U29mdHdhcmUAaW5mby5maWxlZm9ybWF0LmRhdGEuVW5pY29kZVBuZ1NlcnZsZXRoAX8wAAAAQnRFWHREZXNjcmlwdGlvbgBodHRwOi8vd3d3LmZpbGVmb3JtYXQuaW5mby9pbmZvL3VuaWNvZGUvMjcxMy9pbmRleC5odG1yZz0dAAAAO3RFWHRDb3B5cmlnaHQAaHR0cDovL2NyZWF0aXZlY29tbW9ucy5vcmcvbGljZW5zZXMvYnktbmMtc2EvMi4wL2yIkoMAAAKRSURBVHja7dw/SFtRFMfxRxGRIEIpUhzETYJTFofi0EU6FAcXEYciEhAREREhiHQQcXEQB3ETEQfBQcShS6fiIAEHR3ERkQyhEMRBJAjxXHhCBvvOveblKPT7gTNpMvx+3Pf3ahQBAAAAAAAAAAAAAAAAAADgbXTKfJeZldmV+SVTkanKlInHzpzMhUwtYQrE1HxtMsdKEbV4xaDJ2mVOPMoYJyqblfHHo4wJorJx5FHGFDHZWPMoY5mYbIx5lLFNTDb6ZO6VMn4Tk42Mx33GpcxHorKxo5RxJ9NLTO/nvDFMTDa6ZW6VMjaIyY5283cq84GYbBSUMm7jFQSjS9wHpZBRYrLhDkHnShl7xGRnSSnjRqaDmGxkPQ5V34jJjvZ+Y4uI7OSVMkocqux8kvmrFDJETHa2lDL2ichOzuMG8DMx2TlVCpkhIjsjShnnRGSnVeZKKWSAmOwsKmUcEJEd96q1klCG24vbQ0x2VpXVsUpEdrqi5OdVFe7IbW0oq2OBiPxNxpei7hjvtuW4R+WZgM+7N3yPUfKj9VZi1vVG/35pdC3z1fN7NrkJbFyfckX0PPkGV4crlg0LKTza8C1lXfnsNFH7uQ8oxM3gC9/RqVxZlVgd/nYCCynHl7b1lpXPzBNz2F31dWAp9bvQM8o5yP2sjZjDZD1P7PXzI/7snPJ7K8T7Ol8CzyfleHUlPdGtvnB4Q4ChwFVypvx8l0gbtxRYStL0E2c6DlMoo0iM6XF/tH/ZYCF5YkxXTnkUUlMudVuIMH2LryxkjeiapxhYhltVvJ5t8k3jQ0AhbF54Z4euHHHZ8PnvPOzRNeR2sLsnw6X4EPY8bm+ue9j4Mwp73QsAAAAAAAAAAAAAAAD8J54AP01JB1vpm6sAAAAASUVORK5CYII=');
                background-size: 30px, auto;
                background-position: center;
                background-repeat: no-repeat;
            }
        </style>");
        }

        public void GetPageTitle(int month, int transactionCount, StringBuilder output)
        {
            output.AppendFormat("<h1>{0} &mdash; <span class='light'>{1}</span></h1>",
                string.Format(
                    Program.settings.localize.Translate("summary_of_the_month_{0}"),
                    Program.settings.localize.Translate("of_the_month_id_" + month)
                ),
                FormatTransactionCount(transactionCount)
            );
        }

        public string GetFileNameFromMonth(int month)
        {
            return string.Format(
                Program.settings.localize.Translate("filename_summary_of_the_month_{0}"),
                Program.settings.localize.Translate("of_the_month_id_" + month)
            ) + ".pdf";
        }

        public string FormatTransactionCount(int transactionCount)
        {
            return string.Format(
                transactionCount > 1
                ? Program.settings.localize.Translate("{0}_transactions")  // plural
                : Program.settings.localize.Translate("{0}_transaction"),  // singular
                transactionCount
            );
        }

        public void PrintToPDDF(int month, int year)
        {
            int i;
            int entry_index;
            TransactionRepository.TransactionModel[] _transactions = null;

            // the sum of every transaction in the current groupe
            decimal group_total;
            decimal group_spendings;
            decimal group_received_incomes;
            decimal group_pending_incomes;

            // the sum of every group's amount
            decimal total_amount = 0.0M;
            decimal total_spendings = 0.0M;
            decimal total_received_incomes = 0.0M;
            decimal total_pending_incomes = 0.0M;

            // a temporary set of HTML rows
            StringBuilder currentEntryRow_str;

            // TODO: check if destination file is being used or not
            //   QPainter::begin(): Returned false============================] 100%
            //   Error: Unable to write to destination
            //   Exit with code 1, due to unknown error.
            PdfDocument doc = new PdfDocument();

            // retrieve every transaction of the current month
            try
            {
                _transactions = TransactionRepository.GetByMonth(month, year);
            }
            catch (OleDbException ex)
            {
                // abort if there was an error
                ErrorManager.HandleOleDBError(ex);
                return;
            }

            // Group each transaction by type
            IGrouping<int, TransactionRepository.TransactionModel>[] transactionsGroups = _transactions.GroupBy(x => x.type).ToArray();

            // the HTML headings
            StringBuilder s = new StringBuilder(@"<!DOCTYPE html>
            <html>
                <head>
                    <meta charset='utf-8' />
                    <title></title>"
            );

            GetCSSMeta(s);

            GetPageTitle(month, _transactions.Length, s);

            // TODO: translate
            // Table header's row
            s.Append(@"
                </head>
                <body><table>
            ");

            i = 0;
            foreach (IGrouping<int, TransactionRepository.TransactionModel> transactions in transactionsGroups)
            {
                ++i;
                entry_index = 0;

                group_total = 0.0M;
                group_spendings = 0.0M;
                group_received_incomes = 0.0M;
                group_pending_incomes = 0.0M;

                currentEntryRow_str = new StringBuilder();

                var it = transactions.GetEnumerator();

                while (it.MoveNext())
                {
                    ++entry_index;

                    currentEntryRow_str.AppendFormat(@"
                        <tr>
                            <td>{0}</td>
                            <td class='amount'>{1}</td>
                            <td class='{2}'></td>
                            <td class='{3}'></td>
                            <td class='left'>{4}</td>
                        </tr>
                        ",
                        it.Current.dateTransaction.ToString(Program.settings.localize.Translate("dd/MM/yyyy")),
                        it.Current.montant,
                        it.Current.recetteON ? "yes" : "no",
                        it.Current.percuON ? "yes" : "no",
                        string.IsNullOrWhiteSpace(it.Current.description) ? "-" : it.Current.description
                    );

                    // if it is an income
                    if (it.Current.recetteON)
                    {
                        // look if he received the income or not and append it
                        if (it.Current.percuON)
                        {
                            group_received_incomes += it.Current.montant;

                            // add the income the group income
                            group_total += it.Current.montant;
                        }
                        else
                        {
                            group_pending_incomes = it.Current.montant;
                        }
                    }
                    // otherwise, it is a spending, a loss.
                    else
                    {
                        group_spendings += it.Current.montant;

                        // if the value is negative, make it positive
                        group_total -= it.Current.montant > 0 ? it.Current.montant : it.Current.montant * -1;
                    }
                }

                s.AppendFormat(@"
                    <tr><td class='hr' colspan='5'></td></tr>
                    <tr>
                        <th colspan='5' class='th-line-title'>
                            <h2 style='margin: 0'>{0}</h2>
                            {1}, <span class='amount'>{2}</span>
                        </th>
                    </tr>
                ", it.Current.typeTransaction_s, FormatTransactionCount(entry_index), group_total);

                // if we are proceeding the first entry, append the legend
                if (i == 1)
                {
                    s.Append(@"
                    <tr>
                        <th>Date de transaction</th>
                        <th>Montant</th>
                        <th>Recette</th>
                        <th>Perçu</th>
                        <th width='100%'>Description</th>
                    </tr>");
                }

                // append the entries
                s.Append(currentEntryRow_str);

                total_amount += group_total;
                total_pending_incomes += group_pending_incomes;
                total_received_incomes += group_received_incomes;
                total_spendings += group_spendings;
            }

            s.AppendFormat(@"
                    </table>
                    <hr/>
                    <table class='bold-table'>
                        <tr>
                            <td>Dépenses</td>
                            <td class='amount'>{0}</td>
                        </tr>

                        <tr>
                            <td>Recettes</td>
                            <td class='amount'>{1}</td>
                        </tr>

                        <tr>
                            <td>À percevoir</td>
                            <td class='amount'>{2}</td>
                        </tr>

                        <tfoot>
                            <tr>
                                <td>Total</td>
                                <td class='amount'>{3}</td>
                            </tr>
                        </tfoot>
                    </table>
                </body>
            </html>", total_spendings, total_received_incomes, total_pending_incomes, total_amount);

            // set the default filename
            saveFileDialog.FileName = GetFileNameFromMonth(month);

            // TODO: try-catch
            // ask where to save the PDF file
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                doc.Html = s.ToString();
                WkHtmlWkHtmlPdfConverter.ConvertHtmlToPdf(doc, saveFileDialog.FileName);

                // open the PDF file
                Process.Start(saveFileDialog.FileName);
            }
        }

        private void btnExport_Click(object sender, System.EventArgs e)
        {
            int year;
            if (!LocalizationManager.ConvertFloatingTo<int>(this.txtBoxYear.Text, int.TryParse, out year))
            {
                ErrorManager.ShowNotANumberError(this);
                return;
            }

            // this code spawned itself from nowhere idk why
            try {
                if (year == 666)
                {
                    throw new UnableToSummonDaCatException();
                }
            }
            catch (UnableToSummonDaCatException ex)
            {
                ErrorManager.HandleBaseException(ex);
                return;
            }

            PrintToPDDF(this.comboBoxMonth.SelectedIndex + 1, year);
        }
    }
}
