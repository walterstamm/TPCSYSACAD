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
    public partial class ListadoAlumnos : System.Web.UI.Page
    {
        public List<Alumno> lista;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuarios"] == null || !(Util.validacionAdmin((Usuarios)Session["Usuarios"])))
            {

                Response.Redirect("../Login/Login.aspx", false);
            }
            else
           
            {
                AlumnoNegocio listarAlumno = new AlumnoNegocio();

                try
                {
                    Rep.DataSource = listarAlumno.listaAlumno();
                    Rep.DataBind();
                }
                catch (Exception ex)
                {
                    Session.Add("Error.Alumno", ex.ToString());

                    Response.Redirect("Error.aspx");
                }
           // }
        //    else
       //     if (Session["Usuarios"] != null && ((Dominio.Usuarios)Session["Usuarios"]).TipoUsuario != Dominio.TipoUsuario.Admin)
       //     {
      //          Session.Add("ERROR", "PARA LA OPCION SELECCIONADA DEBE SER USUARIO NIVEL ****ADMIN*****.........");
       //         Response.Redirect("../Error.aspx", false);
           }

        }
    

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            AlumnoNegocio eliminoID = new AlumnoNegocio();

            //int idalumno = int.Parse(); lo hice con la idea de eliminar sin hacer una pagina, pero me quede en el camino

            //eliminoID.eliminar(idalumno); No se como

        }
    }
}