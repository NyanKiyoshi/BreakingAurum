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
using BreakingBudget.Services.SQL;
using BreakingBudget.Services.Lang;

namespace BreakingBudget
{
    public partial class FrmAffichage1par1 : MetroForm
    {
        //bindingsources nécessaires à l'affichage 
        BindingSource transactionsBS = new BindingSource();

        //dataset dans lequel seront stockées les tables nécessaires
        DataSet ds = new DataSet();

        public FrmAffichage1par1()
        {
            InitializeComponent();

            this.Text = Program.settings.localize.Translate(this.Name);
            this.Refresh();

            Program.settings.localize.ControlerTranslator(this);

            // inherit theme from settings
            this.metroStyleExtender.StyleManager = Program.settings.styleManager;
            this.StyleManager = this.metroStyleManager;
            this.StyleManager.Theme = Program.settings.styleManager.Theme;
            this.StyleManager.Style = Program.settings.styleManager.Style;
        }
        private void FrmAffichage1par1_Load(object sender, EventArgs e)
        {
            OleDbConnection connec = DatabaseManager.CreateConnection();

            //différentes tables à télécharger en local 
            string[] listeTables = {
                "Personne",
                "Beneficiaires",
            };

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connec;
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

            try
            {
                connec.Open();

                foreach (string elt in listeTables)
                {
                    cmd.CommandText = "SELECT * FROM [" + elt + "]";
                    adapter.Fill(ds, elt);
                }


                string sqlTransaction = @"SELECT t.codeTransaction, t.dateTransaction, t.description, t.montant, t.recetteON, t.percuON, t2.libType 
                               FROM [Transaction] t INNER JOIN [TypeTransaction] t2 ON t.type = t2.codeType
                               ORDER BY t.dateTransaction";

                cmd.CommandText = sqlTransaction;
                adapter.Fill(ds, "Transaction");

                //paramétrages des bindingsources 
                transactionsBS.DataSource = ds.Tables["Transaction"];

                lblType.DataBindings.Add(new Binding("text", transactionsBS, "libType"));
                lblMontant.DataBindings.Add(new Binding("Text", transactionsBS, "montant"));
                
                lblDate.DataBindings.Add(new Binding("Text", transactionsBS, "dateTransaction"));
                rtxtDescription.DataBindings.Add(new Binding("Text", transactionsBS, "description"));

                chkPercu.DataBindings.Add(new Binding("checked", transactionsBS, "percuON"));
                chkRecette.DataBindings.Add(new Binding("checked", transactionsBS, "recetteON"));

                updatePersonnes();

            }
            catch(OleDbException exc)
            {
                ErrorManager.HandleOleDBError(exc);
            }
            finally
            {
                connec.Close();
            }
        }
        private void afficherRes(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b == btnPremier)
                transactionsBS.MoveFirst();
            else if (b == btnPrecedent)
                transactionsBS.MovePrevious();
            else if (b == btnSuivant)
                transactionsBS.MoveNext();
            else if (b == btnDernier)
                transactionsBS.MoveLast();
            updatePersonnes();         
        }

        private void lblDate_TextChanged(object sender, EventArgs e)
        {
            lblDate.Text = lblDate.Text.Substring(0, 10);
        }

        private void lblMontant_TextChanged(object sender, EventArgs e)
        {
           if (lblMontant.Text[lblMontant.Text.Length - 1] != '€')
               lblMontant.Text = lblMontant.Text + "€";
        }

        private void updatePersonnes()
        {
            DataRowView current = (DataRowView)transactionsBS.Current;
            string condition = "codeTransaction = " + current["codeTransaction"].ToString();

            DataRow[] beneficiaires = ds.Tables["Beneficiaires"].Select(condition);
            DataTable tablePersonnesConcernees = new DataTable();
            tablePersonnesConcernees.Columns.Add("PrenomNom", typeof(string));
            foreach (DataRow ligne in beneficiaires)
            {
                DataRow l = tablePersonnesConcernees.NewRow();
                DataRow[] personne = ds.Tables["Personne"].Select("codePersonne = " + ligne["codePersonne"].ToString());
                foreach(DataRow r in personne)
                {
                    l["PrenomNom"] = r["pnPersonne"] + " " + r["nomPersonne"];
                    tablePersonnesConcernees.Rows.Add(l);
                }
                
            }
            lstPersonnes.DataSource = tablePersonnesConcernees;
            lstPersonnes.DisplayMember = "PrenomNom";
        }
    }
}
