using Microsoft.EntityFrameworkCore;
using PS3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS3.Data
{
    public class FizzBuzzContext : DbContext
    {
        public DbSet<FizzBuzz> FizzBuzzes { get; set; }
        public FizzBuzzContext(DbContextOptions options) : base(options) 
        { }
    }
}
