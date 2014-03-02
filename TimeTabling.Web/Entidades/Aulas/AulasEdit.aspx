<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AulasEdit.aspx.cs" Inherits="TimeTabling.Web.Entidades.Aulas.AulasEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <label>Código Aula</label>
    <asp:TextBox runat="server" ID="AulaC"/>
    <br/>
    <label>Descripció Aula</label>
    <asp:TextBox runat="server" ID="AulaD"/>
    <br/>
    <label>Tipo Aula</label>
    <asp:DropDownList ID="TipoAula" runat="server">
        <asp:ListItem Selected="True" Value="Teorica">Teórica</asp:ListItem>
        <asp:ListItem Value="Practica">Práctica</asp:ListItem>
    </asp:DropDownList>
    <br/>
    <label>Software Disponible</label>
    <asp:CheckBox ID="SoftDisponible" runat="server" />
    <br />
    <asp:Button ID="AddAula" runat="server" Text="Añadir" OnClick="AddAula_Click" />
    <asp:Button ID="EditAula" runat="server" Text="Editar" OnClick="EditAula_Click" />
    <asp:Button ID="Cancelar" runat="server" Text="Cancelar" OnClick="Cancelar_Click" />

</asp:Content>
