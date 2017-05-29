using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingBudget.Services.SQL
{
    public static class SQLUtils
    {
        public static bool IsNumber(this object value)
        {
            return value is sbyte
                    || value is byte
                    || value is short
                    || value is ushort
                    || value is int
                    || value is uint
                    || value is long
                    || value is ulong
                    || value is float
                    || value is double
                    || value is decimal;
        }

        public static string SanitizeValue(object value)
        {
            if (SQLUtils.IsNumber(value))
            {
                return value.ToString();
            }

            // TODO
            return "'" + value.ToString() + "'";
        }
    }
}
