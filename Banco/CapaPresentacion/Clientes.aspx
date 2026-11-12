<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="Banco.CapaPresentacion.Clientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" type="text/css" href="/css/Estilos.css">
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            <ul>
                <li><a class="active" href="inicio.aspx">Inicio </a></li>
                <li><a href="Clientes.aspx">Clientes</a></li>
                <li><a href="Contactos.aspx">Contactos</a></li>
                <li><a href="Ayuda.aspx">Ayuda</a></li>
            </ul>
        </div>
        <div>
            <h1>Gestión de Clientes</h1>
        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
        <div>
            <asp:Label ID="lblcodigo" runat="server" Text="Codigo"></asp:Label>
            <asp:TextBox ID="txtcodigo" runat="server"></asp:TextBox>
            <br />
              <asp:Label ID="lblnombre" runat="server" Text="Nombre"></asp:Label>
              <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbledad" runat="server" Text="Edad"></asp:Label>
            <asp:TextBox ID="txtedad" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblsaldo" runat="server" Text="Saldo"></asp:Label>
            <asp:TextBox ID="txtsaldo" runat="server"></asp:TextBox>

        </div>

        <div>
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar Cliente" OnClick="btnAgregar_Click" /> 
            <asp:Button ID="btnBorrar" runat="server" Text="Borrar Cliente" OnClick="btnBorrar_Click" /> 
            <asp:Button ID="btnEditar" runat="server" Text="Editar Cliente" OnClick="btnEditar_Click" /> 

        </div>
    </form>
</body>
</html>
