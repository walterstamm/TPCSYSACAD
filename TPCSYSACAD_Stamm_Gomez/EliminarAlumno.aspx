<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarAlumno.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.EliminarAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-group">
        <asp:Label Text="ID_ALUMNO" runat="server" Width="200px" />
        <asp:TextBox runat="server" ID="text_idalumno" Enabled="false"/>
    </div>

    <div class="form-group">
        <asp:Label Text="CUIL" runat="server" Width="200px" />
        <asp:TextBox runat="server" ID="text_cuil" Enabled="true"/>
    </div>

    <div class="form-group">
        <asp:Label Text="APELLIDO Y NOMBRE" runat="server" Width="200px" />
        <asp:TextBox runat="server" ID="text_apellidonombre" Enabled="true"/>
    </div>

    <div class="form-group">
        <asp:Label Text="NACIONALIDAD" runat="server" Width="200px" />
        <asp:TextBox runat="server" ID="text_nacionalidad" Enabled="true"/>
    </div>

    <div class="form-group">
        <asp:Label Text="FECHA NACIMIENTO" runat="server" Width="200px" />
        <asp:TextBox runat="server" ID="text_fechanacimiento" Enabled="true"/>
    </div>

    <div class="form-group">
        <asp:Label Text="CORREO ELECTRONICO" runat="server" Width="200px" />
        <asp:TextBox runat="server" ID="text_mail" Enabled="true"/>
    </div>

    <div class="form-group">
        <asp:Label Text="DOMICILIO" runat="server" Width="200px" />
        <asp:TextBox runat="server" ID="text_domicilio" Enabled="true"/>
    </div>

    <div class="form-group">
        <asp:Label Text="LOCALIDAD Y PROVINCIA" runat="server" Width="200px" />
        <asp:TextBox runat="server" ID="text_localidadpcia" Enabled="true"/>
    </div>
    <%--<div class="form-group">
        <asp:Label Text="USUARIO" runat="server" Width="200px" />
        <asp:TextBox runat="server" ID="text_usuario" Enabled="false"/>
    </div>
    <div class="form-group">
        <asp:Label Text="ESTADO" runat="server" Width="200px" />
        <asp:TextBox runat="server" ID="text_estado" Enabled="false"/>
    </div>--%>

    <br />  <br />
    <div class="form-group">
        <asp:Button Class="btn btn-danger" Text="ELIMINAR.DOCENTE" ID="EliminarAlumno" OnClick="EliminarAlumno_Click" runat="server" />
    </div>

</asp:Content>
