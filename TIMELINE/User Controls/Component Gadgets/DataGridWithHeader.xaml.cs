using System;
using System.Collections.Generic;
using System.Data;
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
using TIMELINE.Manager.Database;
using TIMELINE.Manager.Report;

namespace TIMELINE.User_Controls.Component_Gadgets
{
    /// <summary>
    /// Interaction logic for DataGridWithHeader.xaml
    /// </summary>
    public partial class DataGridWithHeader : UserControl
    {
        public DataGridWithHeader()
        {
            InitializeComponent();
        }
        private ScrollViewer sv;

        private void LayoutUpdated(object sender, EventArgs e)
        {
            double offset = 0;
            GetScrollViewer(dataGridMonthlyAttendance);
            if (sv != null && sv.ComputedHorizontalScrollBarVisibility == Visibility.Visible)
            {
                offset = sv.ContentHorizontalOffset;
            }

            double w = c1.ActualWidth + c2.ActualWidth ;
            double cW = w;
            Label1.Width = cW;
            w = w - offset;
            double w2 = c3.ActualWidth + c4.ActualWidth + c5.ActualWidth + c6.ActualWidth;
            w = w + w2; 
            Label2.Width =  w < 0 ? 0 : (w > w2 ? w2:w);

            double w3 = c7.ActualWidth + c8.ActualWidth + c9.ActualWidth + c10.ActualWidth;
            w = w + w3;
            Label3.Width =  w < 0 ? 0 : (w > w3 ? w3 : w);

            double w4 = c11.ActualWidth;//+ c4.ActualWidth + c5.ActualWidth + c6.ActualWidth;
            w = w + w4;
            Label4.Width =  w < 0 ? 0 : (w > w4 ? w4 : w);

            double w5 = c12.ActualWidth + c13.ActualWidth + c14.ActualWidth;// + c6.ActualWidth;
            w = w + w5;
            Label5.Width =  w < 0 ? 0 : (w > w5 ? w5 : w);

            double w6 = c15.ActualWidth + c16.ActualWidth + c17.ActualWidth;// + c6.ActualWidth;
            w = w + w6;
            Label6.Width =  w < 0 ? 0 : (w > w6 ? w6 : w);

            double w7 = c18.ActualWidth;// + c4.ActualWidth + c5.ActualWidth + c6.ActualWidth;
            w = w + w7;
            Label7.Width =  w < 0 ? 0 : (w > w7 ? w7 : w);

            double w8 = c19.ActualWidth;// + c4.ActualWidth + c5.ActualWidth + c6.ActualWidth;
            w = w + w8;
            Label8.Width = w < 0 ? 0 : (w > w8 ? w8 : w);

            double w9 = c20.ActualWidth + c21.ActualWidth + c22.ActualWidth;// + c6.ActualWidth;
            w = w + w9;
            Label9.Width = w < 0 ? 0 : (w > w9 ? w9 : w);
        }

        private void GetScrollViewer(DependencyObject obj)
        {
           
            if (sv != null)
            {
                return;
            }

            var tmp = obj as ScrollViewer;
            if (tmp != null)
            {
                if (tmp.Name.Equals("DG_ScrollViewer"))
                {
                    sv = tmp;
                }
                else
                {
                    // Recursive call for each visual child
                    for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
                    {
                        GetScrollViewer(VisualTreeHelper.GetChild(obj, i));
                    }
                }
            }
            else
            {
                // Recursive call for each visual child
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
                {
                    GetScrollViewer(VisualTreeHelper.GetChild(obj, i));
                }
            }
        }

        public void DataLoad()
        {
            MonthlyAttendanceHelper maObj = new MonthlyAttendanceHelper();
            StoreProcedureHelper spObj = new StoreProcedureHelper();
            DataSet data = spObj.getMonthlyAttendance(Convert.ToDateTime("2016-1-1"), Convert.ToDateTime("2015-1-1"), int.Parse("5"));
           // this.dataGridMonthlyAttendance.Columns[0] = true;
          
            dataGridMonthlyAttendance.ItemsSource = maObj.getAllRecord(data);
        }
    }
}
