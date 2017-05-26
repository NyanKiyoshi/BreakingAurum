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
using BreakingBudget.Repositories;
using MetroFramework;

namespace BreakingBudget.Views
{
    public partial class GererPostes : MetroForm
    {
        List<PosteRepository.PosteModel> AddQueue = new List<PosteRepository.PosteModel>();

        public GererPostes()
        {
            InitializeComponent();

            this.addBtn.Text    = Program.settings.localize.Translate("Add");
            this.submitBtn.Text = Program.settings.localize.Translate("Cancel");
            this.cancelBtn.Text = Program.settings.localize.Translate("Submit");

            this.deleteToolStripMenuItem.Click += new EventHandler(this.DeleteEntries);
            this.addToolStripMenuItem.Click += new EventHandler(this.AddEntry);
            this.addBtn.Click += new EventHandler(AddEntry);
        }

        private void DeleteEntries(object s, object e)
        {
            while (this.listBoxPostes.SelectedIndices.Count > 0)
            {
                // remove from the queue if existing
                this.AddQueue.Remove(
                    (PosteRepository.PosteModel)this.listBoxPostes.Items[this.listBoxPostes.SelectedIndices[0]]);

                // then remove it from the list
                this.listBoxPostes.Items.RemoveAt(this.listBoxPostes.SelectedIndices[0]);
            }
        }

        private void AddEntry(object s, object e)
        {
            InputMessageBox inputBox = new InputMessageBox("Add", null, null);
            inputBox.ShowDialog();

            // if the user didn't cancel
            if (!inputBox.userCancelled)
            {
                if (string.IsNullOrWhiteSpace(inputBox.userInput))
                {
                    MetroMessageBox.Show(this,
                        "Invalid input", "Invalid input",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsUnique(inputBox.userInput))
                {
                    MetroMessageBox.Show(this,
                        "Duplicate value", "Duplicate value",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // create a new Poste model,
                // add the user's input to it
                PosteRepository.PosteModel newPoste = new PosteRepository.PosteModel();
                newPoste.libPoste = inputBox.userInput;

                // append the newly created Poste to the list and to the queue
                this.listBoxPostes.Items.Add(newPoste);
                this.AddQueue.Add(newPoste);
            }
        }

        private bool IsUnique(string posteName)
        {
            posteName = posteName.ToLower();
            foreach (PosteRepository.PosteModel e in this.listBoxPostes.Items)
            {
                if (e.libPoste.ToLower().Equals(posteName))
                {
                    return false;
                }
            }
            return true;
        }

        private void GererPostes_Load(object sender, EventArgs e)
        {
            listBoxPostes.Items.AddRange(
                PosteRepository.List()
            );
        }

        private void ShowAddMenu()
        {
            this.deleteToolStripMenuItem.Visible = false;
            this.addToolStripMenuItem.Visible = true;
            ListBoxContextMenu.Show(Cursor.Position);
        }

        private void ShowDeleteOrAddMenu()
        {
            this.deleteToolStripMenuItem.Visible = true;
            this.addToolStripMenuItem.Visible = true;
            ListBoxContextMenu.Show(Cursor.Position);
        }

        private void listBoxPostes_MouseUp(object _s, MouseEventArgs e)
        {
            int clickedIndex;
            ListBox sender = _s as ListBox;

            // if the pressed button is not the Right one, do nothing
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            // if the user selected nothing yet or just one item,
            // find on what item he right-clicked, clear the selection
            // and set the clicked item as selected
            // 
            // But, if the selection count is greater than 1, don't select
            // (the user probably wants to delete the whole selection).
            if (sender.SelectedIndices.Count < 2)
            {
                if ((clickedIndex = sender.IndexFromPoint(e.Location)) == ListBox.NoMatches)
                {
                    ShowAddMenu();
                    return;
                }
                sender.ClearSelected();
                sender.SelectedIndex = clickedIndex;
            }

            // open the menu
            ShowDeleteOrAddMenu();
        }

        private void btnSubmit_Click(object sender, EventArgs _e)
        {
            //List<int>
            // DELETE FROM Postes WHERE codePoste NOT IN ()
            foreach (PosteRepository.PosteModel e in this.listBoxPostes.Items)
            {
                if (e.codePoste != null)
                {
                    //return false;
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GererPostes_FormClosing(object _s, FormClosingEventArgs e)
        {
            MetroForm sender = (MetroForm)_s;
            if (
                MetroMessageBox.Show(this,
                    Program.settings.localize.Translate("quit_confirmation"),
                    Program.settings.localize.Translate("requires_confirmation"),
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question
                ) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void GererPostes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                this.AddEntry(null, null);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                this.DeleteEntries(null, null);
            }
        }
    }
}
