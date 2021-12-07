<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inscribir_Alum_Carrera.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.Inscribir_Alum_Carrera" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




    <br />
    <h5>INSCRIBIR A LOS ALUMNOS A LA CARRERA</h5>
    <div class="form-group">
        <asp:Label Text="ID_ALUMNO" runat="server" Width="200px" />
        <asp:TextBox runat="server" ID="text_Id_alumno" Enabled="false"/>
    </div>
    <div class="form-group">
        <asp:Label Text="APELLIDOS" runat="server" width="200px"/>
        <asp:TextBox runat="server" ID="text_Apellido"/>
    </div>

    <div class="form-group">
        <asp:Label Text="NOMBRE" runat="server" Width="200px" />
        <asp:TextBox runat="server" ID="text_Nombre" Enabled="false"/>
    </div>


    <br />
    <h5>DROPDOWNLIST DINAMICO</h5>
    
    <asp:DropDownList runat="server" ID="ddlCarreras" OnSelectedIndexChanged="ddl_carreras_SelectedIndexChanged" CssClass="btn btn-outline-dark dropdown-toggle" >
    </asp:DropDownList>
    <br />  <br />
     <asp:Button class="btn btn-success" Text="INSCRIBIR EN CARRERA" ID="btn_Incribir" OnClick="btn_Incribir_Click" runat="server" />
    <br />
</asp:Content>
