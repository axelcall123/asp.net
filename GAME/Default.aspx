<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GAME._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
    <div class="row">
        <button type="button" class="btn btn-primary btn-lg btn-block jugar"><a runat="server" href="~/Iniciar_Sesion">Othello</a></button>
    </div>
    <div class="row">
        <h1>OTHELO</h1>
    </div>
        <p>
    <iframe width="480" height="360" src="https://www.youtube.com/embed/XHIDH0ojUtE" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen style="margin-right: 0px"></iframe>
        </p>
</div>
    

</asp:Content>
