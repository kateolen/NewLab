using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMALab.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public ICollection<string> State { get; set; }
        public string City { get; set; }

        public string ZipCode { get; set; }
    }
}