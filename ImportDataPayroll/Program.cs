using ImportDataPayroll.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
//using System.Threading.Tasks;

namespace ImportDataPayroll
{
    class Program
    {
       // static string conn_sql;

        static void Main(string[] args)
        {
            getMenu();

           // conn_sql = ConfigurationManager.AppSettings["ConnectionString_SQLSERVER"].ToString();

            Console.WriteLine();
            Console.WriteLine();

            inputMenu();

            Console.ReadKey();
            Console.WriteLine("Finish Program");
        }

        public static void getMenu()
        {
            Console.WriteLine("===================================================");
            Console.WriteLine("                       Table                      ");
            Console.WriteLine("===================================================");

            Console.WriteLine("ALL PAYROLL");
            Console.WriteLine("1 PAY_ADDRESS");
            Console.WriteLine("2 PAY_ADVANCE");
            Console.WriteLine("3 PAY_ADVANCE_CLEAR");
            Console.WriteLine("4 PAY_ADVANCE_HISTORY");
            Console.WriteLine("5 PAY_BONUS_HISTORY");
            Console.WriteLine("6 PAY_CARDINFO");
            Console.WriteLine("7 PAY_COMPANY_BANK");
            Console.WriteLine("8 PAY_COURSE");
            Console.WriteLine("9 PAY_DAILY");
            Console.WriteLine("10 PAY_DECREASE");
            Console.WriteLine("11 PAY_DECREASE_YEAR");
            Console.WriteLine("12 PAY_DECREASETAX");
            Console.WriteLine("13 PAY_DEPT");
            Console.WriteLine("14 PAY_EMPY");
            Console.WriteLine("15 PAY_EMP_COURSE");
            Console.WriteLine("16 PAY_EMP_LOAN");
            Console.WriteLine("17 PAY_EMP_LOAN_TIME");
            Console.WriteLine("18 PAY_EMP_OFFER");
            Console.WriteLine("19 PAY_EMP_OT_TIME");
            Console.WriteLine("20 PAY_EMPEDU");
            Console.WriteLine("21 PAY_EXPORT_LOGS");
            Console.WriteLine("22 PAY_GROUP");
            Console.WriteLine("23 PAY_HISTORYPOSITION");
            Console.WriteLine("24 PAY_HISTORYSALARY");
            Console.WriteLine("25 PAY_INCDED");
            Console.WriteLine("26 PAY_INCDED_IMP");
            Console.WriteLine("27 PAY_INCDED_REG");
            Console.WriteLine("28 PAY_INCDED_TMP");
            Console.WriteLine("29 PAY_INCOME_DECERASE");
            Console.WriteLine("30 PAY_INCOMEXEMPT");
            Console.WriteLine("31 PAY_IP_ACCESS");
            Console.WriteLine("32 PAY_IP_USER_ALLOW");
            Console.WriteLine("33 PAY_JOB");
            Console.WriteLine("34 PAY_JOB_COST");
            Console.WriteLine("35 PAY_JOB_PERIOD");
            Console.WriteLine("36 PAY_LEAVEWP");
            Console.WriteLine("37 PAY_LOAN_DETAIL");
            Console.WriteLine("38 PAY_LOGALERT");
            Console.WriteLine("39 PAY_MTHINCDED");
            Console.WriteLine("40 PAY_OFFER_LABORLAW");
            Console.WriteLine("41 PAY_OFFER_OTHERCOST");
            Console.WriteLine("42 PAY_OFFER_PERSONALTAX");
            Console.WriteLine("43 PAY_OT");
            Console.WriteLine("44 PAY_PERMISSION");
            Console.WriteLine("45 PAY_POSITION");
            Console.WriteLine("46 PAY_PROVIDENTFUND");
            Console.WriteLine("47 PAY_PVDCOVER");
            Console.WriteLine("48 PAY_SETCOMPANY");
            Console.WriteLine("49 PAY_SETPVDCOVER");
            Console.WriteLine("50 PAY_SOCIALCOST");
            Console.WriteLine("51 PAY_TIME");
            Console.WriteLine("52 PAY_TIME_HOLIDAY");
            Console.WriteLine("53 PAY_TIME_RAW");
            Console.WriteLine("54 PAY_TRANSDEPT");
            Console.WriteLine("55 PAY_WORKINFO");
            Console.WriteLine("56 PAY_YRINCDED");
            Console.WriteLine("57 SUPREME_USER");
            Console.WriteLine("58 EMP");
            Console.WriteLine("59 DEPT");

            Console.WriteLine("");
            Console.WriteLine("ALL PETTYCASH");
            Console.WriteLine("60 PTY_CASH");
            Console.WriteLine("61 PTY_EXCELCONFIG");
            Console.WriteLine("62 PTY_HISWD");
            Console.WriteLine("63 PTY_PAYTYPE");
            Console.WriteLine("64 PTY_PERMISSION");
            Console.WriteLine("65 PTY_REFUND");
            Console.WriteLine("66 PTY_SUMCASH");
            Console.WriteLine("67 PTY_SUMWDRESERVE");
            Console.WriteLine("68 PTY_WDRESERVE");
            Console.WriteLine("69 PTY_WDRESERVE_DETAIL");
            Console.WriteLine("70 PTY_WITHDRAWALS_DAILY");

            Console.WriteLine("");
            Console.WriteLine("ALL FINANCE_BILL");
            Console.WriteLine("71 FINANCE_BILL_ACC");
            Console.WriteLine("72 FINANCE_BILL_M");
            Console.WriteLine("73 FINANCE_BILL_D");
            Console.WriteLine("74 FINANCE_BILL_PAY_M");
            Console.WriteLine("75 FINANCE_BILL_PAY_D");
            Console.WriteLine("76 FINANCE_BILL_VENDER");

            Console.WriteLine("");
            Console.WriteLine("ALL TAXFINANCE");
            Console.WriteLine("77 TAX_DETAIL5");
            Console.WriteLine("78 TAX_SUBTRACT5");
            Console.WriteLine("79 NGAR");
            Console.WriteLine("80 NGAR_TRACKING");
            Console.WriteLine("81 NGAR_PROD");
            Console.WriteLine("82 NGAR_STOCK_IN");
            Console.WriteLine("83 TAXFINANCE_PERMISSION");
        }

        public static void inputMenu()
        {
            Console.Write("Select Table : ");
            string mudule = Console.ReadLine();

            switch (mudule)
            {
                case "ALL PAYROLL":
                    Payroll.Import_PAY_ADDRESS();
                    Payroll.Import_PAY_ADVANCE();
                    Payroll.Import_PAY_ADVANCE_CLEAR();
                    Payroll.Import_PAY_ADVANCE_HISTORY();
                    Payroll.Import_PAY_BONUS_HISTORY();
                    Payroll.Import_PAY_CARDINFO();
                    Payroll.Import_PAY_COMPANY_BANK();
                    Payroll.Import_PAY_COURSE();
                    Payroll.Import_PAY_DAILY();
                    Payroll.Import_PAY_DECREASE();
                    Payroll.Import_PAY_DECREASE_YEAR();
                    Payroll.Import_PAY_DECREASETAX();
                    Payroll.Import_PAY_DEPT();
                    Payroll.Import_PAY_EMP();
                    Payroll.Import_PAY_EMP_COURSE();
                    Payroll.Import_PAY_EMP_LOAN();
                    Payroll.Import_PAY_EMP_LOAN_TIME();
                    Payroll.Import_PAY_EMP_OFFER();
                    Payroll.Import_PAY_EMP_OT_TIME();
                    Payroll.Import_PAY_EMPEDU();
                    Payroll.Import_PAY_EXPORT_LOGS();
                    Payroll.Import_PAY_GROUP();
                    Payroll.Import_PAY_HISTORYPOSITION();
                    Payroll.Import_PAY_HISTORYSALARY();
                    Payroll.Import_PAY_INCDED();
                    Payroll.Import_PAY_INCDED_IMP();
                    Payroll.Import_PAY_INCDED_REG();
                    Payroll.Import_PAY_INCDED_TMP();
                    Payroll.Import_PAY_INCOME_DECERASE();
                    Payroll.Import_PAY_INCOMEXEMPT();
                    Payroll.Import_PAY_IP_ACCESS();
                    Payroll.Import_PAY_IP_USER_ALLOW();
                    Payroll.Import_PAY_JOB();
                    Payroll.Import_PAY_JOB_COST();
                    Payroll.Import_PAY_JOB_PERIOD();
                    Payroll.Import_PAY_LEAVEWP();
                    Payroll.Import_PAY_LOAN_DETAIL();
                    Payroll.Import_PAY_LOGALERT();
                    Payroll.Import_PAY_MTHINCDED();
                    Payroll.Import_PAY_OFFER_LABORLAW();
                    Payroll.Import_PAY_OFFER_OTHERCOST();
                    Payroll.Import_PAY_OFFER_PERSONALTAX();
                    Payroll.Import_PAY_OT();
                    Payroll.Import_PAY_PERMISSION();
                    Payroll.Import_PAY_POSITION();
                    Payroll.Import_PAY_PROVIDENTFUND();
                    Payroll.Import_PAY_PVDCOVER();
                    Payroll.Import_PAY_SETPVDCOVER();
                    Payroll.Import_PAY_SETCOMPANY();
                    Payroll.Import_PAY_SOCIALCOST();
                    Payroll.Import_PAY_TIME();
                    Payroll.Import_PAY_TIME_HOLIDAY();
                    Payroll.Import_PAY_TIME_RAW();
                    Payroll.Import_PAY_TRANSDEPT();
                    Payroll.Import_PAY_WORKINFO();
                    Payroll.Import_PAY_YRINCDED();
                    Payroll.Import_SUPREME_USER();
                    Payroll.Import_EMP();
                    Payroll.Import_DEPT();
                    break;
                
                case "1": Payroll.Import_PAY_ADDRESS(); break;
                case "2": Payroll.Import_PAY_ADVANCE(); break;
                case "3": Payroll.Import_PAY_ADVANCE_CLEAR(); break;
                case "4": Payroll.Import_PAY_ADVANCE_HISTORY(); break;
                case "5": Payroll.Import_PAY_BONUS_HISTORY(); break;
                case "6": Payroll.Import_PAY_CARDINFO(); break;
                case "7": Payroll.Import_PAY_COMPANY_BANK(); break;
                case "8": Payroll.Import_PAY_COURSE(); break;
                case "9": Payroll.Import_PAY_DAILY(); break;
                case "10": Payroll.Import_PAY_DECREASE(); break;
                case "11": Payroll.Import_PAY_DECREASE_YEAR(); break;
                case "12": Payroll.Import_PAY_DECREASETAX(); break;
                case "13": Payroll.Import_PAY_DEPT(); break;
                case "14": Payroll.Import_PAY_EMP(); break;
                case "15": Payroll.Import_PAY_EMP_COURSE(); break;
                case "16": Payroll.Import_PAY_EMP_LOAN(); break;
                case "17": Payroll.Import_PAY_EMP_LOAN_TIME(); break;
                case "18": Payroll.Import_PAY_EMP_OFFER(); break;
                case "19": Payroll.Import_PAY_EMP_OT_TIME(); break;
                case "20": Payroll.Import_PAY_EMPEDU(); break;
                case "21": Payroll.Import_PAY_EXPORT_LOGS(); break;
                case "22": Payroll.Import_PAY_GROUP(); break;
                case "23": Payroll.Import_PAY_HISTORYPOSITION(); break;
                case "24": Payroll.Import_PAY_HISTORYSALARY(); break;
                case "25": Payroll.Import_PAY_INCDED(); break;
                case "26": Payroll.Import_PAY_INCDED_IMP(); break;
                case "27": Payroll.Import_PAY_INCDED_REG(); break;
                case "28": Payroll.Import_PAY_INCDED_TMP(); break;
                case "29": Payroll.Import_PAY_INCOME_DECERASE(); break;
                case "30": Payroll.Import_PAY_INCOMEXEMPT(); break;
                case "31": Payroll.Import_PAY_IP_ACCESS(); break;
                case "32": Payroll.Import_PAY_IP_USER_ALLOW(); break;
                case "33": Payroll.Import_PAY_JOB(); break;
                case "34": Payroll.Import_PAY_JOB_COST(); break;
                case "35": Payroll.Import_PAY_JOB_PERIOD(); break;
                case "36": Payroll.Import_PAY_LEAVEWP(); break;
                case "37": Payroll.Import_PAY_LOAN_DETAIL(); break;
                case "38": Payroll.Import_PAY_LOGALERT(); break;
                case "39": Payroll.Import_PAY_MTHINCDED(); break;
                case "40": Payroll.Import_PAY_OFFER_LABORLAW(); break;
                case "41": Payroll.Import_PAY_OFFER_OTHERCOST(); break;
                case "42": Payroll.Import_PAY_OFFER_PERSONALTAX(); break;
                case "43": Payroll.Import_PAY_OT(); break;
                case "44": Payroll.Import_PAY_PERMISSION(); break;
                case "45": Payroll.Import_PAY_POSITION(); break;
                case "46": Payroll.Import_PAY_PROVIDENTFUND(); break;
                case "47": Payroll.Import_PAY_PVDCOVER(); break;
                case "48": Payroll.Import_PAY_SETCOMPANY(); break;
                case "49": Payroll.Import_PAY_SETPVDCOVER(); break;
                case "50": Payroll.Import_PAY_SOCIALCOST(); break;
                case "51": Payroll.Import_PAY_TIME(); break;
                case "52": Payroll.Import_PAY_TIME_HOLIDAY(); break;
                case "53": Payroll.Import_PAY_TIME_RAW(); break;
                case "54": Payroll.Import_PAY_TRANSDEPT(); break;
                case "55": Payroll.Import_PAY_WORKINFO(); break;
                case "56": Payroll.Import_PAY_YRINCDED(); break;
                case "57": Payroll.Import_SUPREME_USER(); break;
                case "58": Payroll.Import_EMP(); break;
                case "59": Payroll.Import_DEPT(); break;

                case "ALL PETTYCASH":
                    PettyCash.Import_PTY_CASH();
                    PettyCash.Import_PTY_EXCELCONFIG();
                    PettyCash.Import_PTY_HISWD();
                    PettyCash.Import_PTY_PAYTYPE();
                    PettyCash.Import_PTY_PERMISSION();
                    PettyCash.Import_PTY_REFUND();
                    PettyCash.Import_PTY_SUMCASH();
                    PettyCash.Import_PTY_SUMWDRESERVE();
                    PettyCash.Import_PTY_WDRESERVE();
                    PettyCash.Import_PTY_WDRESERVE_DETAIL();
                    PettyCash.Import_PTY_WITHDRAWALS_DAILY();

                    break;

                case "60": PettyCash.Import_PTY_CASH(); break;
                case "61": PettyCash.Import_PTY_EXCELCONFIG(); break;
                case "62": PettyCash.Import_PTY_HISWD(); break;
                case "63": PettyCash.Import_PTY_PAYTYPE(); break;
                case "64": PettyCash.Import_PTY_PERMISSION(); break;
                case "65": PettyCash.Import_PTY_REFUND(); break;
                case "66": PettyCash.Import_PTY_SUMCASH(); break;
                case "67": PettyCash.Import_PTY_SUMWDRESERVE(); break;
                case "68": PettyCash.Import_PTY_WDRESERVE(); break;
                case "69": PettyCash.Import_PTY_WDRESERVE_DETAIL(); break;
                case "70": PettyCash.Import_PTY_WITHDRAWALS_DAILY(); break;


                case "ALL FINANCE_BILL":
                    FinanceBill.Import_FINANCE_BILL_ACC();
                    FinanceBill.Import_FINANCE_BILL_M();
                    FinanceBill.Import_FINANCE_BILL_D();
                    FinanceBill.Import_FINANCE_BILL_PAY_M();
                    FinanceBill.Import_FINANCE_BILL_PAY_D();
                    FinanceBill.Import_FINANCE_BILL_VENDER();
                    break;

                case "71": FinanceBill.Import_FINANCE_BILL_ACC(); break;
                case "72": FinanceBill.Import_FINANCE_BILL_M(); break;
                case "73": FinanceBill.Import_FINANCE_BILL_D(); break;
                case "74": FinanceBill.Import_FINANCE_BILL_PAY_M(); break;
                case "75": FinanceBill.Import_FINANCE_BILL_PAY_D(); break;
                case "76": FinanceBill.Import_FINANCE_BILL_VENDER(); break;


                case "ALL TAXFINANCE":
                    TaxFinance.Import_TAX_DETAIL5();
                    TaxFinance.Import_TAX_SUBTRACT5();
                    TaxFinance.Import_NGAR();
                    TaxFinance.Import_NGAR_TRACKING();
                    TaxFinance.Import_NGAR_PROD();
                    TaxFinance.Import_NGAR_STOCK_IN();
                    TaxFinance.Import_TAXFINANCE_PERMISSION();
                    break;

                case "77": TaxFinance.Import_TAX_DETAIL5(); break;
                case "78": TaxFinance.Import_TAX_SUBTRACT5(); break;
                case "79": TaxFinance.Import_NGAR(); break;
                case "80": TaxFinance.Import_NGAR_TRACKING(); break;
                case "81": TaxFinance.Import_NGAR_PROD(); break;
                case "82": TaxFinance.Import_NGAR_STOCK_IN(); break;
                case "83": TaxFinance.Import_TAXFINANCE_PERMISSION(); break;

                defaule:
                    break;
            }

            Console.WriteLine();

            inputMenu();
        }

       


        
    }
}
