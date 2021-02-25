using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A2part2_HenryNguyen
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = "Welcome to cookies! You selected " + Request.Cookies["language"].Value;
            HttpCookie cookie = Request.Cookies["language"];
            Label1.Text = "Welcome to cookies! You selected " + cookie.Value;

        }
    }
}