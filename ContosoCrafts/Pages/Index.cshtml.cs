using ContosoCrafts.Models;
using ContosoCrafts.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoCrafts.Pages {
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;
        private readonly JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFileProductService productService) {
            _logger = logger;
            ProductService = productService;
        }

        public void OnGet() {
            Products = ProductService.GetProducts();
        }
    }
}
