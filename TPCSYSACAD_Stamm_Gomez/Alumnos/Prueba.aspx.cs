﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPCSYSACAD_Stamm_Gomez
{
    public partial class Prueba : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarreraNegocio conex_dllDinamico = new CarreraNegocio();

            try
            {
                if (!IsPostBack)
                {
                    ddl_carreras.DataSource = conex_dllDinamico.listaCarrera();
                    ddl_carreras.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
            }

        }

        protected void ddl_carreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID_CARRERA;
            ID_CARRERA = (ddl_carreras.SelectedItem.Value.ToString());

            //if(ID_CARRERA != null)
            //{
            //    Session[""];
            //}
            //string valor;
            //valor = 

        }
    }
}