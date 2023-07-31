using System;                
using System.Collections.Generic;                
using System.Linq;                
using System.Text;                
using System.Threading.Tasks;                
                
namespace ImportDataPayroll.Models                
{
    class NGAR_ATTC
    {
        public Decimal? ATTC_ID { get; set; }
        public Decimal? GAR_ID { get; set; }
        public string FILE_DESC { get; set; }
        public string FILE_PATH { get; set; }
        public string FILE_BY { get; set; }
        public string REMARK { get; set; }
        public string ENTRYUSER { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string UPDATEUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
    }                
}