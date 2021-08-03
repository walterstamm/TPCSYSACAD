using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public enum Permisos
    {
        Administracion = 1,
        Profesor = 2,
        Alumno = 3,
        Administrad = 4
    }
    public class Usuarios
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public string Clave { get; set; }
        public Permisos Permiso { get; set; }
        public Usuarios (string descripcion, string clave, int permiso)
        {
            Descripcion = descripcion;
            Clave = clave;
            Permiso = permiso;
            //TipoUsuarios = Admin ? TipoUsuario.ADMIN : TipoUsuario.Normal;
        }
    }
}
