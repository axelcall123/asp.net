<%@ Page EnableEventValidation="false" Title="Iniciar Sesion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Iniciar_Sesion.aspx.cs" Inherits="GAME.Iniciar_Sesion" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>INICIANDO SESION</h1>

        <form action="/" method="post">
            <div class="col-lg-12">
                <span class="icon-user"></span>
                <!--input type="text" placeholder="NOMBRE" required-->
                <asp:TextBox type="text" placeholder="NOMBRE" ID="usuario_s" runat="server" required></asp:TextBox>
            </div>
            <div class="col-lg-12">
                <span class="icon-key"></span>
                <!--input type="password" placeholder="CONTRASEÑA" required-->
                <asp:TextBox type="password" placeholder="CONTRASEÑA" ID="contraseña_s" runat="server" required></asp:TextBox>
            </div>
            <div class="col-lg-12">
                <span class="icon-radio-checked"></span>
                <asp:Button ID="Enviar_s" runat="server" Text="Enviar" OnClick="Enviar_s_Click"/>
            </div>
            <div class="col-sm-4"><a runat="server" href="~/Registrarse">Registrarse</a></div>
            <div class="col-sm-5"></div>
            <div class="col-sm-3">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </div>
        </form>
</asp:Content>
