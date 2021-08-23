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
                alumno.setearConsulta("SELECT ID_ALUMNO, CUIL, APELLIDO_NOMBRE, NACIONALIDAD, FECHA_NAC, MAIL, DOMICILIO, LOCALIDAD_PCIA, USUARIO, ESTADO FROM ALUMNOS WHERE ESTADO !=2");
                alumno.ejecutarLectura();

                while (alumno.Lector.Read())
                {
                    Alumno aux1 = new Alumno();
                    aux1.Idalumno = (int)alumno.Lector["ID_ALUMNO"];
                    aux1.Cuil = (string)alumno.Lector["CUIL"];
                    aux1.ApellidoNombre = (string)alumno.Lector["APELLIDO_NOMBRE"];
                    aux1.Nacionalidad = (string)alumno.Lector["NACIONALIDAD"];
                    aux1.Fecha_Nac = (DateTime)alumno.Lector["FECHA_NAC"];
                    aux1.Mail = (string)alumno.Lector["MAIL"];
                    aux1.Domicilio = (string)alumno.Lector["DOMICILIO"];
                    aux1.Localidad_Prov = (string)alumno.Lector["LOCALIDAD_PCIA"];
                    //aux1.Usuario = (string)alumno.Lector["USUARIO"];
                    aux1.Estado = (int)alumno.Lector["ESTADO"];

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
                string valores = "values( '" + agregoAlumno.Cuil + "', '" + agregoAlumno.ApellidoNombre + "', '" + agregoAlumno.Nacionalidad + "', '" + agregoAlumno.Fecha_Nac + "', '" + agregoAlumno.Mail + "', '" + agregoAlumno.Domicilio + "', '" + agregoAlumno.Localidad_Prov + "')";
                accesoAlumno.setearConsulta("INSERT INTO ALUMNOS(CUIL, APELLIDO_NOMBRE, NACIONALIDAD, FECHA_NAC, MAIL, DOMICILIO, LOCALIDAD_PCIA)" + valores);

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

        public void eliminar(int id)
        {
            alumno = new AccesoDatos();
            try
            {
                alumno.setearConsulta("UPDATE ALUMNOS SET ESTADO = 2 WHERE ID_ALUMNO = " + id);
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
                UnAlumno.setearParametro("@idAlumno", id_alumno);
                UnAlumno.setearConsulta("SELECT  ID_ALUMNO, CUIL, APELLIDO_NOMBRE, NACIONALIDAD, FECHA_NAC, MAIL, DOMICILIO, LOCALIDAD_PCIA FROM ALUMNOS WHERE ID_ALUMNO = " + id_alumno);
                UnAlumno.ejecutarLectura();
                UnAlumno.Lector.Read();

                Alumno aux = new Alumno();
                aux.Idalumno = (int)UnAlumno.Lector["ID_ALUMNO"];
                aux.Cuil = (string)UnAlumno.Lector["CUIL"];
                aux.ApellidoNombre = (string)UnAlumno.Lector["APELLIDO_NOMBRE"];
                aux.Nacionalidad = (string)UnAlumno.Lector["NACIONALIDAD"];
                aux.Fecha_Nac = (DateTime)UnAlumno.Lector["FECHA_NAC"];
                aux.Mail = (string)UnAlumno.Lector["MAIL"];
                aux.Domicilio = (string)UnAlumno.Lector["DOMICILIO"];
                aux.Localidad_Prov = (string)UnAlumno.Lector["LOCALIDAD_PCIA"];
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
                accesoModificar.setearParametro("@apellido_nombre", modificarAlumno.ApellidoNombre);
                accesoModificar.setearParametro("@nacionalidad", modificarAlumno.Nacionalidad);
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
