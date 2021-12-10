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
    public partial class EliminaCarrera : System.Web.UI.Page
    {

        public Carreras eliminoCarrera = new Carreras();
        CarreraNegocio conex_Carrera = new CarreraNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["idCarrera"] != null)
            {
                int carrera = int.Parse(Request.QueryString["idCarrera"].ToString());
                Session["ID"] = carrera;
                eliminoCarrera = conex_Carrera.UnaCarrera(carrera);
                text_idCarrera.Text = eliminoCarrera.id.ToString();
                text_nombreCarrera.Text = eliminoCarrera.nombre;
                text_numeroPlan.Text = eliminoCarrera.numeroplan;
                text_numeroHabilitante.Text = eliminoCarrera.numerohabilitante;
                text_Estado.Text = eliminoCarrera.estado.ToString();

            }

        }

        protected void EliminarCarrera_Click(object sender, EventArgs e)
        {
            int carrera = int.Parse(text_idCarrera.Text);

            conex_Carrera.Eliminar(carrera);
            Response.Redirect("ListadoCarreras.aspx");

        }
    }
}