using Comum.Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Comum.Funcoes;
using System.Data;


public partial class CadastraEmpresa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            
        }
    }
    protected void btCadastrar_Click(object sender, EventArgs e)
    {
        Empresa empresa = new Empresa();

        empresa.Nome = txtNome.Text;
        empresa.Cnpj = Convert.ToInt64(txtCnpj.Text);
        empresa.Senha = Funcoes.GetSHA256(Convert.ToString(txtNome.Text));
        empresa.Email = txtEmail.Text;
        empresa.Cidade = txtCidade.Text;
        empresa.Rua = txtRua.Text;
        empresa.Estado = ddlEstado.Text;
        empresa.Bairro = txtBairro.Text;
        empresa.Numero = Convert.ToInt32(txtNumero.Text);
        empresa.Telefone = Convert.ToInt64(txtTelefone.Text);

        switch (EmpresaDB.EmpInsert(empresa))
        {
            case 0:

                Response.Write("<script language='javascript'>alert('Cadastro efetuado com sucesso!!');</script>");

        txtNome.Text = ""; 
        txtCnpj.Text = "";
        txtNome.Text = "";
        txtEmail.Text = "";
        txtEmail.Text = "";
        txtCidade.Text = "";
        txtRua.Text = "";
        txtBairro.Text = "";
        txtNumero.Text = "";
        txtTelefone.Text = "";

                break;

            case -2:

                Response.Write("<script language='javascript'>alert('Erro ao inserir novo Cadastro!!');</script>");

                break;


        }
    }
}