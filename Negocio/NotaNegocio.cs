using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NotaNegocio
    {
        AccesoDatos notaDatos;

        public List<Nota> listaNotas(int idMateriaDocente)
        {

            List<Nota> lista = new List<Nota>();
            notaDatos = new AccesoDatos();

            try
            {



                return lista;
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                notaDatos.cerrarConexion();
            }
        }

    }
}
