using Comum.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PgPedido : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            DataSet ds = PedidoDB.SelectPedidoGrid();
            ddlDadosPagina();
        }

    }

    private void ddlDadosPagina()
    {
        DataSet dsProduto = ProdutoDB.SelectAllprodutos();
        DataSet dsEmpresa = EmpresaDB.EmpSelectAll();

        Funcoes.CarregaDdlDs(ddlProduto, dsProduto, "pro_nome", "pro_upc");
        Funcoes.CarregaDdlDs(ddlEmpresa, dsEmpresa, "emp_nome", "emp_cnpj");
    }



        
   
    protected void btPedido_Click(object sender, EventArgs e)
    {
        Pedido pedido = new Pedido();
        Usuario user = (Usuario)Session["Perfil"];

        pedido.Data = DateTime.Now;
        pedido.Upc = Convert.ToInt64(ddlProduto.SelectedItem.Value);
        pedido.Cnpj = Convert.ToInt64(ddlEmpresa.SelectedItem.Value);
        pedido.Cpf = user.Cpf;
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
