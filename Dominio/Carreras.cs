using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Carreras
    {
        public string id_carrera { get; set; } //varchar (10)
        public string nombre_carrera { get; set; } //varchar(100)
        public string plan_año { get; set; } //varchar(5)
        public string doc_habilitante { get; set; } // varchar(50)
        public bool estado { get; set; }
    }
}
