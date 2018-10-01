using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    abstract class Employee
    {
        // fields
        private string employeeID = "null";
       
        //properties
        public string EmployeeID
        {
            get { return this.employeeID; }
            set { this.employeeID = value; }
        }

        //Constructor
        public Employee()
        {
            //default
        }

        // methods

        public abstract bool ClockIn();

        public abstract bool ShowID();

        




    }
}
