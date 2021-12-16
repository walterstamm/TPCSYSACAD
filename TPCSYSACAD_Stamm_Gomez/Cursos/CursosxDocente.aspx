<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CursosxDocente.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.Cursos.CursosxDocencte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


     <h1> Cursos</h1>
    <asp:Label Text="Buscar" runat="server" />
    <asp:TextBox runat="server" />
    <div class="container">
        <div class="row py-3">
            <div class="col-3 order-2" id="sticky-sidebar">
                <div class="sticky-top">
                    <div class="nav flex-column">
                        <div class='col-xs-3'>
                            <table>
                                <tr>
                                    <th><a href="AltaCurso.aspx" class="btn btn-primary btn-block">Nuevo Curso</a> </th>
                                    <th><a href="../Default.aspx" class="btn btn-primary btn-block">Volver</a> </th>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col" id="main">
                <table class="table">
                    <thead>
                        <tr>
                            <th scope="col">ID</th> 
                            <th scope="col">Materia</th>
                            <th scope="col">Cuatrimestre</th>
                            <th scope="col">Año</th>

                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="RepCursos">
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("Id") %> </td>
                                    <td><%#Eval("Materia") %> </td>
                                    <td><%#Eval("Cuatrimestre") %> </td>
                                    <td><%#Eval("Anio") %> </td>


                                    <td>
                                        <a class="btn btn-sm btn-outline-info" href='EliminarCurso.aspx?idCurso=<%#Eval("Id") %>'><i title="Calificar" <i title="Calificar" class="fas fa-graduation-cap"></i></a>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>
        </div>
    </div>

</asp:Content>
