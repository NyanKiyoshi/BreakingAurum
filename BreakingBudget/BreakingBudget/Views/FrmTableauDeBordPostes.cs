using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

using MetroFramework.Forms;

using BreakingBudget.Services.SQL;
using BreakingBudget.Services.Lang;
using BreakingBudget.Repositories;

namespace BreakingBudget
{
    public partial class FrmTableauDeBordPostes : MetroForm
    {
        // Déclaration du dataset en global
        DataSet ds;

        private void SaveTablesEnLocal()
        {
            // Création du DataSet
            ds = new DataSet();

            /////////// POSTES A ECHEANCES FIXES ///////////////////////////////////////////////
            // Créer la table qui nous intéresse pour l'affichage des Postes à périodicité fixe
            string requetePFixes = "SELECT p.codePoste as Code, p.libPoste as Description, pp.montant as Montant, "
                                    + "per.libPer as Périodicité "
                                    + "FROM ((PostePeriodique pp "
                                    + "INNER JOIN Periodicite per ON pp.typePer = per.codePer) "
                                    + "INNER JOIN Poste p ON pp.codePoste = p.codePoste) "
                                    + "ORDER BY p.codePoste";

            OleDbCommand cmd = new OleDbCommand(requetePFixes, DatabaseManager.CreateConnection());

            // Création du dataAdapter pour remplir le dataset local
            // avec les informations du SELECT
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);

            cmd.Connection.Open();
            try {
                // Remplissage du dataSet
                da.Fill(ds, "PostesPerFixes");

                /////////// POSTES A ECHEANCES ///////////////////////////////////////////////
                string requetePEcheances = "SELECT p.codePoste as Code, p.libPoste as Description, COUNT(e.codePoste) as Echéances, "
                                         + "SUM(e.montantEcheance) as Montant "
                                         + "FROM ((Poste p "
                                         + "INNER JOIN PostePonctuel pp ON p.codePoste = pp.codePoste) "
                                         + "INNER JOIN Echeances e ON e.codePoste = pp.codePoste)"
                                         + "GROUP BY p.codePoste, p.libPoste "
                                         + "ORDER BY p.codePoste";
                cmd.CommandText = requetePEcheances;
                da.Fill(ds, "PosteEcheances");

                /////////// POSTES A ECHEANCES ///////////////////////////////////////////////
                string requetePRevenus = "SELECT p.codePoste as Code, p.libPoste as Description, pers.nomPersonne+\" \"+pers.pnPersonne as Bénéficiaire, pr.montant "
                                       + "FROM ((Poste p "
                                       + "INNER JOIN PosteRevenu pr ON p.codePoste = pr.codePoste) "
                                       + "INNER JOIN Personne pers ON pers.codePersonne = pr.codePersonne) "
                                       + "ORDER BY p.codePoste";
                cmd.CommandText = requetePRevenus;
                da.Fill(ds, "PosteRevenus");
            }
            catch (OleDbException ex)
            {
                ErrorManager.HandleOleDBError(ex);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        public FrmTableauDeBordPostes()
        {
            InitializeComponent();
            this.Text = Program.settings.localize.Translate(this.Name);
            this.Refresh();
            
            // inherit theme from settings
            this.metroStyleExtender.StyleManager = Program.settings.styleManager;
            this.StyleManager = this.metroStyleManager;
            this.StyleManager.Theme = Program.settings.styleManager.Theme;
            this.StyleManager.Style = Program.settings.styleManager.Style;

            Program.settings.localize.ControlerTranslator(this);
        }

        private void FrmTableauDeBordPostes_Load(object sender, EventArgs e)
        {
            // Création et save des tables qui nous intéressent en local pour pouvoir les exploiter
            // avec les DataGridViews
            SaveTablesEnLocal();
            // Affichage des postes à périodicité fixe
            dgvPostesFixes.DataSource = ds.Tables["PostesPerFixes"];
            dgvPostesFixes.ClearSelection();

            // Affichage des postes à échéances
            dgvPostesEcheances.DataSource = ds.Tables["PosteEcheances"];
            dgvPostesEcheances.ClearSelection();

            // Affichage des postes revenus
            dgvRevenus.DataSource = ds.Tables["PosteRevenus"];
            dgvRevenus.ClearSelection();
        }

        private DataGridViewCellCollection GetSelectedRowData(MetroFramework.Controls.MetroGrid controler)
        {
            if (controler.SelectedRows != null && controler.SelectedRows.Count > 0)
            {
                return controler.SelectedRows[0].Cells;
            }
            return null;
        }

        ////////////// Postes à échéances //////////////////////////////////////////////////
        // Double clique gauche sur les Postes à échéances permet d'afficher des détails sur ce poste
        private void dgvPostesEcheances_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPostesEcheances.SelectedCells != null)
            {
                DataGridViewCellCollection selectedRowCells = GetSelectedRowData(dgvPostesEcheances);
                int codePoste = (int)selectedRowCells[0].Value;
                string descrPoste = selectedRowCells[1].Value.ToString();

                string requeteDetailPostes = "SELECT datePrelevt, montantEcheance "
                                           + "FROM Echeances "
                                           + "WHERE codePoste = @codePoste";

                OleDbCommand cmd = new OleDbCommand(requeteDetailPostes, DatabaseManager.CreateConnection());
                cmd.Parameters.AddWithValue("@codePoste", codePoste);
                cmd.Connection.Open();

                try
                {
                    OleDbDataReader dr = cmd.ExecuteReader();

                    string detailsEcheance = string.Empty;
                    while (dr.Read())
                    {
                        detailsEcheance += "Date prévue : " + dr[0].ToString().Substring(0, 10) + " Montant : " + dr[1] + "\n";
                    }

                    // Affichage des détails
                    FrmAffichDetailsPoste frmADP = new FrmAffichDetailsPoste(codePoste, descrPoste, detailsEcheance);
                    frmADP.ShowDialog();
                }
                catch (OleDbException o)
                {
                    ErrorManager.HandleOleDBError(o);
                }
                finally
                {
                    cmd.Connection.Close();
                }
            }
        }

        ////////////// Menu sur les Postes à échéances fixes /////////////////////////////////////////
        private void dgvPostesFixes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // si le click est effectué avec le bouton droit de la souris
            if (e.Button == MouseButtons.Right)
            {
                // On déselectionne tout
                this.dgvPostesFixes.ClearSelection();
                // On vérifie que la cellule sélectionnée est bien dans le dataset 
                // et est sélectionnable
                if (e.RowIndex >= 0 && e.RowIndex < this.dgvPostesFixes.Rows.Count)
                {
                    // Sélectionner la ligne
                    this.dgvPostesFixes.Rows[e.RowIndex].Selected = true;
                    // on affiche le menu contextuel sous le curseur
                    this.cmsPosteFixes.Show(MousePosition);
                }
            }
        }
        
        ////////////// Menu sur les Postes revenus /////////////////////////////////////////
        private void dgvRevenus_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // si le click est effectué avec le bouton droit de la souris
            if (e.Button == MouseButtons.Right)
            {
                // On déselectionne tout
                this.dgvRevenus.ClearSelection();
                // On vérifie que la cellule sélectionnée est bien dans le dataset 
                // et est sélectionnable
                if (e.RowIndex >= 0 && e.RowIndex < this.dgvRevenus.Rows.Count)
                {
                    // Sélectionner la ligne
                    this.dgvRevenus.Rows[e.RowIndex].Selected = true;
                    // on affiche le menu contextuel sous le curseur
                    this.cmsRevenus.Show(MousePosition);
                }
            }
        }

        private void modifierRevenuToolStripItem_Click(object sender, EventArgs e)
        {

        }

        private void DeleteSelectedPoste(MetroFramework.Controls.MetroGrid controler)
        {
            OleDbConnection dbConn;
            OleDbTransaction dbTransaction;

            // delete a whole Poste if and only if a row was selected
            DataGridViewCellCollection cells = this.GetSelectedRowData(controler);
            if (cells != null)
            {
                dbConn = DatabaseManager.CreateConnection();
                dbConn.Open();
                dbTransaction = dbConn.BeginTransaction();

                try
                {
                    // delete the selected poste in cascade then commit the changes
                    PosteRepository.Delete(dbConn, dbTransaction, (int)cells[0].Value);
                    dbTransaction.Commit();
                }
                catch (OleDbException ex)
                {
                    dbTransaction.Rollback();
                    ErrorManager.HandleOleDBError(ex);
                }
                finally
                {
                    dbConn.Close();
                }
            }
        }

        private void modifierPosteFixesToolStripItem_Click(object sender, EventArgs e)
        {

        }

        private void supprimerPosteFixesToolStripItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedPoste(dgvPostesFixes);
        }

        private void supprimerRevenuToolStripItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedPoste(dgvRevenus);
        }
    }
}
