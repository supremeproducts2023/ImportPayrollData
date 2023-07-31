using System;                
using System.Collections.Generic;                
using System.Linq;                
using System.Text;                
using System.Threading.Tasks;                
                
namespace ImportDataPayroll.Models                
{
    class PR_DETAILS
    {
        public string PR_NO { get; set; }
        public Decimal? ID { get; set; }
        public string PROD_NO { get; set; }
        public string PROD_NAME { get; set; }
        public Decimal? PROD_PRICE { get; set; }
        public string DISCOUNT_PERCENT { get; set; }
        public Decimal? DISCOUNT_BAHT { get; set; }
        public Decimal? PROD_QTY { get; set; }
        public string PROD_UNIT { get; set; }
        public string REC_USER { get; set; }
        public DateTime? REC_DATE { get; set; }
        public string LAST_USER { get; set; }
        public DateTime? LAST_DATE { get; set; }
        public string SUBJOB_NO { get; set; }
        public string CODE { get; set; }
    }                
}