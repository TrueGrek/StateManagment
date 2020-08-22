using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagment._04_Session
{
    public partial class SessionWrite : System.Web.UI.Page
    {
        protected void SaveButton_Click(object sender, EventArgs e)
        {
            // Запись значения в сессию.
            Session["Key"] = TextBox1.Text;

            // Значение будет храниться в памяти сервера 1 минуту. (по умолчанию значение храниться 20 минут)
            Session.Timeout = 1;
        }
    }
}