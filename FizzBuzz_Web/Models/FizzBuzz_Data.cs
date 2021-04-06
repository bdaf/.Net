using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz_Web.Models {
    public class FizzBuzz_Data {
        public int Id { get; set; }
        [Required]
        [Range(1,1000)]
        [Display(Name ="Number To Search")]
        public int Number { get; set; }
        [MaxLength(8)]
        [Column(TypeName="varchar(8)")]
        public string Result { get; set; }
        public DateTime Date{ get; set; }


    }
}


