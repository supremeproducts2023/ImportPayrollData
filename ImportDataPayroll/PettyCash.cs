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
    public class PettyCash
    {
        static string conn_sql = ConfigurationManager.AppSettings["ConnectionString_SQLSERVER"].ToString();

        #region PTY_CASH
        public static void Import_PTY_CASH()
        {
            try
            {
                string str = @"select * from PTY_CASH";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PTY_CASH>();
                var item = new PTY_CASH();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PTY_CASH";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PTY_CASH
                        {
                            C_ID = row["C_ID"].ToString(),
                            C_BALANCE = ClsStrVulue.convertToDecimal(row["C_BALANCE"]),
                            C_D_WD = row["C_D_WD"].ToString(),
                            C_WDAMOUNT = ClsStrVulue.convertToDecimal(row["C_WDAMOUNT"]),
                            C_WDSTAUS = row["C_WDSTAUS"].ToString(),
                            C_CHECK_ID = row["C_CHECK_ID"].ToString(),
                            C_DCHECK = row["C_DCHECK"].ToString(),
                            C_BANK_CODE = row["C_BANK_CODE"].ToString(),
                            C_TOTALAMOUNT = ClsStrVulue.convertToDecimal(row["C_TOTALAMOUNT"]),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            SC_ID = row["SC_ID"].ToString(),
                            C_STATUS_WD = row["C_STATUS_WD"].ToString(),
                            C_INSERT = ClsStrVulue.convertToDecimal(row["C_INSERT"]),
                            C_REDUCE = ClsStrVulue.convertToDecimal(row["C_REDUCE"]),
                            C_D_REFWD = row["C_D_REFWD"].ToString(),
                            C_REMARK = row["C_REMARK"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PTY_CASH", conn_sql, paramList, itemList))
                        Console.WriteLine("PTY_CASH save data error!!");
                    else
                        Console.WriteLine("PTY_CASH insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PTY_EXCELCONFIG
        public static void Import_PTY_EXCELCONFIG()
        {
            try
            {
                string str = @"select * from PTY_EXCELCONFIG";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PTY_EXCELCONFIG>();
                var item = new PTY_EXCELCONFIG();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PTY_EXCELCONFIG";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PTY_EXCELCONFIG
                        {
                            EC_ID = ClsStrVulue.convertToInt(row["EC_ID"]),
                            EC_C1 = row["EC_C1"].ToString(),
                            EC_C2 = row["EC_C2"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            EC_C3 = row["EC_C3"].ToString(),
                            EC_C4 = row["EC_C4"].ToString(),
                            EC_C5 = row["EC_C5"].ToString(),
                            EC_C6 = row["EC_C6"].ToString(),
                            EC_C7 = row["EC_C7"].ToString(),
                            ROWSBEGIN = ClsStrVulue.convertToInt(row["ROWSBEGIN"]),
                            EC_C8 = row["EC_C8"].ToString(),
                            ROWSEND = ClsStrVulue.convertToInt(row["ROWSEND"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PTY_EXCELCONFIG", conn_sql, paramList, itemList))
                        Console.WriteLine("PTY_EXCELCONFIG save data error!!");
                    else
                        Console.WriteLine("PTY_EXCELCONFIG insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PTY_HISWD
        public static void Import_PTY_HISWD()
        {
            try
            {
                string str = @"select * from PTY_HISWD";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PTY_HISWD>();
                var item = new PTY_HISWD();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PTY_HISWD";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PTY_HISWD
                        {
                            HIS_ID = ClsStrVulue.convertToInt(row["HIS_ID"]),
                            WS_ID = row["WS_ID"].ToString(),
                            HIS_AMOUNT = ClsStrVulue.convertToDecimal(row["HIS_AMOUNT"]),
                            HIS_SUBAMOUNT = ClsStrVulue.convertToDecimal(row["HIS_SUBAMOUNT"]),
                            HIT_PLUSAMOUNT = ClsStrVulue.convertToDecimal(row["HIT_PLUSAMOUNT"]),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            HIS_SAMOUNT = ClsStrVulue.convertToDecimal(row["HIS_SAMOUNT"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PTY_HISWD", conn_sql, paramList, itemList))
                        Console.WriteLine("PTY_HISWD save data error!!");
                    else
                        Console.WriteLine("PTY_HISWD insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PTY_PAYTYPE
        public static void Import_PTY_PAYTYPE()
        {
            try
            {
                string str = @"select * from PTY_PAYTYPE";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PTY_PAYTYPE>();
                var item = new PTY_PAYTYPE();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PTY_PAYTYPE";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PTY_PAYTYPE
                        {
                            TYPENO = row["TYPENO"].ToString(),
                            TYPENAME = row["TYPENAME"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            TYPE_STATUS = row["TYPE_STATUS"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PTY_PAYTYPE", conn_sql, paramList, itemList))
                        Console.WriteLine("PTY_PAYTYPE save data error!!");
                    else
                        Console.WriteLine("PTY_PAYTYPE insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PTY_PERMISSION
        public static void Import_PTY_PERMISSION()
        {
            try
            {
                string str = @"select * from PTY_PERMISSION";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PTY_PERMISSION>();
                var item = new PTY_PERMISSION();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PTY_PERMISSION";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PTY_PERMISSION
                        {
                            PER_ID = ClsStrVulue.convertToDecimal(row["PER_ID"]),
                            EMP_NO = row["EMP_NO"].ToString(),
                            PACCESS_MENU = row["PACCESS_MENU"].ToString(),
                            PWORK = row["PWORK"].ToString(),
                            PWELFARE = row["PWELFARE"].ToString(),
                            PMONTH = row["PMONTH"].ToString(),
                            PCONFIG = row["PCONFIG"].ToString(),
                            PSAVEDATA = row["PSAVEDATA"].ToString(),
                            PSALARY = row["PSALARY"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            PREPORT = row["PREPORT"].ToString(),
                            PEXPORT = row["PEXPORT"].ToString(),
                            GROUP_NO = ClsStrVulue.convertToInt(row["GROUP_NO"]),
                            PADVANCE = row["PADVANCE"].ToString(),
                            PLEVEL = row["PLEVEL"].ToString(),

                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PTY_PERMISSION", conn_sql, paramList, itemList))
                        Console.WriteLine("PTY_PERMISSION save data error!!");
                    else
                        Console.WriteLine("PTY_PERMISSION insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PTY_REFUND
        public static void Import_PTY_REFUND()
        {
            try
            {
                string str = @"select * from PTY_REFUND";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PTY_REFUND>();
                var item = new PTY_REFUND();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PTY_REFUND";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PTY_REFUND
                        {
                            RE_ID = row["RE_ID"].ToString(),
                            RE_DATE = row["RE_DATE"].ToString(),
                            RE_AMOUNT = ClsStrVulue.convertToDecimal(row["RE_AMOUNT"]),
                            WSS_ID = row["WSS_ID"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            COM_ID = row["COM_ID"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PTY_REFUND", conn_sql, paramList, itemList))
                        Console.WriteLine("PTY_REFUND save data error!!");
                    else
                        Console.WriteLine("PTY_REFUND insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PTY_SUMCASH
        public static void Import_PTY_SUMCASH()
        {
            try
            {
                string str = @"select * from PTY_SUMCASH";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PTY_SUMCASH>();
                var item = new PTY_SUMCASH();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PTY_SUMCASH";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PTY_SUMCASH
                        {
                            SC_ID = row["SC_ID"].ToString(),
                            SC_BALANCE = row["SC_BALANCE"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            SC_DATE = row["SC_DATE"].ToString(),
                            SC_STATUS = row["SC_STATUS"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            SC_WSTATUS = row["SC_WSTATUS"].ToString(),
                            SC_TOTALBALANCE = ClsStrVulue.convertToDecimal(row["SC_TOTALBALANCE"]),
                            FLG_STODAY = ClsStrVulue.convertToInt(row["FLG_STODAY"]),
                            SC_FORMBALANCE = ClsStrVulue.convertToDecimal(row["SC_FORMBALANCE"]),
                            CUSER = row["CUSER"].ToString(),
                            CDATE = row["CDATE"].ToString(),
                            CTIME = row["CTIME"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PTY_SUMCASH", conn_sql, paramList, itemList))
                        Console.WriteLine("PTY_SUMCASH save data error!!");
                    else
                        Console.WriteLine("PTY_SUMCASH insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PTY_SUMWDRESERVE
        public static void Import_PTY_SUMWDRESERVE()
        {
            try
            {
                string str = @"select * from PTY_SUMWDRESERVE";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PTY_SUMWDRESERVE>();
                var item = new PTY_SUMWDRESERVE();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PTY_SUMWDRESERVE";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PTY_SUMWDRESERVE
                        {
                            WSS_ID = row["WSS_ID"].ToString(),
                            WSS_D = row["WSS_D"].ToString(),
                            WSS_BALANCE = ClsStrVulue.convertToDecimal(row["WSS_BALANCE"]),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            WSS_EMPNO = row["WSS_EMPNO"].ToString(),
                            WSS_TOTAL_BALANCE = ClsStrVulue.convertToDecimal(row["WSS_TOTAL_BALANCE"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PTY_SUMWDRESERVE", conn_sql, paramList, itemList))
                        Console.WriteLine("PTY_SUMWDRESERVE save data error!!");
                    else
                        Console.WriteLine("PTY_SUMWDRESERVE insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PTY_WDRESERVE
        public static void Import_PTY_WDRESERVE()
        {
            try
            {
                string str = @"select * from PTY_WDRESERVE";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PTY_WDRESERVE>();
                var item = new PTY_WDRESERVE();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PTY_WDRESERVE";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PTY_WDRESERVE
                        {
                            WS_ID = row["WS_ID"].ToString(),
                            WS_D_WD = row["WS_D_WD"].ToString(),
                            WS_EMPID = row["WS_EMPID"].ToString(),
                            WS_AMOUNT = ClsStrVulue.convertToDecimal(row["WS_AMOUNT"]),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            SC_ID = row["SC_ID"].ToString(),
                            WSS_ID = row["WSS_ID"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PTY_WDRESERVE", conn_sql, paramList, itemList))
                        Console.WriteLine("PTY_WDRESERVE save data error!!");
                    else
                        Console.WriteLine("PTY_WDRESERVE insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PTY_WDRESERVE_DETAIL
        public static void Import_PTY_WDRESERVE_DETAIL()
        {
            try
            {
                string str = @"select * from PTY_WDRESERVE_DETAIL";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PTY_WDRESERVE_DETAIL>();
                var item = new PTY_WDRESERVE_DETAIL();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PTY_WDRESERVE_DETAIL";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PTY_WDRESERVE_DETAIL
                        {
                            WS_ID = row["WS_ID"].ToString(),
                            WSD_ID = row["WSD_ID"].ToString(),
                            WSD_D_WD = row["WSD_D_WD"].ToString(),
                            WSD_TYPE = row["WSD_TYPE"].ToString(),
                            WSD_AMOUNT = ClsStrVulue.convertToDecimal(row["WSD_AMOUNT"]),
                            WSD_BALANCE = ClsStrVulue.convertToDecimal(row["WSD_BALANCE"]),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PTY_WDRESERVE_DETAIL", conn_sql, paramList, itemList))
                        Console.WriteLine("PTY_WDRESERVE_DETAIL save data error!!");
                    else
                        Console.WriteLine("PTY_WDRESERVE_DETAIL insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PTY_WITHDRAWALS_DAILY
        public static void Import_PTY_WITHDRAWALS_DAILY()
        {
            try
            {
                string str = @"select * from PTY_WITHDRAWALS_DAILY";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PTY_WITHDRAWALS_DAILY>();
                var item = new PTY_WITHDRAWALS_DAILY();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PTY_WITHDRAWALS_DAILY";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PTY_WITHDRAWALS_DAILY
                        {
                            WD_ID = ClsStrVulue.convertToInt(row["WD_ID"]),
                            WD_DATE = row["WD_DATE"].ToString(),
                            TYPENO = row["TYPENO"].ToString(),
                            WD_PAYTO = row["WD_PAYTO"].ToString(),
                            WD_PO = row["WD_PO"].ToString(),
                            WD_AMOUNT = ClsStrVulue.convertToDecimal(row["WD_AMOUNT"]),
                            WD_COMMENT = row["WD_COMMENT"].ToString(),
                            WSS_ID = row["WSS_ID"].ToString(),
                            WD_BC_DATE = row["WD_BC_DATE"].ToString(),
                            WD_BC_BANK = row["WD_BC_BANK"].ToString(),
                            WD_BC_TRANFERTO = row["WD_BC_TRANFERTO"].ToString(),
                            WD_BC_TRANFERFROM = row["WD_BC_TRANFERFROM"].ToString(),
                            WD_M_DATE = row["WD_M_DATE"].ToString(),
                            WD_M_EMP = row["WD_M_EMP"].ToString(),
                            WD_M_PLATE = row["WD_M_PLATE"].ToString(),
                            WD_M_OIL = ClsStrVulue.convertToInt(row["WD_M_OIL"]),
                            WD_M_PENALTY = ClsStrVulue.convertToInt(row["WD_M_PENALTY"]),
                            WD_M_MOTORCYCLE = ClsStrVulue.convertToInt(row["WD_M_MOTORCYCLE"]),
                            WD_M_MD_MOTORCYCLE = ClsStrVulue.convertToInt(row["WD_M_MD_MOTORCYCLE"]),
                            WD_M_OTHER = ClsStrVulue.convertToInt(row["WD_M_OTHER"]),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            WD_PAYTO_TYPE = row["WD_PAYTO_TYPE"].ToString(),
                            WD_ADVANCE = row["WD_ADVANCE"].ToString(),
                            WD_RECEIPT = row["WD_RECEIPT"].ToString(),
                            WD_STATUS = row["WD_STATUS"].ToString(),
                            WD_COMMENT_RETURN = row["WD_COMMENT_RETURN"].ToString(),
                            WD_COMMENT_EDIT = row["WD_COMMENT_EDIT"].ToString(),
                            WD_ID_REF = ClsStrVulue.convertToInt(row["WD_ID_REF"]),
                            WD_PAYTO_BILL = row["WD_PAYTO_BILL"].ToString(),
                            WD_BILL = row["WD_BILL"].ToString(),
                            TYPE_DETAIL = row["TYPE_DETAIL"].ToString(),
                            WD_DATE_REF = row["WD_DATE_REF"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PTY_WITHDRAWALS_DAILY", conn_sql, paramList, itemList))
                        Console.WriteLine("PTY_WITHDRAWALS_DAILY save data error!!");
                    else
                        Console.WriteLine("PTY_WITHDRAWALS_DAILY insert complate!!");
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
