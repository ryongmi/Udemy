using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pro_search_from
{
    public partial class pro_search : Form
    {
        public pro_search()
        {
            InitializeComponent();
        }

        private void pro_search_Load(object sender, EventArgs e)
        {
            this.cbBoxSearchItem.SelectedIndex = 0;
        }

        private void cbBoxSearchItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cbBoxSearchItem.SelectedIndex == 0) 
            {
                this.panelDate.Visible = false;
                this.panelSearch.Visible = true;
            }
            else // date
            {
                this.panelDate.Visible = true;
                this.panelSearch.Visible = false;
            }
        }

        private void cbBoxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbBoxSearchType.SelectedIndex == 4) // Between
            {
                this.lblSearchType.Visible = true;
                this.tBoxSearchLast.Visible = true;
            }
            else
            {
                this.lblSearchType.Visible = false;
                this.tBoxSearchLast.Visible = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (this.cbBoxSearchItem.SelectedIndex == 0)  // last name
                {
                    switch (this.cbBoxSearchType.SelectedIndex)
                    {
                        case -1: // no item
                            MessageBox.Show("Please select your search type!");
                            break;
                        case 0: // =
                            this.phone_book_table_section5TableAdapter.FillBy_like_last_name(pb_ds.phone_book_table_section5, tBoxSearchFirst.Text.Trim());
                            break;
                        case 1: // Starts with
                            this.phone_book_table_section5TableAdapter.FillBy_like_last_name(pb_ds.phone_book_table_section5, tBoxSearchFirst.Text.Trim() + "%");
                            break;
                        case 2: // End with
                            this.phone_book_table_section5TableAdapter.FillBy_like_last_name(pb_ds.phone_book_table_section5, "%" + tBoxSearchFirst.Text.Trim());
                            break;
                        case 3: // Every where
                            this.phone_book_table_section5TableAdapter.FillBy_like_last_name(pb_ds.phone_book_table_section5, "%" + tBoxSearchFirst.Text.Trim() + "%");
                            break;
                        case 4: // Between
                            this.phone_book_table_section5TableAdapter.FillBy_between_last_name(pb_ds.phone_book_table_section5, tBoxSearchFirst.Text.Trim(), tBoxSearchLast.Text.Trim());
                            break;
                        case 5: // Not Equal
                            this.phone_book_table_section5TableAdapter.FillBy_notEqual_last_name(pb_ds.phone_book_table_section5, tBoxSearchFirst.Text.Trim());
                            break;
                        default:
                            break;
                    }
                }
                else  // date
                {
                    this.phone_book_table_section5TableAdapter.FillBy_date_of_birth(pb_ds.phone_book_table_section5, this.dtFirst.Value.ToString(), this.dtLast.Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: 이 코드는 데이터를 'pb_ds.phone_book_table_section5' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
                this.phone_book_table_section5TableAdapter.Fill(this.pb_ds.phone_book_table_section5);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
