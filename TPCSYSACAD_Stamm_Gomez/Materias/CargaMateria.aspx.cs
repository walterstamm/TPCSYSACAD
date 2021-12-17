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
        CuatrimestreNegocio cuaNeg = new CuatrimestreNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuarios"] == null || !(Util.validacionAdmin((Usuarios)Session["Usuarios"])))
            {

                Response.Redirect("../Login/Login.aspx", false);
            }
            ddlCuatrimestre.DataSource = cuaNeg.listaCuatrimestres();
            ddlCuatrimestre.DataValueField = "IdCuatrimestre";
            ddlCuatrimestre.DataTextField = "nombreCuatrimestre";
            ddlCuatrimestre.Items.Insert(0, new ListItem("Seleccione una Cuatrimestre"));
            ddlCuatrimestre.DataBind();

        }

        protected void btn_mat_Agregar_Click(object sender, EventArgs e)
        {
            Materias nuevaMateria = new Materias();
            MateriaNegocio materiaNegocio = new MateriaNegocio();

            try
            {
                nuevaMateria.nombremateria = text_Nombre_Materia.Text;
                nuevaMateria.anio = int.Parse(text_anio_curso.Text);
                nuevaMateria.cuatrimestre = int.Parse(ddlCuatrimestre.SelectedItem.Value);

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