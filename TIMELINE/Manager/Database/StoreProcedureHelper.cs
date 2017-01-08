using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIMELINE.Universal_Statics;

namespace TIMELINE.Manager.Database
{
    class StoreProcedureHelper
    {
        public DataSet getMonthlyAttendance(DateTime toDate, DateTime fromDate, int eId)
        {
            Dictionary<string, object> dicData = SqlParameters.StoreProcedure.monthalyAttadance(toDate, fromDate, eId);
            return DataBaseHelper.StoreProcedure.getData(dicData, "getMonthlyAttendance");
        }

        public DataSet getEmployeeListDepartmentWise(int eid)
        {
            Dictionary<string, object> dictionary = SqlParameters.StoreProcedure.employeeListDepartmentWise(eid);
            return DataBaseHelper.StoreProcedure.getData(dictionary, "getEmployeeListDepartmentWise");

        }

        public DataSet getEmployeeDailyAttendanceReport(DateTime date, string departmentName)
        {
            Dictionary<string, object> dictionary = SqlParameters.StoreProcedure.EmployeeDailyAttendance(date, departmentName);
            return DataBaseHelper.StoreProcedure.getData(dictionary, "getEmployeeDailyAttendanceReport");
        }

        public DataSet getEmployeeDailyAbsentReport(DateTime date, string departmentname)
        {
            Dictionary<string, object> dictionary = SqlParameters.StoreProcedure.EmployeDailyAbsent(date, departmentname);
            return DataBaseHelper.StoreProcedure.getData(dictionary, "getEmployeeDailyAbsentReport");
        }

        public DataSet getEmployeeListGradeWiser(string gradetype)
        {
            Dictionary<string, object> dictionary = SqlParameters.StoreProcedure.EmployeeListGradeWise(gradetype);
            return DataBaseHelper.StoreProcedure.getData(dictionary, "getEmployeeListGradeWiser");
        }

        public DataSet getLeaveRegisterDetail(int selectedEmpId)
        {
            Dictionary<string, object> dictionary = SqlParameters.StoreProcedure.LeaveRegisterList(selectedEmpId);
            return DataBaseHelper.StoreProcedure.getData(dictionary, "getLeaveRegisterDetail");
        }
        public DataSet getAnnualLeaveRegisterDetail(int empId, int year, DateTime stdate, DateTime enddate)
        {
            Dictionary<string, object> dictionary = SqlParameters.StoreProcedure.AnnualLeaveRegisterList(empId, year, stdate, enddate);
            return DataBaseHelper.StoreProcedure.getData(dictionary, "getAnnualLeaveRegisterDetail");
        }
        public DataSet getTimeLogDailyDetail(DateTime selecteddate, string depname)
        {
            Dictionary<string, object> dictionary = SqlParameters.StoreProcedure.TimeLogDaily(selecteddate, depname);
            return DataBaseHelper.StoreProcedure.getData(dictionary, "getTimeLogDailyDetail");
        }
        public DataSet getTimeLogMonthlyDetail(DateTime givendate, DateTime enddate, int empId)
        {
            Dictionary<string, object> dictionary = SqlParameters.StoreProcedure.TimeLogmonthly(givendate, enddate, empId);
            return DataBaseHelper.StoreProcedure.getData(dictionary, "getTimeLogMonthlyDetail");
        }
        public DataSet getGradeTypeList()
        {
            Dictionary<string, object> dictionary = SqlParameters.StoreProcedure.GradeType();
            return DataBaseHelper.StoreProcedure.getData(dictionary, "getGradeTypeList");
        }
        public DataSet getBandhDetail()
        {
            Dictionary<string, object> dictionary = SqlParameters.StoreProcedure.Bandh();
            return DataBaseHelper.StoreProcedure.getData(dictionary, "getBandDetail");
        }
    }

}
