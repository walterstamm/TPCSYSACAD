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
    public partial class ModificarAlumno : System.Web.UI.Page
    {
        public Alumno modificarAlumno = new Alumno();
        AlumnoNegocio conex_Modif = new AlumnoNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["idAlumno"] != null)
                {
                    int IdAlumno = int.Parse(Request.QueryString["idAlumno"].ToString());
                    Session["Idalumno"] = IdAlumno;
                    modificarAlumno = conex_Modif.Un_alumno(IdAlumno);
                    text_Mod_idalumno.Text = modificarAlumno.Idalumno.ToString();
                    text_Mod_cuil.Text = modificarAlumno.Cuil;
                    text_Mod_apellido.Text = modificarAlumno.Apellido;
                    text_Mod_Nombre.Text = modificarAlumno.Nombre;
                    text_Mod_nacionalidad.Text = modificarAlumno.Nacionalidad;
                    text_Mod_fechanac.Text = modificarAlumno.Fecha_Nac.ToString();
                    text_Mod_mail.Text = modificarAlumno.Mail;
                    text_Mod_Domicilio.Text = modificarAlumno.Domicilio;
                    text_Mod_Localidadpcia.Text = modificarAlumno.Localidad_Prov;
                    //text_usuario.Text = eliminarAlumno.Usuario;
                    //text_estado.Text = eliminarAlumno.Estado.ToString();
                }
            }

        }

        protected void btn_ModificarAlumno_Click(object sender, EventArgs e)
        {
            Alumno modif = new Alumno();

            modif.Idalumno = int.Parse(text_Mod_idalumno.Text);
            modif.Cuil = text_Mod_cuil.Text;
            modif.Apellido = text_Mod_apellido.Text;
            modif.Nombre = text_Mod_Nombre.Text;
            modif.Nacionalidad = text_Mod_nacionalidad.Text;
            modif.Fecha_Nac = DateTime.Parse(text_Mod_fechanac.Text);
            modif.Mail = text_Mod_mail.Text;
            modif.Domicilio = text_Mod_Domicilio.Text;
            modif.Localidad_Prov = text_Mod_Localidadpcia.Text;

            conex_Modif.modificar(modif);
            
        }
    }
}