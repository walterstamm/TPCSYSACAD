<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Ooooops...  Ha ocurrido algun Error ............</h1>
    <asp:Label ID="lblError" Text="Error" runat="server" />

    <a href="Default.aspx" class="btn btn-primary">Volver</a>

</asp:Content>
