﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MateriaNegocio
    {
        private AccesoDatos materia;
        public List<Materias> listMateria()
        {
            List<Materias> lis_materia = new List<Materias>();
            AccesoDatos conex_materia = new AccesoDatos();

            try
            {
                conex_materia.setearConsulta("SELECT IDMATERIA, NOMBREMATERIA, IDCARRERA, ANIO, CUATRIMESTRE, ESTADO FROM MATERIAS WHERE ESTADO = 1");
                conex_materia.ejecutarLectura();

                while (conex_materia.Lector.Read())
                {
                    Materias aux1 = new Materias();
                    aux1.idmateria = (int)conex_materia.Lector["IDMATERIA"];
                    aux1.nombremateria = (string)conex_materia.Lector["NOMBREMATERIA"];
                    //aux1.carga_horaria_minima = (int)conex_materia.Lector["CARGA_HORARIA_MINIMA"];
                    aux1.idcarrera = (int)conex_materia.Lector["IDCARRERA"];
                    aux1.anio = (byte)conex_materia.Lector["ANIO"];
                    aux1.cuatrimestre = (byte)conex_materia.Lector["CUATRIMESTRE"];
                    aux1.estado = (string)conex_materia.Lector["ESTADO"];

                    lis_materia.Add(aux1);

                }
                return lis_materia;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void agregar(Materias agregoMateria)
        {
            AccesoDatos conex_Materia = new AccesoDatos();

            try
            {
                string nuevaMateria = " values( '" + agregoMateria.nombremateria + "', '" + agregoMateria.idcarrera + "', '" + agregoMateria.anio + "', '" + agregoMateria.cuatrimestre + "', 1)";     
                conex_Materia.setearConsulta("INSERT INTO MATERIAS(NOMBREMATERIA, IDCARRERA, ANIO, CUATRIMESTRE, ESTADO)" + nuevaMateria);

                conex_Materia.ejectutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conex_Materia.cerrarConexion();
                materia = null;
            }


        }

        public void Eliminar(int id)
        {
            materia = new AccesoDatos();

            try
            {
                materia.setearConsulta("UPDATE MATERIAS SET ESTADO = 0 WHERE IDMATERIA = " + id);
                materia.ejectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                materia.cerrarConexion();
                materia = null;
            }
        }

        public Materias UnaMateria(int idMateria)
        {
            AccesoDatos unamateria = new AccesoDatos();

            try
            {
                //unacarrera.setearParametro("@id_carrera", id_Carrera);
                unamateria.setearConsulta("SELECT IDMATERIA, NOMBREMATERIA, IDCARRERA, ANIO, CUATRIMESTRE, ESTADO FROM MATERIAS WHERE IDMATERIA =" + idMateria);
                unamateria.ejecutarLectura();
                unamateria.Lector.Read();

                Materias aux2 = new Materias();
                aux2.idmateria = (int)unamateria.Lector["IDMATERIA"];
                aux2.nombremateria = (string)unamateria.Lector["NOMBREMATERIA"];
                //aux2.carga_horaria_minima = (int)unamateria.Lector["CARGA_HORARIA_MINIMA"];
                aux2.idcarrera = (int)unamateria.Lector["IDCARRERA"];
                aux2.anio = (byte)unamateria.Lector["ANIO"];
                aux2.cuatrimestre = (byte)unamateria.Lector["CUATRIMESTRE"];
                aux2.estado = (string)unamateria.Lector["ESTADO"];

                return aux2;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                unamateria.cerrarConexion();
            }
        }


        public void Modificar(Materias modifMateria)
        {
            AccesoDatos conex_Materia = new AccesoDatos();

            try
            {
                conex_Materia.setearConsulta("UPDATE CARRERAS SET NOMBREMATERIA = @nombremateria, IDCARRERA = @carrera, ANIO = @añocurso, CUARTRIMESTRE = @cuatrimestre, ESTADO = @estado FROM CARRERAS WHERE IDMATERIA = @idmateria");
                conex_Materia.setearParametro("@idmateria", modifMateria.idmateria);
                conex_Materia.setearParametro("@nombremateria", modifMateria.nombremateria);
                //conex_Materia.setearParametro("@cargahorariaminima", modifMateria.carga_horaria_minima);
                conex_Materia.setearParametro("@carrera", modifMateria.idcarrera);
                conex_Materia.setearParametro("@añocurso", modifMateria.anio);
                conex_Materia.setearParametro("@cuatrimestre", modifMateria.cuatrimestre);
                conex_Materia.setearParametro("@estado", modifMateria.estado);

                conex_Materia.ejectutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conex_Materia.cerrarConexion();
            }
        }
    }
}
