<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalMasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="cphCentralAlmoxarifado" runat="Server">

    <div style="height: 261px; width: 440px; margin-left: 288px; margin-right: 377px; margin-top: 148px" >
        <br />
        <br />
        <asp:Label ID="lblEscolha" runat="server" Text="Tipo de Acesso"></asp:Label>
        <asp:ScriptManager ID="scrMananger" runat="server"></asp:ScriptManager>
        <asp:DropDownList ID="ddlLogin" runat="server" Height="16px" Width="121px">
            <asp:ListItem Value="3">Selecione fonte</asp:ListItem>
            <asp:ListItem Value="0">Empresa</asp:ListItem>
            <asp:ListItem Value="1">Almoxarifado</asp:ListItem>
        </asp:DropDownList>
       
        <br />
        <br />
       
        <div >
            <asp:Label ID="lblCnpjLogin" runat="server" Text="Login(CNPJ/CPF) "></asp:Label>
            <asp:TextBox ID="txtCnpjLogin" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvcpf" SetFocusOnError="true" ControlToValidate="txtCnpjLogin" ErrorMessage="Preencha Cpf ou Cnpj" runat="server"></asp:RequiredFieldValidator>

        </div><br />
        <div >
            <asp:Label ID="lblSenha" runat="server" Text="Senha "></asp:Label>
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" style="margin-left: 78px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvSenha" SetFocusOnError="true" ControlToValidate="txtSenha" ErrorMessage="Preencha Senha" runat="server"></asp:RequiredFieldValidator>


        </div><br />
       
        <div>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" style="margin-left: 119px" Width="94px" />
        </div>
    </div>



</asp:Content>

