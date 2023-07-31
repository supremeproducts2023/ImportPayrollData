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
    public class NGAR_Module
    {
        static string conn_sql = ConfigurationManager.AppSettings["ConnectionString_SQLSERVER"].ToString();

        #region NGAR_PROD_DETAIL
        public static void Import_NGAR_PROD_DETAIL()
        {
            try
            {
                string str = @"select * from NGAR_PROD_DETAIL";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NGAR_PROD_DETAIL>();
                var item = new NGAR_PROD_DETAIL();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NGAR_PROD_DETAIL";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NGAR_PROD_DETAIL
                        {
                            LOT_ID = ClsStrVulue.convertToDecimal(row["LOT_ID"]),
                            PROD_ID = ClsStrVulue.convertToDecimal(row["PROD_ID"]),
                            LOT_NO = row["LOT_NO"].ToString(),
                            SERIAL_NO = row["SERIAL_NO"].ToString(),
                            EXPIRE_DATE = row["EXPIRE_DATE"].ToString(),
                            STATUS_QC = row["STATUS_QC"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NGAR_PROD_DETAIL", conn_sql, paramList, itemList))
                        Console.WriteLine("NGAR_PROD_DETAIL save data error!!");
                    else
                        Console.WriteLine("NGAR_PROD_DETAIL insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NBOM_DESCRIPTION
        public static void Import_NBOM_DESCRIPTION()
        {
            try
            {
                string str = @"select * from NBOM_DESCRIPTION";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NBOM_DESCRIPTION>();
                var item = new NBOM_DESCRIPTION();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NBOM_DESCRIPTION";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NBOM_DESCRIPTION
                        {
                            BOM_CODE = ClsStrVulue.convertToDecimal(row["BOM_CODE"]),
                            BOM_CODESHOW = row["BOM_CODESHOW"].ToString(),
                            BOM_DESC = row["BOM_DESC"].ToString(),
                            BOM_DESC2 = row["BOM_DESC2"].ToString(),
                            BOM_COST = ClsStrVulue.convertToDecimal(row["BOM_COST"]),
                            BOM_UNIT = row["BOM_UNIT"].ToString(),
                            BOM_TYPE = ClsStrVulue.convertToDecimal(row["BOM_TYPE"]),
                            STD_FLAG = ClsStrVulue.convertToDecimal(row["STD_FLAG"]),
                            MATERIAL = row["MATERIAL"].ToString(),
                            FINISHSURFACE = row["FINISHSURFACE"].ToString(),
                            SUPPLIER = row["SUPPLIER"].ToString(),
                            REVISE = row["REVISE"].ToString(),
                            PICTURE_PATH = row["PICTURE_PATH"].ToString(),
                            REMARKS = row["REMARKS"].ToString(),
                            PRODNO = ClsStrVulue.convertToDecimal(row["PRODNO"]),
                            COMP_ID = ClsStrVulue.convertToDecimal(row["COMP_ID"]),
                            USED_FLAG = row["USED_FLAG"].ToString(),
                            REC_USER = row["REC_USER"].ToString(),
                            REC_DATE = ClsStrVulue.convertToDateTime(row["REC_DATE"]),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = ClsStrVulue.convertToDateTime(row["LAST_DATE"]),
                            SENT_TO_SAP = row["SENT_TO_SAP"].ToString(),
                            SENT_TO_DATE = ClsStrVulue.convertToDateTime(row["SENT_TO_DATE"]),
                            PK_SAP = row["PK_SAP"].ToString(),
                            PART_NO = row["PART_NO"].ToString(),
                            DRAWING_NO = row["DRAWING_NO"].ToString(), 
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NBOM_DESCRIPTION", conn_sql, paramList, itemList))
                        Console.WriteLine("NBOM_DESCRIPTION save data error!!");
                    else
                        Console.WriteLine("NBOM_DESCRIPTION insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NGAR_REMARK
        public static void Import_NGAR_REMARK()
        {
            try
            {
                string str = @"select * from NGAR_REMARK";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NGAR_REMARK>();
                var item = new NGAR_REMARK();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NGAR_REMARK";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NGAR_REMARK
                        {
                            RMK_ID = ClsStrVulue.convertToDecimal(row["RMK_ID"]),
                            GAR_ID = ClsStrVulue.convertToDecimal(row["GAR_ID"]),
                            REMARK = row["REMARK"].ToString(),
                            REMARK_BY = row["REMARK_BY"].ToString(),
                            STATUS = row["STATUS"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            ACCEPTREMARK = row["ACCEPTREMARK"].ToString(),
                            LOG_ID = ClsStrVulue.convertToDecimal(row["LOG_ID"])
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NGAR_REMARK", conn_sql, paramList, itemList))
                        Console.WriteLine("NGAR_REMARK save data error!!");
                    else
                        Console.WriteLine("NGAR_REMARK insert complate!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region NGAR_ATTC
        public static void Import_NGAR_ATTC()
        {
            try
            {
                string str = @"select * from NGAR_ATTC";

                DataTable dt;
                dt = ClsOracle.GetOnetable(str, ClsOracle.Read_Conn()).Tables[0];

                var itemList = new List<NGAR_ATTC>();
                var item = new NGAR_ATTC();
                var paramList = ClsStrVulue.getParamList(item);

                if (dt.Rows.Count > 0)
                {
                    str = @"truncate table NGAR_ATTC";
                    ClsSQLServer.ExecuteQuery(str, conn_sql, null);

                    foreach (DataRow row in dt.Rows)
                    {
                        itemList.Add(new NGAR_ATTC
                        {
                            ATTC_ID = ClsStrVulue.convertToDecimal(row["ATTC_ID"]),
                            GAR_ID = ClsStrVulue.convertToDecimal(row["GAR_ID"]),
                            FILE_DESC = row["FILE_DESC"].ToString(),
                            FILE_PATH = row["FILE_PATH"].ToString(),
                            FILE_BY = row["FILE_BY"].ToString(),
                            REMARK = row["REMARK"].ToString(),
                            ENTRYUSER = row["ENTRYUSER"].ToString(),
                            ENTRYDATE = row["ENTRYDATE"].ToString(),
                            ENTRYTIME = row["ENTRYTIME"].ToString(),
                            UPDATEUSER = row["UPDATEUSER"].ToString(),
                            UPDATEDATE = row["UPDATEDATE"].ToString(),
                            UPDATETIME = row["UPDATETIME"].ToString()
                        });
                    }

                    if (!ClsSQLServer.BulkCopy("NGAR_ATTC", conn_sql, paramList, itemList))
                        Console.WriteLine("NGAR_ATTC save data error!!");
                    else
                        Console.WriteLine("NGAR_ATTC insert complate!!");
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
