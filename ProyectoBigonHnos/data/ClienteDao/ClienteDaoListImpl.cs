using System.Collections.Generic;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.ClienteDao
{
    class ClienteDaoListImpl : IClienteDAO
    {
        static private List<Cliente> Clientes = new List<Cliente>();
        static int id = 0;

        public void actualizar(Cliente t)
        {
            for (int i = 0; i < Clientes.Count; i++)
            {
                if (Clientes[i].IdCliente == t.IdCliente)
                    Clientes[i] = t;
            }
        }

        public void eliminar(int id)
        {
            for (int i = 0; i < Clientes.Count; i++)
            {
                if (Clientes[i].IdCliente == id)
                    Clientes.RemoveAt(i);
            }
        }

        public Cliente leerPorId(int id)
        {

            for (int i = 0; i < Clientes.Count; i++)
            {
                if (Clientes[i].IdCliente == id)
                    return Clientes[i];
            }

            return null;
        }

        public List<Cliente> listarTodos()
        {
            return Clientes;
        }

        public void registrar(Cliente t)
        {
            id++;
            t.IdCliente = id;
            Clientes.Add(t);
        }
    }
}
