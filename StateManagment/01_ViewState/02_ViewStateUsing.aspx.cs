using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagment._01_ViewState
{
    public partial class ViewStateUsing : System.Web.UI.Page
    {
        protected void AddOneButton_Click(object sender, EventArgs e)
        {
            int counter = 0;
            // Чтение данных из ViewState
            object obj = ViewState["counter"];
            if (obj != null)
            {
                counter = (int)obj;
            }
            counter += 1;
            // Запись данных во ViewState
            ViewState["counter"] = counter;
        }

        protected void AddTwoButton_Click(object sender, EventArgs e)
        {
            int counter = 0; 
            // Чтение данных из ViewState
            object obj = ViewState["counter"];
            if (obj != null)
            {
                counter = (int)obj;
            }
            counter += 2;
            // Запись данных во ViewState
            ViewState["counter"] = counter;
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            CounterLabel.Text = Convert.ToString(ViewState["counter"]);
        }
    }
}