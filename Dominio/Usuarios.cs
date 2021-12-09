using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public enum TipoUsuario
    {
        Admin    = 3,
        Profesor  = 1,
       // Alumno   = 2
    }
    public class Usuarios
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public int idDocente { get; set; }
        //public Usuarios(string user, string pass, int Usu)
        public Usuarios(string user, string pass, bool admin)
        {
            usuario = user;
            password = pass;
            
        }
    }
}
