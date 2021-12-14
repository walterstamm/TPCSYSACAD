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
    public partial class ModificarDocente : System.Web.UI.Page
    {
        public Docente modifDocente = new Docente();
        DocenteNegocio conex_Docente = new DocenteNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuarios"] == null || !(Util.validacionAdmin((Dominio.Usuarios)Session["Usuarios"])))
            {
                Response.Redirect("../Login/Login.aspx", false);
            }



            if (!IsPostBack)
            {
                if (Request.QueryString["idDocente"] != null)
                {
                    int idDoc = int.Parse(Request.QueryString["idDocente"].ToString());
                    Session["IDDOCENTE"] = idDoc;
                    modifDocente = conex_Docente.un_docente(idDoc);
                    text_Mod_iddocente.Text = modifDocente.Iddocente.ToString();
                    text_Mod_cuil.Text = modifDocente.Cuil;
                    text_Mod_apellido.Text = modifDocente.Apellido;
                    text_Mod_nombre.Text = modifDocente.Nombre;
                    text_Mod_nacionalidad.Text = modifDocente.Nacionalidad;
                    text_Mod_fechanac.Text = modifDocente.FechaNacimiento .ToString();
                    text_Mod_mail.Text = modifDocente.EMail;
                    text_Mod_Domicilio.Text = modifDocente.Domicilio;
                    //text_Mod_Localidadpcia.Text = modifDocente.Localidad_Prov;
                }
            }

        }

        protected void btn_ModificarDocente_Click(object sender, EventArgs e)
        {
            Docente modif = new Docente();

            modif.Iddocente = int.Parse(text_Mod_iddocente.Text);
            modif.Cuil = text_Mod_cuil.Text;
            modif.Apellido = text_Mod_apellido.Text;
            modif.Nombre = text_Mod_nombre.Text;
            modif.Nacionalidad = text_Mod_nacionalidad.Text;
            modif.FechaNacimiento = DateTime.Parse(text_Mod_fechanac.Text);
            modif.EMail = text_Mod_mail.Text;
            modif.Domicilio = text_Mod_Domicilio.Text;
            //modif.Localidad_Prov = text_Mod_Localidadpcia.Text;

            conex_Docente.modificar(modif);
            Response.Redirect("ListadoDocente.aspx");

        }
    }
}