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
    public partial class Listar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Conta> contas = ContaController.getContas();
            gvContas.DataSource = contas;
            gvContas.DataBind();
        }
    }
}