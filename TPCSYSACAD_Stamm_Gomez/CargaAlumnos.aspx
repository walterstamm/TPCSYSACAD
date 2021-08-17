<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargaAlumnos.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.CargaAlumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>ALTA DE ALUMNOS</h1>
    <br />
    
    <div>
        <asp:Label Text="CUIL ALUMNO" runat="server" Width="160px" />
        <asp:TextBox ID="text_Cuil" runat="server" />
    </div>

    <div>
        <asp:Label Text="APELLIDO Y NOMBRE" runat="server" Width="160px" />
        <asp:TextBox ID="text_ApellidoNombre" runat="server" />
    </div>
    
    <div>
        <asp:Label Text="NACIONALIDAD" runat="server" Width="160px" />
        <asp:TextBox ID="text_Nacionalidad" runat="server" />
    </div>
    
    <div>
        <asp:Label Text="FECHA NACIMIENTO" runat="server" Width="160px" />
        <asp:TextBox ID="text_FechaNac" TextMode="Date" runat="server" />
    </div>
    <br />
    <div>
        <asp:Label Text="CORREO ELECTRONICO" runat="server" Width="160px" />
        <asp:TextBox ID="text_Mail" runat="server" />
    </div>
    
    <div>
        <asp:Label Text="DOMICILIO" runat="server" Width="160px" />
        <asp:TextBox ID="text_Domicilio" runat="server" />
    </div>
    
    <div>
        <asp:Label Text="LOCALIDAD Y PROVINCIA" runat="server" Width="160px" />
        <asp:TextBox ID="text_Localidad" runat="server" />
    </div>
    <br />
    <asp:Button Text="AGREGAR" ID="btn_Agregar" OnClick="btn_Agregar_Click" runat="server" />
</asp:Content>

