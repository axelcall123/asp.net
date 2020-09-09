<%@ Page Title="Iniciar Sesion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="GAME.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>INICIANDO SESION</h1>

<div class="container">
    <div class="row">
        <form action="" method="post">
            <div class="col-lg-12">
                <span class="icon-user"></span>
                <input type="text" placeholder="NOMBRE" required>
            </div>
            <div class="col-lg-12">
                <span class="icon-key"></span><input type="password" placeholder="CONTRASEÑA" required>
            </div>
            <div class="col-lg-12">
                <asp:Button ID="Button1" CssClass="btn btn-primary btn-lg" runat="server" Text="Othello" />
            </div>
            <div class="col-sm-8"></div>
            <div class="col-sm-1">
                <a runat="server" href="~/Registrarse">Registrate</a>
            </div>
            <div class="col-sm-3"></div>

        </form>

    </div>
</div>
</asp:Content>