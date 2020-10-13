<%@ Page EnableEventValidation="false" Title="Registrarse" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="GAME.About" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Registrandose</h1>
   <br />
    <br />
    <br />
<form action="~/Default" method="post">
    <div class="col-lg-12">
        <span class="icon-user"></span>
        <!--input type="text" placeholder="NOMBRE" required name="nombre"-->
        <asp:TextBox  type="text" placeholder="NOMBRE" ID="nombre_r" runat="server" required OnTextChanged="nombre_r_TextChanged"></asp:TextBox>
     </div>
    <div class="col-lg-12">
        <span class="icon-user-tie"></span>
        <!--input type="text" placeholder="APELLIDO" required name="apellido"-->
        <asp:TextBox type="text" placeholder="APELLIDO" ID="apellido_r" runat="server" required></asp:TextBox>
    </div>
    <div class="col-lg-12">
        <span class="icon-users"></span>
        <!--input type="text" placeholder="USUARIO" required name="usuario"-->
        <asp:TextBox type="text" placeholder="USARIO" ID="usuario_r" runat="server" required></asp:TextBox>
    </div>
    <div class="col-lg-12">
        <span class="icon-key"></span>
        <!--input type="password" placeholder="CONTRASEÑA" required name="contraseña"-->
        <asp:TextBox type="password" placeholder="CONTRASEÑA" ID="contraseña_r" runat="server" required></asp:TextBox>
    </div>
    <div class="col-lg-12">
        <span class="icon-calendar"></span>
        <!--input type="date" placeholder="Fecha De Nacimiento" required name="fecha"-->
        <asp:TextBox href="~/Default" type="date" placeholder="FECHA NACIMIENTO" ID="fecha_r" runat="server" required></asp:TextBox>
    </div>
    <div class="col-lg-12">
        <span class="icon-earth"></span>
        <!--input type="text" placeholder="PAIS" required name="pais"-->
        <asp:TextBox type="text" placeholder="PAIS" ID="pais_r" runat="server" required></asp:TextBox>
    </div>
     <div class="col-lg-12">
        <span class="icon-envelop"></span>
        <!--input type="text" placeholder="PAIS" required name="pais"-->
        <asp:TextBox type="email" placeholder="EMAIL" ID="email_r" runat="server" required></asp:TextBox>
    </div>
    <div class="col-lg-12">
        <!--input type="submit" value="enviar" name="Enviar"-->
        <span class="icon-radio-checked"></span>
        <asp:Button ID="Enviar_r" runat="server" Text="Enviar" OnClick="Enviar_r_Click" />
        <br />
    </div>
</form>
    
</asp:Content>
