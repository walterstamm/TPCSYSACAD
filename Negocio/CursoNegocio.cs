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

        public void agregarCurso(Cursos curso,List<Alumno>lista)
        {
            cursoConexion = new AccesoDatos();

            try
            {
                cursoConexion.setearParametro("@idmateria", curso.IdMateria);
                cursoConexion.setearParametro("@iddocente",curso.IdDocente);
                cursoConexion.setearParametro("idcuatrimestre", curso.IdCuatrimestre);
                cursoConexion.setearParametro("@anio", curso.Anio);

                cursoConexion.setearConsulta("INSERT INTO MateriasxDocente (IdMateria, IdDocente,IdCuatrimestre,Anio,Estado) VALUES (@idmateria,@iddocente,idcuatrimestre,@anio,1) SELECT SCOPE_IDENTITY() ");

              

                int idMateriaDocente = cursoConexion.returnPK();


                cursoConexion.setearParametro("@idmateriadocente",idMateriaDocente );
                foreach (Alumno alu in lista)
                {
                    cursoConexion.setearParametro("@idAlum", alu.Idalumno);

                    cursoConexion.setearConsulta("INSERT INTO AlumnosxMateria (IdMateriaDocente,IdAlumno) VALUES (@idmateriadocente,@idAlum)");
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


    }
}
