using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public enum TipoUsuario
    {
        Admin = 1,
        Profesor = 2
    }
    public class Usuarios
    {
        public int id_usuario { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public Usuarios (string user, string pass, bool admin)
        {
            User = user;
            Pass = pass;
            //pregunta por el tipo de usuario
            TipoUsuario = admin ? TipoUsuario.Admin : TipoUsuario.Profesor;
            //TipoUsuario = tipousuario == 1 ? TipoUsuario.Administracion : (tipousuario == 2 ? TipoUsuario.Profesor : (tipousuario == 3 ? TipoUsuario.Alumno : TipoUsuario.Administrador));

        }
    }
}
