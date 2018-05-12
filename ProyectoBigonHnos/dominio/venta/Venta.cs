using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio.venta
{
    class Venta
    {
        private DateTime fechaDeVenta;
        private string estado;
        private double iva;
        private double precio;
        private string tipoFactura;
        private double interes;
        private int nroCuotas;

        public Empleado Empleado { get; set; }

        private Cliente cliente;

        private List<LineaDeVenta> lineasDeVenta;
        private Pedido pedido;
        private Pago pago;

        public Venta()
        {
            this.fechaDeVenta = DateTime.Now;
            this.estado = "nueva";
            this.iva = 0.21;
            this.tipoFactura = "A";
        }

        public Venta(Empleado empleado)
        {
            this.fechaDeVenta = DateTime.Now;
            this.estado = "nueva";
            this.iva = 0.21;
            this.tipoFactura = "A";
            Empleado = empleado;
        }

        public void agregarCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public void agregarPedido(Pedido pedido)
        {

            this.pedido = pedido;

            List<LineaDePedido> lineasDePedido = pedido.obtenerLineasDePedido();
            
            foreach (LineaDePedido lp in lineasDePedido) {
                LineaDeVenta lv = new LineaDeVenta(lp.cantidad, lp.producto);
                lineasDeVenta.Add(lv);

            }
        }

        public void agregarNumeroDeCuotas(int nroCuotas)
        {
            this.nroCuotas = nroCuotas;

            CalculadorDeIntereses calculador = new CalculadorDeIntereses();

            this.interes = calculador.calcularInteresPorCuotas(nroCuotas);

        }

        public void agregarEmpleado(Empleado empleado)
        {
            Empleado = empleado;
        }

        public void confirmar()
        {
            this.estado = "Realizado";
            Pago pago = new Pago(this.nroCuotas);
        
        }

        public double obtenerTotal()
        {
            double total = 0.0;

            foreach (LineaDeVenta lv in lineasDeVenta)
            {
                total += lv.obtenerSubtotal();
            }

            return total;
        }

    }
}
