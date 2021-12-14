<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaUsuario.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.UsuariosNuevos.AltaUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="row">
        <div class="col-md-12 alert alert-secondary ">
            <div class="row">
                <div class="col-md-12  text-center">
                    <h1>Nuevo Usuario</h1>
                </div>
            </div>
            <div class="col-md-12 ">
                <div class=" row">
                    <div class="col-md-4 col-sm-12 ">
                        <asp:Label Text="Docentes sin Usuarios" runat="server" Width="160px" />
                        <asp:DropDownList runat="server" ID="ddlDocentes"></asp:DropDownList>
                    </div>
                    <div class="col-md-4 col-sm-12 ">
                        <asp:Label Text="Usuario" runat="server" Width="160px" />
                        <asp:TextBox ID="txtUsuario" runat="server" />
                    </div>
                    <div class="col-md-4 col-sm-12 ">
                        <asp:Label Text="Password" runat="server" Width="160px" />
                        <asp:TextBox ID="txtPasword" runat="server" />
                    </div>
                  
                </div>
            </div>
        </div>
    </div>
    <asp:Button class="btn btn-success" Text="Agregar" ID="btnAgregar"  OnClick="btnAgregar_Click" runat ="server" />

</asp:Content>
