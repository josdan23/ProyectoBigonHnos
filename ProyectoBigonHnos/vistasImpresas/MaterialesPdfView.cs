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
    class MaterialesPdfView
    {

        public void imprimir(List<Material> lista)
        {
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(Application.StartupPath + @"\ListadoDeMateriales.pdf", FileMode.Create));
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
            title.Add("Listado de Materiales");
            title.Alignment = 1;
            doc.Add(title);

            PdfPTable tblPrueba = new PdfPTable(6);
            tblPrueba.WidthPercentage = 97;

            PdfPCell clIdHeader = new PdfPCell(new Phrase("id", _standardFont2));
            clIdHeader.BorderWidth = 0;
            clIdHeader.BorderWidthBottom = 0.75f;
            clIdHeader.BackgroundColor = BaseColor.GRAY;

            PdfPCell clDescHeader = new PdfPCell(new Phrase("descr", _standardFont2));
            clDescHeader.BorderWidth = 0;
            clDescHeader.BorderWidthBottom = 0.75f;
            clDescHeader.BackgroundColor = BaseColor.GRAY;

            PdfPCell clPrecioHeader = new PdfPCell(new Phrase("precio", _standardFont2));
            clPrecioHeader.BorderWidth = 0;
            clPrecioHeader.BorderWidthBottom = 0.75f;
            clPrecioHeader.BackgroundColor = BaseColor.GRAY;

            PdfPCell clStockDispHeader = new PdfPCell(new Phrase("stock_disp", _standardFont2));
            clStockDispHeader.BorderWidth = 0;
            clStockDispHeader.BorderWidthBottom = 0.75f;
            clStockDispHeader.BackgroundColor = BaseColor.GRAY;

            PdfPCell clStockMinHeader = new PdfPCell(new Phrase("stock_min", _standardFont2));
            clStockMinHeader.BorderWidth = 0;
            clStockMinHeader.BorderWidthBottom = 0.75f;
            clStockMinHeader.BackgroundColor = BaseColor.GRAY;

            PdfPCell clUnidadHeader = new PdfPCell(new Phrase("unidad", _standardFont2));
            clUnidadHeader.BorderWidth = 0;
            clUnidadHeader.BorderWidthBottom = 0.75f;
            clUnidadHeader.BackgroundColor = BaseColor.GRAY;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clIdHeader);
            tblPrueba.AddCell(clDescHeader);
            tblPrueba.AddCell(clPrecioHeader);
            tblPrueba.AddCell(clStockDispHeader);
            tblPrueba.AddCell(clStockMinHeader);
            tblPrueba.AddCell(clUnidadHeader);

            foreach (Material unMaterial in lista)
            {
                PdfPCell clId = new PdfPCell(new Phrase(unMaterial.IdMaterial.ToString(), _standardFont));
                clId.BorderWidth = 0;

                PdfPCell clDescripcion = new PdfPCell(new Phrase(unMaterial.Descripcion, _standardFont));
                clDescripcion.BorderWidth = 0;

                PdfPCell clPrecio = new PdfPCell(new Phrase(unMaterial.Precio.ToString(), _standardFont));
                clPrecio.BorderWidth = 0;

                PdfPCell clStockDisponible = new PdfPCell(new Phrase(unMaterial.StockDisponible.ToString(), _standardFont));
                clStockDisponible.BorderWidth = 0;

                PdfPCell clStockMinimo = new PdfPCell(new Phrase(unMaterial.StockMinimo.ToString(), _standardFont));
                clStockMinimo.BorderWidth = 0;

                PdfPCell clUnidad = new PdfPCell(new Phrase(unMaterial.tipoUnidad, _standardFont));
                clUnidad.BorderWidth = 0;

                // Añadimos las celdas a la tabla
                tblPrueba.AddCell(clId);
                tblPrueba.AddCell(clDescripcion);
                tblPrueba.AddCell(clPrecio);
                tblPrueba.AddCell(clStockDisponible);
                tblPrueba.AddCell(clStockMinimo);
                tblPrueba.AddCell(clUnidad);
            }


            doc.Add(new Paragraph("\n"));

            doc.Add(tblPrueba);

            doc.Close();
            writer.Close();

            System.Diagnostics.Process.Start(Application.StartupPath + @"\ListadoDeMateriales.pdf");
        }

    }
}
