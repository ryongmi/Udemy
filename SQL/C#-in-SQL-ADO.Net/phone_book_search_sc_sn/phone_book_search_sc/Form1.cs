using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phone_book_search_sc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void phone_book_table_section5BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phone_book_table_section5BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pb_ds);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'pb_ds.phone_book_table_section5' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.phone_book_table_section5TableAdapter.Fill(this.pb_ds.phone_book_table_section5);

        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            this.phone_book_table_section5TableAdapter.Fill(this.pb_ds.phone_book_table_section5);
        }

        private void btnSearchLastName_Click(object sender, EventArgs e)
        {
            //this.phone_book_table_section5TableAdapter.FillBy_last_name(pb_ds.phone_book_table_section5, tBoxLastName.Text.Trim());

            this.phone_book_table_section5TableAdapter.FillBy_Like_last_name(pb_ds.phone_book_table_section5, "%" + tBoxLastName.Text.Trim() + "%");
        }

        private void btnSearchId_Click(object sender, EventArgs e)
        {
            if(int.TryParse(tBoxId.Text.Trim(), out int nId))
                this.phone_book_table_section5TableAdapter.FillBy_id(this.pb_ds.phone_book_table_section5, nId);
            else
                MessageBox.Show("숫자 입력");
        }

        private void btnSearchBirthDate_Click(object sender, EventArgs e)
        {
            this.phone_book_table_section5TableAdapter.FillBy_between_birth_date(pb_ds.phone_book_table_section5, dtFirst.Value.ToString(), dtLast.Value.ToString());
        }
    }
}
