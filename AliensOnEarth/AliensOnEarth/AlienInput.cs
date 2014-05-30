using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliensOnEarth
{
    class AlienInput : AlienStruct
    {

        public void AliensInput()
        {
            
            AliensClass AC = new AlienCode();
            AliensClass AN=new AlienName();
            AliensClass ABC=new AlienBloodColor();
            AliensClass ANA=new AlienNoOfAntennas();
            AliensClass ANL=new AlienNoOfLegs();
            AliensClass AHP=new AlienHomePlanet();
            

            for (int i = 0; i < Count; i++)  //Loop to insert Alien details into arrays of structure
            {
                Console.WriteLine();
                
                Console.WriteLine("Alien No. {0}", i+1);
                Console.WriteLine("---------------------");


                AC.Attribute(i);
                AN.Attribute(i);
                ABC.Attribute(i);
                ANA.Attribute(i);
                ANL.Attribute(i);
                AHP.Attribute(i);


               
            }

            Console.WriteLine();
            Console.WriteLine("Thanks for entering the details.");
            Console.WriteLine();


        }
    }
}
