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
    public partial class ListadoMaterias : System.Web.UI.Page
    {
        public List<Materias> list_Materias;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuarios"] == null)
            {
                Session.Add("ERROR", "DEBERAS INGRESAR CON USUARIOS Y PASSWARD.........");
                Response.Redirect("../Error.aspx", false);
            }
            else if (Session["Usuarios"] != null && ((Dominio.Usuarios)Session["Usuarios"]).TipoUsuario == TipoUsuario.Admin)
            {

                MateriaNegocio conex_materia = new MateriaNegocio();

                try
                {
                    Rep_Materias.DataSource = conex_materia.listMateria();
                    Rep_Materias.DataBind();
                }
                catch (Exception ex)
                {
                    Session.Add("Error", ex.ToString());

                    //Response.Redirect("Error.aspx");
                }
            }
        }

        
    }
}