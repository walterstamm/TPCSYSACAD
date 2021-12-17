<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargaDocente.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.CargaDocente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12 alert alert-secondary ">
            <div class="row">
                <div class="col-md-12  text-center">
                    <h1>Nuevo Docente</h1>
                </div>
            </div>
            <div class="col-md-12 ">
                <div class=" row">
                    <div class="col-md-4 col-sm-12 ">
                        <asp:Label Text="Cuil" runat="server" Width="160px" />
                        <asp:TextBox ID="text_doc_Cuil" runat="server" />
                        <asp:RequiredFieldValidator runat="server" ForeColor="Red" ControlToValidate="text_doc_Cuil" ValidateRequestMode="Enabled" ID="RequiredFieldValidator7" ErrorMessage="Seleccione uno "></asp:RequiredFieldValidator>

                    </div>
                    <div class="col-md-4 col-sm-12 ">
                        <asp:Label Text="Apellido" runat="server" Width="160px" />
                        <asp:TextBox ID="text_doc_Apellido" runat="server" />
                        <asp:RequiredFieldValidator runat="server" ForeColor="Red" ControlToValidate="text_doc_Apellido" ValidateRequestMode="Enabled" ID="RequiredFieldValidator1" ErrorMessage="Seleccione uno "></asp:RequiredFieldValidator>

                    </div>
                    <div class="col-md-4 col-sm-12 ">
                        <asp:Label Text="Nombre" runat="server" Width="160px" />
                        <asp:TextBox ID="text_doc_Nombre" runat="server" />
                        <asp:RequiredFieldValidator runat="server" ForeColor="Red" ControlToValidate="text_doc_Nombre" ValidateRequestMode="Enabled" ID="RequiredFieldValidator2" ErrorMessage="Seleccione uno "></asp:RequiredFieldValidator>

                    </div>
                    <div class="col-md-4 col-sm-12 ">
                        <asp:Label Text="Nacionalidad" runat="server" Width="160px" />
                        <asp:TextBox ID="text_doc_Nacionalidad" runat="server" />
                        <asp:RequiredFieldValidator runat="server" ForeColor="Red" ControlToValidate="text_doc_Nacionalidad" ValidateRequestMode="Enabled" ID="RequiredFieldValidator3" ErrorMessage="Seleccione uno "></asp:RequiredFieldValidator>

                    </div>
                    <div class="col-md-4 col-sm-12 ">
                        <asp:Label Text="Fecha de Nacimiento" runat="server" Width="160px" /><br />
                        <asp:TextBox ID="text_doc_FechaNac" TextMode="Date" runat="server" />
                        <asp:RequiredFieldValidator runat="server" ForeColor="Red" ControlToValidate="text_doc_FechaNac" ValidateRequestMode="Enabled" ID="RequiredFieldValidator4" ErrorMessage="Seleccione uno "></asp:RequiredFieldValidator>


                    </div>
                    <div class="col-md-4 col-sm-12 ">
                        <asp:Label Text="Email" runat="server" Width="160px" />
                        <asp:TextBox ID="text_doc_Mail" runat="server" />
                        <asp:RequiredFieldValidator runat="server" ForeColor="Red" ControlToValidate="text_doc_Mail" ValidateRequestMode="Enabled" ID="RequiredFieldValidator5" ErrorMessage="Seleccione uno "></asp:RequiredFieldValidator>

                    </div>
                    <div class="col-md-4 col-sm-12 ">
                        <asp:Label Text="Domicilio" runat="server" Width="160px" />
                        <asp:TextBox ID="text_doc_Domicilio" runat="server" />
                        <asp:RequiredFieldValidator runat="server" ForeColor="Red" ControlToValidate="text_doc_Domicilio" ValidateRequestMode="Enabled" ID="RequiredFieldValidator6" ErrorMessage="Seleccione uno "></asp:RequiredFieldValidator>

                    </div>
                </div>
            </div>
        </div>
    </div>
    <asp:Button class="btn btn-success" Text="Agregar" ID="btn_doc_Agregar" OnClick="btn_doc_Agregar_Click" runat="server" />
</asp:Content>
