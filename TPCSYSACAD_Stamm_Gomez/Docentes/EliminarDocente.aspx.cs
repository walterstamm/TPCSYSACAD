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
    public partial class EliminarDocente : System.Web.UI.Page
    {
        public Docente eliminarDocente = new Docente();
        DocenteNegocio conex_Docente = new DocenteNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["idDocente"] != null)
            {
                int docente = int.Parse(Request.QueryString["idDocente"].ToString());
                Session["iddocente"] = docente;
                eliminarDocente = conex_Docente.un_docente(docente);
                text_doc_iddocente.Text = eliminarDocente.Iddocente.ToString();
                text_doc_cuil.Text = eliminarDocente.Cuil;
                text_doc_apellidonombre.Text = eliminarDocente.ApellidoNombre;
                text_doc_nacionalidad.Text = eliminarDocente.Nacionalidad;
                text_doc_fechanacimiento.Text = eliminarDocente.Fecha_Nac.ToString();
                text_doc_mail.Text = eliminarDocente.Mail;
                text_doc_domicilio.Text = eliminarDocente.Domicilio;
                text_doc_localidadpcia.Text = eliminarDocente.Localidad_Prov;
                //text_doc_usuario.Text = eliminarDocente.Usuario;
                //text_doc_Estado.Text = eliminarDocente.Estado;

            }

        }

        protected void EliminarDocente_Click(object sender, EventArgs e)
        {
            int docente = int.Parse(text_doc_iddocente.Text);

            conex_Docente.eliminar(docente);
            Response.Redirect("ListadoDocente.aspx");
        }
    }
}