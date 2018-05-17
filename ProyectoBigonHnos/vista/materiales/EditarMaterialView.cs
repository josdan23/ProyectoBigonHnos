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

namespace ProyectoBigonHnos.vista.materiales
{
    public partial class EditarMaterialView : Form, IMaterialesView
    {
        GestionarMaterialControlador controlador;
        
        public EditarMaterialView(int idMaterial)
        {
            InitializeComponent();
            controlador = new GestionarMaterialControlador(this);
            controlador.detalleMaterial(idMaterial);
        }


        public void mostrarMaterial(int id, string descripcion, int cantidad, double precio, int stockDisponible, int stockMinimo)
        {
            tboxIdMaterial.Text = id.ToString();
            tboxDescripcion.Text = descripcion;
            tboxCantidad.Text = cantidad.ToString();
            tboxPrecio.Text = precio.ToString();
            tboxStockDisponible.Text = stockDisponible.ToString();
            tboxMinimo.Text = stockMinimo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idMaterial = int.Parse(tboxIdMaterial.Text);
            string descripcion = tboxDescripcion.Text;
            int cantidad = int.Parse(tboxCantidad.Text);
            double precio = double.Parse(tboxPrecio.Text);
            int stockDisponible = int.Parse(tboxStockDisponible.Text);
            int stockMinimo = int.Parse(tboxMinimo.Text);


            controlador.modificarMaterial(idMaterial, descripcion, cantidad, precio, stockDisponible, stockMinimo);

            Dispose();
        }
    }
}
