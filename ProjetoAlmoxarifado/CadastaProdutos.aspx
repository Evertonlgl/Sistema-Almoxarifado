<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="CadastaProdutos.aspx.cs" Inherits="CadastaProdutos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphAdmin" Runat="Server">

    <div style="width: 658px; margin-left: 89px; margin-top: 58px">
        <asp:ScriptManager ID="scrMananger" runat="server"></asp:ScriptManager>
        <asp:Label ID="lblNome" runat="server" Text="Nome do Produto"></asp:Label>
        <asp:TextBox ID="txtNome" runat="server" style="margin-left: 7px" Width="126px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvNome" SetFocusOnError="true" ControlToValidate="txtNome" ErrorMessage="Preencha o nome do produto" runat="server" ValidationGroup="produto1"></asp:RequiredFieldValidator>
        <br />
        <br />

        <asp:Label ID="lblUpc" runat="server" Text="Código do Produto"></asp:Label>
        <asp:TextBox ID="txtUpc" runat="server" Width="126px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvUpc" SetFocusOnError="true" ControlToValidate="txtUpc" ErrorMessage="Preencha o código do produto" runat="server" ValidationGroup="produto1"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revprodutoC1" runat="server" ValidationExpression="[\W\w]{12,}" ForeColor="black" ControlToValidate="txtUpc" SetFocusOnError="true" ErrorMessage="Digite o Minimo de 12 caracteres" ValidationGroup="produto1" ></asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="revprodutoC2" runat="server" ValidationExpression="[\W\w]{,12}" ForeColor="black" ControlToValidate="txtUpc" SetFocusOnError="true" Font-Size="15px" ErrorMessage=" 12 Maximo de caracteres" Font-Bold="true" ValidationGroup="produto1"></asp:RegularExpressionValidator>

        <br />
        <br />

        <asp:Label ID="lblPreco" runat="server" Text="Preço do Produto"></asp:Label>
        <asp:TextBox ID="txtPreco" runat="server" style="margin-left: 10px" Width="124px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvPreco" SetFocusOnError="true" ControlToValidate="txtPreco" ErrorMessage="Preencha o preco do produto" runat="server" ValidationGroup="produto1"></asp:RequiredFieldValidator>

        <br />

        <br />
        <asp:Button ID="btCadastrar" runat="server" Text="Cadastra Produto"  OnClick="btCadastrar_Click" ValidationGroup="produto1" style="margin-left: 208px"/>
        <br />

  
        
    </div>
 
</asp:Content>