using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Configuration;
using System.Reflection;
using System.Data.OracleClient;
using ImportDataPayroll.Models;
using System;

namespace ImportDataPayroll
{
    public class NGAR_Module
    {
        static string conn_sql = ConfigurationManager.AppSettings["ConnectionString_SQLSERVER"].ToString();

        #region NGAR_PROD_DETAIL
        public static void Import_NGAR_PROD_DETAIL()
        {
            try
            {
                string str = @"select * from NGAR_PROD_DETAIL";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NGAR_PROD_DETAIL>();
                var item = new NGAR_PROD_DETAIL();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NGAR_PROD_DETAIL";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NGAR_PROD_DETAIL
                        {
                            LOT_ID = ClsStrVulue.convertToDecimal(row["LOT_ID"]),
                            PROD_ID = ClsStrVulue.convertToDecimal(row["PROD_ID"]),
                            LOT_NO = row["LOT_NO"].ToString(),
                            SERIAL_NO = row["SERIAL_NO"].ToString(),
                            EXPIRE_DATE = row["EXPIRE_DATE"].ToString(),
                            STATUS_QC = row["STATUS_QC"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NGAR_PROD_DETAIL", conn_sql, paramList, itemList))
                        Console.WriteLine("NGAR_PROD_DETAIL save data error!!");
                    else
                        Console.WriteLine("NGAR_PROD_DETAIL insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion
    }
}
