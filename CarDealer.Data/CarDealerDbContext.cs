using CarDealer.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Data
{
    public class CarDealerDbContext: DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Option> Option { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Data Source = AVG-188; Initial Catalog = CarDealer; Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>().HasOne(i => i.Customer)
                                          .WithMany(c => c.Invoices)
                                          .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<InvoiceOption>().HasOne(io => io.Invoice)
                                                .WithMany(i => i.InvoiceOption)
                                                .HasForeignKey(io => io.InvoiceId);
            modelBuilder.Entity<InvoiceOption>().HasOne(io => io.Option)
                                                .WithMany(o => o.InvoiceOptions)
                                                .HasForeignKey(io => io.OptionId);
        }
    }
}
