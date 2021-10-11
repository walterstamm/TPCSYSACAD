using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public enum TipoUsuario
    {
        Admin    = 1,
       // Profesor = 2,
        Alumno   = 2
    }
    public class Usuarios
    {
        public int id_usuario { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        //public Usuarios(string user, string pass, int Usu)
        public Usuarios(string user, string pass, bool admin)
        {
            User = user;
            Pass = pass;

            //if (Usu == 1)
            //{
            //    TipoUsuario = TipoUsuario.Admin;
            //}
            //else if (Usu == 2)
            //{
            //    TipoUsuario = TipoUsuario.Profesor;
            //}
            //else if (Usu == 3)
            //{
            //    TipoUsuario = TipoUsuario.Alumno;
            //}
            //pregunta por el tipo de usuario
            TipoUsuario = admin ? TipoUsuario.Admin : TipoUsuario.Alumno; // (admin = TipoUsuario.Profesor ? TipoUsuario.Profesor : TipoUsuario.Alumno);
            //TipoUsuario = TipoUsuario == 1 ? TipoUsuario.Admin : (TipoUsuario == 2 ? TipoUsuario.Profesor : (tipousuario == 3 ? TipoUsuario.Alumno : TipoUsuario.Administrador));

        }
    }
}
