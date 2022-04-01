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

        

        <asp:button ID="Leer" onClick="CLeer" runat="server" Text="Leer" />
        <asp:button ID="Leer_Primero" onClick="LeerP" runat="server" Text="Leer Primero" />
        <asp:button ID="Leer_Anterior" onClick="LeerA" runat="server" Text="Leer Anterior" />
        <asp:button ID="Leer_Siguiente" onClick="LeerS" runat="server" Text="Leer Siguiente" />
        <asp:button ID="Crear" onClick="CCrear" runat="server" Text="Crear" />
        <asp:button ID="Actualizar" OnClick="Act" runat="server" Text="Actualizar" />
        <asp:button ID="Borrar" OnClick="Borr" runat="server" Text="Borrar" /><br />
        <asp:Label ID="MError" runat="server"></asp:Label>
       
    </div>
</asp:Content>
