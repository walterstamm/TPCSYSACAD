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
    public partial class Inscribir_Alum_Carrera : System.Web.UI.Page
    {
        public Alumno Al_Inscripcion = new Alumno();
        AlumnoNegocio al_inscripcion = new AlumnoNegocio(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["idAlumno"] != null)
            {
                int IdAlumno = int.Parse(Request.QueryString["idAlumno"].ToString());
                Session["Idalumno"] = IdAlumno;
                Al_Inscripcion = al_inscripcion.Un_alumno(IdAlumno);
                text_Id_alumno.Text = Al_Inscripcion.Idalumno.ToString();
                text_Apellido.Text = Al_Inscripcion.Apellido;
                text_Nombre.Text = Al_Inscripcion.Nombre;
                
            }

            try
            {
                CarreraNegocio conex_dllDinamico = new CarreraNegocio();
                if (!IsPostBack)
                {
                    ddlCarreras.DataSource = conex_dllDinamico.listaCarrera();
                    ddlCarreras.DataValueField = "id_carrera";
                    ddlCarreras.DataTextField = "nombre_carrera";
                    ddlCarreras.DataBind();
                    ddlCarreras.Items.Insert(0, new ListItem("Seleccione una Carrera"));

                }
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
            }

        }

        protected void ddl_carreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID_CARRERA;
            ID_CARRERA=int.Parse(ddlCarreras.SelectedItem.Value);
        }

        protected void btn_Incribir_Click(object sender, EventArgs e)
        {

        }
    }
}