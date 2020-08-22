using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagment._01_ViewState
{
    //Удобная реализация ViewState
    public partial class ViewStateUsing2 : System.Web.UI.Page
    {
        private const string key = "counter";
        protected int Counter
        {
            get 
            {
                object obj = ViewState[key];
                // Если ViewState хранит требуемый ключ - возвращаем его.
                if (obj != null)
                {
                    return (int)obj;
                }
                // Если ключ отсутствует - устанавливаем значение по умолчанию во ViewState
                else
                {
                    ViewState[key] = 0;
                    return 0;
                }
            }
            set 
            {
                ViewState[key] = value; 
            }
        }

        protected void AddOneButton_Click(object sender, EventArgs e)
        {
            Counter += 1;
        }

        protected void AddTwoButton_Click(object sender, EventArgs e)
        {
            Counter += 2;
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            CounterLabel.Text = Convert.ToString(Counter);
        }
    }
}