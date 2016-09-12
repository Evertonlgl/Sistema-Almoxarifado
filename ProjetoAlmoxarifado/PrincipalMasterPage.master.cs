using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    void Page_PreInit(object sender, EventArgs e)
    {
       
        if (Session["Perfil"] != null)
        {
            Usuario usu = (Usuario)Session["Perfil"];
            if (usu.Perfil == "admin")
            {
                MasterPageFile = "MasterPageAdmin.master";
            }
            else if (usu.Perfil == "compras")
            {
                MasterPageFile = "MasterPageSetorCompra.master";

            }
            else if (usu.Perfil == "operario")
            {
                MasterPageFile = "MasterPageOperario.master";
            }
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
