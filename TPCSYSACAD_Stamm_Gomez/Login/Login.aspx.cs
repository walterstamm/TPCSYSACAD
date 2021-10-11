﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPCSYSACAD_Stamm_Gomez.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuarios usuario;
            UsusarioNegocio conex_usuario = new UsusarioNegocio();

            try
            {
                usuario = new Usuarios(txtUser.Text, txtPassword.Text, false );
                if (conex_usuario.Loguear(usuario))
                {
                    Session.Add("Usuarios", usuario);
                    Util.usuarioLogeado = usuario.User;
                    Response.Redirect("MenuLogin.aspx", false);
                }
                else
                {
                    Session.Add("ERROR....", "USUARIO Y/O PASWARD INCORRECTO");
                    Response.Redirect("../Error.aspx", false);
                }

            }
            catch (Exception ex)
            {

                Session.Add("ERROR EN PAGINA LOGIN", ex.ToString());
                Response.Redirect("../Error.aspx");
            }
        }
    }
}