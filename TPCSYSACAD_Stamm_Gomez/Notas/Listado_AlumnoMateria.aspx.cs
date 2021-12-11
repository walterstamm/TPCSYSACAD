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
    public partial class Listado_AlumnoMateria : System.Web.UI.Page
    {
        public List<Alumno_Materia> Listado;
        protected void Page_Load(object sender, EventArgs e)
        {
            AlumnoMateriaNegocio l_alumno_Materia = new AlumnoMateriaNegocio();

            try
            {
                RepAlumMat.DataSource = l_alumno_Materia.lista_alumno_Materias();
                RepAlumMat.DataBind();
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("../../Error.aspx");
            }
        }
    }
}