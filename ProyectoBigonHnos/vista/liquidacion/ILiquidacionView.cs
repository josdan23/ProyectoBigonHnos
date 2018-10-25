using ProyectoBigonHnos.controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.vista.liquidacion
{
    public interface ILiquidacionView
    {
        void UnirControlador(LiquidacionControlador controlador);

        void ActualizarVista();

        void limpiar();

        void mostrarFamiliar(int idFamiliar, string dni, string parentesco, DateTime fechaNac, bool discapacidad);

        void mostrarLiquidacion(string concepto, double valor, double remunerativo, double noRemunerativo, double descuento);

        void mostrarDatosEmpleado(int idEmpleado, string legajo, string categoria, string cuil, DateTime fechaIngreso);

        void mostrarTotal(double total);

        void mostrarTotalRemunerativo(double totalRemunerativo);

        void mostrarTotalNoRemunerativo(double totalNoRemunerativo);

        void mostrarTotalDescuento(double totalDescuento);

        void agregarConceptosALista(Dictionary<int, String> conceptos);

        void cerrar();


    }
}
