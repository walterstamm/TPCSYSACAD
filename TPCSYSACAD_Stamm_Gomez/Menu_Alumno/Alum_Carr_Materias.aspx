<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alum_Carr_Materias.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.Alum_Autogestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-12">
            <br />
            <h5>ALUMNO:</h5>
            <asp:Label Text="NOMBRE Y APELLIDO DEL ALUMNO" runat="server" />
            <h3>MENÚ AUTOGESTION DE ALUMNOS.</h3>
            <hr />

            
        </div>

        <div class="col-4">
            <h1> DD</h1>
            <div class="col" id="main">
                <table class="table">
                    <thead>
                        <tr>
                            <th scope="col">ID_CARRERA</th>
                            <th scope="col">NOMBRE_CARRERA</th>
                            <th scope="col">PLAN_AÑO</th>
                            <th scope="col">DOCUMENTO HABILITANTE</th>

                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="Rep_Carr">
                            <ItemTemplate> 
                                <tr>
                                    <td><%#Eval("ID_CARRERA") %></td>
                                    <td><%#Eval("NOMBRE_CARRERA") %> </td>
                                    <td><%#Eval("PLAN_AÑO") %> </td>
                                    <%--<td><%#Eval("Fecha_Nac","{0: dd/MM/yyyy}") %> </td>--%>
                                    <td><%#Eval("DOC_HABILITANTE") %> </td>

                                    <td>
                                        <a class="btn btn-sm btn-outline-info" href='EliminarAlumno.aspx?idAlumno=<%#Eval("Idalumno") %>'><i title="Eliminar Alumno" class="fas fa-trash-alt"></i></a>
                                        <a class="btn btn-sm btn-outline-secondary" href='ModificarAlumno.aspx?idAlumno=<%#Eval("Idalumno") %>'><i title="Modificar Alumno" class="far fa-edit"></i></a>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>

                    </tbody>
                </table>
            </div>
    
        </div>
        <div class="col-4">






        </div>
    </div>

</asp:Content>
