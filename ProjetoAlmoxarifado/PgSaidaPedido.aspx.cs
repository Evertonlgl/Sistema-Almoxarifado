using Comum.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PgSaidaPedido : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            DataSet ds = PedidoDB.SelectAllPedidoSaida();
            Funcoes.Carregargrid(ds, gdvPedidos, lblMensagem);

            DataSet dlista = PedidoDB.SelectPedidoGrid();
            Funcoes.Carregargrid(dlista, gdvLista, lblPedidolista);

        }
    }




    protected void btSaida_Click(object sender, EventArgs e)
    {
        GridViewRow row = (GridViewRow)(sender as Control).Parent.Parent;
        int pedidoID = Convert.ToInt32(row.Cells[0].Text);
        int recpqtd = Convert.ToInt32(row.Cells[2].Text);
        int recepID = Convert.ToInt32(row.Cells[7].Text);
        long upc = Convert.ToInt64(row.Cells[6].Text);

        switch (Funcoes.Preenchesaida(recpqtd, pedidoID, recepID, upc))
        {
            case 0:
                Response.Redirect(Request.RawUrl, true);
                break;

            case -2:

                Response.Write("Erro ao Efetuar a Saida");
                break;


        }
    }
}