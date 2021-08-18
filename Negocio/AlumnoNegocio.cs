﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;

namespace Negocio
{
    public class AlumnoNegocio
    {
        private AccesoDatos alumno;

        public List<Alumno> listaAlumno()
        {
            List<Alumno> listado = new List<Alumno>();
            AccesoDatos alumno = new AccesoDatos();
            try
            {
                alumno.setearConsulta("SELECT ID_ALUMNO, CUIL, APELLIDO_NOMBRE, NACIONALIDAD, FECHA_NAC, MAIL, DOMICILIO, LOCALIDA_PCIA, USUARIO, ESTADO FROM ALUMNOS");
                alumno.ejecutarLectura();

                while (alumno.Lector.Read())
                {
                    Alumno aux = new Alumno();
                    aux.Idalumno = (int)alumno.Lector["ID_ALUMNO"];
                    aux.Cuil = (string)alumno.Lector["CUIL"];
                    aux.ApellidoNombre = (string)alumno.Lector["APELLIDO_NOMBRE"];
                    aux.Nacionalidad = (string)alumno.Lector["NACIONALIDAD"];
                    aux.Fecha_Nac = (DateTime)alumno.Lector["FECHA_NAC"];
                    aux.Mail = (string)alumno.Lector["MAIL"];
                    aux.Domicilio = (string)alumno.Lector["DOMICILIO"];
                    aux.Localidad_Prov = (string)alumno.Lector["LOCALIDA_PCIA"];
                    aux.Usuario = (string)alumno.Lector["USUARIO"];
                    aux.Estado = (int)alumno.Lector["ESTADO"];

                    listado.Add(aux);
                }
                return listado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                alumno.cerrarConexion();
            }
        }

        public void eliminar(Alumno id)
        {
            alumno = new AccesoDatos();
            try
            {
                alumno.setearConsulta("UPDATE ALUMNOS SET ESTADO = 0 WHERE ID_ALUMNO = " + id);
                alumno.ejectutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                alumno.cerrarConexion();
                alumno = null;
            }
        }

        public void agregar(Alumno agregoAlumno)
        {
            AccesoDatos accesoAlumno = new AccesoDatos();
            try
            {
                string valores = "values( '" + agregoAlumno.Cuil + "', '" + agregoAlumno.ApellidoNombre + "', '" + agregoAlumno.Nacionalidad + "', '" + agregoAlumno.Fecha_Nac + "', '" + agregoAlumno.Mail + "', '" + agregoAlumno.Domicilio + "', '" + agregoAlumno.Localidad_Prov +  "')";
                accesoAlumno.setearConsulta("INSERT INTO ALUMNOS(CUIL, APELLIDO_NOMBRE, NACIONALIDAD, FECHA_NAC, MAIL, DOMICILIO, LOCALIDA_PCIA)" + valores);

                accesoAlumno.ejectutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoAlumno.cerrarConexion();
                alumno = null;
            }
        }

        public void modificar(Alumno modificarAlumno)
        {
            AccesoDatos accesoModificar = new AccesoDatos();
            try
            {
                accesoModificar.setearConsulta("UPDATE ALUMNOS SET CUIL=@cuil, APELLIDO_NOMBRE=@apellido_nombre, NACIONALIDAD=@nacionalidad, FECHA_NAC=@fecha_nac, MAIL=@mail, DOMICILIO=@domicilio, LOCALIDA_PCIA=@localidad_pcia, USUARIO=@usuario, ESTADO=@estado  WHERE ID_ALUMNO=@id_alumno");
                accesoModificar.setearParametro("@cuil", modificarAlumno.Cuil);
                accesoModificar.setearParametro("@apellido_nombre", modificarAlumno.ApellidoNombre);
                accesoModificar.setearParametro("@nacionalidad", modificarAlumno.Nacionalidad);
                accesoModificar.setearParametro("@fecha_nac", modificarAlumno.Fecha_Nac);
                accesoModificar.setearParametro("@mail", modificarAlumno.Mail);
                accesoModificar.setearParametro("@domicilio", modificarAlumno.Domicilio);
                accesoModificar.setearParametro("@localidad_prov", modificarAlumno.Localidad_Prov);
                accesoModificar.setearParametro("@usuario", modificarAlumno.Usuario);
                accesoModificar.setearParametro("@estado", modificarAlumno.Estado);

                accesoModificar.ejectutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoModificar.cerrarConexion();
            }
        }

        public Alumno Un_alumno(int id_alumno)
        {
            AccesoDatos UnAlumno = new AccesoDatos();
            try
            {
                UnAlumno.setearParametro("@idAlumno", id_alumno);
                UnAlumno.setearConsulta("SELECT  ID_ALUMNO, CUIL, APELLIDO_NOMBRE, NACIONALIDAD, FECHA_NAC, MAIL, DOMICILIO, LOCALIDA_PCIA, USUARIO, ESTADO FROM ALUMNOS WHERE ID_ALUMNO = " + id_alumno);
                UnAlumno.ejecutarLectura();
                UnAlumno.Lector.Read();

                Alumno aux = new Alumno();
                aux.Idalumno = (int)UnAlumno.Lector["ID_ALUMNO"];
                aux.Cuil = (string)UnAlumno.Lector["CUIL"];
                aux.ApellidoNombre = (string)UnAlumno.Lector["APELLIDO_NOMBRE"];
                aux.Nacionalidad = (string)UnAlumno.Lector["FECHA_NAC"];
                aux.Mail = (string)UnAlumno.Lector["MAIL"];
                aux.Domicilio = (string)UnAlumno.Lector["DOMICILIO"];
                aux.Localidad_Prov = (string)UnAlumno.Lector["LOCALIDAD_PCIA"];
                aux.Usuario = (string)UnAlumno.Lector["USUARIO"];
                aux.Estado = (int)UnAlumno.Lector["ESTADO"];

                return aux;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                UnAlumno.cerrarConexion();
            }
        }

        //public List<Alumno> modificarAlumno(int idalumno)
        //{
        //    List<Alumno> modificarAlumno = new List<Alumno>();
        //    AccesoDatos modifAlumno = new AccesoDatos();

        //    try
        //    {
        //        modifAlumno.setearConsulta("" + idalumno)
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

    }
}
