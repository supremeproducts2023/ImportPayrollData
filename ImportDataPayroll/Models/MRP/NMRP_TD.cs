using System;                
using System.Collections.Generic;                
using System.Linq;                
using System.Text;                
using System.Threading.Tasks;                
                
namespace ImportDataPayroll.Models                
{
    class NMRP_TD
    {
        public Decimal? T_RUN { get; set; }
        public string T_NO { get; set; }
        public Decimal? QTY { get; set; }
        public string T_REMARKS { get; set; }
        public string F_NO { get; set; }
        public string REC_USER { get; set; }
        public DateTime? REC_DATE { get; set; }
        public string LAST_USER { get; set; }
        public DateTime? LAST_DATE { get; set; }
    }                
}