using BlueCodingTest.AccesData.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueCodingTest.AccesData
{
    public class BlueCodingTestContext : DbContext
    {
        public BlueCodingTestContext(DbContextOptions<BlueCodingTestContext> options)
            : base(options)
        {
        }

        public DbSet<Food> Food { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
