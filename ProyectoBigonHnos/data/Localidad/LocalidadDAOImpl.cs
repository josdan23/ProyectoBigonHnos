using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.Localidad
{
    class LocalidadDAOImpl : ILocalidadDAO
    {
        private DBConector db;

        public LocalidadDAOImpl()
        {
            db = DBConector.getInstance();
        }

        public void actualizar(dominio.Localidad t)
        {
            throw new NotImplementedException();
        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public dominio.Localidad leerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<dominio.Localidad> listarTodos()
        {
            throw new NotImplementedException();
        }

        public void registrar(dominio.Localidad t)
        {
            string query = String.Format("insert into Localidad (nombre, domicilio_id_domicilio) values (\'{0}\', {1});",
                t.Nombre);
        }
    }
}
