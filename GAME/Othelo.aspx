<%@ Page Title="Othelo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Othelo.aspx.cs" Inherits="GAME.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div onclick=""></div>
<section id="juego">
    <div class="fila">
        <div class="rodear">*</div>
        <div class="rodear">A</div>
        <div class="rodear">B</div>
        <div class="rodear">C</div>
        <div class="rodear">D</div>
        <div class="rodear">E</div>
        <div class="rodear">F</div>
        <div class="rodear">G</div>
        <div class="rodear">H</div>
        <div class="rodear">*</div>
    </div>
    <div class="fila" runat="server" id="f1">
        <div class="rodear">1</div>
            <asp:Button ID="BA1" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BA1_Click" />
            <asp:Button ID="BB1" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BB1_Click" />
            <asp:Button ID="BC1" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BC1_Click" />
            <asp:Button ID="BD1" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BD1_Click" />
            <asp:Button ID="BE1" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BE1_Click" />
            <asp:Button ID="BF1" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BF1_Click" />
            <asp:Button ID="BG1" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BG1_Click" />
            <asp:Button ID="BH1" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BH1_Click" />
        <div class="rodear-rigth">1</div>
    </div>

    <div class="fila" runat="server" id="f2">
        <div class="rodear">2</div>
            <asp:Button ID="BA2" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BA2_Click" />
            <asp:Button ID="BB2" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BB2_Click" />
            <asp:Button ID="BC2" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BC2_Click" />
            <asp:Button ID="BD2" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BD2_Click" />
            <asp:Button ID="BE2" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BE2_Click" />
            <asp:Button ID="BF2" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BF2_Click" />
            <asp:Button ID="BG2" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BG2_Click" />
            <asp:Button ID="BH2" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BH2_Click" />
        <div class="rodear-rigth">2</div>
    </div>

    <div class="fila" runat="server" id="f3">
        <div class="rodear">3</div>
            <asp:Button ID="BA3" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BA3_Click" />
            <asp:Button ID="BB3" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BB3_Click" />
            <asp:Button ID="BC3" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BC3_Click" />
            <asp:Button ID="BD3" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BD3_Click" />
            <asp:Button ID="BE3" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BE3_Click" />
            <asp:Button ID="BF3" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BF3_Click" />
            <asp:Button ID="BG3" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BG3_Click" />
            <asp:Button ID="BH3" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BH3_Click" />
        <div class="rodear-rigth">3</div>
    </div>

    <div class="fila" runat="server" id="f4">
        <div class="rodear">4</div>
          <asp:Button ID="BA4" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BA4_Click" />
          <asp:Button ID="BB4" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BB4_Click" />
          <asp:Button ID="BC4" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BC4_Click" />
          <asp:Button ID="BD4" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BD4_Click" />
          <asp:Button ID="BE4" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BE4_Click" />
          <asp:Button ID="BF4" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BF4_Click" />
          <asp:Button ID="BG4" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BG4_Click" />
          <asp:Button ID="BH4" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BH4_Click" />
        <div class="rodear-rigth">4</div>
    </div>

    <div class="fila" runat="server" id="f5">
        <div class="rodear">5</div>
          <asp:Button ID="BA5" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BA5_Click" />
          <asp:Button ID="BB5" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BB5_Click" />
          <asp:Button ID="BC5" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BC5_Click" />
          <asp:Button ID="BD5" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BD5_Click" />
          <asp:Button ID="BE5" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BE5_Click" />
          <asp:Button ID="BF5" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BF5_Click" />
          <asp:Button ID="BG5" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BG5_Click" />
          <asp:Button ID="BH5" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BH5_Click" />
        <div class="rodear-rigth">5</div>
    </div>

    <div class="fila" runat="server" id="f6">
        <div class="rodear">6</div>
          <asp:Button ID="BA6" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BA6_Click" />
          <asp:Button ID="BB6" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BB6_Click" />
          <asp:Button ID="BC6" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BC6_Click" />
          <asp:Button ID="BD6" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BD6_Click" />
          <asp:Button ID="BE6" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BE6_Click" />
          <asp:Button ID="BF6" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BF6_Click" />
          <asp:Button ID="BG6" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BG6_Click" />
          <asp:Button ID="BH6" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BH6_Click" />
        <div class="rodear-rigth">6</div>
    </div>

    <div class="fila" runat="server" id="f7">
        <div class="rodear">7</div>
          <asp:Button ID="BA7" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BA7_Click" />
          <asp:Button ID="BB7" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BB7_Click" />
          <asp:Button ID="BC7" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BC7_Click" />
          <asp:Button ID="BD7" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BD7_Click" />
          <asp:Button ID="BE7" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BE7_Click" />
          <asp:Button ID="BF7" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BF7_Click" />
          <asp:Button ID="BG7" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BG7_Click" />
          <asp:Button ID="BH7" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BH7_Click" />
        <div class="rodear-rigth">7</div>
    </div>

    <div class="fila" runat="server" id="f8">
        <div class="rodear">8</div>
          <asp:Button ID="BA8" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BA8_Click"/>
          <asp:Button ID="BB8" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BB8_Click" />
          <asp:Button ID="BC8" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BC8_Click" />
          <asp:Button ID="BD8" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BD8_Click" />
          <asp:Button ID="BE8" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BE8_Click" />
          <asp:Button ID="BF8" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BF8_Click" />
          <asp:Button ID="BG8" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BG8_Click" />
          <asp:Button ID="BH8" runat="server" Text="" CssClass="adentro-cuadros" OnClick="BH8_Click" />
        <div class="rodear-rigth">8</div>
    </div>

    <div class="fila">
        <div class="rodear">*</div>
        <div class="rodear">A</div>
        <div class="rodear">B</div>
        <div class="rodear">C</div>
        <div class="rodear">D</div>
        <div class="rodear">E</div>
        <div class="rodear">F</div>
        <div class="rodear">G</div>
        <div class="rodear">H</div>
        <div class="rodear">*</div>
    </div>
        <br />
        <br />
    <div class="col-md-1">
        <asp:Button ID="Guardar" runat="server" Text="Salvar" OnClick="Guardar_Click" />
    </div>
    <div class="col-md-1">
        <asp:Label ID="mensaje" runat="server" Text=""></asp:Label>
    </div>
    <div class="col-md-2">
    </div>
    <div class="col-md-2">
    </div>
    <div class="col-md-2">
        <asp:Button ID="Cargar" runat="server" Text="Cargar" OnClick="Cargar_Click" />
    </div>
    <div class="col-md-4">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
    
</section> 


</asp:Content>
