using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagment._03_Cookies
{
    public partial class CookieRead : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["MyCookie"];
            if (cookie != null)
            {
                OutputLabel.Text = cookie.Value;
            }
            else
            {
                OutputLabel.Text = "В запросе нет cookie-набора с именем 'MyCookie'";
            }
        }
    }
}