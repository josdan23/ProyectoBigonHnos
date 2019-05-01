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
    class NuevaCompraPdfView
    {
        public void imprimir(Compra compra)
        {
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(Application.StartupPath + @"OrdenDeCompra.pdf", FileMode.Create));
            doc.Open();

            Font _standardFont = new Font(Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            Font _standardFont2 = new Font(Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.NORMAL, BaseColor.RED);
            Font _standardFont3 = new Font(Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            Font fontNegraBold = new Font(Font.FontFamily.HELVETICA, 10, Font.BOLD, BaseColor.BLACK);
            Font fontBlanca = new Font(Font.FontFamily.HELVETICA, 10, Font.BOLD, BaseColor.WHITE);

            BaseColor grisClaro = new BaseColor(203, 209, 215);
            BaseColor azulOscuro = new BaseColor(62, 93, 124);

            PdfPTable tableHeader = new PdfPTable(3);
            tableHeader.WidthPercentage = 100;

            PdfPCell logoCell = new PdfPCell(new Phrase("Bigons Hnos", _standardFont2));
            logoCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            logoCell.Border = 0;
            tableHeader.AddCell(logoCell);


            PdfPCell encabezadoCell = new PdfPCell(new Phrase("ORDEN DE COMPRA", _standardFont))
            {
                Colspan = 2,
                Rowspan = 2,
                HorizontalAlignment = Element.ALIGN_CENTER,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                Border = 1,
                BorderWidthBottom = 1,
                BorderWidthLeft = 1,
                BorderWidthRight = 1,
                BackgroundColor = grisClaro
            };
            tableHeader.AddCell(encabezadoCell);


            PdfPCell dirCell = new PdfPCell(new Phrase("Lavalle 233", _standardFont3))
            {
                Border = 0
            };
            tableHeader.AddCell(dirCell);


            PdfPCell telCell = new PdfPCell(new Phrase("Tel: 3920302", _standardFont3))
            {
                Border = 0
            };
            tableHeader.AddCell(telCell);

            tableHeader.AddCell(new PdfPCell()
            {
                Border = 0
            });

            tableHeader.AddCell(new PdfPCell(new Phrase("Fecha: " + compra.fechaCompra, _standardFont3))
            {
                Border = 0,
                HorizontalAlignment = Element.ALIGN_RIGHT
            });

            tableHeader.AddCell(new PdfPCell(new Phrase("Cuit: 8392398893893", _standardFont3))
            {
                Border = 0
            });

            tableHeader.AddCell(new PdfPCell(new Phrase(""))
            {
                Border = 0
            });

            tableHeader.AddCell(new PdfPCell(new Phrase("Nro pedido: " + compra.IdCompra, _standardFont3))
            {
                Border = 0,
                HorizontalAlignment = Element.ALIGN_RIGHT
            });


            tableHeader.AddCell(new PdfPCell(new Phrase("Mail: mail@mail.com", _standardFont3))
            {
                Border = 0
            });

            doc.Add(tableHeader);


            //TABLA DE PROVEEDORES
            BaseColor colorAzulClaro = new BaseColor(157, 181, 204);
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("\n"));

            PdfPTable tableCliente = new PdfPTable(new float[] { 1, 5 });
            tableCliente.WidthPercentage = 100;

            tableCliente.AddCell(new PdfPCell(new Phrase("Proveedor", fontNegraBold))
            {
                Colspan = 2,
                BackgroundColor = grisClaro,
                Border = 0
            });

            tableCliente.AddCell(new PdfPCell(new Phrase("Razon social:", _standardFont3))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tableCliente.AddCell(new PdfPCell(new Phrase(compra.proveedor.RazonSocial, _standardFont3))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tableCliente.AddCell(new PdfPCell(new Phrase("CUIT:", _standardFont3))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tableCliente.AddCell(new PdfPCell(new Phrase(compra.proveedor.Cuit, _standardFont3))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tableCliente.AddCell(new PdfPCell(new Phrase("Tel:", _standardFont3))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tableCliente.AddCell(new PdfPCell(new Phrase(compra.proveedor.Telefonos[0].Numero, _standardFont3))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tableCliente.AddCell(new PdfPCell(new Phrase("Dirección:", _standardFont3))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });

            String direccion = String.Format("{0},{1}-{2},{3}",
                compra.proveedor.Domicilios[0].Calle,
                compra.proveedor.Domicilios[0].Numero,
                compra.proveedor.Domicilios[0].Localidad.Nombre,
                compra.proveedor.Domicilios[0].Localidad.Provincia.Nombre);

            tableCliente.AddCell(new PdfPCell(new Phrase(direccion, _standardFont3))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            doc.Add(tableCliente);


            //tabla de lineas de compra

            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("\n"));
            PdfPTable tablaProductos = new PdfPTable(3);
            tablaProductos.WidthPercentage = 100;
            tablaProductos.AddCell(new PdfPCell(new Phrase("Materiales", fontBlanca))
            {
                Border = 0,
                BackgroundColor = azulOscuro,
                Colspan = 7
            });

            tablaProductos.AddCell(new PdfPCell(new Phrase("id_material", fontNegraBold))
            {
                Border = 0,
                BackgroundColor = grisClaro
            });
            tablaProductos.AddCell(new PdfPCell(new Phrase("Descripcion", fontNegraBold))
            {
                Border = 0,
                BackgroundColor = grisClaro
            });
            tablaProductos.AddCell(new PdfPCell(new Phrase("Cantidad", fontNegraBold))
            {
                Border = 0,
                BackgroundColor = grisClaro
            });
            

            foreach (LineaCompra lc in compra.lineasDeCompra)
            {
                tablaProductos.AddCell(new PdfPCell(new Phrase(lc.material.IdMaterial.ToString(), _standardFont3))
                {
                    Border = 0
                });
                tablaProductos.AddCell(new PdfPCell(new Phrase(lc.material.Descripcion, _standardFont3))
                {
                    Border = 0
                });
                tablaProductos.AddCell(new PdfPCell(new Phrase(lc.cantidad.ToString(), _standardFont3))
                {
                    Border = 0
                });
                
            }

            doc.Add(tablaProductos);

            doc.Close();
            writer.Close();

            System.Diagnostics.Process.Start(Application.StartupPath + @"\OrdenDeCompra.pdf");

        }
    }
}
