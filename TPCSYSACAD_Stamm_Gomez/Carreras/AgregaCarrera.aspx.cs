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
    public partial class AgregaCarrera : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Carrera_Agregar_Click(object sender, EventArgs e)
        {

            Carreras NuevaCarrera = new Carreras();
            CarreraNegocio conex_carrera = new CarreraNegocio();

            try
            {

                NuevaCarrera.nombre = text_nombrecarrera.Text;
                NuevaCarrera.numeroplan = text_numeroplan.Text;
                NuevaCarrera.numerohabilitante = text_numerohabilitante.Text;
                NuevaCarrera.estado = int.Parse(text_estado.Text);

                conex_carrera.agregar(NuevaCarrera);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Response.Redirect("ListadoCarreras.aspx");
            }
        }
    }
}