using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FizzBuzz_Web.Data;
using FizzBuzz_Web.Models;
using Microsoft.AspNetCore.Authorization;
using FizzBuzz_Web.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace FizzBuzz_Web.Pages.RecentFromDatabase
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly FizzBuzz_Web.Data.FizzBuzzContext _context;
        private readonly UserManager<FizzBuzz_User> _userManager;

        public DetailsModel(FizzBuzz_Web.Data.FizzBuzzContext context, UserManager<FizzBuzz_User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public FizzBuzz_Data FizzBuzz_Data { get; set; }
        public string Author;
        public string UserName;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) {
                return NotFound();
            }

            FizzBuzz_Data = await _context.FizzBuzz_Data.FirstOrDefaultAsync(m => m.Id == id);

            if (FizzBuzz_Data == null) {
                return NotFound();
            }

            UserName = _userManager.GetUserName(User);

            Author = FizzBuzz_Data.Author;
            if(Author == null) {
                Author = "";
            }

            return Page();
        }
    }
}
