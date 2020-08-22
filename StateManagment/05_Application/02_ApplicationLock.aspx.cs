using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagment._05_Application
{
    public partial class ApplicationLock : System.Web.UI.Page
    {
        protected void AddOneButton_Click(object sender, EventArgs e)
        {
            // Запрашиваем монопольный доступ.
            Application.Lock();

            int counter = 0;
            if (Application["counter"] != null)
            {
                counter = (int)Application["counter"];
            }
            Application["counter"] = ++counter;
            CounterLabel.Text = counter.ToString();

            // Отключаем монопольный доступ.
            Application.UnLock();

        }
    }
}