using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMELINE.Model.Report.EmployyeDailyAttendacnceReportModel
{
    class EmployyeDailyAttendacnceReportModel
    {
        public int EmpId { get; set; }
        public int WorkHourId { get; set; }
        public DateTime Tdate { get; set; }
        public DateTime Tdate_out { get; set; }
        public DateTime SignInTime { get; set; }

        public string SignInMode { get; set; }
        public string SignInRemark { get; set; }
        public DateTime OutTime { get; set; }
        public string OutMode { get; set; }
        public string OutRemark { get; set; }

        public DateTime LunchIn { get; set; }
        public string LunchInMode { get; set; }
        public string LunchInRemark { get; set; }
        public DateTime LunchOut { get; set; }
        public string LunchOutMode { get; set; }
        public string LunchOutRemark { get; set; }
        public DateTime TiffinIn { get; set; }
        public string TiffinInMode { get; set; }
        public string TiffinInRemark { get; set; }
        public DateTime TiffinOut { get; set; }
        public string TiffinOutMode { get; set; }
        public string TiffinOutRemark { get; set; }

        public string AttStatus { get; set; }
        public string Out_Vno { get; set; }
        public string Is_Halted { get; set; }
        public string FlgIn { get; set; }
        public string FlgOut { get; set; }
        public string Dtl_Out { get; set; }
        public string Dtl_In { get; set; }
        public string Dtt_In { get; set; }
        public string Dtt_Out { get; set; }
        public string emp_Fullname { get; set; }
        public int JobTime { get; set; }
        public byte IsLate { get; set; }
        public int InDiff { get; set; }
        public int OutDiff { get; set; }
        public int IsHata { get; set; }
        public int LunchTime { get; set; }
        public int TiffinTime { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentParent { get; set; }
        public int LunchOutTime { get; set; }
        public int ExlTime { get; set; }
        public int TOutTime { get; set; }
        public int ExtTime { get; set; }
    }

}
