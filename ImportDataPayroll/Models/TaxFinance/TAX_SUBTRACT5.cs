using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class TAX_SUBTRACT5
    {
        public decimal ID { get; set; }
        public DateTime? TAX_DATE { get; set; }
        public string TAX_TYPE { get; set; }
        public decimal INCOME_TOTAL { get; set; }
        public decimal INCOME_TAX { get; set; }
        public string RECORD_BY { get; set; }
        public DateTime? RECORD_DATE { get; set; }
        public decimal TAX_RATE { get; set; }
        public decimal TID { get; set; }
        public string IDROW { get; set; }
        public DateTime? TAX_DATE2 { get; set; }
    }
}

