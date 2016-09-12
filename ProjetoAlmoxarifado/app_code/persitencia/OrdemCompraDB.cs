using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for OrdemCompraDB
/// </summary>
public class OrdemCompraDB
{
	
    public int CompraUpdate(OrdemCompra compra)
    {

        int retornar = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommando;
            string sql = "UPDATE aqu_aquisicao SET   ?aqu_nome ,?aqu_upc , ?aqu_quantidade ,?aqu_valor , ?pro_ativo);";

            objConexao = Mapped.Connection();
            objCommando = Mapped.Command(sql, objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?aqu_nome", compra.Upc));
            objCommando.Parameters.Add(Mapped.Parameter("?aqu_upc", compra.Upc));
            objCommando.Parameters.Add(Mapped.Parameter("?aqu_quantidade", compra.Quantidade));
            objCommando.Parameters.Add(Mapped.Parameter("?aqu_valor", compra.Valor));
            objCommando.Parameters.Add(Mapped.Parameter("?aqu_ativo", compra.Status));
            objCommando.ExecuteNonQuery();
            objConexao.Close();
            objConexao.Dispose();
            objCommando.Dispose();


        }
        catch (Exception e)
        {
            retornar = 2;

        }
        return retornar;

    }


    public static int CompraInsert(OrdemCompra compra)
    {

        int retornar = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommando;
            string sql = "INSERT INTO aqu_aquisicao(aqu_nome, aqu_quantidade ,aqu_valor ,aqu_ativo ,aqu_cpf ,pro_produto_pro_upc) VALUES (?aqu_nome , ?aqu_quantidade ,?aqu_valor ,?aqu_ativo ,?aqu_cpf, ?pro_produto_pro_upc);";
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command(sql, objConexao);

            objCommando.Parameters.Add(Mapped.Parameter("?aqu_nome", compra.Nome));
            objCommando.Parameters.Add(Mapped.Parameter("?aqu_quantidade", compra.Quantidade));
            objCommando.Parameters.Add(Mapped.Parameter("?aqu_valor", compra.Valor));
            objCommando.Parameters.Add(Mapped.Parameter("?aqu_cpf", compra.Cpf));
            objCommando.Parameters.Add(Mapped.Parameter("?aqu_ativo", compra.Status));
            objCommando.Parameters.Add(Mapped.Parameter("?pro_produto_pro_upc", compra.Upc));

            objCommando.ExecuteNonQuery();
            objConexao.Close();
            objConexao.Dispose();
            objCommando.Dispose();

        }
        catch (Exception e)
        {
                retornar = -2;

        }
        return retornar;

    }

    public static DataSet SelectAllCompra()
    {

        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommando;
        IDataAdapter objAdapter;
        objConexao = Mapped.Connection();
        objCommando = Mapped.Command("SELECT * FROM aqu_aquisicao", objConexao);
        objAdapter = Mapped.Adapter(objCommando);
        objAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommando.Dispose();
        return ds;
    }


    


   
    public static OrdemCompra SelectCompra(int ordemcompra)
    {

        try
        {
            OrdemCompra Objcompra = null;
            IDbConnection objConexao;
            IDbCommand objCommando;
            IDataReader ObjDataReader;
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command("SELECT * FROM aqu_aquisicao WHERE aqu_id = ?aquisicao", objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?aquisicao", ordemcompra));
            ObjDataReader = objCommando.ExecuteReader();
            while (ObjDataReader.Read())
            {


                Objcompra = new OrdemCompra();
                Objcompra.Upc = Convert.ToInt32(ObjDataReader["aqu_upc"]);
                Objcompra.Quantidade = Convert.ToInt32(ObjDataReader["aqu_quantidade"]);
                Objcompra.Valor = Convert.ToDouble(ObjDataReader["aqu_valor"]);


                


            }
            ObjDataReader.Close();
            objConexao.Close();
            objConexao.Dispose();
            objCommando.Dispose();
            ObjDataReader.Dispose();

            return Objcompra;
        }
        catch (Exception e)
        {
            return null;

        }

    }



    public int Deletecompra(int compraid)
    {

        int retornar = 0;
        try
        {
            
            IDbConnection objConexao;
            IDbCommand objCommando;
            string sql = "DELETE FROM aqu_aquisicao WHERE aqu_id = ?compraid";
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command(sql , objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?compraid",compraid ));
            objCommando.ExecuteNonQuery();
            objConexao.Close();
            objConexao.Dispose();
            objCommando.Dispose();
           

            
        }
        catch (Exception e)
        {
            retornar = 2;

        }

        return retornar;

    }

    public static void CarregaDdlDs(DropDownList ddl, DataSet dados, String textfield, String valortxt)
    {
        ddl.DataSource = dados;
        ddl.DataTextField = textfield;
        ddl.DataValueField = valortxt;
        ddl.DataBind();
        ddl.Items.Insert(0, "");

    }

    public static Produto SelectPreco(long upc)
    {

        try
        {
            Produto ObjProduto = null;
            IDbConnection objConexao;
            IDbCommand objCommando;
            IDataReader ObjDataReader;
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command("SELECT * FROM pro_produto WHERE pro_upc = ?upc", objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?upc", upc));
            ObjDataReader = objCommando.ExecuteReader();
            while (ObjDataReader.Read())
            {


                ObjProduto = new Produto();
                ObjProduto.Preco = Convert.ToDouble(ObjDataReader["pro_preco"]);




            }
            ObjDataReader.Close();
            objConexao.Close();
            objConexao.Dispose();
            objCommando.Dispose();
            ObjDataReader.Dispose();

            return ObjProduto;
        }
        catch (Exception e)
        {
            return null;

        }

    }
}