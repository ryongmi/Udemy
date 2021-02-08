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

namespace _2nd_control.File_Folder
{
    /// <summary>
    /// io_file_folder.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class io_file_folder : Window
    {
        public io_file_folder()
        {
            InitializeComponent();
        }

        private void file_exists_Click(object sender, RoutedEventArgs e)
        {
            bool b;
            b = System.IO.File.Exists(file_tbox.Text);
            if (b)
                MessageBox.Show("I found folder");
            else
                MessageBox.Show("I can't find folder");
        }

        private void folder_tbox_Click(object sender, RoutedEventArgs e)
        {
            file_tbox.Text = Environment.CurrentDirectory+"\\File_Folder\\img\\Ori.jpg";
        }

        private void file_delete_btn_Click(object sender, RoutedEventArgs e)
        {
            System.IO.File.Delete(file_tbox.Text);
        }

        private void brower_btn_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            ofd.ShowDialog(); 

            file_tbox.Text = ofd.FileName;
        }
    }
}
