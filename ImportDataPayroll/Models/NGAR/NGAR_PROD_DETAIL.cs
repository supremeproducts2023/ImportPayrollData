using System;                
using System.Collections.Generic;                
using System.Linq;                
using System.Text;                
using System.Threading.Tasks;                
                
namespace ImportDataPayroll.Models                
{
    class NGAR_PROD_DETAIL
    {
        public Decimal? LOT_ID { get; set; }
        public Decimal? PROD_ID { get; set; }
        public string LOT_NO { get; set; }
        public string SERIAL_NO { get; set; }
        public string EXPIRE_DATE { get; set; }
        public string STATUS_QC { get; set; }
        public string ENTRYUSER { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string UPDATEUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }

    }                
}