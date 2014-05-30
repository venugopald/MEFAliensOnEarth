using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using SharedLibrary;

namespace AliensOnEarth
{
     [Export(typeof(IPlugin))]
    public class AliensMainClass:IPlugin
    {

        static bool success = false;
        static NoOfAliens NOA = null;
        static AlienInput AI = null;
       
        static IAlienOutPut IAO = null;
        static IAlienExport IAE = null;
        static AliensMainClass MC = null;
        static int answer = 0;


        private void QuestionSet()
        {
            Console.WriteLine();
            Console.WriteLine("What do you want to do ?");
            Console.WriteLine();
            Console.WriteLine("1. ADD Aliens");
            Console.WriteLine("2. DISPLAY Aliens");
            Console.WriteLine("3. EXPORT Aliens");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            Console.Write("Your Selection : ");

            answer = int.Parse(Console.ReadLine());

        }

        static void Main(string[] args)
        {
            AliensMainClass AMC = new AliensMainClass();
            AMC.AliensMainMethod();
        }

       
        public void AliensMainMethod()
        {

            NOA = new NoOfAliens();
            AI = new AlienInput();
          
            IAO = new AlienOutPut();
            IAE = new AlienExport();
            MC = new AliensMainClass();



            Console.Title = "AliensDatabase";
            Console.WriteLine("*****************");
            Console.WriteLine("Welcome Aliens !!");
            Console.WriteLine("*****************");
            Console.WriteLine();



            do
            {

                MC.QuestionSet();

                switch (answer)
                {
                    case 1:    /* NoOfAliensToBeEntered() method is of class NoOfAliens is called to get the count on number of Alien's details to be entered at a time. */
                        NOA.NoOfAliensToBeEntered();
                        Console.WriteLine();

                        Console.WriteLine("Please fill out the following details.");

                        /* AliensInput() method of  class AlienInput is called to input the details entered by the user into the array of structure. */
                        AI.AliensInput();
                        Console.WriteLine();


                        break;

                    case 2:

                        if (AlienStruct.Count != 0)
                        {
                            IAO.AliensOutPut();
                            Console.WriteLine();

                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Before displaying you got it enter the details !!");
                            Console.ReadLine();
                            Console.WriteLine();

                        }

                        break;

                    case 3:

                        if (AlienStruct.Count != 0)
                        {
                            /* AlienReviewandExport() method of class AlienReview is called to give an option to the user to review the data entered before exporting
                                and allowing user to select the required file format to export the entered data into. */
                            IAE.ExportAlienDetails();
                            //Console.WriteLine();


                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Before exporting you got it enter the details !!");
                            Console.WriteLine();

                        }

                        break;

                    case 4:
                        success = true;
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Please enter valid entry");
                        Console.WriteLine();
                        break;

                }

                answer = 0;

            } while (!success);


        }

    }

}

   

    
    


