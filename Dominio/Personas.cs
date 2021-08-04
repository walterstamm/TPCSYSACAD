using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Personas
    {
        public int Idpersona { get; set; }
        public string Dni{ get; set; }
        public string ApellidoNombre { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha_Nac { get; set; }
        public string Mail { get; set; }
    }
}
