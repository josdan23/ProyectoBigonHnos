using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio.pedido;

namespace ProyectoBigonHnos.data.CostoExtraDao
{
    class CostoExtraDaoListImpl : ICostoExtraDao
    {
        private static List<CostoExtra> todosLosCostosExtras = new List<CostoExtra>();
        private static int idContador = 0;

        public void actualizar(CostoExtra t)
        {
            for (int i = 0; i < todosLosCostosExtras.Count; i++)
            {
                if (todosLosCostosExtras.ElementAt(i).idCostoExtra == t.idCostoExtra)
                    todosLosCostosExtras[i] = t;
            }
        }

        public void eliminar(int id)
        {
            for (int i = 0; i < todosLosCostosExtras.Count; i++)
            {
                if (todosLosCostosExtras.ElementAt(i).idCostoExtra == id)
                    todosLosCostosExtras.RemoveAt(i);
            }
        }

        public CostoExtra leerPorId(int id)
        {
            for (int i = 0; i < todosLosCostosExtras.Count; i++)
            {
                if (todosLosCostosExtras.ElementAt(i).idCostoExtra ==id)
                    return todosLosCostosExtras.ElementAt(i);
            }
            return null;
        }

        public List<CostoExtra> listarTodos()
        {
            return todosLosCostosExtras;
        }

        public void registrar(CostoExtra t)
        {
            t.idCostoExtra = idContador;
            idContador++;

            todosLosCostosExtras.Add(t);
        }
    }
}
