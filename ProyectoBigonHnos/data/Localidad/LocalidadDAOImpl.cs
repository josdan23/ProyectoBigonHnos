using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.data.ProvinciaDAO;
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
            string query = string.Format("update localidad set nombre = \'{0}\', provincia_id_provincia = {1} where id_localidad = {2};",
                t.Nombre,
                t.Provincia.IdProvincia,
                t.IdLocalidad);

            db.ejectuarQuery(query);
        }

        public void eliminar(int id)
        {
            int idProvincia = leerPorId(id).Provincia.IdProvincia;
            

            string query = string.Format("delete from localidad where id_localidad = {0};", id);
            db.borrarRegistro(query);

            IProvinciaDAO dao = new ProvinciaDAOImpl();
            dao.eliminar(idProvincia);

        }

        public dominio.Localidad leerPorId(int id)
        {
            string query = string.Format("select * from localidad where id_localidad = {0};", id);

            List<List<Object>> registros = db.consultarQuery(query);

            IProvinciaDAO daoProvincia = new ProvinciaDAOImpl();

            foreach ( List<Object> registroLocalidad in registros)
            {
                return parseLocalidad(registroLocalidad);
            }
            return null;
        }

        public List<dominio.Localidad> listarTodos()
        {
            string query = String.Format("select * from localidad");

            List<dominio.Localidad> todasLasLocalidades = new List<dominio.Localidad>();

            foreach ( List<Object> registro in db.consultarQuery(query))
            {
                todasLasLocalidades.Add(parseLocalidad(registro));
            }

            return todasLasLocalidades;
        }

        public void registrar(dominio.Localidad t)
        {
            IProvinciaDAO daoProvincia = new ProvinciaDAOImpl();
            daoProvincia.registrar(t.Provincia);

            List<Provincia> provincias = daoProvincia.listarTodos();

            int idUltimaProvinciaAgregada = provincias[provincias.Count - 1].IdProvincia;

            string query = string.Format("insert into localidad (nombre, provincia_id_provincia) values (\'{0}\', {1});",
                t.Nombre,
                idUltimaProvinciaAgregada);

            db.ejectuarQuery(query);
        }

        private dominio.Localidad parseLocalidad(List<Object> registro)
        {
            dominio.Localidad localidadRecuperada = new dominio.Localidad();
            localidadRecuperada.IdLocalidad = (int) registro.ElementAt(0);
            localidadRecuperada.Nombre = (string) registro.ElementAt(1);

            int idProvincia = (int)registro.ElementAt(2);

            IProvinciaDAO daoProvincia = new ProvinciaDAOImpl();
            Provincia provinciaRecuperada = daoProvincia.leerPorId(idProvincia);
            localidadRecuperada.Provincia = provinciaRecuperada;

            return localidadRecuperada;
        }
    }
}
