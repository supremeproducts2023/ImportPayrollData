using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PAY_HISTORYPOSITION
    {
        public decimal HISTORYPOSITION_ID { get; set; }
        public string EMPNO { get; set; }
        public decimal? NEWPOSITION_ID { get; set; }
        public string ADJUSTPOS_DATE { get; set; }
        public string POSITION_FLG { get; set; }
        public string COMMAND_NO { get; set; }
        public string ENTRYUSER { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string UPDATEUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
        public string FILEPATH { get; set; }
        public string REMARK_UPDATE { get; set; }
        public decimal? OLDPOSITION_ID { get; set; }
        public string COM_ID { get; set; }

    }
}
