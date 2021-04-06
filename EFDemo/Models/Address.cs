using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFDemo.Models {
    public class Address {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Street { get; set; }
        [Required]
        [MaxLength(80)]
        public string City { get; set; }
        [Required]
        [MaxLength(6)]
        [Column(TypeName="varchar(6)")]
        public string ZipCode { get; set; }
        [Required]
        [MaxLength(80)]
        public string Country { get; set; }

    }
}
