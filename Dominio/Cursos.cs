using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cursos
    {
        public int Id { set; get; }

        public int IdMateria { set; get; }

        public int IdDocente { set; get; }

        public int IdCuatrimestre { set; get; }

        public int Anio { set; get; }

        public int Estado { set; get; }
    }
}
