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
    public class Hamsco
    {
        static string conn_sql = ConfigurationManager.AppSettings["ConnectionString_SQLSERVER_HAMSCO"].ToString();

        #region EMP
        public static void Import_EMP()
        {
            try
            {
                string str = @"select * from EMP";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn_Hamsco()).Tables[0];

                var itemList = new List<EMP>();
                var item = new EMP();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table EMP";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new EMP
                        {
                            EMPNO = row["EMPNO"].ToString(),
                            E_TITLE = row["E_TITLE"].ToString(),
                            E_NAME = row["E_NAME"].ToString(),
                            HIREDATE = ClsStrVulue.convertToDateTime(row["HIREDATE"]),
                            DEPTNO = row["DEPTNO"].ToString(),
                            MNGNO = row["MNGNO"].ToString(),
                            E_JOB = row["E_JOB"].ToString(),
                            E_SITUATION = row["E_SITUATION"].ToString(),
                            QUITDATE = ClsStrVulue.convertToDateTime(row["QUITDATE"]),
                            E_MOBILE = row["E_MOBILE"].ToString(),
                            E_PAGER = row["E_PAGER"].ToString(),
                            E_EXTENTION = row["E_EXTENTION"].ToString(),
                            EMP_RECORDER = row["EMP_RECORDER"].ToString(),
                            S_DEPTNO = row["S_DEPTNO"].ToString(),
                            E_MAIL = row["E_MAIL"].ToString(),
                            E_NAME_EN = row["E_NAME_EN"].ToString(),
                            E_NICKNAME = row["E_NICKNAME"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                            POSITION_NO = ClsStrVulue.convertToDecimal(row["POSITION_NO"]),
                            SENT_TO_SAP = row["SENT_TO_SAP"].ToString(),
                            SENT_TO_DATE = ClsStrVulue.convertToDateTime(row["SENT_TO_DATE"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("EMP", conn_sql, paramList, itemList))
                        Console.WriteLine("EMP save data error!!");
                    else
                        Console.WriteLine("EMP insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region REQUISITION
        public static void Import_REQUISITION()
        {
            try
            {
                string str = @"select * from REQUISITION";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn_Hamsco()).Tables[0];

                var itemList = new List<REQUISITION>();
                var item = new REQUISITION();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table REQUISITION";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new REQUISITION
                        {
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"]),
                            HOSNO = ClsStrVulue.convertToDecimal(row["HOSNO"]),
                            CUSNO = ClsStrVulue.convertToDecimal(row["CUSNO"]),
                            ORDERBY = row["ORDERBY"].ToString(),
                            SENDTO = row["SENDTO"].ToString(),
                            QUOTNO = row["QUOTNO"].ToString(),
                            S_DEPTNO = row["S_DEPTNO"].ToString(),
                            REQDATE = ClsStrVulue.convertToDateTime(row["REQDATE"]),
                            GRANDTOTAL1 = ClsStrVulue.convertToDecimal(row["GRANDTOTAL1"]),
                            GRANDTOTAL2 = ClsStrVulue.convertToDecimal(row["GRANDTOTAL2"]),
                            ENDUSER = row["ENDUSER"].ToString(),
                            EVALUATOR = row["EVALUATOR"].ToString(),
                            DECISIONMAKER = row["DECISIONMAKER"].ToString(),
                            CREDITTERM = ClsStrVulue.convertToDecimal(row["CREDITTERM"]),
                            PAYMENT_ID = ClsStrVulue.convertToDecimal(row["PAYMENT_ID"]),
                            PAYMENT_APPROVAL = row["PAYMENT_APPROVAL"].ToString(),
                            REQ_STATUS = row["REQ_STATUS"].ToString(),
                            ERGENT_REQ = row["ERGENT_REQ"].ToString(),
                            REQ_TYPE = ClsStrVulue.convertToDecimal(row["REQ_TYPE"]),
                            REQ_APPROVE = row["REQ_APPROVE"].ToString(),
                            ORDER_POST_REC = row["ORDER_POST_REC"].ToString(),
                            ORDER_REC = row["ORDER_REC"].ToString(),
                            STOCK1_REC = row["STOCK1_REC"].ToString(),
                            CREDIT1_REC = row["CREDIT1_REC"].ToString(),
                            IMPORT = row["IMPORT"].ToString(),
                            CREDIT2_REC = row["CREDIT2_REC"].ToString(),
                            STOCK2_REC = row["STOCK2_REC"].ToString(),
                            GODOWN_REC = row["GODOWN_REC"].ToString(),
                            CONTRACTNO = row["CONTRACTNO"].ToString(),
                            PONO = row["PONO"].ToString(),
                            DISCOUNT = ClsStrVulue.convertToDecimal(row["DISCOUNT"]),
                            ESP_PERCENTAGE = ClsStrVulue.convertToDecimal(row["ESP_PERCENTAGE"]),
                            UPDATE_TIME_STAMP = ClsStrVulue.convertToDateTime(row["UPDATE_TIME_STAMP"]),
                            REQ_UPDATE_BY = row["REQ_UPDATE_BY"].ToString(),
                            EMPNO = row["EMPNO"].ToString(),
                            REF_MAIN = ClsStrVulue.convertToDecimal(row["REF_MAIN"]),
                            REQ_VAC = ClsStrVulue.convertToDecimal(row["REQ_VAC"]),
                            CREDIT_NOTE = row["CREDIT_NOTE"].ToString(),
                            DELIVER_AT = ClsStrVulue.convertToDecimal(row["DELIVER_AT"]),
                            CONTACTNO_DATE = ClsStrVulue.convertToDateTime(row["CONTACTNO_DATE"]),
                            PONO_DATE = ClsStrVulue.convertToDateTime(row["PONO_DATE"]),
                            DELIVERY_DATE = ClsStrVulue.convertToDateTime(row["DELIVERY_DATE"]),
                            MS_RECEIVEDATE = ClsStrVulue.convertToDateTime(row["MS_RECEIVEDATE"]),
                            REQ_RECORD = row["REQ_RECORD"].ToString(),
                            BILL_SUB = row["BILL_SUB"].ToString(),
                            REQ_PROD = ClsStrVulue.convertToDecimal(row["REQ_PROD"]),
                            RECORD_DATE = ClsStrVulue.convertToDateTime(row["RECORD_DATE"]),
                            LASTUP_DATE = ClsStrVulue.convertToDateTime(row["LASTUP_DATE"]),
                            LASTUP_RECORD = row["LASTUP_RECORD"].ToString(),
                            JOB_NO = ClsStrVulue.convertToDecimal(row["JOB_NO"]),
                            DEPTNO = row["DEPTNO"].ToString(),
                            SPARE = ClsStrVulue.convertToDecimal(row["SPARE"]),
                            SERVICE = ClsStrVulue.convertToDecimal(row["SERVICE"]),
                            CHECK_ROUND = ClsStrVulue.convertToDecimal(row["CHECK_ROUND"]),
                            FORMAT_BILL = row["FORMAT_BILL"].ToString(),
                            VAC_BILL = ClsStrVulue.convertToDecimal(row["VAC_BILL"]),
                            VAC_PREQ = ClsStrVulue.convertToDecimal(row["VAC_PREQ"]),
                            GODOWN_DATE = ClsStrVulue.convertToDateTime(row["GODOWN_DATE"]),
                            ID_LOGSHEET = row["ID_LOGSHEET"].ToString(),
                            REF_GARNO = row["REF_GARNO"].ToString(),
                            REF_INVOICE = row["REF_INVOICE"].ToString(),
                            REF_BILLNO = row["REF_BILLNO"].ToString(),
                            STOCK_PRINT = row["STOCK_PRINT"].ToString(),
                            STOCK_PRINT_DATE = ClsStrVulue.convertToDateTime(row["STOCK_PRINT_DATE"]),
                            MS_PRINT = ClsStrVulue.convertToDecimal(row["MS_PRINT"]),
                            REQ_RETURN = ClsStrVulue.convertToDecimal(row["REQ_RETURN"]),
                            REQ_ATTN = row["REQ_ATTN"].ToString(),
                            DOC_DATE = ClsStrVulue.convertToDateTime(row["DOC_DATE"]),
                            CONTRACT_ID = ClsStrVulue.convertToDecimal(row["CONTRACT_ID"]),
                            STATUS_CONTRACT = ClsStrVulue.convertToDecimal(row["STATUS_CONTRACT"]),
                            IN_WARRANTY = ClsStrVulue.convertToDecimal(row["IN_WARRANTY"]),
                            RE_WARRANTY = row["RE_WARRANTY"].ToString(),
                            YEAR_WARRANTY = ClsStrVulue.convertToDecimal(row["YEAR_WARRANTY"]),
                            FORMAT_BILLSTK = row["FORMAT_BILLSTK"].ToString(),
                            SENT_TO_SAP = row["SENT_TO_SAP"].ToString(),
                            SENT_TO_DATE = ClsStrVulue.convertToDateTime(row["SENT_TO_DATE"]),
                            TEL_SENDTO = row["TEL_SENDTO"].ToString(),
                            SUBJOB = row["SUBJOB"].ToString(),
                            GROUP_PRODUCT = row["GROUP_PRODUCT"].ToString(),
                            ZONE_PRODUCT = row["ZONE_PRODUCT"].ToString(),
                            TS_PRODUCT = row["TS_PRODUCT"].ToString(),
                            BOITYPE = row["BOITYPE"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("REQUISITION", conn_sql, paramList, itemList))
                        Console.WriteLine("REQUISITION save data error!!");
                    else
                        Console.WriteLine("REQUISITION insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region REQUISITION_CONFIG
        public static void Import_REQUISITION_CONFIG()
        {
            try
            {
                string str = @"select * from REQUISITION_CONFIG";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<REQUISITION_CONFIG>();
                var item = new REQUISITION_CONFIG();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table REQUISITION_CONFIG";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new REQUISITION_CONFIG
                        {
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"]),
                            CONFIG_ID = ClsStrVulue.convertToDecimal(row["CONFIG_ID"]),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("REQUISITION_CONFIG", conn_sql, paramList, itemList))
                        Console.WriteLine("REQUISITION_CONFIG save data error!!");
                    else
                        Console.WriteLine("REQUISITION_CONFIG insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region REQUISITION_STATUS_TRACKING
        public static void Import_REQUISITION_STATUS_TRACKING()
        {
            try
            {
                string str = @"select * from REQUISITION_STATUS_TRACKING";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<REQUISITION_STATUS_TRACKING>();
                var item = new REQUISITION_STATUS_TRACKING();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table REQUISITION_STATUS_TRACKING";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new REQUISITION_STATUS_TRACKING
                        {
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"]),
                            OLD_STATUS = row["OLD_STATUS"].ToString(),
                            NEW_STATUS = row["NEW_STATUS"].ToString(),
                            PROCESS_DATE = ClsStrVulue.convertToDateTime(row["PROCESS_DATE"]),
                            USERNAME = row["USERNAME"].ToString(),
                            OS_USER = row["OS_USER"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("REQUISITION_STATUS_TRACKING", conn_sql, paramList, itemList))
                        Console.WriteLine("REQUISITION_STATUS_TRACKING save data error!!");
                    else
                        Console.WriteLine("REQUISITION_STATUS_TRACKING insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region REQUISITION_TIME_PROCESS
        public static void Import_REQUISITION_TIME_PROCESS()
        {
            try
            {
                string str = @"select * from REQUISITION_TIME_PROCESS";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<REQUISITION_TIME_PROCESS>();
                var item = new REQUISITION_TIME_PROCESS();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table REQUISITION_TIME_PROCESS";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new REQUISITION_TIME_PROCESS
                        {
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"]),
                            ORDER_POST_TIME_IN = ClsStrVulue.convertToDateTime(row["ORDER_POST_TIME_IN"]),
                            ORDER_POST_TIME_OUT = ClsStrVulue.convertToDateTime(row["ORDER_POST_TIME_OUT"]),
                            ORDER_RECORD_IN = ClsStrVulue.convertToDateTime(row["ORDER_RECORD_IN"]),
                            ORDER_RECORD_OUT = ClsStrVulue.convertToDateTime(row["ORDER_RECORD_OUT"]),
                            STOCK_CONTROL_IN = ClsStrVulue.convertToDateTime(row["STOCK_CONTROL_IN"]),
                            STOCK_CONTROL_OUT = ClsStrVulue.convertToDateTime(row["STOCK_CONTROL_OUT"]),
                            CREDIT_CONTROL1_IN = ClsStrVulue.convertToDateTime(row["CREDIT_CONTROL1_IN"]),
                            CREDIT_CONTROL1_OUT = ClsStrVulue.convertToDateTime(row["CREDIT_CONTROL1_OUT"]),
                            IMPORT_IN = ClsStrVulue.convertToDateTime(row["IMPORT_IN"]),
                            IMPORT_OUT = ClsStrVulue.convertToDateTime(row["IMPORT_OUT"]),
                            CREDIT_RECORD2_IN = ClsStrVulue.convertToDateTime(row["CREDIT_RECORD2_IN"]),
                            CREDIT_RECORD2_OUT = ClsStrVulue.convertToDateTime(row["CREDIT_RECORD2_OUT"]),
                            STOCK_CONTROL2_IN = ClsStrVulue.convertToDateTime(row["STOCK_CONTROL2_IN"]),
                            STOCK_CONTROL2_OUT = ClsStrVulue.convertToDateTime(row["STOCK_CONTROL2_OUT"]),
                            GODOWN_IN = ClsStrVulue.convertToDateTime(row["GODOWN_IN"]),
                            GODOWN_OUT = ClsStrVulue.convertToDateTime(row["GODOWN_OUT"]),
                            GRAND_TOTAL = ClsStrVulue.convertToDateTime(row["GRAND_TOTAL"]),
                            REMARKS = row["REMARKS"].ToString(),
                            STOCK_MAIL_TO_GODOWN = ClsStrVulue.convertToDateTime(row["STOCK_MAIL_TO_GODOWN"]),
                            STOCK_CONTROL3_IN = ClsStrVulue.convertToDateTime(row["STOCK_CONTROL3_IN"]),
                            STOCK_CONTROL3_OUT = ClsStrVulue.convertToDateTime(row["STOCK_CONTROL3_OUT"]),
                            CREDIT_CONTROL3_IN = ClsStrVulue.convertToDateTime(row["CREDIT_CONTROL3_IN"]),
                            CREDIT_CONTROL3_OUT = ClsStrVulue.convertToDateTime(row["CREDIT_CONTROL3_OUT"]),
                            TS_IN = ClsStrVulue.convertToDateTime(row["TS_IN"]),
                            TS_OUT = ClsStrVulue.convertToDateTime(row["TS_OUT"]),
                            GODOWN_TO_TS = ClsStrVulue.convertToDateTime(row["GODOWN_TO_TS"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("REQUISITION_TIME_PROCESS", conn_sql, paramList, itemList))
                        Console.WriteLine("REQUISITION_TIME_PROCESS save data error!!");
                    else
                        Console.WriteLine("REQUISITION_TIME_PROCESS insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region REQUISITION_TRACKING
        public static void Import_REQUISITION_TRACKING()
        {
            try
            {
                string str = @"select * from REQUISITION_TRACKING";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<REQUISITION_TRACKING>();
                var item = new REQUISITION_TRACKING();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table REQUISITION_TRACKING";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new REQUISITION_TRACKING
                        {
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"]),
                            ORDER_POST_TIME_IN = ClsStrVulue.convertToDateTime(row["ORDER_POST_TIME_IN"]),
                            ORDER_POST_TIME_OUT = ClsStrVulue.convertToDateTime(row["ORDER_POST_TIME_OUT"]),
                            ORDER_RECORD_IN = ClsStrVulue.convertToDateTime(row["ORDER_RECORD_IN"]),
                            ORDER_RECORD_OUT = ClsStrVulue.convertToDateTime(row["ORDER_RECORD_OUT"]),
                            STOCK_CONTROL_IN = ClsStrVulue.convertToDateTime(row["STOCK_CONTROL_IN"]),
                            STOCK_CONTROL_OUT = ClsStrVulue.convertToDateTime(row["STOCK_CONTROL_OUT"]),
                            CREDIT_CONTROL1_IN = ClsStrVulue.convertToDateTime(row["CREDIT_CONTROL1_IN"]),
                            CREDIT_CONTROL1_OUT = ClsStrVulue.convertToDateTime(row["CREDIT_CONTROL1_OUT"]),
                            IMPORT_IN = ClsStrVulue.convertToDateTime(row["IMPORT_IN"]),
                            IMPORT_OUT = ClsStrVulue.convertToDateTime(row["IMPORT_OUT"]),
                            CREDIT_RECORD2_IN = ClsStrVulue.convertToDateTime(row["CREDIT_RECORD2_IN"]),
                            CREDIT_RECORD2_OUT = ClsStrVulue.convertToDateTime(row["CREDIT_RECORD2_OUT"]),
                            STOCK_CONTROL2_IN = ClsStrVulue.convertToDateTime(row["STOCK_CONTROL2_IN"]),
                            STOCK_CONTROL2_OUT = ClsStrVulue.convertToDateTime(row["STOCK_CONTROL2_OUT"]),
                            GODOWN_IN = ClsStrVulue.convertToDateTime(row["GODOWN_IN"]),
                            GODOWN_OUT = ClsStrVulue.convertToDateTime(row["GODOWN_OUT"]),
                            GRAND_TOTAL = ClsStrVulue.convertToDateTime(row["GRAND_TOTAL"]),
                            REMARKS = row["REMARKS"].ToString(),
                            STOCK_MAIL_TO_GODOWN = ClsStrVulue.convertToDateTime(row["STOCK_MAIL_TO_GODOWN"]),
                            STOCK_CONTROL3_IN = ClsStrVulue.convertToDateTime(row["STOCK_CONTROL3_IN"]),
                            STOCK_CONTROL3_OUT = ClsStrVulue.convertToDateTime(row["STOCK_CONTROL3_OUT"]),
                            CREDIT_CONTROL3_IN = ClsStrVulue.convertToDateTime(row["CREDIT_CONTROL3_IN"]),
                            CREDIT_CONTROL3_OUT = ClsStrVulue.convertToDateTime(row["CREDIT_CONTROL3_OUT"]),
                            TS_IN = ClsStrVulue.convertToDateTime(row["TS_IN"]),
                            TS_OUT = ClsStrVulue.convertToDateTime(row["TS_OUT"]),
                            GODOWN_TO_TS = ClsStrVulue.convertToDateTime(row["GODOWN_TO_TS"]),
                            PROCESS_DATE = ClsStrVulue.convertToDateTime(row["PROCESS_DATE"]),
                            USERNAME = row["USERNAME"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("REQUISITION_TRACKING", conn_sql, paramList, itemList))
                        Console.WriteLine("REQUISITION_TRACKING save data error!!");
                    else
                        Console.WriteLine("REQUISITION_TRACKING insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region REQUISITION_TS
        public static void Import_REQUISITION_TS()
        {
            try
            {
                string str = @"select * from REQUISITION_TS";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<REQUISITION_TS>();
                var item = new REQUISITION_TS();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table REQUISITION_TS";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new REQUISITION_TS
                        {
                            SERVICE_NO = row["SERVICE_NO"].ToString(),
                            BRAND_ID = row["BRAND_ID"].ToString(),
                            SER_TYPE = row["SER_TYPE"].ToString(),
                            IMPO_TYPE = row["IMPO_TYPE"].ToString(),
                            STATUS_REQ = row["STATUS_REQ"].ToString(),
                            EQU_NAME = row["EQU_NAME"].ToString(),
                            EQU_MODEL = row["EQU_MODEL"].ToString(),
                            EQU_SN = row["EQU_SN"].ToString(),
                            HOSNO = ClsStrVulue.convertToDecimal(row["HOSNO"]),
                            INVOICE_NO = row["INVOICE_NO"].ToString(),
                            INVOICE_DATE = ClsStrVulue.convertToDateTime(row["INVOICE_DATE"]),
                            PROBLEM = row["PROBLEM"].ToString(),
                            ACTION = row["ACTION"].ToString(),
                            NEED = row["NEED"].ToString(),
                            REMARK = row["REMARK"].ToString(),
                            RE_RECBY = row["RE_RECBY"].ToString(),
                            RE_RECDATE = ClsStrVulue.convertToDateTime(row["RE_RECDATE"]),
                            MD_RECBY = row["MD_RECBY"].ToString(),
                            MD_RECDATE = ClsStrVulue.convertToDateTime(row["MD_RECDATE"]),
                            MGR_RECBY = row["MGR_RECBY"].ToString(),
                            MGR_RECDATE = ClsStrVulue.convertToDateTime(row["MGR_RECDATE"]),
                            SUP_RECBY = row["SUP_RECBY"].ToString(),
                            SUP_RECDATE = ClsStrVulue.convertToDateTime(row["SUP_RECDATE"]),
                            ENG_RECBY = row["ENG_RECBY"].ToString(),
                            ENG_RECDATE = ClsStrVulue.convertToDateTime(row["ENG_RECDATE"]),
                            RECORDER_BY = row["RECORDER_BY"].ToString(),
                            RECORDER_DATE = ClsStrVulue.convertToDateTime(row["RECORDER_DATE"]),
                            CUSNO = ClsStrVulue.convertToDecimal(row["CUSNO"]),
                            REMARK_EDIT = row["REMARK_EDIT"].ToString(),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                            PO_NO = row["PO_NO"].ToString(),
                            GAR_NO = row["GAR_NO"].ToString(),
                            INVOICE_MS = row["INVOICE_MS"].ToString(),
                            PO_DATE = ClsStrVulue.convertToDateTime(row["PO_DATE"]),
                            INVOICE_MS_DATE = ClsStrVulue.convertToDateTime(row["INVOICE_MS_DATE"]),
                            GAR_DATE = ClsStrVulue.convertToDateTime(row["GAR_DATE"]),
                            ESTIMATE_DATE = ClsStrVulue.convertToDateTime(row["ESTIMATE_DATE"]),
                            REMARK_COMMENT = row["REMARK_COMMENT"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("REQUISITION_TS", conn_sql, paramList, itemList))
                        Console.WriteLine("REQUISITION_TS save data error!!");
                    else
                        Console.WriteLine("REQUISITION_TS insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region REQUISITION_TS_FOLLOW
        public static void Import_REQUISITION_TS_FOLLOW()
        {
            try
            {
                string str = @"select * from REQUISITION_TS_FOLLOW";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<REQUISITION_TS_FOLLOW>();
                var item = new REQUISITION_TS_FOLLOW();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table REQUISITION_TS_FOLLOW";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new REQUISITION_TS_FOLLOW
                        {
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            SERVICE_NO = row["SERVICE_NO"].ToString(),
                            FOLLOW_DESC = row["FOLLOW_DESC"].ToString(),
                            FOLLOW_DATE = ClsStrVulue.convertToDateTime(row["FOLLOW_DATE"]),
                            REC_USER = row["REC_USER"].ToString(),
                            FILE_NAME = row["FILE_NAME"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("REQUISITION_TS_FOLLOW", conn_sql, paramList, itemList))
                        Console.WriteLine("REQUISITION_TS_FOLLOW save data error!!");
                    else
                        Console.WriteLine("REQUISITION_TS_FOLLOW insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region REQUISITION2
        public static void Import_REQUISITION2()
        {
            try
            {
                string str = @"select * from REQUISITION2";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<REQUISITION2>();
                var item = new REQUISITION2();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table REQUISITION2";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new REQUISITION2
                        {
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"]),
                            HOSNO = ClsStrVulue.convertToDecimal(row["HOSNO"]),
                            CUSNO = ClsStrVulue.convertToDecimal(row["CUSNO"]),
                            ORDERBY = row["ORDERBY"].ToString(),
                            SENDTO = row["SENDTO"].ToString(),
                            QUOTNO = row["QUOTNO"].ToString(),
                            S_DEPTNO = row["S_DEPTNO"].ToString(),
                            REQDATE = ClsStrVulue.convertToDateTime(row["REQDATE"]),
                            GRANDTOTAL1 = ClsStrVulue.convertToDecimal(row["GRANDTOTAL1"]),
                            GRANDTOTAL2 = ClsStrVulue.convertToDecimal(row["GRANDTOTAL2"]),
                            ENDUSER = row["ENDUSER"].ToString(),
                            EVALUATOR = row["EVALUATOR"].ToString(),
                            DECISIONMAKER = row["DECISIONMAKER"].ToString(),
                            CREDITTERM = ClsStrVulue.convertToDecimal(row["CREDITTERM"]),
                            PAYMENT_ID = ClsStrVulue.convertToDecimal(row["PAYMENT_ID"]),
                            PAYMENT_APPROVAL = row["PAYMENT_APPROVAL"].ToString(),
                            REQ_STATUS = row["REQ_STATUS"].ToString(),
                            ERGENT_REQ = row["ERGENT_REQ"].ToString(),
                            REQ_TYPE = ClsStrVulue.convertToDecimal(row["REQ_TYPE"]),
                            REQ_APPROVE = row["REQ_APPROVE"].ToString(),
                            ORDER_POST_REC = row["ORDER_POST_REC"].ToString(),
                            ORDER_REC = row["ORDER_REC"].ToString(),
                            STOCK1_REC = row["STOCK1_REC"].ToString(),
                            CREDIT1_REC = row["CREDIT1_REC"].ToString(),
                            IMPORT = row["IMPORT"].ToString(),
                            CREDIT2_REC = row["CREDIT2_REC"].ToString(),
                            STOCK2_REC = row["STOCK2_REC"].ToString(),
                            GODOWN_REC = row["GODOWN_REC"].ToString(),
                            CONTRACTNO = row["CONTRACTNO"].ToString(),
                            PONO = row["PONO"].ToString(),
                            DISCOUNT = ClsStrVulue.convertToDecimal(row["DISCOUNT"]),
                            DEPOSIT_MONEY = ClsStrVulue.convertToDecimal(row["DEPOSIT_MONEY"]),
                            ESP_PERCENTAGE = ClsStrVulue.convertToDecimal(row["ESP_PERCENTAGE"]),
                            UPDATE_TIME_STAMP = ClsStrVulue.convertToDateTime(row["UPDATE_TIME_STAMP"]),
                            REQ_UPDATE_BY = row["REQ_UPDATE_BY"].ToString(),
                            EMPNO = row["EMPNO"].ToString(),
                            REF_MAIN = ClsStrVulue.convertToDecimal(row["REF_MAIN"]),
                            REQ_VAC = ClsStrVulue.convertToDecimal(row["REQ_VAC"]),
                            CREDIT_NOTE = row["CREDIT_NOTE"].ToString(),
                            DELIVER_AT = ClsStrVulue.convertToDecimal(row["DELIVER_AT"]),
                            CONTACTNO_DATE = ClsStrVulue.convertToDateTime(row["CONTACTNO_DATE"]),
                            PONO_DATE = ClsStrVulue.convertToDateTime(row["PONO_DATE"]),
                            DELIVERY_DATE = ClsStrVulue.convertToDateTime(row["DELIVERY_DATE"]),
                            MS_RECEIVEDATE = ClsStrVulue.convertToDateTime(row["MS_RECEIVEDATE"]),
                            REQ_RECORD = row["REQ_RECORD"].ToString(),
                            BILL_SUB = row["BILL_SUB"].ToString(),
                            REQ_PROD = ClsStrVulue.convertToDecimal(row["REQ_PROD"]),
                            RECORD_DATE = ClsStrVulue.convertToDateTime(row["RECORD_DATE"]),
                            LASTUP_DATE = ClsStrVulue.convertToDateTime(row["LASTUP_DATE"]),
                            LASTUP_RECORD = row["LASTUP_RECORD"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("REQUISITION2", conn_sql, paramList, itemList))
                        Console.WriteLine("REQUISITION2 save data error!!");
                    else
                        Console.WriteLine("REQUISITION2 insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region BILLING
        public static void Import_BILLING()
        {
            try
            {
                string str = @"select * from BILLING";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<BILLING>();
                var item = new BILLING();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table BILLING";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new BILLING
                        {
                            BILLNO = row["BILLNO"].ToString(),
                            B_DATE = ClsStrVulue.convertToDateTime(row["B_DATE"]),
                            BILL_DETAIL = row["BILL_DETAIL"].ToString(),
                            B_CREDITTERM = row["B_CREDITTERM"].ToString(),
                            CUS_RECEIVEDATE = ClsStrVulue.convertToDateTime(row["CUS_RECEIVEDATE"]),
                            RECEIVEBY = row["RECEIVEBY"].ToString(),
                            RANK = row["RANK"].ToString(),
                            BILL_TYPE = ClsStrVulue.convertToDecimal(row["BILL_TYPE"]),
                            BILL_APPR = row["BILL_APPR"].ToString(),
                            BILL_REMARK = row["BILL_REMARK"].ToString(),
                            BILL_STATUS = row["BILL_STATUS"].ToString(),
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"]),
                            BILL_RECORDER = row["BILL_RECORDER"].ToString(),
                            GARNO = row["GARNO"].ToString(),
                            CUS_NAME = row["CUS_NAME"].ToString(),
                            CUS_ADDR = row["CUS_ADDR"].ToString(),
                            CUSNO = ClsStrVulue.convertToDecimal(row["CUSNO"]),
                            EDIT_VAC = row["EDIT_VAC"].ToString(),
                            EDIT_OBJECTIVE = row["EDIT_OBJECTIVE"].ToString(),
                            GAR_DATE = ClsStrVulue.convertToDateTime(row["GAR_DATE"]),
                            REMARK_CONPO = row["REMARK_CONPO"].ToString(),
                            STKVAT = ClsStrVulue.convertToDecimal(row["STKVAT"]),
                            EXPORT_FINDATE = ClsStrVulue.convertToDateTime(row["EXPORT_FINDATE"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("BILLING", conn_sql, paramList, itemList))
                        Console.WriteLine("BILLING save data error!!");
                    else
                        Console.WriteLine("BILLING insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region BILL_DETAIL
        public static void Import_BILL_DETAIL()
        {
            try
            {
                string str = @"select * from BILL_DETAIL";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<BILL_DETAIL>();
                var item = new BILL_DETAIL();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table BILL_DETAIL";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new BILL_DETAIL
                        {
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"]),
                            PRODNO = ClsStrVulue.convertToDecimal(row["PRODNO"]),
                            P_QTY = ClsStrVulue.convertToDecimal(row["P_QTY"]),
                            NETPRICE = ClsStrVulue.convertToDecimal(row["NETPRICE"]),
                            UNIT_LP = ClsStrVulue.convertToDecimal(row["UNIT_LP"]),
                            TOTAL_LP = ClsStrVulue.convertToDecimal(row["TOTAL_LP"]),
                            NETTOTAL = ClsStrVulue.convertToDecimal(row["NETTOTAL"]),
                            UNITTYPE = row["UNITTYPE"].ToString(),
                            P_DETAIL = row["P_DETAIL"].ToString(),
                            BIFO = ClsStrVulue.convertToDecimal(row["BIFO"]),
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            BRAND_ID = row["BRAND_ID"].ToString(),
                            CONFIG_ID = ClsStrVulue.convertToDecimal(row["CONFIG_ID"]),
                            MS_PO_CODE = row["MS_PO_CODE"].ToString(),
                            MS_RESERVE_CODE = row["MS_RESERVE_CODE"].ToString(),
                            REQ_DEPOSIT = ClsStrVulue.convertToDecimal(row["REQ_DEPOSIT"]),
                            STKPRICEV = ClsStrVulue.convertToDecimal(row["STKPRICEV"]),
                            STKNETPRICEV = ClsStrVulue.convertToDecimal(row["STKNETPRICEV"]),
                            STKPRICENV = ClsStrVulue.convertToDecimal(row["STKPRICENV"]),
                            STKNETPRICENV = ClsStrVulue.convertToDecimal(row["STKNETPRICENV"]),
                            MAIN_PRODNO = ClsStrVulue.convertToDecimal(row["MAIN_PRODNO"]),
                            RENT = ClsStrVulue.convertToDecimal(row["RENT"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("BILL_DETAIL", conn_sql, paramList, itemList))
                        Console.WriteLine("BILL_DETAIL save data error!!");
                    else
                        Console.WriteLine("BILL_DETAIL insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region CPI
        public static void Import_CPI()
        {
            try
            {
                string str = @"select * from CPI";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<CPI>();
                var item = new CPI();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table CPI";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new CPI
                        {
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"]),
                            CP_WITHPO1 = row["CP_WITHPO1"].ToString(),
                            CP_WITHQUOT1 = row["CP_WITHQUOT1"].ToString(),
                            CP_APPOINT1 = row["CP_APPOINT1"].ToString(),
                            CP_TEST1 = row["CP_TEST1"].ToString(),
                            CP_INSTALL1 = row["CP_INSTALL1"].ToString(),
                            SALECHECK1 = row["SALECHECK1"].ToString(),
                            SALESEND1 = row["SALESEND1"].ToString(),
                            CANWAIT1 = row["CANWAIT1"].ToString(),
                            CANCUT1 = row["CANCUT1"].ToString(),
                            CANFOLLOW1 = row["CANFOLLOW1"].ToString(),
                            TELLSALE1 = row["TELLSALE1"].ToString(),
                            CP_WITHPO2 = row["CP_WITHPO2"].ToString(),
                            CP_WITHQUOT2 = row["CP_WITHQUOT2"].ToString(),
                            CP_APPOINT2 = row["CP_APPOINT2"].ToString(),
                            CP_TEST2 = row["CP_TEST2"].ToString(),
                            CP_INSTALL2 = row["CP_INSTALL2"].ToString(),
                            SALECHECK2 = row["SALECHECK2"].ToString(),
                            SALESEND2 = row["SALESEND2"].ToString(),
                            CANWAIT2 = row["CANWAIT2"].ToString(),
                            CANCUT2 = row["CANCUT2"].ToString(),
                            CANFOLLOW2 = row["CANFOLLOW2"].ToString(),
                            TELLSALE2 = row["TELLSALE2"].ToString(),
                            CP_APPROVAL = row["CP_APPROVAL"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("CPI", conn_sql, paramList, itemList))
                        Console.WriteLine("CPI save data error!!");
                    else
                        Console.WriteLine("CPI insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region CPI_CONTRACT
        public static void Import_CPI_CONTRACT()
        {
            try
            {
                string str = @"select * from CPI_CONTRACT";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<CPI_CONTRACT>();
                var item = new CPI_CONTRACT();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table CPI_CONTRACT";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new CPI_CONTRACT
                        {
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"]),
                            WARRANTY = row["WARRANTY"].ToString(),
                            PM = row["PM"].ToString(),
                            CALIBRATION = row["CALIBRATION"].ToString(),
                            DOWNTIME = row["DOWNTIME"].ToString(),
                            RESPONSE_TIME = row["RESPONSE_TIME"].ToString(),
                            ASSUMPSIT = row["ASSUMPSIT"].ToString(),
                            FINE = row["FINE"].ToString(),
                            USER_MANUAL = row["USER_MANUAL"].ToString(),
                            SERVICE_MANUAL = row["SERVICE_MANUAL"].ToString(),
                            DOWNTIMEX2 = row["DOWNTIMEX2"].ToString(),
                            CONSUMABLE = row["CONSUMABLE"].ToString(),
                            TERM_PAYMENT = row["TERM_PAYMENT"].ToString(),
                            REMARKS = row["REMARKS"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("CPI_CONTRACT", conn_sql, paramList, itemList))
                        Console.WriteLine("CPI_CONTRACT save data error!!");
                    else
                        Console.WriteLine("CPI_CONTRACT insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region CPI_PRODUCT
        public static void Import_CPI_PRODUCT()
        {
            try
            {
                string str = @"select * from CPI_PRODUCT";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<CPI_PRODUCT>();
                var item = new CPI_PRODUCT();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table CPI_PRODUCT";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new CPI_PRODUCT
                        {
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"]),
                            ID_TOPIC = ClsStrVulue.convertToDecimal(row["ID_TOPIC"]),
                            ID_CHOICE = ClsStrVulue.convertToDecimal(row["ID_CHOICE"]),
                            REMARKS = row["REMARKS"].ToString(),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("CPI_PRODUCT", conn_sql, paramList, itemList))
                        Console.WriteLine("CPI_PRODUCT save data error!!");
                    else
                        Console.WriteLine("CPI_PRODUCT insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region CPII
        public static void Import_CPII()
        {
            try
            {
                string str = @"select * from CPII";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<CPII>();
                var item = new CPII();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table CPII";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new CPII
                        {
                            CPII_NO = ClsStrVulue.convertToDecimal(row["CPII_NO"]),
                            QUOTNO = row["QUOTNO"].ToString(),
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"]),
                            C_BRAND = row["C_BRAND"].ToString(),
                            C_CONFIG = row["C_CONFIG"].ToString(),
                            C_FREESALE = row["C_FREESALE"].ToString(),
                            C_SPEC = row["C_SPEC"].ToString(),
                            C_INSTALL = row["C_INSTALL"].ToString(),
                            C_SERVOK = row["C_SERVOK"].ToString(),
                            C_PLACE = row["C_PLACE"].ToString(),
                            C_SERV_SERV = row["C_SERV_SERV"].ToString(),
                            C_SERV_SELL = row["C_SERV_SELL"].ToString(),
                            C_INTRAIN = row["C_INTRAIN"].ToString(),
                            C_OUTTRAIN = row["C_OUTTRAIN"].ToString(),
                            C_READY = row["C_READY"].ToString(),
                            C_DELIVER = row["C_DELIVER"].ToString(),
                            C_CN = ClsStrVulue.convertToDecimal(row["C_CN"]),
                            R_BRAND = row["R_BRAND"].ToString(),
                            R_CONFIG = row["R_CONFIG"].ToString(),
                            R_FREESALE = row["R_FREESALE"].ToString(),
                            R_SPEC = row["R_SPEC"].ToString(),
                            R_INSTALL = row["R_INSTALL"].ToString(),
                            R_SERVOK = row["R_SERVOK"].ToString(),
                            R_PLACE = row["R_PLACE"].ToString(),
                            R_SERV_SELL = row["R_SERV_SELL"].ToString(),
                            R_SERV_SERV = row["R_SERV_SERV"].ToString(),
                            R_INTRAIN = row["R_INTRAIN"].ToString(),
                            R_OUTRAIN = row["R_OUTRAIN"].ToString(),
                            R_READY = row["R_READY"].ToString(),
                            R_DELIVER = row["R_DELIVER"].ToString(),
                            R_CN = ClsStrVulue.convertToDecimal(row["R_CN"]),
                            CPII_ADJUST = row["CPII_ADJUST"].ToString(),
                            SALE_MNG_APPR = row["SALE_MNG_APPR"].ToString(),
                            SERVICE_MNG_APPR = row["SERVICE_MNG_APPR"].ToString(),
                            C_USERMANUAL = ClsStrVulue.convertToDecimal(row["C_USERMANUAL"]),
                            R_USERMANUAL = ClsStrVulue.convertToDecimal(row["R_USERMANUAL"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("CPII", conn_sql, paramList, itemList))
                        Console.WriteLine("CPII save data error!!");
                    else
                        Console.WriteLine("CPII insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region REQ_BETWEEN_MNG
        public static void Import_REQ_BETWEEN_MNG()
        {
            try
            {
                string str = @"select * from REQ_BETWEEN_MNG";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<REQ_BETWEEN_MNG>();
                var item = new REQ_BETWEEN_MNG();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table REQ_BETWEEN_MNG";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new REQ_BETWEEN_MNG
                        {
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"]),
                            FROM_MNG = row["FROM_MNG"].ToString(),
                            TO_MNG = row["TO_MNG"].ToString(),
                            SEND_DATE = ClsStrVulue.convertToDateTime(row["SEND_DATE"]),
                            APPROVE_DATE = ClsStrVulue.convertToDateTime(row["APPROVE_DATE"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("REQ_BETWEEN_MNG", conn_sql, paramList, itemList))
                        Console.WriteLine("REQ_BETWEEN_MNG save data error!!");
                    else
                        Console.WriteLine("REQ_BETWEEN_MNG insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region REQ_BILL
        public static void Import_REQ_BILL()
        {
            try
            {
                string str = @"select * from REQ_BILL";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<REQ_BILL>();
                var item = new REQ_BILL();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table REQ_BILL";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new REQ_BILL
                        {
                            BILLNO = row["BILLNO"].ToString(),
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("REQ_BILL", conn_sql, paramList, itemList))
                        Console.WriteLine("REQ_BILL save data error!!");
                    else
                        Console.WriteLine("REQ_BILL insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region REQ_BILL1
        public static void Import_REQ_BILL1()
        {
            try
            {
                string str = @"select * from REQ_BILL1";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<REQ_BILL1>();
                var item = new REQ_BILL1();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table REQ_BILL1";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new REQ_BILL1
                        {
                            BILLNO = row["BILLNO"].ToString(),
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("REQ_BILL1", conn_sql, paramList, itemList))
                        Console.WriteLine("REQ_BILL1 save data error!!");
                    else
                        Console.WriteLine("REQ_BILL1 insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region REQ_BILL3
        public static void Import_REQ_BILL3()
        {
            try
            {
                string str = @"select * from REQ_BILL3";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<REQ_BILL3>();
                var item = new REQ_BILL3();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table REQ_BILL3";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new REQ_BILL3
                        {
                            BILLNO = row["BILLNO"].ToString(),
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("REQ_BILL3", conn_sql, paramList, itemList))
                        Console.WriteLine("REQ_BILL3 save data error!!");
                    else
                        Console.WriteLine("REQ_BILL3 insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region REQ_BILLNEW
        public static void Import_REQ_BILLNEW()
        {
            try
            {
                string str = @"select * from REQ_BILLNEW";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<REQ_BILLNEW>();
                var item = new REQ_BILLNEW();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table REQ_BILLNEW";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new REQ_BILLNEW
                        {
                            BILLNO = row["BILLNO"].ToString(),
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("REQ_BILLNEW", conn_sql, paramList, itemList))
                        Console.WriteLine("REQ_BILLNEW save data error!!");
                    else
                        Console.WriteLine("REQ_BILLNEW insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region REQ_BILLNEW2
        public static void Import_REQ_BILLNEW2()
        {
            try
            {
                string str = @"select * from REQ_BILLNEW2";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<REQ_BILLNEW2>();
                var item = new REQ_BILLNEW2();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table REQ_BILLNEW2";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new REQ_BILLNEW2
                        {
                            BILLNO = row["BILLNO"].ToString(),
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("REQ_BILLNEW2", conn_sql, paramList, itemList))
                        Console.WriteLine("REQ_BILLNEW2 save data error!!");
                    else
                        Console.WriteLine("REQ_BILLNEW2 insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region REQ_COLLECT_BILL
        public static void Import_REQ_COLLECT_BILL()
        {
            try
            {
                string str = @"select * from REQ_COLLECT_BILL";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<REQ_COLLECT_BILL>();
                var item = new REQ_COLLECT_BILL();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table REQ_COLLECT_BILL";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new REQ_COLLECT_BILL
                        {
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"]),
                            BILLDATE = ClsStrVulue.convertToDateTime(row["BILLDATE"]),
                            BILLNO = row["BILLNO"].ToString(),
                            BILL_AMOUNT = ClsStrVulue.convertToDecimal(row["BILL_AMOUNT"]),
                            SALENAME = row["SALENAME"].ToString(),
                            PRODUCTNAME = row["PRODUCTNAME"].ToString(),
                            HOSNO = ClsStrVulue.convertToDecimal(row["HOSNO"]),
                            DO_DATE = ClsStrVulue.convertToDateTime(row["DO_DATE"]),
                            DEP_BILL_DATE = ClsStrVulue.convertToDateTime(row["DEP_BILL_DATE"]),
                            COLLECT_APPOINT = ClsStrVulue.convertToDateTime(row["COLLECT_APPOINT"]),
                            COLLECT_CHEQUE = ClsStrVulue.convertToDateTime(row["COLLECT_CHEQUE"]),
                            CHEQUE_NO = ClsStrVulue.convertToDecimal(row["CHEQUE_NO"]),
                            CHEQUE_DATE = ClsStrVulue.convertToDateTime(row["CHEQUE_DATE"]),
                            BANK_NAME = row["BANK_NAME"].ToString(),
                            BRANCH_NAME = row["BRANCH_NAME"].ToString(),
                            COLLECT_AMOUNT = ClsStrVulue.convertToDecimal(row["COLLECT_AMOUNT"]),
                            RECEIVE_NAME = row["RECEIVE_NAME"].ToString(),
                            REMARKS = row["REMARKS"].ToString(),
                            RECUSER_ID = row["RECUSER_ID"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LASTUSER_ID = row["LASTUSER_ID"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("REQ_COLLECT_BILL", conn_sql, paramList, itemList))
                        Console.WriteLine("REQ_COLLECT_BILL save data error!!");
                    else
                        Console.WriteLine("REQ_COLLECT_BILL insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region REQ_CONTRACT
        public static void Import_REQ_CONTRACT()
        {
            try
            {
                string str = @"select * from REQ_CONTRACT";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<REQ_CONTRACT>();
                var item = new REQ_CONTRACT();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table REQ_CONTRACT";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new REQ_CONTRACT
                        {
                            TITLE = row["TITLE"].ToString(),
                            DESCRIPTION = row["DESCRIPTION"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("REQ_CONTRACT", conn_sql, paramList, itemList))
                        Console.WriteLine("REQ_CONTRACT save data error!!");
                    else
                        Console.WriteLine("REQ_CONTRACT insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region REQ_COUNT_LOGSHEET
        public static void Import_REQ_COUNT_LOGSHEET()
        {
            try
            {
                string str = @"select * from REQ_COUNT_LOGSHEET";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<REQ_COUNT_LOGSHEET>();
                var item = new REQ_COUNT_LOGSHEET();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table REQ_COUNT_LOGSHEET";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new REQ_COUNT_LOGSHEET
                        {
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            DATE_LOG = ClsStrVulue.convertToDateTime(row["DATE_LOG"]),
                            NUM_LOG = ClsStrVulue.convertToDecimal(row["NUM_LOG"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("REQ_COUNT_LOGSHEET", conn_sql, paramList, itemList))
                        Console.WriteLine("REQ_COUNT_LOGSHEET save data error!!");
                    else
                        Console.WriteLine("REQ_COUNT_LOGSHEET insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region BRAND
        public static void Import_BRAND()
        {
            try
            {
                string str = @"select * from BRAND";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn_Hamsco()).Tables[0];

                var itemList = new List<BRAND>();
                var item = new BRAND();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table BRAND";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new BRAND
                        {
                            BRAND_ID = row["BRAND_ID"].ToString(),
                            BRANDNAME = row["BRANDNAME"].ToString(),
                            PRNO = row["PRNO"].ToString(),
                            DEPTNO = row["DEPTNO"].ToString(),
                            AGENT = row["AGENT"].ToString(),
                            ID = ClsStrVulue.convertToDecimal(row["ID"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("BRAND", conn_sql, paramList, itemList))
                        Console.WriteLine("BRAND save data error!!");
                    else
                        Console.WriteLine("BRAND insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region BRAND_EXCHANGE_RATE
        public static void Import_BRAND_EXCHANGE_RATE()
        {
            try
            {
                string str = @"select * from BRAND_EXCHANGE_RATE";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn_Hamsco()).Tables[0];

                var itemList = new List<BRAND_EXCHANGE_RATE>();
                var item = new BRAND_EXCHANGE_RATE();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table BRAND_EXCHANGE_RATE";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new BRAND_EXCHANGE_RATE
                        {
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            EX_NAME = row["EX_NAME"].ToString(),
                            EX_ABBR = row["EX_ABBR"].ToString(),
                            K = ClsStrVulue.convertToDecimal(row["K"]),
                            RECUSER_ID = row["RECUSER_ID"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LASTUSER_ID = row["LASTUSER_ID"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                            STATUS = ClsStrVulue.convertToDecimal(row["STATUS"]),
                            EFFECTIVE_DATE = ClsStrVulue.convertToDateTime(row["EFFECTIVE_DATE"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("BRAND_EXCHANGE_RATE", conn_sql, paramList, itemList))
                        Console.WriteLine("BRAND_EXCHANGE_RATE save data error!!");
                    else
                        Console.WriteLine("BRAND_EXCHANGE_RATE insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region REQ_GWD
        public static void Import_REQ_GWD()
        {
            try
            {
                string str = @"select * from REQ_GWD";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<REQ_GWD>();
                var item = new REQ_GWD();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table REQ_GWD";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new REQ_GWD
                        {
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"]),
                            BILLNO = row["BILLNO"].ToString(),
                            DELIVERY_SEND = ClsStrVulue.convertToDateTime(row["DELIVERY_SEND"]),
                            NAME_RECEIVED = row["NAME_RECEIVED"].ToString(),
                            POSITION_RECEIVED = row["POSITION_RECEIVED"].ToString(),
                            REMARK_SEND = row["REMARK_SEND"].ToString(),
                            REMARK = row["REMARK"].ToString(),
                            RESULT_SEND = ClsStrVulue.convertToDecimal(row["RESULT_SEND"]),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            EXPECT_DATE = row["EXPECT_DATE"].ToString(),
                            DATE_TO_CUS = ClsStrVulue.convertToDateTime(row["DATE_TO_CUS"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("REQ_GWD", conn_sql, paramList, itemList))
                        Console.WriteLine("REQ_GWD save data error!!");
                    else
                        Console.WriteLine("REQ_GWD insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region REQ_GWD_REF
        public static void Import_REQ_GWD_REF()
        {
            try
            {
                string str = @"select * from REQ_GWD_REF";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<REQ_GWD_REF>();
                var item = new REQ_GWD_REF();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table REQ_GWD_REF_REF";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new REQ_GWD_REF
                        {
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"]),
                            LOT_NO = row["LOT_NO"].ToString(),
                            SERIAL_NO = row["SERIAL_NO"].ToString(),
                            REF_NO = row["REF_NO"].ToString(),
                            EXPIRE_DATE = ClsStrVulue.convertToDateTime(row["EXPIRE_DATE"]),
                            REMARK = row["REMARK"].ToString(),
                            ID_BILLNO = ClsStrVulue.convertToDecimal(row["ID_BILLNO"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("REQ_GWD_REF", conn_sql, paramList, itemList))
                        Console.WriteLine("REQ_GWD_REF save data error!!");
                    else
                        Console.WriteLine("REQ_GWD_REF insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region REQ_REMARKS
        public static void Import_REQ_REMARKS()
        {
            try
            {
                string str = @"select * from REQ_REMARKS";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<REQ_REMARKS>();
                var item = new REQ_REMARKS();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table REQ_REMARKS";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new REQ_REMARKS
                        {
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            REQNO = ClsStrVulue.convertToDecimal(row["REQNO"]),
                            REQ_REMARK = row["REQ_REMARK"].ToString(),
                            REQ_REMARKDATE = ClsStrVulue.convertToDateTime(row["REQ_REMARKDATE"]),
                            RECUSER_ID = row["RECUSER_ID"].ToString(),
                            REQ_TO = row["REQ_TO"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("REQ_REMARKS", conn_sql, paramList, itemList))
                        Console.WriteLine("REQ_REMARKS save data error!!");
                    else
                        Console.WriteLine("REQ_REMARKS insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region REQ_STATUS
        public static void Import_REQ_STATUS()
        {
            try
            {
                string str = @"select * from REQ_STATUS";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<REQ_STATUS_TB>();
                var item = new REQ_STATUS_TB();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table REQ_STATUS";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new REQ_STATUS_TB
                        {
                            REQ_STATUS = row["REQ_STATUS"].ToString(),
                            REQ_STATUS_NAME = row["REQ_STATUS_NAME"].ToString(),
                            RECUSER_ID = row["RECUSER_ID"].ToString(),
                            REC_DATE = row["REC_DATE"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("REQ_STATUS", conn_sql, paramList, itemList))
                        Console.WriteLine("REQ_STATUS save data error!!");
                    else
                        Console.WriteLine("REQ_STATUS insert complate!!");
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
