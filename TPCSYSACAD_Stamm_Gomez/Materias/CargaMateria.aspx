<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargaMateria.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.CargaMateria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12 alert alert-secondary ">
            <div class="row">
                <div class="col-md-12  text-center">
                    <h1>Nueva Materia</h1>
                </div>
            </div>
            <div class="col-md-12 ">
                <div class=" row">
                    <div class="col-md-4 col-sm-12 ">
                        <asp:Label Text="Materia: " runat="server" Width="160px" />
                        <asp:TextBox ID="text_Nombre_Materia" runat="server" />
                        <asp:RequiredFieldValidator runat="server" ForeColor="Red" ControlToValidate="text_Nombre_Materia" ValidateRequestMode="Enabled" ID="RequiredFieldValidator7" ErrorMessage="Seleccione uno "></asp:RequiredFieldValidator>

                    </div>

                    <div>
                        <asp:Label Text="Año de Cursada: " runat="server" Width="160px" />
                        <asp:TextBox ID="text_anio_curso" runat="server" />
                        <asp:RequiredFieldValidator runat="server" ForeColor="Red" ControlToValidate="text_anio_curso" ValidateRequestMode="Enabled" ID="RequiredFieldValidator1" ErrorMessage="Seleccione uno "></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3"
                            ControlToValidate="text_anio_curso" ForeColor="Red" runat="server"
                            ErrorMessage="Solo  Acepta Numeros"
                            ValidationExpression="\d+">
                        </asp:RegularExpressionValidator>
                    </div>
                    <div>
                        <asp:Label Text="Cuatrimestre: " runat="server" Width="160px" />
                        <asp:DropDownList runat="server" ID="ddlCuatrimestre"></asp:DropDownList>
                        <asp:RequiredFieldValidator runat="server" ForeColor="Red" ControlToValidate="ddlCuatrimestre" ValidateRequestMode="Enabled" ID="RequiredFieldValidator2" ErrorMessage="Seleccione uno "></asp:RequiredFieldValidator>

                    </div>
                </div>
            </div>
        </div>
    </div>
    <asp:Button class="btn btn-success " Text="Agregar" ID="btn_mat_Agregar" OnClick="btn_mat_Agregar_Click" runat="server" />
</asp:Content>
