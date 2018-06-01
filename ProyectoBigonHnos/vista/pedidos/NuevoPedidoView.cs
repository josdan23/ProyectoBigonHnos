﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBigonHnos.vista.pedidos
{
    partial class NuevoPedidoView : Form
    {
        public NuevoPedidoView()
        {
            InitializeComponent();
        }

        private void NuevoPedidoView_Load(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            AgregarClienteView vista = new AgregarClienteView();
            vista.ShowDialog();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            NuevoProductoView vista = new NuevoProductoView();
            vista.ShowDialog();
        }

        private void btnNuevoComponente_Click(object sender, EventArgs e)
        {
            NuevoComponenteView vista = new NuevoComponenteView();
            vista.ShowDialog();
        }
    }
}
