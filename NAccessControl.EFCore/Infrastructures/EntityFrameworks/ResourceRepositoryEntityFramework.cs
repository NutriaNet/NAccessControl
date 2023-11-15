using Microsoft.EntityFrameworkCore;
using NAccessControl.Domain.Model;

namespace NAccessControl.EFCore.Infrastructures.EntityFrameworks;

public class ResourceRepositoryEntityFramework : IResourceRepository
{
    protected readonly AccessControlDbContext dbContext;

    public ResourceRepositoryEntityFramework(AccessControlDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public void Add(Resource resource)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Resource>> FindAllResourceAsync() =>
        await dbContext
            .Resources
            .Include(r => r.Permissions)
            .ToListAsync();

    public IEnumerable<OwnedResource> FindOwnedResources(IUserId user)
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChangesAsync()
    {
        return dbContext.SaveChangesAsync();
    }
}
