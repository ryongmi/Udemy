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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void phone_book_tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phone_book_tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pb_dataset);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: 이 코드는 데이터를 'pb_dataset.phone_book_table' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
                this.phone_book_tableTableAdapter.Fill_all(this.pb_dataset.phone_book_table);

                // disable save_cancel btn ------------
                this.btnSave.Enabled = false;
                this.btnCencel.Enabled = false;

                // disable groupBox_Grid ------------

                this.groupBox1.Enabled = false;
                this.phone_book_tableDataGridView.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void BtnEnableChange(bool bol)
        {
            this.btnAddNew.Enabled = bol;
            this.btnEdit.Enabled = bol;
            this.btnDel.Enabled = bol;

            this.btnSave.Enabled = !bol;
            this.btnCencel.Enabled = !bol;

            this.groupBox1.Enabled = !bol;
            this.phone_book_tableDataGridView.Enabled = bol;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            BtnEnableChange(false);

            // -------- add new record --------
            this.phone_book_tableBindingSource.AddNew();
            // --------------------------------
            this.pictureBox1.Image = Phone_Book.Properties.Resources.no_image;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int nRc = this.pb_dataset.phone_book_table.Rows.Count;
            if(nRc == 0)
            {
                MessageBox.Show("Please select your record to edit!");
                return;
            }

            BtnEnableChange(false);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int nRc = this.pb_dataset.phone_book_table.Rows.Count;
            if (nRc == 0)
            {
                MessageBox.Show("Please select your record to edit!");
                return;
            }

            BtnEnableChange(false);

            this.groupBox1.Enabled = false;

            // -------- delete record --------
            this.phone_book_tableBindingSource.RemoveCurrent();
            // --------------------------------
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                BtnEnableChange(true);

                this.phone_book_tableBindingSource.EndEdit();

                int nResult = this.phone_book_tableTableAdapter.Update(this.pb_dataset.phone_book_table);

                if(nResult > 0)
                    MessageBox.Show("Saved!");
                else
                    MessageBox.Show("Not Saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            BtnEnableChange(true);

            this.phone_book_tableBindingSource.CancelEdit();
            this.pb_dataset.phone_book_table.RejectChanges();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.phone_book_tableTableAdapter.FillBy_income_info(this.pb_dataset.phone_book_table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string strFileName = this.openFileDialog1.FileName;
            if (strFileName == "")
                return;

            this.pictureBox1.Image = Image.FromFile(strFileName);
        }
    }
}
