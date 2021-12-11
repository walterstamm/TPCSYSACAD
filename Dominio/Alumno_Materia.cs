using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Alumno_Materia
    {
        public int id { get; set; }
        public int idalumno { get; set; }
        public int idmateriadocente { get; set; }
        public int evento1 { get; set; }
        public int evento2 { get; set; }
        public int rec1 { get; set; }
        public int rec2 { get; set; }
        public Decimal notafinal { get; set; }
        public string resultadofinal { set; get; }
    }
}
