using Camplify.Data.Models;
using Camplify.Data.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camplify.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Photo> Photo { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Checklist> Checklist { get; set; }
        public DbSet<DemageCategory> DemageCategory { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Job> Job { get; set; }
        
    }
}
