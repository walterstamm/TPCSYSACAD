using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPCSYSACAD_Stamm_Gomez.UsuariosNuevos
{
    public partial class AltaUsuario : System.Web.UI.Page
    {
        UsusarioNegocio usuNeg = new UsusarioNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {



                //if (Session["Usuarios"] == null || !(Util.validacionAdmin((Usuarios)Session["Usuarios"])))
                //{

                //    Response.Redirect("../Login/Login.aspx", false);
                //}



                ddlDocentes.DataSource = usuNeg.listaDocente();
                ddlDocentes.DataValueField = "Iddocente";
                ddlDocentes.DataTextField = "Nombre";
                ddlDocentes.DataBind();
                ddlDocentes.Items.Insert(0, new ListItem("Seleccione una Docente"));

            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            int id = int.Parse(ddlDocentes.SelectedItem.Value);

            usuNeg.actualizarEstadoDocente(id);

            Usuarios usu = new Usuarios();

            usu.usuario = txtUsuario.Text;
            usu.password = txtPasword.Text;
            usu.idDocente = id;

            usuNeg.agregar(usu);
        }
    }
}