using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

using MetroFramework.Forms;

using BreakingBudget.Services.SQL;
using BreakingBudget.Services.Lang;

namespace BreakingBudget
{
    public partial class FrmCalendrierPrev : MetroForm
    {
        DataSet ds;

        public FrmCalendrierPrev()
        {
            InitializeComponent();

            this.Text = Program.settings.localize.Translate(this.Name);
            this.Refresh();
        }

        private void FrmCalendrierPrev_Load(object sender, EventArgs e)
        {
            string[] mois = { "Poste", "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
            string[] titres = { "Poste", "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Decembre" };
            for (int i = 0; i < 13; i++)
            {
                dgvCalendrier.Columns.Add(string.Format("col{0}", titres[i]), mois[i]);
            }

            this.dgvCalendrier.Columns["colPoste"].Frozen = true;

            ds = new DataSet();
            string[] tables =
            {
                "Poste",
                "PostePeriodique",
                "PostePonctuel",
                "PosteRevenu",
                "Echeances",
                "Periodicite"
            };

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = DatabaseManager.CreateConnection();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

            cmd.Connection.Open();

            try
            {
                foreach (string table in tables)
                {
                    cmd.CommandText = "SELECT * FROM [" + table + "]";
                    adapter.Fill(ds, table);
                }


                //clés primaires sur les tables
                DataColumn PPeriodPK = ds.Tables["PostePeriodique"].Columns["codePoste"];
                DataColumn PPonctPK = ds.Tables["PostePonctuel"].Columns["codePoste"];
                DataColumn PRevenuPK = ds.Tables["PosteRevenu"].Columns["codePoste"];
                DataColumn PPeriodicitePK = ds.Tables["Periodicite"].Columns["codePer"];

                ds.Tables["PostePeriodique"].PrimaryKey = new DataColumn[] { PPeriodPK };
                ds.Tables["PostePonctuel"].PrimaryKey = new DataColumn[] { PPonctPK };
                ds.Tables["PosteRevenu"].PrimaryKey = new DataColumn[] { PRevenuPK };
                ds.Tables["Periodicite"].PrimaryKey = new DataColumn[] { PPeriodicitePK };

                //remplissage de la première colonne
                for (int i = 0; i < ds.Tables["Poste"].Rows.Count; i++)
                {
                    dgvCalendrier.Rows.Add();
                    DataRow d = ds.Tables["Poste"].Rows[i];
                    dgvCalendrier.Rows[i].Cells["colPoste"].Value = d["libPoste"];
                    dgvCalendrier.Rows[i].Cells["colPoste"].Tag = d["codePoste"];
                }

                //on boucle sur chacun des postes
                for (int i = 0; i < dgvCalendrier.RowCount; i++)
                {

                    //switch sur le type du poste 
                    switch (getTypePoste(dgvCalendrier.Rows[i].Cells["colPoste"]))
                    {

                        //remplissage du datagridview pour un poste Revenu
                        case ("PosteRevenu"):
                            DataRow r = ds.Tables["PosteRevenu"].Rows.Find(dgvCalendrier.Rows[i].Cells["colPoste"].Tag);
                            for (int j = 1; j < 13; j++)
                            {
                                dgvCalendrier.Rows[i].Cells[j].Value = r["montant"];
                            }
                            break;

                        //remplissage du datagridview pour un poste Ponctuel 
                        case ("PostePonctuel"):
                            DataRow[] r2 = ds.Tables["Echeances"].Select("codePoste = " + dgvCalendrier.Rows[i].Cells["colPoste"].Tag);
                            int[] moisRemboursement = new int[r2.Length];
                            for (int j = 0; j < r2.Length; j++)
                            {
                                moisRemboursement[j] = int.Parse(r2[j]["datePrelevt"].ToString().Substring(3, 2));
                            }


                            for (int j = 1; j < 13; j++)
                            {
                                if (Array.IndexOf(moisRemboursement, j) != -1)
                                {
                                    dgvCalendrier.Rows[i].Cells[j].Value = r2[0]["montantEcheance"];
                                }
                                else
                                {
                                    dgvCalendrier.Rows[i].Cells[j].Value = 0;
                                }

                            }
                            break;

                        //remplissage du datagridview pour un poste Periodique
                        case ("PostePeriodique"):
                            DataRow r3 = ds.Tables["PostePeriodique"].Rows.Find((dgvCalendrier.Rows[i].Cells["colPoste"].Tag));
                            string periodicite = ds.Tables["Periodicite"].Rows.Find(r3["typePer"]).ToString();
                            for (int j = 1; j < 13; j++)
                            {
                                switch (periodicite)
                                {
                                    case ("hebdomadaire"):
                                        int jours = DateTime.DaysInMonth(DateTime.Now.Year, j);
                                        int semaines = (int)Math.Ceiling((jours) / 7.0);
                                        dgvCalendrier.Rows[i].Cells[j].Value = float.Parse(r3["montant"].ToString()) * semaines;
                                        break;

                                    case ("mensuel"):
                                        dgvCalendrier.Rows[i].Cells[j].Value = r3["montant"].ToString();
                                        break;

                                    case ("bimestriel"):
                                        if ((j - 1) % 2 == 0)
                                            dgvCalendrier.Rows[i].Cells[j].Value = r3["montant"].ToString();
                                        else
                                            dgvCalendrier.Rows[i].Cells[j].Value = 0;
                                        break;

                                    case ("trimestriel"):
                                        if ((j - 1) % 3 == 0)
                                            dgvCalendrier.Rows[i].Cells[j].Value = r3["montant"].ToString();
                                        else
                                            dgvCalendrier.Rows[i].Cells[j].Value = 0;
                                        break;

                                    case ("semestriel"):
                                        if ((j - 1) % 6 == 0)
                                            dgvCalendrier.Rows[i].Cells[j].Value = r3["montant"].ToString();
                                        else
                                            dgvCalendrier.Rows[i].Cells[j].Value = 0;
                                        break;

                                    case ("annuel"):
                                        if ((j - 1) == 0)
                                            dgvCalendrier.Rows[i].Cells[j].Value = r3["montant"].ToString();
                                        else
                                            dgvCalendrier.Rows[i].Cells[j].Value = 0;
                                        break;
                                }
                            }
                            break;
                    }
                }
            }
            catch (OleDbException ex)
            {
                // if error: handle and abort everything
                ErrorManager.HandleOleDBError(ex);
                this.Close();
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }


        private string getTypePoste(DataGridViewCell cell)
        {
            string res = "";

            if (ds.Tables["PostePeriodique"].Rows.Find(cell.Tag) != null)
                res = "PostePeriodique";
            else if (ds.Tables["PosteRevenu"].Rows.Find(cell.Tag) != null)
                res = "PosteRevenu";
            else if (ds.Tables["PostePonctuel"].Rows.Find(cell.Tag) != null)
                res = "PostePonctuel";

            return res;
        }

    }

    
}
