﻿using System;
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
        protected void Page_Load(object sender, EventArgs e)
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

        }
    }
}