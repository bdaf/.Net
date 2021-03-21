using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz_Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace FizzBuzz_Web.Pages
{
    public class RecentlySearchedModel : PageModel {
        public List<FizzBuzz_Data> FizzBuzzes { get; set; }
   
        public void OnGet()
        {
            var FizzBuzzJSON = HttpContext.Session.GetString("FizzBuzz_Session");
            FizzBuzzes = FizzBuzz_Data.ConvertToListFromJSON(FizzBuzzJSON);
            FizzBuzzes.Reverse();
        }
    }
}
