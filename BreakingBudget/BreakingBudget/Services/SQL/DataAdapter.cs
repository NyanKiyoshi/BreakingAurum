using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Reflection;

namespace BreakingBudget.Services.SQL
{
    static class DataAdapter
    {
        // change the value of a given property of a object using .NET Reflection
        // equivalent of: `obj.<field> = value`
        private static void SetAttr(object obj, string field, object value)
        {
            // retrieve a given property from a given object instance
            // and only retrieve a public property
            PropertyInfo prop = obj.GetType().GetProperty(field,
                BindingFlags.Public | BindingFlags.Instance
            );

            // if the property exists and is public + the object is an instance:
            if (prop != null)
            {
                // convert the given value to the property's type
                // and set the property to it
                prop.SetValue(obj, Convert.ChangeType(value, prop.PropertyType), null);
            }
        }

        // yield a class T with property set from OleDbDataReader
        public static IEnumerable<T> OleDbDataReaderToStruct<T>(OleDbDataReader d) where T : new()
        {
            T obj;
            
            // read every entry
            while (d.Read())
            {
                // create a new instance of T
                obj = new T();

                // go through every column and set the property of the same name in the obj T to it
                for (int i = 0; i < d.FieldCount; ++i)
                {
                    SetAttr(obj, d.GetName(i), d[i]);
                }

                // yield the result
                yield return obj;
            }
        }
    }
}
