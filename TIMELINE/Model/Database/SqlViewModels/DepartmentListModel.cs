using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMELINE.Model.Database.SqlViewModels
{
    class DepartmentListModel
    {
        public int departmentId { get; set; }
        public string departmentName { get; set; }
        public int sectorId { get; set; }
        public string sectorName { get; set; }
    }
}
