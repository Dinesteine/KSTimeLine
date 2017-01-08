using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIMELINE.Manager.Database;
using TIMELINE.Model.Database.SqlViewModels;

namespace TIMELINE.Manager
{
    class EmployeeListManager
    {
        public List<EmpListModel> getEmpList()
        {
            SqlViewHelper vh = new SqlViewHelper();
            DataSet data = vh.getEmpList();
            List<EmpListModel> listData = new List<EmpListModel>();
            foreach (DataRow dr in data.Tables[0].Rows)
            {
                EmpListModel empListObj = new EmpListModel();
                empListObj.empId = int.Parse(dr["EMP_ID"].ToString());
                empListObj.empFullName = dr["emp_Fullname"].ToString();
                empListObj.empDeptName = dr["DEPT_NAME"].ToString();

                listData.Add(empListObj);
            }

            return listData;
        }

    }
}
