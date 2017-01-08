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
using TIMELINE.Manager.MasterSettings;

namespace TIMELINE.User_Controls.Master_Settings
{
    /// <summary>
    /// Interaction logic for Bandh.xaml
    /// </summary>
    public partial class Bandh : UserControl
    {
        Band_MasterSetting bandMasterSetting = new Band_MasterSetting();
        public Bandh()
        {
            InitializeComponent();
        }

        private void Bandh_Loaded(object sender, RoutedEventArgs e)
        {
            DataGrid_BandDetail.ItemsSource = bandMasterSetting.BandDetail();
        }
        private void Save_Band(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(TextBox_BandId.Text.ToString());
            string bandName = TextBox_BandName.Text.ToString();
            DateTime bandDate = Convert.ToDateTime(Datepicker_SelectedDate.SelectedDate.ToString());

            bandMasterSetting.AddBand(id, bandName, bandDate);
            //
            DataGrid_BandDetail.ItemsSource = bandMasterSetting.BandDetail();
        }
    }
}
