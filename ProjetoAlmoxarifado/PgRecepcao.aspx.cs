using Comum.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PgRecepcao : System.Web.UI.Page
{
    public int StatusCompra;
    public int calculototal;
    public int RecetaculoId;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            //DataSet ds = RecepcaoDB.Selectreceptaculo();
            //Funcoes.Carregargrid(ds, gdvReceptaculos, lblMensagem);



        }
    }




    private void CarregarCriterios()
    {
        DataSet ds = RecepcaoDB.SelectinfoPedido(Convert.ToInt32(txtIdcompra.Text));
        int qtd = ds.Tables[0].Rows.Count;

        if (qtd > 0)
        {
            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                lblNomeProd.Text = Convert.ToString(ds.Tables[0].Rows[0]["aqu_nome"]);
                lblUsunome.Text = Convert.ToString(ds.Tables[0].Rows[0]["usu_nome"]);
                lblupc.Text = Convert.ToString(ds.Tables[0].Rows[0]["pro_produto_pro_upc"]);
                lblvalor.Text = Convert.ToString(ds.Tables[0].Rows[0]["aqu_valor"]);
                lblqt.Text = Convert.ToString(ds.Tables[0].Rows[0]["aqu_quantidade"]);
                lblPendente.Text = Convert.ToString(ds.Tables[0].Rows[0]["aqu_pendente"]);
                StatusCompra = Convert.ToInt32(ds.Tables[0].Rows[0]["aqu_ativo"]);

            }
        }

        // compara para saber se o pedido já fo concluido
        if (StatusCompra != 0)
        {
            DataSet rds = RecepcaoDB.SelectReceptaculoddl(Convert.ToInt64(lblupc.Text));
            Funcoes.CarregaDdlDs(ddlReceptaculos, rds, "rec_id", "total");
        }
        else
        {

            Response.Write("<script language='javascript'>alert('ESTE PEDIDO FOI CONFIRMADO OU SUSPENSO!');</script>");
            btConfirma.Visible = false;

        }


    }


    protected void btVisualizaordem_Click(object sender, EventArgs e)
    {

        RecepcaoDB.SelectinfoPedido(Convert.ToInt32(txtIdcompra.Text));
        CarregarCriterios();

    }




    protected void btConfirma_Click(object sender, EventArgs e)
    {

        Recepcao recp = new Recepcao();

        if ((Convert.ToInt32(txtpendente.Text) != 0))
        {
            recp.Pendente = Convert.ToInt32(txtpendente.Text);
            recp.Status = 1;
        }
        else
        {
            recp.Pendente = 0;
            recp.Status = 0;
        }

        recp.Upc = Convert.ToInt64(lblupc.Text);
        recp.Quantidade = Convert.ToInt32(ViewState["TotalCompra"]);

        switch (RecepcaoDB.RecepcaoUpdate(recp, Convert.ToInt32(ViewState["IdReceptaculo"]), Convert.ToInt32(txtIdcompra.Text)))
        {
            case 0:

                Response.Write("<script language='javascript'>alert('Armazenagem Concluida!');</script>");
                txtIdcompra.Text = "";
                txtpendente.Text = "";
                txtQtda.Text = "";

                break;

            case -2:

                Response.Write("<script language='javascript'>alert('Erro ao inserir Armazenagem!');</script>");

                break;


        }
        switch (Funcoes.UpdateProdutoTotal(Convert.ToInt64(lblupc.Text)))
        {
            case -2:
                Response.Write("<script language='javascript'>alert('Erro ao Atualizar banco !');</script>");

                break;
        }
    }




    protected void ddlReceptaculos_SelectedIndexChanged(object sender, EventArgs e)
    {
        int qtdDB;
        int qtdCompra;


        if (!String.IsNullOrEmpty(ddlReceptaculos.Text))
        {
            string[] pegar_qtd = ddlReceptaculos.SelectedValue.Split('-');
            if (pegar_qtd != null)
            {
                //Response.Write("Quantidade do receptáculo "+pegar_qtd[0]+": "+pegar_qtd[1]);

                RecetaculoId = Convert.ToInt32(pegar_qtd[0]);
                qtdDB = Convert.ToInt32(pegar_qtd[1]);
                qtdCompra = Convert.ToInt32(lblqt.Text);


                if (qtdDB + qtdCompra <= 100)
                {

                    Response.Write(qtdDB + qtdCompra);
                    if (String.IsNullOrEmpty(txtpendente.Text))
                        txtpendente.Text = "0";
                    calculototal = qtdDB + qtdCompra - (Convert.ToInt32(txtpendente.Text));
                    lblDisponivies.Text = "sim";
                    btConfirma.Visible = true;
                }
                else
                {
                    lblDisponivies.Text = "não há espaço disponivel para todo conteudo adicione em outro recptaculo";
                    btConfirma.Visible = false;
                }
            }

        }

        ViewState["TotalCompra"] = calculototal;
        ViewState["IdReceptaculo"] = RecetaculoId;
    }




}
