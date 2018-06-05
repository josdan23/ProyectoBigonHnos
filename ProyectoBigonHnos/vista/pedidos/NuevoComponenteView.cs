using ProyectoBigonHnos.dominio;
using System;
using System.Windows.Forms;

namespace ProyectoBigonHnos.vista.pedidos
{
    partial class NuevoComponenteView : Form, IPedidoView
    {
        private PedidoControlador controlador;

        public NuevoComponenteView()
        {
            InitializeComponent();
        }

        public void unirControlador(PedidoControlador controlador)
        {
            this.controlador = controlador;
            controlador.unirVista(this);
            controlador.mostrarMateriales();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string descripcion = tboxDescripcion.Text;
            double alto = double.Parse(tboxAlto.Text);
            double ancho = double.Parse(tboxAncho.Text);
            double profundidad = double.Parse(tboxProfundidad.Text);
            string colorPrimario = tboxColorP.Text;
            string colorSecundario = tboxColorS.Text;
            int cantidad = int.Parse(tboxCantidad.Text);

            //TODO: hacer funcionalidad para elegir el id del combobox
            int idMaterial = obtenerIdMaterialSeleccionado(cboxMaterial.SelectedItem.ToString());

            controlador.agregarComponente(
                descripcion,
                alto,
                ancho,
                profundidad,
                colorPrimario,
                colorSecundario,
                cantidad,
                1);

            Dispose();
        }

        public void listarMaterial(int idMaterial, string nombre)
        {

            string idYMaterial = $"{idMaterial}-{nombre}";
            cboxMaterial.Items.Add(idYMaterial);
        }

        private int obtenerIdMaterialSeleccionado(string materialSeleccionado)
        {
            string idMaterial = materialSeleccionado.Split('-')[0];

            return int.Parse(idMaterial);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void ActualizarVista()
        {
            Console.WriteLine("actualizar: vista de agregar componente");
        }
    }
}
