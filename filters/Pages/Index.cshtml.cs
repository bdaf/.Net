using filters.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filters.Pages {
    [CustomFilterAttributes]
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty(SupportsGet=true)]
        public int testVariable { get; set; }
        public IndexModel(ILogger<IndexModel> logger) {
            _logger = logger;
        }

        public void OnGet() {

        }
    }
}
