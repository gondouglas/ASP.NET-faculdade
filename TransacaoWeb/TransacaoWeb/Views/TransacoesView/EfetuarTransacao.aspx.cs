using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TransacaoWeb.Controllers;
using TransacaoWeb.Models;

namespace TransacaoWeb.Views.TransacoesView
{
    public partial class EfetuarTransacao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_efetuar_Click(object sender, EventArgs e)
        {
            try
            {
                Cartao cartao = CartaoController.getCartao(txt_numeroCartao.Text, txt_cod.Text);
                Conta contaDestino = ContaController.getConta(txt_agencia.Text, txt_numero.Text);
                Conta contaOrigem = ContaController.getContaById(cartao.ContaId);
                Transacao transacao = new Transacao()
                {
                    ContaOrigemId = contaOrigem.Id,
                    ContaDestinoId = contaDestino.Id,
                    Data = DateTime.Now,
                    Valor = Convert.ToDouble(txt_valor.Text)
                };
                TransacaoController.EfetuarTransacao(transacao);
            }
            catch (Exception) { }
        }
    }
}