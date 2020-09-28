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
            <asp:ImageButton ID="BA1" runat="server" CssClass="adentro-cuadros" OnClick="BA1_Click" Enabled="False" />
            <asp:ImageButton ID="BB1" runat="server" CssClass="adentro-cuadros" OnClick="BB1_Click" Enabled="False" />
            <asp:ImageButton ID="BC1" runat="server" CssClass="adentro-cuadros" OnClick="BC1_Click" Enabled="False" />
            <asp:ImageButton ID="BD1" runat="server" CssClass="adentro-cuadros" OnClick="BD1_Click" Enabled="False" />
            <asp:ImageButton ID="BE1" runat="server" CssClass="adentro-cuadros" OnClick="BE1_Click" Enabled="False" />
            <asp:ImageButton ID="BF1" runat="server" CssClass="adentro-cuadros" OnClick="BF1_Click" Enabled="False" />
            <asp:ImageButton ID="BG1" runat="server" CssClass="adentro-cuadros" OnClick="BG1_Click" Enabled="False" />
            <asp:ImageButton ID="BH1" runat="server" CssClass="adentro-cuadros" OnClick="BH1_Click" Enabled="False" />
        <div class="rodear-rigth">1</div>
    </div>

    <div class="fila" runat="server" id="f2">
        <div class="rodear">2</div>
            <asp:ImageButton ID="BA2" runat="server" CssClass="adentro-cuadros" OnClick="BA2_Click" Enabled="False" />
            <asp:ImageButton ID="BB2" runat="server" CssClass="adentro-cuadros" OnClick="BB2_Click" Enabled="False" />
            <asp:ImageButton ID="BC2" runat="server" CssClass="adentro-cuadros" OnClick="BC2_Click" Enabled="False" />
            <asp:ImageButton ID="BD2" runat="server" CssClass="adentro-cuadros" OnClick="BD2_Click" Enabled="False" />
            <asp:ImageButton ID="BE2" runat="server" CssClass="adentro-cuadros" OnClick="BE2_Click" Enabled="False" />
            <asp:ImageButton ID="BF2" runat="server" CssClass="adentro-cuadros" OnClick="BF2_Click" Enabled="False" />
            <asp:ImageButton ID="BG2" runat="server" CssClass="adentro-cuadros" OnClick="BG2_Click" Enabled="False" />
            <asp:ImageButton ID="BH2" runat="server" CssClass="adentro-cuadros" OnClick="BH2_Click" Enabled="False" />
        <div class="rodear-rigth">2</div>
    </div>

    <div class="fila" runat="server" id="f3">
        <div class="rodear">3</div>
            <asp:ImageButton ID="BA3" runat="server" CssClass="adentro-cuadros" OnClick="BA3_Click" Enabled="False" />
            <asp:ImageButton ID="BB3" runat="server" CssClass="adentro-cuadros" OnClick="BB3_Click" Enabled="False" />
            <asp:ImageButton ID="BC3" runat="server" CssClass="adentro-cuadros" OnClick="BC3_Click" Enabled="False" />
            <asp:ImageButton ID="BD3" runat="server" CssClass="adentro-cuadros" OnClick="BD3_Click" Enabled="False" />
            <asp:ImageButton ID="BE3" runat="server" CssClass="adentro-cuadros" OnClick="BE3_Click" Enabled="False" />
            <asp:ImageButton ID="BF3" runat="server" CssClass="adentro-cuadros" OnClick="BF3_Click" Enabled="False" />
            <asp:ImageButton ID="BG3" runat="server" CssClass="adentro-cuadros" OnClick="BG3_Click" Enabled="False" />
            <asp:ImageButton ID="BH3" runat="server" CssClass="adentro-cuadros" OnClick="BH3_Click" Enabled="False" />
        <div class="rodear-rigth">3</div>
    </div>

    <div class="fila" runat="server" id="f4">
        <div class="rodear">4</div>
          <asp:ImageButton ID="BA4" runat="server" CssClass="adentro-cuadros" OnClick="BA4_Click" Enabled="False"  />
          <asp:ImageButton ID="BB4" runat="server" CssClass="adentro-cuadros" OnClick="BB4_Click" Enabled="False"  />
          <asp:ImageButton ID="BC4" runat="server" CssClass="adentro-cuadros" OnClick="BC4_Click" Enabled="False"  />
          <asp:ImageButton ID="BD4" runat="server" CssClass="adentro-cuadros" OnClick="BD4_Click" Enabled="False" ImageUrl="~/IMG/2.png" />
          <asp:ImageButton ID="BE4" runat="server" CssClass="adentro-cuadros" OnClick="BE4_Click" Enabled="False" ImageUrl="~/IMG/1.png" />
          <asp:ImageButton ID="BF4" runat="server" CssClass="adentro-cuadros" OnClick="BF4_Click" Enabled="False" />
          <asp:ImageButton ID="BG4" runat="server" CssClass="adentro-cuadros" OnClick="BG4_Click" Enabled="False" />
          <asp:ImageButton ID="BH4" runat="server" CssClass="adentro-cuadros" OnClick="BH4_Click" Enabled="False" />
        <div class="rodear-rigth">4</div>
    </div>

    <div class="fila" runat="server" id="f5">
        <div class="rodear">5</div>
          <asp:ImageButton ID="BA5" runat="server" CssClass="adentro-cuadros" OnClick="BA5_Click" Enabled="False" />
          <asp:ImageButton ID="BB5" runat="server" CssClass="adentro-cuadros" OnClick="BB5_Click" Enabled="False" />
          <asp:ImageButton ID="BC5" runat="server" CssClass="adentro-cuadros" OnClick="BC5_Click" Enabled="False" />
          <asp:ImageButton ID="BD5" runat="server" CssClass="adentro-cuadros" OnClick="BD5_Click" Enabled="False" ImageUrl="~/IMG/1.png" />
          <asp:ImageButton ID="BE5" runat="server" CssClass="adentro-cuadros" OnClick="BE5_Click" Enabled="False" ImageUrl="~/IMG/2.png" />
          <asp:ImageButton ID="BF5" runat="server" CssClass="adentro-cuadros" OnClick="BF5_Click" Enabled="False" />
          <asp:ImageButton ID="BG5" runat="server" CssClass="adentro-cuadros" OnClick="BG5_Click" Enabled="False" />
          <asp:ImageButton ID="BH5" runat="server" CssClass="adentro-cuadros" OnClick="BH5_Click" Enabled="False" />
        <div class="rodear-rigth">5</div>
    </div>

    <div class="fila" runat="server" id="f6">
        <div class="rodear">6</div>
          <asp:ImageButton ID="BA6" runat="server" CssClass="adentro-cuadros" OnClick="BA6_Click" Enabled="False" />
          <asp:ImageButton ID="BB6" runat="server" CssClass="adentro-cuadros" OnClick="BB6_Click" Enabled="False" />
          <asp:ImageButton ID="BC6" runat="server" CssClass="adentro-cuadros" OnClick="BC6_Click" Enabled="False" />
          <asp:ImageButton ID="BD6" runat="server" CssClass="adentro-cuadros" OnClick="BD6_Click" Enabled="False" />
          <asp:ImageButton ID="BE6" runat="server" CssClass="adentro-cuadros" OnClick="BE6_Click" Enabled="False" />
          <asp:ImageButton ID="BF6" runat="server" CssClass="adentro-cuadros" OnClick="BF6_Click" Enabled="False" />
          <asp:ImageButton ID="BG6" runat="server" CssClass="adentro-cuadros" OnClick="BG6_Click" Enabled="False" />
          <asp:ImageButton ID="BH6" runat="server" CssClass="adentro-cuadros" OnClick="BH6_Click" Enabled="False" />
        <div class="rodear-rigth">6</div>
    </div>

    <div class="fila" runat="server" id="f7">
        <div class="rodear">7</div>
          <asp:ImageButton ID="BA7" runat="server" CssClass="adentro-cuadros" OnClick="BA7_Click" Enabled="False" />
          <asp:ImageButton ID="BB7" runat="server" CssClass="adentro-cuadros" OnClick="BB7_Click" Enabled="False" />
          <asp:ImageButton ID="BC7" runat="server" CssClass="adentro-cuadros" OnClick="BC7_Click" Enabled="False" />
          <asp:ImageButton ID="BD7" runat="server" CssClass="adentro-cuadros" OnClick="BD7_Click" Enabled="False" />
          <asp:ImageButton ID="BE7" runat="server" CssClass="adentro-cuadros" OnClick="BE7_Click" Enabled="False" />
          <asp:ImageButton ID="BF7" runat="server" CssClass="adentro-cuadros" OnClick="BF7_Click" Enabled="False" />
          <asp:ImageButton ID="BG7" runat="server" CssClass="adentro-cuadros" OnClick="BG7_Click" Enabled="False" />
          <asp:ImageButton ID="BH7" runat="server" CssClass="adentro-cuadros" OnClick="BH7_Click" Enabled="False" />
        <div class="rodear-rigth">7</div>
    </div>

    <div class="fila" runat="server" id="f8">
        <div class="rodear">8</div>
          <asp:ImageButton ID="BA8" runat="server" CssClass="adentro-cuadros" OnClick="BA8_Click" Enabled="False"/>
          <asp:ImageButton ID="BB8" runat="server" CssClass="adentro-cuadros" OnClick="BB8_Click" Enabled="False" />
          <asp:ImageButton ID="BC8" runat="server" CssClass="adentro-cuadros" OnClick="BC8_Click" Enabled="False" />
          <asp:ImageButton ID="BD8" runat="server" CssClass="adentro-cuadros" OnClick="BD8_Click" Enabled="False" />
          <asp:ImageButton ID="BE8" runat="server" CssClass="adentro-cuadros" OnClick="BE8_Click" Enabled="False" />
          <asp:ImageButton ID="BF8" runat="server" CssClass="adentro-cuadros" OnClick="BF8_Click" Enabled="False" />
          <asp:ImageButton ID="BG8" runat="server" CssClass="adentro-cuadros" OnClick="BG8_Click" Enabled="False" />
          <asp:ImageButton ID="BH8" runat="server" CssClass="adentro-cuadros" OnClick="BH8_Click" Enabled="False" />
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
</section>
    <div class="container">
        <div class="row CarSal">
            <div class="col-md-1">
                <asp:Button ID="Guardar" runat="server" Text="Salvar" OnClick="Guardar_Click" />
            </div>
            <div class="col-md-5">
                <asp:TextBox ID="NombreSalvar" runat="server" placeholder="INGRESE EL NOMBRE DEL ARCHIVO PARA SALVAR" Width="100%"></asp:TextBox>
            </div>
            <div class="col-md-1" >
                <asp:Button ID="Cargar" runat="server" Text="Cargar" OnClick="Cargar_Click" />
            </div>
            <div class="col-md-5">
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </div>
        </div>
    </div>


</asp:Content>
