<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoAlumnos.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.ListadoAlumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <h1>Listado Alumnos</h1>
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
                                    <th> <a href="CargaAlumnos.aspx" class="btn btn-primary btn-block">Cargar Alumno</a> </th>
                                    <th> <a href="../Default.aspx" class="btn btn-primary btn-block">Volver</a> </th>
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
                            <th scope="col">Cuil_Alumno</th>
                            <th scope="col">Apellido</th>
                            <th scope="col">Nombre</th>
                           
                            <th scope="col">Fecha Nac</th>
                            <th scope="col">Correo Electrónico</th>
                            <th scope="col">Domicilio</th>
                            <th scope="col">Localidad - Pcia</th>
                           

                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="Rep">
                            <ItemTemplate> 
                                <tr>
                                    <td><%#Eval("Idalumno") %></td>
                                    <td><%#Eval("Cuil") %> </td>
                                    <td><%#Eval("Apellido") %> </td>
                                    <td><%#Eval("Nombre") %> </td>
                                  
                                    <td><%#Eval("Fecha_Nac","{0: dd/MM/yyyy}") %> </td>
                                    <td><%#Eval("Mail") %> </td>
                                    <td><%#Eval("Domicilio") %> </td>
                                    <td><%#Eval("Localidad_Prov") %> </td>
                                  
                                    
                                    <td>
                                        <a class="btn btn-sm btn-outline-info" href='EliminarAlumno.aspx?idAlumno=<%#Eval("Idalumno") %>'>
                                            <i title="Eliminar Alumno" class="fas fa-trash-alt"></i></a>
                                        <a class="btn btn-sm btn-outline-secondary" href='ModificarAlumno.aspx?idAlumno=<%#Eval("Idalumno") %>'><i title="Modificar Alumno" class="far fa-edit"></i></a>
                                      <%--  <a class="btn btn-sm btn-outline-secondary" href='Inscribir_Alum_Carrera.aspx?idAlumno=<%#Eval("Idalumno") %>'><i title="Inscribir a Carrera" class="far fa-edit"></i></a>--%>
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
