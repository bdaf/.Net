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
        [MaxLength(50)]
        [Column(TypeName="varchar(50)")]
        public string Result { get; set; }
        public DateTime Date{ get; set; }

        internal void CountResult() {
            Result = "";
            if(Number % 3 == 0)
                Result += "Fizz";
            if(Number % 5 == 0)
                Result += "Buzz";
            if(Result == "")
                Result += "Liczba: " + Number + " nie spełnia kryteriów Fizz/Buzz";
            Date = DateTime.Now;
        }
        public static List<FizzBuzz_Data> ConvertToListFromJSON(string FizzBuzzJSON) {
            if(FizzBuzzJSON != null)
                return JsonConvert.DeserializeObject<List<FizzBuzz_Data>>(FizzBuzzJSON);
            else
                return new List<FizzBuzz_Data>();
        }
    }
}


