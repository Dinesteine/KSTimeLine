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
using TIMELINE.WpfWindow.ChildWindows;

namespace TIMELINE.WpfWindow.Home_Menu
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        ChildWindowPrototype obj;
        public Menu()
        {
            InitializeComponent();
        }


        #region File Menu Item Click Events
        //Start File Menu Item Click
        private void fileMenuSelect(object sender, RoutedEventArgs e)
        {

            switch ((sender as MenuItem).Tag.ToString())
            {
                case "0":

                    break;
                case "1":

                    break;
            }
        }
        //End File Menu Item Click
        #endregion

        private void masterSettingMenuSelect(object sender, RoutedEventArgs e)
        {
            switch ((sender as MenuItem).Tag.ToString())
            {
                case "0":
                    obj = new ChildWindowPrototype(this, SelectedMenuItem.MS_EmployeeDetail);
                    obj.Owner = this;
                    obj.Show();
                    break;
                case "1":
                    obj = new ChildWindowPrototype(this, SelectedMenuItem.MS_Bandh);
                    obj.Owner = this;
                    obj.Show();
                    //this.IsEnabled = true;
                    break;
                case "2":
                    obj = new ChildWindowPrototype(this, SelectedMenuItem.MS_Branch);
                    obj.Owner = this;
                    obj.Show();
                    break;
                case "3":
                  
                    break;
                case "4":
                    break;
                case "5":
                    obj = new ChildWindowPrototype(this, SelectedMenuItem.MS_Grade);
                    obj.Owner = this;
                    obj.Show();
                    break;
                case "6":
                    obj = new ChildWindowPrototype(this, SelectedMenuItem.MS_Holiday);
                    obj.Owner = this;
                    obj.Show();
                    break;
                case "7":
                    obj = new ChildWindowPrototype(this, SelectedMenuItem.MS_Leave);
                    obj.Owner = this;
                    obj.Show();
                    break;
            }
        }

        private void transactionMenuItemSelect(object sender, RoutedEventArgs e)
        {
            // App.
         //   var connectionString = ConfigurationManager.ConnectionStrings["CharityManagement"].ConnectionString;
        }

        private void leaveManagementSubMenuItemSelect(object sender, RoutedEventArgs e)
        {

        }

        private void reportMenuselect(object sender, RoutedEventArgs e)
        {
            MenuItem mItem = sender as MenuItem;
                switch (Convert.ToInt16(mItem.Tag.ToString()))
            {
                case 0:
                    obj = new ChildWindowPrototype(this,SelectedMenuItem.report_MonthalyAttendance);
                    obj.Owner = this;
                    obj.Show();
                    break;
                default:
                    break;
            }
        }

        private void LeaveReportSubMenuSelect(object sender, RoutedEventArgs e)
        {

        }

        private void hoursworkedSubMenuSelect(object sender, RoutedEventArgs e)
        {

        }

        private void timelogSubMenuSelect(object sender, RoutedEventArgs e)
        {

        }
    }
}
