<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageSetorCompra.master" AutoEventWireup="true" CodeFile="PgPedido.aspx.cs" Inherits="PgPedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="cthSetorCompra" Runat="Server">
    <div style="margin-left: 27px; margin-right: 21px; margin-top: 38px">
        <asp:ScriptManager ID="scrMananger" runat="server"></asp:ScriptManager>

         <asp:Label ID="lblProduto" runat="server" Text="Nome do Produto"></asp:Label>
         <asp:DropDownList ID="ddlProduto" runat="server" style="margin-left: 12px"></asp:DropDownList>
         <br />
         <br />

        <asp:Label ID="lblEmpresa" runat="server" Text="Nome da Empresa :"></asp:Label>
        <asp:DropDownList ID="ddlEmpresa" runat="server"></asp:DropDownList>
        <br />
        <br />

        <asp:Label ID="lblQtd" runat="server" Text="Quantidade Produto"></asp:Label>
        <asp:TextBox ID="txtQtd" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvqtd" SetFocusOnError="true" ControlToValidate="txtQtd" ErrorMessage="Preencha Quantidade do produto" runat="server" ValidationGroup="pedidoInterno"></asp:RequiredFieldValidator>
        <br />

       <%-- <asp:Label ID="lblCpf" runat="server" Text="Entre com Cpf do usuario"></asp:Label>
        <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvcpf" SetFocusOnError="true" ControlToValidate="txtCpf" ErrorMessage="Preencha o Cpf do Usuário" runat="server" ValidationGroup="pedidoInterno"></asp:RequiredFieldValidator>--%>


        <br />
        <asp:Button ID="btPedido" runat="server" Text="Confirma pedido" OnClick="btPedido_Click" ValidationGroup="pedidoInterno"/>
        <br />
        <br />

        
    </div>
</asp:Content>
