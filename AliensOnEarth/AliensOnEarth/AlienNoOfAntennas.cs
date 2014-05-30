using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliensOnEarth
{
    public class AlienNoOfAntennas : AliensClass
    {
       
        
        public  override void Attribute(int temp)
        {
            
            bool success = false;
            string line = null;
            AlienValidatorInterface AVI = new AlienValidator();

            //Loop to insert Alien's No of antennas Code into an array of structure
            while (!success)
            {
                Console.Write("Alien NoOfAntennas: ");
                line = Console.ReadLine();
                if (AVI.IsIntValid(line)) //Checking the condition whether the entered values are digits or not at AlienValidator class
                {
                    AlienStruct.Al[temp].AlienNoOfAntennas = int.Parse(line);
                    line = null;
                    success = true;
                }
                else
                {
                    Console.WriteLine("Please enter digits only");
                    success = false;
                    line = null;
                }
            }
            success = false;

        }
    }
}
