using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PopImpressao : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ViewState["idcompra"] = Convert.ToInt32(Session["iDcompra"]);
        Impressao();
    }



    public void Impressao()
    {

       
        DataSet ds = RecepcaoDB.SelectinfoPedido(Convert.ToInt32(ViewState["idcompra"]));
        int qtd = ds.Tables[0].Rows.Count;

        if (qtd > 0)
        {
            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                lblNome.Text = Convert.ToString(ds.Tables[0].Rows[0]["aqu_nome"]);
                lblUpc.Text = Convert.ToString(ds.Tables[0].Rows[0]["pro_produto_pro_upc"]);
                lblvaloruni.Text = Convert.ToString(ds.Tables[0].Rows[0]["aqu_valor"]);
                lblqtd.Text = Convert.ToString(ds.Tables[0].Rows[0]["aqu_quantidade"]);
                lbltotal.Text = Convert.ToString(Convert.ToDouble(lblvaloruni.Text) * Convert.ToDouble(lblqtd.Text));


            }
        }
        lblNpedido.Text = Convert.ToString(ViewState["idcompra"]);

    }

}