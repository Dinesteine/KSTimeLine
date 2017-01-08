using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMELINE.Model.Report.Employee_list_gradewise_data_model
{
    class Employee_list_gradewise_data_model
    {
        public int pId { get; set; }
        public int empId { get; set; }
        public string empFullName { get; set; }
        public DateTime DOB { get; set; }
        public DateTime joinDate { get; set; }
        public string Deg_Name { get; set; }
        public string Dept_parent { get; set; }
        public string deptName { get; set; }
        public string gradeName { get; set; }
        public int BSalary { get; set; }
        public int Amnt { get; set; }
    }
}

