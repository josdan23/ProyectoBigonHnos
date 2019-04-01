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
    partial class NuevoMaterialView : Form, IMaterialesView
    {
        GestionarMaterialControlador controlador;

        public NuevoMaterialView()
        {
            InitializeComponent();
            controlador = new GestionarMaterialControlador(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String descripcion = tboxDescripcion.Text;
            double precio = double.Parse( tboxPrecio.Text);
            int stockDisponible = int.Parse(tboxStockDisponible.Text);
            int stockMinimo = int.Parse(tboxMinimo.Text);

            String unidadDelPrecio = unidadCmbox.Text;

            controlador.agregarNuevoMaterial(descripcion, precio, stockMinimo, stockDisponible, unidadDelPrecio);
            Dispose();
        }

        public void mostrarMaterial(int id, string descripcion, int cantidad, double precio, int stockDisponible, int stockMinimo, string unidad)
        {

        }
    }
}
