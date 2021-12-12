<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarDocente.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.EliminarDocente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12  text-center">
            <h1>Eliminar Docente </h1>
        </div>
    </div>
    <div class="container">
        <div class="row py-3">
            <div class="col" id="main">
                <div class="col-md-6 col-sm-12">
                    <asp:Label Text="ID" runat="server" Width="200px" />
                    <asp:TextBox runat="server" ID="text_doc_iddocente" Enabled="false" />
                </div>
               <div class="col-md-6 col-sm-12">
                    <asp:Label Text="Cuil" runat="server" Width="200px" />
                    <asp:TextBox runat="server" ID="text_doc_cuil" Enabled="false" />
                </div>
               <div class="col-md-6 col-sm-12">
                    <asp:Label Text="Apellido" runat="server" Width="200px" />
                    <asp:TextBox runat="server" ID="text_doc_apellido" Enabled="false" />
                </div>
              <div class="col-md-6 col-sm-12">
                    <asp:Label Text="Nombre" runat="server" Width="200px" />
                    <asp:TextBox ID="text_doc_nombre" runat="server" Enabled="false" />
                </div>
               <div class="col-md-6 col-sm-12">
                    <asp:Label Text="Nacionalidad" runat="server" Width="200px" />
                    <asp:TextBox runat="server" ID="text_doc_nacionalidad" Enabled="false" />
                </div>
                <div class="col-md-6 col-sm-12">
                    <asp:Label Text="Fecha de Nacimiento" runat="server" Width="200px" />
                    <asp:TextBox runat="server" ID="text_doc_fechanacimiento" Enabled="false" />
                </div>
                <div class="col-md-6 col-sm-12">
                    <asp:Label Text="Email" runat="server" Width="200px" />
                    <asp:TextBox runat="server" ID="text_doc_mail" Enabled="false" />
                </div>
                <div class="col-md-6 col-sm-12">
                    <asp:Label Text="Domicilio" runat="server" Width="200px" />
                    <asp:TextBox runat="server" ID="text_doc_domicilio" Enabled="false" />
                </div>
                <div class="col-md-6 col-sm-12">
                    <asp:Label Text="Localidad" runat="server" Width="200px" />
                    <asp:TextBox runat="server" ID="text_doc_localidadpcia" Enabled="false" />
                </div>
            </div>
           </div>
        </div>
        <br />
        <br />
        <div class="form-group">
            <asp:Button Class="btn btn-danger" Text="Eliminar" ID="EliminDocente" OnClick="EliminarDocente_Click" runat="server" />
        </div>
</asp:Content>