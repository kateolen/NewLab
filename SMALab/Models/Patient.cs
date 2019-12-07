using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMALab.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public Address Address { get; set; } // Navigational Property
        public int AddressId { get; set; } // A foreign key


    }
}