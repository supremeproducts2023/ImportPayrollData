using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class REQUISITION_TIME_PROCESS
    {
        public Decimal? ID { get; set; }
        public Decimal? REQNO { get; set; }
        public DateTime? ORDER_POST_TIME_IN { get; set; }
        public DateTime? ORDER_POST_TIME_OUT { get; set; }
        public DateTime? ORDER_RECORD_IN { get; set; }
        public DateTime? ORDER_RECORD_OUT { get; set; }
        public DateTime? STOCK_CONTROL_IN { get; set; }
        public DateTime? STOCK_CONTROL_OUT { get; set; }
        public DateTime? CREDIT_CONTROL1_IN { get; set; }
        public DateTime? CREDIT_CONTROL1_OUT { get; set; }
        public DateTime? IMPORT_IN { get; set; }
        public DateTime? IMPORT_OUT { get; set; }
        public DateTime? CREDIT_RECORD2_IN { get; set; }
        public DateTime? CREDIT_RECORD2_OUT { get; set; }
        public DateTime? STOCK_CONTROL2_IN { get; set; }
        public DateTime? STOCK_CONTROL2_OUT { get; set; }
        public DateTime? GODOWN_IN { get; set; }
        public DateTime? GODOWN_OUT { get; set; }
        public DateTime? GRAND_TOTAL { get; set; }
        public string REMARKS { get; set; }
        public DateTime? STOCK_MAIL_TO_GODOWN { get; set; }
        public DateTime? STOCK_CONTROL3_IN { get; set; }
        public DateTime? STOCK_CONTROL3_OUT { get; set; }
        public DateTime? CREDIT_CONTROL3_IN { get; set; }
        public DateTime? CREDIT_CONTROL3_OUT { get; set; }
        public DateTime? TS_IN { get; set; }
        public DateTime? TS_OUT { get; set; }
        public DateTime? GODOWN_TO_TS { get; set; }
    }
}
