﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBigonHnos.controladores;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.vista.ventas
{
    partial class NuevaVentaView : Form, IVentaView
    {
        private VentaControlador Controlador { get; set; }
        private Empleado EmpleadoLogueado { get; set; }

        public NuevaVentaView(Empleado empleadoLog)
        {
            InitializeComponent();
            EmpleadoLogueado = empleadoLog;
        }

        public void ActualizarVista()
        {
            // VOLVER A LLAMAR A LOS METODOS DE CONTROLADOR PARA MOSTRAR LOS DATOS
            dgvPedidos.Rows.Clear();
            materialesDgv.Rows.Clear();
            costosExtrasDgv.Rows.Clear();
            productosDgv.Rows.Clear();
        }

        public void UnirControlador(VentaControlador controlador)
        {
            Controlador = controlador;
            Controlador.unirVista(this);
            Console.WriteLine("nueva venta");
        }

        public void limpiar()
        {
            dgvPedidos.Rows.Clear();
        }

        public void listarPedido(int idPedido, string cliente, DateTime fechaPedido)
        {
            dgvPedidos.Rows.Add(idPedido, cliente, fechaPedido.ToShortDateString());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dniCliente = tboxDni.Text;
            ActualizarVista();
            Controlador.MostrarPedidos(dniCliente);
            Console.WriteLine("se muestra los pedidos");  
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int idPedido = int.Parse(dgvPedidos.CurrentRow.Cells[0].Value.ToString());
                //Controlador.iniciarVenta();
                Controlador.agregarPedido(idPedido);
                Controlador.confirmarVenta();
                //Controlador.agregarEmpleado(EmpleadoLogueado);
                Dispose();
                Controlador.imprimirFacturaDeVenta();
            }

            catch (Exception at)
            {
                MessageBox.Show(at.Message);
            }
            
        }

        public void listarProducto(int idProducto, string descripcion, double alto, double ancho, double profundidad, string colorP, string colorS, int cantidad)
        {
            productosDgv.Rows.Add(idProducto,
                descripcion, 
                ancho,
                alto, 
                profundidad,
                colorP,
                colorS,
                cantidad);
        }

        public void listarMaterial(int idMaterial, string material, double precioUnitario, string unidad, int cantidad, double subtotal)
        {
            materialesDgv.Rows.Add(idMaterial, material, precioUnitario, unidad, cantidad, subtotal);
        }

        public void listarCostosExtras(string descripcion, double monto)
        {
            costosExtrasDgv.Rows.Add(descripcion, monto);
        }

        public void mostrarSubtotalMateriales(double monto)
        {
            subtotalMaterialesLbl.Text = monto.ToString();
        }

        public void mostrarSubtotalCostosExtras(double monto)
        {
            subtotalCargosExtrasLbl.Text = monto.ToString();
        }

        public void mostrarTotal(double monto)
        {
            totalLabel.Text = monto.ToString();
        }

        public void mostrarTotalDeIva(double monto)
        {
            ivaLabel.Text = monto.ToString();
        }

        public void mostrarMontoXCuotas(double monto)
        {
            montoDeCuotasLabel.Text = String.Format("de {0}",monto.ToString("N"));
        }

        public void mostrarCliente(string apellido, string nombre)
        {
            string nombreYApellido = String.Format("{0}, {1}", apellido, nombre);
            clienteLabel.Text = nombreYApellido;
        }

        public void mostrarDniCliente(String dni)
        {
            dniLabel.Text = dni;
        }

        private void seleccionarPedido(object sender, DataGridViewCellEventArgs e)
        {
            int idPedido = int.Parse(dgvPedidos.CurrentRow.Cells[0].Value.ToString());
            Controlador.agregarPedido(idPedido);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cuotas = int.Parse(comboBox1.SelectedItem.ToString());
            Controlador.agregarNumeroDeCuotas(cuotas);
        }

        public void mostrarDomicilio(String calle, int numero, String localidad, String provincia)
        {
            domicilioLabel.Text = string.Format("{0},{1}-{2},{3}", calle, numero, localidad, provincia);
        }

        public void mostrarFechaDeVenta(DateTime fechaDeVenta)
        {
            fechaDeVentaLabel.Text = fechaDeVenta.ToShortDateString();
        }

        public void mostrarLegajoVendedor(String legajo)
        {
            vendedorLegajoLbl.Text = legajo;
        }
    }
}
