using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIMELINE.Model.Report.Monthly_Attendance;

namespace TIMELINE.Manager.Report
{
    class MonthlyAttendanceHelper
    {
        //public List<EmpListModel> getEmpList()
        //{
        //    SqlViewHelper vh = new Helper.SqlViewHelper();
        //    DataSet data = vh.getEmpList();
        //    List<EmpListModel> listData = new List<EmpListModel>();
        //    foreach (DataRow dr in data.Tables[0].Rows)
        //    {
        //        EmpListModel empListObj = new EmpListModel();
        //        empListObj.empId = int.Parse(dr["EMP_ID"].ToString());
        //        empListObj.empFullName = dr["emp_Fullname"].ToString();
        //        empListObj.empDeptName = dr["DEPT_NAME"].ToString();

        //        listData.Add(empListObj);
        //    }

        //    return listData;
        //}

        public List<MonthlyAttendanceforGrid> getAllRecord(DataSet data)
        {
            List<MonthlyAttendanceforGrid> listData = new List<MonthlyAttendanceforGrid>();
            foreach (DataRow dr in data.Tables[0].Rows)
            {
                MonthlyAttendanceforGrid empListObj = new MonthlyAttendanceforGrid();
                empListObj.date = DateTime.Parse(dr["TDATE"].ToString()).Date.ToString();
                empListObj.workedHr = "NO DATA";// dr["------"].ToString();
                empListObj.signinTime = dr["INTIME"].ToString();
                empListObj.signinInDiff = dr["INDIFF"].ToString();
                empListObj.signinMode = dr["INMODE"].ToString();
                empListObj.signinRemarks = dr["INREMARKS"].ToString();
                empListObj.signoutTime = dr["OUTTIME"].ToString();
                empListObj.signoutOutDiff = dr["OUTDIFF"].ToString();
                empListObj.signoutMode = dr["OUTMODE"].ToString();
                empListObj.signoutRemarks = dr["OUTREMARKS"].ToString();
                empListObj.durationInOut = "REMIANING";// dr["--"].ToString();
                empListObj.launchoutTime = dr["LUNCHOUT"].ToString();
                empListObj.launchoutMode = dr["LUNCHOUTMODE"].ToString();
                empListObj.launchoutRemarks = dr["LUNCHOUTREMARKS"].ToString();
                empListObj.launchinTime = dr["LUNCHIN"].ToString();
                empListObj.launchinMode = dr["LUNCHINMODE"].ToString();
                empListObj.launchinRemarks = dr["LUNCHINREMARKS"].ToString();
                empListObj.durationLaunchOutLaunchIn = "R";// dr["--"].ToString();
                empListObj.launchTimeDiff = "R";//dr["emp_Fullname"].ToString();
                empListObj.durationPersonalOut = "R";// dr["emp_Fullname"].ToString();
                empListObj.durationExtraLT = dr["EXTTIME"].ToString();
                empListObj.durationOfficeOut = "REM";// dr["emp_Fullname"].ToString();

                listData.Add(empListObj);
            }
            return listData;
        }
    }

}
