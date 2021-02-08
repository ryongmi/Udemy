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

namespace _2nd_control._2nd_ctls
{
    /// <summary>
    /// checkbox.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class checkbox : Window
    {
        public checkbox()
        {
            InitializeComponent();
        }

        private void chekbox_normal_Checked(object sender, RoutedEventArgs e)
        // 체크박스를 체크하면 발생하는 이벤트
        {
            //btn_show.IsEnabled = true;
            btn_show.IsEnabled = chekbox_normal.IsChecked.Value;
        }

        private void chekbox_normal_Unchecked(object sender, RoutedEventArgs e)
        // 체크박스를 체크해제하면 발생하는 이벤트
        {
            //btn_show.IsEnabled = false;
            btn_show.IsEnabled = chekbox_normal.IsChecked.Value;
        }

        private void mainwindow_Loaded(object sender, RoutedEventArgs e)
        {
            btn_show.IsEnabled = chekbox_normal.IsChecked.Value;
        }
    }
}
