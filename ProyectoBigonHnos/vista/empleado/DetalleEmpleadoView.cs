﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBigonHnos.controladores;

namespace ProyectoBigonHnos.vista.empleado
{
    partial class DetalleEmpleadoView : Form, IEmpleadosView
    {
        public EmpleadoControlador Controlador { get; set; }

        public DetalleEmpleadoView()
        {
            InitializeComponent();
        }

        public void ActualizarVista()
        {
            //ACTUALIZAR LA VISTA DEL EMPLEADO DETALLE
        }

        public void UnirControlador(EmpleadoControlador controlador)
        {
            Controlador = controlador;
            Controlador.unirVista(this);
        }

        public void mostrarInfoPersona(string nombre, string apellido, string dni, string cuit)
        {
            tboxNombre.Text = nombre;
            tboxApellido.Text = apellido;
            tboxDni.Text = dni;
            tboxCuit.Text = cuit;
        }

        public void mostrarDomicilio(string calle, int numero, string localidad, string provincia)
        {
            tboxCalle.Text = calle;
            tboxNumero.Text = numero.ToString();
            tboxLocalidad.Text = localidad;
            tboxProvincia.Text = provincia;
        }

        public void mostrarTelefono(string telefono)
        {
            tboxTelefono.Text = telefono;
        }

        public void mostrarInfoEmpleado(string legajo, string password, bool esAdmin, string categoria)
        {
            tboxLegajo.Text = legajo;

            tboxContrasenia.Text = password;
            tboxCategoria.Text = categoria;
            ckboxAdministrador.Checked = esAdmin;
        }

        public void mostrarFechas(DateTime fechaIngreso, DateTime fechaEgreso)
        {
            tboxFechaIngreso.Text = fechaIngreso.ToShortDateString();

            if (fechaEgreso.Equals(new DateTime()))
                tboxFechaEgreso.Text = "-/-/-";
            else
                tboxFechaEgreso.Text = fechaEgreso.ToShortDateString();
        }

        public void mostrarFamiliar(string dniFamiliar, string parentesco, DateTime fechaNac, bool discapacidad)
        {
            dgvFamiliares.Rows.Add(
                dniFamiliar,
                parentesco,
                fechaNac.ToString(),
                discapacidad.ToString()
                );
        }

        public void mostrarDetalle(string legajoSeleccionado)
        {
            Controlador.mostraDetalleDeEmpleado(legajoSeleccionado);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
