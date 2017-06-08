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

namespace BreakingBudget.Views
{
    public partial class FrmAffichage1par1 : MetroForm
    {
        //bindingsource nécessaire à l'affichage 
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
            OleDbConnection connec = DatabaseManager.GetConnection();

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

                //récupération des tables en local
                foreach (string elt in listeTables)
                {
                    cmd.CommandText = "SELECT * FROM [" + elt + "]";
                    adapter.Fill(ds, elt);
                }

                //requête sql pour récupérer la table transaction, ainsi que le type de la transaction via une jointure
                string sqlTransaction = @"SELECT t.codeTransaction, t.dateTransaction, t.description, t.montant, t.recetteON, t.percuON, t2.libType 
                               FROM [Transaction] t INNER JOIN [TypeTransaction] t2 ON t.type = t2.codeType
                               ORDER BY t.dateTransaction";

                cmd.CommandText = sqlTransaction;
                adapter.Fill(ds, "Transaction");

                //paramétrages du bindingsource
                transactionsBS.DataSource = ds.Tables["Transaction"];

                lblType.DataBindings.Add(new Binding("text", transactionsBS, "libType"));
                lblMontant.DataBindings.Add(new Binding("Text", transactionsBS, "montant"));

                //date de la transaction + format it
                lblDate.DataBindings.Add(
                    new Binding("Text", transactionsBS, "dateTransaction",
                    true, DataSourceUpdateMode.Never, (object)DBNull.Value, Program.settings.localize.Translate("dd/MM/yyyy"))
                );

                //description de la transaction
                rtxtDescription.DataBindings.Add(new Binding("Text", transactionsBS, "description"));

                //percu
                chkPercu.DataBindings.Add(new Binding("checked", transactionsBS, "percuON"));
                
                //recette 
                chkRecette.DataBindings.Add(new Binding("checked", transactionsBS, "recetteON"));

                //page de la transaction
                lblPage.Text = string.Format(Program.settings.localize.Translate("page_{0}_of_{1}"),
                    transactionsBS.Position + 1, transactionsBS.Count);

                //on regarde quelles personnes sont concernées par la transaction
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

        /*
         * afficherRes : void       : met à jour les données affichées lorsque l'on clique sur un bouton
         * Entrée :
         *      sender : object     : bouton sur lequel l'utilisateur a appuyé 
         *           e : EventArgs  : évènement (ex : click sur le bouton)
         * Sortie :
         *      void
         */
        private void afficherRes(object sender, EventArgs e)
        {
            //on récupère le bouton sur lequel l'utilisateur a appuyé 
            Button b = (Button)sender;

            //selon le bouton on avance, recule, ou bien affichons la première/dernière transaction
            if (b == btnPremier)
                transactionsBS.MoveFirst();
            else if (b == btnPrecedent)
                transactionsBS.MovePrevious();
            else if (b == btnSuivant)
                transactionsBS.MoveNext();
            else if (b == btnDernier)
                transactionsBS.MoveLast();

            //on met à jour le numéro de transaction, ainsi que les personnes concernées 
            lblPage.Text = string.Format(Program.settings.localize.Translate("page_{0}_of_{1}"),
                transactionsBS.Position + 1, transactionsBS.Count);
            updatePersonnes();         
        }

        private void lblMontant_TextChanged(object sender, EventArgs e)
        {
            //on ajoute le symbole € devant le montant de chaque transaction
            if (lblMontant.Text[lblMontant.Text.Length - 1] != '€')
               lblMontant.Text = lblMontant.Text + "€";
        }

        private void updatePersonnes()
        {
            //on récupère la ligne courante pointée par le binding source 
            DataRowView current = (DataRowView)transactionsBS.Current;
            
            //requête SQL pour avoir tous les bénéficiaires rattachés à la transaction : stockage dans un tableau de datarow
            string condition = "codeTransaction = " + current["codeTransaction"].ToString();

            DataRow[] beneficiaires = ds.Tables["Beneficiaires"].Select(condition);

            //table locale dans laquelle on stocke toutes les personnes concernées : une seule colonne contenant le nom et le prénom de l'individu
            DataTable tablePersonnesConcernees = new DataTable();
            tablePersonnesConcernees.Columns.Add("PrenomNom", typeof(string));

            //ajout des personnes à la table 
            foreach (DataRow ligne in beneficiaires)
            {
                DataRow l = tablePersonnesConcernees.NewRow();

                //on récupère les bénéficiaires dans la base Personne
                DataRow[] personne = ds.Tables["Personne"].Select("codePersonne = " + ligne["codePersonne"].ToString());
                
                //ajout des personnes récupérées dans la table locale
                foreach (DataRow r in personne)
                {
                    l["PrenomNom"] = r["pnPersonne"] + " " + r["nomPersonne"];
                    tablePersonnesConcernees.Rows.Add(l);
                }
                
            }
            
            //affichage des personnes dans la listbox
            lstPersonnes.DataSource = tablePersonnesConcernees;
            lstPersonnes.DisplayMember = "PrenomNom";
        }
    }
}
