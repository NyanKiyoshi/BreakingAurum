using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingBudget.Services.SQL
{
    public class SQLClause
    {
        private readonly E_SQL_OPERATION SQL_OPERATION;
        private readonly E_SQL_CLAUSE_SEP? SQL_SEP;

        private List<SQLClause> SubClauses;

        private string fieldname;
        private object _value;
        private object value
        {
            get
            {
                return SQLUtils.SanitizeValue(this._value);
            }

            set
            {
                this._value = value;
            }
        }

        public SQLClause(E_SQL_CLAUSE_SEP? SQL_SEP, string fieldname, E_SQL_OPERATION SQL_OPERATION, object value)
        {
            this.SQL_OPERATION = SQL_OPERATION;
            this.SubClauses = new List<SQLClause>();
            this.SQL_SEP = SQL_SEP;

            this.fieldname = fieldname;
            this.value = value;
        }

        public SQLClause(string fieldname, E_SQL_OPERATION SQL_OPERATION, object value)
            : this(null, fieldname, SQL_OPERATION, value)
        {
        }

        public SQLClause AddClause(E_SQL_CLAUSE_SEP? SQL_SEP, string fieldname, E_SQL_OPERATION SqlOperation, object value)
        {
            SQLClause clause = new SQLClause(SQL_SEP, fieldname, SqlOperation, value);
            this.SubClauses.Add(clause);
            return clause;
        }

        public SQLClause And(E_SQL_OPERATION SqlOperation, string fieldname, object value)
        {
            return AddClause(E_SQL_CLAUSE_SEP.AND, fieldname, SqlOperation, value);
        }

        public SQLClause Or(E_SQL_OPERATION SqlOperation, string fieldname, object value)
        {
            return AddClause(E_SQL_CLAUSE_SEP.OR, fieldname, SqlOperation, value);
        }

        public string ClauseToString()
        {
            string s;

            switch (this.SQL_OPERATION)
            {
                case E_SQL_OPERATION.EQUAL_TO:
                    s = "{0} = {1}";
                    break;
                case E_SQL_OPERATION.GREATER_THAN:
                    s = "{0} > {1}";
                    break;
                case E_SQL_OPERATION.GREATER_OR_EQUAL_THAN:
                    s = "{0} >= {1}";
                    break;
                case E_SQL_OPERATION.LESS_THAN:
                    s = "{0} < {1}";
                    break;
                case E_SQL_OPERATION.LESS_OR_EQUAL_THAN:
                    s = "{0} <= {1}";
                    break;
                case E_SQL_OPERATION.LIKE:
                    s = "{0} LIKE {1}";
                    break;
                default:
                    s = "";
                    break;
            }

            return String.Format(s, this.fieldname, this.value);
        }

        private string BuildFromThere()
        {
            string s = this.ClauseToString();
            string sub_clause = "";

            if (this.SubClauses.Count != 0)
            {
                foreach (SQLClause clause in this.SubClauses)
                {
                    switch (clause.SQL_SEP)
                    {
                        case E_SQL_CLAUSE_SEP.AND:
                            sub_clause += " AND ";
                            break;
                        case E_SQL_CLAUSE_SEP.OR:
                            sub_clause += " OR ";
                            break;
                    }
                    sub_clause += "(" + clause.BuildFromThere() + ")";
                }
            }

            return s + sub_clause;
        }

        override public string ToString()
        {
            return this.BuildFromThere();
        }
    }
}
