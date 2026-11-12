<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Banco.CapaPresentacion.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inicio</title>
        <link rel="stylesheet" type="text/css" href="/css/Estilos.css">

</head>
<body>
    <form id="form1" runat="server">
        <div>
                       <ul>
  <li><a class="active" href="inicio.aspx">Inicio </a></li>
  <li><a href="Clientes.aspx">Clientes</a></li>
  <li><a href="#contact">Contactos</a></li>
  <li><a href="#about">Ayuda</a></li>
</ul>
        <div>

            <asp:Image ID="Image1" runat="server" Height="525px" ImageUrl="~/Imagenes/fondos institucionales_Mesa de trabajo 1 copia 4.png" Width="568px" />
        </div>
    </form>
</body>
</html>
