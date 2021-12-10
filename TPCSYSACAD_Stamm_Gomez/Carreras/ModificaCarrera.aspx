<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModificaCarrera.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.ModificaCarrera" %>
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
                            <asp:Label Text="IDCARRERA" runat="server" width="200px"/>
                            <asp:TextBox runat="server" ID="text_Mod_idcarrera" TextMode="Number" Width="200px" Style="text-align: center" Enabled="false" />
                        </div>

                        <div>
                            <asp:Label Text="NOMBRE CARRERA" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_Mod_nombrecarrera" width="200px" Style="text-align: center"/>

                        </div>

                        <div>
                            <asp:Label Text="NUMERO PLAN:   " runat="server" width="200px"/>
                            <asp:TextBox runat="server" ID="text_Mod_numeroplan" Width="200px"  Style="text-align: center"/>
                        </div>

                        <div>
                            <asp:Label Text="NUMERO HABILITANTE" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_Mod_numerohabilitante" Width="200px" Style="text-align: center" />
                        </div>

                        <div>
                            <asp:Label Text="ESTADO:   " runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_Mod_estado" Width="200px" Style="text-align: center" />
                        </div>

                        <br />
                        <asp:Button class="btn btn-warning" Text="Modificar" ID="btn_ModificarCarrera" runat="server" OnClick="btn_ModificarCarrera_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </div>








</asp:Content>
