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
    /// slider.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class slider : Window
    {
        public slider()
        {
            InitializeComponent();
        }

        private void my_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        // slider의 value가 변경되면 발생하는 이벤트, 만약 value값을 지정했으면 프로그램 실행하면서 한번 실행됨
        // 주의할점 : value가 설정되어 있는 상태에서 레이블에 값을 넣어주려고함(아래 함수와같이) 이때, value가 설정되어 이벤트가 발생하는데, slider가 먼저 생성되어 있으면, 이벤트 발생시점에서는 레이블이 생성되어 있지 않아,
        //            오류가 발생한다. 따라서 value를 사용하고, 값을 지정해주려고 하면 지정받을 컨트롤을 (xaml에서) 먼저 선언해야함. 또는 아래와 같이 if문을 걸어줘야함.
        {
            //MessageBox.Show("changed value");
            //int num = (int)my_slider.Value;
            if (lbl_slider_value != null)
                lbl_slider_value.Content = ((int)my_slider.Value).ToString();
        }
    }
}
