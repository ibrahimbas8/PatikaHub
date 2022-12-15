using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InvoiceManagementSystem.Models;

namespace InvoiceManagementSystem.Data
{
    public class InvoiceManagementSystemContext : DbContext
    {
        public InvoiceManagementSystemContext (DbContextOptions<InvoiceManagementSystemContext> options)
            : base(options)
        {
        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Dues> Dues { get; set; }
        public DbSet<ElectricityBill> ElectricityBills { get; set; }
        public DbSet<NaturalGasBill> NaturalGasBills { get; set; }
        public DbSet<Todo> Todoes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WaterBill> WaterBills { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Message> Messages { get; set; }


    }
}
