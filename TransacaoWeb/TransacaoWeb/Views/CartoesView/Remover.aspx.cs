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
    public partial class Remover : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_remover_Click(object sender, EventArgs e)
        {
            try
            {
                Cartao cartao = CartaoController.getCartao(txt_numero_cartao.Text, txt_cod_cartao.Text);
                CartaoController.Remover(cartao);
                
            }
            catch (Exception) { }
        }

        protected void btn_limpar_Click(object sender, EventArgs e)
        {
            foreach (Cartao cartao in CartaoController.getCartoes())
            {
                CartaoController.Remover(cartao);
            }
        }
    }
}