<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarDocente.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.EliminarDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1> ELIMINAR ALUMNOS </h1>
    <div class="form-group">
        <asp:Label Text="ID_ALUMNO" runat="server" Width="200px" />
        <asp:TextBox runat="server" ID="text_doc_iddocente" Enabled="false"/>
    </div>

    <div class="form-group">
        <asp:Label Text="CUIL" runat="server" Width="200px" />
        <asp:TextBox runat="server" ID="text_doc_cuil" Enabled="true"/>
    </div>

    <div class="form-group">
        <asp:Label Text="APELLIDOS" runat="server" Width="200px" />
        <asp:TextBox runat="server" ID="text_doc_apellido" Enabled="true"/>
    </div>

    <div>
        <asp:Label Text="NOMBRES" runat="server" Width="200px" />
        <asp:TextBox ID="text_doc_nombre" runat="server" Enabled="true" />
    </div>

    <div class="form-group">
        <asp:Label Text="NACIONALIDAD" runat="server" Width="200px" />
        <asp:TextBox runat="server" ID="text_doc_nacionalidad" Enabled="true"/>
    </div>

    <div class="form-group">
        <asp:Label Text="FECHA NACIMIENTO" runat="server" Width="200px" />
        <asp:TextBox runat="server" ID="text_doc_fechanacimiento" Enabled="true"/>
    </div>

    <div class="form-group">
        <asp:Label Text="CORREO ELECTRONICO" runat="server" Width="200px" />
        <asp:TextBox runat="server" ID="text_doc_mail" Enabled="true"/>
    </div>

    <div class="form-group">
        <asp:Label Text="DOMICILIO" runat="server" Width="200px" />
        <asp:TextBox runat="server" ID="text_doc_domicilio" Enabled="true"/>
    </div>

    <div class="form-group">
        <asp:Label Text="LOCALIDAD Y PROVINCIA" runat="server" Width="200px" />
        <asp:TextBox runat="server" ID="text_doc_localidadpcia" Enabled="true"/>
    </div>
    <%--<div class="form-group">
        <asp:Label Text="USUARIO" runat="server" Width="200px" />
        <asp:TextBox runat="server" ID="text_doc_usuario" Enabled="false"/>
    </div>
    <div class="form-group">
        <asp:Label Text="ESTADO" runat="server" Width="200px" />
        <asp:TextBox runat="server" ID="text_doc_estado" Enabled="false"/>
    </div>--%>

    <br />  <br />
    <div class="form-group">
        <asp:Button Class="btn btn-danger" Text="ELIMINAR.DOCENTE" ID="EliminDocente" OnClick="EliminarDocente_Click" runat="server" />
    </div>

</asp:Content>
