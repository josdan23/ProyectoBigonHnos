using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.data.PersonaDao;
using ProyectoBigonHnos.data.UsuarioDao;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.EmpleadoDao
{
    class EmpleadoDaoImpl : IEmpleadoDAO
    {

        DBConector db;

        public EmpleadoDaoImpl()
        {
            db = DBConector.getInstance();
        }
        public void actualizar(Empleado t)
        {

            IPersonaDAO personaDao = new PersonaDaoImpl();
            personaDao.actualizar(t);

            IUsuarioDAO usuarioDao = new UsuarioDaoImpl();
            usuarioDao.actualizar(t.Usuario);
            Console.WriteLine("fechaEgreso: "+t.FechaEgreso.ToShortDateString());
            
            string query = String.Format("update empleado set legajo = \'{0}\', fecha_ingreso=\'{1}\', fecha_egreso=\'{2}\', categoria = \'{3}\', cuil=\'{4}\', persona_id_persona={5}, usuario_id_usuario={6} where id_empleado={7};",
                t.Legajo,
                t.FechaIngreso.ToShortDateString(),
                t.FechaEgreso.ToShortDateString(),
                t.Categoria,
                t.Cuil,
                t.IdPersona,
                t.Usuario.IdUsuario,
                t.IdEmpleado);
                

            db.ejectuarQuery(query);
        }

        public void eliminar(int id)
        {
            string query = String.Format("delete from empleado where id_empleado = {0}", id);

            int idPersona = leerPorId(id).IdPersona;
            int idUsuario = leerPorId(id).Usuario.IdUsuario;

            db.borrarRegistro(query);

            IPersonaDAO personaDao = new PersonaDaoImpl();
            personaDao.eliminar(idPersona);

            IUsuarioDAO usuarioDao = new UsuarioDaoImpl();
            usuarioDao.eliminar(idUsuario);

        }

        public Empleado leerPorId(int id)
        {
            String query = String.Format("select * from empleado where id_empleado = {0}", id);

            foreach (List<Object> unRegistro in db.consultarQuery(query))
            {
                return parse(unRegistro);
            }

            return null;
        }

        public List<Empleado> listarTodos()
        {
            String query = String.Format("select * from empleado");

            List<Empleado> empleadosRegistrados = new List<Empleado>();

            foreach(List<Object> unRegistro in db.consultarQuery(query))
            {
                empleadosRegistrados.Add(parse(unRegistro));
            }

            return empleadosRegistrados;
        }

        public void registrar(Empleado t)
        {
            IPersonaDAO personaDao = new PersonaDaoImpl();
            personaDao.registrar(t);
            int idPersona = personaDao.listarTodos().Last().IdPersona;

            IUsuarioDAO usuarioDao = new UsuarioDaoImpl();
            usuarioDao.registrar(t.Usuario);
            int idUsuario = usuarioDao.listarTodos().Last().IdUsuario;

            String query = String.Format("insert into empleado (legajo, fecha_ingreso, categoria, cuil, persona_id_persona, usuario_id_usuario) values (\'{0}\', \'{1}\',\'{2}\',\'{3}\', {4}, {5});",
                t.Legajo,
                t.FechaIngreso.ToShortDateString(),
                t.Categoria,
                t.Cuil,
                idPersona,
                idUsuario);

            db.ejectuarQuery(query);


            //faltan registrar los familiares
        }

        private Empleado parse(List<Object> unRegistro)
        {
            int idPersona = (int)unRegistro.ElementAt(6);
            IPersonaDAO personaDao = new PersonaDaoImpl();
            Persona persona = personaDao.leerPorId(idPersona);
            
            string nombre = persona.Nombre;
            string apellido = persona.Apellido;
            string dni = persona.Dni;

            /*
            int idTelefono = persona.Telefonos[0].IdTelefono;
            string numeroTelefono = persona.Telefonos[0].Numero;
            */
            Telefono telefono = persona.Telefonos[0];

            /*
            int idDomicilio = persona.Domicilioes[0].IdDomicilio;
            string calle = persona.Domicilioes[0].Calle;
            int numeroDomicilio = persona.Domicilioes[0].Numero;

            int idLocalidad = persona.Domicilioes[0].Localidad.IdLocalidad;
            string nombreLocalidad = persona.Domicilioes[0].Localidad.Nombre;

            int idProvincia = persona.Domicilioes[0].Localidad.Provincia.IdProvincia;
            string nombreProvincia = persona.Domicilioes[0].Localidad.Provincia.Nombre;
            */

            Domicilio domicilio = persona.Domicilioes[0];

            int idEmpleado = (int)unRegistro.ElementAt(0);
            string legajo = (string)unRegistro.ElementAt(1);
            string categoria = (string)unRegistro.ElementAt(4);
            string cuil = (string)unRegistro.ElementAt(5);

            DateTime fechaIngreso = DateTime.Parse(unRegistro.ElementAt(2).ToString());
            //string fechaEgresoString = (string)unRegistro.ElementAt(3);
            DateTime fechaEgreso;
            if (!(unRegistro.ElementAt(3) is DBNull))
                fechaEgreso = DateTime.Parse(unRegistro.ElementAt(3).ToString());
            else
                fechaEgreso = DateTime.MinValue;

            int idUsuario = (int)unRegistro.ElementAt(7);
            IUsuarioDAO usuarioDao = new UsuarioDaoImpl();
            Usuario usuario = usuarioDao.leerPorId(idUsuario);

            string password = usuario.Password;
            bool admin = usuario.Administrador;
            bool activo = usuario.Activo;

            Empleado empleado = new Empleado(nombre, apellido, dni, categoria, cuil, password, admin, fechaIngreso);
            empleado.Usuario.IdUsuario = idUsuario;
            empleado.IdPersona = idPersona;
            empleado.Legajo = legajo;
            empleado.FechaEgreso = fechaEgreso;
            empleado.Telefonos.Add(telefono);
            empleado.Domicilioes.Add(domicilio);
            empleado.IdEmpleado = idEmpleado;
            //faltan crear los familiares

            return empleado;
        }
    }
}
