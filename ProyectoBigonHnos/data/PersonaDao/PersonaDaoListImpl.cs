using System.Collections.Generic;
using System.Linq;
using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.data.DomicilioDao;
using ProyectoBigonHnos.data.TelefonoDao;

namespace ProyectoBigonHnos.data.PersonaDao
{
    class PersonaDaoListImpl : IPersonaDAO
    {
        private static List<Persona> todasLasPersonas = new List<Persona>();
        private static int IdContador = 0;

        public void actualizar(Persona t)
        {
            for (int i = 0; i < todasLasPersonas.Count; i++)
            {
                if (todasLasPersonas.ElementAt(i).IdPersona == t.IdPersona)
                    todasLasPersonas[i] = t;
            }

        }

        public void eliminar(int id)
        {
            for (int i = 0; i < todasLasPersonas.Count; i++)
            {
                if (todasLasPersonas.ElementAt(i).IdPersona == id)
                    todasLasPersonas.RemoveAt(i);
            }

        }

        public Persona leerPorId(int id)
        {
            for ( int i = 0; i < todasLasPersonas.Count; i++)
            {
                if (todasLasPersonas.ElementAt(i).IdPersona == id)
                    return todasLasPersonas.ElementAt(i);
            }

            return null;
        }

        public List<Persona> listarTodos()
        {
            return todasLasPersonas;
        }

        public void registrar(Persona t)
        {
            IDomicilioDAO daoDomicilio = new DomicilioDaoListImpl();
            daoDomicilio.registrar(t.Domicilioes[0]);

            ITelefonoDao daoTelefono = new TelefonoDaoListImpl();
            daoTelefono.registrar(t.Telefonos[0]);

            //t.Telefonos[0].IdTelefono = daoTelefono.listarTodos().Last<Telefono>().IdTelefono;
            //t.Domicilioes[0].IdDomicilio = daoDomicilio.listarTodos().Last<Domicilio>().IdDomicilio;

            t.IdPersona = IdContador;
            IdContador++;

            todasLasPersonas.Add(t);

            
            
        }
    }
}
