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

using Microsoft.Win32;
namespace text_control
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
            System.IO.File.WriteAllText("C:\\text_test\\info.txt", tb_tbox.Text, Encoding.UTF8);
        }

        private void btn_load_Click(object sender, RoutedEventArgs e)
        {
            tb_tbox.Text = System.IO.File.ReadAllText("C:\\text_test\\info.txt", Encoding.UTF8);
        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            tb_tbox.Text = "";
            tb_tbox.Focus();
        }

        private void btn_save_as_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog odf = new SaveFileDialog();

            odf.Title = "Save Text File";
            odf.Filter = "txt|*.txt|All|*.*";
            odf.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            odf.AddExtension = true;
            // 자동으로 확장자 추가

            odf.ShowDialog();

            if (odf.FileName != "")
            {
                System.IO.File.WriteAllText(odf.FileName, tb_tbox.Text, Encoding.UTF8);
                // 선택한 파일 경로를 불러와서 저장시킴
            }
        }
    }
}
