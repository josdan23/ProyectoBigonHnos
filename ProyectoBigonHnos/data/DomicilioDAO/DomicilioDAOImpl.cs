using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoBigonHnos.data.LocalidadDao;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.DomicilioDao
{
    class DomicilioDAOImpl : IDomicilioDAO
    {

        private DBConector db;

        public DomicilioDAOImpl()
        {
            db = DBConector.getInstance();
        }

        public void actualizar(Domicilio t)
        {
            string query = String.Format("update domicilio set calle = \'{0}\', numero = {1}, localidad_id_localidad = {2} where id_domicilio = {3};",
                t.Calle,
                t.Numero,
                t.Localidad.IdLocalidad,
                t.IdDomicilio);

            Console.WriteLine(t.Calle);
            Console.WriteLine(t.Numero);
            Console.WriteLine(t.Localidad.IdLocalidad);
            Console.WriteLine(t.IdDomicilio);

            db.ejectuarQuery(query);
        }

        public void eliminar(int id)
        {
            int idLocalidad = leerPorId(id).Localidad.IdLocalidad;

            string query = String.Format("delete from domicilio where id_domicilio = {0};", id);
            db.ejectuarQuery(query);

            ILocalidadDAO daoLocalidad = new LocalidadDAOImpl();
            daoLocalidad.eliminar(idLocalidad);
        }

        public Domicilio leerPorId(int id)
        {
            string query = String.Format("select * from domicilio where id_domicilio = {0};",id);

            List<List<Object>> todosLosRegistros =  db.consultarQuery(query);

            Domicilio domicilioRegistrado = new Domicilio();
            domicilioRegistrado.IdDomicilio = (int)todosLosRegistros.ElementAt(0).ElementAt(0);
            domicilioRegistrado.Calle = (string)todosLosRegistros.ElementAt(0).ElementAt(1);
            domicilioRegistrado.Numero = (int)todosLosRegistros.ElementAt(0).ElementAt(2);

            int idLocalidad = (int)todosLosRegistros.ElementAt(0).ElementAt(3);

            ILocalidadDAO dao = new LocalidadDAOImpl();
            dominio.Localidad localidad = dao.leerPorId(idLocalidad);

            domicilioRegistrado.Localidad = localidad;

            return domicilioRegistrado;
        }

        public List<Domicilio> listarTodos()
        {
            string query = String.Format("select * from Domicilio;");

            List<Domicilio> todosLosDomicilios = new List<Domicilio>();

            List<List<Object>> todosLosRegistros = db.consultarQuery(query);

            foreach (List<Object> unRegistro in todosLosRegistros)
            {
                todosLosDomicilios.Add(parseDomicilio(unRegistro));
            }

            return todosLosDomicilios;
            
        }

        public void registrar(Domicilio t)
        {
            ILocalidadDAO dao = new LocalidadDAOImpl();
            dao.registrar(t.Localidad);

            List<dominio.Localidad> localidades = dao.listarTodos();

            int idUltimaLocalidadAgregada = localidades[localidades.Count - 1].IdLocalidad;

            string query = String.Format("insert into domicilio (calle, numero, localidad_id_localidad) values (\'{0}\',{1}, {2});", 
                t.Calle,
                t.Numero,
                idUltimaLocalidadAgregada);

            db.ejectuarQuery(query);
        }

        private Domicilio parseDomicilio( List<Object> registro)
        {
            Domicilio domicilio = new Domicilio();
            domicilio.IdDomicilio = (int) registro.ElementAt(0);
            domicilio.Calle = (string) registro.ElementAt(1);
            domicilio.Numero = (int) registro.ElementAt(2);

            int IdLocalidad = (int)registro.ElementAt(3);
            ILocalidadDAO daoLocalidad = new LocalidadDAOImpl();
            domicilio.Localidad = daoLocalidad.leerPorId(IdLocalidad);

            return domicilio;
        }
    }
}
