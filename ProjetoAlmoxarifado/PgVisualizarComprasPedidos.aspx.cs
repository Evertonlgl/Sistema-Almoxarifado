using Comum.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PgVisualizarComprasPedidos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet dsemp = PedidoDB.SelectPedidoGrid();
        Funcoes.Carregargrid(dsemp, gdvPedidos, lblPedidos);

        DataSet dsusu = OrdemCompraDB.SelectAllCompra();
        Funcoes.Carregargrid(dsusu, gdvCompras, lblCompras);


    }

    

    protected void btImprimir_Click(object sender, EventArgs e)
    {
        Response.Write("<script language='javascript'>alert('Em Contrução!');</script>");

        GridViewRow gvRow = (GridViewRow)(sender as Control).Parent.Parent;
        int idcompra = Convert.ToInt32(gvRow.Cells[0].Text);

        Session.Add("iDcompra", idcompra);

        ClientScript.RegisterStartupScript(Page.GetType(), "JavaScript", "<script>window.open('PopImpressao.aspx');</script>");
    }
}