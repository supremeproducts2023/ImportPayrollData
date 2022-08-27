using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PAY_EMP_OT_TIME
    {
        public decimal OT_TIME_ID { get; set; }
        public string EMPNO { get; set; }
        public decimal? OT_ID { get; set; }
        public string YEARLY { get; set; }
        public string MONTHLY { get; set; }
        public string DAILY { get; set; }
        public decimal? SALARY { get; set; }
        public decimal? PERHOUR { get; set; }
        public decimal? AMOUNT { get; set; }
        public string STATUS { get; set; }
        public string ENTRYUSER { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string UPDATEUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
        public string COM_ID { get; set; }
        public decimal? HOURS { get; set; }
        public string YEARLY_EFF { get; set; }
        public string MONTHLY_EFF { get; set; }
        public decimal? OT_GROUP_ID { get; set; }
        public decimal? INCDED_ID { get; set; }
    }
}
