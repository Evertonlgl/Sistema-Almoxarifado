using Comum.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PGOrdemCompra : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            DataSet ds = OrdemCompraDB.SelectAllCompra();
            ddlProdutos();
            btEfetuacompra.Visible = false;
        }

    }

    private void ddlProdutos()
    {
        DataSet dados = ProdutoDB.SelectAllprodutos();
        Funcoes.CarregaDdlDs(ddlProduto, dados, "pro_nome", "pro_upc");
    }



    protected void btVisualiza_Click(object sender, EventArgs e)
    {
       
        Produto pt =  OrdemCompraDB.SelectPreco(Convert.ToInt64(ddlProduto.SelectedItem.Value));
        double preco = pt.Preco;
        int quantidade = Convert.ToInt32(txtQtd.Text);
        lblUpc.Text = ddlProduto.SelectedItem.Value;
        lblValor.Text = Convert.ToString(preco * quantidade);
        btEfetuacompra.Visible = true;

    }

    protected void btEfetuacompra_Click(object sender, EventArgs e)
    {
        OrdemCompra compra = new OrdemCompra();
        Usuario user = (Usuario)Session["Perfil"];

        compra.Nome = ddlProduto.SelectedItem.Text;
        compra.Upc = Convert.ToInt64(ddlProduto.SelectedItem.Value);
        compra.Cpf = user.Cpf;
        compra.Valor = Convert.ToDouble(lblValor.Text);
        compra.Quantidade = Convert.ToInt32(txtQtd.Text);
        compra.Status = 1;

        
        switch (OrdemCompraDB.CompraInsert(compra))
        {
            case 0:

              
              txtQtd.Text = "";
              lblValor.Text = "";
              lblUpc.Text = "";
              
              Response.Write("<script language='javascript'>alert('Compra Concluida!');</script>");
                


                break;

            case -2:

                Response.Write("<script language='javascript'>alert('Erro ao inserir nova Compra!');</script>");

                break;


        }
    }
}