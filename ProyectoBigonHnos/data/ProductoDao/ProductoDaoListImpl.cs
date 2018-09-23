using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.ProductoDao
{
    class ProductoDaoListImpl : IProductoDao
    {
        private static List<Producto> todosLosProductos = new List<Producto>();
        private static int IdContador = 0;

        public void actualizar(Producto t)
        {
            int i = buscarIndex(t.IdProducto);

            if (i != -1)
                todosLosProductos[i] = t;
        }

        public void eliminar(int id)
        {
            int i = buscarIndex(id);

            if (i != -1)
                todosLosProductos.RemoveAt(i);
        }

        public Producto leerPorId(int id)
        {
            int i = buscarIndex(id);

            if (i != -1)
                return todosLosProductos.ElementAt(i);

            return null;
        }

        public List<Producto> listarTodos()
        {
            return todosLosProductos;
        }

        public void registrar(Producto t)
        {
            t.IdProducto = IdContador;
            IdContador++;

            todosLosProductos.Add(t);
        }

        private int buscarIndex(int id)
        {
            for ( int i = 0; i < todosLosProductos.Count; i++)
            {
                if (todosLosProductos.ElementAt(i).IdProducto == id)
                    return i;
            }

            return -1;
        }
    }
}
