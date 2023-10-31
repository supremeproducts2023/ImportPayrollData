using System;                
using System.Collections.Generic;                
using System.Linq;                
using System.Text;                
using System.Threading.Tasks;                
                
namespace ImportDataPayroll.Models                
{                
    class NMRP_BD
    {
        public Decimal? B_RUN { get; set; }
        public string B_NO { get; set; }
        public Decimal? QTY { get; set; }
        public string B_REMARKS { get; set; }
        public Decimal? BOM_CODE { get; set; }
        public string REC_USER { get; set; }
        public DateTime? REC_DATE { get; set; }
        public string LAST_USER { get; set; }
        public DateTime? LAST_DATE { get; set; }       
    }                
}