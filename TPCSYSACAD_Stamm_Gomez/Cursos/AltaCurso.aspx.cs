using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPCSYSACAD_Stamm_Gomez.Cursos
{
    public partial class AltaCurso : System.Web.UI.Page
    {

        public MateriaNegocio matNeg = new MateriaNegocio();
        public CuatrimestreNegocio cuaNeg = new CuatrimestreNegocio();
        public DocenteNegocio docNeg = new DocenteNegocio();
        public AlumnoNegocio alumNeg = new AlumnoNegocio();
        public CursoNegocio curNeg = new CursoNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {


                if (Session["Usuarios"] == null || !(Util.validacionAdmin((Usuarios)Session["Usuarios"])))
                {

                    Response.Redirect("../Login/Login.aspx", false);
                }


                ddlMateria.DataSource = matNeg.listMateria();
                ddlMateria.DataValueField = "idMateria";
                ddlMateria.DataTextField = "nombremateria";
                ddlMateria.DataBind();
                ddlMateria.Items.Insert(0, new ListItem("Seleccione una Materia"));

                ddlCuatrimestre.DataSource = cuaNeg.listaCuatrimestres();
                ddlCuatrimestre.DataValueField = "IdCuatrimestre";
                ddlCuatrimestre.DataTextField = "nombreCuatrimestre";
                ddlCuatrimestre.DataBind();
                ddlCuatrimestre.Items.Insert(0, new ListItem("Seleccione un Cuatrimestre"));


                ddlDocente.DataSource = docNeg.listadocenteConcatenado();
                ddlDocente.DataValueField = "Iddocente";
                ddlDocente.DataTextField = "Nombre";
                ddlDocente.DataBind();
                ddlDocente.Items.Insert(0, new ListItem("Seleccione un Docente"));






                chkAlumnos.DataSource = alumNeg.listaAlumnoConcatenado();
                chkAlumnos.DataValueField = "Idalumno";
                chkAlumnos.DataTextField = "Nombre";
                chkAlumnos.DataBind();
            }
        }



        protected void btnConfrimar_Click(object sender, EventArgs e)
        {
            Dominio.Cursos cur= new Dominio.Cursos();
            List<Alumno> lista = new List<Alumno>();
            for (int i = 0; i < chkAlumnos.Items.Count; i++)
            {
                //chkAlumnos.Items[i].Selected
                if (chkAlumnos.Items[i].Selected)
                {
                    Alumno alu = new Alumno();
                    alu.Nombre = chkAlumnos.Items[i].Text;
                    alu.Idalumno = int.Parse(chkAlumnos.Items[i].Value);
                    lista.Add(alu);
                }
            }

            cur.IdCuatrimestre = int.Parse(ddlCuatrimestre.SelectedItem.Value);
            cur.IdDocente = int.Parse(ddlDocente.SelectedItem.Value);
            cur.IdMateria = int.Parse(ddlMateria.SelectedItem.Value);
            cur.Anio = int.Parse(txtAnio.Text);

            curNeg.agregarCurso(cur, lista);


            Response.Redirect("ListadoCursos.aspx",false);
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
           
        }
    }
}