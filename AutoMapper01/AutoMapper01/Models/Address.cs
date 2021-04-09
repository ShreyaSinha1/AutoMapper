using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapper01.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
    }
}