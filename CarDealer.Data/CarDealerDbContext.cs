using CarDealer.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Data
{
    public class CarDealerDbContext: DbContext
    {
        public DbSet<CarModel> Cars { get; set; }
        public DbSet<InvoiceModel> Invoices { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<AddressModel> Addresses { get; set; }
        public DbSet<OptionModel> Option { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Data Source = AVG-188; Initial Catalog = CarDealer; Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InvoiceModel>().HasOne(i => i.Customer)
                                          .WithMany(c => c.Invoices)
                                          .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<InvoiceOptionModel>().HasOne(io => io.Invoice)
                                                .WithMany(i => i.InvoiceOption)
                                                .HasForeignKey(io => io.InvoiceId);
            modelBuilder.Entity<InvoiceOptionModel>().HasOne(io => io.Option)
                                                .WithMany(o => o.InvoiceOptions)
                                                .HasForeignKey(io => io.OptionId);
        }
    }
}
