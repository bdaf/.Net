﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly FizzBuzz_Web.Data.FizzBuzzContext _context;

        public DetailsModel(FizzBuzz_Web.Data.FizzBuzzContext context)
        {
            _context = context;
        }

        public FizzBuzz_Data FizzBuzz_Data { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FizzBuzz_Data = await _context.FizzBuzz_Data.FirstOrDefaultAsync(m => m.Id == id);

            if (FizzBuzz_Data == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}