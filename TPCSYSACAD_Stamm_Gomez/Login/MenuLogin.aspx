<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MenuLogin.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.Login.MenuLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    
    <body style="background-image= url=("images/campus2.jpg"); background-repeat: no-repeat; background-attachment: fixed;" >

    <div class="row">
        <div class="col-12">
            <h3>Te logueaste correctamente.</h3>
            <hr />
           
        </div>

        
        <div class="col-4">
            <% if (Dominio.Util.validacionAdmin((Dominio.Usuarios)Session["Usuarios"])) {  %>
                <p>SOLO USUARIO NIVEL ADMIN</p>

                

            <% } else 
               if (Dominio.Util.validacionDocente((Dominio.Usuarios)Session["Usuarios"])) {  %>
                

            <%}%>
                


        </div>
    </div>

</asp:Content>