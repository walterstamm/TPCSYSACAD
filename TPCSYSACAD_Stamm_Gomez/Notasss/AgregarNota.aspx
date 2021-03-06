<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarNota.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.AgregarNota" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <div class="row">
        <div class="col-md-12  text-center">
            <h1>Agregar Notas </h1>

        </div>
    </div>

    <div class="container">
        <div class="row py-3">
            <div class="col" id="main">

                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="ID_Mat_Doc" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_ID_MxD" TextMode="Number" Width="200px" Style="text-align: center" Enabled="false" />
                        </div>
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="ID_Alumno" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_ID_ALUM" Width="200px" Style="text-align: center"  Enabled="false"/>
                        </div>
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="ID_MAt_Docente" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_ID_MATDOC" Width="200px" Enabled="false" />
                        </div>

                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="1er Calif" runat="server" Width="200px" />
                            <asp:TextBox ID="text_EVENTO1" runat="server" Width="200px" />
                        </div>

                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="2da Calif" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_EVENTO2" Width="200px" />
                        </div>
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="1er Rec" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_REC1" Width="200px" />
                        </div>
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="2do Rec" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_REC2" Width="200px" />
                        </div>
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="Nota Final" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_NOTA_FINAL" Width="200px" />
                        </div>
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="Resultado Final" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_RESULTADO_FINAL" Width="200px" />
                        </div>

                        <br />
                        <asp:Button class="btn btn-warning" Text="Cargar Nota" ID="btn_CargarNota" runat="server" OnClick="btn_CargarNota_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </div>

</asp:Content>
