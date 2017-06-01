using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TransacaoWeb.Controllers;

namespace TransacaoWeb.Views.CartoesView
{
    public partial class Listar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvCartoes.DataSource = CartaoController.getCartoes();
            gvCartoes.DataBind();
        }
    }
}