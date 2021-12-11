<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModificarAlumno.aspx.cs" Inherits="TPCSYSACAD_Stamm_Gomez.ModificarAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">
				<div class="col-md-12  text-center">
					<h1>Modificando Alumno </h1>  
					
				</div>
			</div>
    
    <div class="container">
        <div class="row py-3">
            <div class="col" id="main">
               
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="ID" runat="server"  Width="200px" />
                            <asp:TextBox runat="server" ID="text_Mod_idalumno" class="form-control" Enabled="false" TextMode="Number"   style="text-align: center"/>
                        </div>
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="CUIL" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_Mod_cuil" Width="200px"   />
                        </div>
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="Apellido" runat="server" Width="200px"/>
                            <asp:TextBox runat="server" ID="text_Mod_apellido" Width="200px"   />
                        </div>
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="Nombre" runat="server" width="200px"/>
                            <asp:TextBox runat="server" ID="text_Mod_Nombre" Width="200px"/>    

                        </div>


                     
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="Fecha de Nacimiento" runat="server" Width="200px" />
                            <asp:TextBox runat="server" ID="text_Mod_fechanac" TextMode="DateTime" Width="200px"/>
                        </div>
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="Email" runat="server" Width="200px"/>
                            <asp:TextBox runat="server" ID="text_Mod_mail" Width="200px"/>
                        </div>
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="Domicilio" runat="server" Width="200px"/>
                            <asp:TextBox runat="server" ID="text_Mod_Domicilio" Width="200px"/>
                        </div>
                        <div class="col-md-6 col-sm-12">
                            <asp:Label Text="Localidad" runat="server" Width="200px"/>
                            <asp:TextBox runat="server" ID="text_Mod_Localidadpcia" Width="200px" />
                        </div>
                        <br />
                        <asp:Button class="btn btn-warning" Text="Modificar" ID="btn_ModificarAlumno" runat="server" onclick="btn_ModificarAlumno_Click"/>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </div>

</asp:Content>
