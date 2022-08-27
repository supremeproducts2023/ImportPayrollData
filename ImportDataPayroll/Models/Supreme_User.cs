using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImportDataPayroll.Models
{
    public class SUPREME_USER
    {
        public decimal? ID { get; set; }
        public string EMPNO { get; set; }
        public string SUP_USERNAME { get; set; }
        public string SUP_PASSWORD { get; set; }
        public string COMPUTERNAME { get; set; }
        public decimal? MNG_NO { get; set; }
        public decimal? USE_CK { get; set; }
    }
}
