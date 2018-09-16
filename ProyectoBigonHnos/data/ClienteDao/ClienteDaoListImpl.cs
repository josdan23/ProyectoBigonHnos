using ProyectoBigonHnos.data.Cliente;
using System;
using System.Collections.Generic;

namespace ProyectoBigonHnos.data.ClienteDao
{
    class ClienteDaoListImpl : IClienteDAO
    {
        static private List<dominio.Cliente> Clientes = new List<dominio.Cliente>();
        static int id = 0;

        public void actualizar(dominio.Cliente t)
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

        public dominio.Cliente leerPorId(int id)
        {

            for (int i = 0; i < Clientes.Count; i++)
            {
                if (Clientes[i].IdCliente == id)
                    return Clientes[i];
            }

            return null;
        }

        public List<dominio.Cliente> listarTodos()
        {
            return Clientes;
        }

        public void registrar(dominio.Cliente t)
        {
            id++;
            t.IdCliente = id;
            Clientes.Add(t);
        }
    }
}
