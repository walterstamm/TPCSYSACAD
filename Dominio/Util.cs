using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;

namespace Dominio
{
    public static class Util
    {
        public static string usuarioLogeado { get; set; }
        public static int tipoUsuario { get; set; } 

        public static int id { get; set; } //id_usuario


        public static Boolean validacionAdmin(Usuarios usuario)
        {
            if (usuario != null && usuario.TipoUsuario == Dominio.TipoUsuario.Admin)
            {
                return true;
            }
            return false;
        }

        public static Boolean validacionDocente(Usuarios usuario)
        {
            if (usuario != null && usuario.TipoUsuario == Dominio.TipoUsuario.Profesor)
            {
                return true;
            }
            return false;
        }
    }
}
