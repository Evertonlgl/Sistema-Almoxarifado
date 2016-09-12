<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="CadastraUsuario.aspx.cs" Inherits="CadastraUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphAdmin" Runat="Server">
    <div style="margin-left: 43px; margin-top: 42px">
        <asp:ScriptManager ID="scrMananger" runat="server"></asp:ScriptManager>
        <asp:Label ID="lblNome" runat="server" Text="Nome do usuario"></asp:Label>
        <asp:TextBox ID="txtNomeUsu" runat="server" style="margin-left: 33px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvNomeUsu" SetFocusOnError="true" ControlToValidate="txtNomeUsu" ErrorMessage="Preencha do Usuario do sistema" runat="server" ValidationGroup="funcionario"></asp:RequiredFieldValidator>
        <br />
        <br />

        <asp:Label ID="lblCpf" runat="server" Text="CPF"></asp:Label>
        <asp:TextBox ID="txtCpf" runat="server" style="margin-left: 108px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvcpf" SetFocusOnError="true" ControlToValidate="txtCpf" ErrorMessage="Preencha o Cpf" runat="server" ValidationGroup="funcionario"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revCpfC1" runat="server" ValidationExpression="[\W\w]{11,}" ForeColor="black" ControlToValidate="txtCpf" SetFocusOnError="true" ErrorMessage="Digite o Minimo de 14 caracteres" ValidationGroup="funcionario" ></asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="revCpfC2" runat="server" ValidationExpression="[\W\w]{,11}" ForeColor="black" ControlToValidate="txtCpf" SetFocusOnError="true" Font-Size="15px" ErrorMessage=" 14 Maximo de caracteres" Font-Bold="true" ValidationGroup="funcionario"></asp:RegularExpressionValidator>
        <br />
        <br />


        <asp:Label ID="lblsenha" runat="server" Text="Senha"></asp:Label>
        <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" style="margin-left: 100px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" SetFocusOnError="true" ControlToValidate="txtSenha" ErrorMessage="Preencha a Senha" runat="server" ValidationGroup="funcionario"></asp:RequiredFieldValidator>
        <br />
        <br />
           
        <asp:Label ID="lblCidadeUsu" runat="server" Text="Cidade"></asp:Label>
        <asp:TextBox ID="txtCidadeUsu" runat="server" style="margin-left: 94px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvCidadeUsu" SetFocusOnError="true" ControlToValidate="txtCidadeUsu" ErrorMessage="Preencha a Cidade" runat="server" ValidationGroup="funcionario"></asp:RequiredFieldValidator>
        <br />
        <br />

        <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>
        <%--<asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>--%> 
        <asp:DropDownList ID="ddlEstado" runat="server" style="margin-left: 95px">
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
        <asp:RequiredFieldValidator ID="rfvestado" SetFocusOnError="true" ControlToValidate="ddlEstado" ErrorMessage="Preencha o Estado" runat="server" ValidationGroup="funcionario"></asp:RequiredFieldValidator>
        <br />
        <br />

        <asp:Label ID="lblBairroUsu" runat="server" Text="Bairro"></asp:Label>
        <asp:TextBox ID="txtBairroUsu" runat="server" style="margin-left: 98px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvBairroUsu" SetFocusOnError="true" ControlToValidate="txtBairroUsu" ErrorMessage="Preencha o Bairro" runat="server" ValidationGroup="funcionario"></asp:RequiredFieldValidator>
        <br />
        <br />
        
        <asp:Label ID="lblRua" runat="server" Text="rua"></asp:Label>
        <asp:TextBox ID="txtRua" runat="server" style="margin-left: 117px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvrua" SetFocusOnError="true" ControlToValidate="txtrua" ErrorMessage="Preencha a rua" runat="server" ValidationGroup="funcionario"></asp:RequiredFieldValidator>
        <br />
        <br />

        <asp:Label ID="lblNumeroUsu" runat="server" Text="Numero"></asp:Label>
        <asp:TextBox ID="txtNumeroUsu" runat="server" style="margin-left: 86px" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvNumeroUsu" SetFocusOnError="true" ControlToValidate="txtNumeroUsu" ErrorMessage="Preencha o Numero" runat="server" ValidationGroup="funcionario"></asp:RequiredFieldValidator>
        <br />
        <br />

        <asp:Label ID="lblTelefoneUsu" runat="server" Text="Telefone"></asp:Label>
        <asp:TextBox ID="txtTelefoneUsu" runat="server" style="margin-left: 85px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvTelefoneUsu" SetFocusOnError="true" ControlToValidate="txtTelefoneUsu" ErrorMessage="Preencha o Telefone" runat="server" ValidationGroup="funcionario"></asp:RequiredFieldValidator>
        <br />
        <br />

        <asp:Label ID="lblArea" runat="server" Text="Area de Atuação"></asp:Label>
        
        <asp:DropDownList ID="ddlArea" runat="server" style="margin-left: 35px">
            <asp:ListItem Value="operario">Operação</asp:ListItem>
            <asp:ListItem Value="admin">Administração</asp:ListItem>
            <asp:ListItem Value="compras">Setor de Compras</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="rfvArea" SetFocusOnError="true" ControlToValidate="ddlArea" ErrorMessage="Preencha a Area de atuação" runat="server" ValidationGroup="funcionario"></asp:RequiredFieldValidator>
        <br />
        <br />

        <br />
        <asp:Button ID="btConlcluir" runat="server" Text="Cadastra novo Funcionario"  OnClick="btConlcluir_Click" ValidationGroup="funcionario" style="margin-left: 219px"/>

        <br />

        
    
    </div>
</asp:Content>