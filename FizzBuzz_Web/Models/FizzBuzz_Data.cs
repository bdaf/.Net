using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz_Web.Models {
    public class FizzBuzz_Data {
        [Required(ErrorMessage = "Hmm you have to type something to search if you want to play, you know that?")]
        [Range(1,1000)]
        [Display(Name ="Number To Search")]
        public int Number { get; set; }
        public string Result { get; set; }
        public string Date { get; set; }

        internal void CountResult() {
            Result = "";
            if(Number % 3 == 0)
                Result += "Fizz";
            if(Number % 5 == 0)
                Result += "Buzz";
            if(Result == "")
                Result += Number;
        }
        public static List<FizzBuzz_Data> ConvertToListFromJSON(string FizzBuzzJSON) {
            if(FizzBuzzJSON != null)
                return JsonConvert.DeserializeObject<List<FizzBuzz_Data>>(FizzBuzzJSON);
            else
                return new List<FizzBuzz_Data>();
        }
    }
}


