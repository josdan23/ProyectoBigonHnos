using System;
using System.Windows.Forms;
using ProyectoBigonHnos.controladores;
using ProyectoBigonHnos.vista.materiales;

namespace ProyectoBigonHnos.vista
{
    public partial class MaterialView : UserControl, IMaterialesView
    {
        private GestionarMaterialControlador controlador;
            
        public MaterialView()
        {
            InitializeComponent();

            controlador = new GestionarMaterialControlador(this);
            refrescarTabla();
            ocultarBotonesEditarYEliminar();

        }
        
        public void refrescarTabla()
        {
            dgvMateriales.Rows.Clear();
            controlador.listarMateriales();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMateriales.CurrentRow.Cells[0].Value != null)
            {
                int id = int.Parse(dgvMateriales.CurrentRow.Cells[0].Value.ToString());
                controlador.eliminarMaterial(id);
                refrescarTabla();
                ocultarBotonesEditarYEliminar();
            }
        }

        private void seleccionarFila(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = obtenerIdMaterialSeleccionado();
            EditarMaterialView vista = new EditarMaterialView(id);
            Console.WriteLine(id);
            vista.ShowDialog();
            refrescarTabla();
            ocultarBotonesEditarYEliminar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoMaterialView vista = new NuevoMaterialView();
            vista.ShowDialog();
            Console.WriteLine("NUEVO ELEMENTOO");
            refrescarTabla();
        }

        public void mostrarMaterial(int id, string descripcion, int cantidad, double precio, int stockDisponible, int stockMinimo, string unidad)
        {
            dgvMateriales.Rows.Add(id, descripcion, cantidad, precio, stockDisponible, stockMinimo, unidad);
        }

        public int obtenerIdMaterialSeleccionado()
        {
            return (int) dgvMateriales.CurrentRow.Cells[0].Value;
        }

        private void ocultarBotonesEditarYEliminar()
        {
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
        }
    }
}
