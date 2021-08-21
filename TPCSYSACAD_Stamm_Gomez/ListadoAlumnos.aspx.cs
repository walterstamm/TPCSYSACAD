using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace TPCSYSACAD_Stamm_Gomez
{
    public partial class ListadoAlumnos : System.Web.UI.Page
    {
        public List<Alumno> lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            AlumnoNegocio listarAlumno = new AlumnoNegocio();

            try
            {
                Rep.DataSource = listarAlumno.listaAlumno();
                Rep.DataBind();
            }
            catch (Exception ex)
            {
                //Session.Add("Error", ex.ToString());

                //Response.Redirect("Error.aspx");
            }
        }
    }
}