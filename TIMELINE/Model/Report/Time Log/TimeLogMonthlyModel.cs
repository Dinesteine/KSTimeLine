using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMELINE.Model.Report.Time_Log
{
    class TimeLogMonthlyModel
    {
        public int empId { get; set; }
        public DateTime tdate { get; set; }
        public string ttime { get; set; }//donot kno the datatype
        public string mode { get; set; }//donot kno the datatype
        public byte flag { get; set; }//donot kno the datatype
        public string timeval { get; set; }//donot kno the datatype
        public string deviceno { get; set; }//donot kno the datatype
        public string verifyResult { get; set; }//donot kno the datatype
        public string deviceIp { get; set; }//donot kno the datatype
        public string attMode { get; set; }//donot kno the datatype
        public string empFullname { get; set; }
        public string modeval { get; set; }//donot kno the datatype

    }

}
