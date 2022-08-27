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
    public class Payroll
    {
        static string conn_sql = ConfigurationManager.AppSettings["ConnectionString_SQLSERVER"].ToString();
        #region PAY_ADDRESS
        public static void Import_PAY_ADDRESS()
        {
            try
            {
                string str = @"select * from PAY_ADDRESS";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<Pay_address>();
                var item = new Pay_address();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_ADDRESS";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new Pay_address
                        {
                            ADD_ID = row["ADD_ID"].ToString() == "" ? 0 : Convert.ToDecimal(row["ADD_ID"].ToString()),
                            EMPNO = row["EMPNO"].ToString().Trim(),
                            HOME_NO = row["HOME_NO"].ToString().Trim(),
                            SOI_NO = row["SOI_NO"].ToString().Trim(),
                            STREET_NO = row["STREET_NO"].ToString().Trim(),

                            DISTRICT_NO = row["DISTRICT_NO"].ToString().Trim(),
                            AUMPHUR_NO = row["AUMPHUR_NO"].ToString().Trim(),
                            PROVINCE_NO = row["PROVINCE_NO"].ToString().Trim(),
                            POSTALCODE = row["POSTALCODE"].ToString().Trim(),
                            TEL = row["TEL"].ToString().Trim(),

                            COUNTRY = row["COUNTRY"].ToString().Trim(),
                            ADD_STATUS = row["ADD_STATUS"].ToString() == "" ? 0 : Convert.ToDecimal(row["ADD_STATUS"].ToString()),
                            MAP_PATH = row["MAP_PATH"].ToString().Trim(),
                            ENTRYUSER = row["ENTRYUSER"].ToString().Trim(),
                            ENTRYDATE = row["ENTRYDATE"].ToString().Trim(),

                            ENTRYTIME = row["ENTRYTIME"].ToString().Trim(),
                            UPDATEUSER = row["UPDATEUSER"].ToString().Trim(),
                            UPDATEDATE = row["UPDATEDATE"].ToString().Trim(),
                            UPDATETIME = row["UPDATETIME"].ToString().Trim(),
                            TYPE_FLG = row["TYPE_FLG"].ToString().Trim(),

                            COM_ID = row["COM_ID"].ToString().Trim()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_ADDRESS", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_ADDRESS save data error!!");
                    else
                        Console.WriteLine("PAY_ADDRESS insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_ADVANCE
        public static void Import_PAY_ADVANCE()
        {
            try
            {
                string str = @"select * from PAY_ADVANCE";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<Pay_advance>();
                var item = new Pay_advance();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_ADVANCE";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);



                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new Pay_advance
                        {
                            ADV_FIN_DATE = row["ADV_FIN_DATE"].ToString(),
                            ADV_ACC_DATE = row["ADV_ACC_DATE"].ToString().Trim(),
                            ADV_FIN_NO = row["ADV_FIN_NO"].ToString().Trim(),
                            EMP_NO = row["EMP_NO"].ToString().Trim(),
                            ADV_TYPE = row["ADV_TYPE"].ToString().Trim(),

                            S1_ADV_AMOUNT = ClsStrVulue.ValidateData(row["S1_ADV_AMOUNT"].ToString()),
                            S1_EMP_NO = row["S1_EMP_NO"].ToString().Trim(),
                            S1_EMP_DATE = row["S1_EMP_DATE"].ToString().Trim(),
                            BANK_CODE = ClsStrVulue.ValidateData(row["BANK_CODE"].ToString().Trim()),
                            S2_EMP_NO = row["S2_EMP_NO"].ToString().Trim(),

                            S2_EMP_DATE = row["S2_EMP_DATE"].ToString().Trim(),
                            S3_EMP_NO = row["S3_EMP_NO"].ToString(),
                            S3_EMP_DATE = row["S3_EMP_DATE"].ToString().Trim(),
                            ADV_STATUS = row["ADV_STATUS"].ToString().Trim(),
                            CLR_ID = row["CLR_ID"].ToString().Trim(),

                            CLR_AMOUNT = ClsStrVulue.ValidateData(row["CLR_AMOUNT"].ToString().Trim()),
                            COM_ID = row["COM_ID"].ToString().Trim(),
                            ENTRYUSER = row["ENTRYUSER"].ToString().Trim(),
                            ENTRYDATE = row["ENTRYDATE"].ToString().Trim(),
                            ENTRYTIME = row["ENTRYTIME"].ToString().Trim(),

                            UPDATEUSER = row["UPDATEUSER"].ToString().Trim(),
                            UPDATEDATE = row["UPDATEDATE"].ToString().Trim(),
                            UPDATETIME = row["UPDATETIME"].ToString().Trim(),
                            ADV_ACC_NO = row["ADV_ACC_NO"].ToString().Trim(),
                            ADV_ID = row["ADV_ID"].ToString().Trim(),

                            S2_REMARK = row["S2_REMARK"].ToString().Trim(),
                            S3_REMARK = row["S3_REMARK"].ToString().Trim(),
                            S4_EMP_NO = row["S4_EMP_NO"].ToString().Trim(),
                            S4_EMP_DATE = row["S4_EMP_DATE"].ToString().Trim(),
                            S4_REMARK = row["S4_REMARK"].ToString().Trim(),

                            EXP_ID = ClsStrVulue.ValidateData(row["EXP_ID"].ToString().Trim()),
                            ADV_TRANFER = row["ADV_TRANFER"].ToString().Trim(),
                            TAX_RATE = ClsStrVulue.ValidateData(row["TAX_RATE"].ToString().Trim()),
                            TAX_AMOUNT = row["TAX_AMOUNT"].ToString().Trim(),
                            REAL_AMOUNT = ClsStrVulue.ValidateData(row["REAL_AMOUNT"].ToString().Trim()),

                            S1_REMARK = row["S1_REMARK"].ToString().Trim(),
                            DATE_PAY = ClsStrVulue.ValidateData(row["DATE_PAY"].ToString().Trim()),
                            CHECK_ID = row["CHECK_ID"].ToString().Trim(),
                            ADV_CE = row["ADV_CE"].ToString().Trim(),
                            ADV_CCOMPANY = row["ADV_CCOMPANY"].ToString().Trim(),

                            FLG_RECRIVE_DOCCLEAR = row["FLG_RECRIVE_DOCCLEAR"].ToString().Trim(),
                            RECRIVE_USER = row["RECRIVE_USER"].ToString().Trim(),
                            RECRIVE_DATE = row["RECRIVE_DATE"].ToString().Trim(),
                            RECRIVE_TIME = row["RECRIVE_TIME"].ToString().Trim(),
                            EMP_NO_RECIVE = row["EMP_NO_RECIVE"].ToString().Trim(),

                            TRANSFER_NAME = row["TRANSFER_NAME"].ToString().Trim(),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_ADVANCE", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_ADVANCE save data error!!");
                    else
                        Console.WriteLine("PAY_ADVANCE insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_ADVANCE_CLEAR
        public static void Import_PAY_ADVANCE_CLEAR()
        {
            try
            {
                string str = @"select * from PAY_ADVANCE_CLEAR";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<Pay_advance_clear>();
                var item = new Pay_advance_clear();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_ADVANCE_CLEAR";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new Pay_advance_clear
                        {
                            CLR_ID = row["CLR_ID"].ToString(),
                            CLR_FIN_DATE = row["CLR_FIN_DATE"].ToString(),
                            CLR_ACC_DATE = row["CLR_ACC_DATE"].ToString(),
                            CLR_FIN_NO = row["CLR_FIN_NO"].ToString(),
                            CLR_ACC_NO = row["CLR_ACC_NO"].ToString(),
                            EMP_NO = row["EMP_NO"].ToString(),
                            S1_EMP_NO = row["S1_EMP_NO"].ToString(),
                            S1_EMP_DATE = row["S1_EMP_DATE"].ToString(),
                            S2_EMP_NO = row["S2_EMP_NO"].ToString(),
                            S2_EMP_DATE = row["S2_EMP_DATE"].ToString(),
                            CLR_STATUS = row["CLR_STATUS"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            DDS_DATE = row["DDS_DATE"].ToString(),
                            CLR_AMOUNT = ClsStrVulue.ValidateData(row["CLR_AMOUNT"].ToString()),
                            CLR_TYPE = row["CLR_TYPE"].ToString(),
                            S3_REMARK = row["S3_REMARK"].ToString(),
                            S2_REMARK = row["S2_REMARK"].ToString(),
                            S3_EMP_NO = row["S3_EMP_NO"].ToString(),
                            S3_EMP_DATE = row["S3_EMP_DATE"].ToString(),
                            ADV_REF = row["ADV_REF"].ToString(),
                            BANK_CODE = ClsStrVulue.ValidateData(row["BANK_CODE"].ToString()),
                            EXP_ID = ClsStrVulue.ValidateData(row["EXP_ID"].ToString()),
                            S4_REMARK = row["S4_REMARK"].ToString(),
                            S4_EMP_NO = row["S4_EMP_NO"].ToString(),
                            S4_EMP_DATE = row["S4_EMP_DATE"].ToString(),
                            CLR_TRANFER = row["CLR_TRANFER"].ToString(),
                            S1_REMARK = row["S1_REMARK"].ToString(),
                            CHECK_ID = row["CHECK_ID"].ToString(),
                            PAY_TYPE = row["PAY_TYPE"].ToString(),
                            CLR_MONEY = ClsStrVulue.ValidateData(row["CLR_MONEY"].ToString()),
                            TAX_RATE = ClsStrVulue.ValidateData(row["TAX_RATE"].ToString()),
                            TAX_AMOUNT = ClsStrVulue.ValidateData(row["TAX_AMOUNT"].ToString()),
                            CLR_BVAMOUNT = ClsStrVulue.ValidateData(row["CLR_BVAMOUNT"].ToString()),
                            CLR_AVAMOUNT = ClsStrVulue.ValidateData(row["CLR_AVAMOUNT"].ToString()),
                            CLR_ID_BANK = row["CLR_ID_BANK"].ToString(),
                            CLR_DBANK = row["CLR_DBANK"].ToString(),
                            SHOWSAVE_REMARK = row["SHOWSAVE_REMARK"].ToString(),
                            SAVEREFUND_REMARK = row["SAVEREFUND_REMARK"].ToString(),
                            RETURN_REMARK = row["RETURN_REMARK"].ToString(),

                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_ADVANCE_CLEAR", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_ADVANCE_CLEAR save data error!!");
                    else
                        Console.WriteLine("PAY_ADVANCE_CLEAR insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_ADVANCE_HISTORY
        public static void Import_PAY_ADVANCE_HISTORY()
        {
            try
            {
                string str = @"select * from PAY_ADVANCE_HISTORY";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<Pay_advance_history>();
                var item = new Pay_advance_history();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_ADVANCE_HISTORY";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new Pay_advance_history
                        {
                            HIS_ID = row["HIS_ID"].ToString(),
                            HIS_ADV = row["HIS_ADV"].ToString(),
                            HIT_COMMENT = row["HIT_COMMENT"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            HIT_TYPE = row["HIT_TYPE"].ToString(),
                            HIT_OLD = row["HIT_OLD"].ToString(),
                            HIT_NEW = row["HIT_NEW"].ToString(),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_ADVANCE_HISTORY", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_ADVANCE_HISTORY save data error!!");
                    else
                        Console.WriteLine("PAY_ADVANCE_HISTORY insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_BONUS_HISTORY
        public static void Import_PAY_BONUS_HISTORY()
        {
            try
            {
                string str = @"select * from PAY_BONUS_HISTORY";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<Pay_bonus_history>();
                var item = new Pay_bonus_history();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_BONUS_HISTORY";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new Pay_bonus_history
                        {
                            B_HISID = row["B_HISID"].ToString(),
                            EMPNO = row["EMPNO"].ToString(),
                            BONUS_PERCENT = ClsStrVulue.ValidateData(row["BONUS_PERCENT"].ToString()),
                            BONUS_BATH = ClsStrVulue.ValidateData(row["BONUS_BATH"].ToString()),
                            BONUS_DATE = row["BONUS_DATE"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            BONUS_YEAR = row["BONUS_YEAR"].ToString(),
                            CALCULATED_FLG = ClsStrVulue.ValidateData(row["CALCULATED_FLG"].ToString()),
                            COM_ID = row["COM_ID"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_BONUS_HISTORY", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_BONUS_HISTORY save data error!!");
                    else
                        Console.WriteLine("PAY_BONUS_HISTORY insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_CARDINFO
        public static void Import_PAY_CARDINFO()
        {
            try
            {
                string str = @"select * from PAY_CARDINFO";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<Pay_cardinfo>();
                var item = new Pay_cardinfo();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_CARDINFO";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new Pay_cardinfo
                        {
                            CARDINFO_ID = row["CARDINFO_ID"].ToString(),
                            EMPNO = row["EMPNO"].ToString(),
                            CARD_NO = row["CARD_NO"].ToString(),
                            TAX_NO = row["TAX_NO"].ToString(),
                            SOCIAL_NO = row["SOCIAL_NO"].ToString(),
                            LIVEFUNDS_NO = row["LIVEFUNDS_NO"].ToString(),
                            TAX_FLG = row["TAX_FLG"].ToString(),
                            SOCIAL_FLG = row["SOCIAL_FLG"].ToString(),
                            LIVEFUNDS_FLG = row["LIVEFUNDS_FLG"].ToString(),
                            DATELIVEFUNDS = row["DATELIVEFUNDS"].ToString(),
                            MONTHPROCESSSTART = row["MONTHPROCESSSTART"].ToString(),
                            BRANCHSOCIAL_NO = row["BRANCHSOCIAL_NO"].ToString(),
                            EMPLOYERPERCENT = row["EMPLOYERPERCENT"].ToString(),
                            EMPLOYEEPERCENT = row["EMPLOYEEPERCENT"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_CARDINFO", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_CARDINFO save data error!!");
                    else
                        Console.WriteLine("PAY_CARDINFO insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_COMPANY_BANK
        public static void Import_PAY_COMPANY_BANK()
        {
            try
            {
                string str = @"select * from PAY_COMPANY_BANK";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<Pay_company_bank>();
                var item = new Pay_company_bank();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_COMPANY_BANK";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new Pay_company_bank
                        {
                            BANK_CODE = row["BANK_CODE"].ToString(),
                            BANK_NAME = row["BANK_NAME"].ToString(),
                            BANK_ACCOUNT = row["BANK_ACCOUNT"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            BANK_BRANCH = row["BANK_BRANCH"].ToString(),
                            FLG_USE = row["FLG_USE"].ToString(),
                            BANK = row["BANK"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_COMPANY_BANK", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_COMPANY_BANK save data error!!");
                    else
                        Console.WriteLine("PAY_COMPANY_BANK insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_COURSE
        public static void Import_PAY_COURSE()
        {
            try
            {
                string str = @"select * from PAY_COURSE";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<Pay_course>();
                var item = new Pay_course();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_COURSE";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new Pay_course
                        {
                            COURSENO = row["COURSENO"].ToString(),
                            COURSECODE = row["COURSECODE"].ToString(),
                            COURSENAME = row["COURSENAME"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            FLG = row["FLG"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            COURSE_REMARK = row["COURSE_REMARK"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_COURSE", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_COURSE save data error!!");
                    else
                        Console.WriteLine("PAY_COURSE insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_DAILY
        public static void Import_PAY_DAILY()
        {
            try
            {
                string str = @"select * from PAY_DAILY";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_DAILY>();
                var item = new PAY_DAILY();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_DAILY";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_DAILY
                        {
                            RECORD_ID = row["RECORD_ID"].ToString(),
                            YEARLY = row["YEARLY"].ToString(),
                            MONTHLY = row["MONTHLY"].ToString(),
                            EMP_NO = row["EMP_NO"].ToString(),
                            RATE = row["RATE"].ToString(),
                            DAYS = row["DAYS"].ToString(),
                            AMOUNT = row["AMOUNT"].ToString(),
                            FLGUSE = row["FLGUSE"].ToString(),
                            STATUS = row["STATUS"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            COM_ID = row["COM_ID"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_DAILY", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_DAILY save data error!!");
                    else
                        Console.WriteLine("PAY_DAILY insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_DECREASE
        public static void Import_PAY_DECREASE()
        {
            try
            {
                string str = @"select * from PAY_DECREASE";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_DECREASE>();
                var item = new PAY_DECREASE();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_DECREASE";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_DECREASE
                        {
                            REC_ID = row["REC_ID"].ToString(),
                            EMP_NO = row["EMP_NO"].ToString(),
                            DEC_ID = row["DEC_ID"].ToString(),
                            DEC_TYPE = row["DEC_TYPE"].ToString(),
                            AMOUNT = row["AMOUNT"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            FLGOLD = row["FLGOLD"].ToString(),
                            FLGT50 = row["FLGT50"].ToString(),
                            PROCESSID = row["PROCESSID"].ToString(),
                            REMARKS = row["REMARKS"].ToString(),
                            REC_YEAR = row["REC_YEAR"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_DECREASE", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_DECREASE save data error!!");
                    else
                        Console.WriteLine("PAY_DECREASE insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_DECREASE_YEAR
        public static void Import_PAY_DECREASE_YEAR()
        {
            try
            {
                string str = @"select * from PAY_DECREASE_YEAR";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_DECREASE_YEAR>();
                var item = new PAY_DECREASE_YEAR();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_DECREASE_YEAR";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_DECREASE_YEAR
                        {
                            EMPNO = row["EMPNO"].ToString(),
                            REC_YEAR = row["REC_YEAR"].ToString(),
                            FAMILYSTATUS = row["FAMILYSTATUS"].ToString(),
                            EDUCHILD = row["EDUCHILD"].ToString(),
                            NONEDUCHILD = row["NONEDUCHILD"].ToString(),
                            DE_WORK_BEFORE = row["DE_WORK_BEFORE"].ToString(),
                            DE_HAVEMOREMONEY = row["DE_HAVEMOREMONEY"].ToString(),
                            DE_WEDYEAR = row["DE_WEDYEAR"].ToString(),
                            DE_FANRICH = row["DE_FANRICH"].ToString(),
                            DE_WEDBETWEENYEAR = row["DE_WEDBETWEENYEAR"].ToString(),
                            DE_DIVORCEBEYEAR = row["DE_DIVORCEBEYEAR"].ToString(),
                            DE_DIEBETWEENYEAR = row["DE_DIEBETWEENYEAR"].ToString(),
                            DE_FATHER2 = row["DE_FATHER2"].ToString(),
                            DE_MOTHER1 = row["DE_MOTHER1"].ToString(),
                            DE_MOTHER2 = row["DE_MOTHER2"].ToString(),
                            DE_PBAHT1 = ClsStrVulue.convertToDecimal(row["DE_PBAHT1"]),
                            DE_PBAHT2 = ClsStrVulue.convertToDecimal(row["DE_PBAHT2"]),
                            DE_FATHER1 = row["DE_FATHER1"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            REC_DATE = row["REC_DATE"].ToString(),
                            DE_FATHER3 = row["DE_FATHER3"].ToString(),
                            DE_FATHER5 = row["DE_FATHER5"].ToString(),
                            DE_MOTHER3 = row["DE_MOTHER3"].ToString(),
                            DE_MOTHER5 = row["DE_MOTHER5"].ToString(),
                            DE_PBAHT3 = ClsStrVulue.convertToDecimal(row["DE_PBAHT3"]),
                            DE_PBAHT5 = ClsStrVulue.convertToDecimal(row["DE_PBAHT5"]),
                            EDUALLCHILD = row["EDUALLCHILD"].ToString(),
                            EDUABCHILD = row["EDUABCHILD"].ToString(),
                            DE_FATHER_ID1 = row["DE_FATHER_ID1"].ToString(),
                            DE_FATHER_ID2 = row["DE_FATHER_ID2"].ToString(),
                            DE_FATHER_ID3 = row["DE_FATHER_ID3"].ToString(),
                            DE_FATHER_ID5 = row["DE_FATHER_ID5"].ToString(),
                            DE_MOTHER_ID1 = row["DE_MOTHER_ID1"].ToString(),
                            DE_MOTHER_ID2 = row["DE_MOTHER_ID2"].ToString(),
                            DE_MOTHER_ID3 = row["DE_MOTHER_ID3"].ToString(),
                            DE_MOTHER_ID5 = row["DE_MOTHER_ID5"].ToString()

                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_DECREASE_YEAR", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_DECREASE_YEAR save data error!!");
                    else
                        Console.WriteLine("PAY_DECREASE_YEAR insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_DECREASETAX
        public static void Import_PAY_DECREASETAX()
        {
            try
            {
                string str = @"select * from PAY_DECREASETAX";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_DECREASETAX>();
                var item = new PAY_DECREASETAX();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_DECREASETAX";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_DECREASETAX
                        {
                            DECREASE_ID = ClsStrVulue.convertToDecimal(row["DECREASE_ID"]),
                            DECREASE_DETAIL = row["DECREASE_DETAIL"].ToString(),
                            DECREASE_MAX = ClsStrVulue.convertToDecimal(row["DECREASE_MAX"]),
                            FLG = row["FLG"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            DECREASE_PERCENT = ClsStrVulue.convertToDecimal(row["DECREASE_PERCENT"]),
                            COM_ID = row["COM_ID"].ToString(),
                            REF_ID = ClsStrVulue.convertToDecimal(row["REF_ID"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_DECREASETAX", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_DECREASETAX save data error!!");
                    else
                        Console.WriteLine("PAY_DECREASETAX insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_DEPT
        public static void Import_PAY_DEPT()
        {
            try
            {
                string str = @"select * from PAY_DEPT";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_DEPT>();
                var item = new PAY_DEPT();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_DEPT";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_DEPT
                        {
                            DEPTNO = row["DEPTNO"].ToString(),
                            DEPTNAME = row["DEPTNAME"].ToString(),
                            DEPTABBR = row["DEPTABBR"].ToString(),
                            DEPTTYPE = row["DEPTTYPE"].ToString(),
                            PARENT = row["PARENT"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            STATUS_DEPT = row["STATUS_DEPT"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            COSTCENTER = row["COSTCENTER"].ToString(),
                            DEPT_EXTCD1 = row["DEPT_EXTCD1"].ToString(),
                            DEPT_EXTCD2 = row["DEPT_EXTCD2"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_DEPT", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_DEPT save data error!!");
                    else
                        Console.WriteLine("PAY_DEPT insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_EMP
        public static void Import_PAY_EMP()
        {
            try
            {
                string str = @"select * from PAY_EMP";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<Pay_emp>();
                var item = new Pay_emp();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_EMP";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new Pay_emp
                        {
                            EMPNO = row["EMPNO"].ToString().Trim(),
                            ID_CARD = row["ID_CARD"].ToString().Trim(),
                            NT = row["NT"].ToString().Trim(),
                            NAMET = row["NAMET"].ToString().Trim(),
                            SURNAMET = row["SURNAMET"].ToString().Trim(),

                            NE = row["NE"].ToString().Trim(),
                            SURNAMEE = row["SURNAMEE"].ToString().Trim(),
                            NAMEE = row["NAMEE"].ToString().Trim(),
                            SEX = row["SEX"].ToString().Trim(),
                            DOFB = row["DOFB"].ToString().Trim(),

                            AGE = row["AGE"].ToString().Trim(),
                            TYPE_EMP = row["TYPE_EMP"].ToString().Trim(),
                            FAMILYSTATUS = row["FAMILYSTATUS"].ToString().Trim(),
                            DEPTNO = row["DEPTNO"].ToString().Trim(),
                            D_START = row["D_START"].ToString().Trim(),

                            SECTION = row["SECTION"].ToString().Trim(),
                            D_TEST = row["D_TEST"].ToString().Trim(),
                            POSITION_NO = row["POSITION_NO"].ToString().Trim(),
                            D_CONTAIN = row["D_CONTAIN"].ToString().Trim(),
                            P_LEVEL = row["P_LEVEL"].ToString().Trim(),

                            D_END = row["D_END"].ToString().Trim(),
                            PATH_PIC = row["PATH_PIC"].ToString().Trim(),
                            EDUCHILD = row["EDUCHILD"].ToString().Trim(),
                            NONEDUCHILD = row["NONEDUCHILD"].ToString().Trim(),
                            SALARY = row["SALARY"].ToString() == "" ? 0 : Convert.ToDecimal(row["SALARY"].ToString()),

                            PAYTYPE = row["PAYTYPE"].ToString().Trim(),
                            IDBOOKBANK = row["IDBOOKBANK"].ToString().Trim(),
                            BANKNAME = row["BANKNAME"].ToString().Trim(),
                            EMP_LEVEL = row["EMP_LEVEL"].ToString().Trim(),
                            SPOUSE_STATUSW = row["SPOUSE_STATUSW"].ToString().Trim(),

                            CAL_TIMES = row["CAL_TIMES"].ToString().Trim(),
                            INSUR_PREMIEM = row["INSUR_PREMIEM"].ToString().Trim(),
                            HOME_INTEREST = row["HOME_INTEREST"].ToString().Trim(),
                            DONATE = row["DONATE"].ToString().Trim(),
                            FUND_UNIT = row["FUND_UNIT"].ToString().Trim(),

                            OT_RATE = row["OT_RATE"].ToString().Trim(),
                            TAX_TYPE = row["TAX_TYPE"].ToString().Trim(),
                            STATIC_TAX = row["STATIC_TAX"].ToString().Trim(),
                            UPDATETIME = row["UPDATETIME"].ToString().Trim(),
                            ENTRYUSER = row["ENTRYUSER"].ToString().Trim(),

                            ENTRYDATE = row["ENTRYDATE"].ToString().Trim(),
                            ENTRYTIME = row["ENTRYTIME"].ToString().Trim(),
                            UPDATEUSER = row["UPDATEUSER"].ToString().Trim(),
                            UPDATEDATE = row["UPDATEDATE"].ToString().Trim(),
                            COM_ID = row["COM_ID"].ToString().Trim(),

                            FLG_CALSALARY = row["FLG_CALSALARY"].ToString().Trim(),
                            FLG_CALTAX = row["FLG_CALTAX"].ToString().Trim(),
                            FLG_CALSSO = row["FLG_CALSSO"].ToString().Trim(),
                            FLG_CALPVD = row["FLG_CALPVD"].ToString().Trim(),
                            FLG_PVDADJ = row["FLG_PVDADJ"].ToString().Trim(),

                            NICNAME = row["NICNAME"].ToString().Trim(),
                            EMAIL = row["EMAIL"].ToString().Trim(),
                            DE_WORK_BEFORE = row["DE_WORK_BEFORE"].ToString().Trim(),
                            DE_HAVEMOREMONEY = row["DE_HAVEMOREMONEY"].ToString().Trim(),
                            DE_WEDYEAR = row["DE_WEDYEAR"].ToString().Trim(),

                            DE_FANRICH = row["DE_FANRICH"].ToString().Trim(),
                            DE_WEDBETWEENYEAR = row["DE_WEDBETWEENYEAR"].ToString().Trim(),
                            DE_DIVORCEBEYEAR = row["DE_DIVORCEBEYEAR"].ToString().Trim(),
                            DE_DIEBETWEENYEAR = row["DE_DIEBETWEENYEAR"].ToString().Trim(),
                            DE_FATHER2 = row["DE_FATHER2"].ToString().Trim(),

                            DE_MOTHER1 = row["DE_MOTHER1"].ToString().Trim(),
                            DE_MOTHER2 = row["DE_MOTHER2"].ToString().Trim(),
                            DE_PBAHT1 = row["DE_PBAHT1"].ToString() == "" ? 0 : Convert.ToDecimal(row["DE_PBAHT1"].ToString()),
                            DE_PBAHT2 = row["DE_PBAHT1"].ToString() == "" ? 0 : Convert.ToDecimal(row["DE_PBAHT2"].ToString()),
                            DE_FATHER1 = row["DE_FATHER1"].ToString().Trim(),

                            IDBOOKBANK2 = row["IDBOOKBANK2"].ToString().Trim(),
                            BANKNAME2 = row["BANKNAME2"].ToString().Trim(),
                            SSO_FLG = row["SSO_FLG"].ToString().Trim(),
                            SSO_LAST = row["SSO_LAST"].ToString().Trim(),
                            BOOKBANK_STATUS = row["BOOKBANK_STATUS"].ToString().Trim(),

                            BANK_BRANCH = row["BANK_BRANCH"].ToString().Trim(),
                            BANK_BRANCH2 = row["BANK_BRANCH2"].ToString().Trim()

                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_EMP", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_EMP save data error!!");
                    else
                        Console.WriteLine("PAY_EMP insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        #endregion

        #region PAY_EMP_COURSE
        public static void Import_PAY_EMP_COURSE()
        {
            try
            {
                string str = @"select * from PAY_EMP_COURSE";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_EMP_COURSE>();
                var item = new PAY_EMP_COURSE();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_EMP_COURSE";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_EMP_COURSE
                        {
                            COURSE_ID = row["COURSE_ID"].ToString(),
                            COURSE_DATE_S = row["COURSE_DATE_S"].ToString(),
                            COURSE_TIME_S = row["COURSE_TIME_S"].ToString(),
                            COURSE_DATE_E = row["COURSE_DATE_E"].ToString(),
                            COURSE_TIME_E = row["COURSE_TIME_E"].ToString(),
                            COURSENO = row["COURSENO"].ToString(),
                            COURSE_TRAINER = row["COURSE_TRAINER"].ToString(),
                            COURSE_EXT = row["COURSE_EXT"].ToString(),
                            COURSE_INT = row["COURSE_INT"].ToString(),
                            COURSE_OJT = row["COURSE_OJT"].ToString(),
                            COURSE_OBJ = row["COURSE_OBJ"].ToString(),
                            COURSE_REMARK = row["COURSE_REMARK"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            EMP_NO = row["EMP_NO"].ToString(),
                            COM_ID = row["COM_ID"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_EMP_COURSE", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_EMP_COURSE save data error!!");
                    else
                        Console.WriteLine("PAY_EMP_COURSE insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_EMP_LOAN
        public static void Import_PAY_EMP_LOAN()
        {
            try
            {
                string str = @"select * from PAY_EMP_LOAN";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_EMP_LOAN>();
                var item = new PAY_EMP_LOAN();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_EMP_LOAN";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_EMP_LOAN
                        {
                            EMP_LOAN_ID = row["EMP_LOAN_ID"].ToString(),
                            EMPNO = row["EMPNO"].ToString(),
                            LOAN_ID = row["LOAN_ID"].ToString(),
                            LOAN_AMOUNT = row["LOAN_AMOUNT"].ToString(),
                            LOAN_AMOUNT_PERTIME = row["LOAN_AMOUNT_PERTIME"].ToString(),
                            LOAN_TIME = row["LOAN_TIME"].ToString(),
                            LOAN_RECEIVEDATE = row["LOAN_RECEIVEDATE"].ToString(),
                            LOAN_SMONTH = row["LOAN_SMONTH"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            LOAN_SYEAR = row["LOAN_SYEAR"].ToString(),
                            LOAN_RATE = row["LOAN_RATE"].ToString(),
                            LOAN_TYPE = row["LOAN_TYPE"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_EMP_LOAN", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_EMP_LOAN save data error!!");
                    else
                        Console.WriteLine("PAY_EMP_LOAN insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_EMP_LOAN_TIME
        public static void Import_PAY_EMP_LOAN_TIME()
        {
            try
            {
                string str = @"select * from PAY_EMP_LOAN_TIME";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_EMP_LOAN_TIME>();
                var item = new PAY_EMP_LOAN_TIME();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_EMP_LOAN_TIME";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_EMP_LOAN_TIME
                        {
                            LOAN_TIME_ID = ClsStrVulue.convertToDecimal(row["LOAN_TIME_ID"]),
                            EMP_LOAN_ID = ClsStrVulue.convertToDecimal(row["EMP_LOAN_ID"]),
                            TIME_NO = ClsStrVulue.convertToDecimal(row["TIME_NO"]),
                            YEARLY = row["YEARLY"].ToString(),
                            MONTHLY = row["MONTHLY"].ToString(),
                            YEARLY_EFF = row["YEARLY_EFF"].ToString(),
                            MONTHLY_EFF = row["MONTHLY_EFF"].ToString(),
                            AMOUNT = ClsStrVulue.convertToDecimal(row["AMOUNT"]),
                            INTEREST = ClsStrVulue.convertToDecimal(row["INTEREST"]),
                            TOTAL = ClsStrVulue.convertToDecimal(row["TOTAL"]),
                            STATUS = row["STATUS"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            EMPNO = row["EMPNO"].ToString(),
                            NET = row["NET"].ToString(),
                            REC_ID = ClsStrVulue.convertToDecimal(row["REC_ID"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_EMP_LOAN_TIME", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_EMP_LOAN_TIME save data error!!");
                    else
                        Console.WriteLine("PAY_EMP_LOAN_TIME insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_EMP_OFFER
        public static void Import_PAY_EMP_OFFER()
        {
            try
            {
                string str = @"select * from PAY_EMP_OFFER";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_EMP_OFFER>();
                var item = new PAY_EMP_OFFER();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_EMP_OFFER";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_EMP_OFFER
                        {
                            EMP_OFFERID = row["EMP_OFFERID"].ToString(),
                            INVOICE_NO = row["INVOICE_NO"].ToString(),
                            INVOICE_DATE = row["INVOICE_DATE"].ToString(),
                            OFFER_MONTH = row["OFFER_MONTH"].ToString(),
                            OFFER_COST = row["OFFER_COST"].ToString(),
                            OFFER_ADDM = row["OFFER_ADDM"].ToString(),
                            OFFER_ADDCOST = row["OFFER_ADDCOST"].ToString(),
                            OFFER_PF = row["OFFER_PF"].ToString(),
                            OFFER_TAX = row["OFFER_TAX"].ToString(),
                            EMPNO = row["EMPNO"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            COM_ID = row["COM_ID"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_EMP_OFFER", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_EMP_OFFER save data error!!");
                    else
                        Console.WriteLine("PAY_EMP_OFFER insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_EMP_OT_TIME
        public static void Import_PAY_EMP_OT_TIME()
        {
            try
            {
                string str = @"select * from PAY_EMP_OT_TIME";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_EMP_OT_TIME>();
                var item = new PAY_EMP_OT_TIME();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_EMP_OT_TIME";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_EMP_OT_TIME
                        {
                            OT_TIME_ID = ClsStrVulue.convertToDecimal(row["OT_TIME_ID"]),
                            EMPNO = row["EMPNO"].ToString(),
                            OT_ID = ClsStrVulue.convertToDecimal(row["OT_ID"]),
                            YEARLY = row["YEARLY"].ToString(),
                            MONTHLY = row["MONTHLY"].ToString(),
                            DAILY = row["DAILY"].ToString(),
                            SALARY = ClsStrVulue.convertToDecimal(row["SALARY"]),
                            PERHOUR = ClsStrVulue.convertToDecimal(row["PERHOUR"]),
                            AMOUNT = ClsStrVulue.convertToDecimal(row["AMOUNT"]),
                            STATUS = row["STATUS"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            HOURS = ClsStrVulue.convertToDecimal(row["HOURS"]),
                            YEARLY_EFF = row["YEARLY_EFF"].ToString(),
                            MONTHLY_EFF = row["MONTHLY_EFF"].ToString(),
                            OT_GROUP_ID = ClsStrVulue.convertToDecimal(row["OT_GROUP_ID"]),
                            INCDED_ID = ClsStrVulue.convertToDecimal(row["INCDED_ID"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_EMP_OT_TIME", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_EMP_OT_TIME save data error!!");
                    else
                        Console.WriteLine("PAY_EMP_OT_TIME insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_EMPEDU
        public static void Import_PAY_EMPEDU()
        {
            try
            {
                string str = @"select * from PAY_EMPEDU";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_EMPEDU>();
                var item = new PAY_EMPEDU();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_EMPEDU";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_EMPEDU
                        {
                            EDU_ID = row["EDU_ID"].ToString(),
                            EMPNO = row["EMPNO"].ToString(),
                            DEGREE = row["DEGREE"].ToString(),
                            UNIVERSITY = row["UNIVERSITY"].ToString(),
                            MAJOR = row["MAJOR"].ToString(),
                            FACULTY = row["FACULTY"].ToString(),
                            GRADUATED_YEAR = row["GRADUATED_YEAR"].ToString(),
                            GPA = row["GPA"].ToString(),
                            FLG = row["FLG"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            ABBR_EDU = row["ABBR_EDU"].ToString(),
                            COM_ID = row["COM_ID"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_EMPEDU", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_EMPEDU save data error!!");
                    else
                        Console.WriteLine("PAY_EMPEDU insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_EXPORT_LOGS
        public static void Import_PAY_EXPORT_LOGS()
        {
            try
            {
                string str = @"select * from PAY_EXPORT_LOGS";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_EXPORT_LOGS>();
                var item = new PAY_EXPORT_LOGS();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_EXPORT_LOGS";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_EXPORT_LOGS
                        {
                            EXP_ID = row["EXP_ID"].ToString(),
                            EXP_DATE = row["EXP_DATE"].ToString(),
                            EXP_TIME = row["EXP_TIME"].ToString(),
                            EXP_USER = row["EXP_USER"].ToString(),
                            EXP_TYPE = row["EXP_TYPE"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            EXP_FILE = row["EXP_FILE"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_EXPORT_LOGS", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_EXPORT_LOGS save data error!!");
                    else
                        Console.WriteLine("PAY_EXPORT_LOGS insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_GROUP
        public static void Import_PAY_GROUP()
        {
            try
            {
                string str = @"select * from PAY_GROUP";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_GROUP>();
                var item = new PAY_GROUP();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_GROUP";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_GROUP
                        {
                            GROUP_NO = ClsStrVulue.convertToDecimal(row["GROUP_NO"]),
                            GROUP_NAME = row["GROUP_NAME"].ToString(),
                            FLG_GROUP = row["FLG_GROUP"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_GROUP", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_GROUP save data error!!");
                    else
                        Console.WriteLine("PAY_GROUP insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_HISTORYPOSITION
        public static void Import_PAY_HISTORYPOSITION()
        {
            try
            {
                string str = @"select * from PAY_HISTORYPOSITION";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_HISTORYPOSITION>();
                var item = new PAY_HISTORYPOSITION();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_HISTORYPOSITION";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_HISTORYPOSITION
                        {
                            HISTORYPOSITION_ID = ClsStrVulue.convertToDecimal(row["HISTORYPOSITION_ID"]),
                            EMPNO = row["EMPNO"].ToString(),
                            NEWPOSITION_ID = ClsStrVulue.convertToDecimal(row["NEWPOSITION_ID"]),
                            ADJUSTPOS_DATE = row["ADJUSTPOS_DATE"].ToString(),
                            POSITION_FLG = row["POSITION_FLG"].ToString(),
                            COMMAND_NO = row["COMMAND_NO"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            FILEPATH = row["FILEPATH"].ToString(),
                            REMARK_UPDATE = row["REMARK_UPDATE"].ToString(),
                            OLDPOSITION_ID = ClsStrVulue.convertToDecimal(row["OLDPOSITION_ID"]),
                            COM_ID = row["COM_ID"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_HISTORYPOSITION", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_HISTORYPOSITION save data error!!");
                    else
                        Console.WriteLine("PAY_HISTORYPOSITION insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_HISTORYSALARY
        public static void Import_PAY_HISTORYSALARY()
        {
            try
            {
                string str = @"select * from PAY_HISTORYSALARY";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_HISTORYSALARY>();
                var item = new PAY_HISTORYSALARY();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_HISTORYSALARY";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_HISTORYSALARY
                        {
                            HISTORYSALARY_ID = ClsStrVulue.convertToDecimal(row["HISTORYSALARY_ID"]),
                            EMPNO = row["EMPNO"].ToString(),
                            OLDSALARY = ClsStrVulue.convertToDecimal(row["OLDSALARY"]),
                            NEWSALARY = ClsStrVulue.convertToDecimal(row["NEWSALARY"]),
                            ADJUSTSALARY = ClsStrVulue.convertToDecimal(row["ADJUSTSALARY"]),
                            ADJUSTSAL_FLG = row["ADJUSTSAL_FLG"].ToString(),
                            ADJUSTSAL_DATE = row["ADJUSTSAL_DATE"].ToString(),
                            GRADE = row["GRADE"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            FILEPATH = row["FILEPATH"].ToString(),
                            REMARK_UP = row["REMARK_UP"].ToString(),
                            COM_ID = row["COM_ID"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_HISTORYSALARY", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_HISTORYSALARY save data error!!");
                    else
                        Console.WriteLine("PAY_HISTORYSALARY insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_INCDED
        public static void Import_PAY_INCDED()
        {
            try
            {
                string str = @"select * from PAY_INCDED";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_INCDED>();
                var item = new PAY_INCDED();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_INCDED";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_INCDED
                        {
                            REC_ID = ClsStrVulue.convertToDecimal(row["REC_ID"]),
                            EMP_NO = row["EMP_NO"].ToString(),
                            YEARLY = row["YEARLY"].ToString(),
                            MONTHLY = row["MONTHLY"].ToString(),
                            INC_ID = ClsStrVulue.convertToDecimal(row["INC_ID"]),
                            INC_TYPE = row["INC_TYPE"].ToString(),
                            AMOUNT = ClsStrVulue.convertToDecimal(row["AMOUNT"]),
                            TAXCAL = row["TAXCAL"].ToString(),
                            SSOCAL = row["SSOCAL"].ToString(),
                            PVDCAL = row["PVDCAL"].ToString(),
                            FLGOLD = row["FLGOLD"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            FLGT50 = row["FLGT50"].ToString(),
                            PROCESSID = row["PROCESSID"].ToString(),
                            REMARKS = row["REMARKS"].ToString(),
                            PAYTYPE = row["PAYTYPE"].ToString(),

                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_INCDED", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_INCDED save data error!!");
                    else
                        Console.WriteLine("PAY_INCDED insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_INCDED_IMP
        public static void Import_PAY_INCDED_IMP()
        {
            try
            {
                string str = @"select * from PAY_INCDED_IMP";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_INCDED_IMP>();
                var item = new PAY_INCDED_IMP();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_INCDED_IMP";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_INCDED_IMP
                        {
                            IMPORT_CODE = row["IMPORT_CODE"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            YEARLY = row["YEARLY"].ToString(),
                            MONTHLY = row["MONTHLY"].ToString(),
                            EMP_NO = row["EMP_NO"].ToString(),
                            INC_ID = ClsStrVulue.convertToDecimal(row["INC_ID"]),
                            TAXCAL = row["TAXCAL"].ToString(),
                            SSOCAL = row["SSOCAL"].ToString(),
                            PVDCAL = row["PVDCAL"].ToString(),
                            AMOUNT = ClsStrVulue.convertToDecimal(row["AMOUNT"]),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            REMARKS = row["REMARKS"].ToString(),
                            IMPORT_DEPT = row["IMPORT_DEPT"].ToString(),
                            REC_ID = ClsStrVulue.convertToDecimal(row["REC_ID"]),
                            FLGUSE = row["FLGUSE"].ToString()

                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_INCDED_IMP", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_INCDED_IMP save data error!!");
                    else
                        Console.WriteLine("PAY_INCDED_IMP insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_INCDED_REG
        public static void Import_PAY_INCDED_REG()
        {
            try
            {
                string str = @"select * from PAY_INCDED_REG";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_INCDED_REG>();
                var item = new PAY_INCDED_REG();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_INCDED_REG";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_INCDED_REG
                        {
                            REC_ID = ClsStrVulue.convertToDecimal(row["REC_ID"]),
                            EMP_NO = row["EMP_NO"].ToString(),
                            YEARLY = row["YEARLY"].ToString(),
                            MONTHLY = row["MONTHLY"].ToString(),
                            INC_ID = ClsStrVulue.convertToDecimal(row["INC_ID"]),
                            INC_TYPE = row["INC_TYPE"].ToString(),
                            AMOUNT = ClsStrVulue.convertToDecimal(row["AMOUNT"]),
                            TAXCAL = row["TAXCAL"].ToString(),
                            SSOCAL = row["SSOCAL"].ToString(),
                            PVDCAL = row["PVDCAL"].ToString(),
                            FLGOLD = row["FLGOLD"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            FLGT50 = row["FLGT50"].ToString(),
                            PROCESSID = row["PROCESSID"].ToString(),
                            REMARKS = row["REMARKS"].ToString()

                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_INCDED_REG", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_INCDED_REG save data error!!");
                    else
                        Console.WriteLine("PAY_INCDED_REG insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_INCDED_TMP
        public static void Import_PAY_INCDED_TMP()
        {
            try
            {
                string str = @"select * from PAY_INCDED_TMP";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_INCDED_TMP>();
                var item = new PAY_INCDED_TMP();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_INCDED_TMP";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_INCDED_TMP
                        {
                            REC_ID = ClsStrVulue.convertToDecimal(row["REC_ID"]),
                            EMP_NO = row["EMP_NO"].ToString(),
                            YEARLY = row["YEARLY"].ToString(),
                            MONTHLY = row["MONTHLY"].ToString(),
                            INC_ID = ClsStrVulue.convertToDecimal(row["INC_ID"]),
                            INC_TYPE = row["INC_TYPE"].ToString(),
                            AMOUNT = ClsStrVulue.convertToDecimal(row["AMOUNT"]),
                            TAXCAL = row["TAXCAL"].ToString(),
                            SSOCAL = row["SSOCAL"].ToString(),
                            PVDCAL = row["PVDCAL"].ToString(),
                            FLGOLD = row["FLGOLD"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            FLGT50 = row["FLGT50"].ToString(),
                            PROCESSID = row["PROCESSID"].ToString(),
                            REMARKS = row["REMARKS"].ToString(),
                            PAYTYPE = row["PAYTYPE"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_INCDED_TMP", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_INCDED_TMP save data error!!");
                    else
                        Console.WriteLine("PAY_INCDED_TMP insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_INCOME_DECERASE
        public static void Import_PAY_INCOME_DECERASE()
        {
            try
            {
                string str = @"select * from PAY_INCOME_DECERASE";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_INCOME_DECERASE>();
                var item = new PAY_INCOME_DECERASE();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_INCOME_DECERASE";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_INCOME_DECERASE
                        {
                            INC_ID = ClsStrVulue.convertToDecimal(row["INC_ID"]),
                            INCOMEDESC = row["INCOMEDESC"].ToString(),
                            INCOME_FLG = row["INCOME_FLG"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            CAL_SOCIALCOST = row["CAL_SOCIALCOST"].ToString(),
                            ITEM_TYPE = ClsStrVulue.convertToDecimal(row["ITEM_TYPE"]),
                            PERMISSION_USER = row["PERMISSION_USER"].ToString(),
                            SHOW_SLIP = ClsStrVulue.convertToDecimal(row["SHOW_SLIP"]),
                            CAL_PROVIDENTFUND = row["CAL_PROVIDENTFUND"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            CAL_TAX = row["CAL_TAX"].ToString(),
                            FLG_USE = row["FLG_USE"].ToString(),
                            EXTCODE1 = row["EXTCODE1"].ToString(),
                            EXTCODE2 = row["EXTCODE2"].ToString(),
                            EXTDESC = row["EXTDESC"].ToString(),
                            CAL_TAX_MONTH = row["CAL_TAX_MONTH"].ToString(),
                            FLGSHOW = row["FLGSHOW"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_INCOME_DECERASE", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_INCOME_DECERASE save data error!!");
                    else
                        Console.WriteLine("PAY_INCOME_DECERASE insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_INCOMEXEMPT
        public static void Import_PAY_INCOMEXEMPT()
        {
            try
            {
                string str = @"select * from PAY_INCOMEXEMPT";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_INCOMEXEMPT>();
                var item = new PAY_INCOMEXEMPT();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_INCOMEXEMPT";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_INCOMEXEMPT
                        {
                            ID_EXEMPT = row["ID_EXEMPT"].ToString(),
                            DESC_EXEMPT = row["DESC_EXEMPT"].ToString(),
                            FLGOLD = row["FLGOLD"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            AMOUNT_MAX = row["AMOUNT_MAX"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_INCOMEXEMPT", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_INCOMEXEMPT save data error!!");
                    else
                        Console.WriteLine("PAY_INCOMEXEMPT insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_IP_ACCESS
        public static void Import_PAY_IP_ACCESS()
        {
            try
            {
                string str = @"select * from PAY_IP_ACCESS";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_IP_ACCESS>();
                var item = new PAY_IP_ACCESS();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_IP_ACCESS";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_IP_ACCESS
                        {
                            IP = row["IP"].ToString(),
                            DOMAIN_USER = row["DOMAIN_USER"].ToString(),
                            LOG_DATE = row["LOG_DATE"].ToString(),
                            LOG_TIME = row["LOG_TIME"].ToString(),
                            USER_NAME = row["USER_NAME"].ToString(),
                            STATUS = row["STATUS"].ToString(),
                            SESSIONID = row["SESSIONID"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_IP_ACCESS", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_IP_ACCESS save data error!!");
                    else
                        Console.WriteLine("PAY_IP_ACCESS insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_IP_USER_ALLOW
        public static void Import_PAY_IP_USER_ALLOW()
        {
            try
            {
                string str = @"select * from PAY_IP_USER_ALLOW";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_IP_USER_ALLOW>();
                var item = new PAY_IP_USER_ALLOW();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_IP_USER_ALLOW";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_IP_USER_ALLOW
                        {
                            IP_USER = row["IP_USER"].ToString(),
                            IP_USER_TYPE = row["IP_USER_TYPE"].ToString(),
                            IP_USER_LEVEL = row["IP_USER_LEVEL"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            IP_ALIAS = row["IP_ALIAS"].ToString(),
                            IP_ID = ClsStrVulue.convertToDecimal(row["IP_ID"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_IP_USER_ALLOW", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_IP_USER_ALLOW save data error!!");
                    else
                        Console.WriteLine("PAY_IP_USER_ALLOW insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_JOB
        public static void Import_PAY_JOB()
        {
            try
            {
                string str = @"select * from PAY_JOB";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_JOB>();
                var item = new PAY_JOB();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_JOB";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_JOB
                        {
                            JOBNO = ClsStrVulue.convertToDecimal(row["JOBNO"]),
                            JOBCODE = row["JOBCODE"].ToString(),
                            JOBNAME = row["JOBNAME"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            FLG = row["FLG"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            JOB_REMARK = row["JOB_REMARK"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_JOB", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_JOB save data error!!");
                    else
                        Console.WriteLine("PAY_JOB insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_JOB_COST
        public static void Import_PAY_JOB_COST()
        {
            try
            {
                string str = @"select * from PAY_JOB_COST";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_JOB_COST>();
                var item = new PAY_JOB_COST();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_JOB_COST";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_JOB_COST
                        {
                            JOB_COST_ID = ClsStrVulue.convertToDecimal(row["JOB_COST_ID"]),
                            JOB_REC = ClsStrVulue.convertToDecimal(row["JOB_REC"]),
                            EMP_NO = row["EMP_NO"].ToString(),
                            MONTHLY = row["MONTHLY"].ToString(),
                            YEARLY = row["YEARLY"].ToString(),
                            JOB_INCOME = ClsStrVulue.convertToDecimal(row["JOB_INCOME"]),
                            JOB_DEDUCT = ClsStrVulue.convertToDecimal(row["JOB_DEDUCT"]),
                            JOB_TOTAL = ClsStrVulue.convertToDecimal(row["JOB_TOTAL"]),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            JOBDATE_S = row["JOBDATE_S"].ToString(),
                            JOBDATE_E = row["JOBDATE_E"].ToString(),
                            DAYDIFF = row["DAYDIFF"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_JOB_COST", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_JOB_COST save data error!!");
                    else
                        Console.WriteLine("PAY_JOB_COST insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_JOB_PERIOD
        public static void Import_PAY_JOB_PERIOD()
        {
            try
            {
                string str = @"select * from PAY_JOB_PERIOD";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_JOB_PERIOD>();
                var item = new PAY_JOB_PERIOD();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_JOB_PERIOD";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_JOB_PERIOD
                        {
                            JOB_REC = ClsStrVulue.convertToDecimal(row["JOB_REC"]),
                            JOBNO = ClsStrVulue.convertToDecimal(row["JOBNO"]),
                            EMP_NO = row["EMP_NO"].ToString(),
                            JOBDATE_S = row["JOBDATE_S"].ToString(),
                            JOBDATE_E = row["JOBDATE_E"].ToString(),
                            FLG = row["FLG"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            REMARKS = row["REMARKS"].ToString(),
                            COM_ID = row["COM_ID"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_JOB_PERIOD", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_JOB_PERIOD save data error!!");
                    else
                        Console.WriteLine("PAY_JOB_PERIOD insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_LEAVEWP
        public static void Import_PAY_LEAVEWP()
        {
            try
            {
                string str = @"select * from PAY_LEAVEWP";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_LEAVEWP>();
                var item = new PAY_LEAVEWP();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_LEAVEWP";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_LEAVEWP
                        {
                            MONTHLY = row["MONTHLY"].ToString(),
                            YEARLY = row["YEARLY"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            AMOUNT = ClsStrVulue.convertToDecimal(row["AMOUNT"]),
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            EMP_NO = row["EMP_NO"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_LEAVEWP", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_LEAVEWP save data error!!");
                    else
                        Console.WriteLine("PAY_LEAVEWP insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_LOAN_DETAIL
        public static void Import_PAY_LOAN_DETAIL()
        {
            try
            {
                string str = @"select * from PAY_LOAN_DETAIL";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_LOAN_DETAIL>();
                var item = new PAY_LOAN_DETAIL();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_LOAN_DETAIL";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_LOAN_DETAIL
                        {
                            LOAN_ID = ClsStrVulue.convertToDecimal(row["LOAN_ID"]),
                            LOAN_TYPE = row["LOAN_TYPE"].ToString(),
                            LOAN_INCLUDEDIVI = ClsStrVulue.convertToDecimal(row["LOAN_INCLUDEDIVI"]),
                            LOAN_UP_FLG = row["LOAN_UP_FLG"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            LOAN_INCLUDE_FLG = row["LOAN_INCLUDE_FLG"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            FLG_USE = row["FLG_USE"].ToString(),
                            EXTCODE1 = row["EXTCODE1"].ToString(),
                            EXTCODE2 = row["EXTCODE2"].ToString(),
                            EXTDESC = row["EXTDESC"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_LOAN_DETAIL", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_LOAN_DETAIL save data error!!");
                    else
                        Console.WriteLine("PAY_LOAN_DETAIL insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_LOGALERT
        public static void Import_PAY_LOGALERT()
        {
            try
            {
                string str = @"select * from PAY_LOGALERT";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_LOGALERT>();
                var item = new PAY_LOGALERT();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_LOGALERT";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_LOGALERT
                        {
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            D_DATE = row["D_DATE"].ToString(),
                            T_TIME = row["T_TIME"].ToString(),
                            DETAIL = row["DETAIL"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            EMP = row["EMP"].ToString(),
                            MYEAR = row["MYEAR"].ToString(),
                            FLG_STATUS = row["FLG_STATUS"].ToString(),
                            NUM = ClsStrVulue.convertToDecimal(row["NUM"]),
                            USERID = row["USERID"].ToString(),
                            LOG_GROUP = row["LOG_GROUP"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_LOGALERT", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_LOGALERT save data error!!");
                    else
                        Console.WriteLine("PAY_LOGALERT insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_MTHINCDED
        public static void Import_PAY_MTHINCDED()
        {
            try
            {
                string str = @"select * from PAY_MTHINCDED";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_MTHINCDED>();
                var item = new PAY_MTHINCDED();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_MTHINCDED";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_MTHINCDED
                        {
                            TMTH_ID = ClsStrVulue.convertToDecimal(row["TMTH_ID"]),
                            EMP_NO = row["EMP_NO"].ToString(),
                            YEARLY = row["YEARLY"].ToString(),
                            MONTHLY = row["MONTHLY"].ToString(),
                            TOTAL_INCOME = ClsStrVulue.convertToDecimal(row["TOTAL_INCOME"]),
                            TOTAL_DEDUCT = ClsStrVulue.convertToDecimal(row["TOTAL_DEDUCT"]),
                            TOTAL_TAX = ClsStrVulue.convertToDecimal(row["TOTAL_TAX"]),
                            TOTAL_SSO = ClsStrVulue.convertToDecimal(row["TOTAL_SSO"]),
                            TOTAL_PVD = ClsStrVulue.convertToDecimal(row["TOTAL_PVD"]),
                            TOTAL_AMOUNT = ClsStrVulue.convertToDecimal(row["TOTAL_AMOUNT"]),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            TOTAL_SALARY = ClsStrVulue.convertToDecimal(row["TOTAL_SALARY"]),
                            PROCESSID = row["PROCESSID"].ToString(),
                            FLGUSE = row["FLGUSE"].ToString(),
                            FLGSLIP = row["FLGSLIP"].ToString(),
                            TOTAL_SSO_C = ClsStrVulue.convertToDecimal(row["TOTAL_SSO_C"]),
                            TOTAL_PVD_C = ClsStrVulue.convertToDecimal(row["TOTAL_PVD_C"]),
                            EXP_ID = row["EXP_ID"].ToString(),
                            PRNBY = row["PRNBY"].ToString(),
                            TOTAL_SALARY_SSO = ClsStrVulue.convertToDecimal(row["TOTAL_SALARY_SSO"]),
                            TOTAL_AMOUNT_OLD = ClsStrVulue.convertToDecimal(row["TOTAL_AMOUNT_OLD"]),
                            FLG_R = row["FLG_R"].ToString(),
                            TOTAL_AMOUNT_TEMP = ClsStrVulue.convertToDecimal(row["TOTAL_AMOUNT_TEMP"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_MTHINCDED", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_MTHINCDED save data error!!");
                    else
                        Console.WriteLine("PAY_MTHINCDED insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_OFFER_LABORLAW
        public static void Import_PAY_OFFER_LABORLAW()
        {
            try
            {
                string str = @"select * from PAY_OFFER_LABORLAW";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_OFFER_LABORLAW>();
                var item = new PAY_OFFER_LABORLAW();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_OFFER_LABORLAW";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_OFFER_LABORLAW
                        {
                            LABOR_LAWID = ClsStrVulue.convertToDecimal(row["LABOR_LAWID"]),
                            QTY_WORKDAY1 = ClsStrVulue.convertToDecimal(row["QTY_WORKDAY1"]),
                            QTY_WORKDAY2 = ClsStrVulue.convertToDecimal(row["QTY_WORKDAY2"]),
                            TYPE_UNIT = row["TYPE_UNIT"].ToString(),
                            QTY_MONTH = ClsStrVulue.convertToDecimal(row["QTY_MONTH"]),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            COM_ID = row["COM_ID"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_OFFER_LABORLAW", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_OFFER_LABORLAW save data error!!");
                    else
                        Console.WriteLine("PAY_OFFER_LABORLAW insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_OFFER_OTHERCOST
        public static void Import_PAY_OFFER_OTHERCOST()
        {
            try
            {
                string str = @"select * from PAY_OFFER_OTHERCOST";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_OFFER_OTHERCOST>();
                var item = new PAY_OFFER_OTHERCOST();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_OFFER_OTHERCOST";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_OFFER_OTHERCOST
                        {
                            OTHER_COSTID = ClsStrVulue.convertToDecimal(row["OTHER_COSTID"]),
                            COST1 = ClsStrVulue.convertToDecimal(row["COST1"]),
                            COST2 = ClsStrVulue.convertToDecimal(row["COST2"]),
                            COST3 = ClsStrVulue.convertToDecimal(row["COST3"]),
                            QTY_MONTH = ClsStrVulue.convertToDecimal(row["QTY_MONTH"]),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            COM_ID = row["COM_ID"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_OFFER_OTHERCOST", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_OFFER_OTHERCOST save data error!!");
                    else
                        Console.WriteLine("PAY_OFFER_OTHERCOST insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_OFFER_PERSONALTAX
        public static void Import_PAY_OFFER_PERSONALTAX()
        {
            try
            {
                string str = @"select * from PAY_OFFER_PERSONALTAX";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_OFFER_PERSONALTAX>();
                var item = new PAY_OFFER_PERSONALTAX();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_OFFER_PERSONALTAX";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_OFFER_PERSONALTAX
                        {
                            PERSON_TAXID = ClsStrVulue.convertToDecimal(row["PERSON_TAXID"]),
                            COST_RANGE1 = ClsStrVulue.convertToDecimal(row["COST_RANGE1"]),
                            COST_RANGE2 = ClsStrVulue.convertToDecimal(row["COST_RANGE2"]),
                            GETTAX = ClsStrVulue.convertToDecimal(row["GETTAX"]),
                            QTY_MONTH = ClsStrVulue.convertToDecimal(row["QTY_MONTH"]),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            COM_ID = ClsStrVulue.convertToDecimal(row["COM_ID"]),
                            FLG_USE = row["FLG_USE"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_OFFER_PERSONALTAX", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_OFFER_PERSONALTAX save data error!!");
                    else
                        Console.WriteLine("PAY_OFFER_PERSONALTAX insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_OT
        public static void Import_PAY_OT()
        {
            try
            {
                string str = @"select * from PAY_OT";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_OT>();
                var item = new PAY_OT();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_OT";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_OT
                        {
                            OT_ID = ClsStrVulue.convertToDecimal(row["OT_ID"]),
                            OT_TYPE = row["OT_TYPE"].ToString(),
                            OTCAL_TYPE = row["OTCAL_TYPE"].ToString(),
                            OT_RANGE = row["OT_RANGE"].ToString(),
                            OT_UNIT = row["OT_UNIT"].ToString(),
                            FLG = ClsStrVulue.convertToDecimal(row["FLG"]),
                            COM_ID = row["COM_ID"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            EXTCODE1 = row["EXTCODE1"].ToString(),
                            EXTCODE2 = row["EXTCODE2"].ToString(),
                            EXTDESC = row["EXTDESC"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_OT", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_OT save data error!!");
                    else
                        Console.WriteLine("PAY_OT insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_PERMISSION
        public static void Import_PAY_PERMISSION()
        {
            try
            {
                string str = @"select * from PAY_PERMISSION";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_PERMISSION>();
                var item = new PAY_PERMISSION();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_PERMISSION";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_PERMISSION
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
                            GROUP_NO = ClsStrVulue.convertToDecimal(row["GROUP_NO"]),
                            PADVANCE = row["PADVANCE"].ToString(),
                            PLEVEL = row["PLEVEL"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_PERMISSION", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_PERMISSION save data error!!");
                    else
                        Console.WriteLine("PAY_PERMISSION insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_POSITION
        public static void Import_PAY_POSITION()
        {
            try
            {
                string str = @"select * from PAY_POSITION";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_POSITION>();
                var item = new PAY_POSITION();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_POSITION";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_POSITION
                        {
                            POSITION_NO = ClsStrVulue.convertToDecimal(row["POSITION_NO"]),
                            POSITION_NAME = row["POSITION_NAME"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            POSITION_LEVEL = row["POSITION_LEVEL"].ToString(),
                            POSITION_STATUS = row["POSITION_STATUS"].ToString(),
                            DEPTNO = row["DEPTNO"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_POSITION", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_POSITION save data error!!");
                    else
                        Console.WriteLine("PAY_POSITION insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_PROVIDENTFUND
        public static void Import_PAY_PROVIDENTFUND()
        {
            try
            {
                string str = @"select * from PAY_PROVIDENTFUND";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_PROVIDENTFUND>();
                var item = new PAY_PROVIDENTFUND();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_PROVIDENTFUND";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_PROVIDENTFUND
                        {
                            FUND_ID = ClsStrVulue.convertToDecimal(row["FUND_ID"]),
                            FOR_EMP = ClsStrVulue.convertToDecimal(row["FOR_EMP"]),
                            FOR_COMPANY = ClsStrVulue.convertToDecimal(row["FOR_COMPANY"]),
                            AGEFUND = row["AGEFUND"].ToString(),
                            DENY_FLG = row["DENY_FLG"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            COM_ID = row["COM_ID"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_PROVIDENTFUND", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_PROVIDENTFUND save data error!!");
                    else
                        Console.WriteLine("PAY_PROVIDENTFUND insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_PVDCOVER
        public static void Import_PAY_PVDCOVER()
        {
            try
            {
                string str = @"select * from PAY_PVDCOVER";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_PVDCOVER>();
                var item = new PAY_PVDCOVER();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_PVDCOVER";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_PVDCOVER
                        {
                            MONTHLY = row["MONTHLY"].ToString(),
                            YEARLY = row["YEARLY"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            H01 = row["H01"].ToString(),
                            H02 = row["H02"].ToString(),
                            H03 = row["H03"].ToString(),
                            H04 = row["H04"].ToString(),
                            B01 = row["B01"].ToString(),
                            B02 = row["B02"].ToString(),
                            B03 = row["B03"].ToString(),
                            B04 = row["B04"].ToString(),
                            C01 = row["C01"].ToString(),
                            C02 = row["C02"].ToString(),
                            C03 = row["C03"].ToString(),
                            C04 = row["C04"].ToString(),
                            F01 = row["F01"].ToString(),
                            F02 = row["F02"].ToString(),
                            F03 = row["F03"].ToString(),
                            F04 = row["F04"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_PVDCOVER", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_PVDCOVER save data error!!");
                    else
                        Console.WriteLine("PAY_PVDCOVER insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_SETCOMPANY
        public static void Import_PAY_SETCOMPANY()
        {
            try
            {
                string str = @"select * from PAY_SETCOMPANY";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_SETCOMPANY>();
                var item = new PAY_SETCOMPANY();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_SETCOMPANY";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_SETCOMPANY
                        {
                            COM_ID = row["COM_ID"].ToString(),
                            COM_NAMEE = row["COM_NAMEE"].ToString(),
                            COM_NAMET = row["COM_NAMET"].ToString(),
                            COM_ADDRESSNO = row["COM_ADDRESSNO"].ToString(),
                            COM_SOI = row["COM_SOI"].ToString(),
                            COM_ROAD = row["COM_ROAD"].ToString(),
                            COM_PROVINCE = row["COM_PROVINCE"].ToString(),
                            COM_MAIL = row["COM_MAIL"].ToString(),
                            COM_PHONE = row["COM_PHONE"].ToString(),
                            COM_FAX = row["COM_FAX"].ToString(),
                            COM_WORKQTY = ClsStrVulue.convertToDecimal(row["COM_WORKQTY"]),
                            COM_WORKHOURD = ClsStrVulue.convertToDecimal(row["COM_WORKHOURD"]),
                            COM_WORKHOURM = ClsStrVulue.convertToDecimal(row["COM_WORKHOURM"]),
                            COM_AGEWORKTYPE = ClsStrVulue.convertToDecimal(row["COM_AGEWORKTYPE"]),
                            COM_ACCNO = row["COM_ACCNO"].ToString(),
                            COM_TAXNO = row["COM_TAXNO"].ToString(),
                            COM_PFNO = row["COM_PFNO"].ToString(),
                            COM_DOCNO = row["COM_DOCNO"].ToString(),
                            COM_SFFNO = row["COM_SFFNO"].ToString(),
                            COM_SFFORDER = row["COM_SFFORDER"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            COM_DISTICT = row["COM_DISTICT"].ToString(),
                            COM_CITY = row["COM_CITY"].ToString(),
                            COM_ZIPCODE = ClsStrVulue.convertToDecimal(row["COM_ZIPCODE"]),
                            ADMIN_UNAME = row["ADMIN_UNAME"].ToString(),
                            KBANK_CODE = row["KBANK_CODE"].ToString(),
                            PVD_SIGNNAME = row["PVD_SIGNNAME"].ToString(),
                            PVD_SIGNPOS = row["PVD_SIGNPOS"].ToString(),
                            TAX_SIGNNAME = row["TAX_SIGNNAME"].ToString(),
                            TAX_SIGNPOS = row["TAX_SIGNPOS"].ToString(),
                            SSO_SIGNNAME = row["SSO_SIGNNAME"].ToString(),
                            SSO_SIGNPOS = row["SSO_SIGNPOS"].ToString(),
                            TAX_BRANCH = row["TAX_BRANCH"].ToString(),
                            COM_CODE = row["COM_CODE"].ToString(),
                            OT_SIGNNAME = row["OT_SIGNNAME"].ToString(),
                            OT_SIGNPOS = row["OT_SIGNPOS"].ToString(),
                            TIME_IN01 = row["TIME_IN01"].ToString(),
                            TIME_IN02 = row["TIME_IN02"].ToString(),
                            TIME_IN03 = row["TIME_IN03"].ToString(),
                            TIME_IN04 = row["TIME_IN04"].ToString(),
                            TIME_OUT01 = row["TIME_OUT01"].ToString(),
                            TIME_OUT02 = row["TIME_OUT02"].ToString(),
                            TIME_OUT03 = row["TIME_OUT03"].ToString(),
                            TIME_OUT04 = row["TIME_OUT04"].ToString(),
                            TIME_IN05 = row["TIME_IN05"].ToString(),
                            TIME_IN06 = row["TIME_IN06"].ToString(),
                            TIME_OUT05 = row["TIME_OUT05"].ToString(),
                            TIME_OUT06 = row["TIME_OUT06"].ToString(),
                            TXT_POS_EMP_S = ClsStrVulue.convertToDecimal(row["TXT_POS_EMP_S"]),
                            TXT_POS_EMP_E = ClsStrVulue.convertToDecimal(row["TXT_POS_EMP_E"]),
                            TXT_POS_D_S = ClsStrVulue.convertToDecimal(row["TXT_POS_D_S"]),
                            TXT_POS_D_E = ClsStrVulue.convertToDecimal(row["TXT_POS_D_E"]),
                            TXT_POS_M_S = ClsStrVulue.convertToDecimal(row["TXT_POS_M_S"]),
                            TXT_POS_M_E = ClsStrVulue.convertToDecimal(row["TXT_POS_M_E"]),
                            TXT_POS_Y_S = ClsStrVulue.convertToDecimal(row["TXT_POS_Y_S"]),
                            TXT_POS_Y_E = ClsStrVulue.convertToDecimal(row["TXT_POS_Y_E"]),
                            TXT_POS_HR_S = ClsStrVulue.convertToDecimal(row["TXT_POS_HR_S"]),
                            TXT_POS_HR_E = ClsStrVulue.convertToDecimal(row["TXT_POS_HR_E"]),
                            TXT_POS_MI_S = ClsStrVulue.convertToDecimal(row["TXT_POS_MI_S"]),
                            TXT_POS_MI_E = ClsStrVulue.convertToDecimal(row["TXT_POS_MI_E"]),
                            PATH_LOGO = row["PATH_LOGO"].ToString(),
                            ADMIN_UNAME_PTY = row["ADMIN_UNAME_PTY"].ToString(),
                            COM_CORPORATION = row["COM_CORPORATION"].ToString(),
                            ITEMID = ClsStrVulue.convertToDecimal(row["ITEMID"]),
                            ITEMNUMBER = row["ITEMNUMBER"].ToString(),
                            COM_IDB_SCB = row["COM_IDB_SCB"].ToString(),
                            COM_IDB_BAY = row["COM_IDB_BAY"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_SETCOMPANY", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_SETCOMPANY save data error!!");
                    else
                        Console.WriteLine("PAY_SETCOMPANY insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_SETPVDCOVER
        public static void Import_PAY_SETPVDCOVER()
        {
            try
            {
                string str = @"select * from PAY_SETPVDCOVER";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_SETPVDCOVER>();
                var item = new PAY_SETPVDCOVER();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_SETPVDCOVER";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_SETPVDCOVER
                        {
                            COVER_ID = ClsStrVulue.convertToDecimal(row["COVER_ID"]),
                            COM_ID = row["COM_ID"].ToString(),
                            H01 = row["H01"].ToString(),
                            H02 = row["H02"].ToString(),
                            H03 = row["H03"].ToString(),
                            H04 = row["H04"].ToString(),
                            B01 = row["B01"].ToString(),
                            B02 = row["B02"].ToString(),
                            B03 = row["B03"].ToString(),
                            B04 = row["B04"].ToString(),
                            C01 = row["C01"].ToString(),
                            C02 = row["C02"].ToString(),
                            C03 = row["C03"].ToString(),
                            C04 = row["C04"].ToString(),
                            F01 = row["F01"].ToString(),
                            F02 = row["F02"].ToString(),
                            F03 = row["F03"].ToString(),
                            F04 = row["F04"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_SETPVDCOVER", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_SETPVDCOVER save data error!!");
                    else
                        Console.WriteLine("PAY_SETPVDCOVER insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_SOCIALCOST
        public static void Import_PAY_SOCIALCOST()
        {
            try
            {
                string str = @"select * from PAY_SOCIALCOST";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_SOCIALCOST>();
                var item = new PAY_SOCIALCOST();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_SOCIALCOST";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_SOCIALCOST
                        {
                            SOCIAL_ID = ClsStrVulue.convertToDecimal(row["SOCIAL_ID"]),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            CAL_FLG = row["CAL_FLG"].ToString(),
                            DENY_FLG = row["DENY_FLG"].ToString(),
                            MAXSALARY = ClsStrVulue.convertToDecimal(row["MAXSALARY"]),
                            MAXSOCIAL = ClsStrVulue.convertToDecimal(row["MAXSOCIAL"]),
                            MINSALARY = ClsStrVulue.convertToDecimal(row["MINSALARY"]),
                            MINSOCIAL = ClsStrVulue.convertToDecimal(row["MINSOCIAL"]),
                            COM_ID = row["COM_ID"].ToString(),
                            FOR_EMP = ClsStrVulue.convertToDecimal(row["FOR_EMP"]),
                            FOR_COMPANY = ClsStrVulue.convertToDecimal(row["FOR_COMPANY"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_SOCIALCOST", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_SOCIALCOST save data error!!");
                    else
                        Console.WriteLine("PAY_SOCIALCOST insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_TIME
        public static void Import_PAY_TIME()
        {
            try
            {
                string str = @"select * from PAY_TIME";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_TIME>();
                var item = new PAY_TIME();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_TIME";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_TIME
                        {
                            TIME_ID = ClsStrVulue.convertToDecimal(row["TIME_ID"]),
                            EMP_NO = row["EMP_NO"].ToString(),
                            MONTHLY = row["MONTHLY"].ToString(),
                            YEARLY = row["YEARLY"].ToString(),
                            TIME_DATE = row["TIME_DATE"].ToString(),
                            TIME_IN = row["TIME_IN"].ToString(),
                            TIME_OUT = row["TIME_OUT"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            ID_CARD = row["ID_CARD"].ToString(),
                            FLG = row["FLG"].ToString(),
                            TIME_DESC = row["TIME_DESC"].ToString(),
                            REASON = row["REASON"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            HR = ClsStrVulue.convertToDecimal(row["HR"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_TIME", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_TIME save data error!!");
                    else
                        Console.WriteLine("PAY_TIME insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_TIME_HOLIDAY
        public static void Import_PAY_TIME_HOLIDAY()
        {
            try
            {
                string str = @"select * from PAY_TIME_HOLIDAY";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_TIME_HOLIDAY>();
                var item = new PAY_TIME_HOLIDAY();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_TIME_HOLIDAY";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_TIME_HOLIDAY
                        {
                            WD_DATE = row["WD_DATE"].ToString(),
                            WD_TYPE = row["WD_TYPE"].ToString(),
                            WD_DESC = row["WD_DESC"].ToString(),
                            WD_TIME_IN = row["WD_TIME_IN"].ToString(),
                            WD_TIME_OUT = row["WD_TIME_OUT"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            WD_TIME_NO = row["WD_TIME_NO"].ToString(),
                            YEARLY = row["YEARLY"].ToString(),
                            MONTHLY = row["MONTHLY"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_TIME_HOLIDAY", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_TIME_HOLIDAY save data error!!");
                    else
                        Console.WriteLine("PAY_TIME_HOLIDAY insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_TIME_RAW
        public static void Import_PAY_TIME_RAW()
        {
            try
            {
                string str = @"select * from PAY_TIME_RAW";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_TIME_RAW>();
                var item = new PAY_TIME_RAW();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_TIME_RAW";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    int i = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_TIME_RAW
                        {
                            EMP_NO = row["EMP_NO"].ToString(),
                            DATE_RAW = row["DATE_RAW"].ToString(),
                            TIME_RAW = row["TIME_RAW"].ToString(),
                            FILTER01 = row["FILTER01"].ToString(),
                            FILTER02 = row["FILTER02"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            ENTRYFILE = row["ENTRYFILE"].ToString(),
                            ENTRYID = row["ENTRYID"].ToString()
                        });

                        if (i % 50000 == 0)
                        {
                            if (!ClsSQLServer.BulkCopy("PAY_TIME_RAW", conn_sql, paramList, itemList))
                                Console.WriteLine("PAY_TIME_RAW save data error!!");
                            else
                                Console.WriteLine("PAY_TIME_RAW insert complate!!");

                            itemList = new List<PAY_TIME_RAW>();
                        }

                        i++;
                    }

                    if (itemList.Count > 0)
                    {
                        if (!ClsSQLServer.BulkCopy("PAY_TIME_RAW", conn_sql, paramList, itemList))
                            Console.WriteLine("PAY_TIME_RAW save data error!!");
                        else
                            Console.WriteLine("PAY_TIME_RAW insert complate!!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_TRANSDEPT
        public static void Import_PAY_TRANSDEPT()
        {
            try
            {
                string str = @"select * from PAY_TRANSDEPT";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_TRANSDEPT>();
                var item = new PAY_TRANSDEPT();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_TRANSDEPT";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_TRANSDEPT
                        {
                            TRANS_DEPTID = ClsStrVulue.convertToDecimal(row["TRANS_DEPTID"].ToString()),
                            EMPNO = row["EMPNO"].ToString(),
                            OLD_DEPT = row["OLD_DEPT"].ToString(),
                            NEW_DEPT = row["NEW_DEPT"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            TRANDATE = row["TRANDATE"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            FLGDELETE = row["FLGDELETE"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_TRANSDEPT", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_TRANSDEPT save data error!!");
                    else
                        Console.WriteLine("PAY_TRANSDEPT insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_WORKINFO
        public static void Import_PAY_WORKINFO()
        {
            try
            {
                string str = @"select * from PAY_WORKINFO";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_WORKINFO>();
                var item = new PAY_WORKINFO();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_WORKINFO";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_WORKINFO
                        {
                            INFO_ID = ClsStrVulue.convertToDecimal(row["INFO_ID"]),
                            EMPNO = row["EMPNO"].ToString(),
                            W_MONTH = row["W_MONTH"].ToString(),
                            W_YEAR = row["W_YEAR"].ToString(),
                            W_LATE = row["W_LATE"].ToString(),
                            W_NOSALARY = row["W_NOSALARY"].ToString(),
                            W_DAYOFF = row["W_DAYOFF"].ToString(),
                            W_NOENTRY = row["W_NOENTRY"].ToString(),
                            W_NOEXIT = row["W_NOEXIT"].ToString(),
                            B_LATE = ClsStrVulue.convertToDecimal(row["B_LATE"]),
                            B_NOSALARY = ClsStrVulue.convertToDecimal(row["B_NOSALARY"]),
                            B_DAYOFF = ClsStrVulue.convertToDecimal(row["B_DAYOFF"]),
                            B_NOENTRY = ClsStrVulue.convertToDecimal(row["B_NOENTRY"]),
                            B_NOEXIT = ClsStrVulue.convertToDecimal(row["B_NOEXIT"]),
                            COM_ID = row["COM_ID"].ToString(),
                            ENTRYUSER = ClsStrVulue.convertToDecimal(row["ENTRYUSER"]),
                            ENTRYTIME = ClsStrVulue.convertToDecimal(row["ENTRYTIME"]),
                            ENTRYDATE = ClsStrVulue.convertToDecimal(row["ENTRYDATE"]),
                            UPDATEUSER = ClsStrVulue.convertToDecimal(row["UPDATEUSER"]),
                            UPDATETIME = ClsStrVulue.convertToDecimal(row["UPDATETIME"]),
                            UPDATEDATE = ClsStrVulue.convertToDecimal(row["UPDATEDATE"]),
                            W_TOTAL = ClsStrVulue.convertToDecimal(row["W_TOTAL"]),
                            FLGCAL = row["FLGCAL"].ToString(),
                            REC_6001 = ClsStrVulue.convertToDecimal(row["REC_6001"]),
                            CAL_SALARY = ClsStrVulue.convertToDecimal(row["CAL_SALARY"]),
                            DATE_CAL = row["DATE_CAL"].ToString(),
                            REC_6002 = ClsStrVulue.convertToDecimal(row["REC_6002"]),
                            REC_6003 = ClsStrVulue.convertToDecimal(row["REC_6003"]),
                            REC_6004 = ClsStrVulue.convertToDecimal(row["REC_6004"]),
                            REC_6005 = ClsStrVulue.convertToDecimal(row["REC_6005"]),
                            REC_ID = ClsStrVulue.convertToDecimal(row["REC_ID"]),
                            B_NOSALARYHALF_M = ClsStrVulue.convertToDecimal(row["B_NOSALARYHALF_M"]),
                            B_NOSALARY_M = ClsStrVulue.convertToDecimal(row["B_NOSALARY_M"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_WORKINFO", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_WORKINFO save data error!!");
                    else
                        Console.WriteLine("PAY_WORKINFO insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PAY_YRINCDED
        public static void Import_PAY_YRINCDED()
        {
            try
            {
                string str = @"select * from PAY_YRINCDED";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<PAY_YRINCDED>();
                var item = new PAY_YRINCDED();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PAY_YRINCDED";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PAY_YRINCDED
                        {
                            TYR_ID = ClsStrVulue.convertToDecimal(row["TYR_ID"]),
                            EMP_NO = row["EMP_NO"].ToString(),
                            YEARLY = row["YEARLY"].ToString(),
                            TOTAL_INCOME = ClsStrVulue.convertToDecimal(row["TOTAL_INCOME"]),
                            TOTAL_DEDUCT = ClsStrVulue.convertToDecimal(row["TOTAL_DEDUCT"]),
                            TOTAL_TAX = ClsStrVulue.convertToDecimal(row["TOTAL_TAX"]),
                            TOTAL_SSO = ClsStrVulue.convertToDecimal(row["TOTAL_SSO"]),
                            TOTAL_PVD = ClsStrVulue.convertToDecimal(row["TOTAL_PVD"]),
                            TOTAL_AMOUNT = ClsStrVulue.convertToDecimal(row["TOTAL_AMOUNT"]),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString(),
                            COM_ID = row["COM_ID"].ToString(),
                            TOTAL_SALARY = ClsStrVulue.convertToDecimal(row["TOTAL_SALARY"]),
                            TOTAL_SSO_C = ClsStrVulue.convertToDecimal(row["TOTAL_SSO_C"]),
                            TOTAL_PVD_C = ClsStrVulue.convertToDecimal(row["TOTAL_PVD_C"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PAY_YRINCDED", conn_sql, paramList, itemList))
                        Console.WriteLine("PAY_YRINCDED save data error!!");
                    else
                        Console.WriteLine("PAY_YRINCDED insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region SUPREME_USER
        public static void Import_SUPREME_USER()
        {
            try
            {
                string str = @"select * from SUPREME_USER";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<SUPREME_USER>();
                var item = new SUPREME_USER();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table SUPREME_USER";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new SUPREME_USER
                        {
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            EMPNO = row["EMPNO"].ToString(),
                            SUP_USERNAME = row["SUP_USERNAME"].ToString(),
                            SUP_PASSWORD = row["SUP_PASSWORD"].ToString(),
                            COMPUTERNAME = row["COMPUTERNAME"].ToString(),
                            MNG_NO = ClsStrVulue.convertToDecimal(row["MNG_NO"]),
                            USE_CK = ClsStrVulue.convertToDecimal(row["USE_CK"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("SUPREME_USER", conn_sql, paramList, itemList))
                        Console.WriteLine("SUPREME_USER save data error!!");
                    else
                        Console.WriteLine("SUPREME_USER insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region EMP
        public static void Import_EMP()
        {
            try
            {
                string str = @"select * from EMP where HIREDATE is not null";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

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
                            HIREDATE = Convert.ToDateTime(row["HIREDATE"].ToString()),
                            DEPTNO = row["DEPTNO"].ToString(),
                            MNGNO = row["MNGNO"].ToString(),
                            E_JOB = row["E_JOB"].ToString(),
                            E_SITUATION = row["E_SITUATION"].ToString(),
                            QUITDATE = row["QUITDATE"].ToString(),
                            E_MOBILE = row["E_MOBILE"].ToString(),
                            E_PAGER = row["E_PAGER"].ToString(),
                            E_EXTENTION = row["E_EXTENTION"].ToString(),
                            EMP_RECORDER = row["EMP_RECORDER"].ToString(),
                            S_DEPTNO = row["S_DEPTNO"].ToString(),
                            E_MAIL = row["E_MAIL"].ToString(),
                            E_NAME_EN = row["E_NAME_EN"].ToString(),
                            E_NICKNAME = row["E_NICKNAME"].ToString(),
                            REC_DATE = row["REC_DATE"].ToString(),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = row["LAST_DATE"].ToString(),
                            POSITION_NO = ClsStrVulue.convertToDecimal(row["POSITION_NO"]),
                            SENT_TO_SAP = row["SENT_TO_SAP"].ToString(),
                            SENT_TO_DATE = row["SENT_TO_DATE"].ToString()
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

        #region DEPT
        public static void Import_DEPT()
        {
            try
            {
                string str = @"select * from DEPT";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str).Tables[0];

                var itemList = new List<DEPT>();
                var item = new DEPT();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table DEPT";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new DEPT
                        {
                            DEPTNO = row["DEPTNO"].ToString(),
                            DEPTNAME = row["DEPTNAME"].ToString(),
                            DEPTABBR = row["DEPTABBR"].ToString(),
                            DEPTTYPE = row["DEPTTYPE"].ToString(),
                            PARENT = row["PARENT"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("DEPT", conn_sql, paramList, itemList))
                        Console.WriteLine("DEPT save data error!!");
                    else
                        Console.WriteLine("DEPT insert complate!!");
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
