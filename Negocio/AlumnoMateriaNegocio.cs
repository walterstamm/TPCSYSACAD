using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class AlumnoMateriaNegocio
    {
        private AccesoDatos alumnomateria;

        public List<Alumno_Materia> lista_alumno_Materias()
        {
            List<Alumno_Materia> lis_alumno_Materias = new List<Alumno_Materia>();
            alumnomateria = new AccesoDatos();

            try
            {
                alumnomateria.setearConsulta("SELECT ID, IDALUMNO, IDMATERIADOCENTE, ISNULL(EVENTO1, 0) AS EVENTO1, ISNULL(EVENTO2, 0) AS EVENTO2, ISNULL(REC1, 0) AS REC1, ISNULL(REC2, 0) AS REC2, ISNULL(NOTAFINAL, 0) AS NOTAFINAL, ISNULL(RESULTADOFINAL, 'S/N') AS RESULTADOFINAL FROM ALUMNOSXMATERIA");
                alumnomateria.ejecutarLectura();

                while (alumnomateria.Lector.Read())
                {
                    Alumno_Materia aux1 = new Alumno_Materia();
                    aux1.id = (int)alumnomateria.Lector["ID"];
                    aux1.idalumno = (int)alumnomateria.Lector["IDALUMNO"];
                    aux1.idmateriadocente = (int)alumnomateria.Lector["IDMATERIADOCENTE"];
                    aux1.evento1 = (int)alumnomateria.Lector["EVENTO1"];
                    aux1.evento2 = (int)alumnomateria.Lector["EVENTO2"];
                    aux1.rec1 = (int)alumnomateria.Lector["REC1"];
                    aux1.rec2 = (int)alumnomateria.Lector["REC2"];
                    aux1.notafinal = (decimal)alumnomateria.Lector["NOTAFINAL"];
                    aux1.resultadofinal = (string)alumnomateria.Lector["RESULTADOFINAL"];

                    lis_alumno_Materias.Add(aux1);

                }
                return lis_alumno_Materias;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                alumnomateria.cerrarConexion();
            }

        }

        public Alumno_Materia un_alumno_Materia(int idAlMat)
        {
            AccesoDatos un_AlumMateria = new AccesoDatos();

            try
            {
                un_AlumMateria.setearParametro("@idAlxMat", idAlMat);
                un_AlumMateria.setearConsulta("SELECT ID, IDALUMNO, IDMATERIADOCENTE, ISNULL(EVENTO1, 0) AS EVENTO1, ISNULL(EVENTO2, 0) AS EVENTO2, ISNULL(REC1, 0) AS REC1, ISNULL(REC2, 0) AS REC2, ISNULL(NOTAFINAL, 0) AS NOTAFINAL, ISNULL(RESULTADOFINAL, 'S/N') AS RESULTADOFINAL FROM ALUMNOSXMATERIA WHERE ID =" + idAlMat);
                un_AlumMateria.ejecutarLectura();
                un_AlumMateria.Lector.Read();


                Alumno_Materia aux2 = new Alumno_Materia();
                aux2.id = (int)un_AlumMateria.Lector["ID"];
                aux2.idalumno = (int)un_AlumMateria.Lector["IDALUMNO"];
                aux2.idmateriadocente = (int)un_AlumMateria.Lector["IDMATERIADOCENTE"];
                aux2.evento1 = (int)un_AlumMateria.Lector["EVENTO1"];
                aux2.evento2 = (int)un_AlumMateria.Lector["EVENTO2"];
                aux2.rec1 = (int)un_AlumMateria.Lector["REC1"];
                aux2.rec2 = (int)un_AlumMateria.Lector["REC2"];
                aux2.notafinal = (decimal)un_AlumMateria.Lector["NOTAFINAL"];
                aux2.resultadofinal = (string)un_AlumMateria.Lector["RESULTADOFINAL"];

                return aux2;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                un_AlumMateria.cerrarConexion();
            }
        }

        public void modificar(Alumno_Materia AgreNota)
        {
            AccesoDatos conex_AlumMat = new AccesoDatos();

            try
            {
                conex_AlumMat.setearConsulta(" UPDATE ALUMNOSXMATERIA SET EVENTO1 = @EVENTO1, EVENTO2 = @EVENTO2, REC1 = @REC1, REC2 = @REC2, NOTAFINAL = @NOTAFINAL, RESULTADOFINAL = @RESULTADOFINAL WHERE ID = @ID");

                conex_AlumMat.setearParametro("@EVENTO1", AgreNota.evento1);
                conex_AlumMat.setearParametro("@EVENTO2", AgreNota.evento2);
                conex_AlumMat.setearParametro("@REC1", AgreNota.rec1);
                conex_AlumMat.setearParametro("@REC2", AgreNota.rec2);
                conex_AlumMat.setearParametro("@NOTAFINAL", AgreNota.notafinal);
                conex_AlumMat.setearParametro("@RESULTADOFINAL", AgreNota.resultadofinal);

                conex_AlumMat.ejectutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conex_AlumMat.cerrarConexion();
            }

        }
           
    }
}

