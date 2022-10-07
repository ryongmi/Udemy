using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace en_dictionary_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbBoxSearchType.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(tBoxSearch.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your word to search!");
                return;
            }

            try
            {
                panelProgress.Visible = true;
                panelProgress.Refresh();
                
                switch (cbBoxSearchType.SelectedIndex)
                {
                    case 0: // Equals
                        this.en_word_listTableAdapter.FillBy_word(this.en_dic_ds.en_word_list, tBoxSearch.Text.Trim());
                        break;
                    case 1: // Starts With
                        this.en_word_listTableAdapter.FillBy_like_word(this.en_dic_ds.en_word_list, "%" + tBoxSearch.Text.Trim());
                        break;
                    case 2: // End With
                        this.en_word_listTableAdapter.FillBy_like_word(this.en_dic_ds.en_word_list, tBoxSearch.Text.Trim() + "%");
                        break;
                    case 3: // Every Where
                        this.en_word_listTableAdapter.FillBy_like_word(this.en_dic_ds.en_word_list, "%" + tBoxSearch.Text.Trim() + "%");
                        break;
                    default:
                        break;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                panelProgress.Visible = false;
            }
        }

        private void btntolShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                panelProgress.Visible = true;
                panelProgress.Refresh();

                // TODO: 이 코드는 데이터를 'en_dic_ds.en_word_list' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
                this.en_word_listTableAdapter.Fill(this.en_dic_ds.en_word_list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                panelProgress.Visible = false;
            }
        }
    }
}
