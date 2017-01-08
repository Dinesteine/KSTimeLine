using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMELINE.Model.Database.SqlViewModels
{
    class EmpListModel
    {
        public int empId { get; set; }
        public string empFullName { get; set; }
        public DateTime empDOB { get; set; }
        public string empPADD { get; set; }//PADD = permanent address
        public string empTADD { get; set; }//TADD = temprary adddress
        public string empPhone { get; set; }
        public string empPDistrict { get; set; }//premanent district
        public int empDegId { get; set; }
        public string empDegName { get; set; }
        public string empDeptName { get; set; }
        public int empDeptId { get; set; }
    }

}
