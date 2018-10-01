using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class VirtualPetShelter
    {

        List<string> petNameList = new List<string>() { "abby", "boston", "charlie", "dino" };

        List<string> employeeNameList = new List<string>() { "Pete", "Bob", "Joe", "Mike"};

        

        private string employeeOneName;
        private string employeeTwoName;
        private string employeeThreeName;
        private string employeeFourName;
        private string petOneName;
        private string petTwoName;
        private string petThreeName;
        private string petFourName;

        public string EmployeeOnetName
        {
            get { return this.employeeOneName;}
            set { this.employeeOneName = value; }
        }

        public string EmployeeTwotName
        {
            get { return this.employeeTwoName; }
            set { this.employeeTwoName = value; }
        }

        public string EmployeeThreetName
        {
            get { return this.employeeThreeName; }
            set { this.employeeThreeName = value; }
        }

        public string EmployeeFourName
        {
            get { return this.employeeFourName; }
            set { this.employeeFourName = value; }
        }

        public string PetOneName
        {
            get { return this.petOneName; }
            set { this.petOneName = value; }
        }
        public string PetTwoName
        {
            get { return this.petTwoName; }
            set { this.petTwoName = value; }
        }
        public string PetThreeName
        {
            get { return this.petThreeName; }
            set { this.petThreeName = value; }
        }
        public string PetFourName
        {
            get { return this.petFourName; }
            set { this.petFourName = value; }
        }






    }
}
