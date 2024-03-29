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

        #region NMRP_FM
        public static void Import_NMRP_FM()
        {
            try
            {
                string str = @"select * from NMRP_FM";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NMRP_FM>();
                var item = new NMRP_FM();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NMRP_FM";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NMRP_FM
                        {
                            F_NO = row["F_NO"].ToString(),
                            F_DATE = ClsStrVulue.convertToDateTime(row["F_DATE"]),
                            JOBNO = row["JOBNO"].ToString(),
                            EMPNO = row["EMPNO"].ToString(),
                            STATUS = ClsStrVulue.convertToDecimal(row["STATUS"]),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                            KICK_USER = row["KICK_USER"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NMRP_FM", conn_sql, paramList, itemList))
                        Console.WriteLine("NMRP_FM save data error!!");
                    else
                        Console.WriteLine("NMRP_FM insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NMRP_FD
        public static void Import_NMRP_FD()
        {
            try
            {
                string str = @"select * from NMRP_FD";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NMRP_FD>();
                var item = new NMRP_FD();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NMRP_FD";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NMRP_FD
                        {
                            F_NO = row["F_NO"].ToString(),
                            BOM_CODE = ClsStrVulue.convertToDecimal(row["BOM_CODE"]),
                            QTY = ClsStrVulue.convertToDecimal(row["QTY"]),
                            SEND_DATE = ClsStrVulue.convertToDateTime(row["SEND_DATE"]),
                            F_REMARKS = row["F_REMARKS"].ToString(),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NMRP_FD", conn_sql, paramList, itemList))
                        Console.WriteLine("NMRP_FD save data error!!");
                    else
                        Console.WriteLine("NMRP_FD insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NMRP_PM
        public static void Import_NMRP_PM()
        {
            try
            {
                string str = @"select * from NMRP_PM";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NMRP_PM>();
                var item = new NMRP_PM();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NMRP_PM";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NMRP_PM
                        {
                            P_NO = row["P_NO"].ToString(),
                            BOM_CODE = ClsStrVulue.convertToDecimal(row["BOM_CODE"]),
                            P_DATE = ClsStrVulue.convertToDateTime(row["P_DATE"]),
                            P_EMPNO = row["P_EMPNO"].ToString(),
                            P_REMARKS = row["P_REMARKS"].ToString(),
                            SPEC = row["SPEC"].ToString(),
                            STATUS = ClsStrVulue.convertToDecimal(row["STATUS"]),
                            BRANCH = ClsStrVulue.convertToDecimal(row["BRANCH"]),
                            C_DATE = ClsStrVulue.convertToDateTime(row["C_DATE"]),
                            C_EMPNO = row["C_EMPNO"].ToString(),
                            C_REMARKS = row["C_REMARKS"].ToString(),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                            KICK_USER = row["KICK_USER"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NMRP_PM", conn_sql, paramList, itemList))
                        Console.WriteLine("NMRP_PM save data error!!");
                    else
                        Console.WriteLine("NMRP_PM insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NMRP_PD
        public static void Import_NMRP_PD()
        {
            try
            {
                string str = @"select * from NMRP_PD";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NMRP_PD>();
                var item = new NMRP_PD();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NMRP_PD";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NMRP_PD
                        {
                            P_NO = row["P_NO"].ToString(),
                            F_NO = row["F_NO"].ToString(),
                            QTY = ClsStrVulue.convertToDecimal(row["QTY"]),
                            P_REMARKS = row["P_REMARKS"].ToString(),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NMRP_PD", conn_sql, paramList, itemList))
                        Console.WriteLine("NMRP_PD save data error!!");
                    else
                        Console.WriteLine("NMRP_PD insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NMRP_TM
        public static void Import_NMRP_TM()
        {
            try
            {
                string str = @"select * from NMRP_TM";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NMRP_TM>();
                var item = new NMRP_TM();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NMRP_TM";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NMRP_TM
                        {
                            T_NO = row["T_NO"].ToString(),
                            T_DATE = ClsStrVulue.convertToDateTime(row["T_DATE"]),
                            EMPNO = row["EMPNO"].ToString(),
                            STATUS = ClsStrVulue.convertToDecimal(row["STATUS"]),
                            ROLLBACK_REMARK = row["ROLLBACK_REMARK"].ToString(),
                            P_NO = row["P_NO"].ToString(),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                            SENT_TO_DATE = ClsStrVulue.convertToDateTime(row["SENT_TO_DATE"]),
                            KICK_USER = row["KICK_USER"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NMRP_TM", conn_sql, paramList, itemList))
                        Console.WriteLine("NMRP_TM save data error!!");
                    else
                        Console.WriteLine("NMRP_TM insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NMRP_TD
        public static void Import_NMRP_TD()
        {
            try
            {
                string str = @"select * from NMRP_TD";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NMRP_TD>();
                var item = new NMRP_TD();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NMRP_TD";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NMRP_TD
                        {
                            T_RUN = ClsStrVulue.convertToDecimal(row["T_RUN"]),
                            T_NO = row["T_NO"].ToString(),
                            QTY = ClsStrVulue.convertToDecimal(row["QTY"]),
                            T_REMARKS = row["T_REMARKS"].ToString(),
                            F_NO = row["F_NO"].ToString(),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NMRP_TD", conn_sql, paramList, itemList))
                        Console.WriteLine("NMRP_TD save data error!!");
                    else
                        Console.WriteLine("NMRP_TD insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NMRP_YM
        public static void Import_NMRP_YM()
        {
            try
            {
                string str = @"select * from NMRP_YM";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NMRP_YM>();
                var item = new NMRP_YM();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NMRP_YM";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NMRP_YM
                        {
                            Y_NO = row["Y_NO"].ToString(),
                            Y_DATE = ClsStrVulue.convertToDateTime(row["Y_DATE"]),
                            EMP_NO = row["EMP_NO"].ToString(),
                            STATUS = ClsStrVulue.convertToDecimal(row["STATUS"]),
                            ROLLBACK_REMARKS = row["ROLLBACK_REMARKS"].ToString(),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                            KICK_USER = row["KICK_USER"].ToString(),
                            GAR_NO = row["GAR_NO"].ToString(),
                            SUPPLIER_ID = ClsStrVulue.convertToDecimal(row["SUPPLIER_ID"]),
                            BRANCH = ClsStrVulue.convertToDecimal(row["BRANCH"]),
                            B_NO = row["B_NO"].ToString(),
                            DOC_TYPE = row["DOC_TYPE"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NMRP_YM", conn_sql, paramList, itemList))
                        Console.WriteLine("NMRP_YM save data error!!");
                    else
                        Console.WriteLine("NMRP_YM insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NMRP_YD
        public static void Import_NMRP_YD()
        {
            try
            {
                string str = @"select * from NMRP_YD";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NMRP_YD>();
                var item = new NMRP_YD();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NMRP_YD";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NMRP_YD
                        {
                            Y_RUN = ClsStrVulue.convertToDecimal(row["Y_RUN"]),
                            Y_NO = row["Y_NO"].ToString(),
                            BOM_CODE = ClsStrVulue.convertToDecimal(row["BOM_CODE"]),
                            QTY = row["QTY"].ToString(),
                            Y_REMARKS = row["Y_REMARKS"].ToString(),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NMRP_YD", conn_sql, paramList, itemList))
                        Console.WriteLine("NMRP_YD save data error!!");
                    else
                        Console.WriteLine("NMRP_YD insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NMRP_LOT_IN
        public static void Import_NMRP_LOT_IN()
        {
            try
            {
                string str = @"select * from NMRP_LOT_IN";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NMRP_LOT_IN>();
                var item = new NMRP_LOT_IN();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NMRP_LOT_IN";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NMRP_LOT_IN
                        {
                            IN_ID = ClsStrVulue.convertToDecimal(row["IN_ID"]),
                            BRANCH = ClsStrVulue.convertToDecimal(row["BRANCH"]),
                            BOM_CODE = ClsStrVulue.convertToDecimal(row["BOM_CODE"]),
                            STATUS = ClsStrVulue.convertToDecimal(row["STATUS"]),
                            DOC_RUN = ClsStrVulue.convertToDecimal(row["DOC_RUN"]),
                            DOC_TYPE = row["DOC_TYPE"].ToString(),
                            LOT = row["LOT"].ToString(),
                            SERIAL = row["SERIAL"].ToString(),
                            COST = ClsStrVulue.convertToDecimal(row["COST"]),
                            QTY = ClsStrVulue.convertToDecimal(row["QTY"]),
                            GAR = row["GAR"].ToString(),
                            PRODUCE_FOR = row["PRODUCE_FOR"].ToString(),
                            GWD_USER = row["GWD_USER"].ToString(),
                            GWD_DATE = ClsStrVulue.convertToDateTime(row["GWD_DATE"]),
                            STK_ORDER = ClsStrVulue.convertToDecimal(row["STK_ORDER"]),
                            STK_USER = row["STK_USER"].ToString(),
                            STK_DATE = ClsStrVulue.convertToDateTime(row["STK_DATE"]),
                            IN_ID_M = ClsStrVulue.convertToDecimal(row["IN_ID_M"]),
                            GARNO = row["GARNO"].ToString(),
                            RM_RUN = ClsStrVulue.convertToDecimal(row["RM_RUN"]),
                            T_NO = row["T_NO"].ToString(),
                            CHANGE_NO = row["CHANGE_NO"].ToString(),
                            STK_COMMIT = ClsStrVulue.convertToDateTime(row["STK_COMMIT"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NMRP_LOT_IN", conn_sql, paramList, itemList))
                        Console.WriteLine("NMRP_LOT_IN save data error!!");
                    else
                        Console.WriteLine("NMRP_LOT_IN insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NMRP_LOT_OUT
        public static void Import_NMRP_LOT_OUT()
        {
            try
            {
                string str = @"select * from NMRP_LOT_OUT";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NMRP_LOT_OUT>();
                var item = new NMRP_LOT_OUT();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NMRP_LOT_OUT";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NMRP_LOT_OUT
                        {
                            OUT_ID = ClsStrVulue.convertToDecimal(row["OUT_ID"]),
                            BRANCH = ClsStrVulue.convertToDecimal(row["BRANCH"]),
                            IN_ID = ClsStrVulue.convertToDecimal(row["IN_ID"]),
                            STATUS = ClsStrVulue.convertToDecimal(row["STATUS"]),
                            DOC_RUN = ClsStrVulue.convertToDecimal(row["DOC_RUN"]),
                            DOC_TYPE = row["DOC_TYPE"].ToString(),
                            QTY = ClsStrVulue.convertToDecimal(row["QTY"]),
                            GWD_USER = row["GWD_USER"].ToString(),
                            GWD_DATE = ClsStrVulue.convertToDateTime(row["GWD_DATE"]),
                            STK_ORDER = ClsStrVulue.convertToDecimal(row["STK_ORDER"]),
                            STK_USER = row["STK_USER"].ToString(),
                            STK_DATE = ClsStrVulue.convertToDateTime(row["STK_DATE"]),
                            CHANGE_NO = row["CHANGE_NO"].ToString(),
                            STK_COMMIT = ClsStrVulue.convertToDateTime(row["STK_COMMIT"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NMRP_LOT_OUT", conn_sql, paramList, itemList))
                        Console.WriteLine("NMRP_LOT_OUT save data error!!");
                    else
                        Console.WriteLine("NMRP_LOT_OUT insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NMRP_LOBOR_HOUR
        public static void Import_NMRP_LOBOR_HOUR()
        {
            try
            {
                string str = @"select * from NMRP_LOBOR_HOUR";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NMRP_LOBOR_HOUR>();
                var item = new NMRP_LOBOR_HOUR();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NMRP_LOBOR_HOUR";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NMRP_LOBOR_HOUR
                        {
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            EMPNO = row["EMPNO"].ToString(),
                            DATE_WORK = ClsStrVulue.convertToDateTime(row["DATE_WORK"]),
                            JOBNO = row["JOBNO"].ToString(),
                            LOBOR_HOUR = ClsStrVulue.convertToDecimal(row["LOBOR_HOUR"]),
                            REMARK = row["REMARK"].ToString(),
                            LAST_UP = ClsStrVulue.convertToDateTime(row["LAST_UP"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NMRP_LOBOR_HOUR", conn_sql, paramList, itemList))
                        Console.WriteLine("NMRP_LOBOR_HOUR save data error!!");
                    else
                        Console.WriteLine("NMRP_LOBOR_HOUR insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NMRP_LOCATION
        public static void Import_NMRP_LOCATION()
        {
            try
            {
                string str = @"select * from NMRP_LOCATION";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NMRP_LOCATION>();
                var item = new NMRP_LOCATION();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NMRP_LOCATION";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NMRP_LOCATION
                        {
                            LOCATION_ID = ClsStrVulue.convertToDecimal(row["LOCATION_ID"]),
                            LOCATION_NAME = row["LOCATION_NAME"].ToString(),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NMRP_LOCATION", conn_sql, paramList, itemList))
                        Console.WriteLine("NMRP_LOCATION save data error!!");
                    else
                        Console.WriteLine("NMRP_LOCATION insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NMRP_ADJUST_M
        public static void Import_NMRP_ADJUST_M()
        {
            try
            {
                string str = @"select * from NMRP_ADJUST_M";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NMRP_ADJUST_M>();
                var item = new NMRP_ADJUST_M();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NMRP_ADJUST_M";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NMRP_ADJUST_M
                        {
                            E_NO = row["E_NO"].ToString(),
                            E_DATE = ClsStrVulue.convertToDateTime(row["E_DATE"]),
                            E_TYPE = row["E_TYPE"].ToString(),
                            REMARKS = row["REMARKS"].ToString(),
                            STATUS = ClsStrVulue.convertToDecimal(row["STATUS"]),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NMRP_ADJUST_M", conn_sql, paramList, itemList))
                        Console.WriteLine("NMRP_ADJUST_M save data error!!");
                    else
                        Console.WriteLine("NMRP_ADJUST_M insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NMRP_ADJUST_D
        public static void Import_NMRP_ADJUST_D()
        {
            try
            {
                string str = @"select * from NMRP_ADJUST_D";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NMRP_ADJUST_D>();
                var item = new NMRP_ADJUST_D();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NMRP_ADJUST_D";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NMRP_ADJUST_D
                        {
                            E_RUN = ClsStrVulue.convertToDecimal(row["E_RUN"]),
                            E_NO = row["E_NO"].ToString(),
                            BOM_CODE = ClsStrVulue.convertToDecimal(row["BOM_CODE"]),
                            QTY = ClsStrVulue.convertToDecimal(row["QTY"]),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NMRP_ADJUST_D", conn_sql, paramList, itemList))
                        Console.WriteLine("NMRP_ADJUST_D save data error!!");
                    else
                        Console.WriteLine("NMRP_ADJUST_D insert complate!!");
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
