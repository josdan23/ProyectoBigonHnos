using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.ProveedorDao
{
    class ProveedorDAOImpl : IProveedorDAO
    {

        private DBConector con;

        //actua como base de datos
        List<dominio.Proveedor> listaProveedoresDB;

        public ProveedorDAOImpl()
        {
            listaProveedoresDB = new List<dominio.Proveedor>();
            con = DBConector.getInstance();
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
