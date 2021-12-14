using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;

namespace Negocio
{
    public class CursoNegocio
    {


        private AccesoDatos cursoConexion;

        public void agregarCurso(Cursos curso, List<Alumno> lista)
        {
            cursoConexion = new AccesoDatos();

            try
            {
                cursoConexion.setearParametro("@idmateria", curso.IdMateria);
                cursoConexion.setearParametro("@iddocente", curso.IdDocente);
                cursoConexion.setearParametro("@idcuatrimestre", curso.IdCuatrimestre);
                cursoConexion.setearParametro("@anio", curso.Anio);

                cursoConexion.setearConsulta("INSERT INTO MateriasxDocente (IdMateria, IdDocente,IdCuatrimestre,Anio,Estado) VALUES (@idmateria,@iddocente,@idcuatrimestre,@anio,1) SELECT SCOPE_IDENTITY()  ");

                //SELECT SCOPE_IDENTITY() retorna la id 

                int idMateriaDocente = cursoConexion.returnPK();

                foreach (Alumno alu in lista)
                {
                    cursoConexion.cerrarConexion();
                    cursoConexion.setearConsulta("INSERT INTO AlumnosxMateria (IdMateriaDocente,IdAlumno) VALUES (" + idMateriaDocente + ", " + alu.Idalumno + ")");
                    cursoConexion.ejectutarAccion();
                }



            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cursoConexion.cerrarConexion();
            }

        }


        public List<Cursos> listadoCursos()
        {
            List<Cursos> listaCurso = new List<Cursos>();
            cursoConexion = new AccesoDatos();

            try
            {
                cursoConexion.setearConsulta("SELECT dc.Apellido Apellido,dc.Nombre Nombre,dc.Cuil Cuil,mat.NombreMateria Materia,cua.Nombre Cuatrimestre,mtd.Anio anio from MateriasxDocente mtd " +
                                            "INNER JOIN Docentes dc on dc.IdDocente = mtd.IdDocente " +
                                            "INNER JOIN Cuatrimestres cua on cua.IdCuatrimestre = mtd.IdCuatrimestre " +
                                            "INNER JOIN Materias mat on mat.IdMateria = mtd.IdMateria " +
                                            "WHERE mtd.Estado = 1");
                cursoConexion.ejecutarLectura();

                while (cursoConexion.Lector.Read())
                {
                    Cursos aux1 = new Cursos();
                    aux1.apellidoDocente = (string)cursoConexion.Lector["Apellido"];
                    aux1.nombreDocente = (string)cursoConexion.Lector["Nombre"];
                    aux1.cuilDocente = (string)cursoConexion.Lector["Cuil"];
                    aux1.Materia = (string)cursoConexion.Lector["Materia"];
                    aux1.cuatrimestre = (string)cursoConexion.Lector["Cuatrimestre"];
                    aux1.Anio = (int)cursoConexion.Lector["anio"];


                    listaCurso.Add(aux1);
                }
                return listaCurso;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cursoConexion.cerrarConexion();
            }
        }
    }
}
