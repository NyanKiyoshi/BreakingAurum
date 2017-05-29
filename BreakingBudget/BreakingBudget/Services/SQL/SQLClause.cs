using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace BreakingBudget.Services.SQL
{
    public class SQLClause
    {
        private readonly E_SQL_OPERATION SQL_OPERATION;
        private readonly E_SQL_CLAUSE_SEP? SQL_SEP;

        private List<SQLClause> SubClauses;

        private string fieldname;
        private object _value;
        private object value;
        //{
        //    get
        //    {
        //        return SQLUtils.SanitizeValue(this._value);
        //    }

        //    set
        //    {
        //        this._value = value;
        //    }
        //}

        private int _currentParamNum = 0;
        public int currentParamNum
        {
            get
            {
                return this._currentParamNum;
            }
        }

        private SQLClause root;
        private List<OleDbParameter> _parameters;
        public List<OleDbParameter> DBParameters
        {
            get
            {
                return this._parameters;
            }
        }

        public SQLClause(E_SQL_CLAUSE_SEP? SQL_SEP, string fieldname, E_SQL_OPERATION SQL_OPERATION, object value, SQLClause root)
        {
            this.SQL_OPERATION = SQL_OPERATION;
            this.SubClauses = new List<SQLClause>();
            this.SQL_SEP = SQL_SEP;

            this.fieldname = fieldname;
            this.value = value;

            // if root wasn't supplied, we suppose that the root is the instance itself
            if (root != null)
            {
                this.root = root;
            } else
            {
                this.root = this;
                this._ROOT_RESET();
            }
        }

        public SQLClause(string fieldname, E_SQL_OPERATION SQL_OPERATION, object value, SQLClause root)
            : this(null, fieldname, SQL_OPERATION, value, root) { }

        public string _ROOT_AddParam(object value)
        {
            string key = "@__p" + this.DBParameters.Count;
            this._parameters.Add(new OleDbParameter(key, value));
            return key;
        }

        public void _ROOT_RESET()
        {
            this._parameters = new List<OleDbParameter>();
        }

        public void ResetRoot()
        {
            this.root._ROOT_RESET();
        }

        public string AddParam(object value)
        {
            return this.root._ROOT_AddParam(value);
        }

        public SQLClause AddClause(E_SQL_CLAUSE_SEP? SQL_SEP, string fieldname, E_SQL_OPERATION SqlOperation, object value)
        {
            SQLClause clause = new SQLClause(SQL_SEP, fieldname, SqlOperation, value, this.root);
            this.SubClauses.Add(clause);
            return clause;
        }

        public SQLClause And(string fieldname, E_SQL_OPERATION SqlOperation, object value)
        {
            return AddClause(E_SQL_CLAUSE_SEP.AND, fieldname, SqlOperation, value);
        }

        public SQLClause Or(string fieldname, E_SQL_OPERATION SqlOperation, object value)
        {
            return AddClause(E_SQL_CLAUSE_SEP.OR, fieldname, SqlOperation, value);
        }

        public string ClauseToString()
        {
            string s;
            string fieldname = "[" + this.fieldname + "]";

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

            return String.Format(s, fieldname, this.AddParam(this.value));
        }

        public string BuildFromThere()
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

        //override public string ToString()
        //{
        //    return this.BuildFromThere();
        //}
    }
}
