﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.data.PersonaDao;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.ClienteDao
{
    class ClienteDaoImpl : IClienteDAO
    {

        public DBConector db;

        public ClienteDaoImpl()
        {
            db = DBConector.getInstance();
        }

        public void actualizar(dominio.Cliente t)
        {
            IPersonaDAO daoPersona = new PersonaDaoImpl();
            daoPersona.actualizar(t);
        }

        public void eliminar(int id)
        {

            IPersonaDAO personaDao = new PersonaDaoImpl();

            int idPersona = leerPorId(id).IdPersona;


            string query = string.Format("delete cliente where id_cliente = {0}", id);
            db.ejectuarQuery(query);

            personaDao.eliminar(idPersona);
        }

        public dominio.Cliente leerPorId(int id)
        {
            /*
            string query = string.Format("select * from cliente, persona, domicilio, telefono, localidad, provincia " +
                "where persona_id_persona = id_persona and" +
                " telefono_id_telefono = id_telefono " +
                "and domicilio_id_domicilio = id_domicilio " +
                "and localidad_id_localidad = id_localidad " +
                "and provincia_id_provincia = id_provincia " +
                "and id_cliente = {0};", id);*/

            string query = string.Format("select * from cliente where id_cliente = {0};", id);

            foreach (List<Object> unRegistro in db.consultarQuery(query))
            {
                Cliente cliente = parseCliente(unRegistro);
                return cliente;
            }

            return null;
        }

        public List<dominio.Cliente> listarTodos()
        {
            /*
            string query = string.Format("select * from cliente, persona, domicilio, telefono " +
                "where persona_id_persona = id_persona " +
                "and telefono_id_telefono = id_telefono " +
 
            string query = string.Format("select * from cliente, persona, domicilio, telefono, localidad, provincia " +
                        "select * from cliente, persona, domicilio, telefono, localidad, provincia " +
                "where persona_id_persona = id_persona and" +
                " telefono_id_telefono = id_telefono " +
                "and domicilio_id_domicilio = id_domicilio " +
                "and localidad_id_localidad = id_localidad " +
                "and provincia_id_provincia = id_provincia ");
                               "and domicilio_id_domicilio = id_domicilio");
*/
            String query = string.Format("select * from cliente");
            List<List<Object>> todosLosRegistros = db.consultarQuery(query);

            List<dominio.Cliente> todosLosClientes = new List<dominio.Cliente>();
            foreach (List<Object> registro in todosLosRegistros)
            {
                todosLosClientes.Add(parseCliente(registro));
            }
            return todosLosClientes;
        }

        public void registrar(dominio.Cliente t)
        {
            IPersonaDAO dao = new PersonaDaoImpl();
            dao.registrar(t);

            List<dominio.Persona> todasLasPersonas = dao.listarTodos();

            int idPersona = todasLasPersonas[todasLasPersonas.Count() - 1].IdPersona;

            string query = string.Format("insert into cliente (persona_id_persona) values ({0});",idPersona);

            db.ejectuarQuery(query);
        }

        private dominio.Cliente parseCliente(List<Object> registro)
        {
            int idCliente = (int) registro.ElementAt(0);
            int idPersona = (int)registro.ElementAt(1);

            IPersonaDAO personaDAO = new PersonaDaoImpl();
            Persona persona = personaDAO.leerPorId(idPersona);

            /*
            string dni = (string)registro.ElementAt(3);
            string nombre = (string)registro.ElementAt(4);
            string apellido = (string)registro.ElementAt(5);
            int idDomicilio = (int)registro.ElementAt(8);
            string calle = (string)registro.ElementAt(9);
            int numero = (int)registro.ElementAt(10);
            int idLocalidad = (int)registro.ElementAt(14);
            string localidad = (string)registro.ElementAt(15);
            int idProvincia = (int)registro.ElementAt(17);
            string nombreProvincia = (string)registro.ElementAt(18);
            int idTelefono = (int)registro.ElementAt(12);
            string numeroTelefono = (string)registro.ElementAt(13);
            */

            //dominio.Domicilio domicilio = new Domicilio(calle, numero, localidad, nombreProvincia);
            Domicilio domicilio = persona.Domicilioes[0];
            //domicilio.IdDomicilio = idDomicilio;

            //domicilio.Localidad.IdLocalidad = idLocalidad;

            // domicilio.Localidad.Provincia.IdProvincia = idProvincia;

            //dominio.Telefono telefono = new Telefono(numeroTelefono);
            Telefono telefono = persona.Telefonos[0];
           // telefono.IdTelefono = idTelefono;

            dominio.Cliente cliente = new dominio.Cliente(persona.Nombre, persona.Apellido, persona.Dni);
            cliente.agregarDomicilio(domicilio);
            cliente.agregarTelefono(telefono);
            cliente.IdCliente = idCliente;

            cliente.IdPersona = idPersona;
           

            return cliente;
        }
    }
}
