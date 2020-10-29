<%@ Page Title="Extreme" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Extreme.aspx.cs" Inherits="GAME.Extreme" %>

<asp:Content ID="Control" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate> 
            <asp:Label ID="P_1" runat="server" Enabled="False">0</asp:Label>
            <asp:Label ID="P_2" runat="server" Enabled="False">0</asp:Label>
            <asp:Timer ID="Player1" runat="server" Interval="1000" Enabled="False" OnTick="Player1_Tick"></asp:Timer>
            <asp:Timer ID="Player2" runat="server" Interval="1000" Enabled="True" OnTick="Player2_Tick"></asp:Timer>
        </ContentTemplate>
    </asp:UpdatePanel>

    

    <asp:Panel ID="Panel1" runat="server"></asp:Panel>
    
    <asp:Label ID="TT" runat="server" Text="CONSOLA 1" Height="500px" Width="50%" BackColor="#00CC00"></asp:Label>

    
    
    

</asp:Content>
