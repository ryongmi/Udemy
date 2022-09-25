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
    /// all_ctls.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class all_ctls : Window
    {
        public all_ctls()
        {
            InitializeComponent();
        }

        private void btn_check_box_Click(object sender, RoutedEventArgs e)
        {
            checkbox wi = new checkbox();
            wi.Show();
        }

        private void btn_border_Click(object sender, RoutedEventArgs e)
        {
            border wi = new border();
            wi.Show();
        }

        private void btn_group_box_Click(object sender, RoutedEventArgs e)
        {
            groupbox wi = new groupbox();
            wi.Show();
        }

        private void btn_password_box_Click(object sender, RoutedEventArgs e)
        {
            passwordbox wi = new passwordbox();
            wi.Show();
        }

        private void btn_progress_bar_Click(object sender, RoutedEventArgs e)
        {
            progressBar wi = new progressBar();
            wi.Show();
        }

        private void btn_slider_Click(object sender, RoutedEventArgs e)
        {
            slider wi = new slider();
            wi.Show();
        }
    }
}
