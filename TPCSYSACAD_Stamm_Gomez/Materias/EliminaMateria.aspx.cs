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
    public partial class EliminaMateria : System.Web.UI.Page
    {

        public Materias eliminarMateria = new Materias();
        MateriaNegocio conex_Materia = new MateriaNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Util.tipoUsuario != 3)
            //{
            //    Session.Add("ERROR", "DEBERAS INGRESAR CON USUARIO ADMIN CARGADOCENTE.........");
            //    Response.Redirect("../Error.aspx", false);
            //}
            //else
            //{

                if (Request.QueryString["idMateria"] != null)
                {
                    int materia = int.Parse(Request.QueryString["idMateria"].ToString());
                    Session["IDMATERIA"] = materia;
                    eliminarMateria = conex_Materia.UnaMateria(materia);
                    text_idmateria.Text = eliminarMateria.idmateria.ToString();
                    text_nombre_materia.Text = eliminarMateria.nombremateria;
                    text_idcarrera.Text = eliminarMateria.idcarrera.ToString();
                    text_curso_año.Text = eliminarMateria.anio.ToString();
                    text_cuatrimestre.Text = eliminarMateria.cuatrimestre.ToString();

                }
            //}
        }

        protected void EliminarMateria_Click(object sender, EventArgs e)
        {
            int materia = int.Parse(text_idmateria.Text);

            conex_Materia.Eliminar(materia);
            Response.Redirect("ListadoMaterias.aspx");
        }
    }
}