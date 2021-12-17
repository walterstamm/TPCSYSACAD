<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargarNota.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.Cursos.CargarNota" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12  text-center">
            <h1>
                <asp:Label runat="server" ID="lblAlumno"></asp:Label>
            </h1>
        </div>
    </div>
    <div class="container">
        <div class="row py-3">
            <div class="col" id="main">
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                       
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="Primer Nota" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="txtNota1" MaxLength="4" Width="200px" />
                        </div>
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="Segunda Nota" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="txtNota2" MaxLength="2" Width="200px" />
                        </div>

                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="Nota Final" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="txtNotFinal" MaxLength="2" Width="200px" />
                        </div>

                        <div class="input-group mb-3">
                            <asp:Label Text="Estado Academico" runat="server" Width="160px" class="input-group-text" />
                            <asp:DropDownList ID="ddlEstado" runat="server"></asp:DropDownList>
                            <asp:RequiredFieldValidator runat="server" ForeColor="Red" ControlToValidate="ddlEstado" ValidateRequestMode="Enabled" ID="RequiredFieldValidator2" ErrorMessage="Elija una Materia"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
                                runat="server" ForeColor="Red" ControlToValidate="ddlEstado"
                                ErrorMessage="Por favor Seleecione una Opcion"
                                ValidationExpression="\d+">
                            </asp:RegularExpressionValidator>
                        </div>
                        <br />
                        <asp:Button class="btn btn-warning" Text="Cargar Nota" ID="btnCargarNota" OnClick="btnCargarNota_Click" runat="server"  />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </div>



</asp:Content>
