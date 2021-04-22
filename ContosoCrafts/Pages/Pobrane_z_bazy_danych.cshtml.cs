using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.Data;
using ContosoCrafts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoCrafts.Pages
{
    public class Pobrane_z_bazy_danychModel : PageModel
    {
        public readonly ManufactureContext Context;
        public List<Product> Products { get; set; }

        public Pobrane_z_bazy_danychModel(ManufactureContext context) {
            Context = context;
        }

        public void OnGet()
        {   /* Taking last 10 from database */
            Products = Context.Product.Take(10).ToList();
        }
    }
}
