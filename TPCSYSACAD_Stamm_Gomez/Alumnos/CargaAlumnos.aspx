<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargaAlumnos.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.CargaAlumnos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1 style="text-align: center;">ALTA DE ALUMNOS</h1>
    <br />
    <div class="row g-3 ">
        <div class="input-group mb-3">
            <asp:Label Text="Cuil" runat="server" Width="160px" class="input-group-text" />
            <asp:TextBox ID="text_Cuil" runat="server"  class="form-control"/>
        </div>

        <div class="input-group mb-3">
            <asp:Label Text="Apellido" class="input-group-text" runat="server" Width="160px" />
            <asp:TextBox ID="text_Apellido" runat="server"  class="form-control"/>
        </div>

        <div class="input-group mb-3">
            <asp:Label Text="Nombre" class="input-group-text" runat="server" Width="160px" />
            <asp:TextBox ID="text_Nombre" runat="server"  class="form-control"/>
        </div>


        <div class="input-group mb-3">
            <asp:Label Text="Fecha de Nacimiento"  class="input-group-text" runat="server" Width="160px" />
            <asp:TextBox ID="text_FechaNac" TextMode="Date" runat="server" class="form-control" />
        </div>
        <br />
        <div class="input-group mb-3">
            <asp:Label Text="Email" runat="server" class="input-group-text" Width="160px" />
            <asp:TextBox ID="text_Mail" runat="server"  class="form-control"/>
        </div>

        <div class="input-group mb-3">
            <asp:Label Text="Domicilio" runat="server" class="input-group-text" Width="160px" />
            <asp:TextBox ID="text_Domicilio" runat="server" />
        </div>

        <div class="input-group mb-3">
            <asp:Label Text="Localidad" runat="server" class="input-group-text" Width="160px" />
            <asp:TextBox ID="text_Localidad" runat="server"  class="form-control"/>
        </div>
    </div>
    <br />
    <asp:Button class="btn btn-success" Text="Agregar" ID="btn_Agregar" OnClick="btn_Agregar_Click" runat="server" />
</asp:Content>

