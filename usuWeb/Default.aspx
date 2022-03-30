<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="usuWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <formview method="get">
             <label for="NIF">NIF:</label>
            <input type="text" id="NIF" size="20" ><br><br>
            <label for="Nombre">Nombre:</label>
            <input type="text" id="Nombre" size="20" ><br><br>
            <label for="Edad">Edad:</label>
            <input type="text" id="Edad" size="20" ><br>
            <button>Leer</button>
            <button>Leer Primero</button>
            <button>Leer Anterior</button>
            <button>Leer Siguiente</button>
            <button>Crear</button>
            <button>Actualizar</button>
            <button>Borrar</button>
            
        </formview>
       
    </div>
</asp:Content>
