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
    public partial class AgregarNota : System.Web.UI.Page
    {
        public Alumno_Materia AgregoNota = new Alumno_Materia();
        AlumnoMaterriaNegocio conex_AgregNota = new AlumnoMaterriaNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["Usuarios"] == null || !(Util.validacionAdmin((Usuarios)Session["Usuarios"])))
            //{

            //    Response.Redirect("../Login/Login.aspx", false);
            //}

            if (!IsPostBack)
            {
                if(Request.QueryString["idMxDoc"] != null)
                {
                    int idMC = int.Parse(Request.QueryString["idMxDoc"].ToString());
                    Session["ID"] = idMC;
                    AgregoNota = conex_AgregNota.un_alumno_Materia(idMC);

                    text_ID_MxD.Text = AgregoNota.id.ToString();
                    text_ID_ALUM.Text = AgregoNota.idalumno.ToString();
                    text_ID_MATDOC.Text = AgregoNota.idmateriadocente.ToString();
                    text_EVENTO1.Text = AgregoNota.evento1.ToString();
                    text_EVENTO2.Text = AgregoNota.evento2.ToString();
                    text_REC1.Text = AgregoNota.rec1.ToString();
                    text_REC2.Text = AgregoNota.rec2.ToString();
                    text_NOTA_FINAL.Text = AgregoNota.notafinal.ToString();
                    text_RESULTADO_FINAL.Text = AgregoNota.resultadofinal;

                }
            }

        }

        protected void btn_CargarNota_Click(object sender, EventArgs e)
        {
            Alumno_Materia agregoNota = new Alumno_Materia();

            agregoNota.id = int.Parse(text_ID_MxD.Text);
            agregoNota.idalumno = int.Parse(text_ID_ALUM.Text);
            agregoNota.idmateriadocente = int.Parse(text_ID_MATDOC.Text);
            agregoNota.evento1 = int.Parse(text_EVENTO1.Text);
            agregoNota.evento2 = int.Parse(text_EVENTO2.Text);
            agregoNota.rec1 = int.Parse(text_REC1.Text);
            agregoNota.rec2 = int.Parse(text_REC2.Text);
            agregoNota.notafinal = decimal.Parse(text_NOTA_FINAL.Text);
            agregoNota.resultadofinal = text_RESULTADO_FINAL.Text;

            conex_AgregNota.modificar(agregoNota);
            Response.Redirect("../Listado_AlumnoMateria.aspx");
        }
    }
}