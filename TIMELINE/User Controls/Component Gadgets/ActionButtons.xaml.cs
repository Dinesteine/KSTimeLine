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

namespace TIMELINE.User_Controls.Component_Gadgets
{
    /// <summary>
    /// Interaction logic for ActionButtons.xaml
    /// </summary>
    public partial class ActionButtons : UserControl
    {
        #region call back delegates
        public delegate void ActionFiredCallBack(ActionFired value);
        public void DoWork(ActionFiredCallBack callBackHit)
        {
            callBackHit(_value);
        }
        #endregion

        public ActionFired _value;
        public ActionFiredCallBack setCallBack;
        public ActionButtons()
        {
            InitializeComponent();
            _value = ActionFired.None;
        }

        private void ActionButtonTapped_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            switch (Convert.ToInt16(btn.Tag.ToString()))
            {
                case 0:
                    _value = ActionFired.Load;
                    DoWork(setCallBack);
                    break;
                case 1:
                    _value = ActionFired.Preview;
                    DoWork(setCallBack);
                    break;
                case 2:
                    _value = ActionFired.Print;
                    DoWork(setCallBack);
                    break;
                case 3:
                    _value = ActionFired.Settings;
                    DoWork(setCallBack);
                    break;
                case 4:
                    _value = ActionFired.Undo;
                    DoWork(setCallBack);
                    break;
                default:
                    _value = ActionFired.None;
                    DoWork(setCallBack);
                    break;
            }
        }
    }
}
