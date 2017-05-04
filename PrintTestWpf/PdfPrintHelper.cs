using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PrintTestWpf
{
    class PdfPrintHelper : PrintHelper
    {
        public override void Print(string printer, string file)
        {
            StreamInfo stream = GetStream(file);
            PdfDocument doc = new PdfDocument();
            doc.LoadFromStream(stream.Stream);
            doc.PrinterName = printer;
            doc.PrintDocument.Print();

            stream.Stream.Close();
        }
    }
}
