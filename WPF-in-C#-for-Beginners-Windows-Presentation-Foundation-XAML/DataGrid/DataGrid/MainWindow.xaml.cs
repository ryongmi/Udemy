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
using System.Data;

namespace DataGrid
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

        private void window_loaded(object sender, RoutedEventArgs e)
        {
            // DataTable 생성
            DataTable dataTable = new DataTable();

            // 컬럼 생성
            dataTable.Columns.Add("ID", typeof(string));
            dataTable.Columns.Add("NAME", typeof(string));
            dataTable.Columns.Add("TEL_NO", typeof(string));

            // 데이터 생성
            dataTable.Rows.Add(new string[] { "ID-02", "Name 01", "010-0001-0000" });
            dataTable.Rows.Add(new string[] { "ID-03", "Name 03", "010-0002-0000" });
            dataTable.Rows.Add(new string[] { "ID-01", "Name 04", "010-0004-0000" });
            dataTable.Rows.Add(new string[] { "ID-04", "Name 02", "010-0003-0000" });

            // DataTable의 Default View를 바인딩하기
            dataGrid1.ItemsSource = dataTable.DefaultView;
        }
    }
}
