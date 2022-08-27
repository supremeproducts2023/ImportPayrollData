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
    public class TaxFinance
    {
        static string conn_sql = ConfigurationManager.AppSettings["ConnectionString_SQLSERVER"].ToString();

        #region TAX_DETAIL5
        public static void Import_TAX_DETAIL5()
        {
            try
            {
                string str = @"select * from TAX_DETAIL5";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<TAX_DETAIL5>();
                var item = new TAX_DETAIL5();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table TAX_DETAIL5";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new TAX_DETAIL5
                        {
                            TAX_NO = row["TAX_NO"].ToString(),
                            T_NAME = row["T_NAME"].ToString(),
                            T_ADDRESS = row["T_ADDRESS"].ToString(),
                            ID_CARD = row["ID_CARD"].ToString(),
                            SURNAME = row["SURNAME"].ToString(),
                            C_TYPE = row["C_TYPE"].ToString(),
                            TID = ClsStrVulue.convertToDecimal(row["TID"]),
                            COMP_FLG = row["COMP_FLG"].ToString(),
                            P_NAME = row["P_NAME"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("TAX_DETAIL5", conn_sql, paramList, itemList))
                        Console.WriteLine("TAX_DETAIL5 save data error!!");
                    else
                        Console.WriteLine("TAX_DETAIL5 insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region TAX_SUBTRACT5
        public static void Import_TAX_SUBTRACT5()
        {
            try
            {
                string str = @"select * from TAX_SUBTRACT5";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<TAX_SUBTRACT5>();
                var item = new TAX_SUBTRACT5();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table TAX_SUBTRACT5";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new TAX_SUBTRACT5
                        {
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            TAX_DATE = ClsStrVulue.convertToDateTime(row["TAX_DATE"]),
                            TAX_TYPE = row["TAX_TYPE"].ToString(),
                            INCOME_TOTAL = ClsStrVulue.convertToDecimal(row["INCOME_TOTAL"]),
                            INCOME_TAX = ClsStrVulue.convertToDecimal(row["INCOME_TAX"]),
                            RECORD_BY = row["RECORD_BY"].ToString(),
                            RECORD_DATE = ClsStrVulue.convertToDateTime(row["RECORD_DATE"]),
                            TAX_RATE = ClsStrVulue.convertToDecimal(row["TAX_RATE"]),
                            TID = ClsStrVulue.convertToDecimal(row["TID"]),
                            IDROW = row["IDROW"].ToString(),
                            TAX_DATE2 = ClsStrVulue.convertToDateTime(row["TAX_DATE2"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("TAX_SUBTRACT5", conn_sql, paramList, itemList))
                        Console.WriteLine("TAX_SUBTRACT5 save data error!!");
                    else
                        Console.WriteLine("TAX_SUBTRACT5 insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NGAR
        public static void Import_NGAR()
        {
            try
            {
                string str = @"select * from NGAR";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<NGAR>();
                var item = new NGAR();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NGAR";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NGAR
                        {
                            GAR_ID = ClsStrVulue.convertToDecimal(row["GAR_ID"]),
                            GAR_NO = row["GAR_NO"].ToString(),
                            GAR_DATE = row["GAR_DATE"].ToString(),
                            GARTYPEID = row["GARTYPEID"].ToString(),
                            PO_NO = row["PO_NO"].ToString(),
                            INVOICE_NO = row["INVOICE_NO"].ToString(),
                            INVOICE_DATE = row["INVOICE_DATE"].ToString(),
                            PRODSTATE = row["PRODSTATE"].ToString(),
                            ARRIVAL_DATE = row["ARRIVAL_DATE"].ToString(),
                            INFORMATION = row["INFORMATION"].ToString(),
                            STATUS = row["STATUS"].ToString(),
                            GROUP_PROD = row["GROUP_PROD"].ToString(),
                            GROUP_BALANCE = row["GROUP_BALANCE"].ToString(),
                            GROUP_GL = row["GROUP_GL"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            BRAND_ID = row["BRAND_ID"].ToString(),
                            REMARK = row["REMARK"].ToString(),
                            GARGROUP = row["GARGROUP"].ToString(),
                            BILLSEND_NO = row["BILLSEND_NO"].ToString(),
                            PRICE_TYPE = row["PRICE_TYPE"].ToString(),
                            SENT_TO_DATE = ClsStrVulue.convertToDateTime(row["SENT_TO_DATE"]),
                            GAR_TYPE = row["GAR_TYPE"].ToString(),
                            STOCK_REMARK = row["STOCK_REMARK"].ToString(),

                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NGAR", conn_sql, paramList, itemList))
                        Console.WriteLine("NGAR save data error!!");
                    else
                        Console.WriteLine("NGAR insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NGAR_TRACKING
        public static void Import_NGAR_TRACKING()
        {
            try
            {
                string str = @"select * from NGAR_TRACKING";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<NGAR_TRACKING>();
                var item = new NGAR_TRACKING();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NGAR_TRACKING";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NGAR_TRACKING
                        {
                            LOG_ID = ClsStrVulue.convertToDecimal(row["LOG_ID"]),
                            GAR_ID = ClsStrVulue.convertToDecimal(row["GAR_ID"]),
                            LOG_DATE = row["LOG_DATE"].ToString(),
                            LOG_TIME = row["LOG_TIME"].ToString(),
                            LOG_BY = row["LOG_BY"].ToString(),
                            STATUS = row["STATUS"].ToString(),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NGAR_TRACKING", conn_sql, paramList, itemList))
                        Console.WriteLine("NGAR_TRACKING save data error!!");
                    else
                        Console.WriteLine("NGAR_TRACKING insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NGAR_PROD
        public static void Import_NGAR_PROD()
        {
            try
            {
                string str = @"select * from NGAR_PROD";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<NGAR_PROD>();
                var item = new NGAR_PROD();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NGAR_PROD";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NGAR_PROD
                        {
                            PROD_ID = ClsStrVulue.convertToDecimal(row["PROD_ID"]),
                            GAR_ID = ClsStrVulue.convertToDecimal(row["GAR_ID"]),
                            PROD_NO = row["PROD_NO"].ToString(),
                            PROD_TYPE = row["PROD_TYPE"].ToString(),
                            PROD_CER = row["PROD_CER"].ToString(),
                            BRAND_ID = row["BRAND_ID"].ToString(),
                            QTY_P = ClsStrVulue.convertToDecimal(row["QTY_P"]),
                            UNIT_P = row["UNIT_P"].ToString(),
                            QTY_R = ClsStrVulue.convertToDecimal(row["QTY_R"]),
                            UNIT_R = row["UNIT_R"].ToString(),
                            QTY_QC =ClsStrVulue.convertToDecimal(row["QTY_QC"]),
                            STATUS_R = row["STATUS_R"].ToString(),
                            STATUS_QC = row["STATUS_QC"].ToString(),
                            QC_TYPE = row["QC_TYPE"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            QC_USER = row["QC_USER"].ToString(),
                            QTY_RETURN = ClsStrVulue.convertToDecimal(row["QTY_RETURN"]),
                            QC_DATE = row["QC_DATE"].ToString(),
                            ID_PROD_PO = ClsStrVulue.convertToDecimal(row["ID_PROD_PO"]),

                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NGAR_PROD", conn_sql, paramList, itemList))
                        Console.WriteLine("NGAR_PROD save data error!!");
                    else
                        Console.WriteLine("NGAR_PROD insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NGAR_STOCK_IN
        public static void Import_NGAR_STOCK_IN()
        {
            try
            {
                string str = @"select * from NGAR_STOCK_IN";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<NGAR_STOCK_IN>();
                var item = new NGAR_STOCK_IN();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NGAR_STOCK_IN";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NGAR_STOCK_IN
                        {
                            IN_ID = ClsStrVulue.convertToDecimal(row["IN_ID"]),
                            GAR_ID =ClsStrVulue.convertToDecimal( row["GAR_ID"]),
                            PROD_ID = ClsStrVulue.convertToDecimal(row["PROD_ID"]),
                            IN_BY = row["IN_BY"].ToString(),
                            QTY = ClsStrVulue.convertToDecimal(row["QTY"]),
                            STK_APPROVE = row["STK_APPROVE"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            UNIT_PRICE =ClsStrVulue.convertToDecimal(row["UNIT_PRICE"]),

                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NGAR_STOCK_IN", conn_sql, paramList, itemList))
                        Console.WriteLine("NGAR_STOCK_IN save data error!!");
                    else
                        Console.WriteLine("NGAR_STOCK_IN insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region TAXFINANCE_PERMISSION
        public static void Import_TAXFINANCE_PERMISSION()
        {
            try
            {
                string str = @"select * from TAXFINANCE_PERMISSION";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<TAXFINANCE_PERMISSION>();
                var item = new TAXFINANCE_PERMISSION();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table TAXFINANCE_PERMISSION";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new TAXFINANCE_PERMISSION
                        {
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            COM_ID = row["COM_ID"].ToString(),
                            EMP_NO = row["EMP_NO"].ToString(),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),


                        });
                    }

                    if (!ClsSQLServer.BulkCopy("TAXFINANCE_PERMISSION", conn_sql, paramList, itemList))
                        Console.WriteLine("TAXFINANCE_PERMISSION save data error!!");
                    else
                        Console.WriteLine("TAXFINANCE_PERMISSION insert complate!!");
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
