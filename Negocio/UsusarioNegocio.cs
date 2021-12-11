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
                conex_usuario.setearConsulta("select ud.id,ud.tipousuario  from UsuarioDocente ud inner join Usuarios u on ud.TipoUsuario=u.id where ud.Usuario = @usuario and ud.Password = @password");
                conex_usuario.setearParametro("@usuario", usuario.usuario);
                conex_usuario.setearParametro("@password", usuario.password);

                conex_usuario.ejecutarLectura();

                while (conex_usuario.Lector.Read())
                {
                    usuario.id = (int)conex_usuario.Lector["ID"];
                    usuario.TipoUsuario = (int)(conex_usuario.Lector["TIPOUSUARIO"]) == 1 ? TipoUsuario.Profesor : TipoUsuario.Admin;

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
