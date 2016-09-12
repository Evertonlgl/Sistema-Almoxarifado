using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UsuarioDB
/// </summary>
public class UsuarioDB
{
    public int UsuarioUpdate(Usuario usuario)
    {

        int retornar = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommando;
            string sql = "UPDATE usu_usuario SET   ?usu_nome , ?usu_telefone , ?usu_cidade, ?usu_bairro , ?usu_estado , ?usu_numero , ?usu_senha ,?usu_perfil);";
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command(sql, objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?usu_nome", usuario.Nome));
            objCommando.Parameters.Add(Mapped.Parameter("?usu_telefone", usuario.Telefone));
            objCommando.Parameters.Add(Mapped.Parameter("?usu_cidade", usuario.Cidade));
            objCommando.Parameters.Add(Mapped.Parameter("?usu_bairro", usuario.Bairro));
            objCommando.Parameters.Add(Mapped.Parameter("?usu_estado", usuario.Estado));
            objCommando.Parameters.Add(Mapped.Parameter("?usu_numero", usuario.Numero));
            objCommando.Parameters.Add(Mapped.Parameter("?usu_senha", usuario.Senha));
            objCommando.Parameters.Add(Mapped.Parameter("?usu_perfil", usuario.Perfil));
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


    public static int UsuInsert(Usuario usuario)
    {

        int retornar = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommando;
            string sql = "INSERT INTO usu_usuario VALUES (?usu_cpf, ?usu_nome , ?usu_telefone ,?usu_rua, ?usu_cidade  ,?usu_bairro , ?usu_estado , ?usu_numero , ?usu_senha ,?usu_perfil);";
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command(sql, objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?usu_cpf", usuario.Cpf));
            objCommando.Parameters.Add(Mapped.Parameter("?usu_nome", usuario.Nome));
            objCommando.Parameters.Add(Mapped.Parameter("?usu_telefone", usuario.Telefone));
            objCommando.Parameters.Add(Mapped.Parameter("?usu_cidade", usuario.Cidade));
            objCommando.Parameters.Add(Mapped.Parameter("?usu_bairro", usuario.Bairro));
            objCommando.Parameters.Add(Mapped.Parameter("?usu_estado", usuario.Estado));
            objCommando.Parameters.Add(Mapped.Parameter("?usu_rua", usuario.Rua));
            objCommando.Parameters.Add(Mapped.Parameter("?usu_numero", usuario.Numero));
            objCommando.Parameters.Add(Mapped.Parameter("?usu_senha", usuario.Senha));
            objCommando.Parameters.Add(Mapped.Parameter("?usu_perfil", usuario.Perfil));
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

    public static DataSet UsuarioSelectAll()
    {

        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommando;
        IDataAdapter objAdapter;
        objConexao = Mapped.Connection();
        objCommando = Mapped.Command("SELECT * FROM usu_usuario", objConexao);
        objAdapter = Mapped.Adapter(objCommando);
        objAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommando.Dispose();
        return ds;
    }



    public int DeleteUsuario(int cpf)
    {

        int retornar = 0;
        try
        {
            
            IDbConnection objConexao;
            IDbCommand objCommando;
            string sql = "DELETE FROM usu_usuario WHERE usu_cpf = ?cpf";
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command(sql , objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?cpf", cpf));
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

    //valida usuario login
    public static Usuario ValidarUsu(string cpf, string senha)
    {

        IDbConnection objConexao;
        IDbCommand objComando;
        IDataReader objReader;
        Usuario usuario = null;

        string sql = "SELECT usu_nome, usu_cpf, usu_senha, usu_perfil from usu_usuario WHERE usu_senha=?senha and usu_cpf=?cpf;";

        objConexao = Mapped.Connection();
        objComando = Mapped.Command(sql, objConexao);

        objComando.Parameters.Add(Mapped.Parameter("?cpf", cpf));
        objComando.Parameters.Add(Mapped.Parameter("?senha", senha));
        objReader = objComando.ExecuteReader();
        while (objReader.Read())
        {
            usuario = new Usuario();
            usuario.Senha = Convert.ToString(objReader["usu_senha"]);
            usuario.Cpf = Convert.ToInt64(objReader["usu_cpf"]);
            usuario.Perfil = Convert.ToString(objReader["usu_perfil"]);
            usuario.Nome = Convert.ToString(objReader["usu_nome"]);
        }

        objConexao.Close();
        objConexao.Dispose();
        objComando.Dispose();

        return usuario;
    }



    // verificando se a existe a senha e cnpj no banco
    public static DataSet SelectComparaUsu(long cpf, string senha)
    {

        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommando;
        IDataAdapter objAdapter;
        objConexao = Mapped.Connection();
        objCommando = Mapped.Command("SELECT * FROM usu_usuario where usu_cpf=?cpf and usu_senha = ?senha ;", objConexao);
        objCommando.Parameters.Add(Mapped.Parameter("?cpf", cpf));
        objCommando.Parameters.Add(Mapped.Parameter("?senha", senha));
        objAdapter = Mapped.Adapter(objCommando);
        objAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommando.Dispose();
        return ds;
    }


    // atualiza nova senha do usuario
    public static int UpdadeSenhaUsu(Usuario usu)
    {

        int retornar = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommando;
            string sql = "UPDATE usu_usuario SET usu_senha=?senha WHERE usu_cpf=?cpf;";
            objConexao = Mapped.Connection();
            objCommando = Mapped.Command(sql, objConexao);
            objCommando.Parameters.Add(Mapped.Parameter("?cpf", usu.Cpf));
            objCommando.Parameters.Add(Mapped.Parameter("?senha", usu.Senha));
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