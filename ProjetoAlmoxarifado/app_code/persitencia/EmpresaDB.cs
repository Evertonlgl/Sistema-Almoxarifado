using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for empresadb
/// </summary>
public class EmpresaDB
{
    public static int EmpUpdate(Empresa empresa)
    {

        int retornar = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommando;
            string sql = "UPDATE emp_empresa SET  ?emp_senha , ?emp_email , ?emp_nome , ?emp_cidade , ?emp_bairro, ?emp_estado , ?emp_numero , ?emp_telefone);";

            objConexao = Mapped.Connection();
            objCommando = Mapped.Command(sql, objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?emp_senha", empresa.Senha));
            objCommando.Parameters.Add(Mapped.Parameter("?emp_email", empresa.Email));
            objCommando.Parameters.Add(Mapped.Parameter("?emp_nome", empresa.Nome));
            objCommando.Parameters.Add(Mapped.Parameter("?emp_cidade", empresa.Cidade));
            objCommando.Parameters.Add(Mapped.Parameter("?emp_bairro", empresa.Bairro));
            objCommando.Parameters.Add(Mapped.Parameter("?emp_estado", empresa.Estado));
            objCommando.Parameters.Add(Mapped.Parameter("?emp_estado", empresa.Numero));
            objCommando.Parameters.Add(Mapped.Parameter("?emp_estado", empresa.Telefone));
            objCommando.ExecuteNonQuery();
            objConexao.Close();
            objConexao.Dispose();
            objCommando.Dispose();


        }
        catch (Exception e)
        {
           return retornar = 2;

        }
        return retornar;

    }


    public static int EmpInsert(Empresa empresa)
    {

        int retornar = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommando;
            string sql = "INSERT INTO emp_empresa VALUES (?emp_cnpj, ?emp_senha, ?emp_email, ?emp_nome, ?emp_cidade ,?emp_rua  ,?emp_bairro, ?emp_estado, ?emp_numero, ?emp_telefone)";
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command(sql, objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?emp_cnpj", empresa.Cnpj));
            objCommando.Parameters.Add(Mapped.Parameter("?emp_senha", empresa.Senha));
            objCommando.Parameters.Add(Mapped.Parameter("?emp_email", empresa.Email));
            objCommando.Parameters.Add(Mapped.Parameter("?emp_nome", empresa.Nome));
            objCommando.Parameters.Add(Mapped.Parameter("?emp_cidade", empresa.Cidade));
            objCommando.Parameters.Add(Mapped.Parameter("?emp_rua", empresa.Rua));
            objCommando.Parameters.Add(Mapped.Parameter("?emp_bairro", empresa.Bairro));
            objCommando.Parameters.Add(Mapped.Parameter("?emp_estado", empresa.Estado));
            objCommando.Parameters.Add(Mapped.Parameter("?emp_numero", empresa.Numero));
            objCommando.Parameters.Add(Mapped.Parameter("?emp_telefone", empresa.Telefone));
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

    public static DataSet EmpSelectAll()
    {

        DataSet ds = new DataSet();
        IDbConnection  objConexao;
        IDbCommand objCommando;
        IDataAdapter objAdapter;
        objConexao = Mapped.Connection();
        objCommando = Mapped.Command("SELECT * FROM emp_empresa", objConexao);
        objAdapter = Mapped.Adapter(objCommando);
        objAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommando.Dispose();
        return ds;
    }



    public  static Empresa SelectEmp(int cnpj)
    {

        try{
            Empresa Objempresa = null;
            IDbConnection objConexao;
            IDbCommand objCommando;
            IDataReader ObjDataReader;
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command("SELECT * FROM emp_empresa WHERE emp_cnpj = ?cnpj", objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?cnpj", cnpj));
            ObjDataReader = objCommando.ExecuteReader();
            while (ObjDataReader.Read())
            {
                Objempresa = new Empresa();
                Objempresa.Cnpj = Convert.ToInt32(ObjDataReader["emp_cnpj"]);
                Objempresa.Senha = Convert.ToString(ObjDataReader["emp_senha"]);
                Objempresa.Email = Convert.ToString(ObjDataReader["emp_email"]);
                Objempresa.Nome = Convert.ToString(ObjDataReader["emp_nome"]);
                Objempresa.Cidade = Convert.ToString(ObjDataReader["emp_cidade"]);
                Objempresa.Bairro = Convert.ToString(ObjDataReader["emp_bairro"]);
                Objempresa.Estado = Convert.ToString(ObjDataReader["emp_estado"]);
                Objempresa.Numero = Convert.ToInt32(ObjDataReader["emp_numero"]);
                Objempresa.Telefone = Convert.ToInt32(ObjDataReader["emp_telefone"]);

                
            }
            ObjDataReader.Close();
            objConexao.Close();
            objConexao.Dispose();
            objCommando.Dispose();
            ObjDataReader.Dispose();

            return Objempresa;
        }
        catch (Exception e)
        {
            return null;

        }
    }

    

    public int DeleteEmp(int cnpj)
    {

        int retornar = 0;
        try
        {
            
            IDbConnection objConexao;
            IDbCommand objCommando;
            string sql = "DELETE FROM emp_empresa WHERE emp_cnpj = ?cnpj";
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command(sql , objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?cnpj", cnpj));
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


    public static Empresa ValidarEmp(string cnpj, string senha)
    {

        IDbConnection objConexao;
        IDbCommand objComando;
        IDataReader objReader;
        Empresa empresa = null;

        string sql = "select emp_nome, emp_cnpj, emp_senha from emp_empresa where emp_senha=?senha and emp_cnpj=?cnpj;";

        objConexao = Mapped.Connection();
        objComando = Mapped.Command(sql, objConexao);

        objComando.Parameters.Add(Mapped.Parameter("?cnpj", cnpj));
        objComando.Parameters.Add(Mapped.Parameter("?senha", senha));
        objReader = objComando.ExecuteReader();
        while (objReader.Read())
        {
            empresa = new Empresa();
            empresa.Senha = Convert.ToString(objReader["emp_senha"]);
            empresa.Cnpj = Convert.ToInt64(objReader["emp_cnpj"]);
            empresa.Nome = Convert.ToString(objReader["emp_nome"]);
        }

        objConexao.Close();
        objConexao.Dispose();
        objComando.Dispose();

        return empresa;
    }


// verificando se a existe a senha e cnpj no banco
    public static DataSet SelectCompara(long cnpj, string senha)
    {

        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommando;
        IDataAdapter objAdapter;
        objConexao = Mapped.Connection();
        objCommando = Mapped.Command("SELECT * FROM emp_empresa where emp_cnpj=?cnpj and emp_senha = ?senha ;", objConexao);
        objCommando.Parameters.Add(Mapped.Parameter("?cnpj", cnpj));
        objCommando.Parameters.Add(Mapped.Parameter("?senha", senha));
        objAdapter = Mapped.Adapter(objCommando);
        objAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommando.Dispose();
        return ds;
    }
// atualiza nova senha 
    public static int UpdadeSenhaEmp(Empresa emp)
    {

        int retornar = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommando;
            string sql = "UPDATE emp_empresa SET emp_senha=?senha WHERE emp_cnpj=?cnpj;";
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command(sql, objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?cnpj", emp.Cnpj));
            objCommando.Parameters.Add(Mapped.Parameter("?senha", emp.Senha));
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