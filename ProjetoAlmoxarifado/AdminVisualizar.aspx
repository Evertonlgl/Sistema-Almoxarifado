    <%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="AdminVisualizar.aspx.cs" Inherits="AdminVisualizar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphAdmin" Runat="Server">
    
    
        <asp:Label ID="lblMensagem3" runat="server" Text=""></asp:Label>
        <asp:GridView ID="gdvProdutos" runat="server" AutoGenerateColumns="false" style="margin-left: 71px; margin-top: 28px" >
               <Columns>
                   <asp:BoundField DataField="pro_nome" HeaderText="Nome" />
                   <asp:BoundField DataField="pro_upc" HeaderText="Código Universal" />
                   <asp:BoundField DataField="pro_quantidade" HeaderText="Total em estoque" />
                   <asp:BoundField DataField="pro_preco" HeaderText="Preço Unitário" />
               </Columns>

        </asp:GridView>

    <br />
        <asp:Label ID="lblMensagem1" runat="server" Text=""></asp:Label>
        <br />
        <asp:GridView ID="gdvUsuario" runat="server" AutoGenerateColumns="false" style="margin-left: 69px"  >
               <Columns>
                   <asp:BoundField DataField="usu_nome" HeaderText="Funcionário" />
                   <asp:BoundField DataField="usu_telefone" HeaderText="Telefone" />
                   <asp:BoundField DataField="usu_perfil" HeaderText="Cargo" />
               </Columns>

        </asp:GridView>
    <br />

        <asp:Label ID="lblMensagem2" runat="server" Text=""></asp:Label>
        <br />
        <asp:GridView ID="gdvEmpresa" runat="server" AutoGenerateColumns="false" style="margin-left: 32px"  >
               <Columns>
                   <asp:BoundField DataField="emp_nome" HeaderText="Nome da Empresa" />
                   <asp:BoundField DataField="emp_email" HeaderText="Email Empresa" />
                   <asp:BoundField DataField="emp_telefone" HeaderText="Telefone" />
                   <asp:BoundField DataField="emp_cidade" HeaderText="Cidade"/>
                   <asp:BoundField DataField="emp_estado" HeaderText="URF" />
                   <asp:BoundField DataField="emp_rua" HeaderText="Rua" />
                   <asp:BoundField DataField="emp_bairro" HeaderText="Rua" />
                   <asp:BoundField DataField="emp_numero" HeaderText="Nº" />
               </Columns>

        </asp:GridView>
        
</asp:Content>

