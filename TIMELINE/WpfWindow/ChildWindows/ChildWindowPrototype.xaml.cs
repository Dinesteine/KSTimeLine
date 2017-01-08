using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TIMELINE.Enum;
using TIMELINE.User_Controls.Master_Settings;
using TIMELINE.User_Controls.Report;

namespace TIMELINE.WpfWindow.ChildWindows
{
    /// <summary>
    /// Interaction logic for ChildWindowPrototype.xaml
    /// </summary>
    public partial class ChildWindowPrototype : Window
    {
        TIMELINE.WpfWindow.Home_Menu.Menu _parentWindow;
       
        public ChildWindowPrototype(TIMELINE.WpfWindow.Home_Menu.Menu mainWindow, SelectedMenuItem openWindow)
        {
            InitializeComponent();
            _parentWindow = mainWindow;
            setupWindow(openWindow);
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void setupWindow(SelectedMenuItem selectedUserInterFace)
        {
            switch (selectedUserInterFace)
            {
                case SelectedMenuItem.report_MonthalyAttendance:
                    bodyGrid.Children.Add(new MonthalyAttendance());
                    break;
                case SelectedMenuItem.MS_Bandh:
                    bodyGrid.Children.Add(new Bandh());
                    break;
                default:
                    break;
            }
        }


    }
}
