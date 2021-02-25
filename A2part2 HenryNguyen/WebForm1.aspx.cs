using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A2part2_HenryNguyen
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitbtn_Click(object sender, EventArgs e)
        {
            //HttpCookie cookie = new HttpCookie("language");
            //cookie.Value = RadioButtonList1.Text;
            Response.Cookies["language"].Value = RadioButtonList1.Text;
            Response.Redirect("~/WebForm2.aspx");
        }
    }
}