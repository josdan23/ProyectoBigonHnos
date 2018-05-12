using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBigonHnos.controladores;
using ProyectoBigonHnos.vista.materiales;

namespace ProyectoBigonHnos.vista
{
    public partial class MaterialView : UserControl
    {
        private GestionarMaterialControlador controlador;
            
        public MaterialView()
        {
            InitializeComponent();

            controlador = new GestionarMaterialControlador(this);
            refrescarTabla();

        }
        
        public void mostrarMaterial(int id, string descripcion, int cantidad, double precio, int stockDisponible, int stockMinimo)
        {
            dgvMateriales.Rows.Add(id, descripcion, cantidad, precio, stockDisponible, stockMinimo);
        }

        public void refrescarTabla()
        {
            dgvMateriales.Rows.Clear();
            controlador.listarMateriales();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //int id = (int) dgvMateriales.CurrentRow.Cells[0].Value;

            if (dgvMateriales.CurrentRow.Cells[0].Value != null)
            {
                int id = int.Parse(dgvMateriales.CurrentRow.Cells[0].Value.ToString());
                controlador.eliminarMaterial(id);
                refrescarTabla();
            }
        }

        private void seleccionarFila(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarMaterialVista vista = new EditarMaterialVista();
            vista.ShowDialog();
            refrescarTabla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoMaterialView vista = new NuevoMaterialView(controlador);
            vista.ShowDialog();
            Console.WriteLine("NUEVO ELEMENTOO");
            refrescarTabla();

        }

       
    }
}
