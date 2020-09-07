<%@ Page Title="Registrarse" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="GAME.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Registrandose</h1>
<form action="/" method="post">
    <div class="col-lg-12">
        <span class="icon-user"></!-span>
        <input type="text" placeholder="NOMBRE" required name="nombre">
     </div>
    <div class="col-lg-12">
        <span class="icon-user-tie"></span>
        <input type="text" placeholder="APELLIDO" required name="apellido">
    </div>
    <div class="col-lg-12">
        <span class="icon-users"></span>
        <input type="text" placeholder="USUARIO" required name="usuario">
    </div>
    <div class="col-lg-12">
        <span class="icon-key"></span>
        <input type="password" placeholder="CONTRASEÑA" required name="contraseña">
    </div>
    <div class="col-lg-12">
        <span class="icon-calendar"></span>
        <input type="date" placeholder="Fecha De Nacimiento" required name="fecha">
    </div>
    <div class="col-lg-12">
        <span class="icon-earth"></span>
        <input type="text" placeholder="PAIS" required name="pais">
    </div>
    <input type="submit" value="enviar" name="Enviar">
</form>
</asp:Content>
