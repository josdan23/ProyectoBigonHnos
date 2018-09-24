using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.LineaCompraDao
{
    class LineaCompraDaoListImpl : ILineaCompraDao
    {
        private static List<LineaCompra> todasLasLineasDeCompra = new List<LineaCompra>();
        private static int IdContador = 0;

        public void actualizar(LineaCompra t)
        {
            for (int i = 0; i < todasLasLineasDeCompra.Count; i++)
            {
                if (todasLasLineasDeCompra.ElementAt(i).IdLineaCompra == t.IdLineaCompra)
                    todasLasLineasDeCompra[i] = t;
            }

        }

        public void eliminar(int id)
        {
            for (int i = 0; i < todasLasLineasDeCompra.Count; i++)
            {
                if (todasLasLineasDeCompra.ElementAt(i).IdLineaCompra == id)
                    todasLasLineasDeCompra.RemoveAt(i);
            }

        }

        public LineaCompra leerPorId(int id)
        {
            for ( int i = 0; i < todasLasLineasDeCompra.Count; i++)
            {
                if (todasLasLineasDeCompra.ElementAt(i).IdLineaCompra == id)
                    return todasLasLineasDeCompra.ElementAt(i);
            }

            return null;
        }

        public List<LineaCompra> listarTodos()
        {
            return todasLasLineasDeCompra;
        }

        public void registrar(LineaCompra t)
        {
            t.IdLineaCompra = IdContador;
            IdContador++;
            todasLasLineasDeCompra.Add(t);
        }
    }
}
