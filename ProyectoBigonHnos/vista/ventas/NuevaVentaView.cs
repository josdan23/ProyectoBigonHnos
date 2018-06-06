using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBigonHnos.controladores;

namespace ProyectoBigonHnos.vista.ventas
{
    partial class NuevaVentaView : Form, IVentaView
    {
        private VentaControlador Controlador { get; set; }

        public NuevaVentaView()
        {
            InitializeComponent();
        }

        public void ActualizarVista()
        {
            // VOLVER A LLAMAR A LOS METODOS DE CONTROLADOR PARA MOSTRAR LOS DATOS
            dgvPedidos.Rows.Clear();
        }

        public void UnirControlador(VentaControlador controlador)
        {
            Controlador = controlador;
            controlador.unirVista(this);
        }

        public void limpiar()
        {
            dgvPedidos.Rows.Clear();
        }

        public void listarPedido(int idPedido, string cliente, DateTime fechaPedido)
        {
            dgvPedidos.Rows.Add(idPedido, cliente, fechaPedido);
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
            int idPedido = int.Parse(dgvPedidos.CurrentRow.Cells[0].Value.ToString());
            Controlador.iniciarVenta();
            Controlador.agregarPedido(idPedido);
            Controlador.confirmarVenta();
            Dispose();
        }
    }
}
