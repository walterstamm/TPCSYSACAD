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
    public partial class ListadoDocente : System.Web.UI.Page
    {
        public List<Docente> listados;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuarios"] == null || !(Util.validacionAdmin((Dominio.Usuarios)Session["Usuarios"])))
            {
                Response.Redirect("../Login/Login.aspx", false);
            }
            else 
                
            {
                DocenteNegocio listadocente = new DocenteNegocio();

                try
                {
                    RepDocente.DataSource = listadocente.listadocente();
                    RepDocente.DataBind();
                }
                catch (Exception ex)
                {
                    
                    Session.Add("Error", ex.ToString());
                    Response.Redirect("Error.aspx");

                }
            }


        }
    }
}