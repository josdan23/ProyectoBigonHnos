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

namespace ProyectoBigonHnos.vista.login
{
    partial class Login : Form
    {
        private LoginControlador Controlador { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        public void unirControlador(LoginControlador controlador)
        {
            Controlador = controlador;
            Controlador.unirVista(this);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string legajo = tboxUsuario.Text;
            string password = tboxPassword.Text;

            Controlador.iniciarSesion(legajo, password);
        }
    }
}
