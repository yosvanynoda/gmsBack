using System.Data;
using System.Reflection;

namespace GMS.Business.Helper
{
    public class HelperUDT
    {
        public static DataTable ListToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                switch (prop.PropertyType.Name)
                {
                    case "String":
                        dataTable.Columns.Add(prop.Name, typeof(String));
                        break;
                    case "Int32":
                        dataTable.Columns.Add(prop.Name, typeof(System.Int32));
                        break;
                    default:
                        dataTable.Columns.Add(prop.Name, typeof(String));
                        break;
                }

            }

            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
    }
}
