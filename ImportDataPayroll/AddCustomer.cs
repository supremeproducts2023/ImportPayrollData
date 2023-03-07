using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Configuration;
using System.Reflection;
using System.Data.OracleClient;
using ImportDataPayroll.Models.AddCusotmer;
using System;

namespace ImportDataPayroll
{
    public class AddCustomer
    {
        static string conn_sql = ConfigurationManager.AppSettings["ConnectionString_SQLSERVER"].ToString();

        #region log_customer
        public static void Import_log_customer()
        {
            try
            {
                string str = @"select * from log_customer";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<log_customer>();
                var item = new log_customer();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table log_customer";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new log_customer
                        {
                            RUN_NUM = ClsStrVulue.convertToDecimal(row["RUN_NUM"]),
                            CUSNO = ClsStrVulue.convertToDecimal(row["CUSNO"]),
                            C_TITLE = row["C_TITLE"].ToString(),
                            C_NAME = row["C_NAME"].ToString(),
                            OCCUPATION_ID = ClsStrVulue.convertToDecimal(row["OCCUPATION_ID"]),
                            SPNO = row["SPNO"].ToString(),
                            C_BIRTHDAY = ClsStrVulue.convertToDateTime(row["C_BIRTHDAY"]),
                            C_STATUS = row["C_STATUS"].ToString(),
                            C_SEX = row["C_SEX"].ToString(),
                            C_MOBILE = row["C_MOBILE"].ToString(),
                            C_EMAIL = row["C_EMAIL"].ToString(),
                            C_RATING = row["C_RATING"].ToString(),
                            C_TYPE = row["C_TYPE"].ToString(),
                            C_TAXID = row["C_TAXID"].ToString(),
                            C_AS400ID = row["C_AS400ID"].ToString(),
                            C_IDCARD = ClsStrVulue.convertToDecimal(row["C_IDCARD"]),
                            UPDATE_USER = row["UPDATE_USER"].ToString(),
                            UPDATE_DATETIME = ClsStrVulue.convertToDateTime(row["UPDATE_DATETIME"]),
                            STATUS_LOG = row["STATUS_LOG"].ToString(),
                            USER_REQUEST = row["USER_REQUEST"].ToString(),
                            REMARK = row["REMARK"].ToString(),
                            TAX_BRANCH = row["TAX_BRANCH"].ToString(),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("log_customer", conn_sql, paramList, itemList))
                        Console.WriteLine("log_customer save data error!!");
                    else
                        Console.WriteLine("log_customer insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region LOG_HOSPITAL
        public static void Import_LOG_HOSPITAL()
        {
            try
            {
                string str = @"select * from LOG_HOSPITAL";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<LOG_HOSPITAL>();
                var item = new LOG_HOSPITAL();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table LOG_HOSPITAL";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new LOG_HOSPITAL
                        {
                            RUN_NUM = ClsStrVulue.convertToDecimal(row["RUN_NUM"]),
                            HOSNO = ClsStrVulue.convertToDecimal(row["HOSNO"]),
                            H_TYPEID = row["H_TYPEID"].ToString(),
                            H_TITLE = row["H_TITLE"].ToString(),
                            H_NAME = row["H_NAME"].ToString(),
                            HF_NAME = row["HF_NAME"].ToString(),
                            H_SIZE = row["H_SIZE"].ToString(),
                            H_CUS = row["H_CUS"].ToString(),
                            H_EMAIL = row["H_EMAIL"].ToString(),
                            H_AS400ID = ClsStrVulue.convertToDecimal(row["H_AS400ID"]),
                            AS400_TYPE = row["AS400_TYPE"].ToString(),
                            H_BUILDDATE = ClsStrVulue.convertToDateTime(row["H_BUILDDATE"]),
                            H_RATING = row["H_RATING"].ToString(),
                            H_DIRECTOR = row["H_DIRECTOR"].ToString(),
                            H_OWNER = row["H_OWNER"].ToString(),
                            H_ZONE = ClsStrVulue.convertToDecimal(row["H_ZONE"]),
                            UPDATE_USER = row["UPDATE_USER"].ToString(),
                            UPDATE_DATETIME = ClsStrVulue.convertToDateTime(row["UPDATE_DATETIME"]),
                            STATUS_LOG = row["STATUS_LOG"].ToString(),
                            USER_REQUEST = row["USER_REQUEST"].ToString(),
                            REMARK = row["REMARK"].ToString(),
                            TAX_ID = row["TAX_ID"].ToString(),
                            TAX_BRANCH = row["TAX_BRANCH"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("LOG_HOSPITAL", conn_sql, paramList, itemList))
                        Console.WriteLine("LOG_HOSPITAL save data error!!");
                    else
                        Console.WriteLine("LOG_HOSPITAL insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region LOG_ORG_ADDRESS
        public static void Import_LOG_ORG_ADDRESS()
        {
            try
            {
                string str = @"select * from LOG_ORG_ADDRESS";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<LOG_ORG_ADDRESS>();
                var item = new LOG_ORG_ADDRESS();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table LOG_ORG_ADDRESS";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new LOG_ORG_ADDRESS
                        {
                            RUN_NUM = ClsStrVulue.convertToDecimal(row["RUN_NUM"]),
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            ADDRESS = row["ADDRESS"].ToString(),
                            CITY = row["CITY"].ToString(),
                            PROVINCE = row["PROVINCE"].ToString(),
                            ZIPCODE = row["ZIPCODE"].ToString(),
                            ADDR_TYPE = row["ADDR_TYPE"].ToString(),
                            POSTALCODE = row["POSTALCODE"].ToString(),
                            TEL_NUMBER = row["TEL_NUMBER"].ToString(),
                            FAX_NUMBER = row["FAX_NUMBER"].ToString(),
                            STATUS = row["STATUS"].ToString(),
                            UPDATE_USER = row["UPDATE_USER"].ToString(),
                            UPDATE_DATETIME = ClsStrVulue.convertToDateTime(row["UPDATE_DATETIME"]),
                            STATUS_LOG = row["STATUS_LOG"].ToString(),
                            USER_REQUEST = row["USER_REQUEST"].ToString(),
                            REMARK = row["REMARK"].ToString(),
                            HOSNO = ClsStrVulue.convertToDecimal(row["HOSNO"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("LOG_ORG_ADDRESS", conn_sql, paramList, itemList))
                        Console.WriteLine("LOG_ORG_ADDRESS save data error!!");
                    else
                        Console.WriteLine("LOG_ORG_ADDRESS insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region LOG_HOS_COMMENT
        public static void Import_LOG_HOS_COMMENT()
        {
            try
            {
                string str = @"select * from LOG_HOS_COMMENT";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<LOG_HOS_COMMENT>();
                var item = new LOG_HOS_COMMENT();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table LOG_HOS_COMMENT";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new LOG_HOS_COMMENT
                        {
                            RUN_NUM = ClsStrVulue.convertToDecimal(row["RUN_NUM"]),
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            H_COMMENT = row["H_COMMENT"].ToString(),
                            UPDATE_USER = row["UPDATE_USER"].ToString(),
                            UPDATE_DATETIME = ClsStrVulue.convertToDateTime(row["UPDATE_DATETIME"]),
                            STATUS_LOG = row["STATUS_LOG"].ToString(),
                            USER_REQUEST = row["USER_REQUEST"].ToString(),
                            REMARK = row["REMARK"].ToString(),
                            HOSNO = ClsStrVulue.convertToDecimal(row["HOSNO"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("LOG_HOS_COMMENT", conn_sql, paramList, itemList))
                        Console.WriteLine("LOG_HOS_COMMENT save data error!!");
                    else
                        Console.WriteLine("LOG_HOS_COMMENT insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region HOS_COMMENT
        public static void Import_HOS_COMMENT()
        {
            try
            {
                string str = @"select * from HOS_COMMENT";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<HOS_COMMENT>();
                var item = new HOS_COMMENT();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table HOS_COMMENT";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new HOS_COMMENT
                        {
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            HOSNO = ClsStrVulue.convertToDecimal(row["HOSNO"]),
                            H_COMMENTDATE = ClsStrVulue.convertToDateTime(row["H_COMMENTDATE"]),
                            H_COMMENT = row["H_COMMENT"].ToString(),
                            HC_RECORDER = row["HC_RECORDER"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("HOS_COMMENT", conn_sql, paramList, itemList))
                        Console.WriteLine("HOS_COMMENT save data error!!");
                    else
                        Console.WriteLine("HOS_COMMENT insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region LOG_PERSON_ADDR
        public static void Import_LOG_PERSON_ADDR()
        {
            try
            {
                string str = @"select * from LOG_PERSON_ADDR";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<LOG_PERSON_ADDR>();
                var item = new LOG_PERSON_ADDR();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table LOG_PERSON_ADDR";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new LOG_PERSON_ADDR
                        {
                            RUN_NUM = ClsStrVulue.convertToDecimal(row["RUN_NUM"]),
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            CUSNO = ClsStrVulue.convertToDecimal(row["CUSNO"]),
                            ADDRESS = row["ADDRESS"].ToString(),
                            CITY = row["CITY"].ToString(),
                            PROVINCE = row["PROVINCE"].ToString(),
                            ZIPCODE = row["ZIPCODE"].ToString(),
                            ADDR_TYPE = row["ADDR_TYPE"].ToString(),
                            POSTALCODE = row["POSTALCODE"].ToString(),
                            TEL_NUMBER = row["TEL_NUMBER"].ToString(),
                            FAX_NUMBER = row["FAX_NUMBER"].ToString(),
                            UPDATE_USER = row["UPDATE_USER"].ToString(),
                            UPDATE_DATETIME = ClsStrVulue.convertToDateTime(row["UPDATE_DATETIME"]),
                            STATUS_LOG = row["STATUS_LOG"].ToString(),
                            USER_REQUEST = row["USER_REQUEST"].ToString(),
                            REMARK = row["REMARK"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("LOG_PERSON_ADDR", conn_sql, paramList, itemList))
                        Console.WriteLine("LOG_PERSON_ADDR save data error!!");
                    else
                        Console.WriteLine("LOG_PERSON_ADDR insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region LOG_CUS_COMMENT
        public static void Import_LOG_CUS_COMMENT()
        {
            try
            {
                string str = @"select * from LOG_CUS_COMMENT";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<LOG_CUS_COMMENT>();
                var item = new LOG_CUS_COMMENT();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table LOG_CUS_COMMENT";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new LOG_CUS_COMMENT
                        {
                            RUN_NUM = ClsStrVulue.convertToDecimal(row["RUN_NUM"]),
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            CUSNO = ClsStrVulue.convertToDecimal(row["CUSNO"]),
                            C_COMMENT = row["C_COMMENT"].ToString(),
                            UPDATE_USER = row["UPDATE_USER"].ToString(),
                            UPDATE_DATETIME = ClsStrVulue.convertToDateTime(row["UPDATE_DATETIME"]),
                            STATUS_LOG = row["STATUS_LOG"].ToString(),
                            USER_REQUEST = row["USER_REQUEST"].ToString(),
                            REMARK = row["REMARK"].ToString(),
                            C_COMMENTDATE = ClsStrVulue.convertToDateTime(row["C_COMMENTDATE"]),
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("LOG_CUS_COMMENT", conn_sql, paramList, itemList))
                        Console.WriteLine("LOG_CUS_COMMENT save data error!!");
                    else
                        Console.WriteLine("LOG_CUS_COMMENT insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region CUS_COMMENT
        public static void Import_CUS_COMMENT()
        {
            try
            {
                string str = @"select * from CUS_COMMENT";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<CUS_COMMENT>();
                var item = new CUS_COMMENT();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table CUS_COMMENT";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new CUS_COMMENT
                        {
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            CUSNO = ClsStrVulue.convertToDecimal(row["CUSNO"]),
                            C_COMMENTDATE = ClsStrVulue.convertToDateTime(row["C_COMMENTDATE"]),
                            C_COMMENT = row["C_COMMENT"].ToString(),
                            CC_RECORDER = row["CC_RECORDER"].ToString(),
                            USER_UPDATE = row["USER_UPDATE"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("CUS_COMMENT", conn_sql, paramList, itemList))
                        Console.WriteLine("CUS_COMMENT save data error!!");
                    else
                        Console.WriteLine("CUS_COMMENT insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region LOG_CUS_GROUP
        public static void Import_LOG_CUS_GROUP()
        {
            try
            {
                string str = @"select * from LOG_CUS_GROUP";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<LOG_CUS_GROUP>();
                var item = new LOG_CUS_GROUP();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table LOG_CUS_GROUP";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new LOG_CUS_GROUP
                        {
                            RUN_NUM = ClsStrVulue.convertToDecimal(row["RUN_NUM"]),
                            GROUPNO = ClsStrVulue.convertToDecimal(row["GROUPNO"]),
                            GROUP_NAME = row["GROUP_NAME"].ToString(),
                            UPDATE_USER = row["UPDATE_USER"].ToString(),
                            UPDATE_DATETIME = ClsStrVulue.convertToDateTime(row["UPDATE_DATETIME"]),
                            STATUS_LOG = row["STATUS_LOG"].ToString(),
                            USER_REQUEST = row["USER_REQUEST"].ToString(),
                            REMARK = row["REMARK"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("LOG_CUS_GROUP", conn_sql, paramList, itemList))
                        Console.WriteLine("LOG_CUS_GROUP save data error!!");
                    else
                        Console.WriteLine("LOG_CUS_GROUP insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region CUS_GROUP
        public static void Import_CUS_GROUP()
        {
            try
            {
                string str = @"select * from CUS_GROUP";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<CUS_GROUP>();
                var item = new CUS_GROUP();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table CUS_GROUP";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new CUS_GROUP
                        {
                            GROUPNO = ClsStrVulue.convertToDecimal(row["GROUPNO"]),
                            GROUP_NAME = row["GROUP_NAME"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("CUS_GROUP", conn_sql, paramList, itemList))
                        Console.WriteLine("CUS_GROUP save data error!!");
                    else
                        Console.WriteLine("CUS_GROUP insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region CUS_GROUP_MEMBER
        public static void Import_CUS_GROUP_MEMBER()
        {
            try
            {
                string str = @"select * from CUS_GROUP_MEMBER";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<CUS_GROUP_MEMBER>();
                var item = new CUS_GROUP_MEMBER();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table CUS_GROUP_MEMBER";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new CUS_GROUP_MEMBER
                        {
                            GROUPNO = ClsStrVulue.convertToDecimal(row["GROUPNO"]),
                            CUSNO = ClsStrVulue.convertToDecimal(row["CUSNO"]),
                            FLG = row["FLG"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("CUS_GROUP_MEMBER", conn_sql, paramList, itemList))
                        Console.WriteLine("CUS_GROUP_MEMBER save data error!!");
                    else
                        Console.WriteLine("CUS_GROUP_MEMBER insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region LOG_RESIDENT
        public static void Import_LOG_RESIDENT()
        {
            try
            {
                string str = @"select * from LOG_RESIDENT";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<LOG_RESIDENT>();
                var item = new LOG_RESIDENT();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table LOG_RESIDENT";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new LOG_RESIDENT
                        {
                            RUN_NUM = ClsStrVulue.convertToDecimal(row["RUN_NUM"]),
                            RESNO = ClsStrVulue.convertToDecimal(row["RESNO"]),
                            STU_ID = row["STU_ID"].ToString(),
                            YEARENTRY = ClsStrVulue.convertToDecimal(row["YEARENTRY"]),
                            R_INITIAL = row["R_INITIAL"].ToString(),
                            FACID = row["FACID"].ToString(),
                            RES_TYPEID = ClsStrVulue.convertToDecimal(row["RES_TYPEID"]),
                            UPDATE_USER = row["UPDATE_USER"].ToString(),
                            UPDATE_DATETIME = ClsStrVulue.convertToDateTime(row["UPDATE_DATETIME"]),
                            STATUS_LOG = row["STATUS_LOG"].ToString(),
                            USER_REQUEST = row["USER_REQUEST"].ToString(),
                            REMARK = row["REMARK"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("LOG_RESIDENT", conn_sql, paramList, itemList))
                        Console.WriteLine("LOG_RESIDENT save data error!!");
                    else
                        Console.WriteLine("LOG_RESIDENT insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region RESIDENT
        public static void Import_RESIDENT()
        {
            try
            {
                string str = @"select * from RESIDENT";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<RESIDENT>();
                var item = new RESIDENT();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table RESIDENT";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new RESIDENT
                        {
                            RESNO = ClsStrVulue.convertToDecimal(row["RESNO"]),
                            STU_ID = row["STU_ID"].ToString(),
                            YEARENTRY = ClsStrVulue.convertToDecimal(row["YEARENTRY"]),
                            R_INITIAL = row["R_INITIAL"].ToString(),
                            FACID = ClsStrVulue.convertToDecimal(row["FACID"]),
                            RES_TYPEID = ClsStrVulue.convertToDecimal(row["RES_TYPEID"]),
                            RES_RECORDER = row["RES_RECORDER"].ToString(),
                            USER_UPDATE = row["USER_UPDATE"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("RESIDENT", conn_sql, paramList, itemList))
                        Console.WriteLine("RESIDENT save data error!!");
                    else
                        Console.WriteLine("RESIDENT insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region LOG_PERSON_WORKPLACE
        public static void Import_LOG_PERSON_WORKPLACE()
        {
            try
            {
                string str = @"select * from LOG_PERSON_WORKPLACE";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<LOG_PERSON_WORKPLACE>();
                var item = new LOG_PERSON_WORKPLACE();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table LOG_PERSON_WORKPLACE";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new LOG_PERSON_WORKPLACE
                        {
                            RUN_NUM = ClsStrVulue.convertToDecimal(row["RUN_NUM"]),
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            CUSNO = ClsStrVulue.convertToDecimal(row["CUSNO"]),
                            HOSNO = ClsStrVulue.convertToDecimal(row["HOSNO"]),
                            DEPTNO = row["DEPTNO"].ToString(),
                            C_POSITION = row["C_POSITION"].ToString(),
                            POSTALCODE = row["POSTALCODE"].ToString(),
                            TEL_NUMBER = row["TEL_NUMBER"].ToString(),
                            FAX_NUMBER = row["FAX_NUMBER"].ToString(),
                            UPDATE_USER = row["UPDATE_USER"].ToString(),
                            UPDATE_DATETIME = ClsStrVulue.convertToDateTime(row["UPDATE_DATETIME"]),
                            STATUS_LOG = row["STATUS_LOG"].ToString(),
                            USER_REQUEST = row["USER_REQUEST"].ToString(),
                            REMARK = row["REMARK"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("LOG_PERSON_WORKPLACE", conn_sql, paramList, itemList))
                        Console.WriteLine("LOG_PERSON_WORKPLACE save data error!!");
                    else
                        Console.WriteLine("LOG_PERSON_WORKPLACE insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region PERSON_WORKPLACE
        public static void Import_PERSON_WORKPLACE()
        {
            try
            {
                string str = @"select * from PERSON_WORKPLACE";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<PERSON_WORKPLACE>();
                var item = new PERSON_WORKPLACE();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table PERSON_WORKPLACE";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new PERSON_WORKPLACE
                        {
                            ID = ClsStrVulue.convertToDecimal(row["ID"]),
                            CUSNO = ClsStrVulue.convertToDecimal(row["CUSNO"]),
                            HOSNO = ClsStrVulue.convertToDecimal(row["HOSNO"]),
                            DEPTNO = row["DEPTNO"].ToString(),
                            C_POSITION = row["C_POSITION"].ToString(),
                            POSTALCODE = row["POSTALCODE"].ToString(),
                            TEL_NUMBER = row["TEL_NUMBER"].ToString(),
                            FAX_NUMBER = row["FAX_NUMBER"].ToString(),
                            WK_RECORDER = row["WK_RECORDER"].ToString(),
                            USER_UPDATE = row["USER_UPDATE"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("PERSON_WORKPLACE", conn_sql, paramList, itemList))
                        Console.WriteLine("PERSON_WORKPLACE save data error!!");
                    else
                        Console.WriteLine("PERSON_WORKPLACE insert complate!!");
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
