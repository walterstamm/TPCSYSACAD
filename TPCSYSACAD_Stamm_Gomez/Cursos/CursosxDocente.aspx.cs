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
    public partial class CursosxDocencte : System.Web.UI.Page
    {
        CursoNegocio curNeg = new CursoNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuarios"] == null || !(Util.validacionDocente((Usuarios)Session["Usuarios"])))
              {

                  Response.Redirect("../Login/Login.aspx", false);
               }

           
            
                int id = int.Parse(Session["IdDocente"].ToString());
                RepCursos.DataSource = curNeg.listadoCursosxDocente(id);
                RepCursos.DataBind();
               

            
           
        }
    }
}