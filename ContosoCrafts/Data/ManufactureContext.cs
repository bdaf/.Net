using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ContosoCrafts.Data {
    public class ManufactureContext : DbContext {
        public DbSet<Product> Product { get; set; }

        public ManufactureContext(DbContextOptions options) : base(options) {
        }
    }
}
