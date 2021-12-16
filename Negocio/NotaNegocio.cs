﻿using System;
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
                notaDatos.setearConsulta("SELECT alu.Nombre,alu.Apellido,alu.Cuil,na.Nota1,na.Nota2,na.NotaFinal,na.IdEstadoAcademico  FROM Notas na "+
                                            "INNER JOIN Alumnos alu on alu.Id = na.IdAlumno "+
                                            "WHERE na.IdMateriaDocente = @idMat");
                notaDatos.ejecutarLectura();

                while (notaDatos.Lector.Read())
                {
                    Nota aux = new Nota();
                    aux.alu = new Alumno();
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

    }
}