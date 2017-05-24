using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingBudget.Services.SQL
{
        public enum E_SQL_OPERATION
        {
            LESS_THAN,
            LESS_OR_EQUAL_THAN,
            GREATER_THAN,
            GREATER_OR_EQUAL_THAN,
            EQUAL_TO,
            LIKE
        }

        public enum E_SQL_CLAUSE_SEP
        {
            OR,
            AND
        }
}
