using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.vista;
using ProyectoBigonHnos.vista.login;
using System;

namespace ProyectoBigonHnos.controladores
{
    class LoginControlador
    {
        private Login Vista { get; set; }
        private Empleado EmpleadoLogeado { get; set; }

        public void unirVista(Login vista)
        {
            Vista = vista;
        }

        public void iniciarSesion(string legajo, string password)
        {
            foreach (Empleado empleado in Negocio.getNegocio().obtenerTodosEmpleados())
            {
                if (empleado.Legajo == legajo && empleado.Usuario.Password == password)
                {
                    EmpleadoLogeado = empleado;
                    mostrarVistaPrincipal();
                    break;
                }
            }
        }

        private void mostrarVistaPrincipal()
        {
            Vista.Visible = false;
            VistaPrincipal view = new VistaPrincipal(EmpleadoLogeado);
            view.ShowDialog();


            Vista.Dispose();
        }

        public Empleado obtenerEmpleadoLogeado()
        { 
            return EmpleadoLogeado;
        }
    }
}
