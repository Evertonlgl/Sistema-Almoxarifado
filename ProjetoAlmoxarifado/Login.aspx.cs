using Comum.Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetNoStore();
        txtCnpjLogin.Focus();

    }


    protected void btnLogin_Click(object sender, EventArgs e)
    {



        int opc = Convert.ToInt32(ddlLogin.SelectedValue);
        switch (opc)
        {


            case 0:

                EmpresaDB empresa = new EmpresaDB();
                string senhaE = Funcoes.GetSHA256(txtSenha.Text);
                Empresa emp = EmpresaDB.ValidarEmp(Convert.ToString(txtCnpjLogin.Text), senhaE);

                if (emp != null)
                {

                    Session["Empresa"] = emp;
                    Response.Redirect("PgPedidoExterno.aspx");
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('Usuário e/ou senha incorreto(s)!');</script>");
                }
                break;

            case 1:

                UsuarioDB usuario = new UsuarioDB();
                string senhaU = Funcoes.GetSHA256(txtSenha.Text);
                Usuario usu = UsuarioDB.ValidarUsu(Convert.ToString(txtCnpjLogin.Text), senhaU);

                if (usu != null)
                {
                    if (usu.Perfil == "admin")
                    {
                        Session["Perfil"] = usu;
                        Response.Redirect("AdminVisualizar.aspx");
                    }
                    else if (usu.Perfil == "compras")
                    {
                        Session["Perfil"] = usu;
                        Response.Redirect("PgOrdemCompra.aspx");

                    }
                    else if (usu.Perfil == "operario")
                    {
                        Session["Perfil"] = usu;
                        Response.Redirect("PgRecepcao.aspx");
                    }
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('Usuário e/ou senha incorreto(s)!');</script>");
                }
                break;

            case 3:
                Response.Write("<script language='javascript'>alert('IDENTIFIQUE ACESSO EMPRESA OU ALMOXARIFADO');</script>");
                break;
        }
    }
}
