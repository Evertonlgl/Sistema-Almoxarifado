using System;
using Comum.Funcoes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class PgAlteraSenhaEmpresa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btConfirma_Click(object sender, EventArgs e)
    {
        Empresa emp = new Empresa();



        DataSet ds = EmpresaDB.SelectCompara(Convert.ToInt64(txtCnpjLogin.Text), Funcoes.GetSHA256(Convert.ToString(txtSenha.Text)));
        int qtd = ds.Tables[0].Rows.Count;

        if (qtd == 1)
        {
            emp.Cnpj = Convert.ToInt64(txtCnpjLogin.Text);
            emp.Senha = Funcoes.GetSHA256(Convert.ToString(txtNovasenha.Text));

            if (txtConfirma.Text.Equals(txtNovasenha.Text))
            {
                switch (EmpresaDB.UpdadeSenhaEmp(emp))
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
                Response.Write("<script language='javascript'>alert('Confirmação incorreta!');</script>");
            }

        }
        else
        {
            Response.Write("<script language='javascript'>alert('CNPJ ou senha Incorretos');</script>");
        }



    }





}