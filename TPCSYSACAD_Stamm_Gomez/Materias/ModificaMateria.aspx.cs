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
    public partial class ModificaMateria : System.Web.UI.Page
    {
        public Materias modifMateria = new Materias();
        MateriaNegocio conex_Materia = new MateriaNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Request.QueryString["idMateria"] != null)
                {
                    int idmat = int.Parse(Request.QueryString["idMateria"].ToString());
                    Session["IDMATERIA"] = idmat;
                    modifMateria = conex_Materia.UnaMateria(idmat);
                    text_Mod_idmateria.Text = modifMateria.idmateria.ToString();
                    text_Mod_nombremateria.Text = modifMateria.nombremateria;
                    text_Mod_Carrera.Text = modifMateria.idcarrera.ToString();
                    text_Mod_anio.Text = modifMateria.anio.ToString();
                    text_Mod_cuatrimestre.Text = modifMateria.cuatrimestre.ToString();
                }
            }
        }

        protected void btn_ModificarMateria_Click(object sender, EventArgs e)
        {
            Materias modif = new Materias();

            modif.idmateria = int.Parse(text_Mod_idmateria.Text);
            modif.nombremateria = text_Mod_nombremateria.Text;
            modif.idcarrera = int.Parse(text_Mod_Carrera.Text);
            modif.anio = int.Parse(text_Mod_anio.Text);
            modif.cuatrimestre = int.Parse(text_Mod_cuatrimestre.Text);

            conex_Materia.Modificar(modif);
            Response.Redirect("ListadoMaterias.aspx");
        }
    }
}