/*CASO DE USO: LIQUIDAR
    0. El usuario inicia una nueva liquidacion.
    1. El usuario ingresa el dni del empleado a liquidar.
    2. El sistema muestra la información personal del empleado, y el grupo familiar.
    3. El usuario ingresa el periodo a liquidar y el lugar de pago
    5. El usuario agrega concepto, cantidad y valor base.
    6. El sistema muestra la descripcion del concepto, tipo de concepto, el porcentaje y el sub importe.
    *. Se repite hasta que se indique.
    8. El sistema presenta el total remunerativo, total no remunerativo y descuento.
    9. El usuario confirma la liqudacion.
    10. El sistema registra la nueva liquidacion.
*/

using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.dominio.liquidacion;
using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.controladores
{
    class LiquidacionControlador
    {
        Liquidacion liquidacion;
        Empleado empleado;

        public void iniciarLiquidacion()
        {
            liquidacion = new Liquidacion();
            //cargarConceptosObligatorios();
        }

        public void buscarEmpleado(string legajo)
        {
            empleado = Negocio.getNegocio().buscarEmpleado(legajo);
            liquidacion.Empleado = empleado;
        }

        public void agregarPeriodo(int periodo)
        {
            liquidacion.PeriodoLiquidacion = periodo;
        }

        public void agregarLugarPago(string lugarPago)
        {
            liquidacion.LugarPago = lugarPago;
        }

        public void agregarLineaLiquidacion(int idConcepto, int cantidad, double valorBase)
        {
            Concepto concepto = Negocio.getNegocio().buscarConcepto(idConcepto);
            liquidacion.agregarLineaLiquidacion(cantidad, concepto, valorBase);
        }

        public void confimarLiquidacion()
        {
            //se guarda la liquidacion en la base de datos.
            liquidacion.Imprimir();
        }

        private void cargarConceptosObligatorios()
        {
            foreach ( Concepto concepto in Negocio.getNegocio().obtenerTodosConceptos())
            {
                if (concepto.Obligatorio)
                {
                    agregarLineaLiquidacion(concepto.IdConcepto, 1, 2000);
                }
            }
        }
    }
}