using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Reflection;

namespace BreakingBudget.Services
{
    static class DataAdapter
    {
        private static void SetAttr(object obj, string field, object value)
        {
            PropertyInfo prop = obj.GetType().GetProperty(field, BindingFlags.Public | BindingFlags.Instance);
            if (prop != null)
            {
                prop.SetValue(obj, Convert.ChangeType(value, prop.PropertyType), null);
            }
        }

        public static IEnumerable<T> OleDbDataReaderToStruct<T>(OleDbDataReader d) where T : new()
        {
            T obj;
            
            while (d.Read())
            {
                obj = new T();
                for (int i = 0; i < d.FieldCount; ++i)
                {
                    SetAttr(obj, d.GetName(i), d[i]);
                }
                yield return obj;
            }
        }
    }
}
