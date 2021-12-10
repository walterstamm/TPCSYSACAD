<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregaCarrera.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.AgregaCarrera" %>
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
                        <asp:Label Text="NOMBRE CARRERA: " runat="server" width="160px"/>
                        <asp:TextBox ID="text_nombrecarrera" runat="server" />
                    </div>

                    <div class="col-me-4 col-sm-12">
                        <asp:Label Text="NUMERO DEL PLAN" runat="server" width="160px"/>
                        <asp:TextBox ID="text_numeroplan" runat="server" />
                    </div>

                    <div class="col-me-4 col-sm-12">
                        <asp:Label Text="NUMERO HABILITANTE:" runat="server" Width="160px" />
                        <asp:TextBox ID="text_numerohabilitante" runat="server" />
                    </div>

                    <div class="col-me-4 col-sm-12">
                        <asp:Label Text="ESTADO: " runat="server" Width="160px" />
                        <asp:TextBox ID="text_estado" runat="server" />
                    </div>

                </div>
            </div>
        </div>
    </div>
    <asp:Button class="btn btn-success " Text="Agregar" ID="btn_Carrera_Agregar" OnClick="btn_Carrera_Agregar_Click" runat="server" />

</asp:Content>
