<%@ Page Title="Get" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Get.aspx.cs" Inherits="GAME.Get" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="CPU" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="JUGADOR" OnClick="Button2_Click" />
    <asp:Button ID="Torneo" runat="server" Text="Torneo" OnClick="Torneo_Click" />

    <h3>Si eleig Extreme ponga:</h3>
    <h4>Ponga de que tamaño quiere el tablero y los colores ha seleccionar en un archivo xml</h4>
    <h5>Los colores son de 1 hasta 5 maximo predefinidos</h5>

    <asp:Button ID="Button3" runat="server" Text="Extreme" OnClick="Button3_Click" />  
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <div class="col-xl-12">
        <asp:Label ID="Text" runat="server" Text="Label"></asp:Label>
    </div>
    
</asp:Content>
