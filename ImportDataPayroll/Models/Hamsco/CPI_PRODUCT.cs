using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class CPI_PRODUCT
    {
        public Decimal? REQNO { get; set; }
        public Decimal? ID_TOPIC { get; set; }
        public Decimal? ID_CHOICE { get; set; }
        public string REMARKS { get; set; }
        public string REC_USER { get; set; }
        public DateTime? REC_DATE { get; set; }
        public string LAST_USER { get; set; }
        public DateTime? LAST_DATE { get; set; }
    }
}
