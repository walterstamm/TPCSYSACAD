<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoCursos.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.Cursos.ListadoCursos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Listado de Cursos</h1>
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
                                    <th><a href="CargaDocente.aspx" class="btn btn-primary btn-block">Cargar.Docente</a> </th>
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
                             <th scope="col">Apellido</th>
                            <th scope="col">Nombre</th>
                            <th scope="col">Cuil</th>
                            <th scope="col">Materia</th>
                            <th scope="col">Cuatrimestre</th>
                            <th scope="col">Año</th>

                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="RepCursos">
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("apellidoDocente") %></td>
                                    <td><%#Eval("nombreDocente") %> </td>
                                    <td><%#Eval("cuilDocente") %> </td>
                                    <td><%#Eval("Materia") %> </td>
                                    <td><%#Eval("Cuatrimestre") %> </td>
                                    <td><%#Eval("Anio") %> </td>


                                    <td>
                                        <a class="btn btn-sm btn-outline-info" href='EliminarDocente.aspx?idDocente=<%#Eval("IDDOCENTE") %>'><i title="Eliminar Docente" class="fas fa-trash-alt"></i></a>
                                        <a class="btn btn-sm btn-outline-secondary" href='ModificarDocente.aspx?idDocente=<%#Eval("IDDOCENTE") %>'><i title="Modificar Docente" class="far fa-edit"></i></a>
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
