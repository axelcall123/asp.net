<%@ Page Title="WebForm1" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="GAME.Test.WebForm1" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <asp:Label ID="Uno" runat="server" Text="Label1" Width="500px" Height="500px" BackColor="#009933"></asp:Label>
    <asp:Label ID="Dos" runat="server" Text="Label1" Width="500px" Height="500px" BackColor="#cc6600"></asp:Label>


    <asp:FileUpload ID="FileUpload1" runat="server" />

    <asp:Button ID="B_LUno" runat="server" Text="Button" OnClick="B_LUno_Click" />
    <asp:Button ID="B_LDos" runat="server" Text="Extreme" OnClick="B_LDos_Click" />
</asp:Content>

