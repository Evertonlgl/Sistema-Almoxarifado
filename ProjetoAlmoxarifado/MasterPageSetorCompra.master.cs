using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPageSetorCompra : System.Web.UI.MasterPage
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Perfil"] != null)
        {
            Usuario usu = (Usuario)Session["Perfil"];
            lblNomeSession.Text = Convert.ToString(usu.Nome);

            if (usu.Perfil != "compras")
                Response.Redirect("Login.aspx");
            
        }
        else
        {
            Response.Redirect("Login.aspx");
        }


    }
    protected void btOrdemCompra_Click(object sender, EventArgs e)
    {
        Response.Redirect("PgOrdemCompra.aspx");
    }
    protected void btPedidos_Click(object sender, EventArgs e)
    {
        Response.Redirect("PgPedido.aspx");
    }
    protected void btVisualizarPedidos_Click(object sender, EventArgs e)
    {
        Response.Redirect("PgVisualizarComprasPedidos.aspx");
    }

    protected void logout_Click(object sender, EventArgs e)
    {

        Session.Abandon();
        Session.Clear();
        Response.Redirect("Login.aspx");
    }
}
