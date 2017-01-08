using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TIMELINE.Enum;
using TIMELINE.User_Controls.Component_Gadgets;

namespace TIMELINE.User_Controls.Report
{
    /// <summary>
    /// Interaction logic for MonthalyAttendance.xaml
    /// </summary>
    public partial class MonthalyAttendance : UserControl
    {
        int userSelectedId = -1;
        public MonthalyAttendance()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            EmplySelection empObj = new EmplySelection();
            empObj.setCallBack = EmloyeSelectionButtonTapped;
            gridEmpSection.Children.Add(empObj);

            ActionButtons abObj = new ActionButtons();
            gridActionButton.Children.Add(abObj);

            TIMELINE.User_Controls.Component_Gadgets.DateTime dbObj = new TIMELINE.User_Controls.Component_Gadgets.DateTime();
            gridDaeTime.Children.Add(dbObj);

            DataGridWithHeader obj = new DataGridWithHeader();
            obj.DataLoad();
            gridBodyResult.Children.Add(obj);
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        
        private void loadData()
        {

        }

        //emply selection call back
        public void EmloyeSelectionButtonTapped(int value)
        {
            userSelectedId = value;
        }

        //button action
        public void buttonTappedAction(ActionFired value)
        {
            switch (value)
            {
                case ActionFired.Edit:
                    break;
                case ActionFired.Load:
                    loadData();
                    break;
                case ActionFired.New:
                    break;
                case ActionFired.None:
                    break;
                case ActionFired.Preview:
                    break;
                case ActionFired.Print:
                    break;
                case ActionFired.Save:
                    break;
                case ActionFired.Settings:
                    break;
                case ActionFired.Undo:
                    break;
                default:
                    break;
            }
        }
   
    }
}
