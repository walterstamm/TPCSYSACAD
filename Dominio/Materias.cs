using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Materias
    {
		public int idmateria { set; get; }

		public string nombremateria { set; get; } // varchar(50)



        public int idcarrera { set; get; } // VARCHAR(10) NOT NULL FOREIGN KEY REFERENCES CARRERAS(ID_CARRERA),
        public int anio { set; get; } // INT NOT NULL CHECK(AÑO_CURSO = 1 OR AÑO_CURSO = 2),

		public int cuatrimestre { set; get; } // INT NOT NULL CHECK(CUARTRIMESTRE = 1 OR CUARTRIMESTRE = 2),

		public int estado { set; get; } //	 BIT NOT NULL DEFAULT(1)

	}
}
