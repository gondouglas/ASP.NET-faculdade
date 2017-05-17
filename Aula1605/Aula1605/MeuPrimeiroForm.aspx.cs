using Aula1605.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1605
{
    public partial class MeuPrimeiroForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_salvar_Click(object sender, EventArgs e)
        {
            Projeto proj = new Projeto()
            {
                Nome = txt_nome.Text,
                Descricao = txt_descricao.Text,
                Ativo = chk_ativo.Checked
            };
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_nome.Text = string.Empty;
            txt_descricao.Text = string.Empty;
            chk_ativo.Checked = false;

            ViewState.Add("controle", "1");
        }
    }
}