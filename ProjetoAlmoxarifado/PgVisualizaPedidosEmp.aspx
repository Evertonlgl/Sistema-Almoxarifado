<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagePedidoEmpresa.master" AutoEventWireup="true" CodeFile="PgVisualizaPedidosEmp.aspx.cs" Inherits="PgVisualizaPedidosEmp" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphEmpresa" runat="Server">

    <div style="margin-left: 23px; margin-right: 23px; margin-top: 28px">
        <asp:Label ID="lblMenssagem" runat="server" Text=""></asp:Label>
        <script type="text/javascript"> function confirmCancel() { if (confirm("Deseja confirmar essa operação?")) { return true; } else { return false; } }</script>

        <asp:GridView ID="gdvPedido" AutoGenerateColumns="false" runat="server" OnRowDataBound="gdvPedido_RowDataBound" >
            <Columns>
                <asp:BoundField DataField="ped_id" HeaderText="Código" />
                <asp:BoundField DataField="ped_data" HeaderText="Data" />
                <asp:BoundField DataField="ped_quantidade" HeaderText="Quantidade" />
                <asp:BoundField DataField="emp_nome" HeaderText="Efetuado" />
                <asp:BoundField DataField="pro_nome" HeaderText="Nome produto" />
                <asp:BoundField DataField="pro_upc" HeaderText="Universal Code" />
                <asp:BoundField DataField="ped_ativo" HeaderText="Ativo" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnCancela" runat="server" CommandName="Delete" OnClientClick="javascript:return confirmCancel()" OnClick="btnCancela_Click" Text="Cancelar" />
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>

        </asp:GridView>
    </div>
</asp:Content>

