using EFDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFDemo.Data {
    public class PeopleContext : DbContext{

        public DbSet<Address> Address { get; set; }
        public DbSet<Person> Person { get; set; }

        public PeopleContext(DbContextOptions options) : base(options) {
        }
    }
}
