using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FizzBuzz_Web.Data;
using FizzBuzz_Web.Models;

namespace FizzBuzz_Web.Pages.RecentFromDatabase
{
    public class IndexModel : PageModel
    {
        private readonly FizzBuzz_Web.Data.FizzBuzzContext _context;

        public IndexModel(FizzBuzz_Web.Data.FizzBuzzContext context)
        {
            _context = context;
        }

        public IList<FizzBuzz_Data> FizzBuzz_Data { get;set; }

        public async Task OnGetAsync()
        {
            var Results = from p in _context.FizzBuzz_Data
                                       orderby p.Date descending
                                       select p;
            FizzBuzz_Data = await Results.Take(10).ToListAsync();
        }
    }
}
