<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MenuLogin.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.Login.MenuLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">
        <div class="col-12">
            <h3>Te logueaste correctamente.</h3>
            <hr />
           
        </div>

        <div class="col-4">
            <asp:Button Text="Otros......." ID="btnPagina1" OnClick="btnPagina1_Click" runat="server" CssClass="btn btn-primary" />
        </div>
        <div class="col-4">
            <% if (Dominio.Util.validacionAdmin((Dominio.Usuarios)Session["Usuarios"])) {  %>
                <p>SOLO USUARIO NIVEL ADMIN</p>

                <asp:Button Text="Menu Alumnos" ID="btn_Alumno" OnClick="btn_Alumno_Click" runat="server" CssClass="btn btn-primary" />
                <asp:Button Text="Menu Docentes" ID="btn_Docente" OnClick="btn_Docente_Click" runat="server" CssClass="btn btn-primary" />

            <% } else 
               if (Dominio.Util.validacionDocente((Dominio.Usuarios)Session["Usuarios"])) {  %>
                <p>SOLO USUARIO NIVEL PROFESOR</p>

            <%}%>
                


        </div>
    </div>

</asp:Content>