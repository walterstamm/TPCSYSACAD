<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargaDocente.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.CargaDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

       <h1>ALTA DE DOCENTE</h1>
    <br />
    
    <div>
        <asp:Label Text="CUIL DOCENTE" runat="server" Width="160px" />
        <asp:TextBox ID="text_doc_Cuil" runat="server" />
    </div>

    <div>
        <asp:Label Text="APELLIDO Y NOMBRE" runat="server" Width="160px" />
        <asp:TextBox ID="text_doc_ApellidoNombre" runat="server" />
    </div>
    
    <div>
        <asp:Label Text="NACIONALIDAD" runat="server" Width="160px" />
        <asp:TextBox ID="text_doc_Nacionalidad" runat="server" />
    </div>
    
    <div>
        <asp:Label Text="FECHA NACIMIENTO" runat="server" Width="160px" />
        <asp:TextBox ID="text_doc_FechaNac" TextMode="Date" runat="server" />
    </div>
    <br />
    <div>
        <asp:Label Text="CORREO ELECTRONICO" runat="server" Width="160px" />
        <asp:TextBox ID="text_doc_Mail" runat="server" />
    </div>
    
    <div>
        <asp:Label Text="DOMICILIO" runat="server" Width="160px" />
        <asp:TextBox ID="text_doc_Domicilio" runat="server" />
    </div>
    
    <div>
        <asp:Label Text="LOCALIDAD Y PROVINCIA" runat="server" Width="160px" />
        <asp:TextBox ID="text_doc_Localidad" runat="server" />
    </div>
    <br />
    <asp:Button class="btn btn-success" Text="AGREGAR" ID="btn_doc_Agregar" OnClick="btn_doc_Agregar_Click" runat="server" />

</asp:Content>
