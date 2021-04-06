using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFDemo.Models {
    public class Person {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(70)]
        public string LastName { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
