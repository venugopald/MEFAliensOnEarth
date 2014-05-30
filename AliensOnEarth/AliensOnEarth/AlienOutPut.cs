using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliensOnEarth
{

    public interface IAlienOutPut
    {
        void AliensOutPut();
    }

    class AlienOutPut : IAlienOutPut
    {

        public void AliensOutPut()
        {
            Console.WriteLine("Entered details are as follows :");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Code  Name  BloodColor  NoOfAntennas  NoOfLegs  HomePlanet");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();

            for (int i = 0; i < AlienStruct.Count; i++)
            {
                AlienStruct.Al[i].DisplayAlienDetails();
                Console.WriteLine();
            }
            //Console.ReadLine();
        }
    }
}
