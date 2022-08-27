using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Configuration;
using System.Reflection;
using ImportDataPayroll.Models;

namespace ImportDataPayroll
{
    public class ClsSQLServer
    {

        public static Boolean BulkCopy<T>(String tableName, String ConnName, Dictionary<string, string> paramList, List<T> dataList)
        {
            try
            {
                using (var copy = new SqlBulkCopy(ConnName))
                {
                    copy.DestinationTableName = tableName;

                    if (paramList != null)
                    {
                        foreach (var param in paramList)
                        {
                            copy.ColumnMappings.Add(param.Key, param.Value);
                        }
                    }

                    copy.WriteToServer(ToDataTable(dataList));
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties by using reflection   
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names  
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {

                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        public static Boolean ExecuteQuery(String SQL, String ConnName, List<SearchQueryParameters> filterList)
        {
            try
            {
                DataTable DT = new DataTable();
                using (SqlConnection Connection = new SqlConnection(ConnName))
                {
                    Connection.Open();

                    SqlCommand objCmd = new SqlCommand(SQL, Connection);

                    if (filterList != null && filterList.Count > 0)
                    {
                        foreach (var param in filterList)
                            objCmd.Parameters.Add(param.paramName, param.sqlType).Value = param.Value;
                    }

                    objCmd.ExecuteNonQuery();
                    objCmd.Dispose();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
