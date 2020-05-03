using Microsoft.EntityFrameworkCore;
using ModelCrm.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCrm.CrmDbContext
{
    public class CrmAppDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        private readonly string connectionString =
            "Server =localhost; " +
            "Database =crm; " +
            "User Id =sa; " +
            "Password =admin!@#123;";

        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
