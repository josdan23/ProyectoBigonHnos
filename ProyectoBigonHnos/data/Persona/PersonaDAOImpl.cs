using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.data.DomicilioDAO;
using ProyectoBigonHnos.data.TelefonoDao;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.Persona
{
    class PersonaDAOImpl : IPersonaDAO
    {
        DBConector db;

        public PersonaDAOImpl()
        {
            db = new DBConector();
        }

        public void actualizar(dominio.Persona t)
        {
            string query = String.Format("update persona set dni = \'{0}\', nombre = \'{1}\', apellido = \'{2}\', telefono_id_telefono = {3}, domicilio_id_domicilio = {4} where id_persona = {5};",
                t.Dni,
                t.Nombre,
                t.Apellido,
                t.Telefonos.ElementAt(0).IdTelefono,
                t.Domicilioes.ElementAt(0).IdDomicilio,
                t.IdPersona);

            db.ejectuarQuery(query);
        }

        public void eliminar(int id)
        {
            int idTelefono = leerPorId(id).Telefonos[0].IdTelefono;
            int idDomicilio = leerPorId(id).Domicilioes[0].IdDomicilio;

            string query = string.Format("delete from persona where id_persona = {0}", id);
            db.consultarQuery(query);

            ITelefonoDao daoTelefono = new TelefonoDAOImpl();
            daoTelefono.eliminar(idTelefono);

            IDomicilioDAO daoDomicilio = new DomicilioDAOImpl();
            daoDomicilio.eliminar(idDomicilio);


        }

        public dominio.Persona leerPorId(int id)
        {
            string query = String.Format("select * from persona where id_persona = {0}", id);

            foreach (List<Object> registro in db.consultarQuery(query))
            {
                return parsePersona(registro);
            }
            return null;
        }

        public List<dominio.Persona> listarTodos()
        {
            string query = String.Format("select * from persona;");

            List<dominio.Persona> todasLasPersonas = new List<dominio.Persona>();

            foreach (List<Object> unRegistro in db.consultarQuery(query))
            {
                todasLasPersonas.Add(parsePersona(unRegistro));
            }

            return todasLasPersonas;
        }

        public void registrar(dominio.Persona t)
        {

            ITelefonoDao daoTelefono = new TelefonoDAOImpl();
            daoTelefono.registrar(t.Telefonos.ElementAt(0));

            List<Telefono> todosLosTelefonos = daoTelefono.listarTodos();
            int idTelefono = todosLosTelefonos[todosLosTelefonos.Count -1 ].IdTelefono;

            IDomicilioDAO daoDomicilio = new DomicilioDAOImpl();
            daoDomicilio.registrar(t.Domicilioes.ElementAt(0));

            List<Domicilio> todosLosDomicilios = daoDomicilio.listarTodos();
            int idDomicilio = todosLosDomicilios[todosLosDomicilios.Count - 1].IdDomicilio;
            
            string query = String.Format("insert into persona (dni, nombre, apellido, telefono_id_telefono, domicilio_id_domicilio) values (\'{0}\', \'{1}\', \'{2}\', {3}, {4});",
                t.Dni,
                t.Nombre,
                t.Apellido,
                idTelefono,
                idDomicilio);

            db.ejectuarQuery(query);
        }

        private dominio.Persona parsePersona (List<Object> registro)
        {
            dominio.Persona nuevaPersona = new dominio.Persona();

            nuevaPersona.IdPersona = (int) registro.ElementAt(0);
            nuevaPersona.Dni = (string) registro.ElementAt(1);
            nuevaPersona.Nombre = (string) registro.ElementAt(2);
            nuevaPersona.Apellido = (string)registro.ElementAt(3);

            int idTelefono = (int)registro.ElementAt(4);
            int idDomicilio = (int)registro.ElementAt(5);

            ITelefonoDao daoTelefono = new TelefonoDAOImpl();
            nuevaPersona.agregarTelefono(daoTelefono.leerPorId(idTelefono));

            IDomicilioDAO daoDomicilio = new DomicilioDAOImpl();
            nuevaPersona.agregarDomicilio(daoDomicilio.leerPorId(idDomicilio));

            return nuevaPersona;
        }
    }
}
