﻿using System;
using System.Windows.Forms;
using ProyectoBigonHnos.controladores;

namespace ProyectoBigonHnos.vista.empleado
{
    partial class NuevoEmpleadoView : Form, IEmpleadosView
    {
        private EmpleadoControlador Controlador { get; set; }

        public NuevoEmpleadoView()
        {
            InitializeComponent();
        }

        public void ActualizarVista()
        {
            dgvFamiliares.Rows.Clear();

            Controlador.mostrarGrupoFamiliar();
        }

        public void UnirControlador(EmpleadoControlador controlador)
        {
            Controlador = controlador;
            Controlador.unirVista(this); 

            Controlador.crearEmpleado(); //crea el empleado.

        }

        private void btnGuardarEmpleados_Click(object sender, EventArgs e)
        {
            Controlador.agregarInformacionPersonal(
                tboxApellido.Text,
                tboxNombre.Text,
                tboxDni.Text,
                tboxCuil.Text);

            Controlador.agregarDomicilio(
                tboxCalle.Text,
                int.Parse(tboxNumero.Text),
                tboxLocalidad.Text,
                tboxProvincia.Text);

            Controlador.agregarTelefono(tboxTelefono.Text);



            Controlador.agregarUsuario(
                tboxUserName.Text,
                tboxPassword.Text,
                ckboxAdministrador.Checked);

            Controlador.agregarCategoria(tboxCategoria.Text);
            Controlador.agregarLegajo(tboxLegajo.Text);

            Controlador.confimarEmpleado();

            Dispose();
        }

        public void listarFamiliar(string dniFamiliar, string parentesco, DateTime fechaNacimiento, bool discacidad)
        {
            dgvFamiliares.Rows.Add(dniFamiliar, parentesco, fechaNacimiento, discacidad);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Controlador.agregarFamiliar(
                tboxDniFamiliar.Text,
                dtpFechaIngreso.Value,
                tboxParentescoFamiliar.Text,
                chboxDiscapacidad.Checked);
            ActualizarVista();
        }

        private void btonBorrarFamilar_Click(object sender, EventArgs e)
        {
            String dniFamiliar = dgvFamiliares.CurrentRow.Cells[0].Value.ToString();
            Controlador.eliminarFamiliar(dniFamiliar);
            //Console.WriteLine(dniFamiliar);
        }
    }
}
