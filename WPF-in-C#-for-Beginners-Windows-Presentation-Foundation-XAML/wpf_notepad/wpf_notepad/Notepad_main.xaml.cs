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

using Microsoft.Win32;

namespace wpf_notepad
{
    /// <summary>
    /// Notepad_main.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Notepad_main : Window
    {
        public Notepad_main()
        {
            InitializeComponent();
        }

        private void mitem_new_Click(object sender, RoutedEventArgs e)
        {
            tb_ctl.Text = "";
            tb_ctl.Focus();
        }

        private void mitem_open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Text Files|*.txt";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            ofd.ShowDialog();

            if(ofd.FileName != "")
                tb_ctl.Text = System.IO.File.ReadAllText(ofd.FileName, Encoding.UTF8);          
        }

        private void mitem_save_as_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Text Files|*.txt";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            sfd.AddExtension = true;

            sfd.ShowDialog();

            if(sfd.FileName != "")
            {
                System.IO.File.WriteAllText(sfd.FileName, tb_ctl.Text, Encoding.UTF8);
                MessageBox.Show("Done!");
            }
        }

        private void mitem_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void mitem_undo_Click(object sender, RoutedEventArgs e)
        {
            tb_ctl.Undo();
        }

        private void mitem_redo_Click(object sender, RoutedEventArgs e)
        {
            tb_ctl.Redo();
        }

        private void mitem_cut_Click(object sender, RoutedEventArgs e)
        {
            tb_ctl.Cut();
        }

        private void mitem_copy_Click(object sender, RoutedEventArgs e)
        {
            tb_ctl.Copy();
        }

        private void mitem_paste_Click(object sender, RoutedEventArgs e)
        {
            tb_ctl.Paste();
        }

        private void mitem_select_all_Click(object sender, RoutedEventArgs e)
        {
            tb_ctl.SelectAll();
        }

        private void mitem_wrap_Click(object sender, RoutedEventArgs e)
        {
            if (mitem_wrap.IsChecked == false)
            {
                tb_ctl.TextWrapping = TextWrapping.NoWrap;
                tb_ctl.HorizontalScrollBarVisibility = ScrollBarVisibility.Visible;
            }
            else
            {
                tb_ctl.TextWrapping = TextWrapping.Wrap;
                tb_ctl.HorizontalScrollBarVisibility = ScrollBarVisibility.Hidden;
            }
        }

        private void mitem_zoom_in_Click(object sender, RoutedEventArgs e)
        {
            if(tb_ctl.FontSize < 98)
                tb_ctl.FontSize += 2;
        }

        private void mitem_zoom_out_Click(object sender, RoutedEventArgs e)
        {
            if(tb_ctl.FontSize >= 10)
                tb_ctl.FontSize -= 2;
        }

        private void mitem_zoom_default_Click(object sender, RoutedEventArgs e)
        {
            tb_ctl.FontSize = 15;
        }
    }
}
