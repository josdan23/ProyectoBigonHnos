using System.Collections.Generic;
using System.Linq;
using ProyectoBigonHnos.dominio.venta;

namespace ProyectoBigonHnos.data.VentaDao
{
    class VentaDaoListImpl : IVentaDao
    {
        private static List<Venta> todasLasVentas = new List<Venta>();
        private static int IdContador = 0;

        public void actualizar(Venta t)
        {
            for (int i = 0; i < todasLasVentas.Count; i++)
                if (todasLasVentas.ElementAt(i).IdVenta == t.IdVenta)
                    todasLasVentas[i] = t;
        }

        public void eliminar(int id)
        {
            for ( int i = 0; i < todasLasVentas.Count; i++)
            {
                if (todasLasVentas.ElementAt(i).IdVenta == id)
                    todasLasVentas.RemoveAt(i);
            }
        }

        public Venta leerPorId(int id)
        {
            for (int i = 0; i < todasLasVentas.Count; i++)
            {
                if (todasLasVentas.ElementAt(i).IdVenta == id)
                    return todasLasVentas.ElementAt(i);
            }

            return null;
        }

        public List<Venta> listarTodos()
        {
            return todasLasVentas;
        }

        public void registrar(Venta t)
        {
            t.IdVenta = IdContador;
            IdContador++;

            todasLasVentas.Add(t);
        }
    }
}
