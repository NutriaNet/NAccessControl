using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NAccessControl.Domain.Model;
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

    public IEnumerable<Resource> CreateContractTableResource()
    {
        var read = new Permission("Read", "Read");
        var edit = new Permission("Edit", "Edit");
        var readData = new Permission("ReadData", "Read data");
        var editData = new Permission("EditData", "Edit data");

        var allTablePermissions = new List<Permission>() { read, edit, readData, editData };

        var contract = new Resource("ContractTable", "Contract", allTablePermissions);
        var name = new Resource("NameColumn", "Contract name", allTablePermissions);
        contract.AddChild(name);

        return new Resource[] { contract, name };
    }

    public void Dispose()
    {
        contexts.ForEach(context => context.Dispose());
    }
}
