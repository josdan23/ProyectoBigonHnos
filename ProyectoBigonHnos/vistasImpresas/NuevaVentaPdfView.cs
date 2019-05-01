using iTextSharp.text;
using iTextSharp.text.pdf;
using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.dominio.pedido;
using ProyectoBigonHnos.dominio.venta;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBigonHnos.vistasImpresas
{
    class NuevaVentaPdfView
    {
        public void imprimir(Venta venta)
        {
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(Application.StartupPath + @"\ReciboVenta.pdf", FileMode.Create));
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


            PdfPCell encabezadoCell = new PdfPCell(new Phrase("RECIBO", _standardFont))
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

            tableHeader.AddCell(new PdfPCell(new Phrase("Fecha: " + venta.fechaDeVenta, _standardFont3))
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

            tableHeader.AddCell(new PdfPCell(new Phrase("Nro: " + venta.IdVenta, _standardFont3))
            {
                Border = 0,
                HorizontalAlignment = Element.ALIGN_RIGHT
            });


            tableHeader.AddCell(new PdfPCell(new Phrase("Mail: mail@mail.com", _standardFont3))
            {
                Border = 0
            });

            tableHeader.AddCell(new PdfPCell(new Phrase(""))
            {
                Border = 0
            });

            tableHeader.AddCell(new PdfPCell(new Phrase("", _standardFont3))
            {
                Border = 0,
                HorizontalAlignment = Element.ALIGN_RIGHT,
                BackgroundColor = grisClaro
            });

            doc.Add(tableHeader);

            BaseColor colorAzulClaro = new BaseColor(157, 181, 204);
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("\n"));

            PdfPTable tableCliente = new PdfPTable(new float[] { 1, 5 });
            tableCliente.WidthPercentage = 100;

            tableCliente.AddCell(new PdfPCell(new Phrase("Cliente", fontNegraBold))
            {
                Colspan = 2,
                BackgroundColor = grisClaro,
                Border = 0
            });

            tableCliente.AddCell(new PdfPCell(new Phrase("Dni:", _standardFont3))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tableCliente.AddCell(new PdfPCell(new Phrase(venta.Cliente.Dni, _standardFont3))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tableCliente.AddCell(new PdfPCell(new Phrase("Apellido:", _standardFont3))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tableCliente.AddCell(new PdfPCell(new Phrase(venta.Cliente.Apellido, _standardFont3))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tableCliente.AddCell(new PdfPCell(new Phrase("Nombre:", _standardFont3))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tableCliente.AddCell(new PdfPCell(new Phrase(venta.Cliente.Nombre, _standardFont3))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            doc.Add(tableCliente);


            //TABLA DE PRODUCTOS

            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("\n"));
            PdfPTable tablaProductos = new PdfPTable(7);
            tablaProductos.WidthPercentage = 100;
            tablaProductos.AddCell(new PdfPCell(new Phrase("Productos", fontBlanca))
            {
                Border = 0,
                BackgroundColor = azulOscuro,
                Colspan = 7
            });

            tablaProductos.AddCell(new PdfPCell(new Phrase("Desc", fontNegraBold))
            {
                Border = 0,
                BackgroundColor = grisClaro
            });
            tablaProductos.AddCell(new PdfPCell(new Phrase("Alto", fontNegraBold))
            {
                Border = 0,
                BackgroundColor = grisClaro
            });
            tablaProductos.AddCell(new PdfPCell(new Phrase("Ancho", fontNegraBold))
            {
                Border = 0,
                BackgroundColor = grisClaro
            });
            tablaProductos.AddCell(new PdfPCell(new Phrase("Prof", fontNegraBold))
            {
                Border = 0,
                BackgroundColor = grisClaro
            });
            tablaProductos.AddCell(new PdfPCell(new Phrase("Color_p", fontNegraBold))
            {
                Border = 0,
                BackgroundColor = grisClaro
            });
            tablaProductos.AddCell(new PdfPCell(new Phrase("Color_s", fontNegraBold))
            {
                Border = 0,
                BackgroundColor = grisClaro
            });
            tablaProductos.AddCell(new PdfPCell(new Phrase("cantidad", fontNegraBold))
            {
                Border = 0,
                BackgroundColor = grisClaro
            });

            foreach (LineaVenta lv in venta.lineasDeVenta)
            {
                tablaProductos.AddCell(new PdfPCell(new Phrase(lv.producto.descripcion, _standardFont3))
                {
                    Border = 0
                });
                tablaProductos.AddCell(new PdfPCell(new Phrase(lv.producto.alto.ToString(), _standardFont3))
                {
                    Border = 0
                });
                tablaProductos.AddCell(new PdfPCell(new Phrase(lv.producto.ancho.ToString(), _standardFont3))
                {
                    Border = 0
                });
                tablaProductos.AddCell(new PdfPCell(new Phrase(lv.producto.profundidad.ToString(), _standardFont3))
                {
                    Border = 0
                });
                tablaProductos.AddCell(new PdfPCell(new Phrase(lv.producto.colorPrimario.ToString(), _standardFont3))
                {
                    Border = 0
                });
                tablaProductos.AddCell(new PdfPCell(new Phrase(lv.producto.colorSecundario, _standardFont3))
                {
                    Border = 0
                });
                tablaProductos.AddCell(new PdfPCell(new Phrase(lv.cantidad.ToString(), _standardFont3))
                {
                    Border = 0
                });
            }

            doc.Add(tablaProductos);

            //TABLA DE MATERIALES

            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("\n"));
            PdfPTable tablaMateriales = new PdfPTable(new float[] { 2, 2, 2, 1 });
            tablaMateriales.WidthPercentage = 100;
            tablaMateriales.AddCell(new PdfPCell(new Phrase("Materiales", fontBlanca))
            {
                Border = 0,
                BackgroundColor = azulOscuro,
                Colspan = 4
            });

            tablaMateriales.AddCell(new PdfPCell(new Phrase("Material", fontNegraBold))
            {
                Border = 0,
                BackgroundColor = grisClaro
            });
            tablaMateriales.AddCell(new PdfPCell(new Phrase("Precio", fontNegraBold))
            {
                Border = 0,
                BackgroundColor = grisClaro
            });
            tablaMateriales.AddCell(new PdfPCell(new Phrase("Cantidad", fontNegraBold))
            {
                Border = 0,
                BackgroundColor = grisClaro
            });
            tablaMateriales.AddCell(new PdfPCell(new Phrase("Total", fontNegraBold))
            {
                Border = 0,
                BackgroundColor = grisClaro
            });

            foreach (ListaDeMateriales lm in venta.materialesNecesarios)
            {
                tablaMateriales.AddCell(new PdfPCell(new Phrase(lm.material.Descripcion, _standardFont3))
                {
                    Border = 0
                });
                tablaMateriales.AddCell(new PdfPCell(new Phrase(lm.material.Precio.ToString(), _standardFont3))
                {
                    Border = 0
                });
                tablaMateriales.AddCell(new PdfPCell(new Phrase(lm.cantidad.ToString(), _standardFont3))
                {
                    Border = 0
                });
                tablaMateriales.AddCell(new PdfPCell(new Phrase(lm.getSubtotal().ToString(), _standardFont3))
                {
                    Border = 0
                });
            }
            doc.Add(tablaMateriales);


            //TABLA DE COSTOS EXTRAS
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("\n"));

            PdfPTable tablaExtras = new PdfPTable(new float[] { 6, 1 });
            tablaExtras.WidthPercentage = 100;

            tablaExtras.AddCell(new PdfPCell(new Phrase("Costos extras", fontBlanca))
            {
                Border = 0,
                BackgroundColor = azulOscuro,
                Colspan = 2
            });

            tablaExtras.AddCell(new PdfPCell(new Phrase("Descripcion", fontNegraBold))
            {
                Border = 0,
                BackgroundColor = grisClaro
            });
            tablaExtras.AddCell(new PdfPCell(new Phrase("Costo", fontNegraBold))
            {
                Border = 0,
                BackgroundColor = grisClaro
            });

            foreach (CostoExtra unCosto in venta.costosExtras)
            {
                tablaExtras.AddCell(new PdfPCell(new Phrase(unCosto.descripcion, _standardFont3))
                {
                    Border = 0
                });
                tablaExtras.AddCell(new PdfPCell(new Phrase(unCosto.importe.ToString(), _standardFont3))
                {
                    Border = 0
                });
            }

            doc.Add(tablaExtras);

            //TABLA TOTALES
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("\n"));

            PdfPTable tablaTotal = new PdfPTable(new float[] { 6, 1 });
            tablaTotal.WidthPercentage = 100;

            tablaTotal.AddCell(new PdfPCell(new Phrase("Subtotal materiales", fontNegraBold))
            {
                HorizontalAlignment = Element.ALIGN_RIGHT,
                Border = 0
            });
            tablaTotal.AddCell(new PdfPCell(new Phrase(venta.obtenerSubtotalMateriales().ToString()))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                Border = 0
            });
            tablaTotal.AddCell(new PdfPCell(new Phrase("Subtotal extras", fontNegraBold))
            {
                HorizontalAlignment = Element.ALIGN_RIGHT,
                Border = 0
            });
            tablaTotal.AddCell(new PdfPCell(new Phrase(venta.obtenerSubtotalCostosExtras().ToString()))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                Border = 0
            });

            tablaTotal.AddCell(new PdfPCell(new Phrase("IVA(21%)", fontNegraBold))
            {
                HorizontalAlignment = Element.ALIGN_RIGHT,
                Border = 0
            });
            tablaTotal.AddCell(new PdfPCell(new Phrase(venta.obtenerTotalIva().ToString()))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                Border = 0
            });

            tablaTotal.AddCell(new PdfPCell(new Phrase("Total", fontNegraBold))
            {
                HorizontalAlignment = Element.ALIGN_RIGHT,
                Border = 0
            });
            tablaTotal.AddCell(new PdfPCell(new Phrase(venta.obtenerImporteTotal().ToString()))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                Border = 0,
                BackgroundColor = grisClaro
            });

            doc.Add(tablaTotal);

            doc.Close();
            writer.Close();

            System.Diagnostics.Process.Start(Application.StartupPath + @"\ReciboVenta.pdf");

        }
    }
}
