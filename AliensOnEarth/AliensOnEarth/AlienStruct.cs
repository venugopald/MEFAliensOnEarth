using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliensOnEarth
{
    class AlienStruct
    {

        public static int Count;
        public static Alien[] Al;
        

        public struct Alien
        {
            public string Code;
            public string Name;
            public string BloodColor;
            public int NoOfAntennas;
            public int NoOfLegs;
            public string HomePlanet;

            /* Stores Code value into a Code field */
            public string AlienCode
            {
                get
                {
                    return Code;
                }
                set
                {
                    if (value != null)
                        Code = value;
                }
            }

            /* Stores Name value into a Name field */
            public string AlienName
            {
                get
                {
                    return Name;
                }
                set
                {
                    if (value != null)
                        Name = value;
                }
            }

            /* Stores BloodColor value into a BloodColor field */
            public string AlienBloodColor
            {
                get
                {
                    return BloodColor;
                }
                set
                {
                    if (value != null)
                        BloodColor = value;
                }
            }

            /* Stores NoOfAntennas value into a NoOfAntennas field */
            public int AlienNoOfAntennas
            {
                get
                {
                    return NoOfAntennas;
                }
                set
                {
                    if (value >= 0)
                        NoOfAntennas = value;
                }
            }

            /* Stores NoOfLegs value into a NoOfLegs field */
            public int AlienNoOfLegs
            {
                get
                {
                    return NoOfLegs;
                }
                set
                {
                    if (value >= 0)
                        NoOfLegs = value;
                }
            }

            /* Stores HomePlanet value into a HomePlanet field */
            public string AlienHomePlanet
            {
                get
                {
                    return HomePlanet;
                }
                set
                {
                    if (value != null)
                        HomePlanet = value;
                }
            }


            /* Method to output the entered details */
            public void DisplayAlienDetails()
            {
                Console.Write(" {0,2} {1,5} {2,8} {3,10} {4,12} {5,12} ", Code, Name, BloodColor, NoOfAntennas, NoOfLegs, HomePlanet);

            }


        };




    }
}
