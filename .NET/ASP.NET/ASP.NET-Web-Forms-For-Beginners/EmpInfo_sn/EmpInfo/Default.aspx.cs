using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmpInfo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResult.Text = DropDownList1.Text;
        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
            lblFullName.Text = tBoxName.Text + " " + lblResult.Text;

            if (rdoBtnAccount.Checked)
                lblFullName.Text += " Account"; 
            else if(rdoBtnMarket.Checked)
                lblFullName.Text += " Market";
            else
                lblFullName.Text += " Legal";

            if(chkBoxBA.Checked == true)
                lblFullName.Text += " BA";
            if (chkBoxMA.Checked == true)
                lblFullName.Text += " MA";
            if (chkBoxPHD.Checked == true)
                lblFullName.Text += " PHD";
        }
    }
}