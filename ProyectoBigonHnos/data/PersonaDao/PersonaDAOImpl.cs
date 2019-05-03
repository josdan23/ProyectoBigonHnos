using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoBigonHnos.data.DomicilioDao;
using ProyectoBigonHnos.data.TelefonoDao;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.PersonaDao
{
    class PersonaDAOImpl : IPersonaDAO
    {
        DBConector db;

        public PersonaDAOImpl()
        {
            db = DBConector.getInstance();
        }

        public void actualizar(Persona t)
        {
            string query = String.Format("update persona set dni = \'{0}\', nombre = \'{1}\', apellido = \'{2}\'  where id_persona = {3};",
                t.Dni,
                t.Nombre,
                t.Apellido,
                t.IdPersona);

            IDomicilioDAO dao = new DomicilioDAOImpl();
            dao.actualizar(t.Domicilioes.ElementAt(0));

            ITelefonoDao daoTelefono = new TelefonoDaoImpl();
            daoTelefono.actualizar(t.Telefonos.ElementAt(0));

            db.ejectuarQuery(query);
        }

        public void eliminar(int id)
        {
            int idTelefono = leerPorId(id).Telefonos[0].IdTelefono;
            int idDomicilio = leerPorId(id).Domicilioes[0].IdDomicilio;

            string query = string.Format("delete from persona where id_persona = {0}", id);
            db.consultarQuery(query);

            ITelefonoDao daoTelefono = new TelefonoDaoImpl();
            daoTelefono.eliminar(idTelefono);

            IDomicilioDAO daoDomicilio = new DomicilioDAOImpl();
            daoDomicilio.eliminar(idDomicilio);


        }

        public Persona leerPorId(int id)
        {
            string query = String.Format("select * from persona where id_persona = {0}", id);

            foreach (List<Object> registro in db.consultarQuery(query))
            {
                return parsePersona(registro);
            }
            return null;
        }

        public List<Persona> listarTodos()
        {
            string query = String.Format("select * from persona;");

            List<Persona> todasLasPersonas = new List<Persona>();

            foreach (List<Object> unRegistro in db.consultarQuery(query))
            {
                todasLasPersonas.Add(parsePersona(unRegistro));
            }

            return todasLasPersonas;
        }

        public void registrar(Persona t)
        {

            ITelefonoDao daoTelefono = new TelefonoDaoImpl();
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

        private Persona parsePersona (List<Object> registro)
        {
            Persona nuevaPersona = new Persona();

            nuevaPersona.IdPersona = (int) registro.ElementAt(0);
            nuevaPersona.Dni = (string) registro.ElementAt(1);
            nuevaPersona.Nombre = (string) registro.ElementAt(2);
            nuevaPersona.Apellido = (string)registro.ElementAt(3);

            int idTelefono = (int)registro.ElementAt(4);
            int idDomicilio = (int)registro.ElementAt(5);

            ITelefonoDao daoTelefono = new TelefonoDaoImpl();
            nuevaPersona.agregarTelefono(daoTelefono.leerPorId(idTelefono));

            IDomicilioDAO daoDomicilio = new DomicilioDAOImpl();
            nuevaPersona.agregarDomicilio(daoDomicilio.leerPorId(idDomicilio));

            return nuevaPersona;
        }
    }
}
