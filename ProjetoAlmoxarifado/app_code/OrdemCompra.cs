using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrdemCompra
/// </summary>
public class OrdemCompra
{
    private int _ordemId;
    private long _upc;
    private String _nome;
    private int _quantidade;
    private double _valor;
    private int _status;
    private long _cpf;
    private Produto _produto;


 public int OrdemId
 {
   get { return _ordemId; }
   set { _ordemId = value; }
 }

public  global :: Produto  Produto
{
  get { return _produto; }
  set { _produto = value; }
}


public long Cpf
{
  get { return _cpf; }
  set { _cpf = value; }
}


public int Status
{
  get { return _status; }
  set { _status = value; }
}




public double Valor
{
  get { return _valor; }
  set { _valor = value; }
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