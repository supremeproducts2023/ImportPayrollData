using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImportDataPayroll.Models
{
    public class Pay_address
    {
        public decimal ADD_ID { get; set; }
        public string EMPNO { get; set; }
        public string HOME_NO { get; set; }
        public string SOI_NO { get; set; }
        public string STREET_NO { get; set; }

        public string DISTRICT_NO { get; set; }
        public string AUMPHUR_NO { get; set; }
        public string PROVINCE_NO { get; set; }
        public string POSTALCODE { get; set; }
        public string TEL { get; set; }

        public string COUNTRY { get; set; }
        public decimal? ADD_STATUS { get; set; }
        public string MAP_PATH { get; set; }
        public string ENTRYUSER { get; set; }
        public string ENTRYDATE { get; set; }

        public string ENTRYTIME { get; set; }
        public string UPDATEUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
        public string TYPE_FLG { get; set; }

        public string COM_ID { get; set; }
    }
}
