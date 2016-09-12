using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPageOperario : System.Web.UI.MasterPage
{
 
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Perfil"] != null)
        {
            Usuario usu = (Usuario)Session["Perfil"];
            lblNomeSession.Text = Convert.ToString(usu.Nome);

            if (usu.Perfil != "operario")
                Response.Redirect("Login.aspx");
            
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }



    protected void btRecepcao_Click(object sender, EventArgs e)
    {
        Response.Redirect("PgRecepcao.aspx");
    }
    protected void btSaidapedidos_Click(object sender, EventArgs e)
    {
        Response.Redirect("PgSaidaPedido.aspx");
    }

    protected void logout_Click(object sender, EventArgs e)
    {

        Session.Abandon();
        Session.Clear();
        Response.Redirect("Login.aspx");
    }
}
