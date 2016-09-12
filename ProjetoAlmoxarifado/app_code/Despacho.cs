using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Despacho
/// </summary>
public class Despacho
{
    private Pedido _pedido;
    private Boolean _lancado;

    public Boolean Lancado
    {
        get { return _lancado; }
        set { _lancado = value; }
    }

    public global :: Pedido Pedido
    {
        get { return _pedido; }
        set { _pedido = value; }
    }
}