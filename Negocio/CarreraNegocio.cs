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
                carrera.setearConsulta("SELECT ID_CARRERA, NOMBRE_CARRERA, PLAN_AÑO, DOC_HABILITANTE, ESTADO FROM CARRERAS WHERE ESTADO !=0");
                carrera.ejecutarLectura();
                while (carrera.Lector.Read())
                {
                    Carreras aux1 = new Carreras();
                    aux1.id_carrera = (string)carrera.Lector["ID_CARRERA"];
                    aux1.nombre_carrera = (string)carrera.Lector["NOMBRE_CARRERA"];
                    aux1.plan_año = (string)carrera.Lector["PLAN_AÑO"];
                    aux1.doc_habilitante = (string)carrera.Lector["DOC_HABILITANTE"];
                    aux1.estado = (bool)carrera.Lector["ESTADO"];

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
            AccesoDatos accesoCarrera = new AccesoDatos();

            try
            {
                string nuevaCarrera = " values( '" + agregoCarrera.id_carrera + "', '" + agregoCarrera.nombre_carrera + "', '" + agregoCarrera.plan_año + "', '" + agregoCarrera.doc_habilitante + "', '" + agregoCarrera.estado + "')";
                accesoCarrera.setearConsulta("INSERT INTO CARRERAS(ID_CARRERA, NOMBRE_CARRERA, PLAN_AÑO, DOC_HABILITANTE, ESTADO)" + nuevaCarrera);

                accesoCarrera.ejectutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoCarrera.cerrarConexion();
                carrera = null;
            }
        }
        
        public void Eliminar(string id)
        {
            carrera = new AccesoDatos();

            try
            {
                carrera.setearConsulta("update carreras set estado = 1 where id_carrera = " + id);
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

        public Carreras UnaCarrera(string id_Carrera)
        {
            AccesoDatos unacarrera = new AccesoDatos();

            try
            {
                //unacarrera.setearParametro("@id_carrera", id_Carrera);
                unacarrera.setearConsulta("SELECT ID_CARRERA, NOMBRE_CARRERA, PLAN_AÑO, DOC_HABILITANTE, ESTADO FROM CARRERAS WHERE ID_CARRERA = " + id_Carrera);
                unacarrera.ejecutarLectura();
                unacarrera.Lector.Read();

                Carreras aux2 = new Carreras();
                aux2.id_carrera = (string)unacarrera.Lector["ID_CARRERA"];
                aux2.nombre_carrera = (string)unacarrera.Lector["NOMBRE_CARRERA"];
                aux2.plan_año = (string)unacarrera.Lector["PLAN_AÑO"];
                aux2.doc_habilitante = (string)unacarrera.Lector["DOC_HABILITANTE"];
                aux2.estado = (bool)unacarrera.Lector["ESTADO"];

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
                //unacarrera.setearParametro("@id_carrera", id_Carrera);
                CarreraAlumno.setearConsulta("select i.ID_INSCRIPCION_CARRERA, c.ID_CARRERA, c.NOMBRE_CARRERA from insc_alum_carrera i RIGHT join alumnos a on i.ALUMNO = a.ID_ALUMNO inner join carreras c on i.CARRERA = c.ID_CARRERA inner join USUARIOS u on a.ID_ALUMNO = u.ID_USUARIO where u.ID_USUARIO = " + Util.id);
                CarreraAlumno.ejecutarLectura();
                CarreraAlumno.Lector.Read();

                Carreras usuario = new Carreras();
                usuario.id_carrera = (string)CarreraAlumno.Lector["ID_CARRERA"];
                usuario.nombre_carrera = (string)CarreraAlumno.Lector["NOMBRE_CARRERA"];

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
                conex_Carrera.setearConsulta("UPDATE CARRERAS SET NOMBRE_CARRERA = @nombre_carrera, PLAN_AÑO = @planaño, DOC_HABILITANTE = @dochab, ESTADO = @estado FROM CARRERAS WHERE ID_CARRERA = @idcarrera");
                conex_Carrera.setearParametro("@idcarrera", modifCarrera );
                conex_Carrera.setearParametro("@nombre_carrera", modifCarrera.nombre_carrera);
                conex_Carrera.setearParametro("@planaño", modifCarrera.plan_año);
                conex_Carrera.setearParametro("@dochab", modifCarrera.doc_habilitante);
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
                    aux.id_carrera = conex_datos.Lector.GetString(0);
                    aux.nombre_carrera = conex_datos.Lector.GetString(1);
                    aux.plan_año = conex_datos.Lector.GetString(2);
                    aux.doc_habilitante = conex_datos.Lector.GetString(3);
                    aux.estado = conex_datos.Lector.GetBoolean(4);

                    //aux.Tipo = new Tipo();
                    //aux.Tipo.Id = (int)conex_datos.Lector["idTipo"];
                    //aux.Tipo.Descripcion = (string)conex_datos.Lector["Descripcion"];
                    //aux.UrlImagen = (string)conex_datos.Lector["UrlImagen"];
                    //if (!Convert.IsDBNull(conex_datos.Lector["idEvol"]))
                    //{
                    //    aux.Evolucion = new Pokemon();
                    //    aux.Evolucion.Id = (int)datos.Lector["idEvol"];
                    //    aux.Evolucion.Nombre = datos.Lector["nomEvol"].ToString();
                    //}

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
