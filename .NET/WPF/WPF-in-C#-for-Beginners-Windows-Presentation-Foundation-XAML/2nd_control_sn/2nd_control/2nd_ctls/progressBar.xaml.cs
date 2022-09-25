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
    /// progressBar.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class progressBar : Window
    {
        public progressBar()
        {
            InitializeComponent();
        }

        private void pgb_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbl.Content = ((int)pgb.Value).ToString()+"%";
        }

        private void incr_btn_Click(object sender, RoutedEventArgs e)
        {
            pgb.Value += 5;
        }

        private void desc_btn_Click(object sender, RoutedEventArgs e)
        {
            pgb.Value -= 5;
        }
    }
}
