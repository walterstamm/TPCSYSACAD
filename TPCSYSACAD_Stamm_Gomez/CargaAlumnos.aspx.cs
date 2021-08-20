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

        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Alumno nuevoAlumno = new Alumno();
            AlumnoNegocio alumnoNegocio = new  AlumnoNegocio();

            try
            {
                nuevoAlumno.Cuil = (string)(text_Cuil.Text);
                nuevoAlumno.ApellidoNombre = (string)(text_ApellidoNombre.Text);
                nuevoAlumno.Nacionalidad = (string)(text_Nacionalidad.Text);
                nuevoAlumno.Fecha_Nac = DateTime.Parse(text_FechaNac.Text);
                nuevoAlumno.Mail = (string)(text_Mail.Text);
                nuevoAlumno.Domicilio = (string)(text_Domicilio.Text);
                nuevoAlumno.Localidad_Prov = (string)(text_Localidad.Text);
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
                Response.Redirect("CargaAlumnos.aspx");
            }

        }
    }
}