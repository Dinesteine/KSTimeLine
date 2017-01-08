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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TIMELINE.Enum;
using TIMELINE.Manager;

namespace TIMELINE.User_Controls.Component_Gadgets
{
    /// <summary>
    /// Interaction logic for EmplySelection.xaml
    /// </summary>
    /// 
   

    public partial class EmplySelection : UserControl
    {

        #region call back delegates
        public delegate void EmplySelectionCallBack(int value);
        public void DoWork(EmplySelectionCallBack callBackHit)
        {
            callBackHit(_value);
        }
        #endregion
        
        public int _value;
        public EmplySelectionCallBack setCallBack;
        
        public EmplySelection()
        {
            InitializeComponent();
            _value = -1;
        }
        private void comboBoxEmpName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
              txtBoxEmpId.Text = comboBoxEmpName.SelectedValue.ToString();
            _value = Convert.ToInt16(comboBoxEmpName.SelectedValue.ToString());
            DoWork(setCallBack);
        }
        private void btnPreNextTapped(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Tag.ToString() == "1")
            {
                //Next
                if (comboBoxEmpName.SelectedIndex < comboBoxEmpName.Items.Count - 1)
                {
                    comboBoxEmpName.SelectedIndex = comboBoxEmpName.SelectedIndex + 1;
                }
            }
            else
            {
                //Previous
                if (comboBoxEmpName.SelectedIndex > 1)
                {
                    comboBoxEmpName.SelectedIndex = comboBoxEmpName.SelectedIndex - 1;
                }
            }
        }
        public void loadData()
        {
            EmployeeListManager mAHelperObj = new EmployeeListManager();
            comboBoxEmpName.ItemsSource = mAHelperObj.getEmpList();
           // txtBoxYear.Text = DateTime.Now.Year.ToString();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            loadData();
        }
    }


}
