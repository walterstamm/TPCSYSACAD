<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MenuLogin.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.Login.MenuLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">
        <div class="col-12">
            <h3>Te logueaste correctamente.</h3>
            <hr />
        </div>
        <div class="col-4">
            <asp:Button Text="Menu Alumnos" ID="btnPagina1" OnClick="btnPagina1_Click" runat="server" CssClass="btn btn-primary" />
        </div>
        <div class="col-4">
            <% if (Session["Usuarios"] != null && ((Dominio.Usuarios)Session["Usuarios"]).TipoUsuario == Dominio.TipoUsuario.Admin) {  %>

                <asp:Button Text="Página 2" ID="btnPagina2" OnClick="btnPagina2_Click" runat="server" CssClass="btn btn-primary" />
                <p>Tenés que ser admin.</p>

            <% } %>
        </div>
    </div>
</asp:Content>