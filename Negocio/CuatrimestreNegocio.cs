using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CuatrimestreNegocio
    {
        private AccesoDatos negCuatri;

        public List<Cuatrimestres> listaCuatrimestres()
        {
            negCuatri = new AccesoDatos();


            try
            {
                negCuatri.setearConsulta("SELECT IdCuatrimestre,Nombre from Cuatrimestres");
                negCuatri.ejecutarLectura();
                List<Cuatrimestres> lista = new List<Cuatrimestres>();

                while (negCuatri.Lector.Read())
                {
                    Cuatrimestres cua = new Cuatrimestres();
                    cua.IdCuatrimestre = (int)negCuatri.Lector["IdCuatrimestre"];
                    cua.nombreCuatrimestre = (string)negCuatri.Lector["Nombre"];
                    lista.Add(cua);
                }

                return lista;

            }
            catch ( Exception e)
            {

                throw e;
            }

            finally
            {
                negCuatri.cerrarConexion();
            }
        }
    }
}
