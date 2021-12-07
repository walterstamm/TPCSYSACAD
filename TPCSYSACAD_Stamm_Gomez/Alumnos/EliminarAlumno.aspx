<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarAlumno.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.EliminarAlumno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-12 alert alert-secondary ">
        <div class="row">
            <div class="col-md-12  text-center">
                <h1>Eliminar Alumno</h1>
            </div>
        </div>
        <div class="row g-3 ">

            <div class="form-group">
                <asp:Label Text="ID"   runat="server" Width="200px" />
                <asp:TextBox runat="server" ID="text_idalumno" class="form-control" Enabled="false" />
            </div>

            <div class="form-group">
                <asp:Label Text="Cuil" runat="server"  Width="200px" />
                <asp:TextBox runat="server" ID="text_cuil" Enabled="true" />
            </div>

            <div class="form-group">
                <asp:Label Text="Apellido" runat="server" Width="200px"  />
                <asp:TextBox runat="server"  ID="text_apellido" Enabled="true" />
            </div>

            <div class="form-group">
                <asp:Label Text="Nombre" runat="server" Width="200px"  />
                <asp:TextBox runat="server" ID="text_nombre" Enabled="true" />
            </div>

            <div class="form-group">
                <asp:Label Text="Fecha de Nacimiento" runat="server" Width="200px"  />
                <asp:TextBox runat="server" ID="text_fechanacimiento" Enabled="true"  />
            </div>

            <div class="form-group">
                <asp:Label Text="Email" runat="server" Width="200px"  />
                <asp:TextBox runat="server" ID="text_mail" Enabled="true" />
            </div>

            <div class="form-group">
                <asp:Label Text="Domicilio" runat="server" Width="200px" />
                <asp:TextBox runat="server" ID="text_domicilio" Enabled="true"  />
            </div>

            <div class="form-group">
                <asp:Label Text="Localidad" runat="server" Width="200px" />
                <asp:TextBox runat="server" ID="text_localidadpcia" Enabled="true"/>
            </div>


            <hr>
            <div class="mb-3 row ">
                <div class="col-sm-10 center-tex ">

                    <asp:Button Class="btn btn-danger" Text="Eliminar" ID="EliminarAlumno" OnClick="EliminarAlumno_Click" runat="server" />
                </div>

            </div>
            <hr>
        </div>
</asp:Content>
