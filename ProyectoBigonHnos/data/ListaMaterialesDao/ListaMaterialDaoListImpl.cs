using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio.pedido;

namespace ProyectoBigonHnos.data.ListaMaterialDao
{
    class ListaMaterialDaoListImpl : IListaMaterialDao
    {
        private static List<ListaMaterial> todosLosMaterialesNecesarios = new List<ListaMaterial>();
        private static int IdContador = 0;

        public void actualizar(ListaMaterial t)
        {
            for (int i = 0; i < todosLosMaterialesNecesarios.Count; i++)
            {
                if (todosLosMaterialesNecesarios.ElementAt(i).idListaDeMateriales == t.idListaDeMateriales)
                    todosLosMaterialesNecesarios[i] = t;
            }
        }

        public void eliminar(int id)
        {
            for (int i = 0; i < todosLosMaterialesNecesarios.Count; i++)
            {
                if (todosLosMaterialesNecesarios.ElementAt(i).idListaDeMateriales == id)
                    todosLosMaterialesNecesarios.RemoveAt(i);
            }
        }

        public ListaMaterial leerPorId(int id)
        {
            for (int i = 0; i < todosLosMaterialesNecesarios.Count; i++)
            {
                if (todosLosMaterialesNecesarios.ElementAt(i).idListaDeMateriales == id)
                   return todosLosMaterialesNecesarios.ElementAt(i);
            }

            return null;
        }

        public List<ListaMaterial> listarTodos()
        {
            return todosLosMaterialesNecesarios;
        }

        public void registrar(ListaMaterial t)
        {
            t.idListaDeMateriales = IdContador;
            IdContador++;

            todosLosMaterialesNecesarios.Add(t);
        }
    }
}
