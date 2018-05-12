using ProyectoBigonHnos.controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBigonHnos.vista.materiales
{
    partial class NuevoMaterialView : Form
    {
        GestionarMaterialControlador controlador;

        public NuevoMaterialView(GestionarMaterialControlador controlador)
        {
            InitializeComponent();

            this.controlador = controlador;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String descripcion = tboxDescripcion.Text;
            double precio = double.Parse( tboxPrecio.Text);
            int cantidad = int.Parse(tboxCantidad.Text);
            int stockDisponible = int.Parse(tboxStockDisponible.Text);
            int stockMinimo = int.Parse(tboxMinimo.Text);

            controlador.agregarNuevoMaterial(descripcion, cantidad, precio, stockMinimo, stockDisponible);

            Dispose();
        }
    }
}
