using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Carreras
    {
        public int id { get; set; } //varchar (10)
        public string nombre { get; set; } //varchar(100)
        public string numeroplan { get; set; } //varchar(5)
        public string numerohabilitante { get; set; } // varchar(50)
        public bool estado { get; set; }
    }
}
