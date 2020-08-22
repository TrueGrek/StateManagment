using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagment._01_ViewState
{
    public partial class StateStorageProblem : System.Web.UI.Page
    {
        // При каждом запросе экземпляр этого класса создается повторно,
        // соответственно при вызове любого из обработчиков (AddOneButton_Click или AddTwoButton_Click)
        // значение  переменной _counter будет равное 0.
        int _counter = 0;

        protected void AddOneButton_Click(object sender, EventArgs e)
        {
            _counter += 1;
            CounterLabel.Text = _counter.ToString();
        }

        protected void AddTwoButton_Click(object sender, EventArgs e)
        {
            _counter += 2;
            CounterLabel.Text = _counter.ToString();
        }
    }
}