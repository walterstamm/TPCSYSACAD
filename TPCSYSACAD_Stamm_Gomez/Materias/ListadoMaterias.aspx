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
                                    <th> <a href="CargaMateria.aspx" class="btn btn-primary btn-block">Cargar Materia</a> </th>
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
                            <th scope="col">COD</th>
                            <th scope="col">MATERIA</th>
                            <%--<th scope="col">CARGA HORARIA MINIMA</th>--%>
                            <th scope="col">CARR</th>
                            <th scope="col">AÑO_CURSO</th>
                            <th scope="col">CUATRIMESTRE</th>
                            <th scope="col">ESTADO</th>

                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="Rep_Materias">
                            <ItemTemplate> 
                                <tr>
                                    <td><%#Eval("IDMATERIA") %> </td>
                                    <td><%#Eval("NOMBREMATERIA") %> </td>
                                    <%--<td><%#Eval("carga_horaria_minima") %> </td>--%>
                                    <td><%#Eval("IDCARRERA") %> </td>
                                    <td><%#Eval("ANIO") %> </td>
                                    <td><%#Eval("CUATRIMESTRE") %> </td>
                                    <td><%#Eval("ESTADO") %> </td>
                                    <td>
                                        
                                        <a class="btn btn-sm btn-outline-info" href='EliminaMateria.aspx?idMateria=<%#Eval("IDMATERIA") %>'>
                                            <i title="Eliminar Materia" class="fas fa-trash-alt"></i></a>
                                        
                                        <%--href='EliminarAcarrera.aspx?idMateria=<%#Eval("id_materia") %>'--%>
                                        <a class="btn btn-sm btn-outline-secondary" href='ModificaMateria.aspx?idMateria=<%#Eval("IDMATERIA") %>'>
                                            <i title="Modificar Materia" class="far fa-edit"></i></a>
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
