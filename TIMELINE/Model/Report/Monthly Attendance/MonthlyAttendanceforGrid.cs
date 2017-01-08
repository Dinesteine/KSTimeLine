using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMELINE.Model.Report.Monthly_Attendance
{
    class MonthlyAttendanceforGrid
    {
        public string date { get; set; }
        public string workedHr { get; set; }
        public string signinTime { get; set; }
        public string signinInDiff { get; set; }
        public string signinMode { get; set; }
        public string signinRemarks { get; set; }

        public string signoutTime { get; set; }
        public string signoutOutDiff { get; set; }
        public string signoutMode { get; set; }
        public string signoutRemarks { get; set; }
        public string durationInOut { get; set; }
        public string launchoutTime { get; set; }
        public string launchoutMode { get; set; }
        public string launchoutRemarks { get; set; }
        public string launchinTime { get; set; }
        public string launchinMode { get; set; }
        public string launchinRemarks { get; set; }

        public string durationLaunchOutLaunchIn { get; set; }
        public string launchTimeDiff { get; set; }
        public string durationPersonalOut { get; set; }
        public string durationExtraLT { get; set; }
        public string durationOfficeOut { get; set; }
    }

}
