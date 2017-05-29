using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using BreakingBudget.Repositories;
using BreakingBudget.Services.SQL;
using MetroFramework;

namespace BreakingBudget.Views
{
    public partial class GererPostes : MetroForm
    {
        //List<PosteRepository.PosteModel> AddQueue = new List<PosteRepository.PosteModel>();
        OleDbConnection dbConn;
        //OleDbTransaction Transaction;

        readonly string[] deleteFrom = new string[] 
        {
            "PosteRevenu",
            "PostePeriodique",
            "Echeances",
            "PostePonctuel",
            "Poste"
        };

        public void EnableStyling()
        {
            this.metroStyleExtender.StyleManager = Program.settings.styleManager;
            this.StyleManager = this.metroStyleManager;

            this.StyleManager.Theme = Program.settings.styleManager.Theme;
            this.StyleManager.Style = Program.settings.styleManager.Style;

            if (this.StyleManager.Theme == MetroThemeStyle.Dark)
            {
                this.listPosteContainer.BackColor = Color.FromArgb(55, 56, 57);
            }
            else
            {
                this.listPosteContainer.BackColor = Color.FromArgb(0xCC, 0xCC, 0xCC);
            }
            this.Refresh();
        }

        OleDbTransaction transaction = null;

        public GererPostes()
        {
            InitializeComponent();

            this.Text = Program.settings.localize.Translate("btnGererPostes");

            EnableStyling();

            this.dbConn = DatabaseManager.CreateConnection();


            this.commitBtn.Text    = Program.settings.localize.Translate("Co&mmit");
            this.addBtn.Text    = Program.settings.localize.Translate("&Add");
            this.deleteBtn.Text = Program.settings.localize.Translate("&Delete");
            this.CloseBtn.Text = Program.settings.localize.Translate("&OK");
            this.undoBtn.Text = Program.settings.localize.Translate("&Undo");

            this.deleteToolStripMenuItem.Click += new EventHandler(this.DeleteEntries);
            this.addToolStripMenuItem.Click += new EventHandler(this.AddEntry);
            this.addBtn.Click += new EventHandler(this.AddEntry);
            this.deleteBtn.Click += new EventHandler(this.DeleteEntries);
        }

        private OleDbTransaction BeginTransaction()
        {
            this.dbConn.Open();

            this.CloseBtn.Enabled = false;
            this.deleteBtn.Enabled = this.addBtn.Enabled = false;
            this.listBoxPostes.Enabled = false;

            this.undoBtn.Enabled = true;
            this.commitBtn.Enabled = true;

            this.transaction = this.dbConn.BeginTransaction();
            return this.transaction;
        }

        private void RemoveTransactionState()
        {
            this.CloseBtn.Enabled = true;
            this.deleteBtn.Enabled = this.addBtn.Enabled = true;
            this.listBoxPostes.Enabled = true;

            this.undoBtn.Enabled = false;
            this.commitBtn.Enabled = false;

            this.FillPostes();
        }

        private void RollbackTransaction()
        {
            Console.WriteLine("I :: <- Rollback");
            this.transaction.Rollback();
            this.dbConn.Close();

            this.RemoveTransactionState();
        }

        private void CommitTransaction()
        {
            Console.WriteLine("I :: <- Commit");
            this.transaction.Commit();
            this.dbConn.Close();

            this.RemoveTransactionState();
        }

        public bool RequiresCommit()
        {
            if (this.dbConn != null 
                && this.transaction != null && this.transaction.Connection != null)
            {
                return true;
            }
            return false;
        }

        public bool RequiresCommitAndShowError()
        {
            if (this.RequiresCommit())
            {
                MetroMessageBox.Show(
                    this,
                    Program.settings.localize.Translate("err_operation_requires_commit"),
                    Program.settings.localize.Translate("err_operation_failed_caption"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return true;
            }
            return false;
        }

        private void DeleteEntries(object s, object e)
        {
            // if the form is waiting for a commit/ rollback from the user:
            // do nothing.
            if (this.RequiresCommitAndShowError())
            {
                return;
            }

            OleDbCommand rmCmd;
            PosteRepository.PosteModel entry;
            int removePos;
            DialogResult? dialogResult = null;
            
            // start the transaction mode
            this.BeginTransaction();

            // will there are data to remove and there is no error
            while (this.listBoxPostes.SelectedIndices.Count > 0 && dialogResult == null)
            {
                removePos = this.listBoxPostes.SelectedIndices[0];
                entry = (PosteRepository.PosteModel)this.listBoxPostes.Items[removePos];

                rmCmd = new OleDbCommand();
                rmCmd.Connection = this.dbConn;
                rmCmd.Transaction = this.transaction;
                rmCmd.Parameters.AddWithValue("codePoste", entry.codePoste);

                try
                {
                    foreach (string table in this.deleteFrom)
                    {
                        rmCmd.CommandText = string.Format(
                            "DELETE FROM [{0}] WHERE codePoste = @codePoste", table);
                        Console.WriteLine("I :: Removed: " + rmCmd.CommandText + " -> " + rmCmd.ExecuteNonQuery());
                    }

                    // then remove it from the list
                    this.listBoxPostes.Items.RemoveAt(removePos);
                }
                catch (Exception exc)
                {
                    this.RollbackTransaction();
                    dialogResult = MetroMessageBox.Show(
                        this,
                        string.Format(Program.settings.localize.Translate("err_deletion_failed: {0}, {1}"), entry.libPoste, exc.Message),
                        Program.settings.localize.Translate("err_operation_failed_caption"),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void AddEntry(object s, object e)
        {
            // if the form is waiting for a commit/ rollback from the user:
            // do nothing.
            if (this.RequiresCommitAndShowError())
            {
                return;
            }

            InputMessageBox inputBox = new InputMessageBox("Add", null, null);
            inputBox.ShowDialog();

            // if the user didn't cancel
            if (!inputBox.userCancelled)
            {
                if (string.IsNullOrWhiteSpace(inputBox.userInput))
                {
                    MetroMessageBox.Show(this,
                        Program.settings.localize.Translate("err_invalid_input_empty"),
                        Program.settings.localize.Translate("err_invalid_input_caption"),
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsUnique(inputBox.userInput))
                {
                    MetroMessageBox.Show(this,
                        Program.settings.localize.Translate("err_duplicate_value"),
                        Program.settings.localize.Translate("err_duplicate_value_caption"),
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                // TODO: refactor it to the repository's model (.Create(...))
                // create a new Poste model,
                // add the user's input to it
                PosteRepository.PosteModel newPoste = new PosteRepository.PosteModel();

                // we retrieve the biggest existing Poste identifier currently in the
                // database and we increment it.
                newPoste.codePoste = PosteRepository.BiggestID() + 1;
                newPoste.libPoste = inputBox.userInput;

                // append the newly created Poste to the list and to the queue

                //this.BeginTransaction();
                this.dbConn.Open();
                OleDbCommand cmd = new OleDbCommand(
                    "INSERT INTO Poste (codePoste, libPoste) VALUES(@codePoste, @libPoste)", this.dbConn);
                cmd.Parameters.AddWithValue("codePoste", newPoste.codePoste);
                cmd.Parameters.AddWithValue("libPoste", newPoste.libPoste);

                try
                {
                    cmd.ExecuteNonQuery();
                    this.listBoxPostes.Items.Add(newPoste);
                }
                catch (Exception exc)
                {
                    //this.RollbackTransaction();
                    MetroMessageBox.Show(
                        this,
                        string.Format(Program.settings.localize.Translate("err_insertion_failed: {0}, {1}"), newPoste.libPoste, exc.Message),
                        Program.settings.localize.Translate("err_operation_failed_caption"),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                finally
                {
                    this.dbConn.Close();
                }
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

        private void FillPostes()
        {
            listBoxPostes.Items.Clear();
            listBoxPostes.ClearSelected();
            listBoxPostes.Items.AddRange(
                PosteRepository.List()
            );
        }

        private void GererPostes_Load(object sender, EventArgs e)
        {
            FillPostes();
        }

        private void ShowAddMenu()
        {
            this.deleteToolStripMenuItem.Visible = false;
            this.addToolStripMenuItem.Visible = true;
            listBoxContextMenu.Show(Cursor.Position);
        }

        private void ShowDeleteOrAddMenu()
        {
            this.deleteToolStripMenuItem.Visible = true;
            this.addToolStripMenuItem.Visible = true;
            listBoxContextMenu.Show(Cursor.Position);
        }

        private void listBoxPostes_MouseUp(object _s, MouseEventArgs e)
        {
            int clickedIndex;
            ListBox sender = _s as ListBox;

            // the listbox is disabled or
            // if the pressed button is not the Right one, do nothing
            if (!sender.Enabled || e.Button != MouseButtons.Right)
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

        private void CloseBtn_Click(object sender, EventArgs _e)
        {
            if (this.RequiresCommitAndShowError())
            {
                return;
            }
            this.Close();
        }

        private void GererPostes_FormClosing(object _s, FormClosingEventArgs e)
        {
            MetroForm sender = (MetroForm)_s;

            // if the form is waiting for a commit/ rollback,
            // ask the user to confirm the form's closing.
            // If it confirms or there is no waiting state: close the form and the DB's connection.
            if (this.RequiresCommit() &&
                MetroMessageBox.Show(this,
                    Program.settings.localize.Translate("quit_confirmation_requires_commit"),
                    Program.settings.localize.Translate("requires_confirmation"),
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question
                ) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                this.dbConn.Close();
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

        private void undoBtn_Click(object sender, EventArgs e)
        {
            if (this.RequiresCommit())
            {
                this.RollbackTransaction();
            }
        }

        private void commitBtn_Click(object sender, EventArgs e)
        {
            if (this.RequiresCommit())
            {
                this.CommitTransaction();
            }
        }
    }
}
