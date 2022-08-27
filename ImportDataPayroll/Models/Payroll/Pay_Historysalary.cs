using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PAY_HISTORYSALARY
    {
        public decimal HISTORYSALARY_ID { get; set; }
        public string EMPNO { get; set; }
        public decimal? OLDSALARY { get; set; }
        public decimal? NEWSALARY { get; set; }
        public decimal? ADJUSTSALARY { get; set; }
        public string ADJUSTSAL_FLG { get; set; }
        public string ADJUSTSAL_DATE { get; set; }
        public string GRADE { get; set; }
        public string ENTRYUSER { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string UPDATEUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
        public string FILEPATH { get; set; }
        public string REMARK_UP { get; set; }
        public string COM_ID { get; set; }
    }
}
