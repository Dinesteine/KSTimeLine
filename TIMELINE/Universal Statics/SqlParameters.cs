using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMELINE.Universal_Statics
{
    struct SqlParameters
    {
        public struct StoreProcedure
        {
            public static Dictionary<string, object> monthalyAttadance(DateTime toDate, DateTime fromDate, int empId)
            {
                Dictionary<string, object> dicValue = new Dictionary<string, object>();
                dicValue["ToDT"] = toDate;
                dicValue["FromDT"] = fromDate;
                dicValue["EID"] = empId;
               
                return dicValue;
            }


            public static Dictionary<string, object> employeeListDepartmentWise(int eid)
            {
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic["EID"] = eid;

                return dic;
            }
            public static Dictionary<string, object> EmployeeDailyAttendance(DateTime datetime, string departmentName)
            {
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic["DT"] = datetime;
                dic["DEPT"] = departmentName;
                return dic;
            }

            public static Dictionary<string, object> EmployeDailyAbsent(DateTime date, string departmentname)
            {
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic["CDATE"] = date;
                dic["DEPT"] = departmentname;
                return dic;
            }

            public static Dictionary<string, object> EmployeeListGradeWise(string gradetype)
            {
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic["GTYPE"] = gradetype;
                return dic;
            }
            public static Dictionary<string, object> LeaveRegisterList(int selectedEmpId)
            {
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic["EMPID"] = selectedEmpId;
                return dic;
            }

            public static Dictionary<string, object> AnnualLeaveRegisterList(int empId, int year, DateTime stdate, DateTime enddate)
            {
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic["EMPID"] = empId;
                dic["GYEAR"] = year;
                dic["TYEAR_START"] = stdate;
                dic["TYEAR_END"] = enddate;
                return dic;
            }
            public static Dictionary<string, object> TimeLogDaily(DateTime selecteddate, string depname)
            {
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic["DT"] = selecteddate;
                dic["DEPT"] = depname;
                return dic;
            }
            public static Dictionary<string, object> TimeLogmonthly(DateTime givendate, DateTime enddate, int empId)
            {
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic["DT1"] = givendate;
                dic["DT2"] = enddate;
                dic["EMPID"] = empId;
                return dic;
            }
            public static Dictionary<string, object> GradeType()
            {
                Dictionary<string, object> dic = new Dictionary<string, object>();
                return dic;
            }
            public static Dictionary<string, object> Bandh()
            {
                Dictionary<string, object> dic = new Dictionary<string, object>();
                return dic;
            }
        }


    }

}
