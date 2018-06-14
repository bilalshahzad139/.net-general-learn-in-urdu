using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PdfTesterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var physicalPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            MyPdfHelper.PdfHelper.GeneratePdfTesting(physicalPath);
        }
    }
}
