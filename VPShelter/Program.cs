using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean appRunState = true; //application run state control variable


            //string checkForExit = "null"; TBR

            do
            {

                int menuSelection = 0;
                int subMenuSelection = 0;

                // display UI


                do {
                    Console.WriteLine();
                    Console.WriteLine("Welcome to Vitual Pet Shelter. What employee type are you?");
                    Console.WriteLine();
                    Console.WriteLine("[1] Manager");
                    Console.WriteLine();
                    Console.WriteLine("[2] Volunteer");
                    Console.WriteLine();

                    //get resposnse menu response
                     menuSelection = int.Parse(Console.ReadLine());

                } while ((menuSelection < 1) || (menuSelection > 2)); //trap for invalid entry
                                                                      //process selection
                if (menuSelection == 1)// display manager sub menu
                {
                        
                    Console.WriteLine("Thank you for working at Virtual Pet Shelter!");
                    Console.WriteLine();
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine();
                    Console.WriteLine("[1] Adopt a pet");
                    Console.WriteLine();
                    Console.WriteLine("[2] Feed the pets");
                    Console.WriteLine();
                    Console.WriteLine("[3] Water the pets");
                    Console.WriteLine();
                    Console.WriteLine("[4] Play with a pet");
                    Console.WriteLine();
                    Console.WriteLine("[5] Pay the bills");
                    Console.WriteLine();
                    Console.WriteLine("[6] Quit");
                    Console.WriteLine();
                    // get response
                    subMenuSelection = int.Parse(Console.ReadLine());

                    if (subMenuSelection == 6)
                    {
                        appRunState = false; //exit program

                    }


                }

                if (menuSelection == 2) // display volunteer sub menu
                {
                    Console.WriteLine("Thank you for volunteering at Virtual Pet Shelter!");
                    Console.WriteLine();


                    // Display pet status ///maybe call Prop/Meth


                    Console.WriteLine("What would you like to do next?");
                    Console.WriteLine();
                    Console.WriteLine("[1] Feed the pets");
                    Console.WriteLine();
                    Console.WriteLine("[2] Water the pets");
                    Console.WriteLine();
                    Console.WriteLine("[3] Play with a pet");
                    Console.WriteLine();
                    Console.WriteLine("[4] Quit");
                    Console.WriteLine();

                    // get response
                    subMenuSelection = int.Parse(Console.ReadLine());
                    if (subMenuSelection == 4)
                    {
                        appRunState = false; //exit program

                    }



                }











                //if (subMenuSelection == 4)
                // {
                //     appRunState = false; //exit program

                //  }


                //// NO CODE BELOW HERE DANGER //// NO CODE BELOW HERE DANGER //// NO CODE BELOW HERE DANGER /// 

            } while (appRunState); //app run state loop




        }
    }
}
