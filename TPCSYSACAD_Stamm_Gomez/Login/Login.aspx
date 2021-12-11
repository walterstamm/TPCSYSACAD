<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.Login.Login" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-6">
        <div class="mb-3">
            <br />
            <label class="form-label">User</label>
            <asp:TextBox runat="server" id="txtUser" placeholder="user name" CssClass="form-control"/>
        </div>
        <div class="mb-3">
            <label class="form-label">Password</label>
            <asp:TextBox runat="server" placeholder="*****" id="txtPassword" CssClass="form-control" TextMode="Password"/>
        </div>
        <asp:Button Text="Ingresar" runat="server" ID="btnIngresar" OnClick="btnIngresar_Click" cssclass="btn btn-primary"/>
    </div>
</asp:Content>