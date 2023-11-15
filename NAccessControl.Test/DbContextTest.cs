using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NAccessControl.Domain.Model;
using NAccessControl.EFCore.Infrastructures.EntityFrameworks;

namespace NAccessControl.Test;

public class DbContextTest
{
    [Fact]
    public void TestDbContext()
    {

        var loggerFactory = LoggerFactory.Create(c => c.AddDebug());
        var options = new DbContextOptionsBuilder<AccessControlDbContext>()
            .EnableSensitiveDataLogging()
            .UseLoggerFactory(loggerFactory)
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;


        using var dbContext = new AccessControlDbContext(options);

        var userId = new UserId("1");
        var ownedResource = new OwnedResource()
        {
            UserId = userId
        };

        dbContext.OwnedResources.Add(ownedResource);
        dbContext.SaveChanges();

        var found = dbContext
            .OwnedResources
            .Single(or => or.UserId.GuidValueId == userId.GuidValueId);

        Assert.Equal(found.UserId, userId);
    }

    [Fact]
    public void TestUserIdIsEmpty()
    {
        var loggerFactory = LoggerFactory.Create(c => c.AddDebug());
        var options = new DbContextOptionsBuilder<AccessControlDbContext>()
            .EnableSensitiveDataLogging()
            .UseLoggerFactory(loggerFactory)
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;


        using var dbContext = new AccessControlDbContext(options);

        var userId = new UserId("1");
        var ownedResource = new OwnedResource()
        {
        };

        dbContext.OwnedResources.Add(ownedResource);
        dbContext.SaveChanges();

        var found = dbContext
            .OwnedResources
            .Single(or => or.Id == ownedResource.Id);

        Assert.Equal(1, ownedResource.Id);
    }
}
