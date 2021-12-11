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
    public partial class Alum_Carr_Materias : System.Web.UI.Page
    {
        public List<Carreras> lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            Util.id = 2;
            CarreraNegocio carreraNegocio = new CarreraNegocio();
            try
            {
                //Rep_Carr.DataSource = carreraNegocio.Carrera_Alumno();
                //Rep_Carr.DataBind();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}