<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MenuLogin.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.Login.MenuLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">
        <div class="col-12">
            <h3>Te logueaste correctamente.</h3>
            <hr />
            <asp:Label Text="USUARIO" runat="server" />
            <asp:TextBox runat="server" ID="text_usuario" Enabled="false" />
            <asp:TextBox runat="server" ID="text_Nivel" Enabled="false" />
        </div>

        <div class="col-4">
            <asp:Button Text="Otros......." ID="btnPagina1" OnClick="btnPagina1_Click" runat="server" CssClass="btn btn-primary" />
        </div>
        <div class="col-4">
            <% if (Session["Usuarios"] != null && ((Dominio.Usuarios)Session["Usuarios"]).TipoUsuario == Dominio.TipoUsuario.Admin) {  %>
                <p>SOLO USUARIO NIVEL ADMIN</p>

                <asp:Button Text="Menu Alumnos" ID="btn_Alumno" OnClick="btn_Alumno_Click" runat="server" CssClass="btn btn-primary" />
                <asp:Button Text="Menu Docentes" ID="btn_Docente" OnClick="btn_Docente_Click" runat="server" CssClass="btn btn-primary" />

            <% } else 
               if (Session["Usuarios"] != null && ((Dominio.Usuarios)Session["Usuarios"]).TipoUsuario == Dominio.TipoUsuario.Alumno) {  %>
                <p>SOLO USUARIO NIVEL ALUMNO</p>

                <asp:Button Text="Menu Acceso Alumnos"  ID="btn_Acc_Alumno"  OnClick="btn_Acc_Alumno_Click"  runat="server" CssClass="btn btn-primary" />

            <%} else
               if (Session["Usuarios"] != null && ((Dominio.Usuarios)Session["Usuarios"]).TipoUsuario == Dominio.TipoUsuario.Profesor) {  %>
                <p>SOLO USUARIO NIVEL PROFESOR</p>

                <%--<asp:Button Text="Menu Acceso Docentes" ID="btn_Acc_Docente" OnClick="btn_Acc_Docente_Click" runat="server" CssClass="btn btn-primary" />--%>

            <%}   %>

        </div>
    </div>

</asp:Content>