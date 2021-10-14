using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlueCodingTest.Models;

namespace BlueCodingTest.Data
{
    public class BlueCodingTestContext : DbContext
    {
        public BlueCodingTestContext (DbContextOptions<BlueCodingTestContext> options)
            : base(options)
        {
        }

        public DbSet<BlueCodingTest.Models.Food> Food { get; set; }
    }
}
