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
    public partial class CargaDocente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Util.tipoUsuario != 2)
            {
                Session.Add("ERROR", "DEBERAS INGRESAR CON USUARIO ADMIN CARGADOCENTE.........");
                Response.Redirect("../Error.aspx", false);
            }
        }

        protected void btn_doc_Agregar_Click(object sender, EventArgs e)
        {
            Docente nuevoDocente = new Docente();
            DocenteNegocio docenteNegocio = new DocenteNegocio();

            try
            {
                nuevoDocente.Cuil = text_doc_Cuil.Text;
                nuevoDocente.ApellidoNombre = text_doc_ApellidoNombre.Text;
                nuevoDocente.Nacionalidad = text_doc_Nacionalidad.Text;
                nuevoDocente.Fecha_Nac = DateTime.Parse(text_doc_FechaNac.Text);
                nuevoDocente.Mail = text_doc_Mail.Text;
                nuevoDocente.Domicilio = text_doc_Domicilio.Text;
                nuevoDocente.Localidad_Prov = text_doc_Localidad.Text;
                //nuevoDocente.Usuario = (string)("null");
                //nuevoDocente.Estado = int.Parse("0");

                docenteNegocio.agregar(nuevoDocente);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Response.Redirect("ListadoDocente.aspx");
            }
        }
    }
}