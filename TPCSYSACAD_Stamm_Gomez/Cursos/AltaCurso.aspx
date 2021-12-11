<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaCurso.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.Cursos.AltaCurso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row g-3 ">
        <div class="col-md-12  text-center">
            <h1>Nuevo Curso</h1>
        </div>


        <div class="input-group mb-3">
            <asp:Label Text="Materia" runat="server" Width="160px" class="input-group-text" />
            <asp:DropDownList ID="ddlMateria" runat="server"></asp:DropDownList>
        </div>

        
        <div class="input-group mb-3">
            <asp:Label Text="Cuil" runat="server" Width="160px" class="input-group-text" />
            <asp:TextBox ID="TextBox1" runat="server" />
        </div>


    </div>



</asp:Content>
