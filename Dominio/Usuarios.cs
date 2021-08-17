using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public enum TipoUsuario
    {
        Administracion = 1,
        Profesor = 2,
        Alumno = 3,
        Administrador = 4
    }
    public class Usuarios
    {
        public int ID_USUARIO { get; set; }
        public string USUARIO { get; set; }
        public string PASS { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public Usuarios (string usuario, string pass, int tipousuario)
        {
            USUARIO = usuario;
            PASS = pass;
            //pregunta por el tipo de usuario
            TipoUsuario = tipousuario == 1 ? TipoUsuario.Administracion : (tipousuario == 2 ? TipoUsuario.Profesor : (tipousuario == 3 ? TipoUsuario.Alumno : TipoUsuario.Administrador));

        }
    }
}
