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

namespace ProyectoBigonHnos.vista.empleado
{
    partial class EmpleadoView : UserControl, IEmpleadosView
    {
        private EmpleadoControlador Controlador { get; set; }

        public EmpleadoView()
        {
            InitializeComponent();
            UnirControlador(new EmpleadoControlador());
            ActualizarVista();
        }

        public void ActualizarVista()
        {
            LimpiarVista();
            Controlador.mostrarEmpleados();
        }

        public void UnirControlador(EmpleadoControlador controlador)
        {
            Controlador = controlador;
            Controlador.unirVista(this);
            Console.WriteLine("VISTA EMPLEADO");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoEmpleadoView vista = new NuevoEmpleadoView();
            vista.UnirControlador(Controlador);
            vista.ShowDialog();
            UnirControlador(Controlador);
            ActualizarVista();
        }

        public void listarEmpleado(string legajo, string apellido, string nombre, string dni, DateTime fechaIngreso, string categoria)
        {
            dgvEmpleados.Rows.Add(legajo, apellido, nombre, dni, fechaIngreso, categoria);
        }

        public void LimpiarVista()
        {
            dgvEmpleados.Rows.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string legajo = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();

            Controlador.eliminarEmpleado(legajo);
            ActualizarVista();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            DetalleEmpleadoView vista = new DetalleEmpleadoView();
            vista.ShowDialog();
        }

        private void btnDetalle_Click_1(object sender, EventArgs e)
        {
            string legajoSeleccionado = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();

            DetalleEmpleadoView vista = new DetalleEmpleadoView();
            vista.UnirControlador(Controlador);
            vista.mostrarDetalle(legajoSeleccionado);
            vista.ShowDialog();
        }
    }
}
