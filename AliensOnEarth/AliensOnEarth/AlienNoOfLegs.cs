using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliensOnEarth
{
    public class AlienNoOfLegs : AliensClass
    {
        AlienStruct AS = new AlienStruct();

        public override void Attribute(int temp)
        {
            bool success = false;
            string line = null;
            AlienValidatorInterface AVI = new AlienValidator();

            //Loop to insert Alien's No of legs into an array of structure
            while (!success)
            {
                Console.Write("Alien NoOfLegs: ");
                line = Console.ReadLine();
                if (AVI.IsIntValid(line)) //Checking the condition whether the entered values are digits or not at AlienValidator class
                {
                    AlienStruct.Al[temp].AlienNoOfLegs = int.Parse(line);
                    line = null;
                    success = true;
                }
                else
                {
                    Console.WriteLine("Please enter digits only");
                    line = null;
                    success = false;
                }
            }
            success = false;

        }
    }
}
