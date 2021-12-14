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
                conex_usuario.setearConsulta("select ud.id,ud.tipousuario,IdDocente  from UsuarioDocente ud inner join Usuarios u on ud.TipoUsuario=u.id where ud.Usuario = @usuario and ud.Password = @password");
                conex_usuario.setearParametro("@usuario", usuario.usuario);
                conex_usuario.setearParametro("@password", usuario.password);

                conex_usuario.ejecutarLectura();

                while (conex_usuario.Lector.Read())
                {
                    usuario.id = (int)conex_usuario.Lector["ID"];
                    usuario.TipoUsuario = (int)(conex_usuario.Lector["TIPOUSUARIO"]) == 1 ? TipoUsuario.Profesor : TipoUsuario.Admin;
                    usuario.idDocente = (int)conex_usuario.Lector["IdDocente"];
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

        public bool ValidarDocente(int idDoc)
        {
            AccesoDatos conex_usuario = new AccesoDatos();

            try
            {
                conex_usuario.setearParametro("@idDoc", idDoc);

                conex_usuario.setearConsulta("SELECT Estado from Docentes  WHERE IdDocente=@idDoc");

                conex_usuario.ejecutarLectura();
                bool estado = false;

                while (conex_usuario.Lector.Read())
                {
                    estado = Convert.ToBoolean(conex_usuario.Lector["Estado"]);


                }
                return estado;
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



        public List<Docente> listaDocente()
        {
            List<Docente> lis_Docente = new List<Docente>();
            AccesoDatos usuarioDatos = new AccesoDatos();

            try
            {
                usuarioDatos.setearConsulta("SELECT IdDocente,Apellido +' '+Nombre+'-'+Cuil AS Nombre from Docentes WHERE Estado = 1");
                usuarioDatos.ejecutarLectura();

                while (usuarioDatos.Lector.Read())
                {
                    Docente aux1 = new Docente();
                    aux1.Iddocente = (int)usuarioDatos.Lector["IdDocente"];

                    aux1.Nombre = (string)usuarioDatos.Lector["Nombre"];



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
                usuarioDatos.cerrarConexion();
            }
        }
    

    }
}
