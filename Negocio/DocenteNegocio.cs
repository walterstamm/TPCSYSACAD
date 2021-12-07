using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class DocenteNegocio
    {
        private AccesoDatos docente;
        public List<Docente> listadocente()
        {
            List<Docente> lis_Docente = new List<Docente>();
            docente = new AccesoDatos();

            try
            {
                docente.setearConsulta("SELECT IDDOCENTE, CUIL, APELLIDO, NOMBRE, NACIONALIDAD, FECHANACIMIENTO, EMAIL, DOMICILIO, USUARIOESTADO, ESTADO from DOCENTES WHERE ESTADO = 1");
                docente.ejecutarLectura();

                while (docente.Lector.Read())
                {
                    Docente aux1 = new Docente();
                    aux1.Iddocente = (int)docente.Lector["IDDOCENTE"];
                    aux1.Cuil = (string)docente.Lector["CUIL"];
                    aux1.Apellido = (string)docente.Lector["APELLIDO"];
                    aux1.Nombre = (string)docente.Lector["NOMBRE"];
                    aux1.Nacionalidad = (string)docente.Lector["NACIONALIDAD"];
                    aux1.FechaNacimiento = (DateTime)docente.Lector["FECHANACIMIENTO"];
                    aux1.EMail = (string)docente.Lector["EMAIL"];
                    aux1.Domicilio = (string)docente.Lector["DOMICILIO"];
                    //aux1.Localidad_Prov = (string)docente.Lector["LOCALIDAD_PCIA"];
                    //aux1.Usuario = (string)docente.Lector["USUARIO"]; lo pongo asi porque trae problema por que el valor es nulo
                    aux1.UsuarioEstado = (int)docente.Lector["USUARIOESTADO"];
                    aux1.Estado = (int)docente.Lector["ESTADO"];

                    lis_Docente.Add(aux1);
                }
                return lis_Docente;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                docente.cerrarConexion();
            }
        }

        public void agregar(Docente undocente)
        {
            AccesoDatos accesodoente = new AccesoDatos();
            try
            {
                string valores = "values( '" + undocente.Cuil + "', '" + undocente.Apellido + "', '" + undocente.Nombre + "', '" + undocente.Nacionalidad + "', '" + undocente.FechaNacimiento + "', '" + undocente.EMail + "', '" + undocente.Domicilio + "')";
                accesodoente.setearConsulta("INSERT INTO DOCENTES(CUIL, APELLIDO, NOMBRE, NACIONALIDAD, FECHA_NAC, MAIL, DOMICILIO, LOCALIDAD_PCIA)" + valores);

                accesodoente.ejectutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesodoente.cerrarConexion();
                docente = null;
            }
        }

        public void eliminar(int id)
        {
            docente = new AccesoDatos();
            try
            {
                docente.setearConsulta("UPDATE DOCENTES SET ESTADO = 2 WHERE ID_DOCENTE = " + id);
                docente.ejectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                docente.cerrarConexion();
                docente = null;
            }
        }

        public Docente un_docente(int id_docente)
        {
            AccesoDatos UnDocnete = new AccesoDatos();
            try
            {
                UnDocnete.setearParametro("@idDocente", id_docente);
                UnDocnete.setearConsulta("SELECT ID_DOCENTE, CUIL, APELLIDO, NOMBRE, NACIONALIDAD, FECHANACIMIENTO, EMAIL, DOMICILIO, LOCALIDAD_PCIA FROM DOCENTES WHERE ID_DOCENTE = " + id_docente);
                UnDocnete.ejecutarLectura();
                UnDocnete.Lector.Read();

                Docente aux2 = new Docente();
                aux2.Iddocente = (int)UnDocnete.Lector["ID_DOCENTE"];
                aux2.Cuil = (string)UnDocnete.Lector["CUIL"];
                aux2.Apellido = (string)UnDocnete.Lector["APELLIDO"];
                aux2.Nombre = (string)UnDocnete.Lector["NOMBRE"];
                aux2.Nacionalidad = (string)UnDocnete.Lector["NACIONALIDAD"];
                aux2.FechaNacimiento = (DateTime)UnDocnete.Lector["FECHANACIMIENTO"];
                aux2.EMail = (string)UnDocnete.Lector["EMAIL"];
                aux2.Domicilio = (string)UnDocnete.Lector["DOMICILIO"];
                //aux2.Localidad_Prov = (string)UnDocnete.Lector["LOCALIDAD_PCIA"];
                aux2.UsuarioEstado = (int)UnDocnete.Lector["USUARIOESTADO"];
                aux2.Estado = (int)UnDocnete.Lector["ESTADO"];

                return aux2;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                UnDocnete.cerrarConexion();
            }
        }
        public void modificar(Docente modifDocente)
        {
            AccesoDatos accesoModificar = new AccesoDatos();
            try
            {
                accesoModificar.setearConsulta("UPDATE DOCENTES SET CUIL= @cuil, APELLIDO=@apellido, NOMBRE=@nombre, NACIONALIDAD=@nacionalidad, FECHANACIMIENTO=@fechanacimiento, MAIL=@mail, DOMICILIO=@domicilio WHERE IDDOCENTE=@iddocente");

                accesoModificar.setearParametro("@iddocente", modifDocente.Iddocente);
                accesoModificar.setearParametro("@cuil", modifDocente.Cuil);
                accesoModificar.setearParametro("@apellido", modifDocente.Apellido);
                accesoModificar.setearParametro("@nombre", modifDocente.Nombre);
                accesoModificar.setearParametro("@nacionalidad", modifDocente.Nacionalidad);
                accesoModificar.setearParametro("@fechanacimiento", modifDocente.FechaNacimiento);
                accesoModificar.setearParametro("@mail", modifDocente.EMail);
                accesoModificar.setearParametro("@domicilio", modifDocente.Domicilio);
                //accesoModificar.setearParametro("@localidad_pcia", modifDocente.Localidad_Prov);
                //accesoModificar.setearParametro("@usuario", modifDocente.Usuario);
                //accesoModificar.setearParametro("@estado", modifDocente.Estado);

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
    }
}
