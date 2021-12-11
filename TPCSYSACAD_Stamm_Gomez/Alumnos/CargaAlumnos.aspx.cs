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
    public partial class CargaAlumnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuarios"] == null || !(Util.validacionAdmin((Usuarios)Session["Usuarios"])))
            {
                
                Response.Redirect("../Login/Login.aspx", false);
            }

        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Alumno nuevoAlumno = new Alumno();
            AlumnoNegocio alumnoNegocio = new  AlumnoNegocio();

            try
            {
                nuevoAlumno.Cuil = (text_Cuil.Text);
                nuevoAlumno.Apellido= (text_Apellido.Text);
                nuevoAlumno.Nombre = (text_Nombre.Text);
               // nuevoAlumno.Nacionalidad = (text_Nacionalidad.Text);
                nuevoAlumno.Fecha_Nac = DateTime.Parse(text_FechaNac.Text);
                nuevoAlumno.Mail = (text_Mail.Text);
                nuevoAlumno.Domicilio = (text_Domicilio.Text);
                nuevoAlumno.Localidad_Prov = (text_Localidad.Text);
                //nuevoAlumno.Usuario = (string)("null");
                //nuevoAlumno.Estado = int.Parse("0");

                alumnoNegocio.agregar(nuevoAlumno);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Response.Redirect("ListadoAlumnos.aspx");
            }

        }
    }
}