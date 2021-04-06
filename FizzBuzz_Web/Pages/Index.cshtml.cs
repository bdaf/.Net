using FizzBuzz_Web.Data;
using FizzBuzz_Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz_Web.Pages {
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;
        private readonly FizzBuzzContext _context;

        [BindProperty]
        public FizzBuzz_Data FizzBuzz { get; set; }
        public List<FizzBuzz_Data> FizzBuzzes { get; set; }
        public IndexModel(ILogger<IndexModel> logger, FizzBuzzContext context) {
            _logger = logger;
            _context = context;
        }

        public void OnPost() {
            if(ModelState.IsValid) {
                var FizzBuzzJSON = HttpContext.Session.GetString("FizzBuzz_Session");
                FizzBuzzes = FizzBuzz_Data.ConvertToListFromJSON(FizzBuzzJSON);
                FizzBuzz.CountResult();
                FizzBuzzes.Add(FizzBuzz);
                HttpContext.Session.SetString("FizzBuzz_Session", JsonConvert.SerializeObject(FizzBuzzes));

                _context.FizzBuzz_Data.Add(FizzBuzz);
                _context.SaveChanges();
            }
        }
    }
}
