using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;

namespace BreakingBudget.Services.SQL
{
    public class SelectBuilder
    {

        string TableName;
        string[] SelectFields;
        SQLClause clause;

        public SelectBuilder(string TableName) : this(TableName, null) { }
        public SelectBuilder(string TableName, string[] SelectFields)
        {
            this.TableName = TableName;
            this.SelectFields = SelectFields;
        }

        public SQLClause AddClause(E_SQL_CLAUSE_SEP? SQL_SEP, string fieldname, E_SQL_OPERATION SqlOperation, object value)
        {
            if (this.clause == null)
            {
                this.clause = new SQLClause(SQL_SEP, fieldname, SqlOperation, value, null);
            }
            return this.clause;
        }

        public SQLClause AddClause(string fieldname, E_SQL_OPERATION SqlOperation, object value)
        {
            return this.AddClause(null, fieldname, SqlOperation, value);
        }

        public string BuildToString()
        {
            return "WHERE " + this.clause.ToString();
        }

        public string JoinFields()
        {
            if (this.SelectFields == null)
            {
                return "*";
            }

            StringBuilder s = new StringBuilder();
            int i = 0;

            do
            {
                s.Append("[" + this.SelectFields[i++] + "]" + ((i < this.SelectFields.Length) ? "," : ""));
            } while (i < this.SelectFields.Length);

            return s.ToString();
        }

        override public string ToString()
        {
            return string.Format("SELECT {0} FROM [{1}] {2}",
                JoinFields(), this.TableName, this.BuildToString());
        }
    }
}
