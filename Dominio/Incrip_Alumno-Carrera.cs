using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Incrip_Alumno_Carrera
    {
        public int ID_INSCRIPCION_CARRERA { get; set; }
        public Alumno alumno { get; set;  }
        public Carreras carrera { get; set; }
        public int AÑO { get; set;  }
        public int CUATRIMESTRE { get; set; }
        public bool ESTADO { get; set; }
    }
}
