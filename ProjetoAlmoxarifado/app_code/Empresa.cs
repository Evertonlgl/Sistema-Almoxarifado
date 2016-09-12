using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Empresa
/// </summary>
public class Empresa
{
    private long _cnpj;
    private String _senha;
    private String _nome;
    private String _email;
    private String _cidade;
    private String _bairro;
    private String _Estado;
    private String _rua;


    public String Rua
    {
        get { return _rua; }
        set { _rua = value; }
    }
    private int _numero;
    private long _telefone;

    public long Telefone
    {
        get { return _telefone; }
        set { _telefone = value; }
    }

    public String Estado
    {
        get { return _Estado; }
        set { _Estado = value; }
    }

    public long Cnpj
    {
        get { return _cnpj; }
        set { _cnpj = value; }
    }

    public String Senha
    {
        get { return _senha; }
        set { _senha = value; }
    }

    public String Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public String Email
    {
        get { return _email; }
        set { _email = value; }
    }

    public String Cidade
    {
        get { return _cidade; }
        set { _cidade = value; }
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