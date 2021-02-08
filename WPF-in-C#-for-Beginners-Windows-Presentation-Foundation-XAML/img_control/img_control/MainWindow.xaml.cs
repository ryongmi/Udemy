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
// 오픈파일을 사용하기 위한 라이브러리

namespace img_control
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

        private void btn_img_load_Click(object sender, RoutedEventArgs e)
        {
            if (lbl_fill_name.Content.ToString() != string.Empty)
            {
                // Uri image_path = new Uri("C:\\Users\\ryong\\OneDrive\\Desktop\\vs\\img_control\\img_control\\KakaoTalk_20200919_145305260.jpg");
                Uri image_path = new Uri(lbl_fill_name.Content.ToString());
                // 오픈 파일을 이용해 파일 경로를 라벨에 저장하고 라벨에 저장된 경로를 Uri 객체로 만들어 사진을 바꿔줌.
                // ( 경로 중간에 \ 두개를 써야하는데 라벨에는 하나만 써져있음. 문법으로 정해진거라 그냥 써야함)
                this.img.Source = new BitmapImage(image_path);
            }
        }

        private void btn_fill_Click(object sender, RoutedEventArgs e)
        {
            img.Stretch = Stretch.Fill;
        }

        private void btn_zoom_Click(object sender, RoutedEventArgs e)
        {
            img.Effect = null;
            img.Stretch = Stretch.Uniform;
        }

        private void btn_browse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select image to show";
            // ofd.Filter = "JPG Files|*.jpg|PNG Files|*.png|All Files|*.*";
            ofd.Filter = "Image Files(*.jpg;*.png)|*.jpg;*.png";
            // 파일 확장자

            // ofd.InitialDirectory = "C:\\Users\\ryong\\OneDrive\\Desktop";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // 오픈 파일 열었을때 처음으로 열릴 폴더 지정
            // 위의 것은 경로를 지정하여 절대 변하지 않는다. 아래는 MyDocuments(내 문서)가 변경되면 같이 변경됨.

            ofd.ShowDialog();
            // 오픈 파일 열기

            lbl_fill_name.Content = ofd.FileName;
        }
    }
}
