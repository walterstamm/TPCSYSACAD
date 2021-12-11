<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoCarreras.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.ListadoCarreras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Listado Carreras</h1>
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
                                    <th> <a href="AgregaCarrera.aspx" class="btn btn-primary btn-block">Cargar.Carreras</a> </th>
                                    <th> <a href="Default.aspx" class="btn btn-primary btn-block">Otro.....</a> </th>
                                </tr>
                                <%--<tr> LO USABA PARA NO HACER UNA PAGINA ESPECIFICO PARA ELIMINAR SIN 
                                    <th> <asp:Label Text="ID A ELIMINAR" runat="server" /> </th>
                                    <th>    <asp:TextBox Text="NRO ID" ID="text_Eliminar" runat="server" />  </th>
                                    <th>    <asp:Button Class="btn btn-danger" Text="Elimnar ID" ID="Eliminar" OnClick="Eliminar_Click" runat="server" />  </th>
                                </tr>--%> 

                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col" id="main">
                <table class="table">
                    <thead>
                        <tr>
                            <th scope="col">ID_CARR</th>
                            <th scope="col">NOMBRE CARRERA</th>
                            <th scope="col">PLAN AÑO</th>
                            <th scope="col">DOC HABILITANTE</th>
                            <th scope="col">ESTADO CARRERA</th>

                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="Rep_Carreras">
                            <ItemTemplate> 
                                <tr>
                                    <td><%#Eval("ID") %></td>
                                    <td><%#Eval("NOMBRE") %> </td>
                                    <td><%#Eval("NUMEROPLAN") %> </td>
                                    <td><%#Eval("NUMEROHABILITANTE") %> </td>
                                    <td><%#Eval("ESTADO") %> </td>
                                    
                                    <td>
                                        <a class="btn btn-sm btn-outline-info" href='EliminaCarrera.aspx?idCarrera=<%#Eval("ID") %>'><i title="Eliminar Carrera" class="fas fa-trash-alt"></i></a>
                                        <a class="btn btn-sm btn-outline-secondary" href='ModificaCarrera.aspx?idCarrera=<%#Eval("ID") %>'><i title="Modificar Carrera" class="far fa-edit"></i></a>
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
