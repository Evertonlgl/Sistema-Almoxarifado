using Comum.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PgVisualizaPedidosEmp : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {


        Empresa emp = (Empresa)Session["EMPRESA"];
        DataSet ds = PedidoDB.SelectEmpresaUnico(emp.Cnpj);
        Funcoes.Carregargrid(ds, gdvPedido, lblMenssagem);


    }




    protected void btnCancela_Click(object sender, EventArgs e)
    {

        GridViewRow gvRow = (GridViewRow)(sender as Control).Parent.Parent;
        int index = Convert.ToInt32(gvRow.Cells[0].Text);


        switch (PedidoDB.DeletePedido(index))
        {
            case 0 :
               Response.Write("<script language='javascript'>alert('Concluido cancelamento !');</script>");
               Response.Redirect("PgVisualizaPedidosEmp.aspx");
                break;

            case -2:
                Response.Write("<script language='javascript'>alert('Erro tente novamente !');</script>");
                break;
        }

        
    }



    protected void gdvPedido_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Boolean Ativo = Convert.ToBoolean(e.Row.Cells[6].Text);

            Button btnCalncela = (Button)e.Row.Cells[0].FindControl("btnCancela");
            if (Ativo != true)
            {
                btnCalncela.Visible = false;
            }
        }




    }
}