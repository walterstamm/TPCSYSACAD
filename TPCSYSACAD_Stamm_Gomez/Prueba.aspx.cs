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
    public partial class Prueba : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                CarreraNegocio conex_dllDinamico = new CarreraNegocio();
                if (!IsPostBack)
                {
                    ddlCarreras.DataSource = conex_dllDinamico.listaCarrera();
                    ddlCarreras.DataValueField = "id_carrera";
                    ddlCarreras.DataTextField = "nombre_carrera";
                    ddlCarreras.DataBind();
                    ddlCarreras.Items.Insert(0, new ListItem("Seleccione una Carrera"));
                 
                }
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
            }

        }

        protected void ddl_carreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int ID_CARRERA;
            //ID_CARRERA=int.Parse(ddlCarreras.SelectedItem.Value);
        }
    }
}