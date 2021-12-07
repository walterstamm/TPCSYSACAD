<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModificarDocente.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.ModificarDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h1> MODIFICAR DOCENTE </h1>
    
    <div class="container">
        <div class="row py-3">
            <div class="col" id="main">
                <%--<table class="table">
                    <thead>
                        <tr>
                            <th scope="col" w>ID</th>
                            <th scope="col">CUIL..........</th>
                            <th scope="col">APELLIDO Y NOMBRE</th>
                            <th scope="col">NACIONALIDAD</th>
                            <th scope="col">FECHA NAC</th>
                            <th scope="col">CORREO E-MAIL</th>
                            <th scope="col">DOMICILIO</th>
                            <th scope="col">LOCALIDAD - PCIA</th>
                        </tr>
                    </thead>

                </table>--%>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <div class="form-group">
                            <asp:Label Text="ID_DOCENTE" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_Mod_iddocente" TextMode="Number" Width="200px" style="text-align: center" />
                        </div>
                        <div class="form-group">
                            <asp:Label Text="CUIL" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_Mod_cuil" Width="200px" style="text-align: center" />
                        </div>
                        <div class="form-group">
                            <asp:Label Text="APELLIDOS" runat="server" Width="200px"/>
                            <asp:TextBox runat="server" ID="text_Mod_apellido" Width="200px" />
                        </div>

                        <div>
                            <asp:Label Text="NOMBRES" runat="server" Width="200px" />
                            <asp:TextBox ID="text_Mod_nombre" runat="server" Width="200px" />
                        </div>

                        <div class="form-group">
                            <asp:Label Text="NACIONALIDAD" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_Mod_nacionalidad" Width="200px"/>
                        </div>
                        <div class="form-group">
                            <asp:Label Text="FECHA NACIMIENTO" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_Mod_fechanac" TextMode="DateTime" Width="200px"/>
                        </div>
                        <div class="form-group">
                            <asp:Label Text="CORREO ELECTRONICO" runat="server" Width="200px"/>
                            <asp:TextBox runat="server" ID="text_Mod_mail" Width="200px"/>
                        </div>
                        <div class="form-group">
                            <asp:Label Text="DOMICILIO" runat="server" Width="200px"/>
                            <asp:TextBox runat="server" ID="text_Mod_Domicilio" Width="200px"/>
                        </div>
                        <div class="form-group">
                            <asp:Label Text="LOCALIDAD Y PCIA" runat="server" Width="200px"/>
                            <asp:TextBox runat="server" ID="text_Mod_Localidadpcia" Width="200px" />
                        </div>
                        <br />
                        <asp:Button class="btn btn-warning" Text="MODIFICAR DOCENTE" ID="btn_ModificarDocente" runat="server" onclick="btn_ModificarDocente_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </div>

</asp:Content>
