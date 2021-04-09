using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoMapper01.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }

        
        [Display(Name="Full Name")]
        public string FullName { get; set; }

        public string LastName { get; set; }
        [Display(Name = "Country")]

        public string AddressCountry { get; set; }
        public string Email { get; set; }
    }
}