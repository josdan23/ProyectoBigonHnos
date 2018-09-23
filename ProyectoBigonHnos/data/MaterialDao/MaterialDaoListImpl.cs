using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.MaterialDao
{
    class MaterialDaoListImpl : IMaterialDao
    {
        private static List<Material> todosLosMateriales = new List<Material>();
        private static int IdContador = 0;

        public void actualizar(Material t)
        {
            for ( int i = 0; i < todosLosMateriales.Count; i++)
            {
                if (todosLosMateriales.ElementAt(i).IdMaterial == t.IdMaterial)
                    todosLosMateriales[i] = t;
            }
        }

        public void eliminar(int id)
        {
            for( int i = 0; i < todosLosMateriales.Count; i++)
            {
                if (todosLosMateriales.ElementAt(i).IdMaterial == id)
                    todosLosMateriales.RemoveAt(i);
            }
        }

        public Material leerPorId(int id)
        {
            for (int i = 0; i < todosLosMateriales.Count; i++)
            {
                if (todosLosMateriales.ElementAt(i).IdMaterial == id)
                    return todosLosMateriales.ElementAt(i);
            }

            return null;
        }

        public List<Material> listarTodos()
        {
            return todosLosMateriales;
        }

        public void registrar(Material t)
        {
            t.IdMaterial = IdContador;
            IdContador++;

            todosLosMateriales.Add(t);
        }
    }
}
