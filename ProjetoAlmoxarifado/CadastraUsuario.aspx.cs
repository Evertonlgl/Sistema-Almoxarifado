using Comum.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CadastraUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            
        }
    }
    protected void btConlcluir_Click(object sender, EventArgs e)
    {
        Usuario user = new Usuario();

        user.Nome = txtNomeUsu.Text;
        user.Cpf = Convert.ToInt64(txtCpf.Text);
        user.Senha = Funcoes.GetSHA256(txtSenha.Text);
        user.Cidade = txtCidadeUsu.Text;
        user.Estado = ddlEstado.Text;
        user.Bairro = txtBairroUsu.Text;
        user.Rua = txtRua.Text;
        user.Numero = Convert.ToInt32(txtNumeroUsu.Text);
        user.Telefone = Convert.ToInt64(txtTelefoneUsu.Text);
        user.Perfil = ddlArea.Text;

        switch (UsuarioDB.UsuInsert(user))
        {
            case 0:

                Response.Write("<script language='javascript'>alert('Cadastro efetuado com sucesso!!');</script>");
                break;

            case -2:

                Response.Write("<script language='javascript'>alert('Erro ao inserir novo Cadastro!!');</script>");

                break;


        }
    }
}