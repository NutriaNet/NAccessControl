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
        dbContext.Resources.Add(resource);
    }

    public void AddRange(IEnumerable<Resource> resources) => dbContext.Resources.AddRange(resources);

    public async Task<IEnumerable<Resource>> FindAllResourcesAsync() =>
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
