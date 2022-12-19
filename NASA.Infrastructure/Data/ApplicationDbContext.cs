using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NASA.Infrastructure.Data.Configuration;

namespace NASA.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<string>, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new TeacherConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new CourseConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Course> Courses { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Teacher> Teachers { get; set; } = null!;

    }
}