using System;                
using System.Collections.Generic;                
using System.Linq;                
using System.Text;                
using System.Threading.Tasks;                
                
namespace ImportDataPayroll.Models                
{
    class NMRP_LOBOR_HOUR
    {
        public Decimal? ID { get; set; }
        public string EMPNO { get; set; }
        public DateTime? DATE_WORK { get; set; }
        public string JOBNO { get; set; }
        public Decimal? LOBOR_HOUR { get; set; }
        public string REMARK { get; set; }
        public DateTime? LAST_UP { get; set; }
    }                
}