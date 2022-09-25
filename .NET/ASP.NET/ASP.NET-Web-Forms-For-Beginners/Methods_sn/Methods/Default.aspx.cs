using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Methods
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Area_Click(object sender, EventArgs e)
        {
            double len;
            double wid;
            double area;

            len = double.Parse(tBox_Length.Text);
            wid = double.Parse(tBox_width.Text);

            area = AreaMethod(len, wid);

            lbl_Result.Text = area.ToString();
        }

        private double AreaMethod(double len, double wid)
        {
            return len * wid;
        }
    }
}