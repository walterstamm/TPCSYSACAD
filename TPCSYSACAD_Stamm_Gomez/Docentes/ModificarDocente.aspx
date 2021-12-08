﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModificarDocente.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.ModificarDocente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <div class="row">
        <div class="col-md-12  text-center">
            <h1>Modificar Docente </h1>

        </div>
    </div>

    <div class="container">
        <div class="row py-3">
            <div class="col" id="main">

                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="ID" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_Mod_iddocente" TextMode="Number" Width="200px" Style="text-align: center" Enabled="false" />
                        </div>
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="Cuil" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_Mod_cuil" Width="200px" Style="text-align: center" />
                        </div>
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="Apellido" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_Mod_apellido" Width="200px" />
                        </div>

                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="Nombre" runat="server" Width="200px" />
                            <asp:TextBox ID="text_Mod_nombre" runat="server" Width="200px" />
                        </div>

                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="Nacionalidad" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_Mod_nacionalidad" Width="200px" />
                        </div>
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="Fecha de Nacimiento" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_Mod_fechanac" TextMode="DateTime" Width="200px" />
                        </div>
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="Email" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_Mod_mail" Width="200px" />
                        </div>
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="Domicilio" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_Mod_Domicilio" Width="200px" />
                        </div>

                        <br />
                        <asp:Button class="btn btn-warning" Text="Modificar" ID="btn_ModificarDocente" runat="server" OnClick="btn_ModificarDocente_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </div>

</asp:Content>
