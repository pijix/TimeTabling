<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AulasList.aspx.cs" Inherits="TimeTabling.Web.Entidades.Aulas.AulasList" %>
<%@ Import Namespace="TimeTabling.Core" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView runat="server" ID="GridAulas" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton runat="server" CausesValidation="false"  OnCommand="BtnEditar_Click" Text="Editar" CommandArgument='<%# Eval("AulaC") %>'></asp:LinkButton>
                    <asp:LinkButton runat="server" CausesValidation="false"  OnCommand="BtnEliminar_Click" Text="Eliminar" CommandArgument='<%# Eval("AulaC") %>'></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <asp:Button runat="server" ID="addAula" Text="Añadir" OnClick="addAula_Click"/>
</asp:Content>
