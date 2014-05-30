using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliensOnEarth
{
    public class PDFExport:ExportClass
    {
        IAlienOutPut IAO = new AlienOutPut();
        //bool success = false;
        public override void Export()
        {
            Console.WriteLine("Please check the selected format file at Path: C:\\AlienPDFOutPut.pdf");

            using (StreamWriter writer = new StreamWriter("C:\\AlienPDFOutPut.pdf"))
            {
                Console.SetOut(writer);

                IAO.AliensOutPut();

                writer.Close();
                var standardOutput = new StreamWriter(Console.OpenStandardOutput());
                standardOutput.AutoFlush = true;
                Console.SetOut(standardOutput); 

                //success = true;
                //writer.Flush();
               // Console.ReadLine();

            }
        }
    }
}
