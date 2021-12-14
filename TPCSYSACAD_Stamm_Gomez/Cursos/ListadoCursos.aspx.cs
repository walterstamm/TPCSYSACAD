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
    public partial class ListadoCursos : System.Web.UI.Page
    {
        CursoNegocio curNeg = new CursoNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuarios"] == null || !(Util.validacionAdmin((Dominio.Usuarios)Session["Usuarios"])))
            {
                Response.Redirect("../Login/Login.aspx", false);
            }
            else
            {
                RepCursos.DataSource = curNeg.listadoCursos();
                RepCursos.DataBind();
            }

        }
    }
}