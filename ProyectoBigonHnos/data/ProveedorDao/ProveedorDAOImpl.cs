using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.data.DomicilioDao;
using ProyectoBigonHnos.data.TelefonoDao;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.ProveedorDao
{
    class ProveedorDaoImpl : IProveedorDAO
    {

        private DBConector con;

        public ProveedorDaoImpl()
        {
            con = DBConector.getInstance();
        }

        public void actualizar(Proveedor t)
        {
            IDomicilioDAO domicilioDao = new DomicilioDaoImpl();
            domicilioDao.actualizar(t.Domicilios[0]);

            ITelefonoDao telefonoDao = new TelefonoDaoImpl();
            telefonoDao.actualizar(t.Telefonos[0]);

            String query = String.Format("update proveedor set razon_social= \'{0}\', cuil=\'{1}\' where id_proveedor = {2};",
                t.RazonSocial,
                t.Cuit,
                t.IdProveedor);
            con.ejectuarQuery(query);
        }

        public void eliminar(int id)
        {
            IDomicilioDAO daoDomicilio = new DomicilioDaoImpl();
            int idDomicilio = leerPorId(id).Domicilios[0].IdDomicilio;
            

            ITelefonoDao telefonoDao = new TelefonoDaoImpl();
            int idTelefono = leerPorId(id).Telefonos[0].IdTelefono;

            string query = string.Format("delete from proveedor where id_proveedor = {0}", id);
            con.borrarRegistro(query);

            daoDomicilio.eliminar(idDomicilio);
            telefonoDao.eliminar(idTelefono);
        }

        public Proveedor leerPorId(int id)
        {
            String query = String.Format("select * from proveedor where id_proveedor = {0}", id);

            foreach(List<Object> unRegistro in con.consultarQuery(query))
            {
                return parse(unRegistro);
            }
            return null;
        }

        public List<Proveedor> listarTodos()
        {
            string query = string.Format("select * from proveedor");

            List<Proveedor> proveedoresRegistrados = new List<Proveedor>();

            foreach(List<Object> unRegistro in con.consultarQuery(query))
            {
                proveedoresRegistrados.Add(parse(unRegistro));
            }

            return proveedoresRegistrados;
        }

        public void registrar(Proveedor t)
        {
            IDomicilioDAO domicilioDao = new DomicilioDaoImpl();
            domicilioDao.registrar(t.Domicilios[0]);
            int idDomicilio = domicilioDao.listarTodos().Last().IdDomicilio;

            ITelefonoDao telefonoDao = new TelefonoDaoImpl();
            telefonoDao.registrar(t.Telefonos[0]);
            int idTelefono = telefonoDao.listarTodos().Last().IdTelefono;

            String query = String.Format("insert into proveedor (razon_social, cuil, domicilio_id_domicilio, telefono_id_telefono) values (\'{0}\',\'{1}\',{2},{3});",
                t.RazonSocial,
                t.Cuit,
                idDomicilio,
                idTelefono);

            con.ejectuarQuery(query);
        }

        private Proveedor parse(List<Object> unRegistro)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.IdProveedor = (int)unRegistro.ElementAt(0);
            proveedor.RazonSocial = (string)unRegistro.ElementAt(1);
            proveedor.Cuit = (string)unRegistro.ElementAt(2);

            IDomicilioDAO daoDomicilio = new DomicilioDaoImpl();
            int idDomicilio = (int)unRegistro.ElementAt(3);
            Domicilio domicilio = daoDomicilio.leerPorId(idDomicilio);

            ITelefonoDao daoTelefono = new TelefonoDaoImpl();
            int idTelefono = (int)unRegistro.ElementAt(4);
            Telefono telefono = daoTelefono.leerPorId(idTelefono);

            proveedor.Domicilios.Add(domicilio);
            proveedor.Telefonos.Add(telefono);

            return proveedor;
        }
    }
}
