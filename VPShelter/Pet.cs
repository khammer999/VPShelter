using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Pet:VirtualPet
    {
        // derived from virtual pet
        // fields
        private string typeOfPet = "null";
        private string petsSpecificDiet = "null";


        //properties

        public string TypeOfPet
        {
            get { return this.typeOfPet; }
            set { this.typeOfPet = value;}
        }

        public string PetSpecificDiet
        {
            get { return this.petsSpecificDiet; }
            set { this.petsSpecificDiet = value;}
        }


        

    }
}
