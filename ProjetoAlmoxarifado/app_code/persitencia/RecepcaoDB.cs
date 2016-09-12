using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RecepcaoDB
/// </summary>
public class RecepcaoDB
{

 
    public static int RecepcaoUpdate(Recepcao recebe, int recepID , int aquisicaoID)
    {

        int retornar = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommando;
            string sql = "update aqu_aquisicao a, rec_receptaculo r set";
            sql += " a.aqu_pendente= ?aqu_pendente , a.aqu_ativo = ?aqu_ativo ,r.rec_quantidade = ?rec_quantidade ,r.rec_upc =?rec_upc ";
            sql +=" where r.rec_id = ?recepID and a.aqu_id = ?aquisicaoID;";

            //recp.Quantidade = total;
            //recp.Status = 0;
            //recp.Upc = Convert.ToInt64(lblupc.Text);
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command(sql, objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?aqu_pendente", recebe.Pendente));
            objCommando.Parameters.Add(Mapped.Parameter("?aqu_ativo", recebe.Status));
            objCommando.Parameters.Add(Mapped.Parameter("?rec_quantidade", recebe.Quantidade));
            objCommando.Parameters.Add(Mapped.Parameter("?rec_upc", recebe.Upc));
            objCommando.Parameters.Add(Mapped.Parameter("?recepID", recepID));
            objCommando.Parameters.Add(Mapped.Parameter("?aquisicaoID", aquisicaoID));

            objCommando.ExecuteNonQuery();
            objConexao.Close();
            objConexao.Dispose();
            objCommando.Dispose();


        }
        catch (Exception e)
        {
            return retornar = -2;

        }
        return retornar;

    }




    public DataSet SelectAllOrdemcompra()
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

    public static DataSet Selectreceptaculo()
    {

        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommando;
        IDataAdapter objAdapter;
        objConexao = Mapped.Connection();
        objCommando = Mapped.Command("SELECT * FROM rec_receptaculo", objConexao);
        objAdapter = Mapped.Adapter(objCommando);
        objAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommando.Dispose();
        return ds;
    }

    public static Produto SelectProdutoNome(long upc)
    {

        try
        {
            Produto ObjProduto = null;
            IDbConnection objConexao;
            IDbCommand objCommando;
            IDataReader ObjDataReader;
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command("SELECT pro_nome FROM pro_produto WHERE pro_upc = ?upc", objConexao);
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


    public static Produto receptaculo(long upc)
    {

        try
        {
            Produto ObjProduto = null;
            IDbConnection objConexao;
            IDbCommand objCommando;
            IDataReader ObjDataReader;
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command("SELECT * FROM pro_produto WHERE pro_upc = ?upc and ?upc = null", objConexao);
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


 


    // busca todas as informações referente ao pedido

    public static DataSet SelectinfoPedido(int pedidoId)
    {

        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommando;
        IDataAdapter objAdapter;
        objConexao = Mapped.Connection();
        string sql = "select a.aqu_nome ,u.usu_nome , a.pro_produto_pro_upc, a.aqu_quantidade, a.aqu_valor, a.aqu_pendente, a.aqu_ativo from aqu_aquisicao a ";
        sql += "inner join usu_usuario u on a.aqu_cpf = u.usu_cpf where aqu_id = ?pedidoId";
        objCommando = Mapped.Command(sql, objConexao);
        objCommando.Parameters.Add(Mapped.Parameter("?pedidoId", pedidoId));
        objAdapter = Mapped.Adapter(objCommando);
        objAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommando.Dispose();
        return ds;
    }

// seleciona receptaculo mais a quantidade 
    public static DataSet SelectReceptaculoddl(long upc)
    {

        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommando;
        IDataAdapter objAdapter;
        objConexao = Mapped.Connection();
        string sql = "select *, convert(concat_ws('-', rec_id, rec_quantidade),char) as total from rec_receptaculo  where rec_quantidade < 100 and rec_upc = ?upc or rec_upc is null ;";
        objCommando = Mapped.Command(sql, objConexao);
        objCommando.Parameters.Add(Mapped.Parameter("?upc", upc));
        objAdapter = Mapped.Adapter(objCommando);
        objAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommando.Dispose();
        return ds;
    }


    public static int Produtoatuzlizar(Produto produto)
    {

        int retornar = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommando;
            string sql = "UPDATE pro_produto SET   ?pro_quantidade , ?pro_pendete WHERE pro_upc=?pro_upc ;";
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command(sql, objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?pro_quantidade", produto.Quantidade));
            objCommando.Parameters.Add(Mapped.Parameter("?pro_pendente", produto.Pendente));
            objCommando.Parameters.Add(Mapped.Parameter("?pro_upc", produto.Upc));
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

    //  seleciona o valor total do receptaculo
    public static int SelecTotal(long upc)
    {

        try
        {
            int total= 0;
            IDbConnection objConexao;
            IDbCommand objCommando;
            IDataReader ObjDataReader;
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command("select SUM(rec_quantidade) FROM rec_receptaculo where  rec_upc = ?upc;", objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?upc", upc));
            ObjDataReader = objCommando.ExecuteReader();
            while (ObjDataReader.Read())
            {

                total = Convert.ToInt32(ObjDataReader["SUM(rec_quantidade)"]);
                


            }
            ObjDataReader.Close();
            objConexao.Close();
            objConexao.Dispose();
            objCommando.Dispose();
            ObjDataReader.Dispose();

            return total;
        }
        catch (Exception e)
        {
            return 0;

        }
    }

    // Atualiza os valores da retirada do pedido no banco
    public static int SaidaUpdate(int pedidoid ,int totalqtd, int rcpid ,long upc, int qtdrcp)
    {

        int retornar = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommando;
            string sql = "Update ped_pedido SET ped_ativo = 0 WHERE ped_id=?pedid; ";
            sql += "Update rec_receptaculo SET rec_quantidade = ?qtdrcp WHERE rec_id = ?recid;";
            sql += "Update pro_produto c SET pro_quantidade = ?qtdprod WHERE pro_upc = ?IDproduto;";
            sql += "Update rec_receptaculo SET rec_upc = null  WHERE rec_id =?recid and rec_quantidade <=0  ;";


            objConexao = Mapped.Connection();
            objCommando = Mapped.Command(sql, objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?pedid", pedidoid));
            objCommando.Parameters.Add(Mapped.Parameter("?qtdprod", totalqtd));
            objCommando.Parameters.Add(Mapped.Parameter("?qtdrcp", qtdrcp));
            objCommando.Parameters.Add(Mapped.Parameter("?recid", rcpid));
            objCommando.Parameters.Add(Mapped.Parameter("?IDproduto", upc));

            objCommando.ExecuteNonQuery();
            objConexao.Close();
            objConexao.Dispose();
            objCommando.Dispose();


        }
        catch (Exception e)
        {
            return retornar = -2;

        }
        return retornar;

    }

    public static int QuantidadeRecep(int rcpId)
    {

        try
        {
            int quantidadedoreceptaculo = 0;
            IDbConnection objConexao;
            IDbCommand objCommando;
            IDataReader ObjDataReader;
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command("SELECT rec_quantidade FROM rec_receptaculo WHERE rec_id = ?rcpId", objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?rcpId", rcpId));
            ObjDataReader = objCommando.ExecuteReader();
            while (ObjDataReader.Read())
            {
                
                quantidadedoreceptaculo = Convert.ToInt32(ObjDataReader["rec_quantidade"]);
                


            }
            ObjDataReader.Close();
            objConexao.Close();
            objConexao.Dispose();
            objCommando.Dispose();
            ObjDataReader.Dispose();

            return quantidadedoreceptaculo;
        }
        catch (Exception e)
        {
            return 0;

        }
    }


   
}

//String sql = "select p.ped_id,p.ped_data ,p.ped_quantidade ,e.emp_nome ,o.pro_nome ,o.pro_upc ,p.ped_ativo, u.usu_nome ";
//sql += "FROM ped_pedido p inner join emp_empresa e on p.emp_empresa_emp_cnpj = e.emp_cnpj inner join pro_produto o on p.pro_produto_pro_upc = o.pro_upc inner join usu_usuario u on u.usu_cpf = p.ped_cpf where p.ped_id = ?pedidoId;";
