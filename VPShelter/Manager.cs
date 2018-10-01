using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Manager:Employee
    {

        // fields 

        double salary = 0;

        // property

        public double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }


        //methods

        public override bool ShowID()
        {
            return false;
        }

        public override bool ClockIn()
        {
            return false;
        }

        public void AdoptAPet()
        {
            Console.WriteLine("Pets avalable for adoption:");
            Console.WriteLine();
            Console.WriteLine("for ");
        }

        public void PayTheBills()
        {
            Console.WriteLine("The Bills have been paid");
            Console.WriteLine();

        }




    }
}
