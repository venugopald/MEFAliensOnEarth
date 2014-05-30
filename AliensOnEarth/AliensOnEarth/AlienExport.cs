using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliensOnEarth
{

    public interface IAlienExport
    {
        void ExportAlienDetails();

    }


    class AlienExport : IAlienExport
    {
        public  void ExportAlienDetails()
        {
            AlienValidatorInterface AVI = new AlienValidator();

            char ExportChk ;
            int ExportSelection;
            string line;

            bool success = false;
            
            try
            {

                while (!success)
                {
                    Console.WriteLine();
                    Console.Write("Would you like to export the details ? (Y/N) :");
                    ExportChk = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();


                    if (ExportChk == 'Y' || ExportChk == 'y')
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please specify the file format to be used to export (1 OR 2) ");
                        Console.WriteLine("1.   PLAIN TEXT");
                        Console.WriteLine("2.   PDF");
                        Console.WriteLine();
                        line = Console.ReadLine();

                        if (AVI.IsIntValid(line))
                        {
                            ExportSelection = int.Parse(line);
                        }
                        else
                        {
                            ExportSelection = 0;
                        }

                        switch (ExportSelection)
                        {
                            case 0: Console.WriteLine("Please enter digits only");
                                success = false;
                                break;

                            case 1:
                                ExportClass PlainTxt = new PlainTxtExport();
                                PlainTxt.Export();
                                
                               
                                   success = true;
                            

                                break;

                            case 2:

                                ExportClass PDF = new PDFExport();

                                PDF.Export();

                           
                                   success = true;
                            
                                break;

                            default: Console.WriteLine("Please enter valid input ");
                                success = false;

                                break;

                        }

                       
                    }
                    else if (ExportChk == 'N' || ExportChk == 'n')
                    {
                        //Console.WriteLine("Thank you for using the application, Take care !! ");
                        success = true;
                        //Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid input (Y/N) !!");
                        success = false;

                    }
                    
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}