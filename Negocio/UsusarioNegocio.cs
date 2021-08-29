using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class UsusarioNegocio
    {
        public bool Loguear(Usuarios usuario)
        {
            AccesoDatos conex_usuario = new AccesoDatos();

            try
            {
                conex_usuario.setearConsulta("SELECT ID_USUARIO, TIPOUSUARIO FROM USUARIOS WHERE USUARIO = @usuario and PASSWARD = @passward");
                conex_usuario.setearParametro("@usuario", usuario.User);
                conex_usuario.setearParametro("@passward", usuario.Pass);

                conex_usuario.ejecutarLectura();

                while (conex_usuario.Lector.Read())
                {
                    usuario.id_usuario = (int)conex_usuario.Lector["ID_USUARIO"];
                    usuario.TipoUsuario = (int)(conex_usuario.Lector["TIPOUSUARIO"]) == 2 ? TipoUsuario.Profesor : TipoUsuario.Admin;

                    return true; //SI TRAE EL USUARIO LE ASIGNA LA PASSWARD Y DEVUELVE TRUE.
                }
                return false; // SI NO DEVUELVE FALSE
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conex_usuario.cerrarConexion();
            }
        }
    }
}
