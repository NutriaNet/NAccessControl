using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NAccessControl.EFCore.Infrastructures.EntityFrameworks;

namespace NAccessControl.Test.Fixtures;

public class DatabaseFixture : IDisposable
{


    protected List<AccessControlDbContext> contexts = new();

    public AccessControlDbContext CreateDbContext()
    {
        var loggerFactory = LoggerFactory.Create(c => c.AddDebug());
        var options = new DbContextOptionsBuilder<AccessControlDbContext>()
            .EnableSensitiveDataLogging()
            .UseLoggerFactory(loggerFactory)
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;


        var dbContext = new AccessControlDbContext(options);

        contexts.Add(dbContext);

        return dbContext;
    }

    public void Dispose()
    {
        contexts.ForEach(context => context.Dispose());
    }
}
