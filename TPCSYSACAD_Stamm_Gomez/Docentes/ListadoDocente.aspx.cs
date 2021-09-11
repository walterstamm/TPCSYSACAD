using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPCSYSACAD_Stamm_Gomez
{
    public partial class ListadoDocente : System.Web.UI.Page
    {
        public List<Docente> listados;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuarios"] == null)
            {
                Session.Add("ERROR", "DEBERAS INGRESAR CON USUARIOS Y PASSWARD.........");
                Response.Redirect("../Error.aspx", false);
            }
            else if (Session["Usuarios"] != null && ((Dominio.Usuarios)Session["Usuarios"]).TipoUsuario == Dominio.TipoUsuario.Admin)
            {
                DocenteNegocio listadocente = new DocenteNegocio();

                try
                {
                    RepDocente.DataSource = listadocente.listadocente();
                    RepDocente.DataBind();
                }
                catch (Exception ex)
                {
                    Session.Add("Error", ex.ToString());
                    Response.Redirect("Error.aspx");

                }
            }
            //else
            //{
            //    Session.Add("ERROR", "PARA LA OPCION SELECCIONADA DEBE SER USUARIO NIVEL ****ADMIN*****.........");
            //    Response.Redirect("../Error.aspx", false);
            //}


        }
    }
}