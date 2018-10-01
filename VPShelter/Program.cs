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

            //instantiate objects

            VirtualPetShelter myShelter = new VirtualPetShelter();
            Volunteer volunteerOne = new Volunteer();
            Manager managerOne = new Manager();
            Pet petOne = new Pet();
            Pet petTwo = new Pet();
            Pet petThree = new Pet();
            Pet petFour = new Pet();

            // set names and values.

            petOne.Name = "abbey";
            petOne.TypeOfPet = "Cat";
            petOne.Hunger = 10;
            petOne.Thirst = 10;
            petOne.Boredom = 10;

            petTwo.Name = "boston";
            petTwo.TypeOfPet = "Cat";
            petTwo.Hunger = 20;
            petTwo.Thirst = 20;
            petTwo.Boredom = 20;

            petThree.Name = "charlie";
            petThree.TypeOfPet = "Dog";
            petThree.Hunger = 30;
            petThree.Thirst = 30;
            petThree.Boredom = 30;

            petFour.Name = "dino";
            petFour.TypeOfPet = "Dog";
            petFour.Hunger = 40;
            petFour.Thirst = 40;
            petFour.Boredom = 40;



            do
            {   //begin run state loop

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
                    //display pet status
                    Console.WriteLine();
                    Console.WriteLine(" This is the status of your pets...");
                    Console.WriteLine();
                    Console.WriteLine("Name | Hunger | Thirst| Boredom");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine(petOne.Name+"   "+petOne.Hunger + "         " + petOne.Thirst + "         " + petOne.Boredom);
                    Console.WriteLine(petTwo.Name + "     " + petTwo.Hunger + "       " + petTwo.Thirst + "         " + petTwo.Boredom);
                    Console.WriteLine(petThree.Name + "    " + petThree.Hunger + "       " + petThree.Thirst + "         " + petThree.Boredom);
                    Console.WriteLine(petFour.Name + "    " + petFour.Hunger +"         " + petFour.Thirst + "         " + petFour.Boredom);
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

                    if (subMenuSelection == 2)
                    {   //change values
                        petOne.Hunger--;
                        petTwo.Hunger--;
                        petThree.Hunger--;
                        petFour.Hunger--;

                        //display menues

                        Console.WriteLine("Thank you for working at Virtual Pet Shelter!");
                        Console.WriteLine();
                        //display pet status
                        Console.WriteLine();
                        Console.WriteLine(" This is the status of your pets...");
                        Console.WriteLine();
                        Console.WriteLine("Name | Hunger | Thirst| Boredom");
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine(petOne.Name + "  " + petOne.Hunger + "  " + petOne.Thirst + "  " + petOne.Boredom);
                        Console.WriteLine(petTwo.Name + "    " + petTwo.Hunger + "       " + petTwo.Thirst + "  " + petTwo.Boredom);
                        Console.WriteLine(petThree.Name + "  " + petThree.Hunger + "  " + petThree.Thirst + "  " + petThree.Boredom);
                        Console.WriteLine(petFour.Name + "  " + petFour.Hunger + "  " + petFour.Thirst + "  " + petFour.Boredom);
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

                    }

                    if (subMenuSelection == 3)
                    {
                        //change values
                        petOne.Thirst--;
                        petTwo.Thirst--;
                        petThree.Thirst--;
                        petFour.Thirst--;

                        //display menu
                        Console.WriteLine("Thank you for working at Virtual Pet Shelter!");
                        Console.WriteLine();
                        //display pet status
                        Console.WriteLine();
                        Console.WriteLine(" This is the status of your pets...");
                        Console.WriteLine();
                        Console.WriteLine("Name | Hunger | Thirst| Boredom");
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine(petOne.Name + "    " + petOne.Hunger + "       " + petOne.Thirst + "       " + petOne.Boredom);
                        Console.WriteLine(petTwo.Name + "    " + petTwo.Hunger + "       " + petTwo.Thirst + "       " + petTwo.Boredom);
                        Console.WriteLine(petThree.Name + "    " + petThree.Hunger + "       " + petThree.Thirst + "       " + petThree.Boredom);
                        Console.WriteLine(petFour.Name + "    " + petFour.Hunger + "       " + petFour.Thirst + "       " + petFour.Boredom);
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

                    }
                    if (subMenuSelection == 4)
                    {
                        petOne.Boredom--;
                        petTwo.Boredom--;
                        petThree.Boredom--;
                        petFour.Boredom--;

                        Console.WriteLine("Thank you for working at Virtual Pet Shelter!");
                        Console.WriteLine();
                        //display pet status
                        Console.WriteLine();
                        Console.WriteLine(" This is the status of your pets...");
                        Console.WriteLine();
                        Console.WriteLine("Name | Hunger | Thirst| Boredom");
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine(petOne.Name + "    " + petOne.Hunger + "       " + petOne.Thirst + "       " + petOne.Boredom);
                        Console.WriteLine(petTwo.Name + "    " + petTwo.Hunger + "       " + petTwo.Thirst + "       " + petTwo.Boredom);
                        Console.WriteLine(petThree.Name + "    " + petThree.Hunger + "       " + petThree.Thirst + "       " + petThree.Boredom);
                        Console.WriteLine(petFour.Name + "    " + petFour.Hunger + "       " + petFour.Thirst + "       " + petFour.Boredom);
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
                    }

                    if (subMenuSelection == 5)
                    {
                        managerOne.PayTheBills();
                    }

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
