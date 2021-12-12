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
                        <asp:Label Text="MATERIA: " runat="server" width="160px"/>
                        <asp:TextBox ID="text_Nombre_Materia" runat="server" />
                    </div>
                    <div>
                        <asp:Label Text="CARRERA: " runat="server" Width="160px" />
                        <asp:TextBox ID="text_carrera" runat="server" />
                    </div>
                    <div>
                        <asp:Label Text="AÑO_CURSO: " runat="server" Width="160px" />
                        <asp:TextBox ID="text_anio_curso" runat="server" />
                    </div>
                    <div>
                        <asp:Label Text="CUATRIMESTRE: " runat="server" Width="160px" />
                        <asp:TextBox ID="text_cuatrimestre" runat="server" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <asp:Button class="btn btn-success " Text="Agregar" ID="btn_mat_Agregar" OnClick="btn_mat_Agregar_Click" runat="server" />
</asp:Content>