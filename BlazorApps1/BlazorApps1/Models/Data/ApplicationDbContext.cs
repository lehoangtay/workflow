using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlazorApps1.Models;

namespace BlazorApps1.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Semesters> Semesters { get; set; } = default!;
        public DbSet<Departments> Departments { get; set; } = default!;
        public DbSet<Majors> Majors { get; set; } = default!;
        public DbSet<Subjects> Subjects { get; set; } = default!;
        public DbSet<Courses> Courses { get; set; } = default!;
        public DbSet<ApplicationUser> ApplicationUser { get; set; } = default!;
    }
}
