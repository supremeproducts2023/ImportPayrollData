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
    public class FinanceBill
    {
        static string conn_sql = ConfigurationManager.AppSettings["ConnectionString_SQLSERVER"].ToString();

        #region FINANCE_BILL_ACC
        public static void Import_FINANCE_BILL_ACC()
        {
            try
            {
                string str = @"select * from FINANCE_BILL_ACC";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<FINANCE_BILL_ACC>();
                var item = new FINANCE_BILL_ACC();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table FINANCE_BILL_ACC";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new FINANCE_BILL_ACC
                        {
                            REPORT_DATE = row["REPORT_DATE"].ToString(),
                            ACC_DATE = row["ACC_DATE"].ToString(),
                            ACC_TIME = ClsStrVulue.convertToDecimal(row["ACC_TIME"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("FINANCE_BILL_ACC", conn_sql, paramList, itemList))
                        Console.WriteLine("FINANCE_BILL_ACC save data error!!");
                    else
                        Console.WriteLine("FINANCE_BILL_ACC insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region FINANCE_BILL_M
        public static void Import_FINANCE_BILL_M()
        {
            try
            {
                string str = @"select * from FINANCE_BILL_M";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<FINANCE_BILL_M>();
                var item = new FINANCE_BILL_M();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table FINANCE_BILL_M";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new FINANCE_BILL_M
                        {
                            BILL_NO = row["BILL_NO"].ToString(),
                            COMPANY = ClsStrVulue.convertToDecimal(row["COMPANY"]),
                            SUPPLIER = row["SUPPLIER"].ToString(),
                            PAY_PLACE = row["PAY_PLACE"].ToString(),
                            PAY_DATE = ClsStrVulue.convertToDateTime(row["PAY_DATE"]),
                            REPORT_DATE = ClsStrVulue.convertToDateTime(row["REPORT_DATE"]),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                            REMARKS = row["REMARKS"].ToString(),
                            BILL_NOSHOW = row["BILL_NOSHOW"].ToString(),
                            PRICE_BEFORE_VAT = ClsStrVulue.convertToDecimal(row["PRICE_BEFORE_VAT"]),
                            PERCENT_VAT = ClsStrVulue.convertToDecimal(row["PERCENT_VAT"]),
                            VENDER_ID = ClsStrVulue.convertToDecimal(row["VENDER_ID"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("FINANCE_BILL_M", conn_sql, paramList, itemList))
                        Console.WriteLine("FINANCE_BILL_M save data error!!");
                    else
                        Console.WriteLine("FINANCE_BILL_M insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region FINANCE_BILL_D
        public static void Import_FINANCE_BILL_D()
        {
            try
            {
                string str = @"select * from FINANCE_BILL_D";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<FINANCE_BILL_D>();
                var item = new FINANCE_BILL_D();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table FINANCE_BILL_D";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new FINANCE_BILL_D
                        {
                            BILL_NO = row["BILL_NO"].ToString(),
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            INVOICE = row["INVOICE"].ToString(),
                            INVOICE_DATE = ClsStrVulue.convertToDateTime(row["INVOICE_DATE"]),
                            INVOICE_PRICE = ClsStrVulue.convertToDecimal(row["INVOICE_PRICE"]),
                            AMOUNT_TAX1 = ClsStrVulue.convertToDecimal(row["AMOUNT_TAX1"]),
                            TAX_RATE1 = ClsStrVulue.convertToDecimal(row["TAX_RATE1"]),
                            AMOUNT_TAX2 = ClsStrVulue.convertToDecimal(row["AMOUNT_TAX2"]),
                            TAX_RATE2 = ClsStrVulue.convertToDecimal(row["TAX_RATE2"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("FINANCE_BILL_D", conn_sql, paramList, itemList))
                        Console.WriteLine("FINANCE_BILL_D save data error!!");
                    else
                        Console.WriteLine("FINANCE_BILL_D insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region FINANCE_BILL_PAY_M
        public static void Import_FINANCE_BILL_PAY_M()
        {
            try
            {
                string str = @"select * from FINANCE_BILL_PAY_M";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<FINANCE_BILL_PAY_M>();
                var item = new FINANCE_BILL_PAY_M();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table FINANCE_BILL_PAY_M";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new FINANCE_BILL_PAY_M
                        {
                            PAY_ID = ClsStrVulue.convertToDecimal(row["PAY_ID"]),
                            PAY_NO = row["PAY_NO"].ToString(),
                            PAY_DATE = ClsStrVulue.convertToDateTime(row["PAY_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("FINANCE_BILL_PAY_M", conn_sql, paramList, itemList))
                        Console.WriteLine("FINANCE_BILL_PAY_M save data error!!");
                    else
                        Console.WriteLine("FINANCE_BILL_PAY_M insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region FINANCE_BILL_PAY_D
        public static void Import_FINANCE_BILL_PAY_D()
        {
            try
            {
                string str = @"select * from FINANCE_BILL_PAY_D";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<FINANCE_BILL_PAY_D>();
                var item = new FINANCE_BILL_PAY_D();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table FINANCE_BILL_PAY_D";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new FINANCE_BILL_PAY_D
                        {
                            PAY_ID = ClsStrVulue.convertToDecimal(row["PAY_ID"]),
                            BILL_NO = row["BILL_NO"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("FINANCE_BILL_PAY_D", conn_sql, paramList, itemList))
                        Console.WriteLine("FINANCE_BILL_PAY_D save data error!!");
                    else
                        Console.WriteLine("FINANCE_BILL_PAY_D insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region FINANCE_BILL_VENDER
        public static void Import_FINANCE_BILL_VENDER()
        {
            try
            {
                string str = @"select * from FINANCE_BILL_VENDER";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<FINANCE_BILL_VENDER>();
                var item = new FINANCE_BILL_VENDER();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table FINANCE_BILL_VENDER";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new FINANCE_BILL_VENDER
                        {
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            VENDER_NO = ClsStrVulue.convertToDecimal(row["VENDER_NO"]),
                            VENDER_NAME = row["VENDER_NAME"].ToString(),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                            BILL_PERIOD = row["BILL_PERIOD"].ToString(),
                            FIX_PAY_PLACE = row["FIX_PAY_PLACE"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("FINANCE_BILL_VENDER", conn_sql, paramList, itemList))
                        Console.WriteLine("FINANCE_BILL_VENDER save data error!!");
                    else
                        Console.WriteLine("FINANCE_BILL_VENDER insert complate!!");
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
