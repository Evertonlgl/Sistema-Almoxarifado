<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="PgAlteraSenhafuncionario.aspx.cs" Inherits="PgAlteraSenhafuncionario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphAdmin" Runat="Server">

    <div style="width: 895px; margin-left: 26px; margin-right: 22px; margin-top: 32px">
             
            <asp:Label ID="lblCPFLogin" runat="server" Text="CPF "></asp:Label>
            <asp:TextBox ID="txtCpfLogin" runat="server" style="margin-left: 63px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvcpf" SetFocusOnError="true" ControlToValidate="txtCpfLogin" ErrorMessage="Preencha o Cpf" runat="server" ValidationGroup="Alterasenha"></asp:RequiredFieldValidator>
            <br />
            <br />
        
            <asp:Label ID="lblSenha" runat="server" Text="Senha "></asp:Label>
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" style="margin-left: 63px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvSenha" SetFocusOnError="true" ControlToValidate="txtSenha" ErrorMessage="Preencha Senha" runat="server" ValidationGroup="Alterasenha"></asp:RequiredFieldValidator>



            <br />



            <br />

            <asp:Label ID="lblNovasenha" runat="server" Text="Nova senha "></asp:Label>
            <asp:TextBox ID="txtNovasenha" runat="server" TextMode="Password" style="margin-left: 28px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvNovasenha" SetFocusOnError="true" ControlToValidate="txtSenha" ErrorMessage="Preencha a nova Senha" runat="server" ValidationGroup="Alterasenha"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revNovasenha" runat="server" ValidationExpression="[\W\w]{12,}" ForeColor="black" ControlToValidate="txtNovasenha" SetFocusOnError="true" ErrorMessage="Digite o Minimo de 12 caracteres" ></asp:RegularExpressionValidator>

            <br />

            <br />

            <asp:Label ID="lblConfirma" runat="server" Text="Comfirma senha "></asp:Label>
            <asp:TextBox ID="txtConfirma" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvConfirma" SetFocusOnError="true" ControlToValidate="txtConfirma" ErrorMessage="Preencha a Confirmação" runat="server" ValidationGroup="Alterasenha"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revConfirma" runat="server" ValidationExpression="[\W\w]{12,}" ForeColor="black" ControlToValidate="txtConfirma" SetFocusOnError="true" ErrorMessage="Digite o Minimo de 12 caracteres" ></asp:RegularExpressionValidator>

            <br />

            <br />

            <asp:Button ID="btConfirma" runat="server" Text="confirmar" onclick="btConfirma_Click" ValidationGroup="Alterasenha" style="margin-left: 103px" Width="126px" />
    </div>

</asp:Content>


