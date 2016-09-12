<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PopImpressao.aspx.cs" Inherits="PopImpressao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #top {
            border-style: dashed;
            border-color: inherit;
            border-width: medium;
            width: 875px;
            margin-right: 0px;
            height: 246px;
        }

        #pedidoID {
            text-align:center;
            font-size:x-large;
            font-family:Arial;
            font-size-adjust:inherit;
            border-style: dashed;
            border-color: inherit;
            border-width: medium;
            margin-left: 777px;
            margin-top: 157px;
            width: 231px;
            z-index: 0;
            position:absolute;
            top: -139px;
            left: -127px;
            height: 230px;
        }

        #info {
            border-style: dashed;
            border-color: inherit;
            border-width: medium;
            height: 188px;
        }

        #rodape {
            border: dashed;
        }
    </style>
</head>
<body style="height: 412px; width: 1015px;">
    <form id="form1" runat="server">
        <div style="width: 885px">
            <div id="top">

                <img src="img/logo-exemplo1.gif" style="width: 268px" />

                <div id="pedidoID">
                    <br />
                    <br />
                    PEDIDO DE  COMPRAS
                    <asp:Label ID="lblNpedido" runat="server" Text=""></asp:Label>
                </div>

            </div>
            <div id="info">


                <br />
                &nbsp;<asp:Label ID="Label1" runat="server" Text="Quant."></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Código do Produto"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" Text="Descição do Produto"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" Text="Vlr Uni"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server" Text="Total"></asp:Label>


                <br />


                <br />


                &nbsp;<asp:Label ID="lblqtd" runat="server" Text=""></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblUpc" runat="server" Text=""></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblNome" runat="server" Text=""></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblvaloruni" runat="server" Text=""></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbltotal" runat="server" Text=""></asp:Label>




            </div>
        </div>
    </form>
</body>
</html>
