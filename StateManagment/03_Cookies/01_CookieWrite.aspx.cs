using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagment._03_Cookies
{
    public partial class CookieUsing : System.Web.UI.Page
    {
        protected void SaveButton_Click(object sender, EventArgs e)
        {
            // Создаем cookie набор.
            // Такой cookie-набор будет храниться до тех пор, пока пользователь не закроет браузер.
            HttpCookie cookie = new HttpCookie("MyCookie", TextBox1.Text);
            
            // Добавляем cookie-набор в текущий ответ.
            Response.Cookies.Add(cookie);
        }
    }
}