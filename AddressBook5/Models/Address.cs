using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook5.Models {
    public class Address {
        [Display(Name = "My favourite street"), Required(ErrorMessage = "Please provide a valid street.")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Please provide a number too.")]
        public string Number { get; set; }
        [Display(Name = "My ZipCode!"), Required(ErrorMessage = "Yes, provide ZipCode either. ")]
        public string ZipCode { get; set; }
        [Display(Name = "My Big (or not) City!")]
        [StringLength(60,MinimumLength = 3), Required(ErrorMessage = "Even if it's small, provide it!")]
        public string City { get; set; }
    }
}
