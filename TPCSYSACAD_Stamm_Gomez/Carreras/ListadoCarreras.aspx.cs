using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace TPCSYSACAD_Stamm_Gomez
{
    public partial class ListadoCarreras : System.Web.UI.Page
    {
        public List<Carreras> lis_carreras;
        protected void Page_Load(object sender, EventArgs e)
        {
            CarreraNegocio conex_Carrera = new CarreraNegocio();

            try
            {
                if (Session["Usuarios"] == null || !(Util.validacionAdmin((Usuarios)Session["Usuarios"])))
                {

                    Response.Redirect("../Login/Login.aspx", false);
                }

                Rep_Carreras.DataSource = conex_Carrera.listaCarrera();
                Rep_Carreras.DataBind();
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());

                Response.Redirect("../Error.aspx");
            }

        }
    }
}