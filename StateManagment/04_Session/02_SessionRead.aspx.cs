using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagment._04_Session
{
    public partial class SessionRead : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string text = Session["Key"] as string;
            if (text != null)
            {
                OutputLabel.Text = text;
            }
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            //Session.Clear(); // Удаляет все значения из объекта коллекции.
            Session.Abandon(); // Удаляет объект коллекции.
            Response.Redirect(Request.Url.PathAndQuery);
        }
    }
}