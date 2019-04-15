using ProyectoBigonHnos.dominio.pedido;
using System;
using System.Collections.Generic;


namespace ProyectoBigonHnos.dominio.venta
{
    public class Venta
    {
        private static int contador = 0;

        public  int IdVenta { get; set; }
        public DateTime fechaDeVenta { get; set; }
        public string estado { get; set; }
        public double iva { get; set; }
        public double precio {get; set;}
        public string tipoFactura { get; set; }
        public double interes { get; set; }
        public int nroCuotas { get; set; }

        public Empleado Empleado { get; set; }

        public Cliente Cliente { get; set; }

        public List<LineaVenta> lineasDeVenta { get; set; }
        public Pedido pedido { get; set; }
        public Pago pago { get; set; }
        public List<ListaDeMateriales> materialesNecesarios { get; set; }
        public List<CostoExtra> costosExtras { get; set; }

        public Venta()
        {
            IdVenta = contador;
            contador++;

            fechaDeVenta = DateTime.Now;
            estado = "nueva";
            iva = 0.21;
            tipoFactura = "A";

            lineasDeVenta = new List<LineaVenta>();
            materialesNecesarios = new List<ListaDeMateriales>();
            costosExtras = new List<CostoExtra>();
        }

        public Venta(Empleado empleado)
        {
            fechaDeVenta = DateTime.Now;
            estado = "nueva";
            iva = 0.21;
            tipoFactura = "A";
            Empleado = empleado;
        }

        public void agregarCliente(Cliente cliente)
        {
            Cliente = cliente;
        }

        public void agregarPedido(Pedido pedido)
        { 
            this.pedido = pedido;

            List<LineaPedido> lineasDePedido = pedido.obtenerLineasDePedido();
            
            foreach (LineaPedido lp in lineasDePedido) {
                LineaVenta lv = new LineaVenta(lp.cantidad, lp.producto);
                lineasDeVenta.Add(lv);
            }

            materialesNecesarios = this.pedido.ListaDeMateriales;
            costosExtras = this.pedido.costosExtras;
            Cliente = pedido.cliente;
        }

        public void agregarNumeroDeCuotas(int nroCuotas)
        {
            this.nroCuotas = nroCuotas;

            CalculadorDeIntereses calculador = new CalculadorDeIntereses();

            interes = calculador.calcularInteresPorCuotas(nroCuotas);

        }

        public void agregarEmpleado(Empleado empleado)
        {
            Empleado = empleado;
        }

        public void confirmar()
        {
            estado = "Realizado";
            Pago pago = new Pago(this.nroCuotas);
        }

        public double obtenerTotal()
        {
            double total = 0.0;

            foreach (LineaVenta lv in lineasDeVenta)
            {
                total += lv.obtenerSubtotal();
            }

            foreach (ListaDeMateriales lm in materialesNecesarios)
            {
                total = total + lm.getSubtotal();
            }

            foreach (CostoExtra cx in costosExtras)
            {
                total = total + cx.importe;
            }

            return total;
        }

    }
}
