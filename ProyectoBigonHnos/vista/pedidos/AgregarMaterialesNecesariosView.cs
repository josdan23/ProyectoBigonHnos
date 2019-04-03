using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.vista.pedidos
{
    public partial class AgregarMaterialesNecesariosView : Form, IPedidoView
    {
        public PedidoControlador controlador { get; set; }

        public AgregarMaterialesNecesariosView()
        {
            InitializeComponent();
        }

        public void ActualizarVista()
        {
            cantidadTxBox.Text = "";
            SubtotalTxbox.Text = "";
         
        }


        public void unirControlador(PedidoControlador controlador)
        {
            this.controlador = controlador;
            controlador.unirVista(this);
            controlador.mostrarMateriales();
        }

        public void mostrarMaterialDisponible(int id, string descripcion, string unidad, double precio)
        {
            materialesDisponiblesDGV.Rows.Add(id, descripcion, unidad, precio);
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            int idMaterial = int.Parse(materialesDisponiblesDGV.CurrentRow.Cells[0].Value.ToString());
            int cantidad = int.Parse(cantidadTxBox.Text);

            controlador.agregarMaterialAUsar(idMaterial, cantidad);
            ActualizarVista();
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
