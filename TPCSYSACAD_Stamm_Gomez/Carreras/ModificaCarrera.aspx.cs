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
    public partial class ModificaCarrera : System.Web.UI.Page
    {
        public Carreras modificoCarrera = new Carreras();
        CarreraNegocio conex_Carrera = new CarreraNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Request.QueryString["idCarrera"] != null)
                {
                    int idcarr = int.Parse(Request.QueryString["idCarrera"].ToString());
                    Session["ID"] = idcarr;
                    modificoCarrera = conex_Carrera.UnaCarrera(idcarr);
                    text_Mod_idcarrera.Text = modificoCarrera.id.ToString();
                    text_Mod_nombrecarrera.Text = modificoCarrera.nombre;
                    text_Mod_numeroplan.Text = modificoCarrera.numeroplan;
                    text_Mod_numerohabilitante.Text = modificoCarrera.numerohabilitante;
                    text_Mod_estado.Text = modificoCarrera.estado.ToString();

                }
            }
        }

        protected void btn_ModificarCarrera_Click(object sender, EventArgs e)
        {
            Carreras modifico = new Carreras();

            modifico.id = int.Parse(text_Mod_idcarrera.Text);
            modifico.nombre = text_Mod_nombrecarrera.Text;
            modifico.numeroplan = text_Mod_numeroplan.Text;
            modifico.numerohabilitante = text_Mod_numerohabilitante.Text;
            modifico.estado = int.Parse(text_Mod_estado.Text);

            conex_Carrera.Modificar(modifico);
            Response.Redirect("ListadoCarreras.aspx");
        }
    }
}