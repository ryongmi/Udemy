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

namespace local_window_resource
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

        private void btn_window_res_Click(object sender, RoutedEventArgs e)
        {
            object ob;
            ob = TryFindResource("btn_height");
            // TryFindResource : 리소스가 있는지 찾고, 찾았다면 object타입으로 값을 리턴해줌, 찾지 못하면 null값 리턴
            // ob = Resources["btn_height"];

            if (ob != null)
            {
                lbl_window_res.Content = ob.ToString();
            }
        }

        private void btn_app_res_Click(object sender, RoutedEventArgs e)
        {
            object ob;
            ob = Application.Current.TryFindResource("btn_exit_width");
            // ob = Application.Current.Resources["btn_exit_width"];
            // 애플리케이션 리소스를 사용하는 방법.

            if (ob != null)
            {
                lbl_app_res.Content = ob.ToString();
            }
        }

        private void btn_grid_res_Click(object sender, RoutedEventArgs e)
        {
            object ob;
            ob = grid_main.TryFindResource("grid_width");
            // ob = grid_main.Resources["btn_height"];
            // grid 리소스를 사용하려면 그리드이름.리소스 하면 됨.

            if (ob != null)
            {
                lbl_grid_res.Content = ob.ToString();
            }
        }
    }
}
