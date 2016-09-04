using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XNAConverter;

namespace XNAFormatterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                return;
            }
            XNBBuilder xnbBuilder = new XNBBuilder("Windows", "Reach", false);
            bool buildStatus = false;
            string[] fileNames = new string[] { args[0] };
            xnbBuilder.PackageContent(fileNames, args[1], false, Path.GetDirectoryName(fileNames[0]), out buildStatus);
            try
            {
                File.Delete("ContentPipeline.xml");
            }
            catch
            {
            }
        }
    }
}
