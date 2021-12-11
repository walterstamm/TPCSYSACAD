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
    public partial class CargaMateria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Util.tipoUsuario != 3)
            //{
            //    Session.Add("ERROR", "DEBERAS INGRESAR CON USUARIO ADMIN CARGADOCENTE.........");
            //    Response.Redirect("../Error.aspx", false);
            //}
        }

        protected void btn_mat_Agregar_Click(object sender, EventArgs e)
        {
            Materias nuevaMateria = new Materias();
            MateriaNegocio materiaNegocio = new MateriaNegocio();

            try
            {
                nuevaMateria.nombremateria = text_Nombre_Materia.Text;
                nuevaMateria.idcarrera = int.Parse(text_carrera.Text);
                nuevaMateria.anio = int.Parse(text_anio_curso.Text);
                nuevaMateria.cuatrimestre = int.Parse(text_cuatrimestre.Text);

                materiaNegocio.agregar(nuevaMateria);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Response.Redirect("ListadoMaterias.aspx");
            }
        }
    }
}