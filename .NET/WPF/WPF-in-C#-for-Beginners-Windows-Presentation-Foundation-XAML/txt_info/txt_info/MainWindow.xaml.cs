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

namespace txt_info
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\test\\" + tb_id.Text + "_info_fn.txt", tb_first_name.Text, Encoding.UTF8);
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\test\\" + tb_id.Text + "_info_ln.txt", tb_last_name.Text, Encoding.UTF8);

            MessageBox.Show("Done!", "Alert");
        }

        private void btn_search_Click(object sender, RoutedEventArgs e)
        {
            if (tb_search_id.Text == "")
                return;
            tb_first_name.Text = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\test\\" + tb_search_id.Text + "_info_fn.txt");
            tb_last_name.Text = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\test\\" + tb_search_id.Text + "_info_ln.txt");
            tb_id.Text = tb_search_id.Text;
        }

        private void btn_new_Click(object sender, RoutedEventArgs e)
        {
            tb_id.Text = "";
            tb_first_name.Text = "";
            tb_last_name.Text = "";

            tb_id.Focus();
        }
    }
}
