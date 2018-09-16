using ProyectoBigonHnos.data.ProvinciaDao;
using ProyectoBigonHnos.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.data.ProvinciaDao
{
    class ProvinciaDaoListImpl : IProvinciaDAO
    {
        private static List<Provincia> todasLasProvincias = new List<Provincia>();
        private static int idContador = 0;
        

        public void actualizar(Provincia t)
        {
            for (int i = 0; i < todasLasProvincias.Count; i++)
            {
                if (todasLasProvincias[i].IdProvincia == t.IdProvincia)
                {
                    todasLasProvincias[i] = t;
                }
            }

        }

        public void eliminar(int id)
        {
            for (int i = 0; i < todasLasProvincias.Count; i++)
            {
                if (todasLasProvincias[i].IdProvincia == id)
                {
                    todasLasProvincias.RemoveAt(i);
                }
            }

        }

        public Provincia leerPorId(int id)
        {
            for ( int i = 0; i < todasLasProvincias.Count; i++)
            {
                if ( todasLasProvincias[i].IdProvincia == id)
                {
                    return todasLasProvincias.ElementAt(i);
                }
            }

            return null;
        }

        public List<Provincia> listarTodos()
        {
            return todasLasProvincias;
        }

        public void registrar(Provincia t)
        {
            t.IdProvincia = idContador;
            idContador++;

            todasLasProvincias.Add(t);
        }
    }
}
