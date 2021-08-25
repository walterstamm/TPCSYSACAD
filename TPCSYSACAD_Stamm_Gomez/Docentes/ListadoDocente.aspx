﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoDocente.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.ListadoDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
        <h1>Listado Docente</h1>
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
                                    <th> <a href="CargaAlumnos.aspx" class="btn btn-primary btn-block">Cargar.Docente</a> </th>
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
                            <th scope="col">ID</th>
                            <th scope="col">CUIL_DOCENTE</th>
                            <th scope="col">APELLIDO Y NOMBRE</th>
                            <%--<th scope="col">NACIONALIDAD</th>--%>
                            <th scope="col">FECHA NAC</th>
                            <th scope="col">CORREO ELECTRONICO</th>
                            <th scope="col">DOMICILIO........</th>
                            <th scope="col">LOCALIDAD - PCIA</th>
                            <%--<th scope="col">USUARIO</th>
                            <th scope="col">ESTADO ACADEMICO</th>--%>

                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="RepDocente">
                            <ItemTemplate> 
                                <tr>
                                    <td><%#Eval("Iddocente") %></td>
                                    <td><%#Eval("Cuil") %> </td>
                                    <td><%#Eval("ApellidoNombre") %> </td>
                                    <%--<td><%#Eval("Nacionalidad") %> </td>--%>
                                    <td><%#Eval("Fecha_Nac","{0: dd/MM/yyyy}") %> </td>
                                    <td><%#Eval("Mail") %> </td>
                                    <td><%#Eval("Domicilio") %> </td>
                                    <td><%#Eval("Localidad_Prov") %> </td>
                                    <%--<td><%#Eval("Usuario") %> </td>--%>
                                    <%--<td><%#Eval("Estado") %> </td>--%>
                                    <td>
                                        <a class="btn btn-sm btn-outline-info" href='EliminarDocente.aspx?idDocente=<%#Eval("Iddocente") %>'><i title="Eliminar Docente" class="fas fa-trash-alt"></i></a>
                                        <a class="btn btn-sm btn-outline-secondary" href='ModificarDocente.aspx?idDocente=<%#Eval("Iddocente") %>'><i title="Modificar Docente" class="far fa-edit"></i></a>
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