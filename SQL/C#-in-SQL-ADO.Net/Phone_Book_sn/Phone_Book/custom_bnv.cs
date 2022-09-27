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
    public partial class custom_bnv : Form
    {
        public custom_bnv()
        {
            InitializeComponent();
        }

        private void phone_book_tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phone_book_tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pb_dataset);

        }

        private void custom_bnv_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'pb_dataset.phone_book_table' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.phone_book_tableTableAdapter.Fill_all(this.pb_dataset.phone_book_table);
            DisplayLableValue();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.phone_book_tableBindingSource.MoveFirst();
            DisplayLableValue();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.phone_book_tableBindingSource.MovePrevious();
            DisplayLableValue();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.phone_book_tableBindingSource.MoveNext();
            DisplayLableValue();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.phone_book_tableBindingSource.MoveLast();
            DisplayLableValue();
        }

        private void DisplayLableValue()
        {
            int nPosition = this.phone_book_tableBindingSource.Position + 1;
            int nRowCount = this.phone_book_tableBindingSource.Count;

            lbl_RowCount.Text = " of " + nRowCount.ToString();
            lbl_CurrentRecord.Text = nPosition.ToString();

            if(nPosition == 1)
            {
                btnFirst.Enabled = false;
                btnPrev.Enabled = false;
                btnLast.Enabled = true;
                btnNext.Enabled = true;
            }
            else if(nPosition == nRowCount)
            {
                btnFirst.Enabled = true;
                btnPrev.Enabled = true;
                btnLast.Enabled = false;
                btnNext.Enabled = false;
            }
            else
            {
                btnFirst.Enabled = true;
                btnPrev.Enabled = true;
                btnLast.Enabled = true;
                btnNext.Enabled = true;
            }
        }
    }
}
