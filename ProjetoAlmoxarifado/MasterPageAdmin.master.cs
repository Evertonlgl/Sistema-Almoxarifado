using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPageAdmin : System.Web.UI.MasterPage
{




    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Perfil"] != null)
        {

            Usuario usu = (Usuario)Session["Perfil"];
            lblNomeSession.Text = Convert.ToString(usu.Nome);

            if (usu.Perfil != "admin")
                Response.Redirect("Login.aspx");
            
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }




    protected void btCadastraProduto_Click(object sender, EventArgs e)
    {
        Response.Redirect("CadastaProdutos.aspx");
    }
    protected void btCadastraFuncionario_Click(object sender, EventArgs e)
    {
        Response.Redirect("CadastraUsuario.aspx");

    }
    protected void btCadastraEmpresa_Click(object sender, EventArgs e)
    {
        Response.Redirect("CadastraEmpresa.aspx");
    }
    protected void btVisualizarCadastros_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminVisualizar.aspx");
    }
    protected void btAlterasenhaUsuario_Click(object sender, EventArgs e)
    {
        Response.Redirect("PgAlteraSenhafuncionario.aspx");
    }
    protected void logout_Click(object sender, EventArgs e)
    {

        Session.Abandon();
        Session.Clear();
        Response.Redirect("Login.aspx");
    }
}