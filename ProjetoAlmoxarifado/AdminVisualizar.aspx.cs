using Comum.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminVisualizar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet dsprod = ProdutoDB.SelectAllprodutos();
        Funcoes.Carregargrid(dsprod, gdvProdutos, lblMensagem3);

        DataSet dsemp = EmpresaDB.EmpSelectAll();
        Funcoes.Carregargrid(dsemp, gdvEmpresa, lblMensagem2);

        DataSet dsusu = UsuarioDB.UsuarioSelectAll();
        Funcoes.Carregargrid(dsusu, gdvUsuario, lblMensagem1);

    }
}