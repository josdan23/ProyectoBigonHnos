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
    class EmpleadoDaoImplList : IEmpleadoDAO
    {

        private static List<Empleado> todosLosEmpleados = new List<Empleado>();
        private static int IdContador = 0;

        public void actualizar(Empleado t)
        {
            for (int i = 0; i < todosLosEmpleados.Count; i++)
            {
                if (todosLosEmpleados.ElementAt(i).IdEmpleado == t.IdEmpleado)
                {
                    todosLosEmpleados[i] = t;
                }
            }
        }

        public void eliminar(int id)
        {
            for (int i = 0; i < todosLosEmpleados.Count; i++)
            {
                if (todosLosEmpleados.ElementAt(i).IdEmpleado == id)
                    todosLosEmpleados.RemoveAt(i);
            }
        }

        public Empleado leerPorId(int id)
        {
            for (int i = 0; i < todosLosEmpleados.Count; i++)
            {
                if ( todosLosEmpleados.ElementAt(i).IdEmpleado == id)
                {
                    return todosLosEmpleados.ElementAt(i);
                }
            }
            return null;
        }

        public List<Empleado> listarTodos()
        {
            return todosLosEmpleados;
        }

        public void registrar(Empleado t)
        {
            t.IdEmpleado = IdContador;

            IdContador++;

            todosLosEmpleados.Add(t);

        }
    }
}
