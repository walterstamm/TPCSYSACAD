using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPCSYSACAD_Stamm_Gomez.Cursos
{
    public partial class EliminarCurso : System.Web.UI.Page
    {
        CursoNegocio negCur = new CursoNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuarios"] == null || !(Util.validacionAdmin((Dominio.Usuarios)Session["Usuarios"])))
            {
                Response.Redirect("../Login/Login.aspx", false);
            }

            if (Request.QueryString["IdCurso"] != null)
            {
                int idCurso = int.Parse(Request.QueryString["IdCurso"].ToString());
                Dominio.Cursos cur = new Dominio.Cursos();
                cur = negCur.unCurso(idCurso);
                txtId.Text = cur.Id.ToString();
                txtCuil.Text = cur.cuilDocente;
                txtApellido.Text = cur.apellidoDocente;
                txtNombre.Text = cur.nombreDocente;
                txtMateria.Text = cur.Materia;
                txtCuatrimestre.Text = cur.cuatrimestre;
                txtAnio.Text = cur.Anio.ToString();

            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id =  int.Parse(txtId.Text);
            negCur.eliminar(id);
            Response.Redirect("ListadoCursos.aspx", false);
        }
    }
}