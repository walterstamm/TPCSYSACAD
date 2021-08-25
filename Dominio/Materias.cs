using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Materias
    {
		public string id_materia { set; get; }

		public string nombre_materia { set; get; } // varchar(50)

		public int carga_horaria_minima { set; get; } // INT NOT NULL CHECK(CARGA_HORARIA_MINIMA > 0),

		public string carrera { set; get; } // VARCHAR(10) NOT NULL FOREIGN KEY REFERENCES CARRERAS(ID_CARRERA),
		public int año_curso { set; get; } // INT NOT NULL CHECK(AÑO_CURSO = 1 OR AÑO_CURSO = 2),

		public int cuatrimestre { set; get; } // INT NOT NULL CHECK(CUARTRIMESTRE = 1 OR CUARTRIMESTRE = 2),

		public bool estado { set; get; } //	 BIT NOT NULL DEFAULT(1)

	}
}
