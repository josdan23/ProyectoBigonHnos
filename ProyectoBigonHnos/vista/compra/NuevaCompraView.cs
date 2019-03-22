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
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.vista.compra
{
     public partial class NuevaCompraView : Form, ICompraView
    {

        private CompraControlador controlador { get; set; }
        private bool primeraVez = true;

        public NuevaCompraView()
        {
            InitializeComponent();
            //ActualizarVista();
        }

        public void ActualizarVista()
        {
            compraDataGrid.Rows.Clear();
            fechaLabel.Text = DateTime.Now.ToString();
        }

        public void limpiar()
        {
            throw new NotImplementedException();
        }

        public void UnirControlador(CompraControlador controller)
        {
            controlador = controller;
            controlador.UnirVista(this);

            controlador.iniciarNuevaCompra();
            controlador.mostrarMateriales();
            controlador.mostrarFechaActual();
        }

        public void mostratCamposProveedor(string razonSocial, string cuit, string domicilio, string telefono)
        {
            razonSocialLabel.Text = razonSocial;
            cuitLabel.Text = Text;
            domicilioLabel.Text = domicilio;
            telefonoLabel.Text = telefono;

        }

        public void agregarMaterialATabla(int id, string descripcion, int stockMinimo, int stockDisponible)
        {
            materialesDataGrid.Rows.Add(id, descripcion, stockMinimo, stockDisponible);
        }

        public void agregarMaterialACompra(int id, string descripcion, int cantidad)
        {
            compraDataGrid.Rows.Add(id, descripcion, cantidad);
        }

        public void quitarMaterialDeCompra(int id)
        {
            //buscar entre las filas de la tabla y eliminar la fila

            foreach (DataGridViewRow fila in compraDataGrid.Rows)
            {
                if (int.Parse(fila.Cells[0].Value.ToString()) == id)
                {
                    int index = fila.Index;
                    compraDataGrid.Rows.RemoveAt(index);
                }
            }
        }

        public void actualizarCantidad(int cantidad)
        {
            //obtener el id de la fila, y llamar a controlador para que encuentra la linea de compra y actualziar
        }

      

        private void confirmarButton_Click(object sender, EventArgs e)
        {
            //llamar al controlador y confirmar la compra
            controlador.confirmarComprar();
        }


        public void close()
        {
            Dispose();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            close();
        }

        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int idProveedor = int.Parse(codigoTextView.Text);

            controlador.agregarProveedor(idProveedor);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //llamar a controlador y agregar el material a la compra
            //agregar el material a la tabla

            CantidadCompraMaterialView view = new CantidadCompraMaterialView();
            view.ShowDialog().ToString();

            int cantidad = view.dataIngresada;

            int idMaterial = int.Parse(materialesDataGrid.CurrentRow.Cells[0].Value.ToString());

            bool estaAgregado = false;

            /*if (!primeraVez)
            {

                foreach (DataGridViewRow row in compraDataGrid.Rows)
                {
                    int idMaterialCompra = int.Parse(row.Cells[0].Value.ToString());
                    Console.WriteLine(idMaterialCompra);
                    if (idMaterial == idMaterialCompra )
                    {
                        Console.WriteLine("esta agregado");
                        estaAgregado = true;
                    }

                }
            }
            else
                primeraVez = false;

            if (!estaAgregado)*/
            controlador.agregarMaterial(idMaterial, cantidad);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            //llamar el controlador y quitar el material de la compra

            int index = compraDataGrid.CurrentCell.RowIndex;

            Console.WriteLine("fila eliminada: " + index);
            controlador.cancelarMaterial(index + 1);
        }

        public void mostrarFechaActualDeCompra(DateTime fechaDeCompra)
        {
            fechaLabel.Text = fechaDeCompra.ToString();
        }
    }
}
