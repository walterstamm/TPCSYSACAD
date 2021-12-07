using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Alumno
    {
        public int Idalumno { get; set; } //ES AUTOGENERABLE AUTOINCREMENTAL
        public string Cuil { get; set; }
        public string Apellido{ get; set; }
        public string Nombre { get; set; }

        //public string Nacionalidad { get; set; }
        public DateTime Fecha_Nac { get; set; }
        public string Mail { get; set; }
        public string Domicilio { get; set; } //Calle y nro depto
        public string Localidad_Prov { get; set; } //Localidad y Provincia
        public string Usuario { get; set; }
        public int Estado { get; set; } //0, 1, 2
    }
}
