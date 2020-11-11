<%@ Page Title="Torneo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"  CodeBehind="Torneo.aspx.cs" Inherits="GAME.Torneo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="Verdad" runat="server" Text="8X2" OnClick="Verdad_Click" />
    <asp:Button ID="Verdad_2" runat="server" Text="4X2" OnClick="Verdad_2_Click" Width="38px" />
    <asp:Button ID="Verdad_3" runat="server" Text="2X2" OnClick="Verdad_3_Click"/>
    <asp:Button ID="Cod" runat="server" Text="Ver Codigo" OnClick="Cod_Click" />
    <br />
    <br />
    <asp:UpdatePanel ID="All" runat="server" Visible="False">
        <ContentTemplate>
            <!--NUMERO 8-->
            <div class="Ronda">
                <asp:UpdatePanel ID="Ocho_U" runat="server" Visible="False">
                    <ContentTemplate>
                      <div class="VS">  
                        <div><!--UNO-->
                            <asp:Button ID="D_Uno_1" runat="server" Text="----" Enabled="False" />
                            <asp:Button ID="D_GanarT1_1" runat="server" Text="W" OnClick="D_GanarT1_1_Click" />
                            <div class="Linea"></div>
                            <asp:Button ID="D_UB_1_1" runat="server" Text="2" class="Opciones" OnClick="D_UB_1_1_Click" />
                        </div>
                        <div><!--DOS-->
                            <asp:Button ID="D_Dos_1" runat="server" Text="----" Enabled="False" />
                            <asp:Button ID="D_GanarT1_2" runat="server" Text="W" OnClick="D_GanarT1_2_Click" />
                        </div> 
                      </div>
                      <!--vs-->
                      <div class="VS"> 
                        <div><!--TRES-->
                            <asp:Button ID="D_Tres_1" runat="server" Text="----" Enabled="False" />
                            <asp:Button ID="D_GanarT1_3" runat="server" Text="W" OnClick="D_GanarT1_3_Click" />
                            <div class="Linea"></div>
                            <asp:Button ID="D_UB_3_1" runat="server" Text="1" class="Opciones" OnClick="D_UB_3_1_Click"/>
                        </div>
                        <div><!--CUATRO-->
                            <asp:Button ID="D_Cuatro_1" runat="server" Text="----" Enabled="False" />
                            <asp:Button ID="D_GanarT1_4" runat="server" Text="W" OnClick="D_GanarT1_4_Click" />
                        </div>
                        </div>
                        <!--vs-->
                        <div class="VS">
                        <div><!--CINCO-->
                            <asp:Button ID="D_Cinco_1" runat="server" Text="----" Enabled="False" />
                            <asp:Button ID="D_GanarT1_5" runat="server" Text="W" OnClick="D_GanarT1_5_Click" />
                            <div class="Linea"></div>
                            <asp:Button ID="D_UB_5_1" runat="server" Text="1" class="Opciones" OnClick="D_UB_5_1_Click"/>
                        </div>
                        <div><!--SEIS-->
                            <asp:Button ID="D_Seis_1" runat="server" Text="----" Enabled="False" />
                            <asp:Button ID="D_GanarT1_6" runat="server" Text="W" OnClick="D_GanarT1_6_Click" />
                        </div>
                        </div>
                        <!--vs-->
                        <div class="VS">
                        <div><!--SIETE-->
                            <asp:Button ID="D_Siete_1" runat="server" Text="----" Enabled="False" />
                            <asp:Button ID="D_GanarT1_7" runat="server" Text="W" OnClick="D_GanarT1_7_Click" />
                            <div class="Linea"></div>
                            <asp:Button ID="D_UB_7_1" runat="server" Text="1" class="Opciones" OnClick="D_UB_7_1_Click"/>
                        </div>
                        <div><!--OCHO-->
                            <asp:Button ID="D_Ocho_1" runat="server" Text="----" Enabled="False" />
                            <asp:Button ID="D_GanarT1_8" runat="server" Text="W" OnClick="D_GanarT1_8_Click" />
                        </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <!--NUMERO 4-->
            <div class="Ronda">
                <br />
                <asp:UpdatePanel ID="Cuatro_U" runat="server" Visible="False">
                    <ContentTemplate>
                        <div class="VS">
                        <div><!--UNO-->
                            <asp:Button ID="D_Uno_2" runat="server" Text="----" Enabled="False" />
                            <asp:Button ID="D_GanarT2_1" runat="server" Text="W" OnClick="D_GanarT2_1_Click" />
                            <div class="Linea"></div>
                            <asp:Button ID="D_DB_1_1" runat="server" Text="1" class="Opciones" OnClick="D_DB_1_1_Click"/>
                        </div>
                        <div><!--DOS-->
                            <asp:Button ID="D_Dos_2" runat="server" Text="----" Enabled="False" />
                            <asp:Button ID="D_GanarT2_2" runat="server" Text="W" OnClick="D_GanarT2_2_Click" />
                        </div>
                        </div>
                        <!--vs-->
                        <div class="VS">
                        <div><!--TRES-->
                            <asp:Button ID="D_Tres_2" runat="server" Text="----" Enabled="False" />
                            <asp:Button ID="D_GanarT2_3" runat="server" Text="W" OnClick="D_GanarT2_3_Click" />
                            <div class="Linea"></div>
                            <asp:Button ID="D_DB_3_1" runat="server" Text="1" class="Opciones" OnClick="D_DB_3_1_Click"/>
                        </div>
                        <div><!--CUATRO-->
                            <asp:Button ID="D_Cuatro_2" runat="server" Text="----" Enabled="False" />
                            <asp:Button ID="D_GanarT2_4" runat="server" Text="W" OnClick="D_GanarT2_4_Click" />
                        </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <!--NUMERO 2-->
            <div class="Ronda">
                <div class="VS">
                <div><!--UNO-->
                    <asp:Button ID="D_Uno_3" runat="server" Text="----" Enabled="False" />
                    <asp:Button ID="D_GanarT3_1" runat="server" Text="W" OnClick="D_GanarT3_1_Click" />
                    <div class="Linea"></div>
                    <asp:Button ID="D_TB_1_1" runat="server" Text="1" class="Opciones" OnClick="D_TB_1_1_Click"/>
                </div>
                <div><!--DOS-->
                    <asp:Button ID="D_Dos_3" runat="server" Text="----" Enabled="False" />
                    <asp:Button ID="D_GanarT3_2" runat="server" Text="W" OnClick="D_GanarT3_2_Click" />
                </div>
                </div>
            </div>
            <!--NUMERO 1-->
            <div class="Ronda" >
                <br>
                <div class="VS">
                <div><!--UNO-->
                    <asp:Button ID="D_Uno_4" runat="server" Text="----" Enabled="False" />
                    <asp:Button ID="D_GanarT4_1" runat="server" Text="W" OnClick="D_GanarT4_1_Click" />  
                    <div class="Linea"></div>
                    <asp:Button ID="D_CB_1_1" runat="server" Text="1" class="Opciones"/>
                </div>
                </div>
            </div>
            <!--//--->
            <div class="Ronda" >
              <br>
               <div class="VS">
              <div><!--UNO-->
                  <asp:Button ID="I_GanarT4_1" runat="server" Text="W"  />
                  <asp:Button ID="I_Uno_4" runat="server" Text="----" Enabled="False" OnClick="I_Uno_4_Click" />
                  <div class="Linea"></div>
                  <asp:Button ID="I_CB_1_1" runat="server" Text="1" class="Opciones"/>
              </div>
              </div>
            </div>
            <!--NUMERO DOS-->
            <div class="Ronda" >
              <div class="VS"> 
              <div><!--UNO-->
                  <asp:Button ID="I_GanarT3_1" runat="server" Text="W" OnClick="I_GanarT3_1_Click"  />
                  <asp:Button ID="I_Uno_3" runat="server" Text="----" Enabled="False"  />
                  <div class="Linea"></div>
                  <asp:Button ID="I_TB_1_1" runat="server" Text="1" class="Opciones" OnClick="I_TB_1_1_Click"/>
              </div>
              <div><!--DOS-->
                  <asp:Button ID="I_GanarT3_2" runat="server" Text="W" OnClick="I_GanarT3_2_Click"  />
                  <asp:Button ID="I_Dos_3" runat="server" Text="----" Enabled="False"  />
              </div>
              </div>
            </div>
            <!--NUMERO 4-->
            <div class="Ronda" > 
              <br />
                <asp:UpdatePanel ID="Cuatro_D" runat="server" Visible="False">
                    <ContentTemplate>
                      <div class="VS">
                      <div><!--UNO-->
                          <asp:Button ID="I_GanarT2_1" runat="server" Text="W" OnClick="I_GanarT2_1_Click"  />
                          <asp:Button ID="I_Uno_2" runat="server" Text="----" Enabled="False" />
                          <div class="Linea"></div>
                            <asp:Button ID="I_DB_1_1" runat="server" Text="1" class="Opciones" OnClick="I_DB_1_1_Click"/>
                      </div>
                      <div><!--DOS-->
                          <asp:Button ID="I_GanarT2_2" runat="server" Text="W" OnClick="I_GanarT2_2_Click"  />
                          <asp:Button ID="I_Dos_2" runat="server" Text="----" Enabled="False" />
                      </div>
                      </div>
                      <!--vs-->
                      <div class="VS">
                      <div><!--TRES-->
                          <asp:Button ID="I_GanarT2_3" runat="server" Text="W" OnClick="I_GanarT2_3_Click"  />
                          <asp:Button ID="I_Tres_2" runat="server" Text="----" Enabled="False" />
                          <div class="Linea"></div>
                          <asp:Button ID="I_DB_3_1" runat="server" Text="1" class="Opciones" OnClick="I_DB_3_1_Click"/>
                      </div>
                      <div><!--CUATRO-->
                          <asp:Button ID="I_GanarT2_4" runat="server" Text="W" OnClick="I_GanarT2_4_Click"  />
                          <asp:Button ID="I_Cuatro_2" runat="server" Text="----" Enabled="False" /> 
                      </div>
                      </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <!--NUMERO 8-->
            <div class="Ronda" >
                <asp:UpdatePanel ID="Ocho_D" runat="server" Visible="False">
                    <ContentTemplate>
                      <div class="VS">
                        <div><!--UNO-->
                              <asp:Button ID="I_GanarT1_1" runat="server" Text="W" OnClick="I_GanarT1_1_Click1" />
                              <asp:Button ID="I_Uno_1" runat="server" Text="----" Enabled="False" />
                              <div class="Linea"></div>
                              <asp:Button ID="I_UB_1_1" runat="server" Text="1" class="Opciones" OnClick="I_UB_1_1_Click"/>
                          </div>
                          <div><!--DOS-->
                              <asp:Button ID="I_GanarT1_2" runat="server" Text="W" OnClick="I_GanarT1_2_Click" />
                              <asp:Button ID="I_Dos_1" runat="server" Text="----" Enabled="False" />
                          </div> 
                          </div>
                          <!--vs-->
                          <div class="VS">
                          <div><!--TRES-->
                              <asp:Button ID="I_GanarT1_3" runat="server" Text="W" OnClick="I_GanarT1_3_Click" />
                              <asp:Button ID="I_Tres_1" runat="server" Text="----" Enabled="False" />
                              <div class="Linea"></div>
                              <asp:Button ID="I_UB_3_1" runat="server" Text="1" class="Opciones" OnClick="I_UB_3_1_Click"/>
                          </div>
                          <div><!--CUATRO-->
                              <asp:Button ID="I_GanarT1_4" runat="server" Text="W" OnClick="I_GanarT1_4_Click"  />
                              <asp:Button ID="I_Cuatro_1" runat="server" Text="----" Enabled="False" />
                          </div>
                          </div>
                          <!--vs-->
                          <div class="VS">
                          <div><!--CINCO-->
                              <asp:Button ID="I_GanarT1_5" runat="server" Text="W" OnClick="I_GanarT1_5_Click"  />
                              <asp:Button ID="I_Cinco_1" runat="server" Text="----" Enabled="False" />
                              <div class="Linea"></div>
                              <asp:Button ID="I_UB_5_1" runat="server" Text="1" class="Opciones" OnClick="I_UB_5_1_Click"/>
                          </div>
                          <div><!--SEIS-->
                              <asp:Button ID="I_GanarT1_6" runat="server" Text="W" OnClick="I_GanarT1_6_Click"  />
                              <asp:Button ID="I_Seis_1" runat="server" Text="----" Enabled="False" />
                          </div>
                          </div>
                          <!--vs-->
                          <div class="VS">
                          <div><!--SIETE-->
                              <asp:Button ID="I_GanarT1_7" runat="server" Text="W"  OnClick="I_GanarT1_7_Click"/>
                              <asp:Button ID="I_Siete_1" runat="server" Text="----" Enabled="False" />
                              <div class="Linea"></div>
                              <asp:Button ID="I_UB_7_1" runat="server" Text="1" class="Opciones" OnClick="I_UB_7_1_Click"/>
                          </div>
                          <div><!--OCHO-->
                              <asp:Button ID="I_GanarT1_8" runat="server" Text="W" OnClick="I_GanarT1_8_Click"  />
                              <asp:Button ID="I_Ocho_1" runat="server" Text="----" Enabled="False" />
                          </div>
                          </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:Label ID="T" runat="server" Text="Label"></asp:Label>
</asp:Content>

