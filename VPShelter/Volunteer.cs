using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
     class Volunteer:Employee
    {
        //fields
        private bool clockInStatus = false;
        private bool identificationShownStatus = false;
        private int hoursAvailable = 0;

        //properties

        public bool ClockInStatus
        {
            get { return this.clockInStatus; }
            set { this.clockInStatus = value; }
        }

        public bool IdentificationShownStatus
        {
            get { return this.identificationShownStatus; }
            set { this.identificationShownStatus = value; }
        }

        //methods
        public override bool ClockIn()
        {
            return false;
          
        }

        public override bool ShowID()
        {
            return this.identificationShownStatus;
        }

        public string FeedAllPets()
        {
            string value = "All pets have been fed.";
            return value;
        }

        public string WaterAllPets()
        {
            string value = "All pets have been watered.";
            return value;
        }









    }
}
