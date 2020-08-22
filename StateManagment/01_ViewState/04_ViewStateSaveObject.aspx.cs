using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagment._01_ViewState
{
    public partial class ViewStateSaveObject : System.Web.UI.Page
    {
        protected void WriteButton_Click(object sender, EventArgs e)
        {
            // Объекты, сохраняемые в состояние вида, должны быть сериализуемого типа.
            // Класс должен иметь атрибут Serializable
            Customer cust = new Customer("admin", "admin@example.com");
            ViewState["customer"] = cust;
        }

        protected void ReadButton_Click(object sender, EventArgs e)
        {
            Customer cust = ViewState["customer"] as Customer;
            if (cust != null)
            {
                UserNameLabel.Text = cust.UserName;
                EmailLabel.Text = cust.Email;
            }
            else
            {
                UserNameLabel.Text = "<i>null</i>";
                EmailLabel.Text = "<i>null</i>";
            }
        }
    }
}