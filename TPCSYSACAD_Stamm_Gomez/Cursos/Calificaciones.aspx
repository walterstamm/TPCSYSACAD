<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calificaciones.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.Cursos.Calificaciones" %>
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
                            <th scope="col">Nombre</th> 
                            <th scope="col">Apellido</th>
                            <th scope="col">Cuil</th>
                            <th scope="col">Nota1</th>
                            <th scope="col">Nota2</th>
                            <th scope="col">Estado Academico</th>

                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="repAlum">
                             <ItemTemplate>
                                <tr>
                                    <td><%# DataBinder.Eval(Container.DataItem,"alu.Nombre") %> </td>
                                   <td><%# DataBinder.Eval(Container.DataItem,"alu.Apellido") %> </td>
                                    <td><%# DataBinder.Eval(Container.DataItem,"alu.Cuil") %> </td>
                                    <td><%#Eval("Nota1") %> </td>
                                    <td><%#Eval("Nota2") %> </td>
                                    <td><%#Eval("EstadoAcademico") %> </td>
                                    <td>
                                        <a class="btn btn-sm btn-outline-info" href='CargarNota.aspx?idNota=<%#Eval("Id") %>'><i title="Calificar" <i title="Calificar" class="fas fa-graduation-cap"></i></a>
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
