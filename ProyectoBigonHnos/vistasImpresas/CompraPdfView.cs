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
    class CompraPdfView
    {
        public void imprimir(List<Compra> lista)
        {
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(Application.StartupPath + @"\ListadoDeCompras.pdf", FileMode.Create));
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
            title.Add("Compras realizadas a la fecha");
            title.Alignment = 1;
            doc.Add(title);

            PdfPTable tblPrueba = new PdfPTable(4);
            tblPrueba.WidthPercentage = 90;

            PdfPCell clIdHeader = new PdfPCell(new Phrase("id", _standardFont2));
            clIdHeader.BorderWidth = 0;
            clIdHeader.BorderWidthBottom = 0.75f;
            clIdHeader.BackgroundColor = BaseColor.GRAY;

            PdfPCell clProveedorHeader = new PdfPCell(new Phrase("Proveedor", _standardFont2));
            clProveedorHeader.BorderWidth = 0;
            clProveedorHeader.BorderWidthBottom = 0.75f;
            clProveedorHeader.BackgroundColor = BaseColor.GRAY;

            PdfPCell clFechaHeader = new PdfPCell(new Phrase("Fecha", _standardFont2));
            clFechaHeader.BorderWidth = 0;
            clFechaHeader.BorderWidthBottom = 0.75f;
            clFechaHeader.BackgroundColor = BaseColor.GRAY;

            PdfPCell clEstadoHeader = new PdfPCell(new Phrase("Estado", _standardFont2));
            clEstadoHeader.BorderWidth = 0;
            clEstadoHeader.BorderWidthBottom = 0.75f;
            clEstadoHeader.BackgroundColor = BaseColor.GRAY;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clIdHeader);
            tblPrueba.AddCell(clProveedorHeader);
            tblPrueba.AddCell(clFechaHeader);
            tblPrueba.AddCell(clEstadoHeader);

            foreach(Compra unaCompra in lista)
            {

                if (unaCompra.fechaCompra.Equals(DateTime.Now))
                {
                    PdfPCell clId = new PdfPCell(new Phrase(unaCompra.IdCompra.ToString(), _standardFont));
                    clId.BorderWidth = 0;

                    PdfPCell clProveedor = new PdfPCell(new Phrase(unaCompra.proveedor.RazonSocial, _standardFont));
                    clProveedor.BorderWidth = 0;

                    PdfPCell clFecha = new PdfPCell(new Phrase(unaCompra.fechaCompra.ToShortDateString(), _standardFont));
                    clFecha.BorderWidth = 0;

                    PdfPCell clEstado = new PdfPCell(new Phrase(unaCompra.estado.ToString(), _standardFont));
                    clEstado.BorderWidth = 0;

                    // Añadimos las celdas a la tabla
                    tblPrueba.AddCell(clId);
                    tblPrueba.AddCell(clProveedor);
                    tblPrueba.AddCell(clFecha);
                    tblPrueba.AddCell(clEstado);
                }
            }

            doc.Add(new Paragraph("\n"));

            doc.Add(tblPrueba);

            doc.Close();
            writer.Close();

            System.Diagnostics.Process.Start(Application.StartupPath + @"\ListadoDeCompras.pdf");
        }
    }
}
