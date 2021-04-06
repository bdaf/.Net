using FizzBuzz_Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz_Web.Data {
    public class FizzBuzzContext : DbContext{
        public FizzBuzzContext(DbContextOptions options) : base(options) {
        }

        public DbSet<FizzBuzz_Data> FizzBuzz_Data { get; set; }
    }
}
