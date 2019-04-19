using ProyectoBigonHnos.data;
using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.vista.usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.controladores
{
    public class CabiarContraseniaControlador
    {
        private CambiarContraseniaView Vista { get; set; }
        private Empleado EmpleadoLogueado { get; set; }

        public CabiarContraseniaControlador(string legajo)
        {
            EmpleadoLogueado = Negocio.getNegocio().buscarEmpleado(legajo);
        }

        public void unirVista(CambiarContraseniaView vista)
        {
            Vista = vista;
        }

        public void establecerContrasenia(String nuevaContrasenia)
        {
            EmpleadoLogueado.Usuario.Password = nuevaContrasenia;
            PersistenciaFacade.getInstance().actualiarObjeto<Empleado>(EmpleadoLogueado);

            
        }

        private bool contraseniaSegura(String password)
        {
            return true;
        }

    }
}
