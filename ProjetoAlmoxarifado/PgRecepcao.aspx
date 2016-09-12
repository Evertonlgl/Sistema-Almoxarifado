<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageOperario.master" AutoEventWireup="true" CodeFile="PgRecepcao.aspx.cs" Inherits="PgRecepcao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphOperario" Runat="Server">
    <div style="margin-left: 67px; margin-top: 54px">


        <asp:ScriptManager ID="scrMananger" runat="server"></asp:ScriptManager>
       
        <asp:Label ID="lblIdcompra" runat="server" Text="identificação da ordem de compra"></asp:Label>
        <asp:TextBox ID="txtIdcompra" runat="server" style="margin-left: 10px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvcompra" SetFocusOnError="true" ValidationGroup="bloco1" ControlToValidate="txtIdcompra" ErrorMessage="Entre com o id da Ordem de compra" runat="server"></asp:RequiredFieldValidator>

        <br />

        <br />

        <asp:Label ID="lblNomeProdtxt" runat="server" Text="Nome do Produto"></asp:Label>
        <asp:Label ID="lblNomeProd" runat="server" Text=""></asp:Label>
         <br />
         <br />


         <asp:Label ID="lblUsunomeTxt" runat="server" Text="Pedido requisitado Por :"></asp:Label>
        <asp:Label ID="lblUsunome" runat="server" Text=""></asp:Label>
         <br />
         <br />


        <asp:Label ID="lblupctxt" runat="server" Text="Codigo do produto :"></asp:Label>
        <asp:Label ID="lblupc" runat="server" Text=""></asp:Label>
        <br />
        <br />

         <asp:Label ID="lblValortxt" runat="server" Text="Valor da quantidade de Produto :"></asp:Label>
         <asp:Label ID="lblvalor" runat="server" Text=""></asp:Label>

        <br />

        <br />

        <asp:Label ID="lblQtdTxt" runat="server" Text="Quantidade Produto"></asp:Label>
        <asp:Label ID="lblqt" runat="server" Text=""></asp:Label>
        <br />
        <br />

        <asp:Label ID="lblPendentetxt" runat="server" Text="Produto Pendente"></asp:Label>
        <asp:Label ID="lblPendente" runat="server" Text=""></asp:Label>
        <br />
        <br />

        <asp:Button ID="btVisualizaordem" runat="server" Text="Visualiza compra" OnClick="btVisualizaordem_Click" ValidationGroup="bloco1"/>
        <br />
        <br />
        <br />



        <asp:Label ID="lblQtda" runat="server" Text="quantidade de Produtos adquiridos"></asp:Label>
        <asp:TextBox ID="txtQtda" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvqtda" SetFocusOnError="true" ControlToValidate="txtQtda" ErrorMessage="Entre a quantidade de produtos comprados" runat="server" ValidationGroup="bloco2" ></asp:RequiredFieldValidator>
        <br />
        <br />

        <asp:Label ID="lblpendetes" runat="server" Text="Produto Pendentes :"></asp:Label>
        <asp:TextBox ID="txtpendente" runat="server" style="margin-left: 90px"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="lblddltxt" runat="server" Text="Receptaculos Disponiveis :"></asp:Label>   
        <asp:DropDownList ID="ddlReceptaculos" runat="server" OnSelectedIndexChanged="ddlReceptaculos_SelectedIndexChanged" AutoPostBack="true" style="margin-left: 51px"></asp:DropDownList>
        <asp:RequiredFieldValidator ID="rfvReceptaulos" SetFocusOnError="true" ControlToValidate="ddlReceptaculos" ErrorMessage="Entre com o Receptaculo" runat="server" ValidationGroup="bloco2" ></asp:RequiredFieldValidator>
        <br />
        <br />

        <asp:Label ID="lblDisponiveistxt" runat="server" Text="Espaço Disponivel"></asp:Label>
        <asp:Label ID="lblDisponivies" runat="server" Text=""></asp:Label>
        <br />
        <br />

        <asp:Button ID="btConfirma" runat="server" Text="Confirmar chegada"  OnClick="btConfirma_Click" ValidationGroup="bloco2"/>
        <br />
        <br />


       <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
       <asp:GridView ID="gdvReceptaculos" runat="server" AutoPostBack="true"></asp:GridView>


    </div>
</asp:Content>
