using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PedidoDB
/// </summary>
public class PedidoDB
{


    public static int PedidoInsert(Pedido pedido)
    {

        int retornar = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommando;
            string sql = "INSERT INTO ped_pedido(ped_data ,ped_quantidade ,ped_ativo ,pro_produto_pro_upc ,emp_empresa_emp_cnpj ,ped_cpf) VALUES (?data , ?quantidade , ?ativo , ?upc ,?cnpj , ?cpf);";
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command(sql, objConexao);

            objCommando.Parameters.Add(Mapped.Parameter("?data", pedido.Data));
            objCommando.Parameters.Add(Mapped.Parameter("?quantidade", pedido.Quantidade));
            objCommando.Parameters.Add(Mapped.Parameter("?ativo", pedido.Ativo));
            objCommando.Parameters.Add(Mapped.Parameter("?upc", pedido.Upc));
            objCommando.Parameters.Add(Mapped.Parameter("?cnpj", pedido.Cnpj));
            if(pedido.Cpf !=null)
            objCommando.Parameters.Add(Mapped.Parameter("?cpf", pedido.Cpf));
            else
                objCommando.Parameters.Add(Mapped.Parameter("?cpf", 0));

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

    public static DataSet SelectAllPedido()
    {

        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommando;
        IDataAdapter objAdapter;
        objConexao = Mapped.Connection();
        objCommando = Mapped.Command("SELECT * FROM ped_pedido", objConexao);
        objAdapter = Mapped.Adapter(objCommando);
        objAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommando.Dispose();
        return ds;
    }



    public Pedido SelectPedidosEmp(int cnpj)
    {

        try
        {
            Pedido ObjPedido = null;
            IDbConnection objConexao;
            IDbCommand objCommando;
            IDataReader ObjDataReader;
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command("SELECT * FROM ped_pedido WHERE emp_cnpj = ?cnpj", objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?cnpj", cnpj));
            ObjDataReader = objCommando.ExecuteReader();
            while (ObjDataReader.Read())
            {
                ObjPedido = new Pedido();
                ObjPedido.Id = Convert.ToInt32(ObjDataReader["ped_id"]);
                ObjPedido.Data = Convert.ToDateTime(ObjDataReader["ped_data"]);
                ObjPedido.Quantidade = Convert.ToInt32(ObjDataReader["ped_quantidade"]);
                ObjPedido.Ativo = Convert.ToInt32(ObjDataReader["pet_ativo"]);
                ObjPedido.Upc = Convert.ToInt32(ObjDataReader["pro_upc"]);
                ObjPedido.Cnpj = Convert.ToInt32(ObjDataReader["emp_empresa"]);

            }
            ObjDataReader.Close();
            objConexao.Close();
            objConexao.Dispose();
            objCommando.Dispose();
            ObjDataReader.Dispose();

            return ObjPedido;
        }
        catch (Exception e)
        {
            return null;

        }

        

    }


    // deleta pedido
    public static int DeletePedido(int pedidoid)
    {

        int retornar = 0;
        try
        {
            
            IDbConnection objConexao;
            IDbCommand objCommando;
            string sql = "DELETE FROM ped_pedido WHERE ped_id = ?pedido";
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command(sql , objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?pedido", pedidoid));
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
    // seleciona grid produtos ativos
        public static DataSet SelectPedidoGrid()
          {

        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommando;
        IDataAdapter objAdapter;
        objConexao = Mapped.Connection();
        objCommando = Mapped.Command("select p.ped_id,p.ped_data ,p.ped_quantidade ,e.emp_nome ,o.pro_nome ,o.pro_upc ,p.ped_ativo FROM ped_pedido p inner join emp_empresa e on p.emp_empresa_emp_cnpj = e.emp_cnpj inner join pro_produto o on p.pro_produto_pro_upc = o.pro_upc where ped_ativo !=0 ;", objConexao);
        objAdapter = Mapped.Adapter(objCommando);
        objAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommando.Dispose();
        return ds;
    }

    //Seleciona pedidos de uma unica empresa
        public static DataSet SelectEmpresaUnico(long cnpj)
        {

            DataSet ds = new DataSet();
            IDbConnection objConexao;
            IDbCommand objCommando;
            IDataAdapter objAdapter;
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command("select p.ped_id,p.ped_data ,p.ped_quantidade ,e.emp_nome ,o.pro_nome ,o.pro_upc ,p.ped_ativo FROM ped_pedido p inner join emp_empresa e on p.emp_empresa_emp_cnpj = e.emp_cnpj inner join pro_produto o on p.pro_produto_pro_upc = o.pro_upc where emp_cnpj= ?cnpj order by ped_ativo desc;", objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?cnpj", cnpj));
            objAdapter = Mapped.Adapter(objCommando);
            objAdapter.Fill(ds);
            objConexao.Close();
            objConexao.Dispose();
            objCommando.Dispose();
            return ds;
        }

    //selecionando pedido para grid de saida
        public static DataSet SelectAllPedidoSaida()
        {

            DataSet ds = new DataSet();
            IDbConnection objConexao;
            IDbCommand objCommando;
            IDataAdapter objAdapter;
            String sql = "SELECT ped_id ,ped_data, ped_quantidade, emp_nome, usu_nome, pro_nome, pro_upc , ped_ativo, rec_id ";
            sql += "FROM ped_pedido inner join emp_empresa on emp_cnpj = emp_empresa_emp_cnpj inner join usu_usuario on ped_cpf = usu_cpf or ped_cpf = 0 ";
            sql+= " inner join pro_produto on pro_produto_pro_upc inner join rec_receptaculo where rec_quantidade >= ped_quantidade and ped_ativo = 1 limit 1;";
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command(sql , objConexao);
            objAdapter = Mapped.Adapter(objCommando);
            objAdapter.Fill(ds);
            objConexao.Close();
            objConexao.Dispose();
            objCommando.Dispose();
            return ds;
        }


}