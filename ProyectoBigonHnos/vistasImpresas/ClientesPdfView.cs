using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.vistasImpresas
{
    class ClientesPdfView : IPdfView
    {
        public void imprimir()
        {
            
        }


        public void imprimir(List<Cliente> lista)
        {
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\Daniel\Desktop\ListadoDeClientes.pdf", FileMode.Create));
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
            title.Add("Listado de clientes");
            title.Alignment = 1;
            doc.Add(title);

            PdfPTable tblPrueba = new PdfPTable(4);
            tblPrueba.WidthPercentage = 90;

            PdfPCell clDniHeader = new PdfPCell(new Phrase("Dni", _standardFont2));
            clDniHeader.BorderWidth = 0;
            clDniHeader.BorderWidthBottom = 0.75f;
            clDniHeader.BackgroundColor = BaseColor.GRAY;

            PdfPCell clApellidoHeader = new PdfPCell(new Phrase("Apellido", _standardFont2));
            clApellidoHeader.BorderWidth = 0;
            clApellidoHeader.BorderWidthBottom = 0.75f;
            clApellidoHeader.BackgroundColor = BaseColor.GRAY;

            PdfPCell clNombreHeader = new PdfPCell(new Phrase("Nombre", _standardFont2));
            clNombreHeader.BorderWidth = 0;
            clNombreHeader.BorderWidthBottom = 0.75f;
            clNombreHeader.BackgroundColor = BaseColor.GRAY;

            PdfPCell clTelefonoHeader = new PdfPCell(new Phrase("Telefono", _standardFont2));
            clTelefonoHeader.BorderWidth = 0;
            clTelefonoHeader.BorderWidthBottom = 0.75f;
            clTelefonoHeader.BackgroundColor = BaseColor.GRAY;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clDniHeader);
            tblPrueba.AddCell(clApellidoHeader);
            tblPrueba.AddCell(clNombreHeader);
            tblPrueba.AddCell(clTelefonoHeader);

            foreach (Cliente unCliente in lista)
            {
                PdfPCell clDni = new PdfPCell(new Phrase(unCliente.Dni, _standardFont));
                clDni.BorderWidth = 0;

                PdfPCell clApellido = new PdfPCell(new Phrase(unCliente.Apellido, _standardFont));
                clApellido.BorderWidth = 0;

                PdfPCell clNombre = new PdfPCell(new Phrase(unCliente.Nombre, _standardFont));
                clNombre.BorderWidth = 0;

                PdfPCell clTel = new PdfPCell(new Phrase(unCliente.Telefonos[0].Numero, _standardFont));
                clTel.BorderWidth = 0;

                // Añadimos las celdas a la tabla
                tblPrueba.AddCell(clDni);
                tblPrueba.AddCell(clApellido);
                tblPrueba.AddCell(clNombre);
                tblPrueba.AddCell(clTel);
            }


            doc.Add(new Paragraph("\n"));

            doc.Add(tblPrueba);

            doc.Close();
            writer.Close();

            System.Diagnostics.Process.Start(@"C:\Users\Daniel\Desktop\ListadoDeClientes.pdf");
        }
    }
}
