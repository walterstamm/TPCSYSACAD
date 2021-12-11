<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Listado_AlumnoMateria.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.Listado_AlumnoMateria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



        <h1>Alumnos por Materias</h1>
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
                                    <%--<th> <a href="CargaDocente.aspx" class="btn btn-primary btn-block">Veo que Cargar</a> </th>--%>
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
                            <th scope="col">ID_MxDOC</th>
                            <th scope="col">ID ALUMNO</th>
                            <th scope="col">CURSO </th>
                            <th scope="col">EVENTO 1</th>
                            <%--<th scope="col">NACIONALIDAD</th>--%>
                            <th scope="col">EVENTO 2</th>
                            <th scope="col">REC 1</th>
                            <th scope="col">REC 2</th>
                            <%--<th scope="col">LOCALIDAD - PCIA</th>--%>
                            <th scope="col">NOTA FINAL</th>
                            <th scope="col">RESULTADO FINAL</th>

                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="RepAlumMat">
                            <ItemTemplate> 
                                <tr>
                                    <td><%#Eval("ID") %></td>
                                    <td><%#Eval("IDALUMNO") %> </td>
                                    <td><%#Eval("IDMATERIADOCENTE") %> </td>
                                    <td><%#Eval("EVENTO1") %> </td>
                                    <%--<td><%#Eval("Nacionalidad") %> </td>--%>
                                    <td><%#Eval("EVENTO2") %> </td>
                                    <%--<td><%#Eval("FECHANACIMIENTO","{0: dd/MM/yyyy}") %> </td>--%>
                                    <td><%#Eval("REC1") %> </td>
                                    <td><%#Eval("REC2") %> </td>
                                    <td><%#Eval("NOTAFINAL") %> </td>
                                    <td><%#Eval("RESULTADOFINAL") %> </td>

                                    <td>
                                        <a class="btn btn-sm btn-outline-info" href='EliminarDocente.aspx?idMxDoc=<%#Eval("ID") %>'><i title="Eliminar Docente" class="fas fa-trash-alt"></i></a>
                                        <a class="btn btn-sm btn-outline-secondary" href='AgregarNota.aspx?idMxDoc=<%#Eval("ID") %>'><i title="Modificar Docente" class="far fa-edit"></i></a>
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
