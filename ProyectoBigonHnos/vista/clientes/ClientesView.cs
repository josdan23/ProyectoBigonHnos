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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ProyectoBigonHnos.vista
{
    public partial class ClientesView : UserControl
    {
        GestionarClientesControlador controlador;

        public ClientesView()
        {
            InitializeComponent();

            controlador = new GestionarClientesControlador(this);
            controlador.listarClientes();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoClienteView vista = new NuevoClienteView(controlador);
            vista.ShowDialog();
            refrescar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string dni = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            if ( dni != null)
            {
                controlador.borrarCliente(dni);
                refrescar();
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idCliente = int.Parse(idClienteLbl.Text);
            EditarClienteView vista = new EditarClienteView();
            vista.unirControlador(controlador);
            controlador.verDetalleActualizacionCliente(idCliente, vista);
            vista.ShowDialog();
            refrescar();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void seleccionarFila(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentRow.Cells[0].Value != null)
            {
                controlador.detalleCliente(dgvClientes.CurrentRow.Cells[0].Value.ToString());
                btnEliminar.Enabled = true;
                btnEditar.Enabled = true;

            }
        }

        public void mostrarCliente( String dni, string apellido, string nombre) 
        {
            dgvClientes.Rows.Add(dni, apellido, nombre);

        }

        public void mostrarInformmacion(string dni, string apellido, string nombre)
        {
          
            tboxDni.Text = dni;
            tBoxNombre.Text = nombre;
            tBoxApellido.Text = apellido;
        }

        public void mostrarTelefono(string numero)
        {
            tboxTelefono.Text = numero;
        }

        public void mostrarDomicilio(string numero, string calle, string localidad, string provincia)
        {
            tboxNumero.Text = numero;
            tboxCalle.Text = calle;
            tboxLocalidad.Text = localidad;
            tboxProvincia.Text = provincia;
        }

        public void mostrarIdCliente(String idCliente)
        {
            idClienteLbl.Text = idCliente;
        }

        private void limpiarTabla()
        {
            dgvClientes.Rows.Clear();
          
        }

        private void limpiarTablaTelefono()
        {
            //dgvTelefonos.Rows.Clear();
        }

        public void refrescar()
        {
            tboxDni.Text = "";
            tBoxNombre.Text = "";
            tBoxApellido.Text = "";
            tboxCalle.Text = "";
            tboxNumero.Text = "";
            tboxLocalidad.Text = "";
            tboxProvincia.Text = "";

            limpiarTabla();
            limpiarTablaTelefono();

            controlador.listarClientes();
        }

        private void ClientesView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            controlador.imprimir();

            /*
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\Daniel\Desktop\Hola.pdf", FileMode.Create));
            doc.Open();

            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
 

            Paragraph title = new Paragraph();
            title.Font = FontFactory.GetFont(FontFactory.TIMES, 18f, BaseColor.BLUE);
            title.Add("Listado de clientes");
            doc.Add(title);

            PdfPTable tblPrueba = new PdfPTable(3);
            tblPrueba.WidthPercentage = 100;

            PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", _standardFont));
            clNombre.BorderWidth = 0;
            

            PdfPCell clApellido = new PdfPCell(new Phrase("Apellido", _standardFont));
            clApellido.BorderWidth = 0;
            clApellido.BorderWidthBottom = 0.75f;

            PdfPCell clPais = new PdfPCell(new Phrase("País", _standardFont));
            clPais.BorderWidth = 0;
            clPais.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clApellido);
            tblPrueba.AddCell(clPais);

            doc.Add(new Paragraph("Hola Mundo!!"));
            doc.Add(new Paragraph("Parrafo 1"));
            doc.Add(new Paragraph("Parrafo 2"));

            doc.Add(tblPrueba);

            doc.Close();
            writer.Close();

            System.Diagnostics.Process.Start(@"C:\Users\Daniel\Desktop\Hola.pdf");
            */

        }
    }
}
