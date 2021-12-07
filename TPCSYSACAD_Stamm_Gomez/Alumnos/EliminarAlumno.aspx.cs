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
    public partial class EliminarAlumno : System.Web.UI.Page
    {
        public Alumno eliminarAlumno = new Alumno();
        AlumnoNegocio conex_Alumno = new AlumnoNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["idAlumno"] != null)
            {
                int IdAlumno = int.Parse(Request.QueryString["idAlumno"].ToString());
                Session["Idalumno"] = IdAlumno;
                eliminarAlumno = conex_Alumno.Un_alumno(IdAlumno);
                text_idalumno.Text = eliminarAlumno.Idalumno.ToString();
                text_cuil.Text = eliminarAlumno.Cuil;
                text_apellido.Text = eliminarAlumno.Apellido;
                text_nombre.Text = eliminarAlumno.Nombre;
                text_nacionalidad.Text = eliminarAlumno.Nacionalidad;
                text_fechanacimiento.Text = eliminarAlumno.Fecha_Nac.ToString();
                text_mail.Text = eliminarAlumno.Mail;
                text_domicilio.Text = eliminarAlumno.Domicilio;
                text_localidadpcia.Text = eliminarAlumno.Localidad_Prov;
                //text_usuario.Text = eliminarAlumno.Usuario;
                //text_estado.Text = eliminarAlumno.Estado.ToString();
            }

        }

        protected void EliminarAlumno_Click(object sender, EventArgs e)
        {
            int idalumno = int.Parse(text_idalumno.Text);

            conex_Alumno.eliminar(idalumno);
            Response.Redirect("ListadoAlumnos.aspx");

        }
    }
}