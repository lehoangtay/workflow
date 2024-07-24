using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlazorApps1.Models;

namespace BlazorApps1.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<BlazorApps1.Models.Semesters> Semesters { get; set; } = default!;
        public DbSet<BlazorApps1.Models.Departments> Department { get; set; } = default!;
    }
}
