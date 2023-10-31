using System;                
using System.Collections.Generic;                
using System.Linq;                
using System.Text;                
using System.Threading.Tasks;                
                
namespace ImportDataPayroll.Models                
{
    class NMRP_LOCATION
    {
        public Decimal? LOCATION_ID { get; set; }
        public string LOCATION_NAME { get; set; }
        public string REC_USER { get; set; }
        public DateTime? REC_DATE { get; set; }
        public string LAST_USER { get; set; }
        public DateTime? LAST_DATE { get; set; }
    }                
}