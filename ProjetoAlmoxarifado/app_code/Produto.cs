using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



/// <summary>
/// Summary description for produto
/// </summary>
public class Produto
{
    private long _upc;
    private String _nome;
    private int _quantidade;
    private int _pendente;
    private double _preco;
    private String _posicao;
    private int _receptaculoquantidade;


    public double Preco
    {
        get { return _preco; }
        set { _preco = value; }
    }

    public int Receptaculoquantidade
    {
        get { return _receptaculoquantidade; }
        set { _receptaculoquantidade = value; }
    }

    public String Posicao
    {
        get { return _posicao; }
        set { _posicao = value; }
    }

    public int Pendente
    {
        get { return _pendente; } 
        set { _pendente = value; }
    }

    public int Quantidade
    {
        get { return _quantidade; }
        set { _quantidade = value; }
    }

    public String Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public long Upc
    {
        get { return _upc; }
        set { _upc = value; }
    }
}