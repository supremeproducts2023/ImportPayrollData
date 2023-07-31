using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Configuration;
using System.Reflection;
using System.Data.OracleClient;
using System;

namespace ImportDataPayroll
{
    public class ClsStrVulue
    {
        public static Dictionary<string, String> getParamList<T>(T item)
        {
            Dictionary<string, string> paramList = new Dictionary<string, string>();

            foreach (PropertyInfo propertyInfo in item.GetType().GetProperties())
                paramList.Add(propertyInfo.Name, propertyInfo.Name);

            return paramList;
        }

        public static dynamic ValidateData(string value)
        {
            if (value == "")
                return null;
            else
                return value;
        }

        public static decimal convertToDecimal(object data)
        {
            if (data == null || data.ToString() == "")
                return 0;
            else
                return Convert.ToDecimal(data.ToString());
        }

        public static int convertToInt(object data)
        {
            if (data == null || data.ToString() == "")
                return 0;
            else
                return Convert.ToInt32(data.ToString());
        }

        public static DateTime? convertToDateTime(object data)
        {
            if (data == null || data.ToString() == "")
                return (DateTime?) null;
            else
                return Convert.ToDateTime(data);
        }

        //public static byte convertToLong(object data)
        //{
        //    if (data == null || data.ToString() == "")
        //        return null;
        //    else
        //        return Convert.ToInt64(data.ToString());
        //}
    }
}
