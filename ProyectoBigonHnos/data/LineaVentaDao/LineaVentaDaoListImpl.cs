using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio.liquidacion;
using ProyectoBigonHnos.dominio.venta;

namespace ProyectoBigonHnos.data.LineaVentaDao
{
    class LineaVentaDaoListImpl : ILineaVentaDao
    {
        private static List<LineaDeVenta> todasLasLineasVenta = new List<LineaDeVenta>();
        private static int IdContador = 0;

        public void actualizar(LineaDeVenta t)
        {
            for (int i = 0; i < todasLasLineasVenta.Count; i++)
            {
                if (todasLasLineasVenta.ElementAt(i).IdLineaVenta == t.IdLineaVenta)
                    todasLasLineasVenta[i] = t;
            }
        }

        public void eliminar(int id)
        {
            for (int i = 0; i < todasLasLineasVenta.Count; i++)
            {
                if (todasLasLineasVenta.ElementAt(i).IdLineaVenta == id)
                    todasLasLineasVenta.RemoveAt(i);
            }
        }

        public LineaDeVenta leerPorId(int id)
        {
            for(int i = 0; i <todasLasLineasVenta.Count; i++)
            {
                if (todasLasLineasVenta.ElementAt(i).IdLineaVenta == id)
                    return todasLasLineasVenta.ElementAt(i);
            }

            return null;
        }

        public List<LineaDeVenta> listarTodos()
        {
            return todasLasLineasVenta;
        }

        public void registrar(LineaDeVenta t)
        {
            t.IdLineaVenta = IdContador;
            IdContador++;

            todasLasLineasVenta.Add(t);
        }
    }
}
