using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakingBudget.Views
{
    public partial class Loading : Form
    {
        readonly string[] loadingSequences = new string[]
        {
            "?", ".", "-", "!", "ツ"
        };

        bool isLoading = true;
        public Loading()
        {
            InitializeComponent();
        }

        async private void PutLoadingChars()
        {
            var random = new Random();
            while (this.isLoading)
            {
                await Task.Delay(500);
                this.lblLoadingSymbols.Text = this.loadingSequences[
                    random.Next(loadingSequences.Length)
                ];
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            PutLoadingChars();
        }

        private void Loading_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.isLoading = false;
        }
    }
}
