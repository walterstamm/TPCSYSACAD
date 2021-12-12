<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminaMateria.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.EliminaMateria" %>

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
                    <asp:TextBox ID="text_idmateria" runat="server" Enabled="false"/>
                </div>
                <div class="col-md-6 col-sm-12">
                    <asp:Label Text="MATERIA:  " runat="server" width="200px"/>
                    <asp:TextBox ID="text_nombre_materia" runat="server" Enabled="false"/>
                </div>
                <div class="col-md-6 col-sm-12">
                    <asp:Label Text="IDCARRERA:  " runat="server" width="200px"/>
                    <asp:TextBox ID="text_idcarrera" runat="server" Enabled="false"/>
                </div>
                <div class="col-md-6 col-sm-12">
                    <asp:Label Text="CURSO AÑO:  " runat="server" width="200px"/>
                    <asp:TextBox ID="text_curso_año" runat="server" Enabled="false"/>
                </div>
                <div class="col-md-6 col-sm-12">
                    <asp:Label Text="CUATRIMESTRE:  " runat="server" width="200px"/>
                    <asp:TextBox ID="text_cuatrimestre" runat="server" Enabled="false"/>
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />
    <div class="form-group">
        <asp:Button Class="btn btn-danger" Text="Eliminar" ID="EliminarMateria" OnClick="EliminarMateria_Click" runat="server" />
    </div>
</asp:Content>