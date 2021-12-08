<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoMaterias.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.ListadoMaterias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h1>Listado Materias</h1>
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
                                    <th> <a href="CargaCarreras.aspx" class="btn btn-primary btn-block">Cargar.Carreras</a> </th>
                                    <th> <a href="Default.aspx" class="btn btn-primary btn-block">Otro.....</a> </th>
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
                            <th scope="col">ID_MATERIA</th>
                            <th scope="col">NOMBRE.MATERIA...........</th>
                            <th scope="col">CARGA HORARIA MINIMA</th>
                            <th scope="col">CARRERA</th>
                            <th scope="col">AÑO</th>
                            <th scope="col">CUATRIMESTRE</th>
                            <th scope="col">ESTADO</th>

                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="Rep_Materias">
                            <ItemTemplate> 
                                <tr>
                                    <td><%#Eval("id_materia") %></td>
                                    <td><%#Eval("nombre_materia") %> </td>
                                    <td><%#Eval("carga_horaria_minima") %> </td>
                                    <td><%#Eval("carrera") %> </td>
                                    <td><%#Eval("año_curso") %> </td>
                                    <td><%#Eval("cuatrimestre") %> </td>
                                    <td><%#Eval("estado") %> </td>                                    
                                    <td>
                                        <a class="btn btn-sm btn-outline-info" id="elimCarrera"  onclick='EliminarMateria?idMateria=<%#Eval("id_materia") %>'><i title="Eliminar" class="fas fa-trash-alt"></i></a>
                                        <%--href='EliminarAcarrera.aspx?idMateria=<%#Eval("id_materia") %>'--%>
                                        <a class="btn btn-sm btn-outline-secondary" href='ModificarCarrera.aspx?idMateria=<%#Eval("id_materia") %>'><i title="Modificar Materia" class="far fa-edit"></i></a>
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
