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
        public decimal evento1 { get; set; }
        public decimal evento2 { get; set; }
        public decimal rec1 { get; set; }
        public decimal rec2 { get; set; }
        public Decimal notafinal { get; set; }
        public string resultadofinal { set; get; }
    }
}
