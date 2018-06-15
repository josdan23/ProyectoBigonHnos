using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBigonHnos.controladores;
using ProyectoBigonHnos.vista.login;

namespace ProyectoBigonHnos
{
    class Program
    {
        static void Main(string[] args)
        {

            EmpleadoControlador controlador = new EmpleadoControlador();
            controlador.crearEmpleado();
            controlador.agregarUsuario("daniel", "daniel", "admin");
            controlador.confimarEmpleado();

            Login vista = new Login();
            vista.unirControlador(LoginControlador.getInstance());

            Application.EnableVisualStyles();
            Application.Run(vista);

        }
    }
}
