using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class REQ_COLLECT_BILL
    {
        public Decimal? REQNO { get; set; }

        public DateTime? BILLDATE { get; set; }

        public string BILLNO { get; set; }

        public Decimal? BILL_AMOUNT { get; set; }

        public string SALENAME { get; set; }

        public string PRODUCTNAME { get; set; }

        public Decimal? HOSNO { get; set; }

        public DateTime? DO_DATE { get; set; }

        public DateTime? DEP_BILL_DATE { get; set; }

        public DateTime? COLLECT_APPOINT { get; set; }

        public DateTime? COLLECT_CHEQUE { get; set; }

        public Decimal? CHEQUE_NO { get; set; }

        public DateTime? CHEQUE_DATE { get; set; }

        public string BANK_NAME { get; set; }

        public string BRANCH_NAME { get; set; }

        public Decimal? COLLECT_AMOUNT { get; set; }

        public string RECEIVE_NAME { get; set; }

        public string REMARKS { get; set; }

        public string RECUSER_ID { get; set; }

        public DateTime? REC_DATE { get; set; }

        public string LASTUSER_ID { get; set; }

        public DateTime? LAST_DATE { get; set; }
    }
}
