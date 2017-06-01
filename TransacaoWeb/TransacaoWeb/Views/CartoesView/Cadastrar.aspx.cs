using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TransacaoWeb.Controllers;
using TransacaoWeb.Models;

namespace TransacaoWeb.Views.CartoesView
{
    public partial class Cadastrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_gerar_Click(object sender, EventArgs e)
        {
            try
            {
                Conta conta = ContaController.getConta(txt_agencia.Text, txt_numero.Text);
                ContaController.PedirCartao(conta.Agencia,conta.Numero);
            }
            catch (Exception)
            {

            }
        }
    }
}