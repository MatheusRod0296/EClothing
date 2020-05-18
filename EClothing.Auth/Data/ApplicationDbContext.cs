using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EClothing.Auth.Models;

namespace EClothing.Auth.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlServer("server=127.0.0.1,1433; database=EclothingAuth; User ID=SA; Password=1q2w3e4r!@#$",
                x => x.MigrationsHistoryTable("__EFMigrationsHistoryAspIdentity", "dbo"));
    }
}
