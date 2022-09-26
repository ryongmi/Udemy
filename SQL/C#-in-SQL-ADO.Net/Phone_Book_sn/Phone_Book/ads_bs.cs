using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Book
{
    public partial class ads_bs : Form
    {
        public ads_bs()
        {
            InitializeComponent();
        }

        private void ads_bs_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'pb_dataset1.phone_book_table' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.phone_book_tableTableAdapter.Fill_all(this.pb_dataset1.phone_book_table);
            DisplayRowCount();
            DisplayCurrentRecord();
        }

        private void DisplayCurrentRecord()
        {
            this.lbl_CurrentRecord.Text = (this.phone_book_tableBindingSource.Position + 1).ToString();
        }

        private void DisplayRowCount()
        {
            this.lbl_RowCount.Text = this.phone_book_tableBindingSource.Count.ToString();
        }

        private void phone_book_tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phone_book_tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pb_dataset1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayRowCount();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayCurrentRecord();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.phone_book_tableBindingSource.Sort = "id DESC";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.phone_book_tableBindingSource.Sort = "last_name DESC";
        }
    }
}
