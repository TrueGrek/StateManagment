using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagment._05_Application
{
    public partial class ApplicationUsing : System.Web.UI.Page
    {
        private static string key = "counter";
        public int Counter
        {
            get
            {
                // Данные, которые хранятся в Application - глобальные и доступны всем пользователям.
                object obj = Application[key];
                if (obj == null)
                {
                    Application[key] = 0;
                    return 0;
                }
                return (int)obj;
            }
            set
            {
                Application[key] = value;
            }
        }

        protected void AddOneButton_Click(object sender, EventArgs e)
        {
            Counter += 1;
            CounterLabel.Text = Counter.ToString();
        }

        protected void AddTwoButton_Click(object sender, EventArgs e)
        {
            Counter += 2;
            CounterLabel.Text = Counter.ToString();
        }
    }
}