using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPagePedidoEmpresa : System.Web.UI.MasterPage
{


    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["Empresa"] == null)
            Response.Redirect("Login.aspx");

        Empresa em = (Empresa)Session["Empresa"];

        lblNomeSession.Text = Convert.ToString(em.Nome);


    }
    protected void btPedidos_Click(object sender, EventArgs e)
    {
        Response.Redirect("PgPedidoExterno.aspx");
    }
    protected void btAlterarSenha_Click(object sender, EventArgs e)
    {
        Response.Redirect("PgAlteraSenhaEmpresa.aspx");
    }
    protected void btVisualizarPedidos_Click(object sender, EventArgs e)
    {
        Response.Redirect("PgVisualizaPedidosEmp.aspx");
    }

    protected void logout_Click(object sender, EventArgs e)
    {

        Session.Abandon();
        Session.Clear();
        Response.Redirect("Login.aspx");
    }
}
