using Aula1805.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1805
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_sum_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = OperationController.getOperation(Convert.ToDouble(txt_valor1.Text), Models.Operator.SUM, Convert.ToDouble(txt_valor2.Text)).Resultado.ToString();
        }

        protected void btn_equals_Click(object sender, EventArgs e)
        {
            Session.Add("Valor 1", txt_valor1.Text);
            Session.Add("Valor 2", txt_valor2.Text);
            Response.Redirect("~/Calc2.aspx");
        }
    }
}