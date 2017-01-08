using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMELINE.Model.Report.LeaveRegister
{
    class AnnualLeaveRegisterModel
    {
        public int leaveId { get; set; }
        public string leaveName { get; set; }
        public DateTime leaveDate { get; set; }
        public string given { get; set; }//dont kno the datatype so
        public string taken { get; set; }//dont kno the datatype so
        public string remarks { get; set; }//dont kno the datatype so
        public string givenMonth { get; set; }//dont kno the datatype so
    }

}
