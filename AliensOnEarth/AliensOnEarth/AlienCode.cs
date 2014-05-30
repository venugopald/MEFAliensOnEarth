using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliensOnEarth
{
    public class AlienCode : AliensClass
    {
        public override void Attribute(int temp)
        {
            bool success = false;
            string line = null;
            AlienValidatorInterface AVI = new AlienValidator();
            
            
            while (!success) //Loop to insert Alien's Code into an arrays of structure
            {
                Console.Write("Alien Code: ");
                line = Console.ReadLine();


                if (AVI.IsLetterOrDigitValid(line)) //Checking the condition whether the entered value is digit or alphabet at AlienValidator class
                {
                   AlienStruct.Al[temp].AlienCode = line;
                    line = null;
                    success = true;
                }
                else
                {
                    Console.WriteLine("Please enter either digits or alphabets only");
                    success = false;
                }
            }
            success = false;

        }
    }
}
