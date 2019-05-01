using iTextSharp.text;
using iTextSharp.text.pdf;
using ProyectoBigonHnos.dominio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBigonHnos.vistasImpresas
{
    class PedidosPdfView
    {
        
        public void imprmir(List<Pedido> lista)
        {
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(Application.StartupPath +  @"\ListadoDePedidos.pdf", FileMode.Create));
            doc.Open();

            Font _standardFont = new Font(Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            Font _standardFont2 = new Font(Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.WHITE);

            Paragraph salto = new Paragraph("\n");
            doc.Add(salto);

            PdfPTable tableHeader = new PdfPTable(2);
            tableHeader.WidthPercentage = 100;

            PdfPCell cell = new PdfPCell(new Phrase("Bigons hnos"));
            cell.Border = 0;
            cell.BorderWidthBottom = 0.5f;
            cell.HorizontalAlignment = 0;

            PdfPCell cell1 = new PdfPCell(new Phrase(DateTime.Now.ToString()));
            cell1.Border = 0;
            cell1.BorderWidthBottom = 0.5f;
            cell1.HorizontalAlignment = 2;

            tableHeader.AddCell(cell);
            tableHeader.AddCell(cell1);
            doc.Add(tableHeader);

            doc.Add(salto);
            doc.Add(salto);

            Paragraph title = new Paragraph();
            title.Font = FontFactory.GetFont(FontFactory.TIMES, 24f);
            title.Add("Listado de pedidos de la fecha");
            title.Alignment = 1;
            doc.Add(title);

            PdfPTable tblPrueba = new PdfPTable(4);
            tblPrueba.WidthPercentage = 90;

            PdfPCell clPedidoHeader = new PdfPCell(new Phrase("Pedido", _standardFont2));
            clPedidoHeader.BorderWidth = 0;
            clPedidoHeader.BorderWidthBottom = 0.75f;
            clPedidoHeader.BackgroundColor = BaseColor.GRAY;

            PdfPCell clClienteHeader = new PdfPCell(new Phrase("Cliente", _standardFont2));
            clClienteHeader.BorderWidth = 0;
            clClienteHeader.BorderWidthBottom = 0.75f;
            clClienteHeader.BackgroundColor = BaseColor.GRAY;

            PdfPCell clFechaHeader = new PdfPCell(new Phrase("Fecha", _standardFont2));
            clFechaHeader.BorderWidth = 0;
            clFechaHeader.BorderWidthBottom = 0.75f;
            clFechaHeader.BackgroundColor = BaseColor.GRAY;

            PdfPCell clTotalHeader = new PdfPCell(new Phrase("Total", _standardFont2));
            clTotalHeader.BorderWidth = 0;
            clTotalHeader.BorderWidthBottom = 0.75f;
            clTotalHeader.BackgroundColor = BaseColor.GRAY;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clPedidoHeader);
            tblPrueba.AddCell(clClienteHeader);
            tblPrueba.AddCell(clFechaHeader);
            tblPrueba.AddCell(clTotalHeader);

            foreach (Pedido unPedido in lista)
            {

                if (unPedido.fechaDePedido.Equals(DateTime.Now))
                {
                    PdfPCell clPedido = new PdfPCell(new Phrase(unPedido.idPedido.ToString(), _standardFont));
                    clPedido.BorderWidth = 0;

                    PdfPCell clCliente = new PdfPCell(new Phrase(unPedido.cliente.Apellido + unPedido.cliente.Nombre, _standardFont));
                    clCliente.BorderWidth = 0;

                    PdfPCell clFecha = new PdfPCell(new Phrase(unPedido.fechaDePedido.ToShortDateString(), _standardFont));
                    clFecha.BorderWidth = 0;

                    PdfPCell clTotal = new PdfPCell(new Phrase(unPedido.obtenerTotal().ToString(), _standardFont));
                    clTotal.BorderWidth = 0;

                    // Añadimos las celdas a la tabla
                    tblPrueba.AddCell(clPedido);
                    tblPrueba.AddCell(clCliente);
                    tblPrueba.AddCell(clFecha);
                    tblPrueba.AddCell(clTotal);
                }
            }

            doc.Add(new Paragraph("\n"));

            doc.Add(tblPrueba);

            doc.Close();
            writer.Close();

            System.Diagnostics.Process.Start(Application.StartupPath + @"\ListadoDePedidos.pdf");
        }

    }
}
