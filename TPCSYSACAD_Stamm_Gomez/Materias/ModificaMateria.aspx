<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModificaMateria.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.ModificaMateria" %>
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
                            <asp:Label Text="IDMATERIA" runat="server" width="200px"/>
                            <asp:TextBox runat="server" ID="text_Mod_idmateria" TextMode="Number" Width="200px" Style="text-align: center" Enabled="false" />
                        </div>
                        <div>
                            <asp:Label Text="NOMBRE MATERIA" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_Mod_nombremateria" width="200px" Style="text-align: center"/>
                        </div>
                        <div>
                            <asp:Label Text="CARRERA" runat="server" width="200px"/>
                            <asp:TextBox runat="server" ID="text_Mod_Carrera" Width="200px"  Style="text-align: center"/>
                        </div>
                        <div>
                            <asp:Label Text="AÑO CURSO" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_Mod_anio" Width="200px" Style="text-align: center" />
                        </div>
                        <div>
                            <asp:Label Text="CUATRIMESTRE" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_Mod_cuatrimestre" Width="200px" Style="text-align: center" />
                        </div>
                        <br />
                        <asp:Button class="btn btn-warning" Text="Modificar" ID="btn_ModificarMateria" runat="server" OnClick="btn_ModificarMateria_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </div>
</asp:Content>