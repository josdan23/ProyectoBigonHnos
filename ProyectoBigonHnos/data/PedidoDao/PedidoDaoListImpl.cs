using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.PedidoDao
{
    class PedidoDaoListImpl : IPedidoDao
    {
        private static List<Pedido> todosLosPedidos = new List<Pedido>();
        private static int IdContador = 0;

        public void actualizar(Pedido t)
        {
            for ( int i = 0; i < todosLosPedidos.Count; i++)
            {
                if (todosLosPedidos.ElementAt(i).idPedido == t.idPedido)
                    todosLosPedidos[i] = t;
            }
        }

        public void eliminar(int id)
        {
            for ( int i = 0; i < todosLosPedidos.Count; i++)
            {
                if (todosLosPedidos.ElementAt(i).idPedido == id)
                    todosLosPedidos.RemoveAt(i);
            }
        }

        public Pedido leerPorId(int id)
        {
            for ( int i =  0; i < todosLosPedidos.Count; i++)
            {
                if (todosLosPedidos.ElementAt(i).idPedido == id)
                    return todosLosPedidos.ElementAt(i);
            }

            return null;
        }

        public List<Pedido> listarTodos()
        {
            return todosLosPedidos;
        }

        public void registrar(Pedido t)
        {
            t.idPedido = IdContador;
            IdContador++;

            todosLosPedidos.Add(t);
        }
    }
}
