using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliensOnEarth
{
   public class PlainTxtExport : ExportClass
    {
       IAlienOutPut IAO = new AlienOutPut();
      // bool success = false;
       public override void Export()
       {
           Console.WriteLine("Please check the selected format file at Path: C:\\AlienPLAINTXTOutPut.txt");
           //Console.ReadLine();
           using (StreamWriter writer = new StreamWriter("C:\\AlienPLAINTXTOutPut.txt"))
           {
               writer.AutoFlush = true;
               //writer.Write(AOI.AliensOutPut());
               Console.SetOut(writer);
               IAO.AliensOutPut();


               writer.Close();
               var standardOutput = new StreamWriter(Console.OpenStandardOutput());
               standardOutput.AutoFlush = true;
               Console.SetOut(standardOutput);
               //Console.ReadLine();
               //success = true;
               //writer.Flush();

               

           }
       }
    }
}
