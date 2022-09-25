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

namespace partical
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

        private void btn_return_keyword_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hi");
            return;
            MessageBox.Show("Hi 2");
        }

        private void btn_close_window_Click(object sender, RoutedEventArgs e)
        {
            window_name.Close();
        }

        private void btn_close_app_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            // Environment.Exit(0);
        }

        private void btn_app_direcory_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);
            // exe파일이 있는 폴더를 가리킴
        }

        private void btn_special_folder_Click(object sender, RoutedEventArgs e)
        {
           MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        private void btn_run_app_fix_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\calc.exe");
        }

        private void btn_run_dir_app_Click(object sender, RoutedEventArgs e)
        {
             System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + "\\calc.exe");
        }

        private void btn_run_special_folder_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.System)+"\\calc.exe");
        }
    }
}
