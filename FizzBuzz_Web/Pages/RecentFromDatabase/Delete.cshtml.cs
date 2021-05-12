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
using Microsoft.AspNetCore.Identity;
using FizzBuzz_Web.Areas.Identity.Data;

namespace FizzBuzz_Web.Pages.RecentFromDatabase
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly FizzBuzz_Web.Data.FizzBuzzContext _context;

        private readonly UserManager<FizzBuzz_User> _userManager;

        public DeleteModel(FizzBuzz_Web.Data.FizzBuzzContext context, UserManager<FizzBuzz_User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [BindProperty]
        public FizzBuzz_Data FizzBuzz_Data { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FizzBuzz_Data = await _context.FizzBuzz_Data.FirstOrDefaultAsync(m => m.Id == id);

            if (FizzBuzz_Data == null || FizzBuzz_Data.Author==null)
            {
                return NotFound();
            }
            if(!FizzBuzz_Data.Author.Equals(_userManager.GetUserName(User))) {
                return Forbid();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FizzBuzz_Data = await _context.FizzBuzz_Data.FindAsync(id);

            if (FizzBuzz_Data != null)
            {
                _context.FizzBuzz_Data.Remove(FizzBuzz_Data);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
