using System;
using System.Collections.Generic;
using System.Text;

namespace Multithreading
{
   public class EmployeDetails
    {

        public int EmpID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int pincode { get; set; }
        public EmployeDetails(int EmpID,string Name,string City, int pincode)
        {
            this.EmpID = EmpID;
            this.Name = Name;
            this.City = City;
            this.pincode = pincode;
        }
    }
}
