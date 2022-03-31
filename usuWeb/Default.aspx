<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="usuWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        NIF:
        <asp:TextBox ID="TNIF" runat="server"></asp:TextBox><br /><br />
        Nombre:
        <asp:TextBox ID="TNombre" runat="server"></asp:TextBox><br /><br />
        Edad:
        <asp:TextBox ID="TEdad" runat="server"></asp:TextBox><br /><br />

        <asp:button ID="Leer" runat="server" Text="Leer" />
        <asp:button ID="Leer_Primero" runat="server" Text="Leer Primero" />
        <asp:button ID="Leer_Anterior" runat="server" Text="Leer Anterior" />
        <asp:button ID="Leer_Siguiente" runat="server" Text="Leer Siguiente" />
        <asp:button ID="Crear" runat="server" Text="Crear" />
        <asp:button ID="Actualizar" runat="server" Text="Actualizar" />
        <asp:button ID="Borrar" runat="server" Text="Borrar" />
       
    </div>
</asp:Content>
