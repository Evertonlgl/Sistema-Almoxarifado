<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageOperario.master" AutoEventWireup="true" CodeFile="PgSaidaPedido.aspx.cs" Inherits="PgSaidaPedido" EnableEventValidation="false" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphOperario" Runat="Server">


    <div style="width: 914px; margin-left: 13px; margin-top: 22px">
        <asp:Label ID="lblInfo0" runat="server" Text="Pedidos Disponivel para Saida"></asp:Label>
           <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
           <script type="text/javascript"> function confirmSaida() { if (confirm("Deseja confirmar essa operação?")) { return true; } else { return false; } }</script>

           <asp:GridView ID="gdvPedidos"  AutoGenerateColumns="false" runat="server" HorizontalAlign="Justify">
               <Columns>

                   <asp:BoundField DataField="ped_id" HeaderText="Código do Pedido" />
                   <asp:BoundField DataField="ped_data" HeaderText="Data do Pedido" />
                   <asp:BoundField DataField="ped_quantidade" HeaderText="Quantidade" />
                   <asp:BoundField DataField="emp_nome" HeaderText="Requerido " />
                   <asp:BoundField DataField="usu_nome" HeaderText="efetuado" />
                   <asp:BoundField DataField="pro_nome" HeaderText="Nome do Produto" />
                   <asp:BoundField DataField="pro_upc" HeaderText="Código Universal" />
                   <asp:BoundField DataField="rec_id"  HeaderText="Disponivel em Receptaculo"/>
                   <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btSaida" runat="server"  OnClientClick="javascript:return confirmSaida()" OnClick="btSaida_Click" Text="Confirmar Saida"   />
                    </ItemTemplate>
                </asp:TemplateField>
               </Columns>
               
           </asp:GridView>
        <br />
        <br />


        <asp:Label ID="lblinfo1" runat="server" Text="Lista de Pedidos Ativos"></asp:Label>
        <asp:Label ID="lblPedidolista" runat="server" Text=""></asp:Label>
        <asp:GridView ID="gdvLista" runat="server" AutoGenerateColumns="false"  >
               <Columns>
                   <asp:BoundField DataField="ped_id" HeaderText="Código do Pedido" />
                   <asp:BoundField DataField="ped_data" HeaderText="Nome" />
                   <asp:BoundField DataField="ped_quantidade" HeaderText="Quantidade" />
                   <asp:BoundField DataField="emp_nome" HeaderText="Nome Empresa" />
                   <asp:BoundField DataField="pro_nome" HeaderText="Nome Produto" />


               </Columns>
        </asp:GridView>
        

    </div>
</asp:Content>
