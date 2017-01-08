using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMELINE.Universal_Statics
{
    struct Constants
    {
        public struct DbConstant
        {
            public static String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Data\\DBTRAX_DATA.mdf;Integrated Security=True;Connect Timeout=30";
                //@"Server=DESKTOP-67H7TIE;Database=DBTRAXX;Trusted_Connection=Yes;";
        }
        
        public static string getStoreProcedureName(string spKey)
        {
            switch (spKey)
            {
                case "getMonthlyAttendance":
                    return "sp_MONTHLY_ATTENDANCE";
                case "getEmployeeListDepartmentWise":
                    return "sp_EMPLOYEE_DETAIL";
                case "getEmployeeDailyAttendanceReport":
                    return "sp_DAILY_ATTENDANCE_62";
                case "getEmployeeDailyAbsentReport":
                    return "sp_ABSENTLIST";
                case "getGradeTypeList":
                    return "sp_GetGradeType";
                case "getEmployeeListGradeWiser":
                    return "sp_EMPLIST_GRADEWISE";
                case "getLeaveRegisterDetail":
                    return "sp_LEAVELEDGER";
                case "getAnnualLeaveRegisterDetail":
                    return "sp_YEARLY_LEAVELEDGER";
                case "getTimeLogDailyDetail":
                    return "sp_DAILY_ATTENDANCE_LOG";
                case "getTimeLogMonthlyDetail":
                    return "sp_MONTHLY_ATTENDANCE_LOG";
                case "getGradeDetail":
                    return "sp_GETGRADEDETAIL";
                case "getHolidayDetail":
                    return "sp_GETHOLIDAYDETAIL";
                case "getLeaveDetail":
                    return "sp_GETLEAVEDETAIL";
                case "getBandDetail":
                    return "sp_GETNONHOLIDAY";
                case "getBranchDetail":
                    return "sp_GETBRANCHDETAIL";
                case "getTitleDetail":
                    return "sp_GETTITLES";
                default:
                    return "";
            }
        }

        public static string getTableOrViewName(string tableViewKey)
        {
            switch (tableViewKey)
            {
                case "getOpeningPaidLeave":
                    return "vew_OPENING_PAIDLEAVE";
                case "getUnPaidLeave":
                    return "vew_OPENING_UNPAIDLEAVE";
                case "getAuthEmpList":
                    return "vewAuthEmpList";
                case "getAuthEmpListAll":
                    return "vewAuthEmpListAll";
                case "getDayCount":
                    return "vewDAYCOUNT";
                case "getDepartmentList":
                    return "vewDEPARTMENT_LIST";
                case "getEmpDetail":
                    return "vewEMP_DETAIL";
                case "getEmpWorkHour":
                    return "vewEMP_WORKHOUR";
                case "getEmpWorkHourDatise":
                    return "vewEMP_WORKHOUR_DAYWISE";
                case "getEmpList":
                    return "vewEmpList";
                case "getEmpListAll":
                    return "vewEmpListAll";
                case "EmpListAllV7":
                    return "vewEMPLISTALL_V7";
                case "getEmpNames":
                    return "vewEMPNAMES";
                case "getExpiryLeave":
                    return "vewEXPIRY_LEAVE";
                case "getSalaryPaid":
                    return "vewSALARYPAID";
                default:
                    return "";
            }
        }

    }

}
