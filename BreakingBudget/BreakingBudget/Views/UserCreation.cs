using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using MetroFramework.Forms;

using BreakingBudget.Services.SQL;
using BreakingBudget.Services.Lang;


namespace BreakingBudget.Views
{
    public partial class UserCreation : MetroForm
    {
        // The db field is too short to accept the country code
        //private const string RE_NUMBER_MATCHING = @"^(\+\d{2,3}([\s]*\d){9}$)|^([\s]*\d){10}$";
        private const string RE_NUMBER_MATCHING = @"^([\s]*\d){10}$";

        public UserCreation()
        {
            InitializeComponent();

            Program.settings.localize.ControlerTranslator(this);
            this.Text = Program.settings.localize.Translate(this.Name);
            this.Refresh();
        }

        private bool _UserCancelled;
        public bool UserCancelled { get { return this._UserCancelled;  } }

        // TODO: Implement Me
        private void AcceptButton_Click(object sender, EventArgs e)
        {

            //recuperation des valeurs des textbox 
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string tel = txtTel.Text.Replace(" ", "");

            OleDbConnection connec = DatabaseManager.CreateConnection();

            //requete SQL pour recuperer le code personne le plus grand
            string sqlCodePersonne = "SELECT MAX(codePersonne) FROM Personne";
            //requete sql pour inserer la nouvelle personne dans la base de donnees
            string sqlAjoutPersonne = "INSERT INTO Personne ([codePersonne], [nomPersonne], [pnPersonne], [telMobile]) VALUES (?,?,?,?)";

            //recuperation et calcul du prochain codePersonne
            OleDbCommand cmd = new OleDbCommand(sqlCodePersonne, connec);

            try
            {
                connec.Open();
                int codePersonne = int.Parse(cmd.ExecuteScalar().ToString()) + 1;

                //insertion de la personne dans la base de donnees
                cmd.CommandText = sqlAjoutPersonne;
                cmd.Parameters.AddWithValue("@codePersonne", codePersonne);
                cmd.Parameters.AddWithValue("@nomPersonne", nom);
                cmd.Parameters.AddWithValue("@pnPersonne", prenom);
                cmd.Parameters.AddWithValue("@telMobile", string.IsNullOrEmpty(tel) ? (object)DBNull.Value : tel); //si jamais le telephone n'est pas renseigne, on insert null dans la colonne telMobile
                cmd.ExecuteNonQuery();

                ErrorManager.EntriesSuccessfullyAdded(this);
                this.DialogResult = DialogResult.OK;
            }
            catch (OleDbException ex)
            {
                ErrorManager.HandleOleDBError(ex);
            }
            finally
            {
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this._UserCancelled = true;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTel.Text.Length > 10
                || char.IsDigit(e.KeyChar)
                || e.KeyChar == (char)Keys.Back
                || e.KeyChar == ' ')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Enter && AcceptButton.Enabled)
            {
                this.AcceptButton_Click(null, null);
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == '\'' || e.KeyChar == '-' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
                e.Handled = false;
            else if (e.KeyChar == (char)Keys.Enter && AcceptButton.Enabled)
            {
                this.AcceptButton_Click(null, null);
            }
            else
                e.Handled = true;
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNom.Text) && !string.IsNullOrWhiteSpace(txtPrenom.Text))
            {
                if (string.IsNullOrEmpty(txtTel.Text) || Regex.Match(txtTel.Text, UserCreation.RE_NUMBER_MATCHING).Success)
                    AcceptButton.Enabled = true;
                else
                    AcceptButton.Enabled = false;
            }
            else
                AcceptButton.Enabled = false;
        }
    }
}
