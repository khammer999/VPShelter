using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class VirtualPet
    {  
        /// fields

        private string name = "null";
        private string description = "null";
        private int hunger = 10;
        private int thirst = 10;
        private int boredom = 10;
        

        // properties

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }
        
        public int Boredom
        {
            get { return this.boredom; }
            set { this.boredom = value; }
        }

        // Constructors

        public VirtualPet()
        {
            //default
        }

        public VirtualPet(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public VirtualPet(string name, string description, int hunger, int thirst, int boredom)
        {
            this.name = name;
            this.description = description;
            this.hunger = hunger;
            this.thirst = thirst;
            this.boredom = boredom;
        }

        
         //  Methods

        public void Food()
        {
            this.hunger--;
            this.thirst++;

        }
        public void Food(int food)
        {
            this.Hunger = food;
            this.Thirst = food;
        }

        public void Water()
        {
            this.thirst--;
            

        }
        public void Water(int water)
        {
            this.thirst = water;

        }

        public void PlayTime()
        {
            this.Boredom--;
            
        }

        









    }
}
