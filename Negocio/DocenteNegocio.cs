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
                docente.setearConsulta("SELECT IdDocente, Cuil, Apellido, Nombre,Nacionalidad,FechaNacimiento,Email, Domicilio,UsuarioEstado,Estado from Docentes WHERE Estado = 1");
                docente.ejecutarLectura();

                while (docente.Lector.Read())
                {
                    Docente aux1 = new Docente();
                    aux1.Iddocente = (int)docente.Lector["IdDocente"];
                    aux1.Cuil = (string)docente.Lector["Cuil"];
                    aux1.Apellido = (string)docente.Lector["Apellido"];
                    aux1.Nombre = (string)docente.Lector["Nombre"];
                    aux1.Nacionalidad = (string)docente.Lector["Nacionalidad"];
                    aux1.FechaNacimiento = (DateTime)docente.Lector["FechaNacimiento"];
                    aux1.EMail = (string)docente.Lector["Email"];
                    aux1.Domicilio = (string)docente.Lector["Domicilio"];
                    aux1.UsuarioEstado = (int)docente.Lector["UsuarioEstado"];
                    aux1.Estado = (int)docente.Lector["Estado"];

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
                string valores = "values( '" + undocente.Cuil + "', '" + undocente.Apellido + "', '" + undocente.Nombre + "', '" + undocente.Nacionalidad + "', '" + undocente.FechaNacimiento + "', '" + undocente.EMail + "', '" + undocente.Domicilio + "',"+0+","+1+")";
                accesodoente.setearConsulta("INSERT INTO Docentes(Cuil, Apellido, Nombre,Nacionalidad,FechaNacimiento,Email,Domicilio,UsuarioEstado,Estado)" + valores);

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
                docente.setearConsulta("UPDATE DOCENTES SET Estado = 0 WHERE IdDocente = " + id);
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
                UnDocnete.setearConsulta("SELECT IdDocente, Cuil, Apellido, Nombre, Nacionalidad, FechaNacimiento, Email, Domicilio,UsuarioEstado,Estado FROM DOCENTES WHERE IdDocente = " + id_docente);
                UnDocnete.ejecutarLectura();
                UnDocnete.Lector.Read();

                Docente aux2 = new Docente();
                aux2.Iddocente = (int)UnDocnete.Lector["IdDocente"];
                aux2.Cuil = (string)UnDocnete.Lector["Cuil"];
                aux2.Apellido = (string)UnDocnete.Lector["Apellido"];
                aux2.Nombre = (string)UnDocnete.Lector["Nombre"];
                aux2.Nacionalidad = (string)UnDocnete.Lector["Nacionalidad"];
                aux2.FechaNacimiento = (DateTime)UnDocnete.Lector["FechaNacimiento"];
                aux2.EMail = (string)UnDocnete.Lector["Email"];
                aux2.Domicilio = (string)UnDocnete.Lector["Domicilio"];
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
                accesoModificar.setearConsulta("UPDATE DOCENTES SET CUIL= @cuil, APELLIDO=@apellido, NOMBRE=@nombre, NACIONALIDAD=@nacionalidad, FECHANACIMIENTO=@fechanacimiento, Email=@mail, DOMICILIO=@domicilio WHERE IdDocente=@iddocente");

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
