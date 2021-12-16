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
    public partial class Calificaciones : System.Web.UI.Page
    {
        NotaNegocio notNeg = new NotaNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["idNota"].ToString()) ;


            repAlum.DataSource = notNeg.listaNotas(id);
            repAlum.DataBind();
        }
    }
}