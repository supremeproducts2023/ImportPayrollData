using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PAY_OFFER_PERSONALTAX
    {
        public decimal? PERSON_TAXID { get; set; }
        public decimal? COST_RANGE1 { get; set; }
        public decimal? COST_RANGE2 { get; set; }
        public decimal? GETTAX { get; set; }
        public decimal? QTY_MONTH { get; set; }
        public string ENTRYUSER { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string UPDATEUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
        public decimal? COM_ID { get; set; }
        public string FLG_USE { get; set; }

    }
}

