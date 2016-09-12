using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProdutoDB
/// </summary>
public class ProdutoDB
{
    public static int ProdutoUpdate(Produto produto)
    {

        int retornar = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommando;
            string sql = "UPDATE pro_produto SET   ?pro_nome , ?pro_quantidade , ?pro_pendete, ?pro_preco , ?pro_posicao , ?pro_recepqtd);";





            objConexao = Mapped.Connection();
            objCommando = Mapped.Command(sql, objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?pro_nome", produto.Nome));
            objCommando.Parameters.Add(Mapped.Parameter("?pro_quantidade", produto.Quantidade));
            objCommando.Parameters.Add(Mapped.Parameter("?pro_pendente", produto.Pendente));
            objCommando.Parameters.Add(Mapped.Parameter("?pro_preco", produto.Preco));
            objCommando.Parameters.Add(Mapped.Parameter("?emp_posicao", produto.Posicao));
            objCommando.Parameters.Add(Mapped.Parameter("?emp_recepqtd", produto.Receptaculoquantidade));
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


    public static int ProdutoInsert(Produto produto)
    {

        int retornar = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommando;
            string sql = "INSERT INTO pro_produto(pro_upc, pro_nome ,pro_preco) VALUES (?pro_upc, ?pro_nome ,?pro_preco );";
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command(sql, objConexao);

            objCommando.Parameters.Add(Mapped.Parameter("?pro_upc", produto.Upc));
            objCommando.Parameters.Add(Mapped.Parameter("?pro_nome", produto.Nome));
            objCommando.Parameters.Add(Mapped.Parameter("?pro_preco", produto.Preco));

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

    public static DataSet SelectAllprodutos()
    {

        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommando;
        IDataAdapter objAdapter;
        objConexao = Mapped.Connection();
        objCommando = Mapped.Command("SELECT * FROM pro_produto", objConexao);
        objAdapter = Mapped.Adapter(objCommando);
        objAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommando.Dispose();
        return ds;
    }


   
    public static Produto SelectProdutos(long upc)
    {

        try
        {
            Produto ObjProduto = null;
            IDbConnection objConexao;
            IDbCommand objCommando;
            IDataReader ObjDataReader;
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command("SELECT * FROM pro_produto WHERE pro_upc = ?upc;", objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?upc", upc));
            ObjDataReader = objCommando.ExecuteReader();
            while (ObjDataReader.Read())
            {
                ObjProduto = new Produto();
                ObjProduto.Upc = Convert.ToInt64(ObjDataReader["pro_upc"]);
                ObjProduto.Nome = Convert.ToString(ObjDataReader["pro_nome"]);
                ObjProduto.Quantidade = Convert.ToInt32(ObjDataReader["pro_quantidade"]);
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



    public int DeleteProduto(int upc)
    {

        int retornar = 0;
        try
        {
            
            IDbConnection objConexao;
            IDbCommand objCommando;
            string sql = "DELETE FROM pro_prodoto WHERE pro_upc = ?upc";
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command(sql , objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?upc", upc));
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

    //passa a quantidade total de produto para tabela
    public static int PUpdateQtd(int qtd, long upc)
    {

        int retornar = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommando;
            string sql = "UPDATE pro_produto SET  pro_quantidade=?pro_quantidade WHERE pro_upc=?pro_upc;";
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command(sql, objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?pro_quantidade", qtd));
            objCommando.Parameters.Add(Mapped.Parameter("?pro_upc", upc));
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



}