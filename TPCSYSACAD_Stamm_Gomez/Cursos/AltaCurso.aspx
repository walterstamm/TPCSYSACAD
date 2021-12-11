<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaCurso.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.Cursos.AltaCurso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
        <div class="row g-3 ">
            <div class="col-md-12  text-center">
                <h1>Nuevo Curso</h1>
            </div>


            <div class="input-group mb-3">
                <asp:Label Text="Materia" runat="server" Width="160px" class="input-group-text" />
                <asp:DropDownList ID="ddlMateria" runat="server"></asp:DropDownList>
                 <asp:RequiredFieldValidator runat="server"  ForeColor="Red" ControlToValidate="ddlMateria"  ValidateRequestMode="Enabled" ID="matVal" ErrorMessage="Elija una Materia"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="validator" 
                    runat="server" ForeColor="Red" ControlToValidate="ddlMateria"
                        ErrorMessage="Por favor Seleecione una Opcion" 
                        ValidationExpression="\d+">
                    </asp:RegularExpressionValidator>
            </div>


            <div class="input-group mb-3">
                <asp:Label Text="Cuatrimestre" runat="server" Width="160px" class="input-group-text" />
                <asp:DropDownList ID="ddlCuatrimestre" runat="server"></asp:DropDownList>
                <asp:RequiredFieldValidator runat="server"  ForeColor="Red" ControlToValidate="ddlCuatrimestre"  ValidateRequestMode="Enabled" ID="RequiredFieldValidator1" ErrorMessage="Elija una Materia"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
                    runat="server" ForeColor="Red" ControlToValidate="ddlCuatrimestre"
                        ErrorMessage="Por favor Seleecione una Opcion" 
                        ValidationExpression="\d+">
                    </asp:RegularExpressionValidator>
            </div>



            <div class="input-group mb-3">
                <asp:Label Text="Docente" runat="server" Width="160px" class="input-group-text" />
                <asp:DropDownList ID="ddlDocente" runat="server"></asp:DropDownList>
                <asp:RequiredFieldValidator runat="server"  ForeColor="Red" ControlToValidate="ddlDocente"  ValidateRequestMode="Enabled" ID="RequiredFieldValidator2" ErrorMessage="Elija una Materia"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" 
                    runat="server" ForeColor="Red" ControlToValidate="ddlDocente"
                        ErrorMessage="Por favor Seleecione una Opcion" 
                        ValidationExpression="\d+">
                    </asp:RegularExpressionValidator>
            </div>




            <asp:Button Text="Confirmar" runat="server" ID="btnConfrimar" OnClick="btnConfrimar_Click" />
        </div>

   

</asp:Content>
