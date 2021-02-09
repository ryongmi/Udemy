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
using System.Windows.Threading;

namespace wpf_diary_app
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void pic_cbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        // 콤보박스 아이템 변경되면 발생하는 이벤트
        {
            String path;
            if(pic_cbox.SelectedIndex == 0)
                path = Environment.CurrentDirectory + "\\Data\\Pics\\" + (pic_cbox.SelectedIndex + 1).ToString() + ".png";
            else
                path = Environment.CurrentDirectory + "\\Data\\Pics\\" + (pic_cbox.SelectedIndex + 1).ToString() + ".jpg";
            System.Uri ur = new Uri(path);
            // 이미지 경로 받아옴
            ImageBrush im = new ImageBrush(new BitmapImage(ur));
            // 이미지 uri를 이미지 브러쉬 객체 생성 -> window background 이미지가 imagebrush를 사용해서 이미지브러쉬 객체 im을 만들어야함
            im.Stretch = Stretch.Fill;

            this.Background = im;
            // 백그라운드 이미지 변경

            wpf_diary_app.Properties.Settings.Default.sel_image_main_window = pic_cbox.SelectedIndex;
            // 콤보박스 인덱스가 변경될때마다 설정 값도 바꿔줌

            wpf_diary_app.Properties.Settings.Default.Save();
            // 바꾼 설정 값을 저장함. ( 다음에 실행할때 마지막까지 사용했던 값을 계속 사용할 수 있음 )
        }

        private void main_window_Loaded(object sender, RoutedEventArgs e)
        {
            #region Background image 교체
            // --------------- 콤보박스 백그라운드 이미지 변경 ------------------
            Int32 fi;
            fi = wpf_diary_app.Properties.Settings.Default.sel_image_main_window;
            // Properties 설정에서 설정한 값을 사용하는 구문

            String path;
            if (fi == 0)
                path = Environment.CurrentDirectory + "\\Data\\Pics\\" + (fi + 1).ToString() + ".png";
            else
                path = Environment.CurrentDirectory + "\\Data\\Pics\\" + (wpf_diary_app.Properties.Settings.Default.sel_image_main_window + 1).ToString() + ".jpg";
            System.Uri ur = new Uri(path);
            
            ImageBrush im = new ImageBrush(new BitmapImage(ur));
            
            im.Stretch = Stretch.Fill;

            this.Background = im;

            pic_cbox.SelectedIndex = fi;
            // 백그라운드 이미지를 설정하면서 콤보박스 인덱스도 변경해 줌
            // ------------------------------------------------------------------- 
            #endregion

            #region 디지털 시계 쓰레드 세팅
            // ----------------- 디지털 시계 쓰레드 세팅 ------------------------- 
            DispatcherTimer t = new DispatcherTimer();
            // 타이머 클래스
            t.Interval = new TimeSpan(0, 0, 1);
            // 시간(타이머) 설정
            t.Tick += time_update;
            // Tick : 지정된 시간이 지나면 자동으로 실행되는 이벤트, 타이머 객체(t)에 이벤트가 발생하면 호출될 메서드들을 추가함.
            t.Start();
            // 타이머 실행
            // -------------------------------------------------------------------
            #endregion

            #region 달력 세팅
            // ----------------- 달력 세팅 ------------------------- 
            year_lbl.Content = DateTime.Now.Year.ToString();
            month_lbl.Content = DateTime.Now.ToString("MMMM");
            day_in_month_lbl.Content = DateTime.Now.Date.ToString("dd");
            day_in_week_lbl.Content = DateTime.Now.Date.ToString("dddd");
            // -----------------------------------------------------
            #endregion
        }

        void time_update(object sender, EventArgs e)
        // 1초마다 반복되는 메서드. ( 시계 시간 update )
        {
            time_lbl.Content = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
