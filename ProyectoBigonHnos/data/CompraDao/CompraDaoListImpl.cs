using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.CompraDao
{
    class CompraDaoListImpl : ICompraDao
    {
        private static List<Compra> todasLasCompras = new List<Compra>();
        private static int IdContador = 0;

        public void actualizar(Compra t)
        {
            for (int i = 0; i < todasLasCompras.Count; i++)
                if (todasLasCompras.ElementAt(i).IdCompra == t.IdCompra)
                    todasLasCompras[i] = t;
        }

        public void eliminar(int id)
        {
            for (int i = 0; i < todasLasCompras.Count; i++)
            {
                if (todasLasCompras.ElementAt(i).IdCompra == id)
                    todasLasCompras.RemoveAt(i);
            }
        }

        public Compra leerPorId(int id)
        {
            for (int i = 0; i < todasLasCompras.Count; i++)
            {
                if (todasLasCompras.ElementAt(i).IdCompra == id)
                {
                    return todasLasCompras.ElementAt(i);
                }
            }

            return null;
        }

        public List<Compra> listarTodos()
        {
            return todasLasCompras;
        }

        public void registrar(Compra t)
        {

            t.IdCompra = IdContador;
            IdContador++;
            todasLasCompras.Add(t);
        }
    }
}
