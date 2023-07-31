using System;                
using System.Collections.Generic;                
using System.Linq;                
using System.Text;                
using System.Threading.Tasks;                
                
namespace ImportDataPayroll.Models                
{
    class NGAR_REMARK
    {
        public Decimal? RMK_ID { get; set; }
        public Decimal? GAR_ID { get; set; }
        public string REMARK { get; set; }
        public string REMARK_BY { get; set; }
        public string STATUS { get; set; }
        public string ENTRYUSER { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string ACCEPTREMARK { get; set; }
        public Decimal? LOG_ID { get; set; }
    }                
}