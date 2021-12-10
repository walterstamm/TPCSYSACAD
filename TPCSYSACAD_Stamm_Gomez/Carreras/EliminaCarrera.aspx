<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminaCarrera.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.EliminaCarrera" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">
        <div class="col-md-12  text-center">
            <h1>Eliminar Materia </h1>

        </div>
    </div>


    <div class="container">
        <div class="row py-3">
            <div class="col" id="main">

                <div class="col-md-6 col-sm-12">
                    <asp:Label Text="IDMATERIA:  " runat="server" width="200px"/>
                    <asp:TextBox ID="text_idCarrera" runat="server" Enabled="false"/>
                </div>

                <div class="col-md-6 col-sm-12">
                    <asp:Label Text="NOMBRE CARRERA:  " runat="server" width="200px"/>
                    <asp:TextBox ID="text_nombreCarrera" runat="server" Enabled="false"/>
                </div>

                <div class="col-md-6 col-sm-12">
                    <asp:Label Text="NUMERO PLAN:  " runat="server" width="200px"/>
                    <asp:TextBox ID="text_numeroPlan" runat="server" Enabled="false"/>
                </div>

                <div class="col-md-6 col-sm-12">
                    <asp:Label Text="NUMERO HABILITANTE:  " runat="server" width="200px"/>
                    <asp:TextBox ID="text_numeroHabilitante" runat="server" Enabled="false"/>
                </div>

                <div class="col-md-6 col-sm-12">
                    <asp:Label Text="ESTADO:  " runat="server" width="200px"/>
                    <asp:TextBox ID="text_Estado" runat="server" Enabled="false"/>
                </div>

            </div>
        </div>
    </div>







                <br />
                <br />
                <div class="form-group">
                    <asp:Button Class="btn btn-danger" Text="Eliminar" ID="EliminarCarrera" OnClick="EliminarCarrera_Click" runat="server" />
                </div>


</asp:Content>
