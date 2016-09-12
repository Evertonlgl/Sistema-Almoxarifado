<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageSetorCompra.master" AutoEventWireup="true" CodeFile="PgOrdemCompra.aspx.cs" Inherits="PGOrdemCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cthSetorCompra" Runat="Server">
     <div style="margin-left: 24px; margin-right: 21px; margin-top: 34px">
        <asp:ScriptManager ID="scrMananger" runat="server"></asp:ScriptManager>

         <asp:Label ID="lblProduto" runat="server" Text="Nome do Produto"></asp:Label>
         <asp:DropDownList ID="ddlProduto" runat="server"></asp:DropDownList>
         <br />
         <br />

         <asp:Label ID="lblupctxt" runat="server" Text="Codigo do produto :"></asp:Label>
        <asp:Label ID="lblUpc" runat="server" Text=""></asp:Label>
         <br />
        <br />

         <asp:Label ID="lblValortxt" runat="server" Text="Valor da quantidade de Produto :"></asp:Label>
         <asp:Label ID="lblValor" runat="server" Text=""></asp:Label>
         <br />
        <br />


        <asp:Label ID="lblQtd" runat="server" Text="Quantidade Produto"></asp:Label>
        <asp:TextBox ID="txtQtd" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvqtd" SetFocusOnError="true" ControlToValidate="txtQtd" ErrorMessage="Preencha Quantidade do produto" runat="server" ValidationGroup="compra"></asp:RequiredFieldValidator>
        <br />

         

      

        <%--<asp:Label ID="lblCpf" runat="server" Text="Entre com Cpf"></asp:Label>
        <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvcpf" SetFocusOnError="true" ControlToValidate="txtCpf" ErrorMessage="Preencha o Cpf do Usuário" runat="server" ValidationGroup="compra"></asp:RequiredFieldValidator>

        <br />--%>


         <br />
         <asp:Button ID="btVisualiza" runat="server" Text="Visualiza" OnClick="btVisualiza_Click" ValidationGroup="compra" />
        <br />

        <br />
         <asp:Button ID="btEfetuacompra" runat="server" Text="Confirma" OnClick="btEfetuacompra_Click" />
        <br />

        
        
    </div>
</asp:Content>