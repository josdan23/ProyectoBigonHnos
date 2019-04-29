using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.services
{
    public class ImpresionPdfServices
    {
        public static ImpresionPdfServices instance { get; set; }

        public static ImpresionPdfServices getInstance()
        {
            if (instance == null)
            {
                instance = new ImpresionPdfServices();
            }

            return instance;
        }

        public void ejecutarPdf(String path)
        {
            System.Diagnostics.Process.Start(@"path");
        }

        public void craerPdf(String path)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\Daniel\Desktop\Hola.pdf", FileMode.Create));
            doc.Open();
        }


    }
}
