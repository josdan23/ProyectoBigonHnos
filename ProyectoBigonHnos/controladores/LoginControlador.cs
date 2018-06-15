using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.vista;
using ProyectoBigonHnos.vista.login;
using System;

namespace ProyectoBigonHnos.controladores
{
    class LoginControlador
    {
        static LoginControlador Controlador { get; set; }
        private Login Vista { get; set; }
        private Empleado EmpleadoLogeado { get; set; }

        public static LoginControlador getInstance()
        {
            if (Controlador == null)
                Controlador = new LoginControlador();

            return Controlador;
        }

        public void unirVista(Login vista)
        {
            Vista = vista;
        }

        public void iniciarSesion(string usuario, string password)
        {
            foreach (Empleado empleado in Negocio.getNegocio().empleados)
            {
                if (empleado.Usuario.Username == usuario && empleado.Usuario.Password == password)
                {
                    EmpleadoLogeado = empleado;
                    mostrarVistaPrincipal();
                }
            }
        }

        private void mostrarVistaPrincipal()
        {
            Vista.Visible = false;

            VistaPrincipal view = new VistaPrincipal();
            view.ShowDialog();

            Vista.Dispose();
        }

        public Empleado obtenerEmpleadoLogeado()
        { 
            return EmpleadoLogeado;
        }
    }
}
