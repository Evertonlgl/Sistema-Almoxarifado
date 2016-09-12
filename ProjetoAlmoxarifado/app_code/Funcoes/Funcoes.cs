using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;

namespace Comum.Funcoes
{
    public class Funcoes
    {
        //passa o numero de registro pro dataset
        public static int Qtregistro(DataSet dados)
        {
            return dados.Tables[0].Rows.Count;

        }

        // carrega dataset na grid
        public static void Carregargrid(DataSet dados, GridView gdv, Label lbl)
        {
            int qtd = Qtregistro(dados);
            if (qtd > 0)
            {
                gdv.DataSource = dados.Tables[0].DefaultView;
                gdv.DataBind();
                gdv.Visible = true;
                lbl.Text = "foram encontrados " + qtd + " registros";
            }
            else
            {
                gdv.Visible = false;
                lbl.Text = "Não há registros";
            }
        }

        // passa os dados da ddl
        public static void CarregaDdlDs(DropDownList ddl, DataSet dados, String textfield, String valortxt)
        {
            ddl.DataSource = dados;
            ddl.DataTextField = textfield;
            ddl.DataValueField = valortxt;
            ddl.DataBind();
            ddl.Items.Insert(0, "");

        }

        //atualiza o total de produtos
        public static int UpdateProdutoTotal(long upc)
        {
            int retorno = 0;
            int total = RecepcaoDB.SelecTotal(upc);
            int p = total;

            switch (ProdutoDB.PUpdateQtd(p, upc))
            {
                
                case -2:
                    return retorno = -2;
                    break;

            }

            return retorno;

        }



        //aplica a crip 256
        public static string GetSHA256(string text)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] hashValue;
            byte[] message = UE.GetBytes(text);

            SHA256Managed hashString = new SHA256Managed();
            string hex = "";

            hashValue = hashString.ComputeHash(message);
            foreach (byte x in hashValue)
            {
                hex += String.Format("{0:x2}", x);
            }
            return hex;
        }


        // função preenche a saida
        public static int Preenchesaida(int pedidoQtd, int pedidoID, int receptaculoID, long produtoUPC)
        {
            int retorno = 0;
            Produto prod = ProdutoDB.SelectProdutos(produtoUPC);
            int receptaculoDB = RecepcaoDB.QuantidadeRecep(receptaculoID);

            int clprodtotal = prod.Quantidade - pedidoQtd;
            int clrecptotal = receptaculoDB - pedidoQtd;

            switch (RecepcaoDB.SaidaUpdate(pedidoID, clprodtotal, receptaculoID, produtoUPC, clrecptotal))
            {
                case 0:
                    retorno = 0;
                    break;


                case -2:
                    retorno = -2;
                    break;


            }
            return retorno;
        }





    }





}



