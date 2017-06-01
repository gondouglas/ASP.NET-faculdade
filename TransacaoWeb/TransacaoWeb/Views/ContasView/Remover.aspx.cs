using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TransacaoWeb.Controllers;
using TransacaoWeb.Models;

namespace TransacaoWeb.Views.ContasView
{
    public partial class Remover : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_limpar_Click(object sender, EventArgs e)
        {
            foreach(Conta conta in ContaController.getContas())
            {
                ContaController.Remover(conta);
            }
        }

        protected void btn_remover_Click(object sender, EventArgs e)
        {
            try
            {
                Conta conta = ContaController.getConta(txt_agencia.Text, txt_numero.Text);
                CartaoController.Remover(CartaoController.getById(conta.CartaoId));
                ContaController.Remover(conta);
            }
            catch (Exception) { }
        }
    }
}