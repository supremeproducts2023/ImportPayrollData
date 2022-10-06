using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class REQUISITION
    {
        public Decimal? REQNO { get; set; }
        public Decimal? HOSNO { get; set; }
        public Decimal? CUSNO { get; set; }
        public string ORDERBY { get; set; }
        public string SENDTO { get; set; }
        public string QUOTNO { get; set; }
        public string S_DEPTNO { get; set; }
        public DateTime? REQDATE { get; set; }
        public Decimal? GRANDTOTAL1 { get; set; }
        public Decimal? GRANDTOTAL2 { get; set; }
        public string ENDUSER { get; set; }
        public string EVALUATOR { get; set; }
        public string DECISIONMAKER { get; set; }
        public Decimal? CREDITTERM { get; set; }
        public Decimal? PAYMENT_ID { get; set; }
        public string PAYMENT_APPROVAL { get; set; }
        public string REQ_STATUS { get; set; }
        public string ERGENT_REQ { get; set; }
        public Decimal? REQ_TYPE { get; set; }
        public string REQ_APPROVE { get; set; }
        public string ORDER_POST_REC { get; set; }
        public string ORDER_REC { get; set; }
        public string STOCK1_REC { get; set; }
        public string CREDIT1_REC { get; set; }
        public string IMPORT { get; set; }
        public string CREDIT2_REC { get; set; }
        public string STOCK2_REC { get; set; }
        public string GODOWN_REC { get; set; }
        public string CONTRACTNO { get; set; }
        public string PONO { get; set; }
        public Decimal? DISCOUNT { get; set; }
        public Decimal? ESP_PERCENTAGE { get; set; }
        public DateTime? UPDATE_TIME_STAMP { get; set; }
        public string REQ_UPDATE_BY { get; set; }
        public string EMPNO { get; set; }
        public Decimal? REF_MAIN { get; set; }
        public Decimal? REQ_VAC { get; set; }
        public string CREDIT_NOTE { get; set; }
        public Decimal? DELIVER_AT { get; set; }
        public DateTime? CONTACTNO_DATE { get; set; }
        public DateTime? PONO_DATE { get; set; }
        public DateTime? DELIVERY_DATE { get; set; }
        public DateTime? MS_RECEIVEDATE { get; set; }
        public string REQ_RECORD { get; set; }
        public string BILL_SUB { get; set; }
        public Decimal? REQ_PROD { get; set; }
        public DateTime? RECORD_DATE { get; set; }
        public DateTime? LASTUP_DATE { get; set; }
        public string LASTUP_RECORD { get; set; }
        public Decimal? JOB_NO { get; set; }
        public string DEPTNO { get; set; }
        public Decimal? SPARE { get; set; }
        public Decimal? SERVICE { get; set; }
        public Decimal? CHECK_ROUND { get; set; }
        public string FORMAT_BILL { get; set; }
        public Decimal? VAC_BILL { get; set; }
        public Decimal? VAC_PREQ { get; set; }
        public DateTime? GODOWN_DATE { get; set; }
        public string ID_LOGSHEET { get; set; }
        public string REF_GARNO { get; set; }
        public string REF_INVOICE { get; set; }
        public string REF_BILLNO { get; set; }
        public string STOCK_PRINT { get; set; }
        public DateTime? STOCK_PRINT_DATE { get; set; }
        public Decimal? MS_PRINT { get; set; }
        public Decimal? REQ_RETURN { get; set; }
        public string REQ_ATTN { get; set; }
        public DateTime? DOC_DATE { get; set; }
        public Decimal? CONTRACT_ID { get; set; }
        public Decimal? STATUS_CONTRACT { get; set; }
        public Decimal? IN_WARRANTY { get; set; }
        public string RE_WARRANTY { get; set; }
        public Decimal? YEAR_WARRANTY { get; set; }
        public string FORMAT_BILLSTK { get; set; }
        public string SENT_TO_SAP { get; set; }
        public DateTime? SENT_TO_DATE { get; set; }
        public string TEL_SENDTO { get; set; }
        public DateTime? NEED_DELI_DATE { get; set; }
    }
}
