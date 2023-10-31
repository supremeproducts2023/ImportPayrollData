﻿using System.Collections.Generic;
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

        #region NMRP_OD
        public static void Import_NMRP_OD()
        {
            try
            {
                string str = @"select * from NMRP_OD";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NMRP_OD>();
                var item = new NMRP_OD();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NMRP_OD";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NMRP_OD
                        {
                            O_RUN = ClsStrVulue.convertToDecimal(row["O_RUN"]),
                            JOBNO = row["JOBNO"].ToString(),
                            BOM_CODE = ClsStrVulue.convertToDecimal(row["BOM_CODE"]),
                            PRODNO = ClsStrVulue.convertToDecimal(row["PRODNO"]),
                            O_SPEC = row["O_SPEC"].ToString(),
                            O_QTY = ClsStrVulue.convertToDecimal(row["O_QTY"]),
                            O_SEND = ClsStrVulue.convertToDateTime(row["O_SEND"]),
                            O_COST = ClsStrVulue.convertToDecimal(row["O_COST"]),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NMRP_OD", conn_sql, paramList, itemList))
                        Console.WriteLine("NMRP_OD save data error!!");
                    else
                        Console.WriteLine("NMRP_OD insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NMRP_BM
        public static void Import_NMRP_BM()
        {
            try
            {
                string str = @"select * from NMRP_BM";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NMRP_BM>();
                var item = new NMRP_BM();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NMRP_BM";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NMRP_BM
                        {
                            B_NO = row["B_NO"].ToString(),
                            B_DATE = ClsStrVulue.convertToDateTime(row["B_DATE"]),
                            EMPNO = row["EMPNO"].ToString(),
                            STATUS = ClsStrVulue.convertToDecimal(row["STATUS"]),
                            ROLLBACK_REMARK = row["ROLLBACK_REMARK"].ToString(),
                            DOC_TYPE = row["DOC_TYPE"].ToString(),
                            BRANCH_BEGIN = ClsStrVulue.convertToDecimal(row["BRANCH_BEGIN"]),
                            BRANCH_END = ClsStrVulue.convertToDecimal(row["BRANCH_END"]),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                            SENT_TO_DATE = ClsStrVulue.convertToDateTime(row["SENT_TO_DATE"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NMRP_BM", conn_sql, paramList, itemList))
                        Console.WriteLine("NMRP_BM save data error!!");
                    else
                        Console.WriteLine("NMRP_BM insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NMRP_BD
        public static void Import_NMRP_BD()
        {
            try
            {
                string str = @"select * from NMRP_BD";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NMRP_BD>();
                var item = new NMRP_BD();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NMRP_BD";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NMRP_BD
                        {
                            B_RUN = ClsStrVulue.convertToDecimal(row["B_RUN"]),
                            B_NO = row["B_NO"].ToString(),
                            QTY = ClsStrVulue.convertToDecimal(row["QTY"]),
                            B_REMARKS = row["B_REMARKS"].ToString(),
                            BOM_CODE = ClsStrVulue.convertToDecimal(row["BOM_CODE"]),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NMRP_BD", conn_sql, paramList, itemList))
                        Console.WriteLine("NMRP_BD save data error!!");
                    else
                        Console.WriteLine("NMRP_BD insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NMRP_IRM
        public static void Import_NMRP_IRM()
        {
            try
            {
                string str = @"select * from NMRP_IRM";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NMRP_IRM>();
                var item = new NMRP_IRM();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NMRP_IRM";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NMRP_IRM
                        {
                            IR_NO = row["IR_NO"].ToString(),
                            P_NO = row["P_NO"].ToString(),
                            IR_DATE = ClsStrVulue.convertToDateTime(row["IR_DATE"]),
                            EMPNO = row["EMPNO"].ToString(),
                            STATUS = ClsStrVulue.convertToDecimal(row["STATUS"]),
                            ROLLBACK_REMARK = row["ROLLBACK_REMARK"].ToString(),
                            DOC_TYPE = row["DOC_TYPE"].ToString(),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                            SENT_TO_DATE = ClsStrVulue.convertToDateTime(row["SENT_TO_DATE"]),
                            KICK_USER = row["KICK_USER"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NMRP_IRM", conn_sql, paramList, itemList))
                        Console.WriteLine("NMRP_IRM save data error!!");
                    else
                        Console.WriteLine("NMRP_IRM insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NMRP_IRD
        public static void Import_NMRP_IRD()
        {
            try
            {
                string str = @"select * from NMRP_IRD";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NMRP_IRD>();
                var item = new NMRP_IRD();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NMRP_IRD";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NMRP_IRD
                        {
                            IR_RUN = ClsStrVulue.convertToDecimal(row["IR_RUN"]),
                            IR_NO = row["IR_NO"].ToString(),
                            BOM_CODE = ClsStrVulue.convertToDecimal(row["BOM_CODE"]),
                            QTY = ClsStrVulue.convertToDecimal(row["QTY"]),
                            IR_REMARKS = row["IR_REMARKS"].ToString(),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NMRP_IRD", conn_sql, paramList, itemList))
                        Console.WriteLine("NMRP_IRD save data error!!");
                    else
                        Console.WriteLine("NMRP_IRD insert complate!!");
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