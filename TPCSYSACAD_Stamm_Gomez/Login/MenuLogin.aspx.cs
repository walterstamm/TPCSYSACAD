using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPCSYSACAD_Stamm_Gomez.Login
{
    public partial class MenuLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuarios"] == null)
            {
                Session.Add("error", "Debes loguearte para ingresar");
                Response.Redirect("../Error.aspx", false);
            }
        }

        protected void btnPagina1_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnPagina2_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnDocente_Click(object sender, EventArgs e)
        {

        }

        protected void btn_Alumno_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Alumnos/ListadoAlumnos.aspx", false);
        }

        protected void btn_Docente_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Docentes/ListadoDocente.aspx", false);
        }

        protected void btn_Acc_Docente_Click(object sender, EventArgs e)
        {
            //ACA VA EL ENLACE DE LA PANTALLA DE ACCESO DE LOS DOCENTES
        }
    }
}