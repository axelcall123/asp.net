<%@ Page Title="Get" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Get.aspx.cs" Inherits="GAME.Get" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="CPU" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="JUGADOR" OnClick="Button2_Click" />
    

    <h3>Extreme|Torneo:</h3>
    <h4>Cargar Xml para incializar Extreme o Torneo</h4>
    <h5>Los colores son de 1 hasta 5 maximo predefinidos|Torneo de 16, 8 ó 16 participantes</h5>

    <asp:Button ID="Button3" runat="server" Text="Extreme" OnClick="Button3_Click" />  <asp:Button ID="Torneo" runat="server" Text="Torneo" OnClick="Torneo_Click" />
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <h6>Carga el xml correspondiente para que no de error(Extreme=>Extreme.xml|Torneo=>Torneo.xml)</h6>
     <div class="col-xl-12">
        <asp:Label ID="Text" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>
