using Microsoft.EntityFrameworkCore;
using NAccessControl.Domain.Model;
using NAccessControl.EFCore.Infrastructures.EntityFrameworks;

namespace NAccessControl.Test;

public class DbContextTest
{
    [Fact]
    public void TestDbContext()
    {
        var options = new DbContextOptionsBuilder<AccessControlDbContext>()
        .UseInMemoryDatabase(databaseName: "TestDatabase")
        .Options;

        using var dbContext = new AccessControlDbContext(options);

        var ownedResource = new OwnedResource();
        dbContext.OwnedResources.Add(ownedResource);
        dbContext.SaveChanges();

        var found = dbContext.OwnedResources.ToList();
    }
}
