using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.ProveedorDao
{
    class ProveedorDaoListImpl : IProveedorDAO
    {
        private static List<Proveedor> todosLosProveedores = new List<Proveedor>();
        private static int IdContador = 0;

        public void actualizar(Proveedor t)
        {
            for (int i = 0; i < todosLosProveedores.Count; i++)
            {
                if (todosLosProveedores.ElementAt(i).IdProveedor == t.IdProveedor)
                    todosLosProveedores[i] = t;
            }
        }

        public void eliminar(int id)
        {
            for (int i = 0; i < todosLosProveedores.Count; i++)
            {
                if (todosLosProveedores.ElementAt(i).IdProveedor == id)
                    todosLosProveedores.RemoveAt(i);
            }
        }

        public Proveedor leerPorId(int id)
        {
            for (int i = 0; i < todosLosProveedores.Count; i++)
            {
                if ( todosLosProveedores.ElementAt(i).IdProveedor == id) 
                    return todosLosProveedores.ElementAt(i);
            }

             return null;
        }

        public List<Proveedor> listarTodos()
        {
            return todosLosProveedores;
        }

        public void registrar(Proveedor t)
        {
            t.IdProveedor = IdContador;
            IdContador++;

            todosLosProveedores.Add(t);
        }
    }
}
