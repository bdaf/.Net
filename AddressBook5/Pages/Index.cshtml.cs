using AddressBook5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook5.Pages {
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public Address Addr { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }
        public List<Address> Addresses { get; set; }


        public IndexModel(ILogger<IndexModel> logger) {
            _logger = logger;
        }

        public void OnGet() {
            if(string.IsNullOrWhiteSpace(Name)) {
                Name = "Default User";
            }
        }

        public IActionResult OnPost() {
            if(ModelState.IsValid) {
                var ListOfAddressesJSON = HttpContext.Session.GetString("List_Of_Addresses_Session");
                if(ListOfAddressesJSON == null)
                    Addresses = new List<Address>();
                else
                    Addresses = JsonConvert.DeserializeObject<List<Address>>(ListOfAddressesJSON);
                Addresses.Add(Addr);
                HttpContext.Session.SetString("List_Of_Addresses_Session", JsonConvert.SerializeObject(Addresses));
                return RedirectToPage("./AddressList");
            }
            return Page();
        }
    }
}
