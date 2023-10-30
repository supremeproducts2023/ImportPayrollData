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
    public class MRP
    {
        static string conn_sql = ConfigurationManager.AppSettings["ConnectionString_SQLSERVER"].ToString();

        #region NMRP_OM
        public static void Import_NMRP_OM()
        {
            try
            {
                string str = @"select * from NMRP_OM";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NMRP_OM>();
                var item = new NMRP_OM();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NMRP_OM";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NMRP_OM
                        {
                            JOBNO = row["JOBNO"].ToString(),
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"]),
                            REQDATE = ClsStrVulue.convertToDateTime(row["REQDATE"]),
                            EMPNO = row["EMPNO"].ToString(),
                            CUSHOS_NO = ClsStrVulue.convertToDecimal(row["CUSHOS_NO"]),
                            DEPTNO = row["DEPTNO"].ToString(),
                            JOB_NAME = row["JOB_NAME"].ToString(),
                            STATUS = ClsStrVulue.convertToDecimal(row["STATUS"]),
                            O_DATE = ClsStrVulue.convertToDateTime(row["O_DATE"]),
                            O_EMPNO = row["O_EMPNO"].ToString(),
                            O_REMARKS = row["O_REMARKS"].ToString(),
                            MS_CLOSE_DATE = ClsStrVulue.convertToDateTime(row["MS_CLOSE_DATE"]),
                            MS_CLOSE_EMPNO = row["MS_CLOSE_EMPNO"].ToString(),
                            MS_CLOSE_REMARKS = row["MS_CLOSE_REMARKS"].ToString(),
                            ACC_CLOSE_DATE = ClsStrVulue.convertToDateTime(row["ACC_CLOSE_DATE"]),
                            ACC_CLOSE_EMPNO = row["ACC_CLOSE_EMPNO"].ToString(),
                            ACC_CLOSE_REMARKS = row["ACC_CLOSE_REMARKS"].ToString(),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                            AMBU1 = row["AMBU1"].ToString(),
                            AMBU2 = row["AMBU2"].ToString(),
                            AMBU3 = row["AMBU3"].ToString(),
                            AMBU4 = row["AMBU4"].ToString(),
                            KICK_USER = row["KICK_USER"].ToString(),
                            BOI_FLG = row["BOI_FLG"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NMRP_OM", conn_sql, paramList, itemList))
                        Console.WriteLine("NMRP_OM save data error!!");
                    else
                        Console.WriteLine("NMRP_OM insert complate!!");
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
