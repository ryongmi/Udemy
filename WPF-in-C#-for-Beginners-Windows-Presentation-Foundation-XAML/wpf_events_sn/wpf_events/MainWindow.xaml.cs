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

namespace wpf_events
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

        private void window_events_keydown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.Key.ToString());
            // keydown 이벤트의 e객체는 키보드를 눌렀을 때 누른 키의 값을 가지고 있음.
        }

        private void tb_first_TextChanged(object sender, TextChangedEventArgs e)
        // text가 변경되면 발생하는 이벤트
        {
            this.Title = tb_first.Text;
        }

        private void tb_first_GotFocus(object sender, RoutedEventArgs e)
        // 포커스가 생기면 발생하는 이벤트
        {
            tb_first.Background = Brushes.Coral;
        }

        private void tb_first_LostFocus(object sender, RoutedEventArgs e)
        // 포커스를 잃어버리면 발생하는 이벤트
        {
            tb_first.Background = Brushes.White;
        }

        private void tb_second_GotFocus(object sender, RoutedEventArgs e)
        {
            tb_second.Background = Brushes.Blue;
        }

        private void tb_second_LostFocus(object sender, RoutedEventArgs e)
        {
            tb_second.Background = Brushes.White;
        }

        private void tb_third_GotFocus(object sender, RoutedEventArgs e)
        {
            tb_third.Background = Brushes.Gray;
        }

        private void tb_third_LostFocus(object sender, RoutedEventArgs e)
        {
            tb_third.Background = Brushes.White;
        }

        private void cbox_fname_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tb_first.Text = cbox_fname.SelectedIndex.ToString();
            ComboBoxItem cdi;
            //cdi = cbox_fname.SelectedItem as ComboBoxItem;
            cdi = (ComboBoxItem)cbox_fname.SelectedItem;

            //if(cdi != null)
                tb_second.Text = cdi.Content.ToString();
        }

        private void btn_show_Click(object sender, RoutedEventArgs e)
        {
            tb_first.Text = cbox_fname.SelectedIndex.ToString();
            ComboBoxItem cdi;
            //cdi = cbox_fname.SelectedItem as ComboBoxItem;
            cdi = (ComboBoxItem)cbox_fname.SelectedItem;

            if (cdi != null)
                tb_second.Text = cdi.Content.ToString();
        }

        private void lbox_fname_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem lbi;
            lbi = (ListBoxItem)lbox_fname.SelectedItem;

            if(lbi != null)
                tb_third.Text = lbi.Content.ToString();
        }

        private void btn_show_second_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem lbi;
            lbi = (ListBoxItem)lbox_fname.SelectedItem;

            if (lbi != null)
                tb_third.Text = lbi.Content.ToString();
        }
    }
}
