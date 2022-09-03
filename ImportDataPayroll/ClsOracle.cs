using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Configuration;
using System.Reflection;
using System.Data.OracleClient;
using System;

namespace ImportDataPayroll
{
    public class ClsOracle
    {
        static OracleConnection conn = new OracleConnection();

        public static string Read_Conn()
        {
            string Str_Conn = "";

            Str_Conn = ConfigurationManager.AppSettings["ConnectionString_ORACLE"].ToString();
            return Str_Conn;
        }

        public static string Read_Conn_Hamsco()
        {
            string Str_Conn = "";

            Str_Conn = ConfigurationManager.AppSettings["ConnectionString_ORACLE_HAMSCO"].ToString();
            return Str_Conn;
        }


        public static OracleConnection connectDB(string ConnectionString)
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn = new OracleConnection(ConnectionString);

                conn.Open();
            }
            catch (Exception ex)
            {

            }

            return conn;
        }

        public static OracleConnection CloseDB(string ConnectionString)
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn = new OracleConnection(ConnectionString);

                conn.Close();
            }
            catch (Exception ex)
            {

            }

            return conn;
        }

        public static string GetOneValue(string StrSQL, string ConnectionString)
        {
            OracleConnection objCon = new OracleConnection();
            OracleCommand objCmd = new OracleCommand();
            OracleDataReader objDr;
            String StrS = "";

            try
            {
                objCon = connectDB(ConnectionString);
                objCmd = new OracleCommand(StrSQL, objCon);
                objDr = objCmd.ExecuteReader();

                if (objDr.Read())
                {
                    if (objDr[0] == null)
                        StrS = "";
                    else
                        StrS = objDr[0].ToString();

                    objCon.Close();
                    objCon.Dispose();
                }
            }
            catch (Exception ex)
            {
                StrS = "";
                objCon.Close();
                objCon.Dispose();
            }

            return StrS;
        }

        public static DataSet GetOnetable(string StrSQL, string ConnectionString)
        {
            OracleConnection objCon = new OracleConnection();
            OracleCommand objCmd = new OracleCommand();
            DataSet ds = new DataSet();
            int i = 0;
            OracleDataAdapter objda = new OracleDataAdapter();

            try
            {
                objCon = connectDB(ConnectionString);
                objCmd = new OracleCommand(StrSQL, objCon);
                objCmd.CommandTimeout = 10800;
                objda.SelectCommand = objCmd;

                objda.Fill(ds);

                objCon.Close();
                objCon.Dispose();
            }
            catch (Exception ex)
            {
                objCon.Close();
                objCon.Dispose();
            }

            return ds;
        }
    }
}
