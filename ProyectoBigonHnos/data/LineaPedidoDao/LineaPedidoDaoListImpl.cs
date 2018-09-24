using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.LineaPedidoDao
{
    class LineaPedidoDaoListImpl : ILineaPedidoDao
    {
        private static List<LineaPedido> todasLasLineasPedidos = new List<LineaPedido>();
        private static int IdContador = 0;


        public void actualizar(LineaPedido t)
        {
            for (int i = 0; i < todasLasLineasPedidos.Count; i++)
            {
                if (todasLasLineasPedidos.ElementAt(i).IdLineaPedido == t.IdLineaPedido)
                    todasLasLineasPedidos[i] = t;
            }
        }

        public void eliminar(int id)
        {
            for (int i = 0; i < todasLasLineasPedidos.Count; i++)
            {
                if (todasLasLineasPedidos.ElementAt(i).IdLineaPedido == id)
                    todasLasLineasPedidos.RemoveAt(i);
            }
        }

        public LineaPedido leerPorId(int id)
        {
            for ( int i = 0; i < todasLasLineasPedidos.Count; i++)
            {
                if (todasLasLineasPedidos.ElementAt(i).IdLineaPedido == id)
                    return todasLasLineasPedidos.ElementAt(i);
            }

            return null;
        }

        public List<LineaPedido> listarTodos()
        {
            return todasLasLineasPedidos;
        }

        public void registrar(LineaPedido t)
        {
            t.IdLineaPedido = IdContador;
            IdContador++;

            todasLasLineasPedidos.Add(t);
        }
    }
}
