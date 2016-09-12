using Comum.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PgPedidoExterno : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DataSet dsProduto = ProdutoDB.SelectAllprodutos();
            Funcoes.CarregaDdlDs(ddlProduto, dsProduto, "pro_nome", "pro_upc");
        }

    }
   
   
    protected void btPedido_Click(object sender, EventArgs e)
    {
        Pedido pedido = new Pedido();
        Empresa emp = (Empresa)Session["EMPRESA"];

        pedido.Data = DateTime.Now;
        pedido.Upc = Convert.ToInt64(ddlProduto.SelectedItem.Value);
        pedido.Cnpj = emp.Cnpj;
        pedido.Cpf = 0; 
        pedido.Quantidade = Convert.ToInt32(txtQtd.Text);
        pedido.Ativo = 1;

        switch (PedidoDB.PedidoInsert(pedido))
        {
            case 0:

                Response.Write("<script language='javascript'>alert('Pedido Concluido!');</script>");
                break;

            case -2:

                Response.Write("<script language='javascript'>alert('Erro ao inserir novo Pedido!');</script>");

                break;


        }
    }
}
