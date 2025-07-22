using Microsoft.EntityFrameworkCore;
using JobTracker.Models; // or your actual model namespace

namespace JobTracker.Data; // <-- make sure this matches

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<JobApplication> JobApplications { get; set; }
}
