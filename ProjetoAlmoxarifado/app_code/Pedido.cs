using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Pedido
/// </summary>
public class Pedido
{

    private DateTime _data;
    private int _quantidade;
    private int _ativo;
    private long _upc;
    private long _cnpj;
    private long _cpf;
    private int _id;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public long Upc
    {
        get { return _upc; }
        set { _upc = value; }
    }


    public long Cpf
    {
        get { return _cpf; }
        set { _cpf = value; }
    }

    public long Cnpj
    {
        get { return _cnpj; }
        set { _cnpj = value; }
    }

 
    


    public int Ativo
    {
        get { return _ativo; }
        set { _ativo = value; }
    }
    

    
    public int Quantidade
    {
        get { return _quantidade; }
        set { _quantidade = value; }
    }
   
    


        public DateTime Data
        {
          get { return _data; }
          set { _data = value; }
        }
   

    

}