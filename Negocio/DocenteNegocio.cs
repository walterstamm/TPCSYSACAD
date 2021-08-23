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
                docente.setearConsulta("SELECT ID_DOCENTE, CUIL, APELLIDO_NOMBRE, NACIONALIDAD, FECHA_NAC, MAIL, DOMICILIO, LOCALIDAD_PCIA, USUARIO, ESTADO FROM DOCENTES WHERE ESTADO != 2");
                docente.ejecutarLectura();

                while (docente.Lector.Read())
                {
                    Docente aux1 = new Docente();
                    aux1.Iddocente = (int)docente.Lector["ID_DOCENTE"];
                    aux1.Cuil = (string)docente.Lector["CUIL"];
                    aux1.ApellidoNombre = (string)docente.Lector["APELLIDO_NOMBRE"];
                    aux1.Nacionalidad = (string)docente.Lector["NACIONALIDAD"];
                    aux1.Fecha_Nac = (DateTime)docente.Lector["FECHA_NAC"];
                    aux1.Mail = (string)docente.Lector["MAIL"];
                    aux1.Domicilio = (string)docente.Lector["DOMICILIO"];
                    aux1.Localidad_Prov = (string)docente.Lector["LOCALIDAD_PCIA"];
                    //aux1.Usuario = (string)docente.Lector["USUARIO"]; lo pongo asi porque trae problema por que el valor es nulo
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
                string valores = "values( '" + undocente.Cuil + "', '" + undocente.ApellidoNombre + "', '" + undocente.Nacionalidad + "', '" + undocente.Fecha_Nac + "', '" + undocente.Mail + "', '" + undocente.Domicilio + "', '" + undocente.Localidad_Prov + "')";
                accesodoente.setearConsulta("INSERT INTO DOCENTES(CUIL, APELLIDO_NOMBRE, NACIONALIDAD, FECHA_NAC, MAIL, DOMICILIO, LOCALIDAD_PCIA)" + valores);

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
                UnDocnete.setearConsulta("SELECT ID_DOCENTE, CUIL, APELLIDO_NOMBRE, NACIONALIDAD, FECHA_NAC, MAIL, DOMICILIO, LOCALIDAD_PCIA FROM DOCENTES WHERE ID_DOCENTE = " + id_docente);
                UnDocnete.ejecutarLectura();
                UnDocnete.Lector.Read();

                Docente aux2 = new Docente();
                aux2.Iddocente = (int)UnDocnete.Lector["ID_DOCENTE"];
                aux2.Cuil = (string)UnDocnete.Lector["CUIL"];
                aux2.ApellidoNombre = (string)UnDocnete.Lector["APELLIDO_NOMBRE"];
                aux2.Nacionalidad = (string)UnDocnete.Lector["NACIONALIDAD"];
                aux2.Fecha_Nac = (DateTime)UnDocnete.Lector["FECHA_NAC"];
                aux2.Mail = (string)UnDocnete.Lector["MAIL"];
                aux2.Domicilio = (string)UnDocnete.Lector["DOMICILIO"];
                aux2.Localidad_Prov = (string)UnDocnete.Lector["LOCALIDA_PCIA"];
                //aux2.Usuario = (string)UnDocnete.Lector["USUARIO"];
                //aux2.Estado = (int)UnDocnete.Lector["ESTADO"];

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
                accesoModificar.setearConsulta("UPDATE DOCENTES SET CUIL= @cuil, APELLIDO_NOMBRE=@apellido_nombre, NACIONALIDAD=@nacionalidad, FECHA_NAC=@fecha_nac, MAIL=@mail, DOMICILIO=@domicilio, LOCALIDAD_PCIA=@localidad_pcia WHERE ID_DOCENTE=@id_docente");

                accesoModificar.setearParametro("@id_docente", modifDocente.Iddocente);
                accesoModificar.setearParametro("@cuil", modifDocente.Cuil);
                accesoModificar.setearParametro("@apellido_nombre", modifDocente.ApellidoNombre);
                accesoModificar.setearParametro("@nacionalidad", modifDocente.Nacionalidad);
                accesoModificar.setearParametro("@fecha_nac", modifDocente.Fecha_Nac);
                accesoModificar.setearParametro("@mail", modifDocente.Mail);
                accesoModificar.setearParametro("@domicilio", modifDocente.Domicilio);
                accesoModificar.setearParametro("@localidad_pcia", modifDocente.Localidad_Prov);
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
