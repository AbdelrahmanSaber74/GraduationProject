﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IdentityManagerServerApi.Models;

namespace IdentityManagerServerApi.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        // Your additional properties...

        private readonly string connectionString;

        public AppDbContext()
        {
            connectionString = "Server=abdo; Database=GraduationProject; Trusted_Connection=True; Trust Server Certificate=True;";
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

      
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Patient> Patients { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Your additional model configurations...
        }
    }
}