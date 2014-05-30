using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliensOnEarth
{
    public class AlienBloodColor : AliensClass
    {
        public override void Attribute(int temp)
        {
            bool success = false;
            string line = null;
            AlienValidatorInterface AVI = new AlienValidator();

            while (!success) //Loop to insert Alien's Blood Colour into an array of structure
            {
                Console.Write("Alien BloodColor: ");
                line = Console.ReadLine();
                if (AVI.IsStringValid(line)) //Checking the condition whether the entered values are alphabets or not at AlienValidator class
                {
                    AlienStruct.Al[temp].AlienBloodColor = line;
                    line = null;
                    success = true;
                }
                else
                {
                    Console.WriteLine("Please enter alphabets only");
                    success = false;
                    line = null;
                }
            }
            success = false;

        }
    }
}
