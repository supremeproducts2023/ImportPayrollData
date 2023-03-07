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
    public class PRPO
    {
        static string conn_sql = ConfigurationManager.AppSettings["ConnectionString_SQLSERVER"].ToString();

        #region PR_MASTER
        public static void Import_PR_MASTER()
        {
            try
            {
                string str = @"select * from PR_MASTER";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<PR_MASTER>();
                var item = new PR_MASTER();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PR_MASTER";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PR_MASTER
                        {
                            PR_NO = row["PR_NO"].ToString(),
                            PR_DATE = ClsStrVulue.convertToDateTime(row["PR_DATE"]),
                            DEPTNO = row["DEPTNO"].ToString(),
                            EMPNO = row["EMPNO"].ToString(),
                            MNGNO = row["MNGNO"].ToString(),
                            PR_PAYMENT = row["PR_PAYMENT"].ToString(),
                            FLAG_OBJ = row["FLAG_OBJ"].ToString(),
                            OBJ_NAME1 = row["OBJ_NAME1"].ToString(),
                            OBJ_NAME2 = row["OBJ_NAME2"].ToString(),
                            OBJ_NAME3 = row["OBJ_NAME3"].ToString(),
                            FLAG_TYPE = row["FLAG_TYPE"].ToString(),
                            ESTIMATE_DAY = row["ESTIMATE_DAY"].ToString(),
                            SUPPLIER_ID = ClsStrVulue.convertToDecimal(row["SUPPLIER_ID"]),
                            PR_REMARK = row["PR_REMARK"].ToString(),
                            PR_STATUS = row["PR_STATUS"].ToString(),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                            MNG_REMARK = row["MNG_REMARK"].ToString(),
                            APPROVE_DATE = ClsStrVulue.convertToDateTime(row["APPROVE_DATE"]),
                            MS_USER = row["MS_USER"].ToString(),
                            VAT_INCLUDE = row["VAT_INCLUDE"].ToString(),
                            PR_TYPE = row["PR_TYPE"].ToString(),
                            PR_PATH = row["PR_PATH"].ToString(),
                            PAYCODE = row["PAYCODE"].ToString(),
                            JOBNO = row["JOBNO"].ToString(),  
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PR_MASTER", conn_sql, paramList, itemList))
                        Console.WriteLine("PR_MASTER save data error!!");
                    else
                        Console.WriteLine("PR_MASTER insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PR_AND_PO
        public static void Import_PR_AND_PO()
        {
            try
            {
                string str = @"select * from PR_AND_PO";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<PR_AND_PO>();
                var item = new PR_AND_PO();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PR_AND_PO";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PR_AND_PO
                        {
                            PO_NO = row["PO_NO"].ToString(),
                            PR_NO = row["PR_NO"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PR_AND_PO", conn_sql, paramList, itemList))
                        Console.WriteLine("PR_AND_PO save data error!!");
                    else
                        Console.WriteLine("PR_AND_PO insert complate!!");
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
