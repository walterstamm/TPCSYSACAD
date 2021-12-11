using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CarreraNegocio
    {
        private AccesoDatos carrera;
        public List<Carreras> listaCarrera()
        {
            List<Carreras> lis_carrera = new List<Carreras>();
            AccesoDatos carrera = new AccesoDatos();

            try
            {
              

                carrera.setearConsulta("SELECT ID, NOMBRE, NUMEROPLAN, NUMEROHABILITANTE, ESTADO FROM CARRERAS WHERE ESTADO = 1");
                carrera.ejecutarLectura();
                while (carrera.Lector.Read())
                {
                    Carreras aux1 = new Carreras();
                    aux1.id = (int)carrera.Lector["ID"];
                    aux1.nombre = (string)carrera.Lector["NOMBRE"];
                    aux1.numeroplan = (string)carrera.Lector["NUMEROPLAN"];
                    aux1.numerohabilitante = (string)carrera.Lector["NUMEROHABILITANTE"];
                    aux1.estado = (int)carrera.Lector["ESTADO"];

                    lis_carrera.Add(aux1);
                }
                return lis_carrera;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                carrera.cerrarConexion();
            }
        }

        public void agregar(Carreras agregoCarrera)
        {
            AccesoDatos conex_Carrera = new AccesoDatos();

            try
            {
                string nuevaCarrera = " values( '" + agregoCarrera.nombre + "', '" + agregoCarrera.numeroplan + "', '" + agregoCarrera.numerohabilitante + "', '" + agregoCarrera.estado + "')";
                conex_Carrera.setearConsulta("INSERT INTO CARRERAS( NOMBRE, NUMEROPLAN, NUMEROHABILITANTE, ESTADO)" + nuevaCarrera);

                conex_Carrera.ejectutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conex_Carrera.cerrarConexion();
                carrera = null;
            }
        }
        
        public void Eliminar(int id)
        {
            carrera = new AccesoDatos();

            try
            {
                carrera.setearConsulta("UPDATE CARRERAS SET ESTADO = 0 WHERE ID = " + id);
                carrera.ejectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                carrera.cerrarConexion();
                carrera = null;
            }
        }

        public Carreras UnaCarrera(int id_Carrera)
        {
            AccesoDatos unacarrera = new AccesoDatos();

            try
            {

                unacarrera.setearConsulta("SELECT ID, NOMBRE, NUMEROPLAN, NUMEROHABILITANTE, ESTADO FROM CARRERAS WHERE ID = " + id_Carrera);
                unacarrera.ejecutarLectura();
                unacarrera.Lector.Read();

                Carreras aux2 = new Carreras();
                aux2.id = (int)unacarrera.Lector["ID"];
                aux2.nombre = (string)unacarrera.Lector["NOMBRE"];
                aux2.numeroplan = (string)unacarrera.Lector["NUMEROPLAN"];
                aux2.numerohabilitante = (string)unacarrera.Lector["NUMEROHABILITANTE"];
                aux2.estado = (int)unacarrera.Lector["ESTADO"];

                return aux2;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                unacarrera.cerrarConexion();
            }
        }

        public Carreras Carrera_idUsuario()
        {
            AccesoDatos CarreraAlumno = new AccesoDatos();

            try
            {

                CarreraAlumno.setearConsulta("select i.ID_INSCRIPCION_CARRERA, c.ID_CARRERA, c.NOMBRE_CARRERA from insc_alum_carrera i RIGHT join alumnos a on i.ALUMNO = a.ID_ALUMNO inner join carreras c on i.CARRERA = c.ID_CARRERA inner join USUARIOS u on a.ID_ALUMNO = u.ID_USUARIO where u.ID_USUARIO = " + Util.id);
                CarreraAlumno.ejecutarLectura();
                CarreraAlumno.Lector.Read();

                Carreras usuario = new Carreras();
                usuario.id = (int)CarreraAlumno.Lector["ID"];
                usuario.nombre = (string)CarreraAlumno.Lector["NOMBRE_CARRERA"];

                return usuario;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CarreraAlumno.cerrarConexion();
            }
        }

        public void Modificar(Carreras modifCarrera)
        {
            AccesoDatos conex_Carrera = new AccesoDatos();

            try
            {
                conex_Carrera.setearConsulta("UPDATE CARRERAS SET NOMBRE = @nombre_carrera, NUMEROPLAN = @numeroplan, NUMEROHABILITANTE = @numerohabilitante, ESTADO = @estado FROM CARRERAS WHERE ID = @idcarrera");
                conex_Carrera.setearParametro("@idcarrera", modifCarrera.id );
                conex_Carrera.setearParametro("@nombre_carrera", modifCarrera.nombre);
                conex_Carrera.setearParametro("@numeroplan", modifCarrera.numeroplan);
                conex_Carrera.setearParametro("@numerohabilitante", modifCarrera.numerohabilitante);
                conex_Carrera.setearParametro("@estado", modifCarrera.estado);

                conex_Carrera.ejectutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conex_Carrera.cerrarConexion();
            }
        }

        public List<Carreras> listarConSP()
        {
            List<Carreras> lista_carrera = new List<Carreras>();
            Carreras aux;
            AccesoDatos conex_datos = new AccesoDatos();
            try
            {
                conex_datos.setearSP("spListar");
                conex_datos.ejecutarLectura();
                while (conex_datos.Lector.Read())
                {
                    aux = new Carreras();
                    aux.id = int.Parse(conex_datos.Lector.GetString(0));
                    aux.nombre = conex_datos.Lector.GetString(1);
                    aux.numeroplan = (conex_datos.Lector.GetString(2));
                    aux.numerohabilitante = (conex_datos.Lector.GetString(3));
                    aux.estado = conex_datos.Lector.GetInt32(4);

                    lista_carrera.Add(aux);
                }

                return lista_carrera;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conex_datos.cerrarConexion();
                conex_datos = null;
            }

        }


    }
}
