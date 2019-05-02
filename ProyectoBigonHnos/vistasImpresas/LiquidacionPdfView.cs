using iTextSharp.text;
using iTextSharp.text.pdf;
using ProyectoBigonHnos.dominio.liquidacion;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBigonHnos.vistasImpresas
{
    class LiquidacionPdfView
    {

        public void imprimir(Liquidacion liquidacion)
        {
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(Application.StartupPath + @"\Liquidacion.pdf", FileMode.Create));
            doc.Open();

            //FONTS
            Font _standardFont2 = new Font(Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.NORMAL, BaseColor.RED);
            Font fontNegra10 = new Font(Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            Font fontBlanca10 = new Font(Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.WHITE);
            Font fontBlanca10Bold = new Font(Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
            Font fontNegra10Simple = new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL, BaseColor.BLACK);
            Font _standardFont = new Font(Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            //COLORES
            BaseColor azulOscuro = new BaseColor(62, 93, 124);
            BaseColor grisClaro = new BaseColor(215, 223, 232);


            PdfPTable tableHeader = new PdfPTable(3);
            tableHeader.WidthPercentage = 100;

            PdfPCell logoCell = new PdfPCell(new Phrase("Bigons Hnos", _standardFont2));
            logoCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            logoCell.Border = 0;
            tableHeader.AddCell(logoCell);

            PdfPCell encabezadoCell = new PdfPCell(new Phrase("RECIBO DE HABERES", _standardFont))
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


            PdfPCell dirCell = new PdfPCell(new Phrase("Lavalle 233", fontNegra10Simple))
            {
                Border = 0
            };
            tableHeader.AddCell(dirCell);


            PdfPCell telCell = new PdfPCell(new Phrase("Tel: 3920302", fontNegra10Simple))
            {
                Border = 0
            };
            tableHeader.AddCell(telCell);

            tableHeader.AddCell(new PdfPCell()
            {
                Border = 0
            });

            tableHeader.AddCell(new PdfPCell(new Phrase(".", fontNegra10Simple))
            {
                Border = 0,
                HorizontalAlignment = Element.ALIGN_RIGHT
            });

            tableHeader.AddCell(new PdfPCell(new Phrase("Cuit: 8392398893893", fontNegra10Simple))
            {
                Border = 0
            });

            tableHeader.AddCell(new PdfPCell(new Phrase(""))
            {
                Border = 0
            });

            tableHeader.AddCell(new PdfPCell(new Phrase(".", fontNegra10Simple))
            {
                Border = 0,
                HorizontalAlignment = Element.ALIGN_RIGHT
            });


            tableHeader.AddCell(new PdfPCell(new Phrase("Mail: mail@mail.com", fontNegra10Simple))
            {
                Border = 0
            });

            tableHeader.AddCell(new PdfPCell(new Phrase(""))
            {
                Border = 0
            });

            tableHeader.AddCell(new PdfPCell(new Phrase(".", fontNegra10Simple))
            {
                Border = 0,
                HorizontalAlignment = Element.ALIGN_RIGHT,
                BackgroundColor = grisClaro
            });

            doc.Add(tableHeader);

            //TABLA DE EMPLEADO
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("\n"));

            PdfPTable tablaEmpleado = new PdfPTable(4);
            tablaEmpleado.WidthPercentage = 100;

            tablaEmpleado.AddCell(new PdfPCell(new Phrase("Legajo", fontNegra10))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tablaEmpleado.AddCell(new PdfPCell(new Phrase("Apellido y Nombre", fontNegra10))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tablaEmpleado.AddCell(new PdfPCell(new Phrase(""))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tablaEmpleado.AddCell(new PdfPCell(new Phrase("Cuit", fontNegra10))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });

            tablaEmpleado.AddCell(new PdfPCell(new Phrase(liquidacion.Empleado.Legajo))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });//ingresar legajo
            String apellidoYNombre = liquidacion.Empleado.Apellido + ", " + liquidacion.Empleado.Nombre;
            tablaEmpleado.AddCell(new PdfPCell(new Phrase(apellidoYNombre))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });//igresar nombre
            tablaEmpleado.AddCell(new PdfPCell(new Phrase(""))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tablaEmpleado.AddCell(new PdfPCell(new Phrase(liquidacion.Empleado.Cuil))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });//cuit


            tablaEmpleado.AddCell(new PdfPCell(new Phrase(".")) {
                BackgroundColor = grisClaro,
                Colspan = 4,
                Border = 0
            });


            tablaEmpleado.AddCell(new PdfPCell(new Phrase("Categoria", fontNegra10))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tablaEmpleado.AddCell(new PdfPCell(new Phrase("Lugar de cobro", fontNegra10))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tablaEmpleado.AddCell(new PdfPCell(new Phrase(""))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tablaEmpleado.AddCell(new PdfPCell(new Phrase(""))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });

            tablaEmpleado.AddCell(new PdfPCell(new Phrase(liquidacion.Empleado.Categoria))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tablaEmpleado.AddCell(new PdfPCell(new Phrase(liquidacion.LugarPago))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tablaEmpleado.AddCell(new PdfPCell(new Phrase(""))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tablaEmpleado.AddCell(new PdfPCell(new Phrase(""))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });

            tablaEmpleado.AddCell(new PdfPCell(new Phrase("."))
            {
                BackgroundColor = grisClaro,
                Border = 0,
                Colspan = 4
            });

            tablaEmpleado.AddCell(new PdfPCell(new Phrase("Fecha de ingreso", fontNegra10))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tablaEmpleado.AddCell(new PdfPCell(new Phrase("Periodo", fontNegra10))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tablaEmpleado.AddCell(new PdfPCell(new Phrase("Fecha de pago", fontNegra10))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });
            tablaEmpleado.AddCell(new PdfPCell(new Phrase("Nro de recibo", fontNegra10))
            {
                BackgroundColor = grisClaro,
                Border = 0
            });

            tablaEmpleado.AddCell(new PdfPCell(new Phrase(liquidacion.Empleado.FechaIngreso.ToShortDateString()))
            {
                BackgroundColor = grisClaro,
                Border = 0
            }); //fechas de ingreso
            tablaEmpleado.AddCell(new PdfPCell(new Phrase(liquidacion.PeriodoLiquidacion.ToString()))
            {
                BackgroundColor = grisClaro,
                Border = 0
            }); //periodo
            tablaEmpleado.AddCell(new PdfPCell(new Phrase(DateTime.Now.ToShortDateString()))
            {
                BackgroundColor = grisClaro,
                Border = 0
            }); // fecha de pago
            tablaEmpleado.AddCell(new PdfPCell(new Phrase(liquidacion.IdLiquidacion.ToString()))
            {
                BackgroundColor = grisClaro,
                Border = 0
            }); //nro de recibo

            doc.Add(tablaEmpleado);


            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("\n"));
            //tabla de liquidación
            PdfPTable tablaLiquidacion = new PdfPTable(6);
            tablaLiquidacion.WidthPercentage = 100;

            tablaLiquidacion.AddCell(new PdfPCell(new Phrase("id_concept", fontBlanca10Bold))
            {
                Border = 0,
                BackgroundColor = azulOscuro
            });
            tablaLiquidacion.AddCell(new PdfPCell(new Phrase("concept", fontBlanca10Bold))
            {
                Border = 0,
                BackgroundColor = azulOscuro
            });
            tablaLiquidacion.AddCell(new PdfPCell(new Phrase("cantidad", fontBlanca10Bold))
            {
                Border = 0,
                BackgroundColor = azulOscuro
            });
            tablaLiquidacion.AddCell(new PdfPCell(new Phrase("remunerativo", fontBlanca10Bold))
            {
                Border = 0,
                BackgroundColor = azulOscuro
            });
            tablaLiquidacion.AddCell(new PdfPCell(new Phrase("no_remunerativo", fontBlanca10Bold))
            {
                Border = 0,
                BackgroundColor = azulOscuro
            });
            tablaLiquidacion.AddCell(new PdfPCell(new Phrase("descuento", fontBlanca10Bold))
            {
                Border = 0,
                BackgroundColor = azulOscuro
            });

            foreach (LineaLiquidacion unaLinea in liquidacion.LineasLiquidacion)
            {
                tablaLiquidacion.AddCell(new PdfPCell(new Phrase(unaLinea.Concepto.IdConcepto.ToString(), fontNegra10Simple))
                {
                    Border = 0,
                    BackgroundColor = grisClaro
                });
                tablaLiquidacion.AddCell(new PdfPCell(new Phrase(unaLinea.Concepto.Descripcion, fontNegra10Simple))
                {
                    Border = 0
                });
                tablaLiquidacion.AddCell(new PdfPCell(new Phrase(unaLinea.Cantidad.ToString(), fontNegra10Simple))
                {
                    Border = 0,
                    BackgroundColor = grisClaro
                });

                if (unaLinea.Concepto.Tipo == TipoConcepto.REMUNERATIVO)
                {
                    tablaLiquidacion.AddCell(new PdfPCell(new Phrase(unaLinea.getImporte().ToString(), fontNegra10Simple))
                    {
                        Border = 0
                    });
                    tablaLiquidacion.AddCell(new PdfPCell(new Phrase("", fontNegra10Simple))
                    {
                        BackgroundColor = grisClaro,
                        Border = 0
                    });
                    tablaLiquidacion.AddCell(new PdfPCell(new Phrase("", fontNegra10Simple))
                    {
                        Border = 0
                    });
                }
                else if (unaLinea.Concepto.Tipo == TipoConcepto.NO_REMUNERATIVO)
                {
                    tablaLiquidacion.AddCell(new PdfPCell(new Phrase("", fontNegra10Simple))
                    {
                        Border = 0
                    });
                    tablaLiquidacion.AddCell(new PdfPCell(new Phrase(unaLinea.getImporte().ToString(), fontNegra10Simple))
                    {
                        BackgroundColor = grisClaro,
                        Border = 0
                    });
                    tablaLiquidacion.AddCell(new PdfPCell(new Phrase("", fontNegra10Simple))
                    {
                        Border = 0
                    });
                }
                else
                {
                    tablaLiquidacion.AddCell(new PdfPCell(new Phrase("", fontNegra10Simple))
                    {
                        Border = 0
                    });
                    tablaLiquidacion.AddCell(new PdfPCell(new Phrase("", fontNegra10Simple))
                    {
                        BackgroundColor = grisClaro,
                        Border = 0
                    });
                    tablaLiquidacion.AddCell(new PdfPCell(new Phrase(unaLinea.getImporte().ToString(), fontNegra10Simple))
                    {
                        Border = 0
                    });
                }

            }

            doc.Add(tablaLiquidacion);

            PdfPTable tablaTotales = new PdfPTable(6);
            tablaTotales.WidthPercentage = 100;

            tablaTotales.AddCell(new PdfPCell(new Phrase("", fontNegra10Simple))
            {
                Border = 0
            });
            tablaTotales.AddCell(new PdfPCell(new Phrase("", fontNegra10Simple))
            {
                Border = 0
            });
            tablaTotales.AddCell(new PdfPCell(new Phrase("", fontNegra10Simple))
            {
                Border = 0
            });
            tablaTotales.AddCell(new PdfPCell(new Phrase(liquidacion.getTotalRemunerativo().ToString(), fontNegra10Simple))
            {
                BorderColor = grisClaro
            });
            tablaTotales.AddCell(new PdfPCell(new Phrase(liquidacion.getTotalNoRemunerativo().ToString(), fontNegra10Simple))
            {
                BorderColor = grisClaro
            });
            tablaTotales.AddCell(new PdfPCell(new Phrase(liquidacion.getTotalDescuento().ToString(), fontNegra10Simple))
            {
                BorderColor = grisClaro
            });


            tablaTotales.AddCell(new PdfPCell(new Phrase("."))
            {
                Border = 0
            });
            tablaTotales.AddCell(new PdfPCell(new Phrase("."))
            {
                Border = 0
            });
            tablaTotales.AddCell(new PdfPCell(new Phrase("."))
            {
                Border = 0
            });
            tablaTotales.AddCell(new PdfPCell(new Phrase("."))
            {
                Border = 0
            });
            tablaTotales.AddCell(new PdfPCell(new Phrase("Neto a cobrar: ", fontNegra10))
            {
                BorderColor = grisClaro,
                HorizontalAlignment = Element.ALIGN_RIGHT
            });
            tablaTotales.AddCell(new PdfPCell(new Phrase(liquidacion.GetImporteTotal().ToString(), fontNegra10Simple))
            {
                BorderColor = grisClaro,
            });

            doc.Add(tablaTotales);

            doc.Close();
            writer.Close();

            System.Diagnostics.Process.Start(Application.StartupPath + @"\Liquidacion.pdf");
        }

    }
}
