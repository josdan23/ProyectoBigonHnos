﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.dominio.pedido;
using System.IO;
using System.Windows.Forms;

namespace ProyectoBigonHnos.vistasImpresas
{
    class NuevoPedidoPdfView
    {

        public void imprimir(Pedido pedido)
        {
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(Application.StartupPath +  @"\Pedido.pdf", FileMode.Create));
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


            PdfPCell encabezadoCell = new PdfPCell(new Phrase("PEDIDO", _standardFont))
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

            tableHeader.AddCell(new PdfPCell(new Phrase("Fecha de pedido: " + pedido.fechaDePedido.ToShortDateString(), _standardFont3))
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

            tableHeader.AddCell(new PdfPCell(new Phrase("Nro pedido: " + pedido.idPedido, _standardFont3))
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

            tableHeader.AddCell(new PdfPCell(new Phrase("Fecha de entrega: " + pedido.fechaDeEntrega.ToShortDateString(), _standardFont3))
            {
                Border = 0,
                HorizontalAlignment = Element.ALIGN_RIGHT,
                BackgroundColor = grisClaro
            });

            doc.Add(tableHeader);


            //TABLA DE CLIENTES

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
            tableCliente.AddCell(new PdfPCell(new Phrase(pedido.cliente.Dni, _standardFont3))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tableCliente.AddCell(new PdfPCell(new Phrase("Apellido:", _standardFont3))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tableCliente.AddCell(new PdfPCell(new Phrase(pedido.cliente.Apellido, _standardFont3))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tableCliente.AddCell(new PdfPCell(new Phrase("Nombre:", _standardFont3))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tableCliente.AddCell(new PdfPCell(new Phrase(pedido.cliente.Nombre, _standardFont3))
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

            tablaProductos.AddCell(new PdfPCell(new Phrase("Desc",fontNegraBold))
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

            foreach (LineaPedido pl in pedido.lineasDePedido)
            {
                tablaProductos.AddCell(new PdfPCell(new Phrase(pl.producto.descripcion, _standardFont3))
                {
                    Border = 0
                });
                tablaProductos.AddCell(new PdfPCell(new Phrase(pl.producto.alto.ToString(), _standardFont3))
                {
                    Border = 0
                });
                tablaProductos.AddCell(new PdfPCell(new Phrase(pl.producto.ancho.ToString(), _standardFont3))
                {
                    Border = 0
                });
                tablaProductos.AddCell(new PdfPCell(new Phrase(pl.producto.profundidad.ToString(), _standardFont3))
                {
                    Border = 0
                });
                tablaProductos.AddCell(new PdfPCell(new Phrase(pl.producto.colorPrimario.ToString(), _standardFont3))
                {
                    Border = 0
                });
                tablaProductos.AddCell(new PdfPCell(new Phrase(pl.producto.colorSecundario, _standardFont3))
                {
                    Border = 0
                });
                tablaProductos.AddCell(new PdfPCell(new Phrase(pl.cantidad.ToString(), _standardFont3))
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

            foreach (ListaMaterial lm in pedido.ListaDeMateriales)
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

            foreach(CostoExtra unCosto in pedido.costosExtras)
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
            tablaTotal.AddCell(new PdfPCell(new Phrase( pedido.obtenerSubtotalDeMateriales().ToString()))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                Border = 0
            });
            tablaTotal.AddCell(new PdfPCell(new Phrase("Subtotal extras", fontNegraBold))
            {
                HorizontalAlignment = Element.ALIGN_RIGHT,
                Border = 0
            });
            tablaTotal.AddCell(new PdfPCell(new Phrase(pedido.obtenerSubtotalCostosExtras().ToString()))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                Border = 0
            });
            tablaTotal.AddCell(new PdfPCell(new Phrase("Total", fontNegraBold))
            {
                HorizontalAlignment = Element.ALIGN_RIGHT,
                Border = 0
            });
            tablaTotal.AddCell(new PdfPCell(new Phrase(pedido.obtenerTotal().ToString()))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                Border = 0,
                BackgroundColor = grisClaro
            });

            doc.Add(tablaTotal);

            doc.Close();
            writer.Close();

            System.Diagnostics.Process.Start(Application.StartupPath + @"\Pedido.pdf");

        }

    }
}
