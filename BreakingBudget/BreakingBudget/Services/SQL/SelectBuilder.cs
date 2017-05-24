using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingBudget.Services.SQL
{
    public class SelectBuilder
    {

        string TableName;
        SQLClause clause;

        public SelectBuilder(string TableName)
        {
            this.TableName = TableName;
        }

        public SQLClause AddClause(E_SQL_CLAUSE_SEP? SQL_SEP, string fieldname, E_SQL_OPERATION SqlOperation, object value)
        {
            if (this.clause == null)
            {
                this.clause = new SQLClause(SQL_SEP, fieldname, SqlOperation, value);
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

        override public string ToString()
        {
            return this.BuildToString();
        }
    }
}
