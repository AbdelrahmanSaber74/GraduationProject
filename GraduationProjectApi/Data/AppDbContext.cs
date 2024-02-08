﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IdentityManagerServerApi.Models;

namespace IdentityManagerServerApi.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {

        private readonly string connectionString;

        public AppDbContext()
        {
            connectionString = "Data Source=SQL8005.site4now.net;Initial Catalog=db_aa4b69_graduationproject;User Id=db_aa4b69_graduationproject_admin;Password=Data Source=SQL8005.site4now.net;Initial Catalog=db_aa4b69_graduationproject;User Id=db_aa4b69_graduationproject_admin;Password=QxaN@qT23wLUL7t";
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
