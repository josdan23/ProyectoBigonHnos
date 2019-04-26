using ProyectoBigonHnos.dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBigonHnos.vista.compra
{
    public partial class CompraDetalleView : Form, ICompraView
    {
        private CompraControlador controlador { get; set; }

        public CompraDetalleView()
        {
            InitializeComponent();
        }

        public void mostrarRazonSocial(String razonSocial)
        {
            razonSocialLabel.Text = razonSocial;
        }

        public void mostrarCuil(String cuil)
        {
            CuilLabel.Text = cuil;
        }

        public void mostrarDomicilio(String domicilio)
        {
            DomicilioLable.Text = domicilio;
        }

        public void mostrarTelefono(String telefono)
        {
            TelefonoLabel.Text = telefono;
        }

        public void mostrarFechaDeCompra(DateTime fechaDeCompra)
        {
            FechaLabel.Text = fechaDeCompra.ToString();
        }

        public void mostrarIdCompra (int idCompra)
        {
            IdCompraLabel.Text = idCompra.ToString();
        }

        public void mostrarEstado (String estadoCompra)
        {
            EstadoLabel.Text = estadoCompra;
        }

        public void mostrarMaterial(int idMaterial, string descripcion, int cantidadSolicitada)
        {
            dgvMaterialesAComprar.Rows.Add(idMaterial, descripcion, cantidadSolicitada);
        }

        public void UnirControlador(CompraControlador controlador)
        {
            this.controlador = controlador;
            controlador.UnirVista(this);

            
        }

        public void ActualizarVista()
        {
            throw new NotImplementedException();
        }

        public void limpiar()
        {
            throw new NotImplementedException();
        }

        public void close()
        {
            Dispose();
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            int idCompra = int.Parse(IdCompraLabel.Text);
            controlador.finalizarCompra(idCompra);
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            close();
        }

        public void cambiarEstadoBotonAprobar(bool flag)
        {
            btnAprobar.Enabled = flag;
        }
    }
}
