using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for usuarios
/// </summary>
public class Usuario
{
    private long _cpf;
    private String _senha;
    private String _nome;
    private String _cidade;
    private int _numero;
    private String _bairro;
    private long _telefone;
    private String _estado;
    private String _perfil;
    private String _rua;


    public String Rua
    {
        get { return _rua; }
        set { _rua = value; }
    }

    public String Perfil
    {
        get { return _perfil; }
        set { _perfil = value; }
    }


    public String Estado
    {
        get { return _estado; }
        set { _estado = value; }
    }

    public long Telefone
    {
        get { return _telefone; }
        set { _telefone = value; }
    }



    public String Senha
    {
     get { return _senha; }
     set { _senha = value; }
    }


    public String Cidade
    {
        get { return _cidade; }
        set { _cidade = value; }
    }

    public String Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public long Cpf
    {
        get { return _cpf; }
        set { _cpf = value; }
    }

    public String Bairro
    {
        get { return _bairro; }
        set { _bairro = value; }
    }


    public int Numero
    {
        get { return _numero; }
        set { _numero = value; }
    }

}