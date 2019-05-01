using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.vistasImpresas
{
    class ProveedorPdfView
    {
        internal void imprimir(List<Proveedor> lista)
        {
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(Application.StartupPath + @"\ListadoDeProveedores.pdf", FileMode.Create));
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
            title.Add("Proveedores registrados");
            title.Alignment = 1;
            doc.Add(title);

            PdfPTable tblPrueba = new PdfPTable(5);
            tblPrueba.WidthPercentage = 90;

            PdfPCell clIdProvHeader = new PdfPCell(new Phrase("id_prov", _standardFont2));
            clIdProvHeader.BorderWidth = 0;
            clIdProvHeader.BorderWidthBottom = 0.75f;
            clIdProvHeader.BackgroundColor = BaseColor.GRAY;

            PdfPCell clRazonSocialHeader = new PdfPCell(new Phrase("razon_social", _standardFont2));
            clRazonSocialHeader.BorderWidth = 0;
            clRazonSocialHeader.BorderWidthBottom = 0.75f;
            clRazonSocialHeader.BackgroundColor = BaseColor.GRAY;

            PdfPCell clCuitHeader = new PdfPCell(new Phrase("cuit", _standardFont2));
            clCuitHeader.BorderWidth = 0;
            clCuitHeader.BorderWidthBottom = 0.75f;
            clCuitHeader.BackgroundColor = BaseColor.GRAY;

            PdfPCell clTelefonoHeader = new PdfPCell(new Phrase("telefono", _standardFont2));
            clTelefonoHeader.BorderWidth = 0;
            clTelefonoHeader.BorderWidthBottom = 0.75f;
            clTelefonoHeader.BackgroundColor = BaseColor.GRAY;

            PdfPCell clDireccionHeader = new PdfPCell(new Phrase("direccion", _standardFont2));
            clDireccionHeader.BorderWidth = 0;
            clDireccionHeader.BorderWidthBottom = 0.75f;
            clDireccionHeader.BackgroundColor = BaseColor.GRAY;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clIdProvHeader);
            tblPrueba.AddCell(clRazonSocialHeader);
            tblPrueba.AddCell(clCuitHeader);
            tblPrueba.AddCell(clTelefonoHeader);
            tblPrueba.AddCell(clDireccionHeader);

            foreach (Proveedor unProveedor in lista)
            {

                PdfPCell clId = new PdfPCell(new Phrase(unProveedor.IdProveedor.ToString(), _standardFont));
                clId.BorderWidth = 0;

                PdfPCell clRazonSocial = new PdfPCell(new Phrase(unProveedor.RazonSocial, _standardFont));
                clRazonSocial.BorderWidth = 0;

                PdfPCell clCuit = new PdfPCell(new Phrase(unProveedor.Cuit, _standardFont));
                clCuit.BorderWidth = 0;

                PdfPCell clTelefono = new PdfPCell(new Phrase(unProveedor.Telefonos[0].Numero, _standardFont));
                clTelefono.BorderWidth = 0;

                String domicilio = String.Format("{0}, {1} - {2}, {3}", unProveedor.Domicilios[0].Calle, unProveedor.Domicilios[0].Numero,
                    unProveedor.Domicilios[0].Localidad.Nombre,
                    unProveedor.Domicilios[0].Localidad.Provincia.Nombre);

                PdfPCell clDomicilio = new PdfPCell(new Phrase(domicilio, _standardFont));
                clDomicilio.BorderWidth = 0;

                // Añadimos las celdas a la tabla
                tblPrueba.AddCell(clId);
                tblPrueba.AddCell(clRazonSocial);
                tblPrueba.AddCell(clCuit);
                tblPrueba.AddCell(clTelefono);
                tblPrueba.AddCell(clDomicilio);
            }

            doc.Add(new Paragraph("\n"));

            doc.Add(tblPrueba);

            doc.Close();
            writer.Close();

            System.Diagnostics.Process.Start(Application.StartupPath + @"\ListadoDeProveedores.pdf");
        }

    }
}
