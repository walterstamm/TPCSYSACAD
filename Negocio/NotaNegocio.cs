using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NotaNegocio
    {
        AccesoDatos notaDatos;

        public List<Nota> listaNotas(int idMateriaDocente)
        {

            List<Nota> lista = new List<Nota>();
            notaDatos = new AccesoDatos();

            try
            {

                notaDatos.setearParametro("@idMat",idMateriaDocente);
                notaDatos.setearConsulta("SELECT alu.Nombre,alu.Apellido,alu.Cuil,na.Nota1,na.Nota2,na.NotaFinal,na.IdEstadoAcademico,na.Id  FROM Notas na "+
                                            "INNER JOIN Alumnos alu on alu.Id = na.IdAlumno "+
                                            "WHERE na.IdMateriaDocente = @idMat");
                notaDatos.ejecutarLectura();

                while (notaDatos.Lector.Read())
                {
                    Nota aux = new Nota();
                    aux.alu = new Alumno();
                    aux.id = (int)notaDatos.Lector["Id"];
                    aux.alu.Nombre = (string)notaDatos.Lector["Nombre"];
                    aux.alu.Apellido = (string)notaDatos.Lector["Apellido"];
                    aux.alu.Cuil = (string)notaDatos.Lector["Cuil"];
                    aux.Nota1 = (decimal)notaDatos.Lector["Nota1"];
                    aux.Nota2 = (decimal)notaDatos.Lector["Nota2"];
                    aux.NotaFinal = (decimal)notaDatos.Lector["NotaFinal"];
                    aux.EstadoAcademico = (int)notaDatos.Lector["IdEstadoAcademico"];

                    lista.Add(aux);


                }

                return lista;
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                notaDatos.cerrarConexion();
            }
        }



        public Nota traerUnaNota(int idNota)
        {

            notaDatos = new AccesoDatos();

            try
            {

                notaDatos.setearParametro("@idNota", idNota);
                notaDatos.setearConsulta("SELECT alu.Nombre,alu.Apellido,alu.Cuil,na.Nota1,na.Nota2,na.NotaFinal,na.IdEstadoAcademico,na.Id  FROM Notas na " +
                                            "INNER JOIN Alumnos alu on alu.Id = na.IdAlumno " +
                                            "WHERE na.Id = @idNota");
                notaDatos.ejecutarLectura();

                notaDatos.Lector.Read();
                
                    Nota aux = new Nota();
                    aux.alu = new Alumno();
                    aux.id = (int)notaDatos.Lector["Id"];
                    aux.alu.Nombre = (string)notaDatos.Lector["Nombre"];
                    aux.alu.Apellido = (string)notaDatos.Lector["Apellido"];
                    aux.alu.Cuil = (string)notaDatos.Lector["Cuil"];
                    aux.Nota1 = (decimal)notaDatos.Lector["Nota1"];
                    aux.Nota2 = (decimal)notaDatos.Lector["Nota2"];
                    aux.NotaFinal = (decimal)notaDatos.Lector["NotaFinal"];
                    aux.EstadoAcademico = (int)notaDatos.Lector["IdEstadoAcademico"];




                return aux; ;
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                notaDatos.cerrarConexion();
            }
        }


        public List<EstadoAcademico> listaEstado()
        {
            notaDatos = new AccesoDatos();


            try
            {
                notaDatos.setearConsulta("SELECT Id,Nombre FROM EstadoAcademico");
                notaDatos.ejecutarLectura();
                List<EstadoAcademico> lista = new List<EstadoAcademico>();

                while (notaDatos.Lector.Read())
                {
                    EstadoAcademico Est = new EstadoAcademico();
                    Est.id = (int)notaDatos.Lector["Id"];
                    Est.Nombre = (string)notaDatos.Lector["Nombre"];
                    lista.Add(Est);
                }

                return lista;

            }
            catch (Exception e)
            {

                throw e;
            }

            finally
            {
                notaDatos.cerrarConexion();
            }
        }
    }
}
