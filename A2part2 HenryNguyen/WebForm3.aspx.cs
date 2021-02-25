using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A2part2_HenryNguyen
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["language"];
            //HttpCookie poop = Request.Cookies.Get("language");
            string language =  cookie.Value;
            
            if (language == "C++")
            {
                ListBox1.Items.Add("The C++ Programming Language");
            }
            else if (language =="Visual Basic 2008")
            {
                ListBox1.Items.Add("Mastering Microsoft Visual Basic 2008");
            }
            else if (language == "Visual C# 2008")
            {
                ListBox1.Items.Add("C++ mit Microsoft Visual C++ 2008: Einführung in Standard-C++");
            }
            else if (language == "C")
            {
                ListBox1.Items.Add("The C Programming Language. 2nd Edition");
            }
            else if (language == "Java")
            {
                ListBox1.Items.Add("Effective Java");
            }
        }
    }
}