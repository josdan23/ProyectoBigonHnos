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
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.vista.pedidos
{
    public partial class AgregarMaterialesNecesariosView : Form, IPedidoView
    {
        public IPedidoController controlador { get; set; }

        public AgregarMaterialesNecesariosView()
        {
            InitializeComponent();
        }

        public void ActualizarVista()
        {
            cantidadTxBox.Text = "";
            SubtotalTxbox.Text = "";
         
        }


        public void unirControlador(IPedidoController controlador)
        {
            this.controlador = controlador;
            if (controlador is PedidoControlador)
            {
                ((PedidoControlador)controlador).unirVista(this);
                ((PedidoControlador)controlador).mostrarMateriales();
            }
            else
            {
                ((EditarPedidoControlador)controlador).unirVista(this);
                ((EditarPedidoControlador)controlador).mostrarMateriales();
            }
        }

        public void mostrarMaterialDisponible(int id, string descripcion, string unidad, double precio)
        {
            materialesDisponiblesDGV.Rows.Add(id, descripcion, unidad, precio);
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            try
            {

                int idMaterial = int.Parse(materialesDisponiblesDGV.CurrentRow.Cells[0].Value.ToString());
                int cantidad = int.Parse(cantidadTxBox.Text);

                cantidadTxBox.Text = "";

                if (controlador is PedidoControlador)
                    ((PedidoControlador)controlador).agregarMaterialAUsar(idMaterial, cantidad);
                else
                    ((EditarPedidoControlador)controlador).agregarNuevoMaterialDisponible(idMaterial, cantidad);

                ActualizarVista();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void ingresarTexto(object sender, EventArgs e)
        {
            if (cantidadTxBox.Text != "")
            {
                double precioUnitarioMaterial = double.Parse(materialesDisponiblesDGV.CurrentRow.Cells[3].Value.ToString());
                int cantidad = int.Parse(cantidadTxBox.Text);

                double subtotal = precioUnitarioMaterial * cantidad;
                SubtotalTxbox.Text = string.Format("{0}", subtotal);
            }
            else
                SubtotalTxbox.Text = "";
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
