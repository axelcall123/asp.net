<%@ Page Title="Torneo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"  CodeBehind="Torneo.aspx.cs" Inherits="GAME.Torneo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="Verdad" runat="server" Text="8x8" OnClick="Verdad_Click" />
    <asp:Button ID="Verdad_2" runat="server" Text="4x4" OnClick="Verdad_2_Click" />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    
    
    <asp:UpdatePanel ID="All" runat="server" Visible="False">
        <ContentTemplate>
            <!--NUMERO 8-->
            <div class="Ronda">
                <asp:UpdatePanel ID="Ocho_U" runat="server" Visible="False">
                    <ContentTemplate>
                        <div>
                            <asp:Button ID="D_Uno_1" runat="server" Text="----" Enabled="False" />
                            <asp:Button ID="D_GanarT1_1" runat="server" Text="W" OnClick="D_GanarT1_1_Click" />
                        </div>
                        <div>
                            <asp:Button ID="D_Dos_1" runat="server" Text="----" Enabled="False" />
                            <asp:Button ID="D_GanarT1_2" runat="server" Text="W" OnClick="D_GanarT1_2_Click" />
                        </div> 
                        <br />
                        <div>
                            <asp:Button ID="D_Tres_1" runat="server" Text="----" Enabled="False" />
                            <asp:Button ID="D_GanarT1_3" runat="server" Text="W" OnClick="D_GanarT1_3_Click" />
                        </div>
                        <div>
                            <asp:Button ID="D_Cuatro_1" runat="server" Text="----" Enabled="False" />
                            <asp:Button ID="D_GanarT1_4" runat="server" Text="W" OnClick="D_GanarT1_4_Click" />
                        </div>
                        <br />
                        <div>
                            <asp:Button ID="D_Cinco_1" runat="server" Text="----" Enabled="False" />
                            <asp:Button ID="D_GanarT1_5" runat="server" Text="W" OnClick="D_GanarT1_5_Click" />
                        </div>
                        <div>
                            <asp:Button ID="D_Seis_1" runat="server" Text="----" Enabled="False" />
                            <asp:Button ID="D_GanarT1_6" runat="server" Text="W" OnClick="D_GanarT1_6_Click" />
                        </div>
                        <br />

                        <div>
                            <asp:Button ID="D_Siete_1" runat="server" Text="----" Enabled="False" />
                            <asp:Button ID="D_GanarT1_7" runat="server" Text="W" OnClick="D_GanarT1_7_Click" />
                        </div>
                        <div>
                            <asp:Button ID="D_Ocho_1" runat="server" Text="----" Enabled="False" />
                            <asp:Button ID="D_GanarT1_8" runat="server" Text="W" OnClick="D_GanarT1_8_Click" />
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <!--NUMERO 4-->
            <div class="Ronda">
                <br />
                <div>
                    <asp:Button ID="D_Uno_2" runat="server" Text="----" Enabled="False" />
                    <asp:Button ID="D_GanarT2_1" runat="server" Text="W" OnClick="D_GanarT2_1_Click" />
                </div>
                <div>
                    <asp:Button ID="D_Dos_2" runat="server" Text="----" Enabled="False" />
                    <asp:Button ID="D_GanarT2_2" runat="server" Text="W" OnClick="D_GanarT2_2_Click" />
                </div>
                <br />

                <div>
                    <asp:Button ID="D_Tres_2" runat="server" Text="----" Enabled="False" />
                    <asp:Button ID="D_GanarT2_3" runat="server" Text="W" OnClick="D_GanarT2_3_Click" />
                </div>
                <div>
                    <asp:Button ID="D_Cuatro_2" runat="server" Text="----" Enabled="False" />
                    <asp:Button ID="D_GanarT2_4" runat="server" Text="W" OnClick="D_GanarT2_4_Click" />
                </div>
            </div>
            <!--NUMERO 2-->
            <div class="Ronda">
                <div>
                    <asp:Button ID="D_Uno_3" runat="server" Text="----" Enabled="False" />
                    <asp:Button ID="D_GanarT3_1" runat="server" Text="W" OnClick="D_GanarT3_1_Click" />
                </div>
                <div>
                    <asp:Button ID="D_Dos_3" runat="server" Text="----" Enabled="False" />
                    <asp:Button ID="D_GanarT3_2" runat="server" Text="W" OnClick="D_GanarT3_2_Click" />
                </div>
            </div>
            <!--NUMERO 1-->
            <div class="Ronda" > 
                <div>
                    <asp:Button ID="D_Uno_4" runat="server" Text="----" Enabled="False" />
                    <asp:Button ID="D_GanarT4_1" runat="server" Text="W" OnClick="D_GanarT4_1_Click" />
                </div>
            </div>


            <div class="Ronda" > 
              <div>
                  <asp:Button ID="I_GanarT4_1" runat="server" Text="W"  />
                  <asp:Button ID="I_Uno_4" runat="server" Text="----" Enabled="False" OnClick="I_Uno_4_Click" />
              </div>
            </div>
            <!--NUMERO DOS-->
            <div class="Ronda" > 
              <div>
                  <asp:Button ID="I_GanarT3_1" runat="server" Text="W" OnClick="I_GanarT3_1_Click"  />
                  <asp:Button ID="I_Uno_3" runat="server" Text="----" Enabled="False"  />
              </div>
              <div>
                  <asp:Button ID="I_GanarT3_2" runat="server" Text="W" OnClick="I_GanarT3_2_Click"  />
                  <asp:Button ID="I_Dos_3" runat="server" Text="----" Enabled="False"  />
              </div>
            </div>
            <!--NUMERO 4-->
            <div class="Ronda" > 
              <br />
              <div>
                  <asp:Button ID="I_GanarT2_1" runat="server" Text="W" OnClick="I_GanarT2_1_Click"  />
                  <asp:Button ID="I_Uno_2" runat="server" Text="----" Enabled="False" />
              </div>
              <div>
                  <asp:Button ID="I_GanarT2_2" runat="server" Text="W" OnClick="I_GanarT2_2_Click"  />
                  <asp:Button ID="I_Dos_2" runat="server" Text="----" Enabled="False" />                 
              </div>
              <br />

              <div>
                  <asp:Button ID="I_GanarT2_3" runat="server" Text="W" OnClick="I_GanarT2_3_Click"  />
                  <asp:Button ID="I_Tres_2" runat="server" Text="----" Enabled="False" />
              </div>
              <div>
                  <asp:Button ID="I_GanarT2_4" runat="server" Text="W" OnClick="I_GanarT2_4_Click"  />
                  <asp:Button ID="I_Cuatro_2" runat="server" Text="----" Enabled="False" /> 
              </div>
            </div>
            <!--NUMERO 8-->
            <div class="Ronda" >
                <asp:UpdatePanel ID="Ocho_D" runat="server" Visible="False">
                    <ContentTemplate>
                        <div>
                              <asp:Button ID="I_GanarT1_1" runat="server" Text="W" OnClick="I_GanarT1_1_Click1" />
                              <asp:Button ID="I_Uno_1" runat="server" Text="----" Enabled="False" />
                          </div>
                          <div>
                              <asp:Button ID="I_GanarT1_2" runat="server" Text="W" OnClick="I_GanarT1_2_Click" />
                              <asp:Button ID="I_Dos_1" runat="server" Text="----" Enabled="False" />
                          </div> 
                          <br />

                          <div>
                              <asp:Button ID="I_GanarT1_3" runat="server" Text="W" OnClick="I_GanarT1_3_Click" />
                              <asp:Button ID="I_Tres_1" runat="server" Text="----" Enabled="False" />
                          </div>
                          <div>
                              <asp:Button ID="I_GanarT1_4" runat="server" Text="W" OnClick="I_GanarT1_4_Click"  />
                              <asp:Button ID="I_Cuatro_1" runat="server" Text="----" Enabled="False" />
                          </div>
                          <br />

                          <div>
                              <asp:Button ID="I_GanarT1_5" runat="server" Text="W" OnClick="I_GanarT1_5_Click"  />
                              <asp:Button ID="I_Cinco_1" runat="server" Text="----" Enabled="False" />
                          </div>
                          <div>
                              <asp:Button ID="I_GanarT1_6" runat="server" Text="W" OnClick="I_GanarT1_6_Click"  />
                              <asp:Button ID="I_Seis_1" runat="server" Text="----" Enabled="False" />
                          </div>
                          <br />

                          <div>
                              <asp:Button ID="I_GanarT1_7" runat="server" Text="W"  OnClick="I_GanarT1_7_Click"/>
                              <asp:Button ID="I_Siete_1" runat="server" Text="----" Enabled="False" />
                          </div>
                          <div>
                              <asp:Button ID="I_GanarT1_8" runat="server" Text="W" OnClick="I_GanarT1_8_Click"  />
                              <asp:Button ID="I_Ocho_1" runat="server" Text="----" Enabled="False" />
                          </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <br />
    <br />
    <br />
</asp:Content>

