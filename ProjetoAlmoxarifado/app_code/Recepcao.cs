using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Recepcao
/// </summary>
public class Recepcao
{
    private int _pendente;
    private int _status;
    private int _quantidade;
    private long _upc;
    private int _receptaculoId;

    public int ReceptaculoId
    {
        get { return _receptaculoId; }
        set { _receptaculoId = value; }
    }

    public long Upc
    {
        get { return _upc; }
        set { _upc = value; }
    }



    public int Status
    {
        get { return _status; }
        set { _status = value; }
    }

    public int Quantidade
    {
        get { return _quantidade; }
        set { _quantidade = value; }
    }


    public int Pendente
    {
        get { return _pendente; }
        set { _pendente = value; }
    }

   
}