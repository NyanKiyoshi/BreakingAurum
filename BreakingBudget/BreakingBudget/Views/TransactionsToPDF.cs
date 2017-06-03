using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using BreakingBudget.Services.PDF;
using BreakingBudget.Repositories;

namespace BreakingBudget.Views
{
    public partial class TransactionsToPDF : MetroForm
    {
        public void GetCSSMeta(StringBuilder output)
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

        public void GetPageTitle(string month, int transactionCount, StringBuilder output)
        {
            output.AppendFormat("<h1>{0} &mdash; <span class='light'>{1}</span></h1>",
                string.Format(
                    Program.settings.localize.Translate("summary_of_the_month_{0}"),
                    Program.settings.localize.Translate("of_" + month)
                ),
                string.Format(
                    transactionCount > 1
                    ? Program.settings.localize.Translate("{0}_transactions")  // plural
                    : Program.settings.localize.Translate("{0}_transaction"),  // singular
                    transactionCount
                )
            );
        }

        public TransactionsToPDF(int month = 2, int year = 2017)
        {
            // TODO: check if destination file is being used or not
            //   QPainter::begin(): Returned false============================] 100%
            //   Error: Unable to write to destination
            //   Exit with code 1, due to unknown error.
            InitializeComponent();

            Program.settings.localize.ImportResourceLocalization("PDFTransactions");
            PdfDocument doc = new PdfDocument();


            TransactionRepository.TransactionModel[] _transactions = TransactionRepository.GetByMonth(month, year);

            // Group each transaction by type
            IGrouping<int, TransactionRepository.TransactionModel>[] tr = _transactions.GroupBy(x => x.type).ToArray();

            doc.Html = this.richTextBox.Text = "";
            StringBuilder s = new StringBuilder(@"<!DOCTYPE html>
<html>
    <head>
        <meta charset='utf-8' />
        <title>{Transaction of {0}}</title>
    </head>

    <body>");

            GetPageTitle("april", _transactions.Length, s);

            //        <table>
            //            <tr>
            //                <th colspan='5' class='th-line-title'>
            //                    <h2 style='margin: 0'>Essence</h2>
            //                    3 transactions, <span class='amount'>220.65</span>
            //                </th>
            //            </tr>
            //            <tr>
            //                <th>Date de transaction</th>
            //                <th>Montant</th>
            //                <th>Recette</th>
            //                <th>Perçu</th>
            //                <th width='100%'>Description</th>
            //            </tr>
            //            <tr>
            //                <td>04/04/2017</td>
            //                <td class='amount'>54.20</td>
            //                <td class='yes'></td>
            //                <td class='yes'></td>
            //                <td class='left'>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
            //                tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
            //                quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo
            //                consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse
            //                cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non
            //                proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</td>
            //            </tr>

            //            <tr>
            //                <td>20/04/2017</td>
            //                <td class='amount'>98.56</td>
            //                <td class='no'></td>
            //                <td class='no'></td>
            //                <td class='left'>Essence de la semaine</td>
            //            </tr>

            //            <tr>
            //                <td>27/04/2017</td>
            //                <td class='amount'>67.89</td>
            //                <td class='no'></td>
            //                <td class='no'></td>
            //                <td class='left'>Essence de la semaine</td>
            //            </tr>

            //            <tr>
            //                <td class='hr' colspan='5'></td>
            //            </tr>

            //            <tr>
            //                <th colspan='5' class='th-line-title'>
            //                    <h2 style='margin: 0'>Vêtements</h2>
            //                    1 transaction, <span class='amount'>220.65</span>
            //                </th>
            //            </tr>

            //            <tr>
            //                <td>28/04/2017</td>
            //                <td class='amount'>154.00</td>
            //                <td class='no'></td>
            //                <td class='no'></td>
            //                <td class='left'>Jeans</td>
            //            </tr>
            //        </table>

            //        <hr />

            //        <table class='bold-table'>
            //            <tr>
            //                <td>Dépenses</td>
            //                <td class='amount'>54.20</td>
            //            </tr>

            //            <tr>
            //                <td>Recettes</td>
            //                <td class='amount'>54.2</td>
            //            </tr>

            //            <tr>
            //                <td>À percevoir</td>
            //                <td class='amount'>0.00</td>
            //            </tr>

            //            <tfoot>
            //                <tr>
            //                    <td>Total</td>
            //                    <td class='amount'>-320.45</td>
            //                </tr>
            //            </tfoot>
            //        </table>
            //    </body>
            //</html>");

            this.richTextBox.Text = s.ToString();
            //WkHtmlWkHtmlPdfConverter.ConvertHtmlToPdf(doc, "out.pdf");
        }
    }
}
