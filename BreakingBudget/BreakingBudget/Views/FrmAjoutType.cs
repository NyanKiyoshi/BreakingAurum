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

using BreakingBudget.Services.Lang;
using BreakingBudget.Services.SQL;

namespace BreakingBudget
{
    public partial class FrmAjoutType : MetroForm
    {
        public FrmAjoutType()
        {
            InitializeComponent();

            // inherit theme from settings
            this.metroStyleExtender.StyleManager = Program.settings.styleManager;
            this.StyleManager = this.metroStyleManager;
            this.StyleManager.Theme = Program.settings.styleManager.Theme;
            this.StyleManager.Style = Program.settings.styleManager.Style;

            Program.settings.localize.ControlerTranslator(this);
            this.Text = Program.settings.localize.Translate(this.Name);
            this.Refresh();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ajouterType(null, null);
        }

        private void txtType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == '\'' || e.KeyChar == '-' || char.IsDigit(e.KeyChar) ||e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
                e.Handled = false;
            else if (e.KeyChar == (char)Keys.Enter && btnOK.Enabled)
            {
                this.ajouterType(null, null);
            }
            else
                e.Handled = true;
        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtType.Text) && !string.IsNullOrWhiteSpace(txtType.Text))
            {
                btnOK.Enabled = true;
            }
            else
            {
                btnOK.Enabled = false;
            }
        }

        private void ajouterType(object sender, EventArgs e)
        {
            //recuperation des valeurs des textbox 
            string type = txtType.Text.Trim();
            OleDbConnection connec = DatabaseManager.CreateConnection();

            try
            {
                // On ouvre la connexion si elle n'est pas déjà ouverte
                connec.Open();

                // vérifier si le type existe déjà
                string requeteverif = "SELECT [libType] FROM [TypeTransaction] WHERE LCASE(libType) = @libType";
                OleDbCommand cmdVerif = new OleDbCommand(requeteverif, connec);
                cmdVerif.Parameters.AddWithValue("@libType", type);
                OleDbDataReader drVerif = cmdVerif.ExecuteReader();

                if (!drVerif.HasRows)
                {
                    //requete SQL pour recuperer le code type le plus grand
                    string requeteMaxCodeType = "SELECT MAX(codeType) FROM [TypeTransaction]";
                    //recuperation et calcul du prochain codeType
                    OleDbCommand cmd = new OleDbCommand(requeteMaxCodeType, connec);
                    int nextCodeType = int.Parse(cmd.ExecuteScalar().ToString()) + 1;

                    //requete sql pour inserer le nouveau type dans la base de donnees
                    string requeteAddType = "INSERT INTO [TypeTransaction] ([codeType], [libType]) VALUES (@codeType,@libType)";
                    //insertion du nouveau dans la base de donnees
                    cmd.CommandText = requeteAddType;
                    cmd.Parameters.AddWithValue("@codeType", nextCodeType);
                    cmd.Parameters.AddWithValue("@libType", type);
                    cmd.ExecuteNonQuery();

                    // TODO: translate
                    MessageBox.Show("Le type " + type + " a bien ete ajoute !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // TODO: translate
                    MessageBox.Show("Attention ce type existe déjà !", "Erreur ajout type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtType.Text = string.Empty;
                }
            }
            catch (OleDbException ex)
            {
                ErrorManager.HandleOleDBError(ex);
            }
            finally
            {
                connec.Close();
            }
        }
    }
}
