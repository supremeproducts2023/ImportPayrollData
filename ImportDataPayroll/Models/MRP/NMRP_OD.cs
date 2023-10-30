using System;                
using System.Collections.Generic;                
using System.Linq;                
using System.Text;                
using System.Threading.Tasks;                
                
namespace ImportDataPayroll.Models                
{                
    class NMRP_OD
    {
        public Decimal? O_RUN { get; set; }
        public string JOBNO { get; set; }
        public Decimal? BOM_CODE { get; set; }
        public Decimal? PRODNO { get; set; }
        public string O_SPEC { get; set; }
        public Decimal? O_QTY { get; set; }
        public DateTime? O_SEND { get; set; }
        public Decimal? O_COST { get; set; }
        public string REC_USER { get; set; }
        public DateTime? REC_DATE { get; set; }
        public string LAST_USER { get; set; }
        public DateTime? LAST_DATE { get; set; }           
    }                
}