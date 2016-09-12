<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagePedidoEmpresa.master" AutoEventWireup="true" CodeFile="PgPedidoExterno.aspx.cs" Inherits="PgPedidoExterno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphEmpresa" Runat="Server">
    <div style="width: 887px; margin-left: 30px; margin-top: 39px">
        <asp:ScriptManager ID="scrMananger" runat="server"></asp:ScriptManager>

         <asp:Label ID="lblProduto" runat="server" Text="Nome do Produto"></asp:Label>
         <asp:DropDownList ID="ddlProduto" runat="server" Height="16px" style="margin-left: 13px" Width="129px"></asp:DropDownList>
         <br />
         <br />


        <asp:Label ID="lblQtd" runat="server" Text="Quantidade Produto"></asp:Label>
        <asp:TextBox ID="txtQtd" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvqtd" SetFocusOnError="true" ControlToValidate="txtQtd" ErrorMessage="Preencha Quantidade do produto" runat="server" ValidationGroup="PedidoEx" ></asp:RequiredFieldValidator>
        <br />
        <br />



        <br />
        <asp:Button ID="btPedido" runat="server" Text="Confirma pedido" OnClick="btPedido_Click" ValidationGroup="PedidoEx" />
        <br />

        
    </div>
 </asp:Content>