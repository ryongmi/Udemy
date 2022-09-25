using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaStore
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPurchase_Click(object sender, EventArgs e)
        {
            double Total = 0;

            if (rdoBtnBaby.Checked)
                Total += 10;
            else if (rdoBtnMama.Checked)
                Total += 13;
            else if (rdoBtnPapa.Checked)
                Total += 16;
            else
            {
                lblTotal.Text = "Plz check Pizza";
                return;
            }

            if (rdoBtnDish.Checked)
                Total += 2;
            else if (!rdoBtnCrust.Checked)
            {
                lblTotal.Text = "Plz check Dou";
                return;
            }

            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                    Total += Convert.ToDouble(item.Value);
            }

            if ((CheckBoxList1.Items[0].Selected && CheckBoxList1.Items[2].Selected && CheckBoxList1.Items[4].Selected) || (CheckBoxList1.Items[0].Selected && CheckBoxList1.Items[1].Selected && CheckBoxList1.Items[3].Selected))
                Total -= 2;

            lblTotal.Text = "$" + Total.ToString();
        }
    }
}