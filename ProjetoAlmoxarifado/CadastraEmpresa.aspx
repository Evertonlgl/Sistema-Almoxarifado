<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="CadastraEmpresa.aspx.cs" Inherits="CadastraEmpresa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphAdmin" Runat="Server">
    <div style="margin-left: 63px; margin-top: 42px">
        <asp:ScriptManager ID="scrMananger" runat="server"></asp:ScriptManager>
        <asp:Label ID="lblNome" runat="server" Text="Nome da Empresa"></asp:Label>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvNome" SetFocusOnError="true" ControlToValidate="txtNome" ErrorMessage="Preencha o nome da Empresa" runat="server" ValidationGroup="empresa1"></asp:RequiredFieldValidator>
        <br />
        <br />

        <asp:Label ID="lblCnpj" runat="server" Text="CNPJ"></asp:Label>
        <asp:TextBox ID="txtCnpj" runat="server" style="margin-left: 76px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvcnpj" SetFocusOnError="true" ControlToValidate="txtCnpj" ErrorMessage="Preencha o Cnpj" runat="server" ValidationGroup="empresa1"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revEmpC1" runat="server" ValidationExpression="[\W\w]{14,}" ForeColor="black" ControlToValidate="txtCnpj" SetFocusOnError="true" ErrorMessage="Digite o Minimo de 14 caracteres" ValidationGroup="empresa1"></asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="revEmpC2" runat="server" ValidationExpression="[\W\w]{,14}" ForeColor="black" ControlToValidate="txtCnpj" SetFocusOnError="true"  ErrorMessage=" 14 Maximo de caracteres" ValidationGroup="empresa1"></asp:RegularExpressionValidator>
        <br />
        <br />

        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="margin-left: 82px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvemail" SetFocusOnError="true" ControlToValidate="txtEmail" ErrorMessage="Preencha o Email" runat="server" ValidationGroup="empresa1"></asp:RequiredFieldValidator>
        <br />
        <br />

        <%--<asp:Label ID="lblsenha" runat="server" Text="Senha"></asp:Label>
        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" SetFocusOnError="true" ControlToValidate="txtCnpj" ErrorMessage="Preencha a Senha" runat="server"></asp:RequiredFieldValidator>
        <br />--%>
           
        <asp:Label ID="lblCidade" runat="server" Text="Cidade"></asp:Label>
        <asp:TextBox ID="txtCidade" runat="server" style="margin-left: 70px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvCidade" SetFocusOnError="true" ControlToValidate="txtCidade" ErrorMessage="Preencha a Cidade" runat="server" ValidationGroup="empresa1"></asp:RequiredFieldValidator>
        <br />
        <br />

        <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>
        <%--<asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>--%> 
        <asp:DropDownList ID="ddlEstado" runat="server" style="margin-left: 72px">
            <asp:ListItem Value="AC">AC</asp:ListItem>
            <asp:ListItem Value="AL">AL</asp:ListItem>
            <asp:ListItem Value="AP">AP</asp:ListItem>
            <asp:ListItem Value="AM">AM</asp:ListItem>
            <asp:ListItem Value="BA">BA</asp:ListItem>
            <asp:ListItem Value="CE">CE</asp:ListItem>
            <asp:ListItem Value="DF">DF</asp:ListItem>
            <asp:ListItem Value="ES">ES</asp:ListItem>
            <asp:ListItem Value="GO">GO</asp:ListItem>
            <asp:ListItem Value="MA">MA</asp:ListItem>
            <asp:ListItem Value="MT">MT</asp:ListItem>
            <asp:ListItem Value="MS">MS</asp:ListItem>
            <asp:ListItem Value="MG">MG</asp:ListItem>
            <asp:ListItem Value="PB">PA</asp:ListItem>
            <asp:ListItem Value="PB">PB</asp:ListItem>
            <asp:ListItem Value="PR">PR</asp:ListItem>
            <asp:ListItem Value="PI">PI</asp:ListItem>
            <asp:ListItem Value="PE">PE</asp:ListItem>
            <asp:ListItem Value="RJ">RJ</asp:ListItem>
            <asp:ListItem Value="RN">RN</asp:ListItem>
            <asp:ListItem Value="RS">RS</asp:ListItem>
            <asp:ListItem Value="RO">RO</asp:ListItem>
            <asp:ListItem Value="RR">RR</asp:ListItem>
            <asp:ListItem Value="SC">SC</asp:ListItem>
            <asp:ListItem Value="SP">SP</asp:ListItem>
            <asp:ListItem Value="SE">SE</asp:ListItem>
            <asp:ListItem Value="TO">TO</asp:ListItem>
                </asp:DropDownList>
        <asp:RequiredFieldValidator ID="rfvestado" SetFocusOnError="true" ControlToValidate="ddlEstado" ErrorMessage="Preencha o Estado" runat="server" ValidationGroup="empresa1"></asp:RequiredFieldValidator>
        <br />
        <br />

        <asp:Label ID="lblBairro" runat="server" Text="Bairro"></asp:Label>
        <asp:TextBox ID="txtBairro" runat="server" style="margin-left: 75px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvBairro" SetFocusOnError="true" ControlToValidate="txtBairro" ErrorMessage="Preencha o Bairro" runat="server" ValidationGroup="empresa1"></asp:RequiredFieldValidator>
        <br />
        <br />

        <asp:Label ID="lblRua" runat="server" Text="rua"></asp:Label>
        <asp:TextBox ID="txtRua" runat="server" style="margin-left: 93px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvrua" SetFocusOnError="true" ControlToValidate="txtrua" ErrorMessage="Preencha a rua" runat="server" ValidationGroup="empresa1"></asp:RequiredFieldValidator>
        <br />
        <br />

        <asp:Label ID="lblNumero" runat="server" Text="Numero"></asp:Label>
        <asp:TextBox ID="txtNumero" runat="server" style="margin-left: 62px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvNumero" SetFocusOnError="true" ControlToValidate="txtNumero" ErrorMessage="Preencha o Numero" runat="server" ValidationGroup="empresa1"></asp:RequiredFieldValidator>
        <br />
        <br />

        <asp:Label ID="lblTelefone" runat="server" Text="Telefone"></asp:Label>
        <asp:TextBox ID="txtTelefone" runat="server" style="margin-left: 59px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvTelefone" SetFocusOnError="true" ControlToValidate="txtTelefone" ErrorMessage="Preencha o Telefone" runat="server" ValidationGroup="empresa1"></asp:RequiredFieldValidator>
        <br />



        <br />
        <asp:Button ID="btCadastrar" runat="server" Text="Cadastra Empresa"  OnClick="btCadastrar_Click" ValidationGroup="empresa1"/>
        <br />

      
    
    </div>
</asp:Content>
