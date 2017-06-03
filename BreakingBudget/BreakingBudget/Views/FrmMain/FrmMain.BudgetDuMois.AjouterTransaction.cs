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
        // Type de la transaction lors de la modification de celle-ci 
        int typeTransac;
        // Déclaration du DialogueResult pour confirmer la modification de la transaction
        DialogResult sureModif;


        private void InitializeAjouterTransactionBudgetDuMois()
        {
            this.btnAddType.Font = this.IconFont;
            this.btnAddType.Text = Encoding.UTF8.GetString(new byte[] { 0xEE, 0x85, 0x87 });

            // Paramètre des composants
            this.btnModif.Visible = false;
            panelAjoutTransac.Visible = true;
            this.Text = "Nouvelle transaction";

            this.FrmAjoutTransaction_Load();
        }

        private void InitializeAjouterTransactionBudgetDuMois(
            MultiPanePage callingPage,
            DateTime dataTransac, string description, string montant, bool recette, bool percu, int type)
        {
            // call base
            this.InitializeAjouterTransactionBudgetDuMois();

            // Paramètres des composants
            panelAjoutTransac.Visible = false;
            this.Text = "Modifier une transaction";
            this.btnAnnuler2.Visible = true;
            this.btnModif.Visible = true;
            this.btnModif.Enabled = true;

            // Initialisation de la transaction à modifier
            // Récupération des info de la transaction du formulaire père
            this.calTransaction.Value = dataTransac;
            this.FieldsContainerTxtDescr.Text = description;
            this.txtMontant.Text = montant;
            this.ckbRecette.Checked = recette;
            this.ckbPercu.Checked = percu;
            this.typeTransac = type;

            // hide sidebar
            this.HideSidebar();

            this.FrmAjoutTransaction_Load();
        }

        ////////////// FONCTIONS OUTILS ///////////////////////////////////////////////////////////////////
        // Remplir listbox par liaison de donnée
        private void RemplirListboxNomPrenom()
        {
            OleDbConnection connec = DatabaseManager.CreateConnection();

            // On récupère les données de la table Personne
            // puis on les stocks dans une table locale "Personne"
            string requete = @"SELECT *
                               FROM [Personne]";
            OleDbCommand cmd = new OleDbCommand(requete, connec);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable tblPersonne = new DataTable("Personne");

            try
            {
                connec.Open();

                da.Fill(tblPersonne);

                // On créé une colonne NOM+PRENOM pour pouvoir  faire la liaison de donnée
                tblPersonne.Columns.Add("NomPrenom");
                foreach (DataRow dr in tblPersonne.Rows)
                    dr["NomPrenom"] = dr["nomPersonne"] + " " + dr["pnPersonne"];

                // On complète la listbox avec les "Noms Prénoms" des personnes
                // par liaison de donnée
                // avec la table locale créée
                listBoxPersonne.DataSource = tblPersonne;
                listBoxPersonne.DisplayMember = "NomPrenom";
                listBoxPersonne.ValueMember = "codePersonne";

                // On désélectionne tous les éléments
                listBoxPersonne.ClearSelected();
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

        // Remplir combobox par liaison de donnée
        private void RemplirCombobox(ComboBox cbo, string nomTable, string champAffiche, string champCache)
        {
            OleDbConnection connec = DatabaseManager.CreateConnection();

            // On récupère les données de la table en paramètre
            // puis on les stocks dans une table locale "table"
            string requete = @"SELECT *
                               FROM " + nomTable;
            OleDbCommand cmd = new OleDbCommand(requete, connec);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable table = new DataTable("nomTable");

            try {
                connec.Open();

                da.Fill(table);

                // On remplit le composant par liaison de donnée
                // avec la table locale créée
                cbo.DataSource = table;
                cbo.DisplayMember = champAffiche.ToString();
                cbo.ValueMember = champCache.ToString();
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

        // Vérifier la saisie d'un montant 
        public static void VerifSaisieMontant(KeyPressEventArgs e, MetroFramework.Controls.MetroTextBox txt)
        {
            // Si c'est un chiffre, on accepte
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            // On accepte l'effacement
            else if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            // On accepte le "-" uniquement un première position
            else if (e.KeyChar == '-')
            {
                if (txt.Text == string.Empty)
                    e.Handled = false;
                else if (txt.Text.Length > 0 && !txt.Text.Contains("-"))
                {
                    e.Handled = true;
                    string txtsave = txt.Text;
                    txt.Text = "-" + txtsave;
                    txt.SelectionStart = txt.Text.Length;
                }
                else
                    e.Handled = true;
            }
            // On autorise uniquement UNE SEULE virgule uniquement en milieu de chaine
            else if (e.KeyChar == ',')
            {
                if (txt.Text.Contains(',') || txt.Text == string.Empty)
                    e.Handled = true;
            }
            else
                e.Handled = true;
        }

        // Obtenir le prochaine numéro de transaction disponible
        private int GetNextIdTransac()
        {
            OleDbConnection connec = DatabaseManager.CreateConnection();

            int res = 1;
            try
            {
                connec.Open();
                string requete = @"SELECT MAX(codeTransaction) 
                                   FROM [Transaction]";
                OleDbCommand cmd = new OleDbCommand(requete, connec);
                res = (int)cmd.ExecuteScalar() + 1;
            }
            catch (OleDbException ex)
            {
                ErrorManager.HandleOleDBError(ex);
            }
            finally
            {
                connec.Close();
            }
            // Return 1 si l'index n'a pas été trouvé
            return res;
        }

        // Si le champ du montant est non renseigné ou qu'il contient juste un "-"
        // ou si aucune personne bénéficiaire n'est sélectionnée
        // Alors on désactive le bouton
        private void VerifConditionTransaction()
        {
            if (txtMontant.Text == string.Empty || txtMontant.Text == "-" || listBoxPersonne.SelectedItems.Count == 0)
            {
                btnOK.Enabled = false;
            }
            else
            {
                btnOK.Enabled = true;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FrmAjoutTransaction_Load()
        {
            // On récupère tous les types pour compléter la combobox "cboType"
            RemplirCombobox(cboType, "TypeTransaction", "libType", "codeType");

            // On préselectionne la bonne valeur de "type de transaction"
            // lors de la modification de celle-ci à partir du tableau de bord
            if (!panelAjoutTransac.Visible)
            {
                cboType.SelectedValue = typeTransac;
            }
            // On complète la listbox avec les "Noms Prénoms" des personnes
            RemplirListboxNomPrenom();
        }

        private void txtMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Contrôle de la saisie du montant lors de la 
            // pression d'une touche du clavier
            VerifSaisieMontant(e, txtMontant);
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

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {
            VerifConditionTransaction();

            // Vérification des entrées lors de la 
            // modification d'une transaction
            if (btnModif.Visible)
            {
                if (txtMontant.Text == string.Empty || txtMontant.Text == "-")
                {
                    btnModif.Enabled = false;
                }
                else
                {
                    btnModif.Enabled = true;
                }
            }

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Remettre la fenêtre par défaut (vider tous les composants)
            ckbRecette.Checked = false;
            ckbPercu.Checked = false;
            FieldsContainerTxtDescr.Text = string.Empty;
            txtMontant.Text = string.Empty;
            calTransaction.Value = DateTime.Today;
            listBoxPersonne.SelectedItems.Clear();
            cboType.SelectedIndex = 0;
        }

        // Bouton ajouter une personne
        private void btnAddPers_Click(object sender, EventArgs e)
        {
            // Affichage du formulaire d'ajout d'une personne
            UserCreation frmAddPers = new UserCreation();
            frmAddPers.ShowDialog();
            // Si une personne a été ajoutée, alors
            // on rafraichi la liste des personnes
            if (frmAddPers.DialogResult == DialogResult.OK)
                RemplirListboxNomPrenom();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            FrmAjoutType frmAddType = new FrmAjoutType();
            frmAddType.ShowDialog();
            if (frmAddType.DialogResult == DialogResult.OK)
            {
                // On récupère tous les types pour compléter la combobox "cboType"
                RemplirCombobox(cboType, "TypeTransaction", "libType", "codeType");
            }
        }

        // Valider la transaction
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Récupération des informations du formulaire
            string dateTransaction = calTransaction.Value.ToShortDateString();
            string description = FieldsContainerTxtDescr.Text;
            string montant = txtMontant.Text;
            int type = (int)cboType.SelectedValue;
            int idTransac = GetNextIdTransac(); // Récupérer le numéro de la prochaine transaction

            int codeRetour;

            // Ouverture de la connection
            OleDbConnection connec = DatabaseManager.CreateConnection();

            // Construction de la chaine de la requête
            string requeteTransac = @"INSERT INTO [Transaction]
                                        VALUES (?,?,?,?,?,?,?)";

            // Création de la requete INSERT de la transaction
            OleDbCommand cmdTransac = new OleDbCommand(requeteTransac, connec);
            cmdTransac.Parameters.AddWithValue("@codeTransaction", idTransac);
            cmdTransac.Parameters.AddWithValue("@dateTransaction", dateTransaction);

            // Si jamais la description n'est pas renseigne, on insert "NULL" dans la colonne description
            cmdTransac.Parameters.AddWithValue("@description", string.IsNullOrEmpty(description) ? (object)DBNull.Value : description);
            cmdTransac.Parameters.AddWithValue("@montant", montant);
            cmdTransac.Parameters.AddWithValue("@recetteON", ckbRecette.Checked);
            cmdTransac.Parameters.AddWithValue("@percuON", ckbPercu.Checked);
            cmdTransac.Parameters.AddWithValue("@type", type);

            try {
                // Execution de la requête
                connec.Open();
                codeRetour = cmdTransac.ExecuteNonQuery();

                // Création des requetes dans la table des bénéficiaires
                OleDbCommand cmdBenef = new OleDbCommand();
                cmdBenef.Connection = connec;
                string requeteBenef = @"INSERT INTO [Beneficiaires]([codeTransaction], [codePersonne])
                                            VALUES (?,?)";
                cmdBenef.CommandText = requeteBenef;
                string numPers = string.Empty;

                // Pour chaque personne sélectionnée dans la listbox,
                // ajouter la transaction avec le codePersonne correspondant
                foreach (DataRowView drw in listBoxPersonne.SelectedItems)
                {
                    cmdBenef.Parameters.Clear();
                    numPers = drw.Row[0].ToString();
                    cmdBenef.Parameters.AddWithValue("@codeTransaction", idTransac);
                    cmdBenef.Parameters.AddWithValue("@codePersonne", numPers);
                    cmdBenef.ExecuteNonQuery();
                }
                ErrorManager.EntriesSuccessfullyAdded(this);
            }
            catch (OleDbException ex)
            {
                ErrorManager.HandleOleDBError(ex);
            }
            finally
            {
                connec.Close();
            }

            // TODO: SMS API
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            sureModif = MessageBox.Show("Voulez-vous vraiment modifier cette transaction ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            // TODO: clear the form!!
        }

        // Bouton "tout sélectionner"
        private void ckbTtSelect_Click(object sender, EventArgs e)
        {
            if (ckbTtSelect.Checked)
            {
                for (int i = 0; i < listBoxPersonne.Items.Count; i++)
                    listBoxPersonne.SetSelected(i, true);
            }
            else
                listBoxPersonne.SelectedItems.Clear();
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

        private void listBoxPersonne_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifConditionTransaction();
            // On décheck le bouton tout selectionner si on déselectionne un élement dans la listbox
            if (listBoxPersonne.SelectedItems.Count != listBoxPersonne.Items.Count && ckbTtSelect.Checked)
                ckbTtSelect.Checked = false;
            // On check le bouton tout selectionner si on coche tous les élements de la liste
            if (listBoxPersonne.SelectedItems.Count == listBoxPersonne.Items.Count)
                ckbTtSelect.Checked = true;
        }
    }
}
