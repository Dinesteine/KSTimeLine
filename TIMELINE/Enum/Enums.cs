using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMELINE.Enum
{
  public enum SelectEmployee
    {
        Next,
        Previous,
        None
    }

    public enum ActionFired
    {
        Load,
        Print,
        Preview,
        Undo,
        Edit,
        Save,
        New,
        Settings,
        None
    }


   public enum SelectedMenuItem
    {
        //Menu File
        File_CompnyInformation,
        File_LogoutAdmin,
        File_Exit,
        //Menu Master Settings
        MS_EmployeeDetail,
        MS_Bandh,
        MS_Branch,
        MS_Department,
        MS_Designation,
        MS_Grade,
        MS_Leave,
        MS_Holiday,
        MS_SigninModeSettings,
        MS_ChangeInternalDateTime,
        MS_UserManager,
        MS_CHangePassword,
        //menu report
        report_MonthalyAttendance

    }


}
