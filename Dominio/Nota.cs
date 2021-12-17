using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{

    public class Nota
    {
        public Alumno alu { get; set; }
        public int id { get; set; }
        
        public int idAlumno { get; set; }

        public int idMateriaDocente { get; set; }

        public decimal Nota1 { get; set; }

        public decimal Nota2 { get; set; }

        public decimal NotaFinal { get; set; }

        public int EstadoAcademico { get; set; }
    }
}
