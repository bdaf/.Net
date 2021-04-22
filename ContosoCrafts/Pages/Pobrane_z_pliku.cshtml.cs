using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.Models;
using ContosoCrafts.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoCrafts.Pages
{
    public class Pobrane_z_plikuModel : PageModel
    {
        private readonly JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; set; }

        public Pobrane_z_plikuModel(JsonFileProductService productService) {
            ProductService = productService;
        }

        public void OnGet(){
            Products = ProductService.GetProducts();
        }
    }
}
