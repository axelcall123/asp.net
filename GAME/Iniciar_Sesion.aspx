<%@ Page Title="Iniciar Sesion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="GAME.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>INICIANDO SESION</h1>

<div class="container">
    <div class="row">
        <form action="" method="post">
            <div class="col-lg-12">
                <span class="icon-user"></span>
                <!--input type="text" placeholder="NOMBRE" required-->
                <asp:TextBox type="text" placeholder="NOMBRE" ID="usuario_s" runat="server" required></asp:TextBox>
            </div>
            <div class="col-lg-12">
                <span class="icon-key"></span>
                <!--input type="password" placeholder="CONTRASEÑA" required-->
                <asp:TextBox type="password" placeholder="USARIO" ID="contraseña_s" runat="server" required></asp:TextBox>
            </div>
            <div class="col-lg-12">
                <!--input type="password" placeholder="CONTRASEÑA" required-->
                <asp:Button ID="Enviar_s" runat="server" Text="Enviar" />
            </div>
            <div class="col-sm-8"></div>
            <div class="col-sm-1"></div>
            <div class="col-sm-3"></div>
        </form>
    </div>
</div>
</asp:Content>