<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageSetorCompra.master" AutoEventWireup="true" CodeFile="PgVisualizarComprasPedidos.aspx.cs" Inherits="PgVisualizarComprasPedidos" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cthSetorCompra" Runat="Server">
    <div style="margin-left: 31px; margin-right: 27px; margin-top: 39px">


        <asp:Label ID="lblInfo2" runat="server" Text="Lista de Compras Ativas"></asp:Label>
        <asp:Label ID="lblCompras" runat="server" Text=""></asp:Label>
        <asp:GridView ID="gdvCompras" runat="server" AutoGenerateColumns="false"  >
               <Columns>
                   <asp:BoundField DataField="aqu_id" HeaderText="Identificação" />
                   <asp:BoundField DataField="aqu_nome" HeaderText="Nome" />
                   <asp:BoundField DataField="aqu_quantidade" HeaderText="Quantidade" />
                   <asp:BoundField DataField="aqu_valor" HeaderText="Valor da Compra" />
                   <asp:BoundField DataField="aqu_pendente" HeaderText="Pendente" />     
                   <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btImprimir" runat="server" OnClick="btImprimir_Click" Text="Imprimir" />
                    </ItemTemplate>
                </asp:TemplateField>
               </Columns>
        </asp:GridView>

        
        <br />
        <br />

       <asp:Label ID="lblinfo1" runat="server" Text="Lista de Pedidos Ativos"></asp:Label>
        <asp:Label ID="lblPedidos" runat="server" Text=""></asp:Label>
        <asp:GridView ID="gdvPedidos" runat="server" AutoGenerateColumns="false"  >
               <Columns>
                   <asp:BoundField DataField="ped_data" HeaderText="Nome" />
                   <asp:BoundField DataField="ped_quantidade" HeaderText="Quantidade" />
                   <asp:BoundField DataField="emp_nome" HeaderText="Nome Empresa" />
                   <asp:BoundField DataField="pro_nome" HeaderText="Nome Produto" />


               </Columns>
        </asp:GridView>




    </div>
</asp:Content>

