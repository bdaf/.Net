using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddressBook5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace AddressBook5.Pages
{
    public class AddressListModel : PageModel {
        public Address Addr { get; set; }
        public List<Address> Addresses { get; set; }
        public void OnGet(){
            var ListOfAddressesJSON = HttpContext.Session.GetString("List_Of_Addresses_Session");
            if(ListOfAddressesJSON != null)
                Addresses = JsonConvert.DeserializeObject<List<Address>>(ListOfAddressesJSON);
            else
                Addresses = new List<Address>();
        }
    }
}
