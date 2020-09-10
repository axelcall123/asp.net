<%@ Page EnableEventValidation="false" Title="Registrarse" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="GAME.About" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Registrandose</h1>
   
<form action="~/Default" method="post">
    <div class="col-lg-12">
        <span class="icon-user"></span>
        <!--input type="text" placeholder="NOMBRE" required name="nombre"-->
        <asp:TextBox  type="text" placeholder="NOMBRE" ID="nombre_r" runat="server" required></asp:TextBox>
     </div>
    <div class="col-lg-12">
        <span class="icon-user-tie"></span>
        <!--input type="text" placeholder="APELLIDO" required name="apellido"-->
        <asp:TextBox type="text" placeholder="APELLIDO" ID="apellido_r" runat="server" required></asp:TextBox>
    </div>
    <div class="col-lg-12">
        <span class="icon-users"></span>
        <!--input type="text" placeholder="USUARIO" required name="usuario"-->
        <asp:TextBox type="text" placeholder="USARIO" ID="usuario_r" runat="server" required></asp:TextBox>
    </div>
    <div class="col-lg-12">
        <span class="icon-key"></span>
        <!--input type="password" placeholder="CONTRASEÑA" required name="contraseña"-->
        <asp:TextBox type="password" placeholder="CONTRASEÑA" ID="contraseña_r" runat="server" required></asp:TextBox>
    </div>
    <div class="col-lg-12">
        <span class="icon-calendar"></span>
        <!--input type="date" placeholder="Fecha De Nacimiento" required name="fecha"-->
        <asp:TextBox href="~/Default" type="date" placeholder="FECHA NACIMIENTO" ID="fecha_r" runat="server" required></asp:TextBox>
    </div>
    <div class="col-lg-12">
        <span class="icon-earth"></span>
        <!--input type="text" placeholder="PAIS" required name="pais"-->
        <asp:TextBox type="text" placeholder="PAIS" ID="pais_r" runat="server" required></asp:TextBox>
    </div>
     <div class="col-lg-12">
        <span class="icon-envelop"></span>
        <!--input type="text" placeholder="PAIS" required name="pais"-->
        <asp:TextBox type="email" placeholder="EMAIL" ID="email_r" runat="server" required></asp:TextBox>
    </div>
    <div class="col-lg-12">
        <!--input type="submit" value="enviar" name="Enviar"-->
        <span class="icon-radio-checked"></span>
        <asp:Button ID="Enviar_r" runat="server" Text="Enviar" OnClick="Enviar_r_Click" />


        <br />
    </div>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id_Usuario" DataSourceID="Data" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="Id_Usuario" HeaderText="Id_Usuario" ReadOnly="True" SortExpression="Id_Usuario" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
            <asp:BoundField DataField="Nombre_Usuario" HeaderText="Nombre_Usuario" SortExpression="Nombre_Usuario" />
            <asp:BoundField DataField="Contraseña" HeaderText="Contraseña" SortExpression="Contraseña" />
            <asp:BoundField DataField="Fecha_Nac" HeaderText="Fecha_Nac" SortExpression="Fecha_Nac" />
            <asp:BoundField DataField="Pais" HeaderText="Pais" SortExpression="Pais" />
            <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="Data" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:JuegoConnectionString %>" DeleteCommand="DELETE FROM [Usuario] WHERE [Id_Usuario] = @original_Id_Usuario AND [Nombre] = @original_Nombre AND [Apellido] = @original_Apellido AND [Nombre_Usuario] = @original_Nombre_Usuario AND [Contraseña] = @original_Contraseña AND [Fecha_Nac] = @original_Fecha_Nac AND [Pais] = @original_Pais AND [Correo] = @original_Correo" InsertCommand="INSERT INTO [Usuario] ([Id_Usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contraseña], [Fecha_Nac], [Pais], [Correo]) VALUES (@Id_Usuario, @Nombre, @Apellido, @Nombre_Usuario, @Contraseña, @Fecha_Nac, @Pais, @Correo)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Usuario]" UpdateCommand="UPDATE [Usuario] SET [Nombre] = @Nombre, [Apellido] = @Apellido, [Nombre_Usuario] = @Nombre_Usuario, [Contraseña] = @Contraseña, [Fecha_Nac] = @Fecha_Nac, [Pais] = @Pais, [Correo] = @Correo WHERE [Id_Usuario] = @original_Id_Usuario AND [Nombre] = @original_Nombre AND [Apellido] = @original_Apellido AND [Nombre_Usuario] = @original_Nombre_Usuario AND [Contraseña] = @original_Contraseña AND [Fecha_Nac] = @original_Fecha_Nac AND [Pais] = @original_Pais AND [Correo] = @original_Correo">
        <DeleteParameters>
            <asp:Parameter Name="original_Id_Usuario" Type="Int32" />
            <asp:Parameter Name="original_Nombre" Type="String" />
            <asp:Parameter Name="original_Apellido" Type="String" />
            <asp:Parameter Name="original_Nombre_Usuario" Type="String" />
            <asp:Parameter Name="original_Contraseña" Type="String" />
            <asp:Parameter DbType="Date" Name="original_Fecha_Nac" />
            <asp:Parameter Name="original_Pais" Type="String" />
            <asp:Parameter Name="original_Correo" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Id_Usuario" Type="Int32" />
            <asp:Parameter Name="Nombre" Type="String" />
            <asp:Parameter Name="Apellido" Type="String" />
            <asp:Parameter Name="Nombre_Usuario" Type="String" />
            <asp:Parameter Name="Contraseña" Type="String" />
            <asp:Parameter DbType="Date" Name="Fecha_Nac" />
            <asp:Parameter Name="Pais" Type="String" />
            <asp:Parameter Name="Correo" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Nombre" Type="String" />
            <asp:Parameter Name="Apellido" Type="String" />
            <asp:Parameter Name="Nombre_Usuario" Type="String" />
            <asp:Parameter Name="Contraseña" Type="String" />
            <asp:Parameter DbType="Date" Name="Fecha_Nac" />
            <asp:Parameter Name="Pais" Type="String" />
            <asp:Parameter Name="Correo" Type="String" />
            <asp:Parameter Name="original_Id_Usuario" Type="Int32" />
            <asp:Parameter Name="original_Nombre" Type="String" />
            <asp:Parameter Name="original_Apellido" Type="String" />
            <asp:Parameter Name="original_Nombre_Usuario" Type="String" />
            <asp:Parameter Name="original_Contraseña" Type="String" />
            <asp:Parameter DbType="Date" Name="original_Fecha_Nac" />
            <asp:Parameter Name="original_Pais" Type="String" />
            <asp:Parameter Name="original_Correo" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
</form>
</asp:Content>
