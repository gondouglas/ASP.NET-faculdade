using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1805
{
    public partial class Calc2 : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                double valor1 = Convert.ToDouble(Session["Valor 1"].ToString());
                double valor2 = Convert.ToDouble(Session["Valor 2"].ToString());
                txt_sumvalor1.Text = valor1.ToString();
                txt_sumvalor2.Text = valor2.ToString();
                txt_sumresult.Text = (valor1 + valor2).ToString();
                txt_subvalor1.Text = valor1.ToString();
                txt_subvalor2.Text = valor2.ToString();
                txt_subresult.Text = (valor1 - valor2).ToString();
                txt_mulvalor1.Text = valor1.ToString();
                txt_mulvalor2.Text = valor2.ToString();
                txt_mulresult.Text = (valor1 * valor2).ToString();
                txt_divvalor1.Text = valor1.ToString();
                txt_divvalor2.Text = valor2.ToString();
                txt_divresult.Text = (valor1 / valor2).ToString();
            }
            catch (Exception) { }
        }
    }
}