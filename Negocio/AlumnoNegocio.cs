using System;
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
            List<Alumno> lis_Alumno = new List<Alumno>();
            AccesoDatos alumno = new AccesoDatos();
 
            try
            {
                alumno.setearConsulta("SELECT Id, Cuil,Apellido,Nombre,FechaNacimiento,Email,Domicilio,Localidad,Estado FROM Alumnos WHERE Estado=1");
                alumno.ejecutarLectura();

                while (alumno.Lector.Read())
                {
                    Alumno aux1 = new Alumno();
                    aux1.Idalumno = (int)alumno.Lector["Id"];
                    aux1.Cuil = (string)alumno.Lector["Cuil"];
                    aux1.Apellido = (string)alumno.Lector["Apellido"];
                    aux1.Nombre = (string)alumno.Lector["Nombre"];
                    aux1.Fecha_Nac = (DateTime)alumno.Lector["FechaNacimiento"];
                    aux1.Mail = (string)alumno.Lector["Email"];
                    aux1.Domicilio = (string)alumno.Lector["Domicilio"];
                    aux1.Localidad_Prov = (string)alumno.Lector["Localidad"];
                    aux1.Estado = (int)alumno.Lector["Estado"];

                    lis_Alumno.Add(aux1);
                }
                return lis_Alumno;
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

        public void agregar(Alumno agregoAlumno)
        {
            AccesoDatos accesoAlumno = new AccesoDatos();
            try
            {
                string valores = "values( '" + agregoAlumno.Cuil + "', '" + agregoAlumno.Apellido + "', '" + agregoAlumno.Nombre + "', '" + agregoAlumno.Fecha_Nac + "', '" + agregoAlumno.Mail + "', '" + agregoAlumno.Domicilio + "', '" + agregoAlumno.Localidad_Prov + "',"+1+")";
                accesoAlumno.setearConsulta("set dateformat 'DMY' INSERT INTO ALUMNOS(Cuil, Apellido, Nombre,FechaNacimiento, Email, Domicilio,Localidad,Estado)" + valores);
                accesoAlumno.ejectutarAccion();
                //accesoAlumno.setearConsulta("UPDATE ALUMNOS SET USUARIOS = 'al.'"+ agregoAlumno.Cuil + " where cuil = " + agregoAlumno.Cuil);
                //accesoAlumno.ejectutarAccion();

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

        public void eliminar(int id)
        {
            alumno = new AccesoDatos();
            try
            {
                alumno.setearConsulta("UPDATE ALUMNOS SET Estado = 0 WHERE Id = " + id);
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

        public Alumno Un_alumno(int id_alumno)
        {
            AccesoDatos UnAlumno = new AccesoDatos();
            try
            {
                //UnAlumno.setearParametro("@idAlumno", id_alumno);
                UnAlumno.setearConsulta("SELECT Id, Cuil,Apellido,Nombre,FechaNacimiento,Email,Domicilio,Localidad FROM ALUMNOS WHERE Id = " + id_alumno);
                UnAlumno.ejecutarLectura();
                UnAlumno.Lector.Read();

                Alumno aux = new Alumno();
                aux.Idalumno = (int)UnAlumno.Lector["Id"];
                aux.Cuil = (string)UnAlumno.Lector["Cuil"];
                aux.Apellido = (string)UnAlumno.Lector["Apellido"];
                aux.Nombre = (string)UnAlumno.Lector["Nombre"];
                //aux.Nacionalidad = (string)UnAlumno.Lector["NACIONALIDAD"];
                aux.Fecha_Nac = (DateTime)UnAlumno.Lector["FechaNacimiento"];
                aux.Mail = (string)UnAlumno.Lector["Email"];
                aux.Domicilio = (string)UnAlumno.Lector["Domicilio"];
                aux.Localidad_Prov = (string)UnAlumno.Lector["Localidad"];
                //aux.Usuario = (string)UnAlumno.Lector["USUARIO"];
                //aux.Estado = (int)UnAlumno.Lector["ESTADO"];

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

        public void modificar(Alumno modificarAlumno)
        {
            AccesoDatos accesoModificar = new AccesoDatos();
            try
            {
                accesoModificar.setearConsulta("UPDATE ALUMNOS SET CUIL= @cuil, APELLIDO_NOMBRE=@apellido_nombre, NACIONALIDAD=@nacionalidad, FECHA_NAC=@fecha_nac, MAIL=@mail, DOMICILIO=@domicilio, LOCALIDAD_PCIA=@localidad_pcia WHERE ID_ALUMNO=@id_alumno");
                
                accesoModificar.setearParametro("@id_alumno", modificarAlumno.Idalumno);
                accesoModificar.setearParametro("@cuil", modificarAlumno.Cuil);
                accesoModificar.setearParametro("@apellido", modificarAlumno.Apellido);
                accesoModificar.setearParametro("@nombre", modificarAlumno.Nombre);
                //accesoModificar.setearParametro("@nacionalidad", modificarAlumno.Nacionalidad);
                accesoModificar.setearParametro("@fecha_nac", modificarAlumno.Fecha_Nac);
                accesoModificar.setearParametro("@mail", modificarAlumno.Mail);
                accesoModificar.setearParametro("@domicilio", modificarAlumno.Domicilio);
                accesoModificar.setearParametro("@localidad_pcia", modificarAlumno.Localidad_Prov);
                //accesoModificar.setearParametro("@usuario", modificarAlumno.Usuario);
                //accesoModificar.setearParametro("@estado", modificarAlumno.Estado);

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
