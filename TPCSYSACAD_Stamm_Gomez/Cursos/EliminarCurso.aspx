<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarCurso.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.Cursos.EliminarCurso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-12  text-center">
            <h1>Eliminar Curso </h1>
        </div>
    </div>
    <div class="container">
        <div class="row py-3">
            <div class="col" id="main">
                <div class="col-md-6 col-sm-12">
                    <asp:Label Text="ID" runat="server" Width="200px" />
                    <asp:TextBox runat="server" ID="txtId" Enabled="false" />
                </div>
                <div class="col-md-6 col-sm-12">
                    <asp:Label Text="Cuil" runat="server" Width="200px" />
                    <asp:TextBox runat="server" ID="txtCuil" Enabled="false" />
                </div>
                <div class="col-md-6 col-sm-12">
                    <asp:Label Text="Apellido" runat="server" Width="200px" />
                    <asp:TextBox runat="server" ID="txtApellido" Enabled="false" />
                </div>
                <div class="col-md-6 col-sm-12">
                    <asp:Label Text="Nombre" runat="server" Width="200px" />
                    <asp:TextBox ID="txtNombre" runat="server" Enabled="false" />
                </div>
                <div class="col-md-6 col-sm-12">
                    <asp:Label Text="Materia" runat="server" Width="200px" />
                    <asp:TextBox runat="server" ID="txtMateria" Enabled="false" />
                </div>
                <div class="col-md-6 col-sm-12">
                    <asp:Label Text="Cuatrimestre" runat="server" Width="200px" />
                    <asp:TextBox runat="server" ID="txtCuatrimestre" Enabled="false" />
                </div>
                <div class="col-md-6 col-sm-12">
                    <asp:Label Text="Año" runat="server" Width="200px" />
                    <asp:TextBox runat="server" ID="txtAnio" Enabled="false" />
                </div>

            </div>
        </div>
    </div>
    <br />
    <br />
    <div class="form-group">
        <asp:Button Class="btn btn-danger" Text="Eliminar" ID="btnEliminar" OnClick="btnEliminar_Click" runat="server" />
    </div>
</asp:Content>
