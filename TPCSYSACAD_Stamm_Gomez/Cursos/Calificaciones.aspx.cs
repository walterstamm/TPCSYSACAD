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
    public partial class Calificaciones : System.Web.UI.Page
    {
        NotaNegocio notNeg = new NotaNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["idNota"] != null)
            {
                int id = int.Parse(Request.QueryString["idNota"].ToString());


                repAlum.DataSource = notNeg.listaNotas(id);
                repAlum.DataBind();
                Session["idCalificacion"] = id;
            }
            else
            {
                int id = int.Parse(Session["idCalificacion"].ToString());
                repAlum.DataSource = notNeg.listaNotas(id);
                repAlum.DataBind();

            }
        }
    }
}