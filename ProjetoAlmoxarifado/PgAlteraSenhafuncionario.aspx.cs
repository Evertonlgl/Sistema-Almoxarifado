using Comum.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PgAlteraSenhafuncionario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btConfirma_Click(object sender, EventArgs e)
    {
        Usuario usu = new Usuario();



        DataSet ds = UsuarioDB.SelectComparaUsu(Convert.ToInt64(txtCpfLogin.Text), Funcoes.GetSHA256(Convert.ToString(txtSenha.Text)));
        int qtd = ds.Tables[0].Rows.Count;

        if (qtd == 1)
        {
            usu.Cpf = Convert.ToInt64(txtCpfLogin.Text);
            usu.Senha = Funcoes.GetSHA256(Convert.ToString(txtNovasenha.Text));

            if (txtConfirma.Text.Equals(txtNovasenha.Text))
            {
                switch (UsuarioDB.UpdadeSenhaUsu(usu))
                {
                    case 0:

                        Response.Write("<script language='javascript'>alert('Alteração Concluida!');</script>");
                        break;

                    case -2:

                        Response.Write("<script language='javascript'>alert('Erro ao Atualizar!');</script>");

                        break;


                }
            }
            else
            {
                Response.Write("<script language='javascript'>alert('Confirmação incorreta');</script>");
            }

        }
        else
        {
            Response.Write ("<script language='javascript'>alert('Cpf ou senha Incorretos');</script>");
        }



    }
}