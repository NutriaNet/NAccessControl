using Microsoft.EntityFrameworkCore;
using NAccessControl.Domain.Model;

namespace NAccessControl.EFCore.Infrastructures.EntityFrameworks;

public class AccessControlDbContext : DbContext
{
    public DbSet<OwnedResource> OwnedResources { get; set; }

    public AccessControlDbContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OwnedResource>()
           .Property(e => e.UserId)
           .HasConversion(
                v => v.ToInt(),
                v => new UserId(v)
            );
    }
}
