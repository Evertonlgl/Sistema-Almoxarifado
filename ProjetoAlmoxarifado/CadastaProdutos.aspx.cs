using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Comum.Funcoes;
using System.Data;

public partial class CadastaProdutos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            
           
        }
    }
    protected void btCadastrar_Click(object sender, EventArgs e)
    {
        Produto produto = new Produto();

        produto.Nome = txtNome.Text;
        produto.Upc = Convert.ToInt64(txtUpc.Text);
        produto.Preco = Convert.ToDouble(txtPreco.Text);

        switch (ProdutoDB.ProdutoInsert(produto))
        {
            case 0:

                Response.Write("<script language='javascript'>alert('Cadastro efetuado com sucesso!');</script>");


                txtNome.Text = "";
                txtPreco.Text = "";
                txtUpc.Text = "";
                break;

            case -2:

                Response.Write("<script language='javascript'>alert('Erro ao inserir novo produto!');</script>");

                break;


        }
    }

    
}