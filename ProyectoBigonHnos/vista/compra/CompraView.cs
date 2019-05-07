using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.vista.compra
{
    public partial class CompraView : UserControl, ICompraView
    {
        public CompraControlador controlador { get; set; }


        public CompraView(Empleado empleadoLogueado)
        {
            InitializeComponent();
           
            UnirControlador(new CompraControlador(empleadoLogueado));
            ActualizarVista();
        }

        public CompraView()
        {
            InitializeComponent();
            UnirControlador(new CompraControlador());
            ActualizarVista();
            
        }

        public void ActualizarVista()
        {
            comprasRealizadasDataGrid.Rows.Clear();
            controlador.cargarComprasRealizadas();
            try
            {
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void limpiar()
        {
            throw new NotImplementedException();
        }

        public void UnirControlador(CompraControlador controlador)
        {
            this.controlador = controlador;
            controlador.UnirVista(this);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaCompraView vista = new NuevaCompraView();
            vista.UnirControlador(controlador);
            vista.ShowDialog();
            UnirControlador(controlador);
            ActualizarVista();

        }

        public void close()
        {
            Dispose();  
        }

        public void mostrarCompra(int id, string proveedor, DateTime fecha, string estado)
        {
            comprasRealizadasDataGrid.Rows.Add(id, proveedor, fecha, estado);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(comprasRealizadasDataGrid.CurrentRow.Cells[0].Value.ToString());

            controlador.eliminarCompra(id);
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            CompraDetalleView vista = new CompraDetalleView();
            vista.UnirControlador(controlador);

            int idSeleccionado = int.Parse(comprasRealizadasDataGrid.CurrentRow.Cells[0].Value.ToString());
            controlador.mostrarCompraCargada(idSeleccionado);
            vista.ShowDialog();

            controlador.UnirVista(this);
            ActualizarVista();
            
        }

        private void seleccionarFila(object sender, DataGridViewCellEventArgs e)
        {
          
            btnEliminar.Enabled = true;
            btnDetalle.Enabled = true;
        }

        private void imprimirBtn_Click(object sender, EventArgs e)
        {
            controlador.imprimir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
