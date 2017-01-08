using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMELINE.Model.Report.LeaveRegister
{
    class LeaveRegisterModel
    {
        public int empId { get; set; }
        public int leaveId { get; set; }
        public int given { get; set; }
        public int taken { get; set; }
        public DateTime leave_Date { get; set; }
        public string remarks { get; set; }
        public int approvedBy { get; set; }
        public byte isRegular { get; set; }
        public int adjusted { get; set; }
        public int noHours { get; set; }
        public string leaveName { get; set; }
    }

}
