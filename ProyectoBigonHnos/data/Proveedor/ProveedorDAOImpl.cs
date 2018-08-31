﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.Proveedor
{
    class ProveedorDAOImpl : ProveedorDAO
    {
        //actua como base de datos
        List<dominio.Proveedor> listaProveedoresDB;

        public ProveedorDAOImpl()
        {
            listaProveedoresDB = new List<dominio.Proveedor>();
        }

        public void actualizar(dominio.Proveedor t)
        {
            throw new NotImplementedException();
        }

        public void eliminar(int id)
        {
            foreach (dominio.Proveedor prov in listaProveedoresDB)
            {
                if (prov.IdProveedor == id)
                    listaProveedoresDB.Remove(prov);
            }
        }

        public dominio.Proveedor leerPorId(int id)
        {
            foreach(dominio.Proveedor proveedor in listaProveedoresDB)
            {
                if (proveedor.IdProveedor == id)
                    return proveedor;
            }
            return null;
        }

        public List<dominio.Proveedor> listarTodos()
        {
            return listaProveedoresDB;
        }

        public void registrar(dominio.Proveedor t)
        {
            listaProveedoresDB.Add(t);
        }
    }
}
