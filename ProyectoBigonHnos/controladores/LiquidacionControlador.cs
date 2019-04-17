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

using System;
using System.Collections.Generic;
using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.dominio.liquidacion;
using ProyectoBigonHnos.data;
using ProyectoBigonHnos.vista.liquidacion;

namespace ProyectoBigonHnos.controladores
{
    public class LiquidacionControlador
    {
        Liquidacion liquidacion;
        Empleado empleado;

        private ILiquidacionView vista { get; set; }


        public void iniciarLiquidacion()
        {
            liquidacion = new Liquidacion();
            //cargarConceptosObligatorios();
        }

        public void unirVista(ILiquidacionView vista)
        {
            this.vista = vista;
        }

        public void buscarEmpleado(string legajo)
        {
            
            empleado = Negocio.getNegocio().buscarEmpleado(legajo);

            if (empleado != null)
            {
                liquidacion.Empleado = empleado;

                vista.mostrarDatosEmpleado(empleado.IdEmpleado, empleado.Legajo, empleado.Categoria, empleado.Cuil, empleado.FechaIngreso);

                foreach (GrupoFamiliar familiar in empleado.Familiares)
                {
                    vista.mostrarFamiliar(
                        familiar.IdGrupoFamiliar,
                        familiar.Dni,
                        familiar.Parentesco,
                        familiar.FechaNacimiento,
                        familiar.Discapacidad);
                }
            }

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

            int index = liquidacion.LineasLiquidacion.Count;

            double resultado = liquidacion.LineasLiquidacion[index - 1].getImporte();

            switch (concepto.Tipo)
            {
                case TipoConcepto.REMUNERATIVO:
                    vista.mostrarLiquidacion(concepto.Descripcion, concepto.Porcentaje, resultado, 0.0, 0.0);
                    break;
                case TipoConcepto.NO_REMUNERATIVO:
                    vista.mostrarLiquidacion(concepto.Descripcion, concepto.Porcentaje, 0.0, resultado, 0.0);
                    break;
                case TipoConcepto.DESCUENTO:
                    vista.mostrarLiquidacion(concepto.Descripcion, concepto.Porcentaje, 0.0, 0.0, resultado);
                    break;
            }

            vista.mostrarTotal(liquidacion.GetImporteTotal());
            vista.mostrarTotalRemunerativo(liquidacion.getTotalRemunerativo());
            vista.mostrarTotalNoRemunerativo(liquidacion.getTotalNoRemunerativo());
            vista.mostrarTotalDescuento(liquidacion.getTotalDescuento());
        }

        internal void mostrarDetalleLiquidacion(int idLiquidacion)
        {
            Liquidacion liquidacion = PersistenciaFacade.getInstance().obtenerObjeto<Liquidacion>(idLiquidacion);

            vista.mostrarDatosEmpleado(
                liquidacion.Empleado.IdEmpleado,
                liquidacion.Empleado.Legajo,
                liquidacion.Empleado.Categoria,
                liquidacion.Empleado.Cuil,
                liquidacion.Empleado.FechaIngreso);

            vista.mostrarTotalRemunerativo(liquidacion.getTotalRemunerativo());
            vista.mostrarTotalNoRemunerativo(liquidacion.getTotalNoRemunerativo());
            vista.mostrarTotalDescuento(liquidacion.getTotalDescuento());

            ((DetalleLiquidacionView)vista).mostrarInfoEmpleado(
                liquidacion.Empleado.Nombre,
                liquidacion.Empleado.Apellido);

            foreach(LineaLiquidacion lq in liquidacion.LineasLiquidacion)
            {
                if (lq.Concepto.Tipo == TipoConcepto.REMUNERATIVO)
                {
                    vista.mostrarLiquidacion(lq.Concepto.Descripcion, lq.Cantidad, lq.getImporte(), 0, 0);
                }
                else if (lq.Concepto.Tipo == TipoConcepto.NO_REMUNERATIVO)
                {
                    vista.mostrarLiquidacion(lq.Concepto.Descripcion, lq.Cantidad, 0, lq.getImporte(), 0);
                }
                else
                    vista.mostrarLiquidacion(lq.Concepto.Descripcion, lq.Cantidad,0 ,0 ,lq.getImporte());
            }
        }

        internal void filtrarLiquidacionPorPeriodo(MesesItemCombobox selectedItem)
        {
            List<Liquidacion> todasLasLiquidaciones = PersistenciaFacade.getInstance().obtenerTodos<Liquidacion>();

            foreach (Liquidacion unaLiquidacion in todasLasLiquidaciones)
            {
                if (selectedItem.numero == unaLiquidacion.PeriodoLiquidacion)
                {
                    ((LiquidacionPanelView)vista).listarLiquidacion(
                    unaLiquidacion.PeriodoLiquidacion.ToString(),
                    unaLiquidacion.Empleado.Legajo,
                    unaLiquidacion.Empleado.Apellido,
                    unaLiquidacion.Empleado.Nombre,
                    unaLiquidacion.IdLiquidacion);
                }
                
            }
        }

        public void confimarLiquidacion()
        { 
            liquidacion.Imprimir();
            PersistenciaFacade.getInstance().registrarObjeto(liquidacion);
            vista.cerrar();
        }

        private void cargarConceptosObligatorios()
        {
            foreach (Concepto concepto in Negocio.getNegocio().obtenerTodosConceptos())
            {
                if (concepto.Obligatorio)
                {
                    agregarLineaLiquidacion(concepto.IdConcepto, 1, 2000);
                }
            }
        }

        internal void cancelarLiquidacion()
        {
            liquidacion = null;
            vista.cerrar();
        }

        public void listarConceptos()
        {
            List<Concepto> conceptos = PersistenciaFacade.getInstance().obtenerTodos<Concepto>();

            Dictionary<int, string> conceptosDictionary = new Dictionary<int, string>();

            foreach (Concepto conc in conceptos)
            {
                conceptosDictionary.Add(conc.IdConcepto, conc.Descripcion);
            }

            vista.agregarConceptosALista(conceptosDictionary);
        }

        internal void eliminarLineaLiquidacion(int index)
        {
            liquidacion.LineasLiquidacion.RemoveAt(index);

            vista.mostrarTotalRemunerativo(liquidacion.getTotalRemunerativo());
            vista.mostrarTotalNoRemunerativo(liquidacion.getTotalNoRemunerativo());
            vista.mostrarTotalDescuento(liquidacion.getTotalDescuento());
            vista.mostrarTotal(liquidacion.GetImporteTotal());
        }

        public void motrarLiquidaciones()
        {
            List<Liquidacion> todasLasLiquidaciones = PersistenciaFacade.getInstance().obtenerTodos<Liquidacion>();

            foreach (Liquidacion unaLiquidacion in todasLasLiquidaciones)
            {
                ((LiquidacionPanelView)vista).listarLiquidacion(
                    unaLiquidacion.PeriodoLiquidacion.ToString(),
                    unaLiquidacion.Empleado.Legajo,
                    unaLiquidacion.Empleado.Apellido,
                    unaLiquidacion.Empleado.Nombre,
                    unaLiquidacion.IdLiquidacion);
            }
        }
    }
}