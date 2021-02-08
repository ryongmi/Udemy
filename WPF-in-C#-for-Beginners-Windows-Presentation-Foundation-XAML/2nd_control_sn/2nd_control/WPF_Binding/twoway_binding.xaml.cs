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

namespace _2nd_control.WPF_Binding
{
    /// <summary>
    /// twoway_binding.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class twoway_binding : Window
    {
        public twoway_binding()
        {
            InitializeComponent();
        }

        private void my_btn_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression bx;
            bx = mt_tb.GetBindingExpression(TextBox.TextProperty);
            bx.UpdateSource();
            // Target에서 Source로 값 보내기
        }

        private void mt_tb_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            MessageBox.Show("Source is update!");
        }

        private void mt_tb_TargetUpdated(object sender, DataTransferEventArgs e)
        {
            MessageBox.Show("Target is update!");
        }
    }
}
