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
    public partial class CargarNota : System.Web.UI.Page
    {
        NotaNegocio notaNeg = new NotaNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Request.QueryString["idNota"] != null)
                {
                    int idNota = int.Parse(Request.QueryString["idNota"].ToString());
                    Session["idNota"] = idNota;

                    Nota nota = new Nota();

                    nota = notaNeg.traerUnaNota(idNota);
                    Session["idNota"] = nota.id;
                    int idEstado = nota.EstadoAcademico;

                    string nombre = nota.alu.Nombre.ToString() + " " + nota.alu.Apellido.ToString();

                    lblAlumno.Text= nombre;
                    txtNota1.Text = nota.Nota1.ToString();
                    txtNota2.Text = nota.Nota2.ToString();
                    txtNotFinal.Text = nota.NotaFinal.ToString();

                    ddlEstado.DataSource = notaNeg.listaEstado();
                    ddlEstado.DataValueField = "id";
                    ddlEstado.DataTextField = "Nombre";
                    ddlEstado.SelectedValue = idEstado.ToString();
                    ddlEstado.DataBind();
                    
                }
            }

        }

        protected void btnCargarNota_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Session["idNota"].ToString());

            Nota nota = new Nota();
            nota.id = id;
            nota.Nota1=decimal.Parse(txtNota1.Text);
            nota.Nota2 = decimal.Parse(txtNota2.Text);
            nota.NotaFinal = decimal.Parse(txtNotFinal.Text);
            nota.EstadoAcademico = int.Parse(ddlEstado.SelectedItem.Value);

            notaNeg.agregarNota(nota);


        }
    }
}