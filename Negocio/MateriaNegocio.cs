using System;
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
                conex_materia.setearConsulta("SELECT ID_MATERIA, NOMBRE_MATERIA, CARGA_HORARIA_MINIMA, CARRERA, AÑO_CURSO, CUATRIMESTRE, ESTADO FROM MATERIAS WHERE ESTADO != 0");
                conex_materia.ejecutarLectura();

                while (conex_materia.Lector.Read())
                {
                    Materias aux1 = new Materias();
                    aux1.id_materia = (string)conex_materia.Lector["ID_MATERIA"];
                    aux1.nombre_materia = (string)conex_materia.Lector["NOMBRE_MATERIA"];
                    aux1.carga_horaria_minima = (int)conex_materia.Lector["CARGA_HORARIA_MINIMA"];
                    aux1.carrera = (string)conex_materia.Lector["CARRERA"];
                    aux1.año_curso = (int)conex_materia.Lector["AÑO_CURSO"];
                    aux1.cuatrimestre = (int)conex_materia.Lector["CUATRIMESTRE"];
                    aux1.estado = (bool)conex_materia.Lector["ESTADO"];

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
                string nuevaMateria = " values( '" + agregoMateria.id_materia + "', '" + agregoMateria.nombre_materia + "', '" + agregoMateria.carga_horaria_minima + "', '" + agregoMateria.carrera + "', '" + agregoMateria.año_curso + "', '" + agregoMateria.cuatrimestre + "')";
                conex_Materia.setearConsulta("INSERT INTO MATERIAS(ID_MATERIA, NOMBRE_MATERIA, CARGA_HORARIA_MINIMA, CARRERA, AÑO_CURSO, CUATRIMESTRE)" + nuevaMateria);

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

        public void Eliminar(string id)
        {
            materia = new AccesoDatos();

            try
            {
                materia.setearConsulta("UPDATE MATERIAS SET ESTADO = 0 WHERE ID_MATERIA = " + id);
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

        public Materias UnaMateria(string id_Materia)
        {
            AccesoDatos unamateria = new AccesoDatos();

            try
            {
                //unacarrera.setearParametro("@id_carrera", id_Carrera);
                unamateria.setearConsulta("SELECT ID_MATERIA, NOMBRE_MATERIA, CARGA_HORARIA_MINIMA, CARRERA, AÑO_CURSO, CUARTRIMESTRE, ESTADO FROM MATERIAS WHERE ID_MATERIA =" + id_Materia);
                unamateria.ejecutarLectura();
                unamateria.Lector.Read();

                Materias aux2 = new Materias();
                aux2.id_materia = (string)unamateria.Lector["ID_MATERIA"];
                aux2.nombre_materia = (string)unamateria.Lector["NOMBRE_MATERIA"];
                aux2.carga_horaria_minima = (int)unamateria.Lector["CARGA_HORARIA_MINIMA"];
                aux2.carrera = (string)unamateria.Lector["CARRERA"];
                aux2.año_curso = (int)unamateria.Lector["AÑO_CURSO"];
                aux2.cuatrimestre = (int)unamateria.Lector["CUARTRIMESTRE"];
                aux2.estado = (bool)unamateria.Lector["ESTADO"];

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
                conex_Materia.setearConsulta("UPDATE CARRERAS SET NOMBRE_MATERIA = @nombremateria, CARGA_HORARIA_MINIMA = @cargahorariaminima, CARRERA = @carrera, AÑO_CURSO = @añocurso, CUARTRIMESTRE = @cuatrimestre, ESTADO = @estado FROM CARRERAS WHERE ID_MATERIA = @idmateria");
                conex_Materia.setearParametro("@idmateria", modifMateria);
                conex_Materia.setearParametro("@nombremateria", modifMateria.nombre_materia);
                conex_Materia.setearParametro("@cargahorariaminima", modifMateria.carga_horaria_minima);
                conex_Materia.setearParametro("@carrera", modifMateria.carrera);
                conex_Materia.setearParametro("@añocurso", modifMateria.año_curso);
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
