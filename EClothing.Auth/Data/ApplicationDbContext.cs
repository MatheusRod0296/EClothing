using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EClothing.Auth.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace EClothing.Auth.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public IConfiguration Configuration { get; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<IdentityUserClaim<int>>().Property(c => c.Id).UseSqlServerIdentityColumn();
            

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                x => x.MigrationsHistoryTable("__EFMigrationsHistoryAspIdentity", "dbo"));
    }
}
