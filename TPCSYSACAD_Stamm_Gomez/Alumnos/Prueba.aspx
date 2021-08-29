<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Prueba.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.Prueba" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>PRUEBA</h1>
    <br />
    <h5>DROPDOWNLIST FIJO</h5>
    <asp:Label Text="FIJO....." runat="server"  />
    <asp:DropDownList runat="server" CssClass="btn btn-outline-dark dropdown-toggle" >
        <asp:ListItem Text="text1" />
        <asp:ListItem Text="text2" />
    </asp:DropDownList>
    <br />  <br />
    <h5>DROPDOWNLIST DINAMICO</h5>
    <br />
    <asp:Label Text="DINAMICO" runat="server" />
    <asp:DropDownList runat="server" CssClass="btn btn-outline-dark dropdown-toggle" OnSelectedIndexChanged="ddl_carreras_SelectedIndexChanged" ID="ddl_carreras" >
        
    </asp:DropDownList>
</asp:Content>
