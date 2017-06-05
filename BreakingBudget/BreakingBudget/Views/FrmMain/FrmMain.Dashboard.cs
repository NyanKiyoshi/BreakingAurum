using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kerido.Controls;

using BreakingBudget.Views;
using BreakingBudget.Services.SQL;
using BreakingBudget.Services.Lang;

namespace BreakingBudget.Views.FrmMain
{
    partial class FrmMain
    {
        // Déclaration d'un dataset local
        DataSet ds;

        public void InitializeDashboard()
        {
            // On récupère la table transaction en local
            SaveTableEnLocal("Transaction");

            // Affichage des résultats dans le dgv
            dgvTransac.DataSource = ds.Tables["Transaction"];

            // On désactive les champs de recherche par défaut
            ckbDate_Click(null, null);
            ckbLib_Click(null, null);
            ckbMontant_Click(null, null);
        }

        ///////////////// FONCTIONS /////////////////////////////////////////
        private void SaveTableEnLocal(string nomTable)
        {
            OleDbConnection connec = DatabaseManager.CreateConnection();

            // Création du DataSet
            ds = new DataSet();

            // Création de la commande SELECT toutes les transactions
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM [" + nomTable + "]", connec);

            // Création du dataAdapter pour remplir le dataset local
            // avec les informations du SELECT
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);

            // Vérifier si la table existe, si oui, la supprimer
            if (ds.Tables.Contains(nomTable))
                ds.Tables.Remove(nomTable);

            // Ouverture de la connexion
            connec.Open();

            try
            {
                // Remplissage du dataSet
                da.Fill(ds, nomTable);
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

        // événement lors d'un click sur une cellule d'un DataGridView
        private void dgvTransac_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // si le click est effectué avec le bouton droit de la souris
            if (e.Button == MouseButtons.Right)
            {
                // On déselectionne tout
                this.dgvTransac.ClearSelection();
                // On vérifie que la cellule sélectionnée est bien dans le dataset 
                // et est sélectionnable
                if (e.RowIndex >= 0 && e.RowIndex < this.dgvTransac.Rows.Count)
                {
                    // Sélectionner la ligne
                    this.dgvTransac.Rows[e.RowIndex].Selected = true;
                    // on affiche le menu contextuel sous le curseur
                    this.cmsDgv.Show(MousePosition);
                }
            }
        }
        // Clique sur "Modifier" sur le menu déroulant
        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // On récupère l'index de la ligne sélectionnée
            int rowToModify = dgvTransac.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int idTransac = (int)dgvTransac.Rows[rowToModify].Cells[0].Value;
            // Récupération des valeurs à modifier
            DataRow[] dtTransacSelect = ds.Tables["Transaction"].Select("codeTransaction = " + idTransac);
            string dateTransac = dtTransacSelect[0][1].ToString();
            DateTime dt = Convert.ToDateTime(dateTransac);
            string description = dtTransacSelect[0][2].ToString();
            string montant = dtTransacSelect[0][3].ToString();
            bool recette = (bool)dtTransacSelect[0][4];
            bool percu = (bool)dtTransacSelect[0][5];
            int type = (int)dtTransacSelect[0][6];

            // Création et affichage du formulaire de modification
            AjouterTransaction frmAdd = new AjouterTransaction(dt, description, montant, recette, percu, type);
            frmAdd.ShowDialog();

            OleDbConnection connec = DatabaseManager.CreateConnection();
            // Si la modification est confirmée par l'utilisateur
            // On lance la modification de la transaction
            if (frmAdd.AjoutTransaction_confirmModif == DialogResult.Yes)
            {
                connec.Open();

                // Récupération des infos modifiées
                dateTransac = frmAdd.AjoutTransaction_Date;
                description = frmAdd.AjoutTransaction_Description;
                montant = frmAdd.AjoutTransaction_Montant;
                recette = frmAdd.AjoutTransaction_Recette;
                percu = frmAdd.AjoutTransaction_Percu;
                type = frmAdd.AjoutTransaction_Type;

                // Construction de la requete SQL Update
                string cmdUpdate = @"UPDATE [Transaction] "
                                  + "SET [dateTransaction] = ?, [description] = ?, [montant] = ?, [recetteON] = ?, [percuON] = ?, [type] = ?"
                                  + "WHERE [codeTransaction] = ?";

                OleDbCommand cmd = new OleDbCommand(cmdUpdate, connec);

                // Ajouts des paramètres
                cmd.Parameters.AddWithValue("@dateTransaction", dateTransac);
                //Si jamais la description n'est pas renseigne, on insert "NULL" dans la colonne description
                cmd.Parameters.AddWithValue("@description", string.IsNullOrEmpty(description) ? (object)DBNull.Value : description);
                cmd.Parameters.AddWithValue("@montant", montant);
                cmd.Parameters.AddWithValue("@recetteON", recette);
                cmd.Parameters.AddWithValue("@percuON", percu);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@codeTransaction", idTransac);

                try
                {
                    // Exécution de la commande UPDATE
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaction modifiée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mise a jour de la table locale
                    dtTransacSelect[0][1] = dateTransac;
                    dtTransacSelect[0][2] = description;
                    dtTransacSelect[0][3] = montant;
                    dtTransacSelect[0][4] = recette;
                    dtTransacSelect[0][5] = percu;
                    dtTransacSelect[0][6] = type;

                    // Mise à jour du dgv pour affichage direct de la modification
                    dgvTransac.Rows[rowToModify].SetValues(idTransac, dateTransac, description, montant, recette, percu, type);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connec.Close();
                }
            }
        }
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Création d'une transaction de suppréssion de la "transaction"
            OleDbTransaction transac = null;
            OleDbConnection connec;

            // On récupère l'index de la ligne sélectionnée
            int rowToDelete = dgvTransac.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int idTransac = (int)dgvTransac.Rows[rowToDelete].Cells[0].Value;
            // On propose de la supprimer 
            DialogResult sure = MessageBox.Show("Voulez-vous vraiment supprimer la transaction sélectionnée ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sure == DialogResult.Yes)
            {
                // Ouverture de la connection
                connec = DatabaseManager.CreateConnection();
                connec.Open();

                // Début de la transaction
                transac = connec.BeginTransaction();

                // On supprime tous les bénéficiaires de la transaction à supprimer
                string requetedelBenef = "DELETE "
                                       + "FROM [Beneficiaires] "
                                       + "WHERE [codeTransaction] = @idTransac";
                OleDbCommand cmdDelBenef = new OleDbCommand(requetedelBenef, connec);
                cmdDelBenef.Parameters.AddWithValue("@idTransac", idTransac);
                cmdDelBenef.Transaction = transac;

                try {
                    cmdDelBenef.ExecuteNonQuery();

                    // Construction de la requete DELETE de la transaction en elle-meme
                    string requeteDelTransac = "DELETE "
                                             + "FROM [Transaction] "
                                             + "WHERE [codeTransaction] = @idTransac";
                    OleDbCommand cmdDelTransac = new OleDbCommand(requeteDelTransac, connec);
                    cmdDelTransac.Parameters.AddWithValue("@idTransac", idTransac);
                    cmdDelTransac.Transaction = transac;
                    cmdDelTransac.ExecuteNonQuery();

                    // On valide la transaction si il n'y a aucun soucis
                    transac.Commit();
                }
                catch (OleDbException ex)
                {
                    ErrorManager.HandleOleDBError(ex);
                }
                finally
                {
                    connec.Close();
                }

                // Metre à jour le dataset local 
                SaveTableEnLocal("Transaction");
                dgvTransac.DataSource = ds.Tables["Transaction"];
                // Nettoyer la zone de recherche
                btnClear_Click(null, null);

                MessageBox.Show("Transaction(s) supprimée(s) avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Tout déselectionner dans le dgv
            dgvTransac.ClearSelection();
        }

        ////////// Partie recherche //////////////////////////////////////////
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string requete = @"SELECT * FROM [Transaction] ";
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = DatabaseManager.CreateConnection();

            // Si rechercher par Date Unique
            if (ckbDate.Checked && rdbDateUnique.Checked)
            {
                string date = dtpDeb.Value.ToShortDateString();
                if (!requete.Contains("WHERE"))
                {
                    requete += "WHERE [dateTransaction] = @dateUniq ";
                }
                else
                {
                    requete += "AND [dateTransaction] = @dateUniq ";
                }
                cmd.Parameters.AddWithValue("@dateUniq", date);
            }
            // Si recherche par Plage de date
            else if (ckbDate.Checked && rdbPlage.Checked)
            {
                string dateDeb = dtpDeb.Value.ToShortDateString();
                string dateFin = dtpFin.Value.ToShortDateString();
                if (!requete.Contains("WHERE"))
                {
                    requete += "WHERE [dateTransaction] >= @dateDebut " +
                                  "AND [dateTransaction] <= @dateFin ";
                }
                else
                {
                    requete += "AND [dateTransaction] >= @dateDebut " +
                               "AND [dateTransaction] <= @dateFin ";
                }
                cmd.Parameters.AddWithValue("@dateDebut", dateDeb);
                cmd.Parameters.AddWithValue("@dateFin", dateFin);
            }
            // Si recherche par libellé
            if (ckbLib.Checked)
            {
                string libelle = txtLib.Text;
                if (!requete.Contains("WHERE"))
                {
                    requete += "WHERE [description] LIKE @description ";
                }
                else
                {
                    requete += "AND [description] LIKE @description";
                }
                cmd.Parameters.AddWithValue("@description", "%" + libelle + "%");
            }
            // Si recherche par montant
            if (ckbMontant.Checked)
            {
                string montant = txtMontant.Text;
                if (!requete.Contains("WHERE"))
                {
                    requete += "WHERE [montant] & '' LIKE @montant ";
                }
                else
                {
                    requete += "AND [montant] & '' LIKE @montant ";
                }
                cmd.Parameters.AddWithValue("@montant", "%" + montant + "%");

                // Bouton recette
                requete += "AND [recetteON] = @recetteStatu ";
                cmd.Parameters.AddWithValue("@recetteStatu", ckbRecette.Checked);

                // Bouton percu
                requete += "AND [percuON] = @percuStatu ";
                cmd.Parameters.AddWithValue("@percuStatu", ckbPercu.Checked);
            }
            cmd.CommandText = requete;
            try
            {
                cmd.Connection.Open();

                // On créé une table pour stocker les résultats
                DataTable dtResults = new DataTable("tblResults");
                OleDbDataAdapter daResults = new OleDbDataAdapter(cmd);
                // On remplit cette table avec la requête de recherche construite ci-dessus
                daResults.Fill(dtResults);
                // Si aucune ligne n'a été trouvé, on vide le dgv et on affiche une message
                if (dtResults.Rows.Count == 0)
                {
                    dgvTransac.DataSource = null;
                    MessageBox.Show("Aucune transaction trouvée", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Sinon, on affiche les résultats
                else
                {
                    dgvTransac.DataSource = dtResults;
                }
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
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Remettre la fenêtre par défaut (vider tous les composants)
            rdbDateUnique.Checked = true;
            rdbDateUnique_Click(null, null);
            ckbPercu.Checked = false;
            ckbRecette.Checked = false;
            txtLib.Text = string.Empty;
            txtMontant.Text = string.Empty;
            dtpDeb.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
            ckbDate.Checked = false;
            ckbLib.Checked = false;
            ckbMontant.Checked = false;
            ckbDate_Click(null, null);
            ckbLib_Click(null, null);
            ckbMontant_Click(null, null);
            dgvTransac.DataSource = ds.Tables["Transaction"];
        }
        private void ckbRecette_Click(object sender, EventArgs e)
        {
            // Rajouter/enlever le "-" dans la zone de txt
            // de saisie du montant si il n'existe pas déjà
            // On decheck également le bouton "Perçu"
            // qui n'a aucun sens quand la transaction n'est 
            // pas une recette
            if (ckbRecette.Checked == false)
            {
                string txtsave = txtMontant.Text;
                txtMontant.Text = "-" + txtsave;
                ckbPercu.Checked = false;
            }
            else
            {
                if (txtMontant.Text.Contains("-"))
                {
                    txtMontant.Text = txtMontant.Text.Replace("-", "");
                }
            }
        }
        private void ckbPercu_Click(object sender, EventArgs e)
        {
            // On vérifie que le bouton recette soit coché
            // pour pouvoir cocher le bouton perçu
            if (ckbPercu.Checked)
            {
                if (!ckbRecette.Checked)
                {
                    ckbRecette.Checked = true;
                    ckbRecette_Click(null, null);
                }
            }
        }
        private void ckbDate_Click(object sender, EventArgs e)
        {
            // Si on coche la date, alors on active les champs de recherche par date
            if (ckbDate.Checked)
            {
                rdbDateUnique.Enabled = true;
                rdbPlage.Enabled = true;
                dtpDeb.Enabled = true;
                dtpFin.Enabled = true;
            }
            // Sinon on les désactivent
            else
            {
                rdbDateUnique.Enabled = false;
                rdbPlage.Enabled = false;
                rdbDateUnique_Click(sender, e);
                dtpDeb.Enabled = false;
                dtpFin.Enabled = false;
            }
            // Vérifier si des critères de recherche sont sélectionnés 
            // pour pouvoir lancer la recherche
            if (!ckbDate.Checked && !ckbLib.Checked && !ckbMontant.Checked)
            {
                btnSearch.Enabled = false;
            }
            else
            {
                btnSearch.Enabled = true;
            }
        }
        private void ckbLib_Click(object sender, EventArgs e)
        {
            // Si on coche Libellé, on active la recherche par libellé
            if (ckbLib.Checked)
            {
                txtLib.Enabled = true;
                txtLib.Focus();
            }
            // Sinon, on la désactive
            else
            {
                txtLib.Enabled = false;
            }
            // Vérifier si des critères de recherche sont sélectionnés 
            // pour pouvoir lancer la recherche
            if (!ckbDate.Checked && !ckbLib.Checked && !ckbMontant.Checked)
            {
                btnSearch.Enabled = false;
            }
            else
            {
                btnSearch.Enabled = true;
            }
        }
        private void ckbMontant_Click(object sender, EventArgs e)
        {
            // Si on coche montant, on active la recherche par montant
            if (ckbMontant.Checked)
            {
                txtMontant.Enabled = true;
                txtMontant.Focus();
                ckbRecette.Enabled = true;
                ckbPercu.Enabled = true;
            }
            // Sinon on la désactive
            else
            {
                txtMontant.Enabled = false;
                ckbRecette.Enabled = false;
                ckbPercu.Enabled = false;
            }
            // Vérifier si des critères de recherche sont sélectionnés 
            // pour pouvoir lancer la recherche
            if (!ckbDate.Checked && !ckbLib.Checked && !ckbMontant.Checked)
            {
                btnSearch.Enabled = false;
            }
            else
            {
                btnSearch.Enabled = true;
            }
        }
        private void rdbDateUnique_Click(object sender, EventArgs e)
        {
            if (rdbDateUnique.Checked)
            {
                // Décocher le bouton Plage
                rdbPlage.Checked = false;
                // Rendre invisible les composants inutiles
                lblDateDeb.Visible = false;
                lblDateA.Visible = false;
                dtpFin.Visible = false;
            }
        }
        private void rdbPlage_Click(object sender, EventArgs e)
        {
            if (rdbPlage.Checked)
            {
                // Décocher le bouton Unique
                rdbDateUnique.Checked = false;
                // Rendre visible les élements de date
                lblDateDeb.Visible = true;
                lblDateA.Visible = true;
                dtpFin.Visible = true;
            }
        }
        private void txtMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Contrôle de la saisie du montant lors de la 
            // pression d'une touche du clavier
            AjouterTransaction.VerifSaisieMontant(e, txtMontant);

            if (e.KeyChar == (char)Keys.Enter && btnSearch.Enabled == true)
            {
                btnSearch_Click(null, null);
            }
        }
        private void txtMontant_KeyUp(object sender, KeyEventArgs e)
        {
            // Changer le status du bouton recette si il y a un moins 
            // dans la textebox du montant
            if (txtMontant.Text != "")
            {
                if (txtMontant.Text.Substring(0, 1) == "-")
                    ckbRecette.Checked = false;
                else
                    ckbRecette.Checked = true;
            }
        }
        private void txtLib_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && btnSearch.Enabled == true)
            {
                btnSearch_Click(null, null);
            }
        }
    }
}
